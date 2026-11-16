using System;
using System.Windows.Forms;
using TOEIC_Practice.BLL;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.TaiKhoan;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.TaiKhoan;
using TOEIC_Practice.GUI.Admin;

namespace TOEIC_Practice.GUI
{
    public partial class FrmDangNhap : Form
    {
        private readonly AccountBLL _accountBLL = new AccountBLL();

        public FrmDangNhap()
        {
            InitializeComponent();
            this.Load += FrmDangNhap_Load;
            this.FormClosed += FrmDangNhap_FormClosed;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
#if DEBUG
            EnsureSampleAccountsIfEmpty();
#endif
            InitLoginUI();
        }

        private void InitLoginUI()
        {
            try
            {
                if (txtMatKhau != null)
                    txtMatKhau.PasswordChar = '*';

                if (chkHienMatKhau != null)
                    chkHienMatKhau.Checked = false;
            }
            catch
            {
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTenTaiKhoan.Text.Trim();
                string password = txtMatKhau.Text;

                _accountBLL.Login(username, password);

                if (Session.IsAdmin)
                {
                    FrmAdminMain frmAdmin = new FrmAdminMain();
                    frmAdmin.Show();
                    this.Hide();
                }
                else
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau == null || chkHienMatKhau == null)
                return;

            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '*';
        }

        private void EnsureSampleAccountsIfEmpty()
        {
            try
            {
                AccountDAL dal = new AccountDAL();
                AccountBLL bll = new AccountBLL();

                AccountDTO adminAccount = dal.GetByUsername("admin");
                if (adminAccount == null)
                {
                    int adminId = bll.CreateAccount("admin", "Quản trị viên", "123456");
                    bll.AssignRole(adminId, "Admin");
                }

                AccountDTO userAccount = dal.GetByUsername("user1");
                if (userAccount == null)
                {
                    int userId = bll.CreateAccount("user1", "Người dùng mẫu", "123456");
                    bll.AssignRole(userId, "User");
                }
            }
            catch
            {
                // Không chặn form đăng nhập nếu seed lỗi
            }
        }

            private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }
    }
}