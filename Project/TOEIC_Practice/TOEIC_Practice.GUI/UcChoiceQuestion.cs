using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    public partial class UcChoiceQuestion : UserControl
    {
        private AttemptQuestionDTO _q;
        private int _total;

        public event Action<int, int> AnswerSelected;

        public UcChoiceQuestion()
        {
            InitializeComponent();

            rdoA.CheckedChanged += Answer_CheckedChanged;
            rdoB.CheckedChanged += Answer_CheckedChanged;
            rdoC.CheckedChanged += Answer_CheckedChanged;
            rdoD.CheckedChanged += Answer_CheckedChanged;

            this.Resize += (s, e) => AdjustLayout();
        }

        public void BindData(AttemptQuestionDTO q, int total, List<AttemptOptionDTO> opts)
        {
            _q = q;
            _total = total;

            lblQuestionNo.Text = $"{q.OrderNo}.";
            lblQuestionText.Text = q.QuestionText ?? "";
            lblQuestionText.MaximumSize = new System.Drawing.Size(this.Width - 90, 0);

            rdoA.Text = "A.";
            rdoB.Text = "B.";
            rdoC.Text = "C.";
            rdoD.Text = "D.";

            if (opts != null)
            {
                var sorted = opts.OrderBy(x => x.DisplayOrder).ToList();

                string TextOf(string label)
                {
                    var o = sorted.FirstOrDefault(x =>
                        string.Equals(x.OptionLabel, label, StringComparison.OrdinalIgnoreCase));

                    return o == null ? $"{label}." : $"{label}. {o.AnswerText}";
                }

                rdoA.Text = TextOf("A");
                rdoB.Text = TextOf("B");
                rdoC.Text = TextOf("C");
                rdoD.Text = TextOf("D");
            }

            SetSelectedOption(q.ChosenOptionLabel);
            AdjustLayout();
        }

        private void Answer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r == null || !r.Checked || _q == null) return;

            int idx = -1;
            if (r == rdoA) idx = 0;
            else if (r == rdoB) idx = 1;
            else if (r == rdoC) idx = 2;
            else if (r == rdoD) idx = 3;

            if (idx >= 0)
                AnswerSelected?.Invoke(_q.AttemptQuestionId, idx);
        }

        public void SetSelectedOption(string label)
        {
            if (string.IsNullOrWhiteSpace(label)) return;

            label = label.Trim().ToUpperInvariant();

            rdoA.CheckedChanged -= Answer_CheckedChanged;
            rdoB.CheckedChanged -= Answer_CheckedChanged;
            rdoC.CheckedChanged -= Answer_CheckedChanged;
            rdoD.CheckedChanged -= Answer_CheckedChanged;

            try
            {
                rdoA.Checked = label == "A";
                rdoB.Checked = label == "B";
                rdoC.Checked = label == "C";
                rdoD.Checked = label == "D";
            }
            finally
            {
                rdoA.CheckedChanged += Answer_CheckedChanged;
                rdoB.CheckedChanged += Answer_CheckedChanged;
                rdoC.CheckedChanged += Answer_CheckedChanged;
                rdoD.CheckedChanged += Answer_CheckedChanged;
            }
        }
        private void AdjustLayout()
        {
            int availableWidth = this.ClientSize.Width - 90;
            if (availableWidth < 200) availableWidth = 200;

            lblQuestionText.MaximumSize = new System.Drawing.Size(availableWidth, 0);
            lblQuestionText.Width = availableWidth;

            int textHeight = TextRenderer.MeasureText(
                lblQuestionText.Text,
                lblQuestionText.Font,
                new System.Drawing.Size(lblQuestionText.Width, 0),
                TextFormatFlags.WordBreak).Height;

            if (textHeight < 28) textHeight = 28;
            lblQuestionText.Height = textHeight + 6;

            int topOptions = lblQuestionText.Bottom + 12;

            rdoA.Top = topOptions;
            rdoB.Top = rdoA.Bottom + 8;
            rdoC.Top = rdoB.Bottom + 8;
            rdoD.Top = rdoC.Bottom + 8;

            int optionWidth = this.ClientSize.Width - 40;
            if (optionWidth < 200) optionWidth = 200;

            rdoA.Width = optionWidth;
            rdoB.Width = optionWidth;
            rdoC.Width = optionWidth;
            rdoD.Width = optionWidth;

            int totalHeight = rdoD.Bottom + 15;
            if (totalHeight < 180) totalHeight = 180;

            this.Height = totalHeight;
        }
    }
}