namespace TOEIC_Practice.GUI
{
    partial class UcReview_PassageGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtPassage;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPassage = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.flpQuestions);
            this.pnlMain.Controls.Add(this.txtPassage);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1180, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // flpQuestions
            // 
            this.flpQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpQuestions.Location = new System.Drawing.Point(780, 52);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Size = new System.Drawing.Size(380, 628);
            this.flpQuestions.TabIndex = 2;
            // 
            // txtPassage
            // 
            this.txtPassage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassage.Location = new System.Drawing.Point(16, 52);
            this.txtPassage.Name = "txtPassage";
            this.txtPassage.Size = new System.Drawing.Size(748, 628);
            this.txtPassage.TabIndex = 1;
            this.txtPassage.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PART";
            // 
            // UcReview_PassageGroup
            // 
            this.Controls.Add(this.pnlMain);
            this.Name = "UcReview_PassageGroup";
            this.Size = new System.Drawing.Size(1180, 700);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}