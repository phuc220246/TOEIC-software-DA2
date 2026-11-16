using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.History;
using TOEIC_Practice.BLL.LamBai;
using TOEIC_Practice.BLL.NoiDungDe;
using TOEIC_Practice.BLL.Stats;
using TOEIC_Practice.DTO.History;
using TOEIC_Practice.DTO.NoiDungDe;
using TOEIC_Practice.DTO;

using TOEIC_Practice.DTO.Stats;


namespace TOEIC_Practice.GUI
{
    public partial class FrmMain : Form
    {
        private readonly EtsBLL _etsBll = new EtsBLL();
        private readonly TestBLL _testBll = new TestBLL();
        private readonly PartBLL _partBll = new PartBLL();
        private readonly AttemptBLL _attemptBll = new AttemptBLL();
        private readonly HistoryBLL _historyBll = new HistoryBLL();
        private readonly StatsBLL _statsBLL = new StatsBLL();

        private List<EtsDTO> _etsList = new List<EtsDTO>();
        private List<PartDTO> _parts = new List<PartDTO>();

        private int _historySelectedEtsId = -1;
        private TestDTO _historySelectedTest = null;
        private int _selectedEtsId = -1;
        private TestDTO _selectedTest = null;

        public FrmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadParts();          // load 7 part cho view cấu hình
            SetupTimeLimit();     // set combo thời gian
            LoadYears();          // load nút năm
            ShowDanhSachTest();   // hiển thị view 1
            InitHistoryTab();         // tab Lịch sử
            InitStatsTab();       // tab thống kê
        }

        // ======= VIEW SWITCH =======
        private void ShowDanhSachTest()
        {
            pnlDanhSachTest.Visible = true;
            pnlCauHinhLuyenTap.Visible = false;
            _selectedTest = null;
        }

        // ======= LOAD PARTS =======
        private void LoadParts()
        {
            _parts = _partBll.GetAll();
            clbParts.Items.Clear();

            // CheckedListBox hiển thị theo ToString() của PartDTO
            foreach (var p in _parts)
                clbParts.Items.Add(p, true);
        }

        private void SetupTimeLimit()
        {
            // Giống Study4: cho chọn giới hạn thời gian (để trống = không giới hạn)
            cboTimeLimit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimeLimit.Items.Clear();
            cboTimeLimit.Items.Add("Không giới hạn thời gian");
            cboTimeLimit.Items.Add("120 phút (Full TOEIC)");
            cboTimeLimit.Items.Add("60 phút");
            cboTimeLimit.Items.Add("45 phút");
            cboTimeLimit.Items.Add("30 phút");
            cboTimeLimit.Items.Add("15 phút");
            cboTimeLimit.SelectedIndex = 0;
        }

        private int? GetTimeLimitMinutes()
        {
            // Trả null nếu không giới hạn
            switch (cboTimeLimit.SelectedIndex)
            {
                case 0: return null;
                case 1: return 120;
                case 2: return 60;
                case 3: return 45;
                case 4: return 30;
                case 5: return 15;
                default: return null;
            }
        }

        // ======= YEARS (ETS) =======
        private void LoadYears()
        {
            flowYears.Controls.Clear();

            _etsList = _etsBll.GetAll()
                              .OrderByDescending(x => x.Year)
                              .ToList();

            foreach (var ets in _etsList)
            {
                Button btn = new Button();
                btn.Text = ets.Year.ToString();
                btn.Tag = ets;
                btn.Width = 70;
                btn.Height = 34;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.Click += YearButton_Click;

                flowYears.Controls.Add(btn);
            }

            if (_etsList.Count > 0)
            {
                SelectEts(_etsList[0].EtsId);
                HighlightSelectedYear(_etsList[0].Year);
            }
        }

        private void YearButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ets = btn.Tag as EtsDTO;

            SelectEts(ets.EtsId);
            HighlightSelectedYear(ets.Year);

