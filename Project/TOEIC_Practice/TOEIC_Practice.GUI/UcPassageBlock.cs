using System;
using System.Windows.Forms;

namespace TOEIC_Practice.GUI
{
    public partial class UcPassageBlock : UserControl
    {
        public UcPassageBlock()
        {
            InitializeComponent();
        }

        public void Bind(string title, string passageText)
        {
            lblTitle.Text = string.IsNullOrWhiteSpace(title) ? "Đoạn văn" : title;
            txtPassage.Text = passageText ?? "";
        }
    }
}