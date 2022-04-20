using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace XtractPro.Utils.JsonPath
{
    public class QueryGenerator
    {
        // https://goessner.net/articles/JsonPath/
        public static readonly string[] PathExpressions = new[] {
            "$.store.book[1].author",       // author of second book from store

            "$..author",                    // all authors, at any level
            //"$..author[2]",               // the third author --> baaaad!
            "$..book[2]",                   // the third book
            "$..book[0,1]",                 // first two books
            "$..book[:2]",                  // first two books
            "$..book[-1:]",                 // last book

            "$.store.book[*].author",       // authors of all books from store
            "$..*",
            "$.store.*",                    // all things in the store (some books and a red bicycle)
            "$.store..price",               // price of everything in the store

            //"$..book[?(@.length - 1)]",
            "$..book[?(@.isbn)]",           // any book with isbn property
            "$..book[?(@.price < 10)]",     // any book with a price property which is < 10
        };

        public static string GetQuery(string expr, string json)
        {
            if (string.IsNullOrEmpty(expr))
                return "-- [ERROR] must use non-empty Path Expression!";
            if (string.IsNullOrEmpty(json))
                return "-- [ERROR] must use non-empty JSON!";

            // top CTE
            var sb = new StringBuilder();
            sb.AppendLine($"with src as (");
            sb.AppendLine($"  select parse_json('{json.Replace("'", "''")}') as v)");
            sb.AppendLine();

            var parts = Tokenize(expr);
            var path = string.Join('.', parts);

            var alias = GetAlias(parts[^1]);

            var j = path.IndexOf("..");
            if (j < 0 && path.StartsWith('.'))
            {
                j = 0;
                path = path[1..];
            }
            var sel = j < 0 ? $"v:{path}"
                : j == 0 ? "v"
                : $"v:{path[..j]}";

            if (j < 0)
            {
                sb.AppendLine($"select {sel} as {alias}");
                sb.AppendLine($"from src;");
            }
            else
            {
                var kpath = path[j..];
                var key = GetAlias(kpath, true);
                var index = GetIndex(kpath);

                if (index.Length == 0 || HasNumericIndex(Unbracket(index)))
                {
                    sb.AppendLine($"select elem.value{index} as {alias}");
                    sb.AppendLine($"from src,");
                    sb.AppendLine($"  lateral flatten(input => {sel}, recursive => true) as elem");
                    sb.AppendLine($"where elem.key = '{key}';");
                }
                else
                {
                    sb.AppendLine($", src2 as (");
                    sb.AppendLine($"  select elem.value as {alias}");
                    sb.AppendLine($"  from src,");
                    sb.AppendLine($"    lateral flatten(input => {sel}, recursive => true) as elem");
                    sb.AppendLine($"  where elem.key = '{key}')");
                    sb.AppendLine();

                    sb.AppendLine($"select elem.value as {alias}");
                    sb.AppendLine($"from src2,");
                    sb.AppendLine($"  lateral flatten(input => {alias}) as elem");

                    index = Unbracket(index);
                    var limitClause = GetLimitOffsetClause(index);
                    if (limitClause.Length > 0)
                        sb.AppendLine(limitClause);
                    else
                    {
                        index = Unphar(index[1..])[2..];
                        var identif = GetIdentifier(index);
                        var queue = (index.Length == identif.Length ? "" : index[identif.Length..]);
                        sb.AppendLine($"where elem.value:\"{identif}\"{(queue == "" ? " is not null" : queue)};");
                    }
                }
            }

            Debug.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private static string[] Tokenize(string expr)
        {
            var list = new List<string>();
            var isWhere = false;
            var item = "";

            var parts = expr.Split('.');
            foreach (var part in parts)
            {
                if (isWhere)
                {
                    item += $".{part}";
                    if (part.Contains(']'))
                    {
                        isWhere = false;
                        list.Add(Quote(item));
                        item = "";
                    }
                }
                else if (part.Contains('[') && !part.Contains(']'))
                {
                    item = part;
                    isWhere = true;
                }
                else if (part != "$" || list.Count > 0)
                    list.Add(Quote(part));
            }
            return list.ToArray();
        }

        private static string GetAlias(string s, bool unquote = false)
        {
            var i = s.IndexOf('[');
            if (i >= 0) s = s[..i];
            if (unquote) s = s[1..^1];
            return s;
        }
        private static string GetIndex(string s, bool unquote = false)
        {
            var i = s.IndexOf('[');
            if (i < 0) return "";
            s = s[i..];
            if (unquote) s = s[1..^1];
            return s;
        }
        private static string GetIdentifier(string s)
        {
            var i = 0;
            for (; i < s.Length; i++)
                if (!char.IsLetterOrDigit(s[i]))
                    break;
            return s[..i];
        }

        private static bool HasNumericIndex(string s) => int.TryParse(s.Trim(), out _);
        private static string Unbracket(string s) => s.TrimStart('[').TrimEnd(']');
        private static string Unquote(string s) => s.Trim('"');
        private static string Unphar(string s) => s.TrimStart('(').TrimEnd(')');
        private static string Quote(string s)
        {
            var i = s.IndexOf('[');
            var path = i < 0 ? s : s[0..i];
            path = path.Length == 0 ? "" : $"\"{path}\"";
            return path + (i < 0 ? "" : s[i..]);
        }

        private static string GetLimitOffsetClause(string index)
        {
            int limit, offset;
            if (index.Contains(','))
            {
                var pts = index.Split(',');
                _ = int.TryParse(pts[0], out offset);
                _ = int.TryParse(pts[1], out limit);
                limit -= offset - 1;
            }
            else if (index.Contains(':'))
            {
                var pts = index.Split(':');
                if (pts[0].Trim().Length == 0) offset = 0;
                else _ = int.TryParse(pts[0], out offset);
                if (pts[1].Trim().Length == 0) limit = -1;
                else _ = int.TryParse(pts[1], out limit);
            }
            else
                return "";
            
            var off = offset == 0 ? "" : $" offset {offset}";
            var lim = limit < 0 && offset <= 0 ? ""
                : offset > 0 ? $"limit null"
                : $"limit {limit}";

            return $"{lim}{off};";
        }
    }
}
