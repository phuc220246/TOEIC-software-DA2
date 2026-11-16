namespace TOEIC_Practice.GUI
{
    partial class FrmXemLai
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlRoot;

        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.FlowLayoutPanel flpReview;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPartTitle;
        public System.Windows.Forms.FlowLayoutPanel flpNav;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flpReview = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPartTitle = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.White;
            this.pnlRoot.Controls.Add(this.pnlLeft);
            this.pnlRoot.Controls.Add(this.pnlRight);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRoot.Size = new System.Drawing.Size(1280, 720);
            this.pnlRoot.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.flpReview);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(16, 16);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlLeft.Size = new System.Drawing.Size(1028, 688);
            this.pnlLeft.TabIndex = 0;
            // 
            // flpReview
            // 
            this.flpReview.AutoScroll = true;
            this.flpReview.BackColor = System.Drawing.Color.White;
            this.flpReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpReview.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReview.Location = new System.Drawing.Point(0, 0);
            this.flpReview.Name = "flpReview";
            this.flpReview.Size = new System.Drawing.Size(1016, 688);
            this.flpReview.TabIndex = 0;
            this.flpReview.WrapContents = false;
            //this.flpReview.Paint += new System.Windows.Forms.PaintEventHandler(this.flpReview_Paint);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.flpNav);
            this.pnlRight.Controls.Add(this.lblPartTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1044, 16);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(220, 688);
            this.pnlRight.TabIndex = 1;
            // 
            // flpNav
            // 
            this.flpNav.AutoScroll = true;
            this.flpNav.BackColor = System.Drawing.Color.White;
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.Location = new System.Drawing.Point(10, 50);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(198, 626);
            this.flpNav.TabIndex = 0;
            // 
            // lblPartTitle
            // 
            this.lblPartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPartTitle.Location = new System.Drawing.Point(10, 10);
            this.lblPartTitle.Name = "lblPartTitle";
            this.lblPartTitle.Size = new System.Drawing.Size(198, 40);
            this.lblPartTitle.TabIndex = 1;
            this.lblPartTitle.Text = "Part 5";
            this.lblPartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmXemLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmXemLai";
            this.Text = "Xem đáp án";
            this.Load += new System.EventHandler(this.FrmXemLai_Shown);
            this.Resize += new System.EventHandler(this.FrmXemLai_Resize);
            this.pnlRoot.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}