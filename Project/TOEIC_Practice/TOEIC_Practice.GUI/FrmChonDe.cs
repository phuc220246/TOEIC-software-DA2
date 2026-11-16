using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.NoiDungDe;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.GUI
{
    public partial class FrmChonDe : Form
    {
        private readonly EtsBLL _etsBll = new EtsBLL();
        private readonly TestBLL _testBll = new TestBLL();

        private List<EtsDTO> _etsList = new List<EtsDTO>();
        private int _selectedEtsId = -1;

        public FrmChonDe()
        {
            InitializeComponent();
        }

        private void FrmChonDe_Load(object sender, EventArgs e)
        {
            LoadYears();
        }

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
                btn.Tag = ets; // lưu cả object
                btn.Width = 60;
                btn.Height = 32;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Standard;

                btn.Click += YearButton_Click;

                flowYears.Controls.Add(btn);
            }

            // auto chọn năm đầu tiên nếu có
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
        }

        private void HighlightSelectedYear(int year)
        {
            foreach (Control c in flowYears.Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = (b.Text == year.ToString()) ? Color.LightSteelBlue : Color.White;
                }
            }
        }

        private void SelectEts(int etsId)
        {
            _selectedEtsId = etsId;
            LoadTestsByEts(etsId);
        }

        private void LoadTestsByEts(int etsId)
        {
            flowTests.Controls.Clear();

            var tests = _testBll.GetByEts(etsId);

            foreach (var t in tests)
            {
                flowTests.Controls.Add(CreateTestCard(t));
            }
        }

        private Control CreateTestCard(TestDTO t)
        {
            Panel card = new Panel();
            card.Width = 240;
            card.Height = 150;
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
            lblTitle.Height = 40;
            lblTitle.Location = new Point(10, 10);

            Label lblInfo = new Label();
            lblInfo.Text = "120 phút | 7 phần | 200 câu";
            lblInfo.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblInfo.AutoSize = false;
            lblInfo.Width = card.Width - 20;
            lblInfo.Height = 20;
            lblInfo.Location = new Point(10, 55);

            Button btnLamBai = new Button();
            btnLamBai.Text = "Làm bài";
            btnLamBai.Width = 100;
            btnLamBai.Height = 32;
            btnLamBai.Location = new Point(10, 95);
            btnLamBai.Tag = t;
            btnLamBai.Click += BtnLamBai_Click;

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblInfo);
            card.Controls.Add(btnLamBai);

            return card;
        }

        private void BtnLamBai_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var test = btn.Tag as TestDTO;

            MessageBox.Show($"Bạn chọn TestId={test.TestId}, TestNo={test.TestNo}");

            // TODO: bước sau sẽ gọi Attempt_Start và mở FrmLamBai thật
            // FrmLamBai f = new FrmLamBai(test.TestId);
            // f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearchYear.Text.Trim();

            if (string.IsNullOrWhiteSpace(kw))
            {
                LoadYears();
                return;
            }

            // Lọc năm theo text
            var filtered = _etsList.Where(x => x.Year.ToString().Contains(kw)).ToList();
            if (filtered.Count == 0)
            {
                MessageBox.Show("Không tìm thấy năm ETS phù hợp!");
                return;
            }

            // Render lại years theo filtered
            flowYears.Controls.Clear();
            foreach (var ets in filtered)
            {
                Button btn = new Button();
                btn.Text = ets.Year.ToString();
                btn.Tag = ets;
                btn.Width = 60;
                btn.Height = 32;
                btn.Margin = new Padding(6);
                btn.BackColor = Color.White;
                btn.Click += YearButton_Click;
                flowYears.Controls.Add(btn);
            }

            // chọn item đầu
            SelectEts(filtered[0].EtsId);
            HighlightSelectedYear(filtered[0].Year);
        }
    }
}