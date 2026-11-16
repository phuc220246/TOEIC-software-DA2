using System;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class FrmKetQua : Form
    {
        private readonly AttemptSummaryDTO _sum;
        private readonly string _badgeText;

        public FrmKetQua(AttemptSummaryDTO summary, string badgeText = "Luyện tập")
        {
            InitializeComponent();
            _sum = summary;
            _badgeText = badgeText;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FrmKetQua_Load(object sender, EventArgs e)
        {
            lblBadgePart.Text = _badgeText;

            lblKetQuaValue.Text = $"{_sum.CorrectCount}/{_sum.TotalQuestions}";

            double acc = (_sum.TotalQuestions <= 0) ? 0 : (100.0 * _sum.CorrectCount / _sum.TotalQuestions);
            lblAccuracyValue.Text = $"{acc:0.0}%";

            lblTimeValue.Text = FormatDuration(_sum.DurationSeconds);

            lblCorrectValue.Text = _sum.CorrectCount.ToString();
            lblWrongValue.Text = _sum.WrongCount.ToString();
            lblSkippedValue.Text = _sum.SkippedCount.ToString();
        }

        private string FormatDuration(int? seconds)
        {
            if (!seconds.HasValue || seconds.Value < 0) return "00:00:00";
            TimeSpan ts = TimeSpan.FromSeconds(seconds.Value);
            return ts.ToString(@"hh\:mm\:ss");
        }

        private void btnXemDapAn_Click(object sender, EventArgs e)
        {
            FrmXemLai f = new FrmXemLai(_sum.AttemptId, 0);
            f.Show();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}