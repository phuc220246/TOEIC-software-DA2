using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcReview_Part5Question : UserControl
    {
        private AttemptReviewQuestionDTO _q;
        private List<AttemptReviewOptionDTO> _opts;
        private bool _expanded = false;

        public int OrderNo => _q?.OrderNo ?? 0;

        public UcReview_Part5Question()
        {
            InitializeComponent();

            pnlExplain.Visible = false;
            rdoToggleExplain.Checked = false;
            rdoToggleExplain.AutoCheck = false;

            rdoToggleExplain.Click += rdoToggleExplain_Click;
            this.Resize += UcReview_Part5Question_Resize;
        }

        public void Bind(AttemptReviewQuestionDTO q, List<AttemptReviewOptionDTO> opts)
        {
            _q = q;
            _opts = opts ?? new List<AttemptReviewOptionDTO>();

            lblQuestion.Text = $"{q.OrderNo}. {q.QuestionText}";
            txtExplain.Text = string.IsNullOrWhiteSpace(q.Explanation)
                ? "Không có giải thích."
                : q.Explanation;

            ResetOptionUI();
            lblCorrectLine.Text = "";

            var sorted = _opts.OrderBy(x => x.DisplayOrder).ToList();

            ApplyOption(pnlA, lblA, "A", sorted, q.ChosenOptionLabel);
            ApplyOption(pnlB, lblB, "B", sorted, q.ChosenOptionLabel);
            ApplyOption(pnlC, lblC, "C", sorted, q.ChosenOptionLabel);
            ApplyOption(pnlD, lblD, "D", sorted, q.ChosenOptionLabel);

            string chosen = (q.ChosenOptionLabel ?? "").Trim().ToUpper();
            string correct = (q.CorrectOptionLabel ?? "").Trim().ToUpper();

            if (!string.IsNullOrEmpty(correct))
            {
                if (string.IsNullOrEmpty(chosen) || chosen != correct)
                    lblCorrectLine.Text = $"Đáp án đúng: {correct}";
            }

            _expanded = false;
            pnlExplain.Visible = false;
            rdoToggleExplain.Checked = false;

            AdjustControlHeight();
        }

        private void ResetOptionUI()
        {
            ResetSingleOption(pnlA, lblA);
            ResetSingleOption(pnlB, lblB);
            ResetSingleOption(pnlC, lblC);
            ResetSingleOption(pnlD, lblD);
        }

        private void ResetSingleOption(Panel pnl, Label lbl)
        {
            pnl.Visible = true;
            pnl.BackColor = Color.White;
            lbl.ForeColor = Color.Black;
        }

        private void ApplyOption(Panel pnl, Label lbl, string label, List<AttemptReviewOptionDTO> sorted, string chosenLabel)
        {
            var opt = sorted.FirstOrDefault(x =>
                string.Equals(x.OptionLabel, label, StringComparison.OrdinalIgnoreCase));

            if (opt == null)
            {
                pnl.Visible = false;
                return;
            }

            pnl.Visible = true;
            lbl.Text = $"{label}. {opt.AnswerText}";

            string chosen = (chosenLabel ?? "").Trim().ToUpper();

            if (!string.IsNullOrEmpty(chosen) && chosen == label)
            {
                if (opt.IsCorrect)
                {
                    pnl.BackColor = Color.FromArgb(220, 252, 231);
                    lbl.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    pnl.BackColor = Color.FromArgb(254, 226, 226);
                    lbl.ForeColor = Color.FromArgb(220, 38, 38);
                }
                return;
            }

            if (opt.IsCorrect)
            {
                pnl.BackColor = Color.FromArgb(220, 252, 231);
                lbl.ForeColor = Color.FromArgb(22, 163, 74);
            }
        }

        private void RepositionExplainPanel()
        {
            pnlExplain.Left = 17;
            pnlExplain.Top = rdoToggleExplain.Bottom + 8;
            pnlExplain.Width = pnlRoot.ClientSize.Width - 34;
        }

        private void AdjustExplanationLayout()
        {
            RepositionExplainPanel();

            int width = pnlExplain.ClientSize.Width - 20;
            if (width < 250) width = 250;

            txtExplain.Left = 10;
            txtExplain.Top = 10;
            txtExplain.Width = width;

            int textHeight = TextRenderer.MeasureText(
                txtExplain.Text ?? "",
                txtExplain.Font,
                new Size(txtExplain.Width, 0),
                TextFormatFlags.WordBreak).Height;

            if (textHeight < 30) textHeight = 30;

            txtExplain.Height = textHeight + 6;
            pnlExplain.Height = txtExplain.Height + 20;
        }

        private void AdjustControlHeight()
        {
            int bottom = lblCorrectLine.Bottom;

            if (rdoToggleExplain.Visible && rdoToggleExplain.Bottom > bottom)
                bottom = rdoToggleExplain.Bottom;

            if (pnlExplain.Visible && pnlExplain.Bottom > bottom)
                bottom = pnlExplain.Bottom;

            this.Height = bottom + 15;
        }

        private void NotifyParentToRelayout()
        {
            Control parent = this.Parent;

            while (parent != null)
            {
                parent.PerformLayout();

                if (parent is UcReview_Part6Group group)
                {
                    group.FixChildrenWidth();
                }

                parent = parent.Parent;
            }
        }

        private void rdoToggleExplain_Click(object sender, EventArgs e)
        {
            _expanded = !_expanded;
            pnlExplain.Visible = _expanded;

            if (_expanded)
            {
                AdjustExplanationLayout();
                pnlExplain.BringToFront();
            }

            AdjustControlHeight();
            NotifyParentToRelayout();
        }

        private void UcReview_Part5Question_Resize(object sender, EventArgs e)
        {
            if (pnlExplain.Visible)
            {
                AdjustExplanationLayout();
            }

            AdjustControlHeight();
        }
    }
}