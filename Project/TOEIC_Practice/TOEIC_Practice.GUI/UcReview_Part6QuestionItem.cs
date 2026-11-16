using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcReview_Part6QuestionItem : UserControl
    {
        private AttemptReviewQuestionDTO _q;
        private List<AttemptReviewOptionDTO> _opts;

        public int OrderNo => _q?.OrderNo ?? 0;

        public UcReview_Part6QuestionItem()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public void Bind(AttemptReviewQuestionDTO q, List<AttemptReviewOptionDTO> opts)
        {
            _q = q;
            _opts = opts ?? new List<AttemptReviewOptionDTO>();
            _q.OrderNo = OrderNo;
            lblQuestion.Text = $"{q.OrderNo}. {q.QuestionText ?? ""}";
            txtExplain.Text = q.Explanation ?? "";

            // set text options
            SetOptionText("A", lblA);
            SetOptionText("B", lblB);
            SetOptionText("C", lblC);
            SetOptionText("D", lblD);

            // reset colors
            ResetOptionUI();

            string chosen = (q.ChosenOptionLabel ?? "").Trim().ToUpper();
            string correct = (q.CorrectOptionLabel ?? "").Trim().ToUpper();

            lblCorrect.Text = string.IsNullOrEmpty(correct) ? "Đáp án đúng: ?" : $"Đáp án đúng: {correct}";

            // tô màu đúng/sai giống Study4
            ApplyColor(chosen, correct);

            // mặc định ẩn giải thích
            rdoToggleExplain.Checked = false;
            pnlExplain.Visible = false;

            // auto height theo explain (khi bật)
            AdjustHeight(false);
        }

        private void SetOptionText(string label, Label lbl)
        {
            var item = _opts.FirstOrDefault(x => (x.OptionLabel ?? "").Trim().ToUpper() == label);
            lbl.Text = $"{label}. {(item?.AnswerText ?? "")}";
        }

        private void ResetOptionUI()
        {
            ClearPanel(pnlA, lblA);
            ClearPanel(pnlB, lblB);
            ClearPanel(pnlC, lblC);
            ClearPanel(pnlD, lblD);
        }

        private void ClearPanel(Panel p, Label lbl)
        {
            p.BackColor = Color.White;
            lbl.ForeColor = Color.Black;
            lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }

        private void ApplyColor(string chosen, string correct)
        {
            // correct -> xanh nhạt
            if (!string.IsNullOrEmpty(correct))
                SetCorrect(correct);

            // chosen -> nếu sai thì đỏ nhạt
            if (!string.IsNullOrEmpty(chosen) && chosen != correct)
                SetWrong(chosen);

            // nếu chosen == correct -> chosen sẽ đã xanh rồi
        }

        private void SetCorrect(string label)
        {
            Panel p; Label lbl;
            GetPanelByLabel(label, out p, out lbl);
            if (p == null) return;

            p.BackColor = Color.FromArgb(220, 252, 231);  // xanh nhạt
            lbl.ForeColor = Color.FromArgb(22, 163, 74); // xanh
            lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }

        private void SetWrong(string label)
        {
            Panel p; Label lbl;
            GetPanelByLabel(label, out p, out lbl);
            if (p == null) return;

            p.BackColor = Color.FromArgb(254, 226, 226);  // đỏ nhạt
            lbl.ForeColor = Color.FromArgb(239, 68, 68);  // đỏ
            lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }

        private void GetPanelByLabel(string label, out Panel p, out Label lbl)
        {
            p = null; lbl = null;
            switch ((label ?? "").Trim().ToUpper())
            {
                case "A": p = pnlA; lbl = lblA; break;
                case "B": p = pnlB; lbl = lblB; break;
                case "C": p = pnlC; lbl = lblC; break;
                case "D": p = pnlD; lbl = lblD; break;
            }
        }

        private void rdoToggleExplain_CheckedChanged(object sender, EventArgs e)
        {
            bool show = rdoToggleExplain.Checked;
            pnlExplain.Visible = show;
            AdjustHeight(show);
        }

        private void AdjustHeight(bool showExplain)
        {
            // base height
            int baseHeight = 260;

            if (!showExplain)
            {
                this.Height = baseHeight;
                return;
            }

            // đo chiều cao explain theo text
            int w = pnlExplain.Width - 10;
            if (w < 50) w = 50;

            Size sz = TextRenderer.MeasureText(
                txtExplain.Text ?? "",
                txtExplain.Font,
                new Size(w, 10000),
                TextFormatFlags.WordBreak);

            int explainHeight = Math.Min(260, Math.Max(70, sz.Height + 20));
            pnlExplain.Height = explainHeight;

            this.Height = baseHeight - 35 + explainHeight; // bù phần panel explain
        }
    }
}