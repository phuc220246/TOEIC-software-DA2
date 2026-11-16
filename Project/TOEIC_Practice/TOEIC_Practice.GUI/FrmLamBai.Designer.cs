namespace TOEIC_Practice.GUI
{
    partial class FrmLamBai
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.flpNoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnTiepPart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblThongTinPart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.flpNoiDung);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.pnlSidebar);
            this.splitMain.Size = new System.Drawing.Size(1371, 811);
            this.splitMain.SplitterDistance = 1005;
            this.splitMain.SplitterWidth = 5;
            this.splitMain.TabIndex = 0;
            // 
            // flpNoiDung
            // 
            this.flpNoiDung.AutoScroll = true;
            this.flpNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNoiDung.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNoiDung.Location = new System.Drawing.Point(0, 0);
            this.flpNoiDung.Name = "flpNoiDung";
            this.flpNoiDung.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.flpNoiDung.Size = new System.Drawing.Size(1005, 811);
            this.flpNoiDung.TabIndex = 0;
            this.flpNoiDung.WrapContents = false;
            this.flpNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.flpNoiDung_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.btnNopBai);
            this.pnlSidebar.Controls.Add(this.btnTiepPart);
            this.pnlSidebar.Controls.Add(this.lblTimer);
            this.pnlSidebar.Controls.Add(this.lblThongTinPart);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlSidebar.Size = new System.Drawing.Size(361, 811);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNopBai.Location = new System.Drawing.Point(17, 750);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(325, 43);
            this.btnNopBai.TabIndex = 4;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnTiepPart
            // 
            this.btnTiepPart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTiepPart.Location = new System.Drawing.Point(17, 194);
            this.btnTiepPart.Name = "btnTiepPart";
            this.btnTiepPart.Size = new System.Drawing.Size(325, 38);
            this.btnTiepPart.TabIndex = 3;
            this.btnTiepPart.Text = "Tiếp Part →";
            this.btnTiepPart.UseVisualStyleBackColor = true;
            this.btnTiepPart.Click += new System.EventHandler(this.btnTiepPart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTimer.Location = new System.Drawing.Point(17, 128);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(325, 48);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThongTinPart
            // 
            this.lblThongTinPart.AutoSize = true;
            this.lblThongTinPart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTinPart.Location = new System.Drawing.Point(17, 85);
            this.lblThongTinPart.Name = "lblThongTinPart";
            this.lblThongTinPart.Size = new System.Drawing.Size(161, 25);
            this.lblThongTinPart.TabIndex = 1;
            this.lblThongTinPart.Text = "Part: (chưa load)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(17, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOEIC - Đang làm bài";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 811);
            this.Controls.Add(this.splitMain);
            this.Name = "FrmLamBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm bài";
            this.Load += new System.EventHandler(this.FrmLamBai_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.FlowLayoutPanel flpNoiDung;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThongTinPart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTiepPart;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Timer timer1;
    }
}