using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcReview_Question : UserControl
    {
        private AttemptReviewQuestionDTO _q;
        private List<AttemptOptionDTO> _opts;

        public int OrderNo => _q != null ? _q.OrderNo : 0;

        public UcReview_Question()
        {
            InitializeComponent();
        }

        public void Bind(AttemptReviewQuestionDTO q, List<AttemptOptionDTO> opts)
        {
            _q = q;
            _opts = (opts ?? new List<AttemptOptionDTO>())
                .OrderBy(x => x.DisplayOrder)
                .ToList();

            string chosen = (q.ChosenOptionLabel ?? "").Trim().ToUpper();
            string correct = (q.CorrectOptionLabel ?? "").Trim().ToUpper();

            lblHeader.Text = q.OrderNo.ToString();
            lblQuestion.Text = $"{q.OrderNo}. {q.QuestionText}";

            // reset UI
            ResetPanel(pnlA, lblA);
            ResetPanel(pnlB, lblB);
            ResetPanel(pnlC, lblC);
            ResetPanel(pnlD, lblD);

            SetOptionText("A", lblA);
            SetOptionText("B", lblB);
            SetOptionText("C", lblC);
            SetOptionText("D", lblD);

            // tô màu: đúng xanh, user chọn sai đỏ
            if (!string.IsNullOrEmpty(correct))
            {
                if (correct == "A") MarkCorrect(pnlA);
                if (correct == "B") MarkCorrect(pnlB);
                if (correct == "C") MarkCorrect(pnlC);
                if (correct == "D") MarkCorrect(pnlD);
            }

            if (!string.IsNullOrEmpty(chosen) && chosen != correct)
            {
                if (chosen == "A") MarkWrong(pnlA);
                if (chosen == "B") MarkWrong(pnlB);
                if (chosen == "C") MarkWrong(pnlC);
                if (chosen == "D") MarkWrong(pnlD);
            }

            lblCorrectLine.Text = $"Đáp án đúng: {correct}";

            txtExplain.Text = q.Explanation ?? "";
            txtExplain.Visible = false;
            rdoToggleExplain.Checked = false;
        }

        private void SetOptionText(string label, Label lbl)
        {
            var o = _opts.FirstOrDefault(x => string.Equals(x.OptionLabel, label, StringComparison.OrdinalIgnoreCase));
            lbl.Text = o == null ? $"{label}." : $"{label}. {o.AnswerText}";
        }

        private void ResetPanel(Panel p, Label lbl)
        {
            p.BackColor = Color.White;
            lbl.ForeColor = Color.Black;
        }

        private void MarkCorrect(Panel p)
        {
            p.BackColor = Color.FromArgb(220, 252, 231); // xanh nhạt
        }

        private void MarkWrong(Panel p)
        {
            p.BackColor = Color.FromArgb(254, 226, 226); // đỏ nhạt
            foreach (Control c in p.Controls)
                if (c is Label lb) lb.ForeColor = Color.Red;
        }

        private void rdoToggleExplain_CheckedChanged(object sender, EventArgs ev)
        {
            txtExplain.Visible = rdoToggleExplain.Checked;
            // tăng chiều cao control để hiện lời giải
            this.Height = rdoToggleExplain.Checked ? 330 : 240;
            txtExplain.Height = rdoToggleExplain.Checked ? 120 : 32;
        }
    }
}