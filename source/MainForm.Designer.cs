
namespace XtractPro.Utils.JsonPath
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbrMain = new System.Windows.Forms.StatusStrip();
            this.sbrMainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabJsonIn = new System.Windows.Forms.TabControl();
            this.tabJsonInPage = new System.Windows.Forms.TabPage();
            this.txtJsonIn = new System.Windows.Forms.TextBox();
            this.tabJsonOut = new System.Windows.Forms.TabControl();
            this.tabJsonOutPage = new System.Windows.Forms.TabPage();
            this.txtJsonOut = new System.Windows.Forms.TextBox();
            this.tabQuery = new System.Windows.Forms.TabControl();
            this.tabQueryPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.tabResultPage = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboPath = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sbrMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabJsonIn.SuspendLayout();
            this.tabJsonInPage.SuspendLayout();
            this.tabJsonOut.SuspendLayout();
            this.tabJsonOutPage.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabQueryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.tabResultPage.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbrMain
            // 
            this.sbrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbrMainLabel});
            this.sbrMain.Location = new System.Drawing.Point(0, 521);
            this.sbrMain.Name = "sbrMain";
            this.sbrMain.Size = new System.Drawing.Size(1190, 26);
            this.sbrMain.TabIndex = 2;
            this.sbrMain.Text = "statusStrip1";
            // 
            // sbrMainLabel
            // 
            this.sbrMainLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbrMainLabel.Name = "sbrMainLabel";
            this.sbrMainLabel.Size = new System.Drawing.Size(1175, 20);
            this.sbrMainLabel.Spring = true;
            this.sbrMainLabel.Text = " ";
            this.sbrMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabQuery);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 490);
            this.splitContainer1.SplitterDistance = 601;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel1.Controls.Add(this.tabJsonIn);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.tabJsonOut);
            this.splitContainer3.Size = new System.Drawing.Size(601, 490);
            this.splitContainer3.SplitterDistance = 186;
            this.splitContainer3.TabIndex = 1;
            this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
            // 
            // tabJsonIn
            // 
            this.tabJsonIn.Controls.Add(this.tabJsonInPage);
            this.tabJsonIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabJsonIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJsonIn.Location = new System.Drawing.Point(0, 0);
            this.tabJsonIn.Multiline = true;
            this.tabJsonIn.Name = "tabJsonIn";
            this.tabJsonIn.SelectedIndex = 0;
            this.tabJsonIn.Size = new System.Drawing.Size(601, 186);
            this.tabJsonIn.TabIndex = 0;
            // 
            // tabJsonInPage
            // 
            this.tabJsonInPage.Controls.Add(this.txtJsonIn);
            this.tabJsonInPage.Location = new System.Drawing.Point(4, 29);
            this.tabJsonInPage.Name = "tabJsonInPage";
            this.tabJsonInPage.Size = new System.Drawing.Size(593, 153);
            this.tabJsonInPage.TabIndex = 1;
            this.tabJsonInPage.Text = "Input Data";
            this.tabJsonInPage.UseVisualStyleBackColor = true;
            // 
            // txtJsonIn
            // 
            this.txtJsonIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtJsonIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonIn.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJsonIn.Location = new System.Drawing.Point(0, 0);
            this.txtJsonIn.Multiline = true;
            this.txtJsonIn.Name = "txtJsonIn";
            this.txtJsonIn.ReadOnly = true;
            this.txtJsonIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonIn.Size = new System.Drawing.Size(593, 153);
            this.txtJsonIn.TabIndex = 1;
            this.txtJsonIn.WordWrap = false;
            // 
            // tabJsonOut
            // 
            this.tabJsonOut.Controls.Add(this.tabJsonOutPage);
            this.tabJsonOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJsonOut.Location = new System.Drawing.Point(0, 0);
            this.tabJsonOut.Name = "tabJsonOut";
            this.tabJsonOut.SelectedIndex = 0;
            this.tabJsonOut.Size = new System.Drawing.Size(601, 300);
            this.tabJsonOut.TabIndex = 2;
            // 
            // tabJsonOutPage
            // 
            this.tabJsonOutPage.Controls.Add(this.txtJsonOut);
            this.tabJsonOutPage.Location = new System.Drawing.Point(4, 29);
            this.tabJsonOutPage.Name = "tabJsonOutPage";
            this.tabJsonOutPage.Size = new System.Drawing.Size(593, 267);
            this.tabJsonOutPage.TabIndex = 1;
            this.tabJsonOutPage.Text = "Output Data";
            this.tabJsonOutPage.UseVisualStyleBackColor = true;
            // 
            // txtJsonOut
            // 
            this.txtJsonOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtJsonOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonOut.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJsonOut.Location = new System.Drawing.Point(0, 0);
            this.txtJsonOut.Multiline = true;
            this.txtJsonOut.Name = "txtJsonOut";
            this.txtJsonOut.ReadOnly = true;
            this.txtJsonOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonOut.Size = new System.Drawing.Size(593, 267);
            this.txtJsonOut.TabIndex = 11;
            this.txtJsonOut.WordWrap = false;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.tabQueryPage);
            this.tabQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuery.Location = new System.Drawing.Point(0, 0);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.SelectedIndex = 0;
            this.tabQuery.Size = new System.Drawing.Size(585, 490);
            this.tabQuery.TabIndex = 0;
            // 
            // tabQueryPage
            // 
            this.tabQueryPage.Controls.Add(this.splitContainer2);
            this.tabQueryPage.Location = new System.Drawing.Point(4, 29);
            this.tabQueryPage.Name = "tabQueryPage";
            this.tabQueryPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueryPage.Size = new System.Drawing.Size(577, 457);
            this.tabQueryPage.TabIndex = 0;
            this.tabQueryPage.Text = "Query";
            this.tabQueryPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtQuery);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.tabResult);
            this.splitContainer2.Size = new System.Drawing.Size(571, 451);
            this.splitContainer2.SplitterDistance = 154;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(571, 154);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.WordWrap = false;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.tabResultPage);
            this.tabResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResult.Location = new System.Drawing.Point(0, 0);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(571, 293);
            this.tabResult.TabIndex = 1;
            // 
            // tabResultPage
            // 
            this.tabResultPage.Controls.Add(this.txtResult);
            this.tabResultPage.Location = new System.Drawing.Point(4, 29);
            this.tabResultPage.Name = "tabResultPage";
            this.tabResultPage.Size = new System.Drawing.Size(563, 260);
            this.tabResultPage.TabIndex = 1;
            this.tabResultPage.Text = "Query Result";
            this.tabResultPage.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(563, 260);
            this.txtResult.TabIndex = 11;
            this.txtResult.WordWrap = false;
            // 
            // cboPath
            // 
            this.cboPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPath.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPath.FormattingEnabled = true;
            this.cboPath.Location = new System.Drawing.Point(120, 0);
            this.cboPath.Name = "cboPath";
            this.cboPath.Size = new System.Drawing.Size(976, 28);
            this.cboPath.TabIndex = 4;
            this.cboPath.SelectedIndexChanged += new System.EventHandler(this.cboPath_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRun.Location = new System.Drawing.Point(1096, 0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(94, 31);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboPath);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnRun);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1190, 31);
            this.pnlTop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path Expression:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.sbrMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "JSON Path for Snowflake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sbrMain.ResumeLayout(false);
            this.sbrMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabJsonIn.ResumeLayout(false);
            this.tabJsonInPage.ResumeLayout(false);
            this.tabJsonInPage.PerformLayout();
            this.tabJsonOut.ResumeLayout(false);
            this.tabJsonOutPage.ResumeLayout(false);
            this.tabJsonOutPage.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQueryPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabResultPage.ResumeLayout(false);
            this.tabResultPage.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip sbrMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabJsonIn;
        private System.Windows.Forms.TabControl tabQuery;
        private System.Windows.Forms.TabPage tabQueryPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ToolStripStatusLabel sbrMainLabel;
        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TabPage tabJsonInPage;
        private System.Windows.Forms.TabPage tabResultPage;
        private System.Windows.Forms.TextBox txtJsonIn;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cboPath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tabJsonOut;
        private System.Windows.Forms.TabPage tabJsonOutPage;
        private System.Windows.Forms.TextBox txtJsonOut;
        private System.Windows.Forms.Label label1;
    }
}

