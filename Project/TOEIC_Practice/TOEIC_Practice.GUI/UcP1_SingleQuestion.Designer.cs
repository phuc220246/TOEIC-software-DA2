namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    partial class UcP1_SingleQuestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (_currentlyPlayingControl == this)
                {
                    _currentlyPlayingControl = null;
                }

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
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.wmpAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblQuestionNo.Location = new System.Drawing.Point(18, 18);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(18, 20);
            this.lblQuestionNo.TabIndex = 0;
            this.lblQuestionNo.Text = "1";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlOptions);
            this.pnlMain.Controls.Add(this.picImage);
            this.pnlMain.Controls.Add(this.wmpAudio);
            this.pnlMain.Controls.Add(this.btnStopAudio);
            this.pnlMain.Controls.Add(this.btnPlayAudio);
            this.pnlMain.Controls.Add(this.lblQuestionNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(980, 640);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.Controls.Add(this.rdoD);
            this.pnlOptions.Controls.Add(this.rdoC);
            this.pnlOptions.Controls.Add(this.rdoB);
            this.pnlOptions.Controls.Add(this.rdoA);
            this.pnlOptions.Location = new System.Drawing.Point(18, 500);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(944, 126);
            this.pnlOptions.TabIndex = 3;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoD.Location = new System.Drawing.Point(10, 93);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(41, 24);
            this.rdoD.TabIndex = 3;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D.";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoC.Location = new System.Drawing.Point(10, 63);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(40, 24);
            this.rdoC.TabIndex = 2;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C.";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoB.Location = new System.Drawing.Point(10, 33);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(40, 24);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B.";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoA.Location = new System.Drawing.Point(10, 3);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(40, 24);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A.";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(18, 70);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(944, 410);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // wmpAudio
            // 
            this.wmpAudio.Enabled = true;
            this.wmpAudio.Location = new System.Drawing.Point(320, 18);
            this.wmpAudio.Name = "wmpAudio";
            this.wmpAudio.Size = new System.Drawing.Size(10, 10);
            this.wmpAudio.TabIndex = 1;
            this.wmpAudio.Visible = false;
            // 
            // UcP1_SingleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcP1_SingleQuestion";
            this.Size = new System.Drawing.Size(980, 640);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).EndInit();
            this.ResumeLayout(false);
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayAudio.Location = new System.Drawing.Point(60, 18);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(130, 32);
            this.btnPlayAudio.TabIndex = 4;
            this.btnPlayAudio.Text = "▶ Phát audio";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStopAudio.Location = new System.Drawing.Point(200, 18);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(90, 32);
            this.btnStopAudio.TabIndex = 5;
            this.btnStopAudio.Text = "■ Dừng";
            this.btnStopAudio.UseVisualStyleBackColor = true;
        }

        #endregion

        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.PictureBox picImage;
        private AxWMPLib.AxWindowsMediaPlayer wmpAudio;
        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.Button btnStopAudio;
    }
}