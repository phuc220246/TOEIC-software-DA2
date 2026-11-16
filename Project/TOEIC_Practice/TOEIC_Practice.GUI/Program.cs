using System;
using System.Windows.Forms;

namespace TOEIC_Practice.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form đăng nhập đầu tiên
            Application.Run(new FrmDangNhap());
        }
    }
}