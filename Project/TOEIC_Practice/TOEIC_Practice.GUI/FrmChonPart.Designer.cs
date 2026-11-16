namespace TOEIC_Practice.GUI
{
    partial class FrmChonPart
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
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpParts = new System.Windows.Forms.GroupBox();
            this.chkPart7 = new System.Windows.Forms.CheckBox();
            this.chkPart6 = new System.Windows.Forms.CheckBox();
            this.chkPart5 = new System.Windows.Forms.CheckBox();
            this.chkPart4 = new System.Windows.Forms.CheckBox();
            this.chkPart3 = new System.Windows.Forms.CheckBox();
            this.chkPart2 = new System.Windows.Forms.CheckBox();
            this.chkPart1 = new System.Windows.Forms.CheckBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlQuick = new System.Windows.Forms.Panel();
            this.btnQuickReading = new System.Windows.Forms.Button();
            this.btnQuickListening = new System.Windows.Forms.Button();
            this.btnQuickFull = new System.Windows.Forms.Button();
            this.pnlRoot.SuspendLayout();
            this.grpParts.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlQuick.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.White;
            this.pnlRoot.Controls.Add(this.pnlButtons);
            this.pnlRoot.Controls.Add(this.grpTime);
            this.pnlRoot.Controls.Add(this.grpParts);
            this.pnlRoot.Controls.Add(this.pnlQuick);
            this.pnlRoot.Controls.Add(this.lblTitle);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRoot.Size = new System.Drawing.Size(520, 520);
            this.pnlRoot.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(488, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn phần thi bạn muốn làm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpParts
            // 
            this.grpParts.Controls.Add(this.chkPart7);
            this.grpParts.Controls.Add(this.chkPart6);
            this.grpParts.Controls.Add(this.chkPart5);
            this.grpParts.Controls.Add(this.chkPart4);
            this.grpParts.Controls.Add(this.chkPart3);
            this.grpParts.Controls.Add(this.chkPart2);
            this.grpParts.Controls.Add(this.chkPart1);
            this.grpParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpParts.Location = new System.Drawing.Point(16, 96);
            this.grpParts.Name = "grpParts";
            this.grpParts.Padding = new System.Windows.Forms.Padding(12);
            this.grpParts.Size = new System.Drawing.Size(488, 246);
            this.grpParts.TabIndex = 2;
            this.grpParts.TabStop = false;
            this.grpParts.Text = "Chọn Part";
            // 
            // chkPart7
            // 
            this.chkPart7.AutoSize = true;
            this.chkPart7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart7.Location = new System.Drawing.Point(18, 204);
            this.chkPart7.Name = "chkPart7";
            this.chkPart7.Size = new System.Drawing.Size(71, 23);
            this.chkPart7.TabIndex = 6;
            this.chkPart7.Text = "Part 7";
            this.chkPart7.UseVisualStyleBackColor = true;
            // 
            // chkPart6
            // 
            this.chkPart6.AutoSize = true;
            this.chkPart6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart6.Location = new System.Drawing.Point(18, 175);
            this.chkPart6.Name = "chkPart6";
            this.chkPart6.Size = new System.Drawing.Size(71, 23);
            this.chkPart6.TabIndex = 5;
            this.chkPart6.Text = "Part 6";
            this.chkPart6.UseVisualStyleBackColor = true;
            // 
            // chkPart5
            // 
            this.chkPart5.AutoSize = true;
            this.chkPart5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart5.Location = new System.Drawing.Point(18, 146);
            this.chkPart5.Name = "chkPart5";
            this.chkPart5.Size = new System.Drawing.Size(71, 23);
            this.chkPart5.TabIndex = 4;
            this.chkPart5.Text = "Part 5";
            this.chkPart5.UseVisualStyleBackColor = true;
            // 
            // chkPart4
            // 
            this.chkPart4.AutoSize = true;
            this.chkPart4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart4.Location = new System.Drawing.Point(18, 117);
            this.chkPart4.Name = "chkPart4";
            this.chkPart4.Size = new System.Drawing.Size(71, 23);
            this.chkPart4.TabIndex = 3;
            this.chkPart4.Text = "Part 4";
            this.chkPart4.UseVisualStyleBackColor = true;
            // 
            // chkPart3
            // 
            this.chkPart3.AutoSize = true;
            this.chkPart3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart3.Location = new System.Drawing.Point(18, 88);
            this.chkPart3.Name = "chkPart3";
            this.chkPart3.Size = new System.Drawing.Size(71, 23);
            this.chkPart3.TabIndex = 2;
            this.chkPart3.Text = "Part 3";
            this.chkPart3.UseVisualStyleBackColor = true;
            // 
            // chkPart2
            // 
            this.chkPart2.AutoSize = true;
            this.chkPart2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart2.Location = new System.Drawing.Point(18, 59);
            this.chkPart2.Name = "chkPart2";
            this.chkPart2.Size = new System.Drawing.Size(71, 23);
            this.chkPart2.TabIndex = 1;
            this.chkPart2.Text = "Part 2";
            this.chkPart2.UseVisualStyleBackColor = true;
            // 
            // chkPart1
            // 
            this.chkPart1.AutoSize = true;
            this.chkPart1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPart1.Location = new System.Drawing.Point(18, 30);
            this.chkPart1.Name = "chkPart1";
            this.chkPart1.Size = new System.Drawing.Size(71, 23);
            this.chkPart1.TabIndex = 0;
            this.chkPart1.Text = "Part 1";
            this.chkPart1.UseVisualStyleBackColor = true;
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.lblHint);
            this.grpTime.Controls.Add(this.cboTime);
            this.grpTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTime.Location = new System.Drawing.Point(16, 342);
            this.grpTime.Name = "grpTime";
            this.grpTime.Padding = new System.Windows.Forms.Padding(12);
            this.grpTime.Size = new System.Drawing.Size(488, 96);
            this.grpTime.TabIndex = 3;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Giới hạn thời gian";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(15, 64);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(318, 15);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Để trống = làm bài không giới hạn (giống Study4).";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(18, 30);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(452, 25);
            this.cboTime.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(16, 456);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(488, 48);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(271, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(375, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Luyện tập";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlQuick
            // 
            this.pnlQuick.Controls.Add(this.btnQuickReading);
            this.pnlQuick.Controls.Add(this.btnQuickListening);
            this.pnlQuick.Controls.Add(this.btnQuickFull);
            this.pnlQuick.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuick.Location = new System.Drawing.Point(16, 58);
            this.pnlQuick.Name = "pnlQuick";
            this.pnlQuick.Size = new System.Drawing.Size(488, 38);
            this.pnlQuick.TabIndex = 1;
            // 
            // btnQuickReading
            // 
            this.btnQuickReading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickReading.Location = new System.Drawing.Point(242, 4);
            this.btnQuickReading.Name = "btnQuickReading";
            this.btnQuickReading.Size = new System.Drawing.Size(110, 30);
            this.btnQuickReading.TabIndex = 2;
            this.btnQuickReading.Text = "Reading (5-7)";
            this.btnQuickReading.UseVisualStyleBackColor = true;
            this.btnQuickReading.Click += new System.EventHandler(this.btnQuickReading_Click);
            // 
            // btnQuickListening
            // 
            this.btnQuickListening.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickListening.Location = new System.Drawing.Point(126, 4);
            this.btnQuickListening.Name = "btnQuickListening";
            this.btnQuickListening.Size = new System.Drawing.Size(110, 30);
            this.btnQuickListening.TabIndex = 1;
            this.btnQuickListening.Text = "Listening (1-4)";
            this.btnQuickListening.UseVisualStyleBackColor = true;
            this.btnQuickListening.Click += new System.EventHandler(this.btnQuickListening_Click);
            // 
            // btnQuickFull
            // 
            this.btnQuickFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickFull.Location = new System.Drawing.Point(10, 4);
            this.btnQuickFull.Name = "btnQuickFull";
            this.btnQuickFull.Size = new System.Drawing.Size(110, 30);
            this.btnQuickFull.TabIndex = 0;
            this.btnQuickFull.Text = "Full 7 Part";
            this.btnQuickFull.UseVisualStyleBackColor = true;
            this.btnQuickFull.Click += new System.EventHandler(this.btnQuickFull_Click);
            // 
            // FrmChonPart
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChonPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Part";
            this.Load += new System.EventHandler(this.FrmChonPart_Load);
            this.pnlRoot.ResumeLayout(false);
            this.grpParts.ResumeLayout(false);
            this.grpParts.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlQuick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlQuick;
        private System.Windows.Forms.Button btnQuickReading;
        private System.Windows.Forms.Button btnQuickListening;
        private System.Windows.Forms.Button btnQuickFull;
        private System.Windows.Forms.GroupBox grpParts;
        private System.Windows.Forms.CheckBox chkPart7;
        private System.Windows.Forms.CheckBox chkPart6;
        private System.Windows.Forms.CheckBox chkPart5;
        private System.Windows.Forms.CheckBox chkPart4;
        private System.Windows.Forms.CheckBox chkPart3;
        private System.Windows.Forms.CheckBox chkPart2;
        private System.Windows.Forms.CheckBox chkPart1;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
    }
}