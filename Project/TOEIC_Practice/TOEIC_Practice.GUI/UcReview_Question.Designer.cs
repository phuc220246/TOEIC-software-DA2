namespace TOEIC_Practice.GUI
{
    partial class UcReview_Question
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblCorrectLine;
        private System.Windows.Forms.RadioButton rdoToggleExplain;
        private System.Windows.Forms.TextBox txtExplain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.rdoToggleExplain = new System.Windows.Forms.RadioButton();
            this.lblCorrectLine = new System.Windows.Forms.Label();
            this.pnlD = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.pnlC = new System.Windows.Forms.Panel();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlB = new System.Windows.Forms.Panel();
            this.lblB = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.pnlD.SuspendLayout();
            this.pnlC.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.White;
            this.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoot.Controls.Add(this.txtExplain);
            this.pnlRoot.Controls.Add(this.rdoToggleExplain);
            this.pnlRoot.Controls.Add(this.lblCorrectLine);
            this.pnlRoot.Controls.Add(this.pnlD);
            this.pnlRoot.Controls.Add(this.pnlC);
            this.pnlRoot.Controls.Add(this.pnlB);
            this.pnlRoot.Controls.Add(this.pnlA);
            this.pnlRoot.Controls.Add(this.lblQuestion);
            this.pnlRoot.Controls.Add(this.lblHeader);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRoot.Size = new System.Drawing.Size(720, 240);
            this.pnlRoot.TabIndex = 0;
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExplain.Location = new System.Drawing.Point(12, 196);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(692, 32);
            this.txtExplain.TabIndex = 8;
            this.txtExplain.Visible = false;
            // 
            // rdoToggleExplain
            // 
            this.rdoToggleExplain.AutoSize = true;
            this.rdoToggleExplain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoToggleExplain.Location = new System.Drawing.Point(12, 168);
            this.rdoToggleExplain.Name = "rdoToggleExplain";
            this.rdoToggleExplain.Size = new System.Drawing.Size(189, 23);
            this.rdoToggleExplain.TabIndex = 7;
            this.rdoToggleExplain.Text = "Giải thích chi tiết đáp án";
            this.rdoToggleExplain.UseVisualStyleBackColor = true;
            this.rdoToggleExplain.CheckedChanged += new System.EventHandler(this.rdoToggleExplain_CheckedChanged);
            // 
            // lblCorrectLine
            // 
            this.lblCorrectLine.AutoSize = true;
            this.lblCorrectLine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCorrectLine.ForeColor = System.Drawing.Color.Green;
            this.lblCorrectLine.Location = new System.Drawing.Point(12, 144);
            this.lblCorrectLine.Name = "lblCorrectLine";
            this.lblCorrectLine.Size = new System.Drawing.Size(94, 19);
            this.lblCorrectLine.TabIndex = 6;
            this.lblCorrectLine.Text = "Đáp án đúng:";
            // 
            // pnlD
            // 
            this.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlD.Controls.Add(this.lblD);
            this.pnlD.Location = new System.Drawing.Point(12, 116);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(692, 26);
            this.pnlD.TabIndex = 5;
            // 
            // lblD
            // 
            this.lblD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblD.Location = new System.Drawing.Point(0, 0);
            this.lblD.Name = "lblD";
            this.lblD.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.lblD.Size = new System.Drawing.Size(690, 24);
            this.lblD.TabIndex = 0;
            this.lblD.Text = "D.";
            // 
            // pnlC
            // 
            this.pnlC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlC.Controls.Add(this.lblC);
            this.pnlC.Location = new System.Drawing.Point(12, 88);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(692, 26);
            this.pnlC.TabIndex = 4;
            // 
            // lblC
            // 
            this.lblC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblC.Location = new System.Drawing.Point(0, 0);
            this.lblC.Name = "lblC";
            this.lblC.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.lblC.Size = new System.Drawing.Size(690, 24);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "C.";
            // 
            // pnlB
            // 
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.Controls.Add(this.lblB);
            this.pnlB.Location = new System.Drawing.Point(12, 60);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(692, 26);
            this.pnlB.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblB.Location = new System.Drawing.Point(0, 0);
            this.lblB.Name = "lblB";
            this.lblB.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.lblB.Size = new System.Drawing.Size(690, 24);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "B.";
            // 
            // pnlA
            // 
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.Controls.Add(this.lblA);
            this.pnlA.Location = new System.Drawing.Point(12, 32);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(692, 26);
            this.pnlA.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblA.Location = new System.Drawing.Point(0, 0);
            this.lblA.Name = "lblA";
            this.lblA.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.lblA.Size = new System.Drawing.Size(690, 24);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A.";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(12, 12);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(692, 18);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeader.Location = new System.Drawing.Point(620, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(84, 18);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "#";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UcReview_Question
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlRoot);
            this.Name = "UcReview_Question";
            this.Size = new System.Drawing.Size(720, 240);
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlD.ResumeLayout(false);
            this.pnlC.ResumeLayout(false);
            this.pnlB.ResumeLayout(false);
            this.pnlA.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}