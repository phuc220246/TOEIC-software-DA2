using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;
using System.Linq;
namespace TOEIC_Practice.GUI
{
    public partial class UcP5_SingleQuestion : UserControl
    {
        private readonly AttemptQuestionDTO _q;
        private readonly int _total;

        // attemptQuestionId, selectedIndex (0=A,1=B,2=C,3=D)
        public event Action<int, int> AnswerSelected;

        public UcP5_SingleQuestion(AttemptQuestionDTO q, int total)
        {
            InitializeComponent();
            _q = q;
            _total = total;

            // đảm bảo radio đã bắt sự kiện (nếu bạn chưa set trong designer)
            rdoA.CheckedChanged += Answer_CheckedChanged;
            rdoB.CheckedChanged += Answer_CheckedChanged;
            rdoC.CheckedChanged += Answer_CheckedChanged;
            rdoD.CheckedChanged += Answer_CheckedChanged;

            BindData();
        }

        private void BindData()
        {
            lblHeader.Text = $"Câu {_q.OrderNo}/{_total}  -  Part {_q.PartId}";
            txtQuestion.Text = _q.QuestionText ?? "";

            // Placeholder (sẽ được SetOptions ghi đè)
            rdoA.Text = "A.";
            rdoB.Text = "B.";
            rdoC.Text = "C.";
            rdoD.Text = "D.";
        }

        /// <summary>
        /// Nhận danh sách đáp án A/B/C/D đã trộn theo AttemptQuestionId
        /// </summary>
        public void SetOptions(List<AttemptOptionDTO> opts)
        {
            if (opts == null) return;

            // đảm bảo đúng thứ tự 1..4
            var sorted = opts.OrderBy(x => x.DisplayOrder).ToList();

            // tìm theo OptionLabel
            string TextOf(string label)
            {
                var o = sorted.FirstOrDefault(x => string.Equals(x.OptionLabel, label, StringComparison.OrdinalIgnoreCase));
                return o == null ? $"{label}." : $"{label}. {o.AnswerText}";
            }

            rdoA.Text = TextOf("A");
            rdoB.Text = TextOf("B");
            rdoC.Text = TextOf("C");
            rdoD.Text = TextOf("D");
        }

        private void Answer_CheckedChanged(object sender, EventArgs e)
        {
            // chỉ xử lý khi radio đang được chọn
            var r = sender as RadioButton;
            if (r == null || !r.Checked) return;

            int idx = -1;
            if (r == rdoA) idx = 0;
            else if (r == rdoB) idx = 1;
            else if (r == rdoC) idx = 2;
            else if (r == rdoD) idx = 3;

            if (idx >= 0)
                AnswerSelected?.Invoke(_q.AttemptQuestionId, idx);
        }

        private void UcP5_SingleQuestion_Load(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
                
        }
        public void SetSelectedOption(string label)
        {
            if (string.IsNullOrWhiteSpace(label)) return;

            label = label.Trim().ToUpperInvariant();

            // tránh bắn event khi set lại trạng thái
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
    }
}