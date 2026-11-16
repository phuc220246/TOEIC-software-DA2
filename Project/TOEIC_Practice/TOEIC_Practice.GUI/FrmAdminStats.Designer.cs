namespace TOEIC_Practice.GUI.Admin
{
    partial class FrmAdminStats
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnGoRecent = new System.Windows.Forms.Button();
            this.btnGoByTest = new System.Windows.Forms.Button();
            this.btnGoPart = new System.Windows.Forms.Button();
            this.btnGoAccount = new System.Windows.Forms.Button();
            this.btnGoOverview = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.pnlRecentAttempts = new System.Windows.Forms.GroupBox();
            this.dgvRecentAttempts = new System.Windows.Forms.DataGridView();
            this.pnlByTest = new System.Windows.Forms.GroupBox();
            this.dgvByTest = new System.Windows.Forms.DataGridView();
            this.pnlAccuracy = new System.Windows.Forms.GroupBox();
            this.dgvAccuracyByPart = new System.Windows.Forms.DataGridView();
            this.pnlAccountOverview = new System.Windows.Forms.GroupBox();
            this.lblAccLastAttempt = new System.Windows.Forms.Label();
            this.lblAccAvgScore = new System.Windows.Forms.Label();
            this.lblAccDistinctTests = new System.Windows.Forms.Label();
            this.lblAccAttemptCount = new System.Windows.Forms.Label();
            this.lblAccDisplayName = new System.Windows.Forms.Label();
            this.lblAccUsername = new System.Windows.Forms.Label();
            this.pnlOverview = new System.Windows.Forms.GroupBox();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalTests = new System.Windows.Forms.Label();
            this.lblTotalUsersWithAttempts = new System.Windows.Forms.Label();
            this.lblTotalSubmittedAttempts = new System.Windows.Forms.Label();
            this.lblActiveAccounts = new System.Windows.Forms.Label();
            this.lblTotalAccounts = new System.Windows.Forms.Label();
            this.pnlTopNav.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlScroll.SuspendLayout();
            this.pnlRecentAttempts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).BeginInit();
            this.pnlByTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByTest)).BeginInit();
            this.pnlAccuracy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccuracyByPart)).BeginInit();
            this.pnlAccountOverview.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlTopNav.Controls.Add(this.btnGoRecent);
            this.pnlTopNav.Controls.Add(this.btnGoByTest);
            this.pnlTopNav.Controls.Add(this.btnGoPart);
            this.pnlTopNav.Controls.Add(this.btnGoAccount);
            this.pnlTopNav.Controls.Add(this.btnGoOverview);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1180, 50);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnGoRecent
            // 
            this.btnGoRecent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoRecent.ForeColor = System.Drawing.Color.White;
            this.btnGoRecent.Location = new System.Drawing.Point(772, 9);
            this.btnGoRecent.Name = "btnGoRecent";
            this.btnGoRecent.Size = new System.Drawing.Size(222, 31);
            this.btnGoRecent.TabIndex = 4;
            this.btnGoRecent.Text = "lần làm gần đây của 1 account";
            this.btnGoRecent.UseVisualStyleBackColor = false;
            this.btnGoRecent.Click += new System.EventHandler(this.btnGoRecent_Click);
            // 
            // btnGoByTest
            // 
            this.btnGoByTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoByTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoByTest.ForeColor = System.Drawing.Color.White;
            this.btnGoByTest.Location = new System.Drawing.Point(594, 9);
            this.btnGoByTest.Name = "btnGoByTest";
            this.btnGoByTest.Size = new System.Drawing.Size(162, 31);
            this.btnGoByTest.TabIndex = 3;
            this.btnGoByTest.Text = "Thống kê Test";
            this.btnGoByTest.UseVisualStyleBackColor = false;
            this.btnGoByTest.Click += new System.EventHandler(this.btnGoByTest_Click);
            // 
            // btnGoPart
            // 
            this.btnGoPart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPart.ForeColor = System.Drawing.Color.White;
            this.btnGoPart.Location = new System.Drawing.Point(416, 9);
            this.btnGoPart.Name = "btnGoPart";
            this.btnGoPart.Size = new System.Drawing.Size(162, 31);
            this.btnGoPart.TabIndex = 2;
            this.btnGoPart.Text = "Accuracy Part";
            this.btnGoPart.UseVisualStyleBackColor = false;
            this.btnGoPart.Click += new System.EventHandler(this.btnGoPart_Click);
            // 
            // btnGoAccount
            // 
            this.btnGoAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAccount.ForeColor = System.Drawing.Color.White;
            this.btnGoAccount.Location = new System.Drawing.Point(218, 9);
            this.btnGoAccount.Name = "btnGoAccount";
            this.btnGoAccount.Size = new System.Drawing.Size(182, 31);
            this.btnGoAccount.TabIndex = 1;
            this.btnGoAccount.Text = "Tổng quan Account";
            this.btnGoAccount.UseVisualStyleBackColor = false;
            this.btnGoAccount.Click += new System.EventHandler(this.btnGoAccount_Click);
            // 
            // btnGoOverview
            // 
            this.btnGoOverview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoOverview.ForeColor = System.Drawing.Color.White;
            this.btnGoOverview.Location = new System.Drawing.Point(20, 9);
            this.btnGoOverview.Name = "btnGoOverview";
            this.btnGoOverview.Size = new System.Drawing.Size(182, 31);
            this.btnGoOverview.TabIndex = 0;
            this.btnGoOverview.Text = "Tổng quan hệ thống";
            this.btnGoOverview.UseVisualStyleBackColor = false;
            this.btnGoOverview.Click += new System.EventHandler(this.btnGoOverview_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.cboAccount);
            this.pnlFilter.Controls.Add(this.lblAccount);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 50);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1180, 56);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(446, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboAccount
            // 
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(117, 16);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(309, 24);
            this.cboAccount.TabIndex = 1;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(20, 20);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(88, 16);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Chọn account";
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.pnlRecentAttempts);
            this.pnlScroll.Controls.Add(this.pnlByTest);
            this.pnlScroll.Controls.Add(this.pnlAccuracy);
            this.pnlScroll.Controls.Add(this.pnlAccountOverview);
            this.pnlScroll.Controls.Add(this.pnlOverview);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 106);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(1180, 664);
            this.pnlScroll.TabIndex = 2;
            // 
            // pnlRecentAttempts
            // 
            this.pnlRecentAttempts.Controls.Add(this.dgvRecentAttempts);
            this.pnlRecentAttempts.Location = new System.Drawing.Point(20, 1108);
            this.pnlRecentAttempts.Name = "pnlRecentAttempts";
            this.pnlRecentAttempts.Size = new System.Drawing.Size(1128, 280);
            this.pnlRecentAttempts.TabIndex = 4;
            this.pnlRecentAttempts.TabStop = false;
            this.pnlRecentAttempts.Text = "Recent Attempts By Account";
            // 
            // dgvRecentAttempts
            // 
            this.dgvRecentAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentAttempts.Location = new System.Drawing.Point(3, 18);
            this.dgvRecentAttempts.Name = "dgvRecentAttempts";
            this.dgvRecentAttempts.RowHeadersWidth = 51;
            this.dgvRecentAttempts.RowTemplate.Height = 24;
            this.dgvRecentAttempts.Size = new System.Drawing.Size(1122, 259);
            this.dgvRecentAttempts.TabIndex = 0;
            // 
            // pnlByTest
            // 
            this.pnlByTest.Controls.Add(this.dgvByTest);
            this.pnlByTest.Location = new System.Drawing.Point(20, 796);
            this.pnlByTest.Name = "pnlByTest";
            this.pnlByTest.Size = new System.Drawing.Size(1128, 290);
            this.pnlByTest.TabIndex = 3;
            this.pnlByTest.TabStop = false;
            this.pnlByTest.Text = "Thống kê theo Test";
            // 
            // dgvByTest
            // 
            this.dgvByTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvByTest.Location = new System.Drawing.Point(3, 18);
            this.dgvByTest.Name = "dgvByTest";
            this.dgvByTest.RowHeadersWidth = 51;
            this.dgvByTest.RowTemplate.Height = 24;
            this.dgvByTest.Size = new System.Drawing.Size(1122, 269);
            this.dgvByTest.TabIndex = 0;
            // 
            // pnlAccuracy
            // 
            this.pnlAccuracy.Controls.Add(this.dgvAccuracyByPart);
            this.pnlAccuracy.Location = new System.Drawing.Point(20, 525);
            this.pnlAccuracy.Name = "pnlAccuracy";
            this.pnlAccuracy.Size = new System.Drawing.Size(1128, 250);
            this.pnlAccuracy.TabIndex = 2;
            this.pnlAccuracy.TabStop = false;
            this.pnlAccuracy.Text = "Accuracy theo Part";
            // 
            // dgvAccuracyByPart
            // 
            this.dgvAccuracyByPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccuracyByPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccuracyByPart.Location = new System.Drawing.Point(3, 18);
            this.dgvAccuracyByPart.Name = "dgvAccuracyByPart";
            this.dgvAccuracyByPart.RowHeadersWidth = 51;
            this.dgvAccuracyByPart.RowTemplate.Height = 24;
            this.dgvAccuracyByPart.Size = new System.Drawing.Size(1122, 229);
            this.dgvAccuracyByPart.TabIndex = 0;
            // 
            // pnlAccountOverview
            // 
            this.pnlAccountOverview.Controls.Add(this.lblAccLastAttempt);
            this.pnlAccountOverview.Controls.Add(this.lblAccAvgScore);
            this.pnlAccountOverview.Controls.Add(this.lblAccDistinctTests);
            this.pnlAccountOverview.Controls.Add(this.lblAccAttemptCount);
            this.pnlAccountOverview.Controls.Add(this.lblAccDisplayName);
            this.pnlAccountOverview.Controls.Add(this.lblAccUsername);
            this.pnlAccountOverview.Location = new System.Drawing.Point(20, 283);
            this.pnlAccountOverview.Name = "pnlAccountOverview";
            this.pnlAccountOverview.Size = new System.Drawing.Size(1128, 220);
            this.pnlAccountOverview.TabIndex = 1;
            this.pnlAccountOverview.TabStop = false;
            this.pnlAccountOverview.Text = "Tổng quan theo Account";
            // 
            // lblAccLastAttempt
            // 
            this.lblAccLastAttempt.AutoSize = true;
            this.lblAccLastAttempt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccLastAttempt.Location = new System.Drawing.Point(36, 172);
            this.lblAccLastAttempt.Name = "lblAccLastAttempt";
            this.lblAccLastAttempt.Size = new System.Drawing.Size(149, 23);
            this.lblAccLastAttempt.TabIndex = 5;
            this.lblAccLastAttempt.Text = "Lần làm gần nhất";
            // 
            // lblAccAvgScore
            // 
            this.lblAccAvgScore.AutoSize = true;
            this.lblAccAvgScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccAvgScore.Location = new System.Drawing.Point(36, 143);
            this.lblAccAvgScore.Name = "lblAccAvgScore";
            this.lblAccAvgScore.Size = new System.Drawing.Size(144, 23);
            this.lblAccAvgScore.TabIndex = 4;
            this.lblAccAvgScore.Text = "Điểm trung bình";
            // 
            // lblAccDistinctTests
            // 
            this.lblAccDistinctTests.AutoSize = true;
            this.lblAccDistinctTests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccDistinctTests.Location = new System.Drawing.Point(36, 114);
            this.lblAccDistinctTests.Name = "lblAccDistinctTests";
            this.lblAccDistinctTests.Size = new System.Drawing.Size(151, 23);
            this.lblAccDistinctTests.TabIndex = 3;
            this.lblAccDistinctTests.Text = "Số test khác nhau";
            // 
            // lblAccAttemptCount
            // 
            this.lblAccAttemptCount.AutoSize = true;
            this.lblAccAttemptCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccAttemptCount.Location = new System.Drawing.Point(36, 85);
            this.lblAccAttemptCount.Name = "lblAccAttemptCount";
            this.lblAccAttemptCount.Size = new System.Drawing.Size(94, 23);
            this.lblAccAttemptCount.TabIndex = 2;
            this.lblAccAttemptCount.Text = "Số lần làm";
            // 
            // lblAccDisplayName
            // 
            this.lblAccDisplayName.AutoSize = true;
            this.lblAccDisplayName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccDisplayName.Location = new System.Drawing.Point(36, 56);
            this.lblAccDisplayName.Name = "lblAccDisplayName";
            this.lblAccDisplayName.Size = new System.Drawing.Size(116, 23);
            this.lblAccDisplayName.TabIndex = 1;
            this.lblAccDisplayName.Text = "DisplayName";
            // 
            // lblAccUsername
            // 
            this.lblAccUsername.AutoSize = true;
            this.lblAccUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccUsername.Location = new System.Drawing.Point(36, 27);
            this.lblAccUsername.Name = "lblAccUsername";
            this.lblAccUsername.Size = new System.Drawing.Size(89, 23);
            this.lblAccUsername.TabIndex = 0;
            this.lblAccUsername.Text = "Username";
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.lblAverageScore);
            this.pnlOverview.Controls.Add(this.lblTotalQuestions);
            this.pnlOverview.Controls.Add(this.lblTotalTests);
            this.pnlOverview.Controls.Add(this.lblTotalUsersWithAttempts);
            this.pnlOverview.Controls.Add(this.lblTotalSubmittedAttempts);
            this.pnlOverview.Controls.Add(this.lblActiveAccounts);
            this.pnlOverview.Controls.Add(this.lblTotalAccounts);
            this.pnlOverview.Location = new System.Drawing.Point(20, 20);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1128, 240);
            this.pnlOverview.TabIndex = 0;
            this.pnlOverview.TabStop = false;
            this.pnlOverview.Text = "Tổng quan hệ thống";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverageScore.Location = new System.Drawing.Point(36, 202);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(197, 23);
            this.lblAverageScore.TabIndex = 6;
            this.lblAverageScore.Text = "Điểm TB toàn hệ thống";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuestions.Location = new System.Drawing.Point(36, 173);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(135, 23);
            this.lblTotalQuestions.TabIndex = 5;
            this.lblTotalQuestions.Text = "Tổng số câu hỏi";
            // 
            // lblTotalTests
            // 
            this.lblTotalTests.AutoSize = true;
            this.lblTotalTests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTests.Location = new System.Drawing.Point(36, 144);
            this.lblTotalTests.Name = "lblTotalTests";
            this.lblTotalTests.Size = new System.Drawing.Size(108, 23);
            this.lblTotalTests.TabIndex = 4;
            this.lblTotalTests.Text = "Tổng số test";
            // 
            // lblTotalUsersWithAttempts
            // 
            this.lblTotalUsersWithAttempts.AutoSize = true;
            this.lblTotalUsersWithAttempts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsersWithAttempts.Location = new System.Drawing.Point(36, 115);
            this.lblTotalUsersWithAttempts.Name = "lblTotalUsersWithAttempts";
            this.lblTotalUsersWithAttempts.Size = new System.Drawing.Size(179, 23);
            this.lblTotalUsersWithAttempts.TabIndex = 3;
            this.lblTotalUsersWithAttempts.Text = "User đã từng làm bài";
            // 
            // lblTotalSubmittedAttempts
            // 
            this.lblTotalSubmittedAttempts.AutoSize = true;
            this.lblTotalSubmittedAttempts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSubmittedAttempts.Location = new System.Drawing.Point(36, 86);
            this.lblTotalSubmittedAttempts.Name = "lblTotalSubmittedAttempts";
            this.lblTotalSubmittedAttempts.Size = new System.Drawing.Size(170, 23);
            this.lblTotalSubmittedAttempts.TabIndex = 2;
            this.lblTotalSubmittedAttempts.Text = "Lượt nộp bài hợp lệ";
            // 
            // lblActiveAccounts
            // 
            this.lblActiveAccounts.AutoSize = true;
            this.lblActiveAccounts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblActiveAccounts.Location = new System.Drawing.Point(36, 57);
            this.lblActiveAccounts.Name = "lblActiveAccounts";
            this.lblActiveAccounts.Size = new System.Drawing.Size(221, 23);
            this.lblActiveAccounts.TabIndex = 1;
            this.lblActiveAccounts.Text = "Tài khoản đang hoạt động";
            // 
            // lblTotalAccounts
            // 
            this.lblTotalAccounts.AutoSize = true;
            this.lblTotalAccounts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAccounts.Location = new System.Drawing.Point(36, 28);
            this.lblTotalAccounts.Name = "lblTotalAccounts";
            this.lblTotalAccounts.Size = new System.Drawing.Size(131, 23);
            this.lblTotalAccounts.TabIndex = 0;
            this.lblTotalAccounts.Text = "Tổng tài khoản";
            // 
            // FrmAdminStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 770);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTopNav);
            this.Name = "FrmAdminStats";
            this.Text = "Admin - Thống kê";
            this.Load += new System.EventHandler(this.FrmAdminStats_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlScroll.ResumeLayout(false);
            this.pnlRecentAttempts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).EndInit();
            this.pnlByTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByTest)).EndInit();
            this.pnlAccuracy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccuracyByPart)).EndInit();
            this.pnlAccountOverview.ResumeLayout(false);
            this.pnlAccountOverview.PerformLayout();
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnGoRecent;
        private System.Windows.Forms.Button btnGoByTest;
        private System.Windows.Forms.Button btnGoPart;
        private System.Windows.Forms.Button btnGoAccount;
        private System.Windows.Forms.Button btnGoOverview;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.GroupBox pnlRecentAttempts;
        private System.Windows.Forms.DataGridView dgvRecentAttempts;
        private System.Windows.Forms.GroupBox pnlByTest;
        private System.Windows.Forms.DataGridView dgvByTest;
        private System.Windows.Forms.GroupBox pnlAccuracy;
        private System.Windows.Forms.DataGridView dgvAccuracyByPart;
        private System.Windows.Forms.GroupBox pnlAccountOverview;
        private System.Windows.Forms.Label lblAccLastAttempt;
        private System.Windows.Forms.Label lblAccAvgScore;
        private System.Windows.Forms.Label lblAccDistinctTests;
        private System.Windows.Forms.Label lblAccAttemptCount;
        private System.Windows.Forms.Label lblAccDisplayName;
        private System.Windows.Forms.Label lblAccUsername;
        private System.Windows.Forms.GroupBox pnlOverview;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblTotalTests;
        private System.Windows.Forms.Label lblTotalUsersWithAttempts;
        private System.Windows.Forms.Label lblTotalSubmittedAttempts;
        private System.Windows.Forms.Label lblActiveAccounts;
        private System.Windows.Forms.Label lblTotalAccounts;
    }
}