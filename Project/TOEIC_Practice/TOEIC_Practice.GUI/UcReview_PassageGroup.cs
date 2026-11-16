using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcReview_PassageGroup : UserControl
    {
        public UcReview_PassageGroup()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            txtPassage.ReadOnly = true;
            txtPassage.BorderStyle = BorderStyle.FixedSingle;
            txtPassage.BackColor = Color.White;
            txtPassage.ScrollBars = RichTextBoxScrollBars.Vertical;

            flpQuestions.FlowDirection = FlowDirection.TopDown;
            flpQuestions.WrapContents = false;
            flpQuestions.AutoScroll = false;
        }

        public void Bind(
            int partId,
            int groupOrderNo,
            string passageText,
            List<AttemptReviewQuestionDTO> questions,
            Func<int, List<AttemptReviewOptionDTO>> getOptions)
        {
            lblTitle.Text = $"PART {partId}" + (groupOrderNo > 0 ? $" - Nhóm {groupOrderNo}" : "");
            txtPassage.Text = passageText ?? "";

            flpQuestions.SuspendLayout();
            flpQuestions.Controls.Clear();

            foreach (var q in questions.OrderBy(x => x.OrderNo))
            {
                var opts = getOptions != null
                    ? getOptions(q.AttemptQuestionId)
                    : new List<AttemptReviewOptionDTO>();

                var uc = new UcReview_Part5Question();
                uc.Width = flpQuestions.ClientSize.Width - 25;
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                uc.Margin = new Padding(0, 0, 0, 12);
                uc.Bind(q, opts);

                flpQuestions.Controls.Add(uc);
            }

            flpQuestions.ResumeLayout();
            flpQuestions.PerformLayout();

            FixChildrenWidth();
        }

        public void FixChildrenWidth()
        {
            int w = flpQuestions.ClientSize.Width - 25;
            if (w < 300) w = 300;

            foreach (Control c in flpQuestions.Controls)
            {
                c.Width = w;
            }
        }
    }
}