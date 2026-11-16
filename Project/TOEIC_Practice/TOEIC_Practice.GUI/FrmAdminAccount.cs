using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.Admin;
using TOEIC_Practice.DTO.Admin;


namespace TOEIC_Practice.GUI.Admin
{
    public partial class FrmAdminAccount : Form
    {
        private readonly AdminAccountBLL _bll = new AdminAccountBLL();
        private List<AdminAccountDTO> _allAccounts = new List<AdminAccountDTO>();
        private List<AdminRoleDTO> _roles = new List<AdminRoleDTO>();
        private int _selectedAccountId = 0;
        private bool _isEditMode = false;

        public FrmAdminAccount()
        {
            InitializeComponent();
        }

        private void FrmAdminAccount_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoles();
                SetupGrid();
                LoadAccounts();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khởi tạo form Account:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRoles()
        {
            _roles = _bll.GetRoles();

            List<AdminRoleDTO> filterRoles = new List<AdminRoleDTO>();
            filterRoles.Add(new AdminRoleDTO { RoleId = 0, RoleName = "-- Tất cả --" });
            filterRoles.AddRange(_roles);

            cboRoleFilter.DataSource = null;
            cboRoleFilter.DisplayMember = "RoleName";
            cboRoleFilter.ValueMember = "RoleName";
            cboRoleFilter.DataSource = filterRoles;

            cboRoleEdit.DataSource = null;
            cboRoleEdit.DisplayMember = "RoleName";
            cboRoleEdit.ValueMember = "RoleName";
            cboRoleEdit.DataSource = _roles;
        }

