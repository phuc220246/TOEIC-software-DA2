namespace TOEIC_Practice.GUI
{
    partial class FrmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabChonDe = new System.Windows.Forms.TabPage();
            this.pnlChonDeBody = new System.Windows.Forms.Panel();
            this.pnlCauHinhLuyenTap = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnLuyenTap = new System.Windows.Forms.Button();
            this.cboTimeLimit = new System.Windows.Forms.ComboBox();
            this.lblGioiHan = new System.Windows.Forms.Label();
            this.clbParts = new System.Windows.Forms.CheckedListBox();
            this.lblChonPart = new System.Windows.Forms.Label();
            this.lblTestDangChon = new System.Windows.Forms.Label();
            this.pnlDanhSachTest = new System.Windows.Forms.Panel();
            this.flowTests = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChonDeTop = new System.Windows.Forms.Panel();
            this.flowYears = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlLichSuTop = new System.Windows.Forms.Panel();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.pnlStatsContainer = new System.Windows.Forms.Panel();
            this.pnlRecentAttempts = new System.Windows.Forms.Panel();
            this.dgvRecentAttempts = new System.Windows.Forms.DataGridView();
            this.lblRecentAttemptsTitle = new System.Windows.Forms.Label();
            this.pnlByTest = new System.Windows.Forms.Panel();
            this.dgvStatsByTest = new System.Windows.Forms.DataGridView();
            this.lblByTestTitle = new System.Windows.Forms.Label();
            this.pnlByPart = new System.Windows.Forms.Panel();
            this.dgvStatsByPart = new System.Windows.Forms.DataGridView();
            this.lblByPartTitle = new System.Windows.Forms.Label();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.tlpOverview = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCardTotalAttempts = new System.Windows.Forms.Panel();
            this.lblTotalAttempts = new System.Windows.Forms.Label();
            this.lblTotalAttemptsTitle = new System.Windows.Forms.Label();
            this.pnlCardTotalQuestions = new System.Windows.Forms.Panel();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalQuestionsTitle = new System.Windows.Forms.Label();
            this.pnlCardTotalCorrect = new System.Windows.Forms.Panel();
            this.lblTotalCorrect = new System.Windows.Forms.Label();
            this.lblTotalCorrectTitle = new System.Windows.Forms.Label();
            this.pnlCardAccuracy = new System.Windows.Forms.Panel();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblAccuracyTitle = new System.Windows.Forms.Label();
            this.pnlCardTotalWrong = new System.Windows.Forms.Panel();
            this.lblTotalWrong = new System.Windows.Forms.Label();
            this.lblTotalWrongTitle = new System.Windows.Forms.Label();
            this.pnlCardTotalSkipped = new System.Windows.Forms.Panel();
            this.lblTotalSkipped = new System.Windows.Forms.Label();
            this.lblTotalSkippedTitle = new System.Windows.Forms.Label();
            this.pnlCardAvgDuration = new System.Windows.Forms.Panel();
            this.lblAvgDuration = new System.Windows.Forms.Label();
            this.lblAvgDurationTitle = new System.Windows.Forms.Label();
            this.pnlCardLastSubmitted = new System.Windows.Forms.Panel();
            this.lblLastSubmitted = new System.Windows.Forms.Label();
            this.lblLastSubmittedTitle = new System.Windows.Forms.Label();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.pnlStatsNav = new System.Windows.Forms.Panel();
            this.btnStatsOverview = new System.Windows.Forms.Button();
            this.btnStatsByPart = new System.Windows.Forms.Button();
            this.btnStatsByTest = new System.Windows.Forms.Button();
            this.btnStatsRecent = new System.Windows.Forms.Button();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.FormClosed += FrmMain_FormClosed;
            this.tabMain.SuspendLayout();
            this.tabChonDe.SuspendLayout();
            this.pnlChonDeBody.SuspendLayout();
            this.pnlCauHinhLuyenTap.SuspendLayout();
            this.pnlDanhSachTest.SuspendLayout();
            this.pnlChonDeTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.pnlLichSuTop.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.pnlStatsContainer.SuspendLayout();
            this.pnlRecentAttempts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).BeginInit();
            this.pnlByTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsByTest)).BeginInit();
            this.pnlByPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsByPart)).BeginInit();
            this.pnlOverview.SuspendLayout();
            this.tlpOverview.SuspendLayout();
            this.pnlCardTotalAttempts.SuspendLayout();
            this.pnlCardTotalQuestions.SuspendLayout();
            this.pnlCardTotalCorrect.SuspendLayout();
            this.pnlCardAccuracy.SuspendLayout();
            this.pnlCardTotalWrong.SuspendLayout();
            this.pnlCardTotalSkipped.SuspendLayout();
            this.pnlCardAvgDuration.SuspendLayout();
            this.pnlCardLastSubmitted.SuspendLayout();
            this.pnlStatsNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabChonDe);
            this.tabMain.Controls.Add(this.tabLichSu);
            this.tabMain.Controls.Add(this.tabThongKe);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1371, 811);
            this.tabMain.TabIndex = 0;
            // 
            // tabChonDe
            // 
            this.tabChonDe.Controls.Add(this.pnlChonDeBody);
            this.tabChonDe.Controls.Add(this.pnlChonDeTop);
            this.tabChonDe.Location = new System.Drawing.Point(4, 32);
            this.tabChonDe.Name = "tabChonDe";
            this.tabChonDe.Padding = new System.Windows.Forms.Padding(3);
            this.tabChonDe.Size = new System.Drawing.Size(1363, 775);
            this.tabChonDe.TabIndex = 0;
            this.tabChonDe.Text = "Chọn đề";
            this.tabChonDe.UseVisualStyleBackColor = true;
            // 
            // pnlChonDeBody
            // 
            this.pnlChonDeBody.Controls.Add(this.pnlCauHinhLuyenTap);
            this.pnlChonDeBody.Controls.Add(this.pnlDanhSachTest);
            this.pnlChonDeBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChonDeBody.Location = new System.Drawing.Point(3, 142);
            this.pnlChonDeBody.Name = "pnlChonDeBody";
            this.pnlChonDeBody.Size = new System.Drawing.Size(1357, 630);
            this.pnlChonDeBody.TabIndex = 1;
            // 
            // pnlCauHinhLuyenTap
            // 
            this.pnlCauHinhLuyenTap.BackColor = System.Drawing.Color.White;
            this.pnlCauHinhLuyenTap.Controls.Add(this.btnQuayLai);
            this.pnlCauHinhLuyenTap.Controls.Add(this.btnLuyenTap);
            this.pnlCauHinhLuyenTap.Controls.Add(this.cboTimeLimit);
            this.pnlCauHinhLuyenTap.Controls.Add(this.lblGioiHan);
            this.pnlCauHinhLuyenTap.Controls.Add(this.clbParts);
            this.pnlCauHinhLuyenTap.Controls.Add(this.lblChonPart);
            this.pnlCauHinhLuyenTap.Controls.Add(this.lblTestDangChon);
            this.pnlCauHinhLuyenTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCauHinhLuyenTap.Location = new System.Drawing.Point(0, 0);
            this.pnlCauHinhLuyenTap.Name = "pnlCauHinhLuyenTap";
            this.pnlCauHinhLuyenTap.Padding = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.pnlCauHinhLuyenTap.Size = new System.Drawing.Size(1357, 630);
            this.pnlCauHinhLuyenTap.TabIndex = 1;
            this.pnlCauHinhLuyenTap.Visible = false;
            this.pnlCauHinhLuyenTap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCauHinhLuyenTap_Paint);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.Location = new System.Drawing.Point(24, 19);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(126, 36);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "← Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnLuyenTap
            // 
            this.btnLuyenTap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuyenTap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuyenTap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuyenTap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuyenTap.ForeColor = System.Drawing.Color.White;
            this.btnLuyenTap.Location = new System.Drawing.Point(24, 563);
            this.btnLuyenTap.Name = "btnLuyenTap";
            this.btnLuyenTap.Size = new System.Drawing.Size(183, 47);
            this.btnLuyenTap.TabIndex = 6;
            this.btnLuyenTap.Text = "LUYỆN TẬP";
            this.btnLuyenTap.UseVisualStyleBackColor = false;
            this.btnLuyenTap.Click += new System.EventHandler(this.btnLuyenTap_Click);
            // 
            // cboTimeLimit
            // 
            this.cboTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeLimit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTimeLimit.FormattingEnabled = true;
            this.cboTimeLimit.Location = new System.Drawing.Point(24, 514);
            this.cboTimeLimit.Name = "cboTimeLimit";
            this.cboTimeLimit.Size = new System.Drawing.Size(1309, 31);
            this.cboTimeLimit.TabIndex = 5;
            // 
            // lblGioiHan
            // 
            this.lblGioiHan.AutoSize = true;
            this.lblGioiHan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGioiHan.Location = new System.Drawing.Point(21, 482);
            this.lblGioiHan.Name = "lblGioiHan";
            this.lblGioiHan.Size = new System.Drawing.Size(435, 23);
            this.lblGioiHan.TabIndex = 4;
            this.lblGioiHan.Text = "Giới hạn thời gian (Để trống để làm bài không giới hạn)";
            // 
            // clbParts
            // 
            this.clbParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbParts.CheckOnClick = true;
            this.clbParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clbParts.FormattingEnabled = true;
            this.clbParts.Location = new System.Drawing.Point(24, 176);
            this.clbParts.Name = "clbParts";
            this.clbParts.Size = new System.Drawing.Size(1309, 279);
            this.clbParts.TabIndex = 3;
            // 
            // lblChonPart
            // 
            this.lblChonPart.AutoSize = true;
            this.lblChonPart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChonPart.Location = new System.Drawing.Point(21, 144);
            this.lblChonPart.Name = "lblChonPart";
            this.lblChonPart.Size = new System.Drawing.Size(271, 25);
            this.lblChonPart.TabIndex = 2;
            this.lblChonPart.Text = "Chọn phần thi bạn muốn làm";
            // 
            // lblTestDangChon
            // 
            this.lblTestDangChon.AutoSize = true;
            this.lblTestDangChon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTestDangChon.Location = new System.Drawing.Point(171, 27);
            this.lblTestDangChon.Name = "lblTestDangChon";
            this.lblTestDangChon.Size = new System.Drawing.Size(315, 25);
            this.lblTestDangChon.TabIndex = 1;
            this.lblTestDangChon.Text = "Bạn đang chọn: (chưa có test nào)";
            // 
            // pnlDanhSachTest
            // 
            this.pnlDanhSachTest.Controls.Add(this.flowTests);
            this.pnlDanhSachTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSachTest.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSachTest.Name = "pnlDanhSachTest";
            this.pnlDanhSachTest.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlDanhSachTest.Size = new System.Drawing.Size(1357, 630);
            this.pnlDanhSachTest.TabIndex = 0;
            // 
            // flowTests
            // 
            this.flowTests.AutoScroll = true;
            this.flowTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTests.Location = new System.Drawing.Point(14, 13);
            this.flowTests.Name = "flowTests";
            this.flowTests.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.flowTests.Size = new System.Drawing.Size(1329, 604);
            this.flowTests.TabIndex = 0;
            // 
            // pnlChonDeTop
            // 
            this.pnlChonDeTop.Controls.Add(this.flowYears);
            this.pnlChonDeTop.Controls.Add(this.pnlSearch);

            this.pnlSearch.Controls.Add(this.btnDangXuat);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchYear);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlChonDeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChonDeTop.Location = new System.Drawing.Point(3, 3);
            this.pnlChonDeTop.Name = "pnlChonDeTop";
            this.pnlChonDeTop.Size = new System.Drawing.Size(1357, 139);
            this.pnlChonDeTop.TabIndex = 0;
            // 
            // flowYears
            // 
            this.flowYears.AutoScroll = true;
            this.flowYears.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowYears.Location = new System.Drawing.Point(0, 0);
            this.flowYears.Name = "flowYears";
            this.flowYears.Padding = new System.Windows.Forms.Padding(14, 13, 14, 0);
            this.flowYears.Size = new System.Drawing.Size(1357, 64);
            this.flowYears.TabIndex = 0;
            this.flowYears.WrapContents = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchYear);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 75);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1357, 64);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(955, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchYear.Location = new System.Drawing.Point(137, 17);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(800, 30);
            this.txtSearchYear.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(14, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm theo năm";
            // 
            // tabLichSu
            // 
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.pnlLichSuTop);
            this.tabLichSu.Location = new System.Drawing.Point(4, 32);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(1363, 775);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            this.tabLichSu.UseVisualStyleBackColor = true;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeight = 29;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.Location = new System.Drawing.Point(3, 56);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.Size = new System.Drawing.Size(1357, 716);
            this.dgvLichSu.TabIndex = 1;
            // 
            // pnlLichSuTop
            // 
            this.pnlLichSuTop.Controls.Add(this.lblLichSu);
            this.pnlLichSuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLichSuTop.Location = new System.Drawing.Point(3, 3);
            this.pnlLichSuTop.Name = "pnlLichSuTop";
            this.pnlLichSuTop.Size = new System.Drawing.Size(1357, 53);
            this.pnlLichSuTop.TabIndex = 0;
            // 
            // lblLichSu
            // 
            this.lblLichSu.AutoSize = true;
            this.lblLichSu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLichSu.Location = new System.Drawing.Point(18, 16);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(217, 25);
            this.lblLichSu.TabIndex = 0;
            this.lblLichSu.Text = "Lịch sử làm bài của bạn";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.pnlStatsContainer);
            this.tabThongKe.Controls.Add(this.pnlStatsNav);
            this.tabThongKe.Location = new System.Drawing.Point(4, 32);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(1363, 775);
            this.tabThongKe.TabIndex = 2;
            this.tabThongKe.Text = "Thống kê";
            this.tabThongKe.UseVisualStyleBackColor = true;
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.AutoScroll = true;
            this.pnlStatsContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlStatsContainer.Controls.Add(this.pnlRecentAttempts);
            this.pnlStatsContainer.Controls.Add(this.pnlByTest);
            this.pnlStatsContainer.Controls.Add(this.pnlByPart);
            this.pnlStatsContainer.Controls.Add(this.pnlOverview);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatsContainer.Location = new System.Drawing.Point(3, 55);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStatsContainer.Size = new System.Drawing.Size(1357, 717);
            this.pnlStatsContainer.TabIndex = 1;
            // 
            // pnlRecentAttempts
            // 
            this.pnlRecentAttempts.BackColor = System.Drawing.Color.White;
            this.pnlRecentAttempts.Controls.Add(this.dgvRecentAttempts);
            this.pnlRecentAttempts.Controls.Add(this.lblRecentAttemptsTitle);
            this.pnlRecentAttempts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentAttempts.Location = new System.Drawing.Point(12, 842);
            this.pnlRecentAttempts.Name = "pnlRecentAttempts";
            this.pnlRecentAttempts.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRecentAttempts.Size = new System.Drawing.Size(1312, 280);
            this.pnlRecentAttempts.TabIndex = 3;
            // 
            // dgvRecentAttempts
            // 
            this.dgvRecentAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentAttempts.Location = new System.Drawing.Point(12, 42);
            this.dgvRecentAttempts.Name = "dgvRecentAttempts";
            this.dgvRecentAttempts.RowHeadersWidth = 51;
            this.dgvRecentAttempts.Size = new System.Drawing.Size(1288, 226);
            this.dgvRecentAttempts.TabIndex = 1;
            this.dgvRecentAttempts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentAttempts_CellContentClick);
            // 
            // lblRecentAttemptsTitle
            // 
            this.lblRecentAttemptsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentAttemptsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentAttemptsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblRecentAttemptsTitle.Name = "lblRecentAttemptsTitle";
            this.lblRecentAttemptsTitle.Size = new System.Drawing.Size(1288, 30);
            this.lblRecentAttemptsTitle.TabIndex = 0;
            this.lblRecentAttemptsTitle.Text = "Lần làm gần đây";
            this.lblRecentAttemptsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlByTest
            // 
            this.pnlByTest.BackColor = System.Drawing.Color.White;
            this.pnlByTest.Controls.Add(this.dgvStatsByTest);
            this.pnlByTest.Controls.Add(this.lblByTestTitle);
            this.pnlByTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByTest.Location = new System.Drawing.Point(12, 522);
            this.pnlByTest.Name = "pnlByTest";
            this.pnlByTest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlByTest.Size = new System.Drawing.Size(1312, 320);
            this.pnlByTest.TabIndex = 2;
            // 
            // dgvStatsByTest
            // 
            this.dgvStatsByTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsByTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsByTest.Location = new System.Drawing.Point(12, 42);
            this.dgvStatsByTest.Name = "dgvStatsByTest";
            this.dgvStatsByTest.RowHeadersWidth = 51;
            this.dgvStatsByTest.Size = new System.Drawing.Size(1288, 266);
            this.dgvStatsByTest.TabIndex = 1;
            // 
            // lblByTestTitle
            // 
            this.lblByTestTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblByTestTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblByTestTitle.Location = new System.Drawing.Point(12, 12);
            this.lblByTestTitle.Name = "lblByTestTitle";
            this.lblByTestTitle.Size = new System.Drawing.Size(1288, 30);
            this.lblByTestTitle.TabIndex = 0;
            this.lblByTestTitle.Text = "Hiệu suất theo Test";
            this.lblByTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlByPart
            // 
            this.pnlByPart.BackColor = System.Drawing.Color.White;
            this.pnlByPart.Controls.Add(this.dgvStatsByPart);
            this.pnlByPart.Controls.Add(this.lblByPartTitle);
            this.pnlByPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByPart.Location = new System.Drawing.Point(12, 272);
            this.pnlByPart.Name = "pnlByPart";
            this.pnlByPart.Padding = new System.Windows.Forms.Padding(12);
            this.pnlByPart.Size = new System.Drawing.Size(1312, 250);
            this.pnlByPart.TabIndex = 1;
            // 
            // dgvStatsByPart
            // 
            this.dgvStatsByPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsByPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsByPart.Location = new System.Drawing.Point(12, 42);
            this.dgvStatsByPart.Name = "dgvStatsByPart";
            this.dgvStatsByPart.RowHeadersWidth = 51;
            this.dgvStatsByPart.Size = new System.Drawing.Size(1288, 196);
            this.dgvStatsByPart.TabIndex = 1;
            this.dgvStatsByPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStatsByPart_DataBindingComplete);
            // 
            // lblByPartTitle
            // 
            this.lblByPartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblByPartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblByPartTitle.Location = new System.Drawing.Point(12, 12);
            this.lblByPartTitle.Name = "lblByPartTitle";
            this.lblByPartTitle.Size = new System.Drawing.Size(1288, 30);
            this.lblByPartTitle.TabIndex = 0;
            this.lblByPartTitle.Text = "Hiệu suất theo Part";
            this.lblByPartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.White;
            this.pnlOverview.Controls.Add(this.tlpOverview);
            this.pnlOverview.Controls.Add(this.lblOverviewTitle);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOverview.Location = new System.Drawing.Point(12, 12);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Padding = new System.Windows.Forms.Padding(12);
            this.pnlOverview.Size = new System.Drawing.Size(1312, 260);
            this.pnlOverview.TabIndex = 0;
            // 
            // tlpOverview
            // 
            this.tlpOverview.ColumnCount = 4;
            this.tlpOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOverview.Controls.Add(this.pnlCardTotalAttempts, 0, 0);
            this.tlpOverview.Controls.Add(this.pnlCardTotalQuestions, 1, 0);
            this.tlpOverview.Controls.Add(this.pnlCardTotalCorrect, 2, 0);
            this.tlpOverview.Controls.Add(this.pnlCardAccuracy, 3, 0);
            this.tlpOverview.Controls.Add(this.pnlCardTotalWrong, 0, 1);
            this.tlpOverview.Controls.Add(this.pnlCardTotalSkipped, 1, 1);
            this.tlpOverview.Controls.Add(this.pnlCardAvgDuration, 2, 1);
            this.tlpOverview.Controls.Add(this.pnlCardLastSubmitted, 3, 1);
            this.tlpOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOverview.Location = new System.Drawing.Point(12, 42);
            this.tlpOverview.Name = "tlpOverview";
            this.tlpOverview.RowCount = 2;
            this.tlpOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverview.Size = new System.Drawing.Size(1288, 206);
            this.tlpOverview.TabIndex = 1;
            // 
            // pnlCardTotalAttempts
            // 
            this.pnlCardTotalAttempts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotalAttempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalAttempts.Controls.Add(this.lblTotalAttempts);
            this.pnlCardTotalAttempts.Controls.Add(this.lblTotalAttemptsTitle);
            this.pnlCardTotalAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTotalAttempts.Location = new System.Drawing.Point(8, 8);
            this.pnlCardTotalAttempts.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardTotalAttempts.Name = "pnlCardTotalAttempts";
            this.pnlCardTotalAttempts.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardTotalAttempts.Size = new System.Drawing.Size(306, 87);
            this.pnlCardTotalAttempts.TabIndex = 0;
            // 
            // lblTotalAttempts
            // 
            this.lblTotalAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAttempts.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalAttempts.Location = new System.Drawing.Point(12, 36);
            this.lblTotalAttempts.Name = "lblTotalAttempts";
            this.lblTotalAttempts.Size = new System.Drawing.Size(280, 37);
            this.lblTotalAttempts.TabIndex = 0;
            this.lblTotalAttempts.Text = "0";
            this.lblTotalAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAttemptsTitle
            // 
            this.lblTotalAttemptsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAttemptsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalAttemptsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalAttemptsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalAttemptsTitle.Name = "lblTotalAttemptsTitle";
            this.lblTotalAttemptsTitle.Size = new System.Drawing.Size(280, 24);
            this.lblTotalAttemptsTitle.TabIndex = 1;
            this.lblTotalAttemptsTitle.Text = "Tổng bài đã nộp";
            // 
            // pnlCardTotalQuestions
            // 
            this.pnlCardTotalQuestions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotalQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalQuestions.Controls.Add(this.lblTotalQuestions);
            this.pnlCardTotalQuestions.Controls.Add(this.lblTotalQuestionsTitle);
            this.pnlCardTotalQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTotalQuestions.Location = new System.Drawing.Point(330, 8);
            this.pnlCardTotalQuestions.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardTotalQuestions.Name = "pnlCardTotalQuestions";
            this.pnlCardTotalQuestions.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardTotalQuestions.Size = new System.Drawing.Size(306, 87);
            this.pnlCardTotalQuestions.TabIndex = 1;
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuestions.Location = new System.Drawing.Point(12, 36);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(280, 37);
            this.lblTotalQuestions.TabIndex = 0;
            this.lblTotalQuestions.Text = "0";
            this.lblTotalQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalQuestionsTitle
            // 
            this.lblTotalQuestionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalQuestionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalQuestionsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalQuestionsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalQuestionsTitle.Name = "lblTotalQuestionsTitle";
            this.lblTotalQuestionsTitle.Size = new System.Drawing.Size(280, 24);
            this.lblTotalQuestionsTitle.TabIndex = 1;
            this.lblTotalQuestionsTitle.Text = "Tổng câu đã làm";
            // 
            // pnlCardTotalCorrect
            // 
            this.pnlCardTotalCorrect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotalCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalCorrect.Controls.Add(this.lblTotalCorrect);
            this.pnlCardTotalCorrect.Controls.Add(this.lblTotalCorrectTitle);
            this.pnlCardTotalCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTotalCorrect.Location = new System.Drawing.Point(652, 8);
            this.pnlCardTotalCorrect.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardTotalCorrect.Name = "pnlCardTotalCorrect";
            this.pnlCardTotalCorrect.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardTotalCorrect.Size = new System.Drawing.Size(306, 87);
            this.pnlCardTotalCorrect.TabIndex = 2;
            // 
            // lblTotalCorrect
            // 
            this.lblTotalCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCorrect.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalCorrect.Location = new System.Drawing.Point(12, 36);
            this.lblTotalCorrect.Name = "lblTotalCorrect";
            this.lblTotalCorrect.Size = new System.Drawing.Size(280, 37);
            this.lblTotalCorrect.TabIndex = 0;
            this.lblTotalCorrect.Text = "0";
            this.lblTotalCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCorrectTitle
            // 
            this.lblTotalCorrectTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCorrectTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalCorrectTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalCorrectTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalCorrectTitle.Name = "lblTotalCorrectTitle";
            this.lblTotalCorrectTitle.Size = new System.Drawing.Size(280, 24);
            this.lblTotalCorrectTitle.TabIndex = 1;
            this.lblTotalCorrectTitle.Text = "Tổng đúng";
            // 
            // pnlCardAccuracy
            // 
            this.pnlCardAccuracy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardAccuracy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAccuracy.Controls.Add(this.lblAccuracy);
            this.pnlCardAccuracy.Controls.Add(this.lblAccuracyTitle);
            this.pnlCardAccuracy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardAccuracy.Location = new System.Drawing.Point(974, 8);
            this.pnlCardAccuracy.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardAccuracy.Name = "pnlCardAccuracy";
            this.pnlCardAccuracy.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardAccuracy.Size = new System.Drawing.Size(306, 87);
            this.pnlCardAccuracy.TabIndex = 3;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccuracy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAccuracy.Location = new System.Drawing.Point(12, 36);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(280, 37);
            this.lblAccuracy.TabIndex = 0;
            this.lblAccuracy.Text = "0%";
            this.lblAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccuracyTitle
            // 
            this.lblAccuracyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccuracyTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAccuracyTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccuracyTitle.Location = new System.Drawing.Point(12, 12);
            this.lblAccuracyTitle.Name = "lblAccuracyTitle";
            this.lblAccuracyTitle.Size = new System.Drawing.Size(280, 24);
            this.lblAccuracyTitle.TabIndex = 1;
            this.lblAccuracyTitle.Text = "Accuracy %";
            // 
            // pnlCardTotalWrong
            // 
            this.pnlCardTotalWrong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotalWrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalWrong.Controls.Add(this.lblTotalWrong);
            this.pnlCardTotalWrong.Controls.Add(this.lblTotalWrongTitle);
            this.pnlCardTotalWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTotalWrong.Location = new System.Drawing.Point(8, 111);
            this.pnlCardTotalWrong.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardTotalWrong.Name = "pnlCardTotalWrong";
            this.pnlCardTotalWrong.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardTotalWrong.Size = new System.Drawing.Size(306, 87);
            this.pnlCardTotalWrong.TabIndex = 4;
            // 
            // lblTotalWrong
            // 
            this.lblTotalWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalWrong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalWrong.Location = new System.Drawing.Point(12, 36);
            this.lblTotalWrong.Name = "lblTotalWrong";
            this.lblTotalWrong.Size = new System.Drawing.Size(280, 37);
            this.lblTotalWrong.TabIndex = 0;
            this.lblTotalWrong.Text = "0";
            this.lblTotalWrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalWrongTitle
            // 
            this.lblTotalWrongTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalWrongTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalWrongTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalWrongTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalWrongTitle.Name = "lblTotalWrongTitle";
            this.lblTotalWrongTitle.Size = new System.Drawing.Size(280, 24);
            this.lblTotalWrongTitle.TabIndex = 1;
            this.lblTotalWrongTitle.Text = "Tổng sai";
            // 
            // pnlCardTotalSkipped
            // 
            this.pnlCardTotalSkipped.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotalSkipped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalSkipped.Controls.Add(this.lblTotalSkipped);
            this.pnlCardTotalSkipped.Controls.Add(this.lblTotalSkippedTitle);
            this.pnlCardTotalSkipped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTotalSkipped.Location = new System.Drawing.Point(330, 111);
            this.pnlCardTotalSkipped.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardTotalSkipped.Name = "pnlCardTotalSkipped";
            this.pnlCardTotalSkipped.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardTotalSkipped.Size = new System.Drawing.Size(306, 87);
            this.pnlCardTotalSkipped.TabIndex = 5;
            // 
            // lblTotalSkipped
            // 
            this.lblTotalSkipped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSkipped.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalSkipped.Location = new System.Drawing.Point(12, 36);
            this.lblTotalSkipped.Name = "lblTotalSkipped";
            this.lblTotalSkipped.Size = new System.Drawing.Size(280, 37);
            this.lblTotalSkipped.TabIndex = 0;
            this.lblTotalSkipped.Text = "0";
            this.lblTotalSkipped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSkippedTitle
            // 
            this.lblTotalSkippedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalSkippedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalSkippedTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalSkippedTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTotalSkippedTitle.Name = "lblTotalSkippedTitle";
            this.lblTotalSkippedTitle.Size = new System.Drawing.Size(280, 24);
            this.lblTotalSkippedTitle.TabIndex = 1;
            this.lblTotalSkippedTitle.Text = "Tổng bỏ qua";
            // 
            // pnlCardAvgDuration
            // 
            this.pnlCardAvgDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardAvgDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAvgDuration.Controls.Add(this.lblAvgDuration);
            this.pnlCardAvgDuration.Controls.Add(this.lblAvgDurationTitle);
            this.pnlCardAvgDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardAvgDuration.Location = new System.Drawing.Point(652, 111);
            this.pnlCardAvgDuration.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardAvgDuration.Name = "pnlCardAvgDuration";
            this.pnlCardAvgDuration.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardAvgDuration.Size = new System.Drawing.Size(306, 87);
            this.pnlCardAvgDuration.TabIndex = 6;
            // 
            // lblAvgDuration
            // 
            this.lblAvgDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvgDuration.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAvgDuration.Location = new System.Drawing.Point(12, 36);
            this.lblAvgDuration.Name = "lblAvgDuration";
            this.lblAvgDuration.Size = new System.Drawing.Size(280, 37);
            this.lblAvgDuration.TabIndex = 0;
            this.lblAvgDuration.Text = "00:00";
            this.lblAvgDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvgDurationTitle
            // 
            this.lblAvgDurationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvgDurationTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgDurationTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblAvgDurationTitle.Location = new System.Drawing.Point(12, 12);
            this.lblAvgDurationTitle.Name = "lblAvgDurationTitle";
            this.lblAvgDurationTitle.Size = new System.Drawing.Size(280, 24);
            this.lblAvgDurationTitle.TabIndex = 1;
            this.lblAvgDurationTitle.Text = "Thời gian trung bình";
            // 
            // pnlCardLastSubmitted
            // 
            this.pnlCardLastSubmitted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardLastSubmitted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardLastSubmitted.Controls.Add(this.lblLastSubmitted);
            this.pnlCardLastSubmitted.Controls.Add(this.lblLastSubmittedTitle);
            this.pnlCardLastSubmitted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardLastSubmitted.Location = new System.Drawing.Point(974, 111);
            this.pnlCardLastSubmitted.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardLastSubmitted.Name = "pnlCardLastSubmitted";
            this.pnlCardLastSubmitted.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardLastSubmitted.Size = new System.Drawing.Size(306, 87);
            this.pnlCardLastSubmitted.TabIndex = 7;
            // 
            // lblLastSubmitted
            // 
            this.lblLastSubmitted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastSubmitted.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLastSubmitted.Location = new System.Drawing.Point(12, 36);
            this.lblLastSubmitted.Name = "lblLastSubmitted";
            this.lblLastSubmitted.Size = new System.Drawing.Size(280, 37);
            this.lblLastSubmitted.TabIndex = 0;
            this.lblLastSubmitted.Text = "--";
            this.lblLastSubmitted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastSubmittedTitle
            // 
            this.lblLastSubmittedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastSubmittedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastSubmittedTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblLastSubmittedTitle.Location = new System.Drawing.Point(12, 12);
            this.lblLastSubmittedTitle.Name = "lblLastSubmittedTitle";
            this.lblLastSubmittedTitle.Size = new System.Drawing.Size(280, 24);
            this.lblLastSubmittedTitle.TabIndex = 1;
            this.lblLastSubmittedTitle.Text = "Lần nộp gần nhất";
            // 
            // lblOverviewTitle
            // 
            this.lblOverviewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOverviewTitle.Location = new System.Drawing.Point(12, 12);
            this.lblOverviewTitle.Name = "lblOverviewTitle";
            this.lblOverviewTitle.Size = new System.Drawing.Size(1288, 30);
            this.lblOverviewTitle.TabIndex = 0;
            this.lblOverviewTitle.Text = "Tổng quan";
            this.lblOverviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatsNav
            // 
            this.pnlStatsNav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStatsNav.Controls.Add(this.btnStatsOverview);
            this.pnlStatsNav.Controls.Add(this.btnStatsByPart);
            this.pnlStatsNav.Controls.Add(this.btnStatsByTest);
            this.pnlStatsNav.Controls.Add(this.btnStatsRecent);
            this.pnlStatsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsNav.Location = new System.Drawing.Point(3, 3);
            this.pnlStatsNav.Name = "pnlStatsNav";
            this.pnlStatsNav.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlStatsNav.Size = new System.Drawing.Size(1357, 52);
            this.pnlStatsNav.TabIndex = 0;
            // 
            // btnStatsOverview
            // 
            this.btnStatsOverview.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatsOverview.Location = new System.Drawing.Point(12, 10);
            this.btnStatsOverview.Name = "btnStatsOverview";
            this.btnStatsOverview.Size = new System.Drawing.Size(110, 32);
            this.btnStatsOverview.TabIndex = 0;
            this.btnStatsOverview.Text = "Tổng quan";
            this.btnStatsOverview.UseVisualStyleBackColor = true;
            // 
            // btnStatsByPart
            // 
            this.btnStatsByPart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatsByPart.Location = new System.Drawing.Point(132, 10);
            this.btnStatsByPart.Name = "btnStatsByPart";
            this.btnStatsByPart.Size = new System.Drawing.Size(110, 32);
            this.btnStatsByPart.TabIndex = 1;
            this.btnStatsByPart.Text = "Theo Part";
            this.btnStatsByPart.UseVisualStyleBackColor = true;
            // 
            // btnStatsByTest
            // 
            this.btnStatsByTest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatsByTest.Location = new System.Drawing.Point(252, 10);
            this.btnStatsByTest.Name = "btnStatsByTest";
            this.btnStatsByTest.Size = new System.Drawing.Size(110, 32);
            this.btnStatsByTest.TabIndex = 2;
            this.btnStatsByTest.Text = "Theo Test";
            this.btnStatsByTest.UseVisualStyleBackColor = true;
            // 
            // btnStatsRecent
            // 
            this.btnStatsRecent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStatsRecent.Location = new System.Drawing.Point(372, 10);
            this.btnStatsRecent.Name = "btnStatsRecent";
            this.btnStatsRecent.Size = new System.Drawing.Size(110, 32);
            this.btnStatsRecent.TabIndex = 3;
            this.btnStatsRecent.Text = "Gần đây";
            this.btnStatsRecent.UseVisualStyleBackColor = true;
            // 
            // lblThongKe
            // 
            this.lblThongKe.Location = new System.Drawing.Point(0, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(100, 23);
            this.lblThongKe.TabIndex = 0;
            //
            // btnDangXuat
            //
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Location = new System.Drawing.Point(1087, 15);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 34);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 811);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOEIC Practice - Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabChonDe.ResumeLayout(false);
            this.pnlChonDeBody.ResumeLayout(false);
            this.pnlCauHinhLuyenTap.ResumeLayout(false);
            this.pnlCauHinhLuyenTap.PerformLayout();
            this.pnlDanhSachTest.ResumeLayout(false);
            this.pnlChonDeTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tabLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.pnlLichSuTop.ResumeLayout(false);
            this.pnlLichSuTop.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.pnlStatsContainer.ResumeLayout(false);
            this.pnlRecentAttempts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).EndInit();
            this.pnlByTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsByTest)).EndInit();
            this.pnlByPart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsByPart)).EndInit();
            this.pnlOverview.ResumeLayout(false);
            this.tlpOverview.ResumeLayout(false);
            this.pnlCardTotalAttempts.ResumeLayout(false);
            this.pnlCardTotalQuestions.ResumeLayout(false);
            this.pnlCardTotalCorrect.ResumeLayout(false);
            this.pnlCardAccuracy.ResumeLayout(false);
            this.pnlCardTotalWrong.ResumeLayout(false);
            this.pnlCardTotalSkipped.ResumeLayout(false);
            this.pnlCardAvgDuration.ResumeLayout(false);
            this.pnlCardLastSubmitted.ResumeLayout(false);
            this.pnlStatsNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabChonDe;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.TabPage tabThongKe;

        private System.Windows.Forms.Panel pnlChonDeTop;
        private System.Windows.Forms.FlowLayoutPanel flowYears;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlChonDeBody;

        // View 1
        private System.Windows.Forms.Panel pnlDanhSachTest;
        private System.Windows.Forms.FlowLayoutPanel flowTests;

        // View 2
        private System.Windows.Forms.Panel pnlCauHinhLuyenTap;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTestDangChon;
        private System.Windows.Forms.Label lblChonPart;
        private System.Windows.Forms.CheckedListBox clbParts;
        private System.Windows.Forms.Label lblGioiHan;
        private System.Windows.Forms.ComboBox cboTimeLimit;
        private System.Windows.Forms.Button btnLuyenTap;

        private System.Windows.Forms.Panel pnlLichSuTop;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label lblThongKe;

        // Lich su
        private System.Windows.Forms.Panel pnlLichSuBody;

        private System.Windows.Forms.Panel pnlHistorySelect;
        private System.Windows.Forms.Panel pnlHistorySelectTop;
        private System.Windows.Forms.FlowLayoutPanel flowHistoryYears;
        private System.Windows.Forms.Panel pnlHistorySearch;
        private System.Windows.Forms.Label lblHistorySearch;
        private System.Windows.Forms.TextBox txtHistorySearchYear;
        private System.Windows.Forms.Button btnHistorySearch;
        private System.Windows.Forms.Panel pnlHistoryTestList;
        private System.Windows.Forms.FlowLayoutPanel flowHistoryTests;

        private System.Windows.Forms.Panel pnlHistoryDetail;
        private System.Windows.Forms.Panel pnlHistoryDetailTop;
        private System.Windows.Forms.Button btnHistoryBack;
        private System.Windows.Forms.Label lblHistoryTestHeader;

        // Thống kê
        // ===== TAB THONG KE =====
        private System.Windows.Forms.Panel pnlStatsNav;
        private System.Windows.Forms.Button btnStatsOverview;
        private System.Windows.Forms.Button btnStatsByPart;
        private System.Windows.Forms.Button btnStatsByTest;
        private System.Windows.Forms.Button btnStatsRecent;

        private System.Windows.Forms.Panel pnlStatsContainer;

        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.TableLayoutPanel tlpOverview;

        private System.Windows.Forms.Panel pnlByPart;
        private System.Windows.Forms.Label lblByPartTitle;
        private System.Windows.Forms.DataGridView dgvStatsByPart;

        private System.Windows.Forms.Panel pnlByTest;
        private System.Windows.Forms.Label lblByTestTitle;
        private System.Windows.Forms.DataGridView dgvStatsByTest;

        private System.Windows.Forms.Panel pnlRecentAttempts;
        private System.Windows.Forms.Label lblRecentAttemptsTitle;
        private System.Windows.Forms.DataGridView dgvRecentAttempts;

        // 8 cards
        private System.Windows.Forms.Panel pnlCardTotalAttempts;
        private System.Windows.Forms.Panel pnlCardTotalQuestions;
        private System.Windows.Forms.Panel pnlCardTotalCorrect;
        private System.Windows.Forms.Panel pnlCardAccuracy;
        private System.Windows.Forms.Panel pnlCardTotalWrong;
        private System.Windows.Forms.Panel pnlCardTotalSkipped;
        private System.Windows.Forms.Panel pnlCardAvgDuration;
        private System.Windows.Forms.Panel pnlCardLastSubmitted;

        // title labels trong card
        private System.Windows.Forms.Label lblTotalAttemptsTitle;
        private System.Windows.Forms.Label lblTotalQuestionsTitle;
        private System.Windows.Forms.Label lblTotalCorrectTitle;
        private System.Windows.Forms.Label lblAccuracyTitle;
        private System.Windows.Forms.Label lblTotalWrongTitle;
        private System.Windows.Forms.Label lblTotalSkippedTitle;
        private System.Windows.Forms.Label lblAvgDurationTitle;
        private System.Windows.Forms.Label lblLastSubmittedTitle;

        // value labels trong card
        private System.Windows.Forms.Label lblTotalAttempts;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblTotalCorrect;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblTotalWrong;
        private System.Windows.Forms.Label lblTotalSkipped;
        private System.Windows.Forms.Label lblAvgDuration;
        private System.Windows.Forms.Label lblLastSubmitted;
    }
}