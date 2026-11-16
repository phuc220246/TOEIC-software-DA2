using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.Admin;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.GUI.Admin
{
    public partial class FrmAdminStats : Form
    {
        private readonly AdminStatsBLL _statsBLL = new AdminStatsBLL();
        private readonly AdminAccountBLL _accountBLL = new AdminAccountBLL();

        public FrmAdminStats()
        {
            InitializeComponent();
        }

        private void FrmAdminStats_Load(object sender, EventArgs e)
        {
            try
            {
                InitUiStyle();
                LoadAccountFilter();
                SetupGridViews();
                LoadAllStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khởi tạo form thống kê:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InitUiStyle()
        {
            this.BackColor = Color.WhiteSmoke;

            pnlOverview.BackColor = Color.White;
            pnlAccountOverview.BackColor = Color.White;
            pnlAccuracy.BackColor = Color.White;
            pnlByTest.BackColor = Color.White;
            pnlRecentAttempts.BackColor = Color.White;
        }

        private void LoadAccountFilter()
        {
            List<AdminAccountDTO> accounts = _accountBLL.GetAll();

            List<AccountComboItem> items = new List<AccountComboItem>();
            items.Add(new AccountComboItem { AccountId = 0, DisplayText = "-- Chọn account --" });

            foreach (AdminAccountDTO acc in accounts.Where(x => x.IsActive))
            {
                items.Add(new AccountComboItem
                {
                    AccountId = acc.AccountId,
                    DisplayText = $"{acc.Username} - {acc.DisplayName}"
                });
            }

            cboAccount.DataSource = null;
            cboAccount.DisplayMember = "DisplayText";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = items;
        }

        private void SetupGridViews()
        {
            SetupGridCommon(dgvAccuracyByPart);
            SetupGridCommon(dgvByTest);
            SetupGridCommon(dgvRecentAttempts);
        }

        private void SetupGridCommon(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void LoadAllStats()
        {
            LoadSystemOverview();
            LoadAccuracyByPart();
            LoadByTest();
            LoadAccountStats();
        }

        private void LoadSystemOverview()
        {
            AdminStatsOverviewDTO dto = _statsBLL.GetOverview();

            lblTotalAccounts.Text = "Tổng tài khoản: " + dto.TotalAccounts;
            lblActiveAccounts.Text = "Tài khoản đang hoạt động: " + dto.ActiveAccounts;
            lblTotalSubmittedAttempts.Text = "Lượt nộp bài hợp lệ: " + dto.TotalSubmittedAttempts;
            lblTotalUsersWithAttempts.Text = "User đã từng làm bài: " + dto.TotalUsersWithAttempts;
            lblTotalTests.Text = "Tổng số test: " + dto.TotalTests;
            lblTotalQuestions.Text = "Tổng số câu hỏi: " + dto.TotalQuestions;
            lblAverageScore.Text = "Điểm TB toàn hệ thống: " + dto.AverageScore.ToString("0.##");
        }

        private void LoadAccuracyByPart()
        {
            List<AdminStatsPartAccuracyDTO> list = _statsBLL.GetAccuracyByPart();
            dgvAccuracyByPart.DataSource = null;
            dgvAccuracyByPart.DataSource = list;
        }

        private void LoadByTest()
        {
            List<AdminStatsByTestDTO> list = _statsBLL.GetByTest();
            dgvByTest.DataSource = null;
            dgvByTest.DataSource = list;
        }

        private void LoadAccountStats()
        {
            int accountId = GetSelectedAccountId();

            if (accountId <= 0)
            {
                ClearAccountStats();
                return;
            }

            AdminStatsAccountOverviewDTO overview = _statsBLL.GetOverviewByAccount(accountId);
            List<AdminStatsPartAccuracyDTO> partList = _statsBLL.GetAccuracyByPartByAccount(accountId);
            List<AdminStatsRecentAttemptDTO> recentList = _statsBLL.GetRecentAttemptsByAccount(accountId);

            lblAccUsername.Text = "Username: " + overview.Username;
            lblAccDisplayName.Text = "DisplayName: " + overview.DisplayName;
            lblAccAttemptCount.Text = "Số lần làm: " + overview.AttemptCount;
            lblAccDistinctTests.Text = "Số test khác nhau: " + overview.DistinctTests;
            lblAccAvgScore.Text = "Điểm trung bình: " + overview.AverageScore.ToString("0.##");
            lblAccLastAttempt.Text = "Lần làm gần nhất: " + (overview.LastAttemptAt.HasValue
                ? overview.LastAttemptAt.Value.ToString("dd/MM/yyyy HH:mm")
                : "(chưa có)");

            dgvRecentAttempts.DataSource = null;
            dgvRecentAttempts.DataSource = recentList;

            dgvAccuracyByPart.DataSource = null;
            dgvAccuracyByPart.DataSource = partList;
        }

        private void ClearAccountStats()
        {
            lblAccUsername.Text = "Username: ";
            lblAccDisplayName.Text = "DisplayName: ";
            lblAccAttemptCount.Text = "Số lần làm: 0";
            lblAccDistinctTests.Text = "Số test khác nhau: 0";
            lblAccAvgScore.Text = "Điểm trung bình: 0";
            lblAccLastAttempt.Text = "Lần làm gần nhất: ";

            dgvRecentAttempts.DataSource = null;
            dgvRecentAttempts.DataSource = new List<AdminStatsRecentAttemptDTO>();

            LoadAccuracyByPart();
        }

        private int GetSelectedAccountId()
        {
            if (cboAccount.SelectedValue == null)
                return 0;

            return Convert.ToInt32(cboAccount.SelectedValue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi làm mới thống kê:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated) return;

            try
            {
                LoadAccountStats();
            }
            catch
            {
            }
        }

        private void btnGoOverview_Click(object sender, EventArgs e)
        {
            pnlScroll.ScrollControlIntoView(pnlOverview);
        }

        private void btnGoAccount_Click(object sender, EventArgs e)
        {
            pnlScroll.ScrollControlIntoView(pnlAccountOverview);
        }

        private void btnGoPart_Click(object sender, EventArgs e)
        {
            pnlScroll.ScrollControlIntoView(pnlAccuracy);
        }

        private void btnGoByTest_Click(object sender, EventArgs e)
        {
            pnlScroll.ScrollControlIntoView(pnlByTest);
        }

        private void btnGoRecent_Click(object sender, EventArgs e)
        {
            pnlScroll.ScrollControlIntoView(pnlRecentAttempts);
        }

        private class AccountComboItem
        {
            public int AccountId { get; set; }
            public string DisplayText { get; set; }
        }
    }
}