        private void SetupGrid()
        {
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.ReadOnly = true;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.MultiSelect = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAccount.Columns.Clear();

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAccountId",
                HeaderText = "ID",
                DataPropertyName = "AccountId",
                FillWeight = 50
            });

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsername",
                HeaderText = "Username",
                DataPropertyName = "Username",
                FillWeight = 110
            });

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDisplayName",
                HeaderText = "DisplayName",
                DataPropertyName = "DisplayName",
                FillWeight = 120
            });

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRoleName",
                HeaderText = "Role",
                DataPropertyName = "RoleName",
                FillWeight = 80
            });

            dgvAccount.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                FillWeight = 60
            });

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCreatedAt",
                HeaderText = "CreatedAt",
                DataPropertyName = "CreatedAt",
                FillWeight = 110,
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvAccount.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLastLoginAt",
                HeaderText = "LastLogin",
                DataPropertyName = "LastLoginAt",
                FillWeight = 110,
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
            });
        }

        private void LoadAccounts()
        {
            _allAccounts = _bll.GetAll();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = (txtSearch.Text ?? "").Trim().ToLower();
            string selectedRole = cboRoleFilter.SelectedValue == null ? "" : cboRoleFilter.SelectedValue.ToString();

            IEnumerable<AdminAccountDTO> query = _allAccounts;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    (!string.IsNullOrWhiteSpace(x.Username) && x.Username.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrWhiteSpace(x.DisplayName) && x.DisplayName.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrWhiteSpace(x.RoleName) && x.RoleName.ToLower().Contains(keyword)));
            }

            if (!string.IsNullOrWhiteSpace(selectedRole) && selectedRole != "-- Tất cả --")
            {
                query = query.Where(x => string.Equals(x.RoleName, selectedRole, StringComparison.OrdinalIgnoreCase));
            }

            List<AdminAccountDTO> list = query.ToList();

            dgvAccount.DataSource = null;
            dgvAccount.DataSource = list;

            lblTotal.Text = "Tổng số: " + list.Count;
        }

        private void ResetForm()
        {
            _selectedAccountId = 0;
            _isEditMode = false;

            lblMode.Text = "Chế độ: Thêm mới";

            txtUsername.Text = "";
            txtDisplayName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;

            txtUsername.ReadOnly = false;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;

            if (cboRoleEdit.Items.Count > 0)
                cboRoleEdit.SelectedIndex = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnResetPassword.Enabled = false;
            btnSetActive.Enabled = false;

            dgvAccount.ClearSelection();
            txtUsername.Focus();
        }

        private void FillForm(AdminAccountDTO dto)
        {
            if (dto == null) return;

            _selectedAccountId = dto.AccountId;
            _isEditMode = true;

            lblMode.Text = "Chế độ: Cập nhật";

            txtUsername.Text = dto.Username;
            txtDisplayName.Text = dto.DisplayName;
            chkIsActive.Checked = dto.IsActive;

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            txtUsername.ReadOnly = true;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;

            SelectRoleInEdit(dto.RoleName);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnResetPassword.Enabled = true;
            btnSetActive.Enabled = true;
        }

        private void SelectRoleInEdit(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                if (cboRoleEdit.Items.Count > 0)
                    cboRoleEdit.SelectedIndex = 0;
                return;
            }

            for (int i = 0; i < cboRoleEdit.Items.Count; i++)
            {
                AdminRoleDTO role = cboRoleEdit.Items[i] as AdminRoleDTO;
                if (role != null && string.Equals(role.RoleName, roleName, StringComparison.OrdinalIgnoreCase))
                {
                    cboRoleEdit.SelectedIndex = i;
                    return;
                }
            }
        }

        private string GetSelectedRoleNameForEdit()
        {
            AdminRoleDTO role = cboRoleEdit.SelectedItem as AdminRoleDTO;
            return role == null ? "" : role.RoleName;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = _bll.Create(
                    txtUsername.Text,
                    txtDisplayName.Text,
                    txtPassword.Text,
                    txtConfirmPassword.Text,
                    GetSelectedRoleNameForEdit(),
                    chkIsActive.Checked);

                MessageBox.Show(
                    "Thêm tài khoản thành công. ID mới: " + newId,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAccounts();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm tài khoản thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAccountId <= 0)
                    throw new Exception("Bạn chưa chọn tài khoản cần cập nhật.");

                _bll.Update(
                    _selectedAccountId,
                    txtDisplayName.Text,
                    GetSelectedRoleNameForEdit(),
                    chkIsActive.Checked);

                MessageBox.Show(
                    "Cập nhật tài khoản thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAccounts();

                AdminAccountDTO dto = _bll.GetById(_selectedAccountId);
                FillForm(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cập nhật tài khoản thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAccountId <= 0)
                    throw new Exception("Bạn chưa chọn tài khoản cần reset mật khẩu.");

                string newPassword = PromptPassword("Nhập mật khẩu mới:");
                if (newPassword == null) return;

                string confirmPassword = PromptPassword("Nhập lại mật khẩu mới:");
                if (confirmPassword == null) return;

                _bll.ResetPassword(_selectedAccountId, newPassword, confirmPassword);

                MessageBox.Show(
                    "Reset mật khẩu thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Reset mật khẩu thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSetActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAccountId <= 0)
                    throw new Exception("Bạn chưa chọn tài khoản.");

                bool newState = !chkIsActive.Checked;
                string actionText = newState ? "mở khóa" : "khóa";

                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn " + actionText + " tài khoản này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs != DialogResult.Yes)
                    return;

                _bll.SetActive(_selectedAccountId, newState);

                MessageBox.Show(
                    "Cập nhật trạng thái tài khoản thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAccounts();

                AdminAccountDTO dto = _bll.GetById(_selectedAccountId);
                FillForm(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cập nhật trạng thái thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadRoles();
                LoadAccounts();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Làm mới thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cboRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || dgvAccount.Rows.Count == 0)
                    return;

                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                if (row == null || row.Cells["colAccountId"].Value == null)
                    return;

                int accountId = Convert.ToInt32(row.Cells["colAccountId"].Value);
                AdminAccountDTO dto = _bll.GetById(accountId);

                FillForm(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn dòng tài khoản:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string PromptPassword(string title)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 420;
                prompt.Height = 170;
                prompt.Text = title;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;

                Label lbl = new Label();
                lbl.Left = 20;
                lbl.Top = 20;
                lbl.Width = 350;
                lbl.Text = title;

                TextBox txt = new TextBox();
                txt.Left = 20;
                txt.Top = 50;
                txt.Width = 350;
                txt.PasswordChar = '*';

                Button btnOk = new Button();
                btnOk.Text = "OK";
                btnOk.Left = 214;
                btnOk.Top = 85;
                btnOk.Width = 75;
                btnOk.DialogResult = DialogResult.OK;

                Button btnCancel = new Button();
                btnCancel.Text = "Hủy";
                btnCancel.Left = 295;
                btnCancel.Top = 85;
                btnCancel.Width = 75;
                btnCancel.DialogResult = DialogResult.Cancel;

                prompt.Controls.Add(lbl);
                prompt.Controls.Add(txt);
                prompt.Controls.Add(btnOk);
                prompt.Controls.Add(btnCancel);

                prompt.AcceptButton = btnOk;
                prompt.CancelButton = btnCancel;

                return prompt.ShowDialog() == DialogResult.OK ? txt.Text : null;
            }
        }
    }
}