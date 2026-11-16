namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    partial class UcP2_SingleQuestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            try
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcP2_SingleQuestion));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblGuide = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.wmpAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblGuide);
            this.pnlMain.Controls.Add(this.pnlOptions);
            this.pnlMain.Controls.Add(this.wmpAudio);
            this.pnlMain.Controls.Add(this.btnStopAudio);
            this.pnlMain.Controls.Add(this.btnPlayAudio);
            this.pnlMain.Controls.Add(this.lblQuestionNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.pnlMain.Size = new System.Drawing.Size(1029, 277);
            this.pnlMain.TabIndex = 0;
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblGuide.ForeColor = System.Drawing.Color.DimGray;
            this.lblGuide.Location = new System.Drawing.Point(23, 66);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(276, 23);
            this.lblGuide.TabIndex = 5;
            this.lblGuide.Text = "Listen and choose the best response.";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.Controls.Add(this.rdoC);
            this.pnlOptions.Controls.Add(this.rdoB);
            this.pnlOptions.Controls.Add(this.rdoA);
            this.pnlOptions.Location = new System.Drawing.Point(23, 107);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(982, 144);
            this.pnlOptions.TabIndex = 4;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoC.Location = new System.Drawing.Point(9, 98);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(49, 29);
            this.rdoC.TabIndex = 2;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C.";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoB.Location = new System.Drawing.Point(9, 51);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(48, 29);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B.";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rdoA.Location = new System.Drawing.Point(9, 4);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(49, 29);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A.";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // wmpAudio
            // 
            this.wmpAudio.Enabled = true;
            this.wmpAudio.Location = new System.Drawing.Point(336, 20);
            this.wmpAudio.Name = "wmpAudio";
            this.wmpAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAudio.OcxState")));
            this.wmpAudio.Size = new System.Drawing.Size(10, 10);
            this.wmpAudio.TabIndex = 3;
            this.wmpAudio.Visible = false;
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStopAudio.Location = new System.Drawing.Point(227, 19);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(103, 34);
            this.btnStopAudio.TabIndex = 2;
            this.btnStopAudio.Text = "■ Dừng";
            this.btnStopAudio.UseVisualStyleBackColor = true;
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayAudio.Location = new System.Drawing.Point(66, 19);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(149, 34);
            this.btnPlayAudio.TabIndex = 1;
            this.btnPlayAudio.Text = "▶ Phát audio";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblQuestionNo.Location = new System.Drawing.Point(23, 26);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(23, 25);
            this.lblQuestionNo.TabIndex = 0;
            this.lblQuestionNo.Text = "1";
            // 
            // UcP2_SingleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcP2_SingleQuestion";
            this.Size = new System.Drawing.Size(1029, 277);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.Button btnStopAudio;
        private AxWMPLib.AxWindowsMediaPlayer wmpAudio;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.Label lblGuide;
    }
}