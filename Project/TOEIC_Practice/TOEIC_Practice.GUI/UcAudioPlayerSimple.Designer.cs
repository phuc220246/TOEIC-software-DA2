namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    partial class UcAudioPlayerSimple
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

                StopAudio();

                if (disposing)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAudioPlayerSimple));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.wmpAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.wmpAudio);
            this.pnlMain.Controls.Add(this.btnStopAudio);
            this.pnlMain.Controls.Add(this.btnPlayAudio);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMain.Size = new System.Drawing.Size(320, 56);
            this.pnlMain.TabIndex = 0;
            // 
            // wmpAudio
            // 
            this.wmpAudio.Enabled = true;
            this.wmpAudio.Location = new System.Drawing.Point(250, 10);
            this.wmpAudio.Name = "wmpAudio";
            this.wmpAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAudio.OcxState")));
            this.wmpAudio.Size = new System.Drawing.Size(10, 10);
            this.wmpAudio.TabIndex = 2;
            this.wmpAudio.Visible = false;
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStopAudio.Location = new System.Drawing.Point(150, 10);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(90, 34);
            this.btnStopAudio.TabIndex = 1;
            this.btnStopAudio.Text = "■ Dừng";
            this.btnStopAudio.UseVisualStyleBackColor = true;
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayAudio.Location = new System.Drawing.Point(8, 10);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(135, 34);
            this.btnPlayAudio.TabIndex = 0;
            this.btnPlayAudio.Text = "▶ Phát audio";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            // 
            // UcAudioPlayerSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcAudioPlayerSimple";
            this.Size = new System.Drawing.Size(320, 56);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.Button btnStopAudio;
        private AxWMPLib.AxWindowsMediaPlayer wmpAudio;
    }
}