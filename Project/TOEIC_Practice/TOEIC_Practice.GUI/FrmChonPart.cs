using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TOEIC_Practice.GUI
{
    public partial class FrmChonPart : Form
    {
        // Output để FrmMain lấy dùng
        public string SelectedPartIdsCsv { get; private set; } = "";
        public int? TimeLimitMinutes { get; private set; } = null;

        public FrmChonPart()
        {
            InitializeComponent();
        }

        private void FrmChonPart_Load(object sender, EventArgs e)
        {
            // Combo thời gian: để trống = không giới hạn
            cboTime.Items.Clear();
            cboTime.Items.Add(new ComboItem("Không giới hạn", null));
            cboTime.Items.Add(new ComboItem("15 phút", 15));
            cboTime.Items.Add(new ComboItem("30 phút", 30));
            cboTime.Items.Add(new ComboItem("45 phút", 45));
            cboTime.Items.Add(new ComboItem("60 phút", 60));
            cboTime.Items.Add(new ComboItem("90 phút", 90));
            cboTime.Items.Add(new ComboItem("120 phút", 120));
            cboTime.SelectedIndex = 0;

            // Mặc định giống Study4: hay làm reading trước -> tick Part 5
            chkPart5.Checked = true;
        }

        private void btnQuickFull_Click(object sender, EventArgs e)
        {
            SetParts(true, true, true, true, true, true, true);
        }

        private void btnQuickListening_Click(object sender, EventArgs e)
        {
            SetParts(true, true, true, true, false, false, false);
        }

        private void btnQuickReading_Click(object sender, EventArgs e)
        {
            SetParts(false, false, false, false, true, true, true);
        }

        private void SetParts(bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7)
        {
            chkPart1.Checked = p1;
            chkPart2.Checked = p2;
            chkPart3.Checked = p3;
            chkPart4.Checked = p4;
            chkPart5.Checked = p5;
            chkPart6.Checked = p6;
            chkPart7.Checked = p7;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var parts = new List<int>();
            if (chkPart1.Checked) parts.Add(1);
            if (chkPart2.Checked) parts.Add(2);
            if (chkPart3.Checked) parts.Add(3);
            if (chkPart4.Checked) parts.Add(4);
            if (chkPart5.Checked) parts.Add(5);
            if (chkPart6.Checked) parts.Add(6);
            if (chkPart7.Checked) parts.Add(7);

            if (parts.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn Part nào.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedPartIdsCsv = string.Join(",", parts);

            // Time limit
            var selected = cboTime.SelectedItem as ComboItem;
            TimeLimitMinutes = selected?.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ComboBox helper
        private class ComboItem
        {
            public string Text { get; }
            public int? Value { get; }

            public ComboItem(string text, int? value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString() => Text;
        }
    }
}