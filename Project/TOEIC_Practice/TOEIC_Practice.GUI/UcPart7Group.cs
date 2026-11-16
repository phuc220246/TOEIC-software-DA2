using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class UcPart7Group : UserControl
    {
        private AttemptPart7GroupDTO _group;
        private Dictionary<int, List<AttemptOptionDTO>> _optionsMap;

        // attemptQuestionId, selectedIndex
        public event Action<int, int> AnswerSelected;

        public UcPart7Group()
        {
            InitializeComponent();
        }

        public void Bind(
            AttemptPart7GroupDTO group,
            Dictionary<int, List<AttemptOptionDTO>> optionsMap,
            int totalQuestionsInPart)
        {
            _group = group;
            _optionsMap = optionsMap ?? new Dictionary<int, List<AttemptOptionDTO>>();

            lblTitle.Text = $"Part 7 - Nhóm {_group.GroupOrderNo}";

            flpPassages.Controls.Clear();
            flpQuestions.Controls.Clear();

            BindPassages();
            BindQuestions(totalQuestionsInPart);

            FixChildrenWidth();
        }

        private void BindPassages()
        {
            if (_group == null || _group.Passages == null) return;

            foreach (var p in _group.Passages.OrderBy(x => x.PassageNo))
            {
                var uc = new UcPassageBlock();
                uc.Margin = new Padding(0, 0, 0, 12);
                uc.Width = flpPassages.ClientSize.Width - 25;

                string title = string.IsNullOrWhiteSpace(p.Title)
                    ? $"Passage {p.PassageNo}"
                    : p.Title;

                uc.Bind(title, p.PassageText);
                flpPassages.Controls.Add(uc);
            }
        }

        private void BindQuestions(int totalQuestionsInPart)
        {
            if (_group == null || _group.Questions == null) return;

            foreach (var q in _group.Questions.OrderBy(x => x.OrderNo))
            {
                var uc = new UcP5_SingleQuestion(q, totalQuestionsInPart);
                uc.Margin = new Padding(0, 0, 0, 12);
                uc.Width = flpQuestions.ClientSize.Width - 25;

                if (_optionsMap.ContainsKey(q.AttemptQuestionId))
                {
                    uc.SetOptions(_optionsMap[q.AttemptQuestionId]);
                }

                uc.SetSelectedOption(q.ChosenOptionLabel);

                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    AnswerSelected?.Invoke(attemptQuestionId, selectedIndex);
                };

                flpQuestions.Controls.Add(uc);
            }
        }

        public void FixChildrenWidth()
        {
            foreach (Control c in flpPassages.Controls)
            {
                c.Width = flpPassages.ClientSize.Width - 25;
            }

            foreach (Control c in flpQuestions.Controls)
            {
                c.Width = flpQuestions.ClientSize.Width - 25;
            }
        }

        private void UcPart7Group_Load(object sender, EventArgs e)
        {
            FixChildrenWidth();
        }

        private void UcPart7Group_Resize(object sender, EventArgs e)
        {
            FixChildrenWidth();
        }

        private void flpPassages_SizeChanged(object sender, EventArgs e)
        {
            FixChildrenWidth();
        }

        private void flpQuestions_SizeChanged(object sender, EventArgs e)
        {
            FixChildrenWidth();
        }
    }
}