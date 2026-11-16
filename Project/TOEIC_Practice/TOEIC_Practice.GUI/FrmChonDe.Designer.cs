namespace TOEIC_Practice.GUI
{
    partial class FrmChonDe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.flowYears = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.flowTests = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.flowYears);
            this.pnlTop.Controls.Add(this.pnlSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 120);
            this.pnlTop.TabIndex = 0;
            // 
            // flowYears
            // 
            this.flowYears.AutoScroll = true;
            this.flowYears.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowYears.Location = new System.Drawing.Point(0, 0);
            this.flowYears.Name = "flowYears";
            this.flowYears.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.flowYears.Size = new System.Drawing.Size(1100, 55);
            this.flowYears.TabIndex = 0;
            this.flowYears.WrapContents = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchYear);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 60);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1100, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(420, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchYear.Location = new System.Drawing.Point(120, 16);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(290, 25);
            this.txtSearchYear.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(20, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm theo năm";
            // 
            // flowTests
            // 
            this.flowTests.AutoScroll = true;
            this.flowTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTests.Location = new System.Drawing.Point(0, 120);
            this.flowTests.Name = "flowTests";
            this.flowTests.Padding = new System.Windows.Forms.Padding(10);
            this.flowTests.Size = new System.Drawing.Size(1100, 580);
            this.flowTests.TabIndex = 1;
            // 
            // FrmChonDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.flowTests);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmChonDe";
            this.Text = "Chọn đề TOEIC";
            this.Load += new System.EventHandler(this.FrmChonDe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel flowYears;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.FlowLayoutPanel flowTests;
    }
}