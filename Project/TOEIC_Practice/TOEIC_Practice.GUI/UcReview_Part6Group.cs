using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcReview_Part6Group : UserControl
    {
        public Dictionary<int, Control> OrderToControl { get; private set; }
            = new Dictionary<int, Control>();

        public UcReview_Part6Group()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            txtPassage.ReadOnly = true;
            txtPassage.BackColor = Color.White;
            txtPassage.BorderStyle = BorderStyle.FixedSingle;
            txtPassage.ScrollBars = RichTextBoxScrollBars.Vertical;

            pnlQuestionsHost.AutoScroll = true;
        }

        public void Bind(
            string title,
            string passage,
            List<AttemptReviewQuestionDTO> questions,
            Func<int, List<AttemptReviewOptionDTO>> optionsProvider)
        {
            lblTitle.Text = title;
            txtPassage.Text = passage ?? "";

            pnlQuestionsHost.Controls.Clear();
            OrderToControl.Clear();

            int currentTop = 0;
            int width = pnlQuestionsHost.ClientSize.Width - 20;
            if (width < 320) width = 320;

            foreach (var q in questions.OrderBy(x => x.OrderNo))
            {
                var opts = optionsProvider != null
                    ? optionsProvider(q.AttemptQuestionId)
                    : new List<AttemptReviewOptionDTO>();

                var uc = new UcReview_Part5Question();
                uc.Left = 0;
                uc.Top = currentTop;
                uc.Width = width;
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                uc.Bind(q, opts);

                pnlQuestionsHost.Controls.Add(uc);
                OrderToControl[q.OrderNo] = uc;

                currentTop += uc.Height + 12;
            }

            pnlQuestionsHost.Height = currentTop;
            this.Height = Math.Max(txtPassage.Bottom, pnlQuestionsHost.Bottom) + 20;
        }

        public void FixChildrenWidth()
        {
            int width = pnlQuestionsHost.ClientSize.Width - 20;
            if (width < 320) width = 320;

            int currentTop = 0;

            foreach (Control c in pnlQuestionsHost.Controls)
            {
                c.Left = 0;
                c.Top = currentTop;
                c.Width = width;
                currentTop += c.Height + 12;
            }

            pnlQuestionsHost.Height = currentTop;
            this.Height = Math.Max(txtPassage.Bottom, pnlQuestionsHost.Bottom) + 20;
        }
    }
}