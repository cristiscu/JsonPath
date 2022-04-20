using System;
using System.Data;
using Snowflake.Data.Client;

namespace XtractPro.Utils.JsonPath
{
    public static class QueryRunner
    {
        // run Snowflake SQL query an return a table with results
        public static DataTable RunQuery(string query)
        {
            // TODO: save a SNOWFLAKE_CONNSTR environment variable with the following content:
            // account=your-snowflake-account;user=your-username;password=your-password;
            var connStr = Environment.GetEnvironmentVariable("SNOWFLAKE_CONNSTR");

            using (var conn = new SnowflakeDbConnection())
            {
                conn.ConnectionString = connStr;
                conn.Open();
                using (var cmd = new SnowflakeDbCommand(conn))
                {
                    cmd.CommandText = query;
                    var table = new DataTable();
                    using (var adapter = new SnowflakeDbDataAdapter(cmd))
                        adapter.Fill(table);
                    conn.Close();
                    return table;
                }
            }
        }
    }
}
