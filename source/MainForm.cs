using System;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XtractPro.Utils.JsonPath
{
    public partial class MainForm : Form
    {
        private const int SplitterOffset = 38;

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            splitContainer3.SplitterDistance = splitContainer1.Height / 2;
            splitContainer2.SplitterDistance = splitContainer3.SplitterDistance - SplitterOffset;

            var json = File.ReadAllText("files/books.json");
            txtJsonIn.Text = JToken.Parse(json).ToString(Formatting.Indented);

            foreach (var expr in QueryGenerator.PathExpressions)
                if (!string.IsNullOrEmpty(expr))
                    cboPath.Items.Add(expr);
            cboPath.SelectedIndex = 0;
        }

        private void cboPath_SelectedIndexChanged(object sender, EventArgs e) => FillResults();
        private void btnRun_Click(object sender, EventArgs e) => FillResults();
        private void FillResults()
        {
            txtJsonOut.Text = txtResult.Text = "";
            WriteStatus();

            // JSON Path from Newtonsoft
            var input = txtJsonIn.Text;
            var obj = JObject.Parse(input);
            var sb = new StringBuilder();
            var i = 0;
            try
            {
                var list = obj.SelectTokens(cboPath.Text);
                foreach (var elem in list)
                {
                    sb.AppendLine($"[{i++}] __________________");
                    sb.AppendLine();
                    sb.AppendLine(elem.ToString(Formatting.Indented));
                    sb.AppendLine();
                }
            }
            catch (Exception ex)
            {
                WriteStatus(ex.Message, true);
                return;
            }
            txtJsonOut.Text = sb.ToString();

            // generate and run Snowflake SQL query
            txtQuery.Text = QueryGenerator.GetQuery(cboPath.Text, input);
            var query = txtQuery.Text;
            if (string.IsNullOrEmpty(query) || query.Contains("[ERROR]"))
                return;

            // (try to) run SQL query
            DataTable table = null;
            try { table = QueryRunner.RunQuery(query); }
            catch (Exception ex)
            {
                WriteStatus(ex.Message, true);
                return;
            }

            // show query result
            sb = new StringBuilder();
            i = 0;
            foreach (DataRow row in table.Rows)
            {
                var json = row[0].ToString();
                sb.AppendLine($"[{i++}] __________________");
                sb.AppendLine();
                try { sb.AppendLine(JToken.Parse(json).ToString(Formatting.Indented)); }
                catch { sb.AppendLine(json); }
                sb.AppendLine();
            }
            txtResult.Text = sb.ToString();
        }

        private void WriteStatus(string msg = "", bool isError = false)
        {
            sbrMainLabel.Text = msg;
            sbrMainLabel.ForeColor = isError ? Color.Red : SystemColors.WindowText;
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
            => splitContainer3.SplitterDistance = splitContainer2.SplitterDistance + SplitterOffset;
        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
            => splitContainer2.SplitterDistance = splitContainer3.SplitterDistance - SplitterOffset;
    }
}
