namespace TOEIC_Practice.GUI
{
    partial class UcReview_Part6QuestionItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pnlExplain = new System.Windows.Forms.Panel();
            this.txtExplain = new System.Windows.Forms.RichTextBox();
            this.rdoToggleExplain = new System.Windows.Forms.RadioButton();
            this.pnlD = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.pnlC = new System.Windows.Forms.Panel();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlB = new System.Windows.Forms.Panel();
            this.lblB = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.pnlExplain.SuspendLayout();
            this.pnlD.SuspendLayout();
            this.pnlC.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoot.Controls.Add(this.lblCorrect);
            this.pnlRoot.Controls.Add(this.pnlExplain);
            this.pnlRoot.Controls.Add(this.rdoToggleExplain);
            this.pnlRoot.Controls.Add(this.pnlD);
            this.pnlRoot.Controls.Add(this.pnlC);
            this.pnlRoot.Controls.Add(this.pnlB);
            this.pnlRoot.Controls.Add(this.pnlA);
            this.pnlRoot.Controls.Add(this.lblQuestion);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRoot.Size = new System.Drawing.Size(520, 260);
            this.pnlRoot.TabIndex = 0;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblCorrect.Location = new System.Drawing.Point(12, 172);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(95, 17);
            this.lblCorrect.TabIndex = 7;
            this.lblCorrect.Text = "Đáp án đúng: ";
            // 
            // pnlExplain
            // 
            this.pnlExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExplain.Controls.Add(this.txtExplain);
            this.pnlExplain.Location = new System.Drawing.Point(15, 216);
            this.pnlExplain.Name = "pnlExplain";
            this.pnlExplain.Size = new System.Drawing.Size(490, 35);
            this.pnlExplain.TabIndex = 6;
            this.pnlExplain.Visible = false;
            // 
            // txtExplain
            // 
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExplain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtExplain.Location = new System.Drawing.Point(0, 0);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(488, 33);
            this.txtExplain.TabIndex = 0;
            this.txtExplain.Text = "";
            // 
            // rdoToggleExplain
            // 
            this.rdoToggleExplain.AutoSize = true;
            this.rdoToggleExplain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.rdoToggleExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.rdoToggleExplain.Location = new System.Drawing.Point(15, 192);
            this.rdoToggleExplain.Name = "rdoToggleExplain";
            this.rdoToggleExplain.Size = new System.Drawing.Size(175, 21);
            this.rdoToggleExplain.TabIndex = 5;
            this.rdoToggleExplain.TabStop = true;
            this.rdoToggleExplain.Text = "Giải thích chi tiết đáp án";
            this.rdoToggleExplain.UseVisualStyleBackColor = true;
            this.rdoToggleExplain.CheckedChanged += new System.EventHandler(this.rdoToggleExplain_CheckedChanged);
            // 
            // pnlD
            // 
            this.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlD.Controls.Add(this.lblD);
            this.pnlD.Location = new System.Drawing.Point(15, 137);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(490, 28);
            this.pnlD.TabIndex = 4;
            // 
            // lblD
            // 
            this.lblD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblD.Location = new System.Drawing.Point(0, 0);
            this.lblD.Name = "lblD";
            this.lblD.Padding = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.lblD.Size = new System.Drawing.Size(488, 26);
            this.lblD.TabIndex = 0;
            this.lblD.Text = "D.";
            // 
            // pnlC
            // 
            this.pnlC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlC.Controls.Add(this.lblC);
            this.pnlC.Location = new System.Drawing.Point(15, 109);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(490, 28);
            this.pnlC.TabIndex = 3;
            // 
            // lblC
            // 
            this.lblC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblC.Location = new System.Drawing.Point(0, 0);
            this.lblC.Name = "lblC";
            this.lblC.Padding = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.lblC.Size = new System.Drawing.Size(488, 26);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "C.";
            // 
            // pnlB
            // 
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.Controls.Add(this.lblB);
            this.pnlB.Location = new System.Drawing.Point(15, 81);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(490, 28);
            this.pnlB.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblB.Location = new System.Drawing.Point(0, 0);
            this.lblB.Name = "lblB";
            this.lblB.Padding = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.lblB.Size = new System.Drawing.Size(488, 26);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "B.";
            // 
            // pnlA
            // 
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.Controls.Add(this.lblA);
            this.pnlA.Location = new System.Drawing.Point(15, 53);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(490, 28);
            this.pnlA.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblA.Location = new System.Drawing.Point(0, 0);
            this.lblA.Name = "lblA";
            this.lblA.Padding = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.lblA.Size = new System.Drawing.Size(488, 26);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A.";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(12, 12);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(493, 38);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "131. ....";
            // 
            // UcReview_Part6QuestionItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlRoot);
            this.Name = "UcReview_Part6QuestionItem";
            this.Size = new System.Drawing.Size(520, 260);
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlExplain.ResumeLayout(false);
            this.pnlD.ResumeLayout(false);
            this.pnlC.ResumeLayout(false);
            this.pnlB.ResumeLayout(false);
            this.pnlA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton rdoToggleExplain;
        private System.Windows.Forms.Panel pnlExplain;
        private System.Windows.Forms.RichTextBox txtExplain;
        private System.Windows.Forms.Label lblCorrect;
    }
}