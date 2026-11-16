using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TOEIC_Practice.DTO;

namespace TOEIC_Practice.GUI.Admin
{
    public partial class FrmAdminMain : Form
    {
        private Form _currentChildForm;
        private bool _isLoggingOut = false;
        private Timer _clockTimer;

        private readonly Color _menuBackColor = Color.FromArgb(32, 43, 76);
        private readonly Color _menuBorderColor = Color.FromArgb(90, 110, 160);
        private readonly Color _menuActiveColor = Color.FromArgb(41, 128, 185);
        private readonly Color _logoutColor = Color.FromArgb(220, 53, 69);

        public FrmAdminMain()
        {
            InitializeComponent();

            this.Load += FrmAdminMain_Load;
            this.FormClosed += FrmAdminMain_FormClosed;
            this.Resize += FrmAdminMain_Resize;
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {
            try
            {
                CheckAdminPermission();
                InitFormUi();
                InitClock();
                UpdateHeaderInfo();

                // Mặc định mở trang thống kê hoặc dashboard
                ActivateMenuButton(btnDashboard);
                OpenChildForm(new FrmAdminStats());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể khởi tạo trang Admin:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Session.Clear();
                FrmDangNhap frm = new FrmDangNhap();
                frm.Show();
                this.Hide();
            }
        }

        private void CheckAdminPermission()
        {
            if (!Session.IsLoggedIn || !Session.IsAdmin)
            {
                throw new Exception("Bạn không có quyền truy cập khu vực Admin.");
            }
        }

        private void InitFormUi()
        {
            this.Text = "TOEIC Practice - Admin";
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1200, 700);

            pnlContainer.Dock = DockStyle.Fill;
            pnlHeader.Dock = DockStyle.Top;
            pnlSidebar.Dock = DockStyle.Left;

            pnlContainer.BackColor = Color.FromArgb(245, 247, 250);

            // Giúp vẽ mượt hơn chút
            this.DoubleBuffered = true;
        }

        private void InitClock()
        {
            if (_clockTimer != null)
            {
                _clockTimer.Stop();
                _clockTimer.Dispose();
            }

            _clockTimer = new Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();

            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void UpdateHeaderInfo()
        {
            string name = !string.IsNullOrWhiteSpace(Session.DisplayName)
                ? Session.DisplayName
                : Session.Username;

            lblWelcome.Text = "Xin chào, " + name;
        }

        private void FrmAdminMain_Resize(object sender, EventArgs e)
        {
            // Có thể cập nhật gì thêm khi resize nếu cần.
            // Hiện tại Dock/Anchor đã xử lý phần lớn việc co giãn.
        }

        private void OpenChildForm(Form childForm)
        {
            if (childForm == null) return;

            try
            {
                if (_currentChildForm != null)
                {
                    _currentChildForm.Close();
                    _currentChildForm.Dispose();
                    _currentChildForm = null;
                }

                _currentChildForm = childForm;

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.AutoScaleMode = AutoScaleMode.Font;

                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(childForm);
                pnlContainer.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở form con:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ResetMenuButtons()
        {
            List<Button> menuButtons = new List<Button>
            {
                btnDashboard,
                btnAdminEts,
                btnAdminTest,
                btnAdminGroup,
                btnAdminQuestion,
                btnAdminAccount,
                btnAdminStats
            };

            foreach (Button btn in menuButtons)
            {
                btn.BackColor = _menuBackColor;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = _menuBorderColor;
                btn.FlatAppearance.BorderSize = 1;
            }

            btnDashboard.BackColor = _menuBackColor;
            btnDangXuat.BackColor = _logoutColor;
            btnDangXuat.ForeColor = Color.White;
        }

        private void ActivateMenuButton(Button activeButton)
        {
            ResetMenuButtons();

            if (activeButton == null) return;

            activeButton.BackColor = _menuActiveColor;
            activeButton.ForeColor = Color.White;
            activeButton.FlatAppearance.BorderColor = Color.White;
            activeButton.FlatAppearance.BorderSize = 1;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnDashboard);
            OpenChildForm(new FrmAdminStats());
        }

        private void btnAdminEts_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminEts);
            OpenChildForm(new FrmAdminEts());
        }

        private void btnAdminTest_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminTest);
            OpenChildForm(new FrmAdminTest());
        }

        private void btnAdminGroup_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminGroup);
            OpenChildForm(new FrmAdminGroup());
        }

        private void btnAdminQuestion_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminQuestion);
            OpenChildForm(new FrmAdminQuestion());
        }

        private void btnAdminAccount_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminAccount);
            OpenChildForm(new FrmAdminAccount());
        }

        private void btnAdminStats_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(btnAdminStats);
            OpenChildForm(new FrmAdminStats());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs != DialogResult.Yes)
                return;

            try
            {
                _isLoggingOut = true;

                if (_clockTimer != null)
                {
                    _clockTimer.Stop();
                    _clockTimer.Dispose();
                    _clockTimer = null;
                }

                if (_currentChildForm != null)
                {
                    _currentChildForm.Close();
                    _currentChildForm.Dispose();
                    _currentChildForm = null;
                }

                Session.Clear();

                FrmDangNhap frmLogin = new FrmDangNhap();
                frmLogin.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                _isLoggingOut = false;

                MessageBox.Show(
                    "Đăng xuất thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_clockTimer != null)
            {
                _clockTimer.Stop();
                _clockTimer.Dispose();
                _clockTimer = null;
            }

            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }
    }
}