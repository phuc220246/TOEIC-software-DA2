namespace TOEIC_Practice.GUI
{
    partial class UcPassageBlock
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPassage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.txtPassage = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.txtPassage);
            this.pnl.Controls.Add(this.lblTitle);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Padding = new System.Windows.Forms.Padding(12);
            this.pnl.Size = new System.Drawing.Size(891, 414);
            this.pnl.TabIndex = 0;
            // 
            // txtPassage
            // 
            this.txtPassage.BackColor = System.Drawing.Color.White;
            this.txtPassage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassage.Location = new System.Drawing.Point(12, 40);
            this.txtPassage.Multiline = true;
            this.txtPassage.Name = "txtPassage";
            this.txtPassage.ReadOnly = true;
            this.txtPassage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassage.Size = new System.Drawing.Size(865, 360);
            this.txtPassage.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(865, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đoạn văn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcPassageBlock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnl);
            this.Name = "UcPassageBlock";
            this.Size = new System.Drawing.Size(891, 414);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}