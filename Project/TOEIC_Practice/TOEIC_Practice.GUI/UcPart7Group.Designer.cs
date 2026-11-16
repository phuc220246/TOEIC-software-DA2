namespace TOEIC_Practice.GUI
{
    partial class UcPart7Group
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.flpPassages = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOuter.Controls.Add(this.splitMain);
            this.pnlOuter.Controls.Add(this.pnlTop);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOuter.Size = new System.Drawing.Size(1000, 520);
            this.pnlOuter.TabIndex = 0;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.None;
            this.splitMain.Location = new System.Drawing.Point(10, 50);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.flpPassages);
            this.splitMain.Panel1MinSize = 300;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.flpQuestions);
            this.splitMain.Panel2MinSize = 320;
            this.splitMain.Size = new System.Drawing.Size(978, 458);
            this.splitMain.SplitterDistance = 500;
            this.splitMain.SplitterWidth = 8;
            this.splitMain.TabIndex = 1;
            // 
            // flpPassages
            // 
            this.flpPassages.AutoScroll = true;
            this.flpPassages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPassages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPassages.Location = new System.Drawing.Point(0, 0);
            this.flpPassages.Name = "flpPassages";
            this.flpPassages.Padding = new System.Windows.Forms.Padding(0);
            this.flpPassages.Size = new System.Drawing.Size(500, 458);
            this.flpPassages.TabIndex = 0;
            this.flpPassages.WrapContents = false;
            this.flpPassages.SizeChanged += new System.EventHandler(this.flpPassages_SizeChanged);
            // 
            // flpQuestions
            // 
            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuestions.Location = new System.Drawing.Point(0, 0);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Padding = new System.Windows.Forms.Padding(0);
            this.flpQuestions.Size = new System.Drawing.Size(470, 458);
            this.flpQuestions.TabIndex = 0;
            this.flpQuestions.WrapContents = false;
            this.flpQuestions.SizeChanged += new System.EventHandler(this.flpQuestions_SizeChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(978, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(978, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Part 7 - Nhóm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcPart7Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlOuter);
            this.Name = "UcPart7Group";
            this.Size = new System.Drawing.Size(1000, 520);
            this.Load += new System.EventHandler(this.UcPart7Group_Load);
            this.Resize += new System.EventHandler(this.UcPart7Group_Resize);
            this.pnlOuter.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.FlowLayoutPanel flpPassages;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
    }
}