            // nếu đang ở view cấu hình, đổi năm thì quay lại danh sách
            ShowDanhSachTest();
        }

        private void HighlightSelectedYear(int year)
        {
            foreach (Control c in flowYears.Controls)
            {
                if (c is Button b)
                    b.BackColor = (b.Text == year.ToString()) ? Color.LightSteelBlue : Color.White;
            }
        }

        private void SelectEts(int etsId)
        {
            _selectedEtsId = etsId;
            LoadTestsByEts(etsId);
        }

        // ======= TEST LIST (CARDS) =======
        private void LoadTestsByEts(int etsId)
        {
            flowTests.Controls.Clear();

            var tests = _testBll.GetByEts(etsId);
            foreach (var t in tests)
                flowTests.Controls.Add(CreateTestCard(t));
        }

        private Control CreateTestCard(TestDTO t)
        {
            Panel card = new Panel();
            card.Width = 260;
            card.Height = 165;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);
            card.BackColor = Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = string.IsNullOrWhiteSpace(t.Title)
                ? $"TOEIC Test {t.TestNo}"
                : t.Title;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.Width = card.Width - 20;
            lblTitle.Height = 44;
            lblTitle.Location = new Point(10, 10);

            Label lblInfo = new Label();
            lblInfo.Text = "120 phút | 7 phần | 200 câu";
            lblInfo.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblInfo.AutoSize = false;
            lblInfo.Width = card.Width - 20;
            lblInfo.Height = 20;
            lblInfo.Location = new Point(10, 60);

            // Giống Study4: nút "Luyện tập" / "Chi tiết" / "Xem kết quả"
            Button btnLuyen = new Button();
            btnLuyen.Text = "Luyện tập";
            btnLuyen.Width = 110;
            btnLuyen.Height = 34;
            btnLuyen.Location = new Point(10, 105);
            btnLuyen.Tag = t;
            btnLuyen.Click += BtnLuyen_Click;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblInfo);
            card.Controls.Add(btnLuyen);
            return card;
        }

        private void BtnLuyen_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                if (btn == null)
                {
                    MessageBox.Show("Không xác định được nút bấm.");
                    return;
                }

                var test = btn.Tag as TestDTO;
                if (test == null)
                {
                    MessageBox.Show("Không lấy được thông tin Test (Tag bị rỗng).");
                    return;
                }

                // ✅ Popup chọn Part + TimeLimit (Option 1)
                using (var f = new FrmChonPart())
                {
                    if (f.ShowDialog(this) != DialogResult.OK)
                        return;

                    int attemptId = _attemptBll.StartAttempt(
                        Session.AccountId,          // user đang đăng nhập
                        test.TestId,                // lấy testId từ TestDTO
                        f.SelectedPartIdsCsv,       // vd: "5" hoặc "5,6,7"
                        f.TimeLimitMinutes          // null hoặc 15/30/...
                    );

                    // ✅ Mở form làm bài
                    var frm = new FrmLamBai(attemptId);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Luyện tập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ======= SEARCH YEAR =======
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearchYear.Text.Trim();
            if (string.IsNullOrWhiteSpace(kw))
            {
                LoadYears();
                return;
            }

            var filtered = _etsList.Where(x => x.Year.ToString().Contains(kw)).ToList();
            if (filtered.Count == 0)
            {
                MessageBox.Show("Không tìm thấy năm ETS phù hợp!");
                return;
            }

            flowYears.Controls.Clear();
            foreach (var ets in filtered.OrderByDescending(x => x.Year))
            {
                Button btn = new Button();
                btn.Text = ets.Year.ToString();
                btn.Tag = ets;
                btn.Width = 70;
                btn.Height = 34;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.Click += YearButton_Click;
                flowYears.Controls.Add(btn);
            }

            SelectEts(filtered[0].EtsId);
            HighlightSelectedYear(filtered[0].Year);
            ShowDanhSachTest();
        }

        // ======= VIEW 2 BUTTONS =======
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ShowDanhSachTest();
        }

        private void btnLuyenTap_Click(object sender, EventArgs e)
        {
            if (_selectedTest == null)
            {
                MessageBox.Show("Bạn chưa chọn test!");
                return;
            }

            // part đã tick
            var partIds = new List<int>();
            foreach (var item in clbParts.CheckedItems)
            {
                if (item is PartDTO p)
                    partIds.Add(p.PartId);
            }

            if (partIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 Part.");
                return;
            }

            bool isFull = (partIds.Count == _parts.Count);
            int? limitMinutes = GetTimeLimitMinutes();

            // 1) Tạo Attempt trong DB
            int attemptId = _attemptBll.StartAttempt(Session.AccountId, _selectedTest.TestId, partIds, limitMinutes);

            // 2) Mở form làm bài
            FrmLamBai f = new FrmLamBai(attemptId);
            f.Show();
            // Tạm thời test — bước sau sẽ gọi Attempt_Start và mở FrmLamBai
            MessageBox.Show(
                $"Bắt đầu luyện tập\nTestId={_selectedTest.TestId}\n" +
                $"Parts: {string.Join(",", partIds)}\n" +
                $"Chế độ: {(isFull ? "FULL" : "CHỌN PART")}\n" +
                $"Giới hạn: {(limitMinutes.HasValue ? limitMinutes + " phút" : "Không giới hạn")}"
            );

            // TODO bước sau:
            // var f = new FrmLamBai(_selectedTest.TestId, partIds, limitMinutes);
            // f.Show();
        }

        private void pnlCauHinhLuyenTap_Paint(object sender, PaintEventArgs e)
        {

        }
        // =========================
        // HISTORY TAB
        // =========================

        private void InitHistoryTab()
        {
            BuildHistoryLayout();
            LoadHistoryYears();
            ShowHistorySelectView();
        }

        private void BuildHistoryLayout()
        {
            // xóa UI cũ của tab lịch sử
            tabLichSu.Controls.Clear();

            // ===== TOP =====
            pnlLichSuTop = new Panel();
            pnlLichSuTop.Dock = DockStyle.Top;
            pnlLichSuTop.Height = 56;

            lblLichSu = new Label();
            lblLichSu.AutoSize = true;
            lblLichSu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLichSu.Location = new Point(18, 16);
            lblLichSu.Text = "Lịch sử làm bài của bạn";

            pnlLichSuTop.Controls.Add(lblLichSu);

            // ===== BODY WRAPPER =====
            pnlLichSuBody = new Panel();
            pnlLichSuBody.Dock = DockStyle.Fill;

            // ===== VIEW 1: CHỌN TEST =====
            pnlHistorySelect = new Panel();
            pnlHistorySelect.Dock = DockStyle.Fill;

            pnlHistorySelectTop = new Panel();
            pnlHistorySelectTop.Dock = DockStyle.Top;
            pnlHistorySelectTop.Height = 139;

            flowHistoryYears = new FlowLayoutPanel();
            flowHistoryYears.Dock = DockStyle.Top;
            flowHistoryYears.Height = 64;
            flowHistoryYears.Padding = new Padding(14, 13, 14, 0);
            flowHistoryYears.WrapContents = false;
            flowHistoryYears.AutoScroll = true;

            pnlHistorySearch = new Panel();
            pnlHistorySearch.Dock = DockStyle.Bottom;
            pnlHistorySearch.Height = 64;

            lblHistorySearch = new Label();
            lblHistorySearch.AutoSize = true;
            lblHistorySearch.Font = new Font("Segoe UI", 10F);
            lblHistorySearch.Location = new Point(14, 20);
            lblHistorySearch.Text = "Tìm theo năm";

            txtHistorySearchYear = new TextBox();
            txtHistorySearchYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHistorySearchYear.Font = new Font("Segoe UI", 10F);
            txtHistorySearchYear.Location = new Point(137, 17);
            txtHistorySearchYear.Width = 1064;

            btnHistorySearch = new Button();
            btnHistorySearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHistorySearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistorySearch.Location = new Point(1213, 15);
            btnHistorySearch.Size = new Size(126, 34);
            btnHistorySearch.Text = "Tìm kiếm";
            btnHistorySearch.Click += btnHistorySearch_Click;

            pnlHistorySearch.Controls.Add(lblHistorySearch);
            pnlHistorySearch.Controls.Add(txtHistorySearchYear);
            pnlHistorySearch.Controls.Add(btnHistorySearch);

            pnlHistorySelectTop.Controls.Add(flowHistoryYears);
            pnlHistorySelectTop.Controls.Add(pnlHistorySearch);

            pnlHistoryTestList = new Panel();
            pnlHistoryTestList.Dock = DockStyle.Fill;
            pnlHistoryTestList.Padding = new Padding(14, 13, 14, 13);

            flowHistoryTests = new FlowLayoutPanel();
            flowHistoryTests.Dock = DockStyle.Fill;
            flowHistoryTests.Padding = new Padding(14, 13, 14, 13);
            flowHistoryTests.AutoScroll = true;

            pnlHistoryTestList.Controls.Add(flowHistoryTests);

            pnlHistorySelect.Controls.Add(pnlHistoryTestList);
            pnlHistorySelect.Controls.Add(pnlHistorySelectTop);

            // ===== VIEW 2: CHI TIẾT HISTORY =====
            pnlHistoryDetail = new Panel();
            pnlHistoryDetail.Dock = DockStyle.Fill;
            pnlHistoryDetail.Visible = false;

            pnlHistoryDetailTop = new Panel();
            pnlHistoryDetailTop.Dock = DockStyle.Top;
            pnlHistoryDetailTop.Height = 72;

            btnHistoryBack = new Button();
            btnHistoryBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistoryBack.Location = new Point(14, 18);
            btnHistoryBack.Size = new Size(126, 36);
            btnHistoryBack.Text = "← Quay lại";
            btnHistoryBack.Click += btnHistoryBack_Click;

            lblHistoryTestHeader = new Label();
            lblHistoryTestHeader.AutoSize = true;
            lblHistoryTestHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHistoryTestHeader.Location = new Point(160, 24);
            lblHistoryTestHeader.Text = "Chưa chọn test";

            pnlHistoryDetailTop.Controls.Add(btnHistoryBack);
            pnlHistoryDetailTop.Controls.Add(lblHistoryTestHeader);

            dgvLichSu = new DataGridView();
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.AllowUserToAddRows = false;
            dgvLichSu.AllowUserToDeleteRows = false;
            dgvLichSu.ReadOnly = true;
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.AutoGenerateColumns = false;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichSu.MultiSelect = false;
            dgvLichSu.CellContentClick += dgvLichSu_CellContentClick;

            BuildHistoryGridColumns();

            pnlHistoryDetail.Controls.Add(dgvLichSu);
            pnlHistoryDetail.Controls.Add(pnlHistoryDetailTop);

            // ===== ADD BODY =====
            pnlLichSuBody.Controls.Add(pnlHistoryDetail);
            pnlLichSuBody.Controls.Add(pnlHistorySelect);

            tabLichSu.Controls.Add(pnlLichSuBody);
            tabLichSu.Controls.Add(pnlLichSuTop);
        }

        private void BuildHistoryGridColumns()
        {
            dgvLichSu.Columns.Clear();

            var colAttemptId = new DataGridViewTextBoxColumn();
            colAttemptId.Name = "colAttemptId";
            colAttemptId.DataPropertyName = "AttemptId";
            colAttemptId.Visible = false;

            var colNgayLam = new DataGridViewTextBoxColumn();
            colNgayLam.Name = "colNgayLam";
            colNgayLam.HeaderText = "Ngày làm";
            colNgayLam.DataPropertyName = "NgayLamText";
            colNgayLam.FillWeight = 24;

            var colPart = new DataGridViewTextBoxColumn();
            colPart.Name = "colPart";
            colPart.HeaderText = "Phần làm";
            colPart.DataPropertyName = "PartDisplayText";
            colPart.FillWeight = 18;

            var colKetQua = new DataGridViewTextBoxColumn();
            colKetQua.Name = "colKetQua";
            colKetQua.HeaderText = "Kết quả";
            colKetQua.DataPropertyName = "ResultText";
            colKetQua.FillWeight = 16;

            var colThoiGian = new DataGridViewTextBoxColumn();
            colThoiGian.Name = "colThoiGian";
            colThoiGian.HeaderText = "Thời gian làm bài";
            colThoiGian.DataPropertyName = "DurationText";
            colThoiGian.FillWeight = 22;

            var colChiTiet = new DataGridViewLinkColumn();
            colChiTiet.Name = "colChiTiet";
            colChiTiet.HeaderText = "";
            colChiTiet.Text = "Xem chi tiết";
            colChiTiet.UseColumnTextForLinkValue = true;
            colChiTiet.FillWeight = 20;

            dgvLichSu.Columns.Add(colAttemptId);
            dgvLichSu.Columns.Add(colNgayLam);
            dgvLichSu.Columns.Add(colPart);
            dgvLichSu.Columns.Add(colKetQua);
            dgvLichSu.Columns.Add(colThoiGian);
            dgvLichSu.Columns.Add(colChiTiet);
        }

        private void ShowHistorySelectView()
        {
            pnlHistorySelect.Visible = true;
            pnlHistoryDetail.Visible = false;
            lblLichSu.Text = "Lịch sử làm bài của bạn";
        }

        private void ShowHistoryDetailView()
        {
            pnlHistorySelect.Visible = false;
            pnlHistoryDetail.Visible = true;
        }

        private void LoadHistoryYears()
        {
            flowHistoryYears.Controls.Clear();

            var etsList = _etsBll.GetAll()
                .OrderByDescending(x => x.Year)
                .ToList();

            foreach (var ets in etsList)
            {
                Button btn = new Button();
                btn.Text = ets.Year.ToString();
                btn.Tag = ets;
                btn.Width = 70;
                btn.Height = 34;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.Click += HistoryYearButton_Click;

                flowHistoryYears.Controls.Add(btn);
            }

            if (etsList.Count > 0)
            {
                SelectHistoryEts(etsList[0].EtsId);
                HighlightHistorySelectedYear(etsList[0].Year);
            }
        }

        private void HistoryYearButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ets = btn?.Tag as EtsDTO;
            if (ets == null) return;

            SelectHistoryEts(ets.EtsId);
            HighlightHistorySelectedYear(ets.Year);
            ShowHistorySelectView();
        }

        private void HighlightHistorySelectedYear(int year)
        {
            foreach (Control c in flowHistoryYears.Controls)
            {
                if (c is Button b)
                    b.BackColor = (b.Text == year.ToString()) ? Color.LightSteelBlue : Color.White;
            }
        }

        private void SelectHistoryEts(int etsId)
        {
            _historySelectedEtsId = etsId;
            LoadHistoryTestsByEts(etsId);
        }

        private void LoadHistoryTestsByEts(int etsId)
        {
            flowHistoryTests.Controls.Clear();

            var tests = _testBll.GetByEts(etsId);
            foreach (var t in tests)
                flowHistoryTests.Controls.Add(CreateHistoryTestCard(t));
        }

        private Control CreateHistoryTestCard(TestDTO t)
        {
            Panel card = new Panel();
            card.Width = 260;
            card.Height = 165;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);
            card.BackColor = Color.White;

            Label lblTitle = new Label();
            lblTitle.Text = string.IsNullOrWhiteSpace(t.Title)
                ? $"TOEIC Test {t.TestNo}"
                : t.Title;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.Width = card.Width - 20;
            lblTitle.Height = 44;
            lblTitle.Location = new Point(10, 10);

            Label lblInfo = new Label();
            lblInfo.Text = "Xem các lần làm bài đã nộp";
            lblInfo.Font = new Font("Segoe UI", 9);
            lblInfo.AutoSize = false;
            lblInfo.Width = card.Width - 20;
            lblInfo.Height = 20;
            lblInfo.Location = new Point(10, 60);

            Button btnHistory = new Button();
            btnHistory.Text = "Xem lịch sử";
            btnHistory.Width = 110;
            btnHistory.Height = 34;
            btnHistory.Location = new Point(10, 105);
            btnHistory.Tag = t;
            btnHistory.Click += BtnXemLichSu_Click;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblInfo);
            card.Controls.Add(btnHistory);

            return card;
        }

        private void BtnXemLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                var test = btn?.Tag as TestDTO;
                if (test == null) return;

                _historySelectedTest = test;
                OpenHistoryDetail(test.TestId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi mở lịch sử",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpenHistoryDetail(int testId)
        {
            HistoryTestHeaderDTO header = _historyBll.GetTestHeader(testId);
            List<AttemptHistoryItemDTO> attempts = _historyBll.GetAttemptsByAccountAndTest(Session.AccountId, testId);

            lblHistoryTestHeader.Text = header != null
                ? $"Kết quả làm bài của bạn - {header.TestDisplayTitle}"
                : "Kết quả làm bài của bạn";

            dgvLichSu.DataSource = null;
            dgvLichSu.DataSource = attempts;

            ShowHistoryDetailView();
        }

        private void btnHistoryBack_Click(object sender, EventArgs e)
        {
            ShowHistorySelectView();
        }

        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            string kw = txtHistorySearchYear.Text.Trim();

            if (string.IsNullOrWhiteSpace(kw))
            {
                LoadHistoryYears();
                return;
            }

            var etsList = _etsBll.GetAll()
                .Where(x => x.Year.ToString().Contains(kw))
                .OrderByDescending(x => x.Year)
                .ToList();

            if (etsList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy năm ETS phù hợp!");
                return;
            }

            flowHistoryYears.Controls.Clear();

            foreach (var ets in etsList)
            {
                Button btn = new Button();
                btn.Text = ets.Year.ToString();
                btn.Tag = ets;
                btn.Width = 70;
                btn.Height = 34;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.Click += HistoryYearButton_Click;
                flowHistoryYears.Controls.Add(btn);
            }

            SelectHistoryEts(etsList[0].EtsId);
            HighlightHistorySelectedYear(etsList[0].Year);
            ShowHistorySelectView();
        }

        private void dgvLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvLichSu.Columns[e.ColumnIndex].Name != "colChiTiet") return;

            object v = dgvLichSu.Rows[e.RowIndex].Cells["colAttemptId"].Value;
            if (v == null) return;

            int attemptId = Convert.ToInt32(v);

            FrmXemLai f = new FrmXemLai(attemptId, 0);
            f.Show();
        }
        // =========================
        // STATS TAB
        // =========================
        private void InitStatsTab()
        {
            ApplyStatsGridStyle(dgvStatsByPart);
            ApplyStatsGridStyle(dgvStatsByTest);
            ApplyStatsGridStyle(dgvRecentAttempts);

            BuildStatsByPartColumns();
            BuildStatsByTestColumns();
            BuildRecentAttemptsColumns();

            int accountId = Session.AccountId;
            LoadStatsOverview(accountId);
            LoadStatsByPart(accountId);
            LoadStatsByTest(accountId);
            LoadRecentAttempts(accountId);

            dgvRecentAttempts.CellContentClick -= dgvRecentAttempts_CellContentClick;
            dgvRecentAttempts.CellContentClick += dgvRecentAttempts_CellContentClick;

            InitStatsNavButtons();
            BuildOverviewCardsText();
        }
        private void ApplyStatsGridStyle(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 36;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowTemplate.Height = 32;
        }
        private void BuildStatsByPartColumns()
        {
            dgvStatsByPart.Columns.Clear();
            dgvStatsByPart.AutoGenerateColumns = false;

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartName",
                HeaderText = "Part",
                DataPropertyName = "PartName",
                FillWeight = 18
            });

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartTotalQuestions",
                HeaderText = "Tổng câu",
                DataPropertyName = "TotalQuestions",
                FillWeight = 16
            });

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartCorrect",
                HeaderText = "Đúng",
                DataPropertyName = "CorrectCount",
                FillWeight = 14
            });

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartWrong",
                HeaderText = "Sai",
                DataPropertyName = "WrongCount",
                FillWeight = 14
            });

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartSkipped",
                HeaderText = "Bỏ qua",
                DataPropertyName = "SkippedCount",
                FillWeight = 14
            });

            dgvStatsByPart.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartAccuracy",
                HeaderText = "Accuracy %",
                DataPropertyName = "AccuracyText",
                FillWeight = 20
            });
        }
        private void BuildStatsByTestColumns()
        {
            dgvStatsByTest.Columns.Clear();
            dgvStatsByTest.AutoGenerateColumns = false;

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTestDisplayTitle",
                HeaderText = "Test",
                DataPropertyName = "TestDisplayTitle",
                FillWeight = 22
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTestTitle",
                HeaderText = "Tên bài",
                DataPropertyName = "TestTitle",
                FillWeight = 24
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAttemptCount",
                HeaderText = "Số lần làm",
                DataPropertyName = "AttemptCount",
                FillWeight = 12
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotalQuestions",
                HeaderText = "Tổng câu",
                DataPropertyName = "TotalQuestions",
                FillWeight = 12
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotalCorrect",
                HeaderText = "Tổng đúng",
                DataPropertyName = "TotalCorrect",
                FillWeight = 12
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAvgAccuracy",
                HeaderText = "Avg Accuracy",
                DataPropertyName = "AvgAccuracyText",
                FillWeight = 14
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBestAccuracy",
                HeaderText = "Best Accuracy",
                DataPropertyName = "BestAccuracyText",
                FillWeight = 14
            });

            dgvStatsByTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLastAttemptAt",
                HeaderText = "Lần làm gần nhất",
                DataPropertyName = "LastAttemptAtText",
                FillWeight = 18
            });
        }
        private void BuildRecentAttemptsColumns()
        {
            dgvRecentAttempts.Columns.Clear();
            dgvRecentAttempts.AutoGenerateColumns = false;

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentAttemptId",
                DataPropertyName = "AttemptId",
                Visible = false
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentTest",
                HeaderText = "Test",
                DataPropertyName = "TestDisplayTitle",
                FillWeight = 18
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentPart",
                HeaderText = "Part",
                DataPropertyName = "PartDisplayText",
                FillWeight = 14
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentResult",
                HeaderText = "Kết quả",
                DataPropertyName = "ResultText",
                FillWeight = 12
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentAccuracy",
                HeaderText = "Accuracy",
                DataPropertyName = "AccuracyText",
                FillWeight = 12
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentDate",
                HeaderText = "Ngày làm",
                DataPropertyName = "StartedAtText",
                FillWeight = 18
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRecentDuration",
                HeaderText = "Thời gian",
                DataPropertyName = "DurationText",
                FillWeight = 12
            });

            dgvRecentAttempts.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "colReview",
                HeaderText = "",
                Text = "Xem lại",
                UseColumnTextForLinkValue = true,
                FillWeight = 10
            });
        }
        private void dgvStatsByPart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStatsByPart.Rows)
            {
                object v = row.Cells["colPartAccuracy"].Value;
                if (v == null) continue;

                string accText = v.ToString().Replace("%", "").Trim();
                double acc;
                if (!double.TryParse(accText, out acc)) continue;

                if (acc >= 80)
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                else if (acc >= 50)
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                else
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void LoadStatsOverview(int accountId)
        {
            var overview = _statsBLL.GetOverviewByAccount(accountId);

            lblTotalAttempts.Text = overview.TotalSubmittedAttempts.ToString();
            lblTotalQuestions.Text = overview.TotalQuestions.ToString();
            lblTotalCorrect.Text = overview.TotalCorrect.ToString();
            lblTotalWrong.Text = overview.TotalWrong.ToString();
            lblTotalSkipped.Text = overview.TotalSkipped.ToString();
            lblAccuracy.Text = overview.AccuracyText;
            lblAvgDuration.Text = overview.AvgDurationText;
            lblLastSubmitted.Text = overview.LastSubmittedAtText;
        }

        private void LoadStatsByPart(int accountId)
        {
            var items = _statsBLL.GetByPart(accountId);

            dgvStatsByPart.AutoGenerateColumns = false;
            dgvStatsByPart.DataSource = null;
            dgvStatsByPart.DataSource = items;
        }

        private void LoadStatsByTest(int accountId)
        {
            var items = _statsBLL.GetByTest(accountId);

            dgvStatsByTest.AutoGenerateColumns = false;
            dgvStatsByTest.DataSource = null;
            dgvStatsByTest.DataSource = items;
        }

        private void LoadRecentAttempts(int accountId)
        {
            var items = _statsBLL.GetRecentAttempts(accountId, 10);

            dgvRecentAttempts.AutoGenerateColumns = false;
            dgvRecentAttempts.DataSource = null;
            dgvRecentAttempts.DataSource = items;
        }

        private void dgvRecentAttempts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            if (dgvRecentAttempts.Columns[e.ColumnIndex].Name != "colReview")
                return;

            var item = dgvRecentAttempts.Rows[e.RowIndex].DataBoundItem as RecentAttemptStatsDTO;
            if (item == null || item.AttemptId <= 0)
                return;

            FrmXemLai frm = new FrmXemLai(item.AttemptId, 0);
            frm.ShowDialog();
        }
        private void InitStatsNavButtons()
        {
            btnStatsOverview.Click += (s, e) => ScrollStatsToPanel(pnlOverview);
            btnStatsByPart.Click += (s, e) => ScrollStatsToPanel(pnlByPart);
            btnStatsByTest.Click += (s, e) => ScrollStatsToPanel(pnlByTest);
            btnStatsRecent.Click += (s, e) => ScrollStatsToPanel(pnlRecentAttempts);
        }
        private void BuildOverviewCardsText()
        {
            lblTotalAttemptsTitle.Text = "Tổng bài đã nộp";
            lblTotalQuestionsTitle.Text = "Tổng câu đã làm";
            lblTotalCorrectTitle.Text = "Tổng đúng";
            lblAccuracyTitle.Text = "Độ chính xác %";
            lblTotalWrongTitle.Text = "Tổng sai";
            lblTotalSkippedTitle.Text = "Tổng bỏ qua";
            lblAvgDurationTitle.Text = "Thời gian trung bình";
            lblLastSubmittedTitle.Text = "Lần nộp gần nhất";
        }

        private void ScrollStatsToPanel(Control target)
        {
            if (target == null) return;
            pnlStatsContainer.ScrollControlIntoView(target);
        }

        private bool _isLoggingOut = false;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);   

            if (rs != DialogResult.Yes)
                return;

            try
            {
                _isLoggingOut = true;
                Session.Clear();

                FrmDangNhap frmLogin = new FrmDangNhap();
                frmLogin.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                _isLoggingOut = false;

                MessageBox.Show(
                    "Đăng xuất thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }

    }
}