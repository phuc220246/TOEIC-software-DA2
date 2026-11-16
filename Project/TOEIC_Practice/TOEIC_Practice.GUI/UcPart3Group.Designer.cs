namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    partial class UcPart3Group
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (picImage != null && picImage.Image != null)
                    {
                        picImage.Image.Dispose();
                        picImage.Image = null;
                    }

                    components?.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlQuestionsHost = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.ucAudioPlayer = new TOEIC_Practice.GUI.UserControls.LamBai.UcAudioPlayerSimple();
            this.lblGroupTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlQuestionsHost);
            this.pnlMain.Controls.Add(this.picImage);
            this.pnlMain.Controls.Add(this.ucAudioPlayer);
            this.pnlMain.Controls.Add(this.lblGroupTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1020, 760);
            this.pnlMain.TabIndex = 0;
            //
            // pnlQuestionsHost
            //
            this.pnlQuestionsHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))));
            this.pnlQuestionsHost.AutoScroll = false;
            this.pnlQuestionsHost.Location = new System.Drawing.Point(20, 448);
            this.pnlQuestionsHost.Name = "pnlQuestionsHost";
            this.pnlQuestionsHost.Size = new System.Drawing.Size(978, 292);
            this.pnlQuestionsHost.TabIndex = 3;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(20, 74);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(978, 360);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // ucAudioPlayer
            // 
            this.ucAudioPlayer.Location = new System.Drawing.Point(80, 14);
            this.ucAudioPlayer.Name = "ucAudioPlayer";
            this.ucAudioPlayer.Size = new System.Drawing.Size(320, 56);
            this.ucAudioPlayer.TabIndex = 1;
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGroupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGroupTitle.Location = new System.Drawing.Point(20, 24);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(54, 25);
            this.lblGroupTitle.TabIndex = 0;
            this.lblGroupTitle.Text = "Part 3";
            // 
            // UcPart3Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcPart3Group";
            this.Size = new System.Drawing.Size(1020, 760);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGroupTitle;
        private UcAudioPlayerSimple ucAudioPlayer;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel pnlQuestionsHost;
    }
}