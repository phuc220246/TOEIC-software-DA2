using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL;
using TOEIC_Practice.BLL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.GUI.Admin
{
    public partial class FrmAdminEts : Form
    {
        private readonly AdminEtsBLL _etsBLL = new AdminEtsBLL();

        private List<AdminEtsDTO> _etsList = new List<AdminEtsDTO>();
        private int _selectedEtsId = 0;

        public FrmAdminEts()
        {
            InitializeComponent();
        }

        private void FrmAdminEts_Load(object sender, EventArgs e)
        {
            try
            {
                InitGrid();
                LoadEtsList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load form Admin ETS:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Init UI

        private void InitGrid()
        {
            dgvEts.AutoGenerateColumns = false;
            dgvEts.Columns.Clear();
            dgvEts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEts.MultiSelect = false;
            dgvEts.ReadOnly = true;
            dgvEts.AllowUserToAddRows = false;
            dgvEts.AllowUserToDeleteRows = false;
            dgvEts.RowHeadersVisible = false;
            dgvEts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEts.BackgroundColor = System.Drawing.Color.White;

            dgvEts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEtsId",
                HeaderText = "ID",
                DataPropertyName = "EtsId",
                Width = 70
            });

            dgvEts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colYear",
                HeaderText = "Year",
                DataPropertyName = "Year",
                Width = 100
            });

            dgvEts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTitle",
                HeaderText = "Title",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvEts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 80
            });

            dgvEts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUpdatedAt",
                HeaderText = "Updated At",
                DataPropertyName = "UpdatedAt",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            });
        }

        private void LoadEtsList()
        {
            _etsList = _etsBLL.GetAll();

            dgvEts.DataSource = null;
            dgvEts.DataSource = _etsList;

            lblTotal.Text = "Tổng số: " + _etsList.Count;
        }

        private void ClearInput()
        {
            _selectedEtsId = 0;

            nudYear.Value = 2024;
            txtTitle.Clear();
            chkIsActive.Checked = true;

            lblMode.Text = "Chế độ: Thêm mới";
        }

        private void SetCreateMode()
        {
            ClearInput();

            nudYear.Enabled = true;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDeactivate.Enabled = false;
        }

        private void SetEditMode(AdminEtsDTO dto)
        {
            if (dto == null) return;

            _selectedEtsId = dto.EtsId;

            if (dto.Year >= nudYear.Minimum && dto.Year <= nudYear.Maximum)
                nudYear.Value = dto.Year;

            txtTitle.Text = dto.Title;
            chkIsActive.Checked = dto.IsActive;

            nudYear.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDeactivate.Enabled = true;

            lblMode.Text = "Chế độ: Cập nhật";
        }

        #endregion

        #region Events

        private void dgvEts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                AdminEtsDTO dto = dgvEts.Rows[e.RowIndex].DataBoundItem as AdminEtsDTO;
                if (dto == null) return;

                SetEditMode(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn dòng ETS:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AdminEtsDTO dto = ReadInputForCreate();
                int newId = _etsBLL.Create(dto);

                MessageBox.Show(
                    "Thêm ETS thành công. ID mới = " + newId,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEtsList();
                SelectRowByEtsId(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm ETS thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AdminEtsDTO dto = ReadInputForUpdate();
                _etsBLL.Update(dto);

                MessageBox.Show(
                    "Cập nhật ETS thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEtsList();
                SelectRowByEtsId(dto.EtsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cập nhật ETS thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedEtsId <= 0)
                    throw new Exception("Bạn chưa chọn ETS cần deactivate.");

                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn deactivate ETS này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs != DialogResult.Yes)
                    return;

                _etsBLL.Deactivate(_selectedEtsId);

                MessageBox.Show(
                    "Deactivate ETS thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEtsList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Deactivate ETS thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetCreateMode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEtsList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Refresh thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                List<AdminEtsDTO> filtered = _etsList;

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    filtered = _etsList.Where(x =>
                        x.EtsId.ToString().Contains(keyword) ||
                        x.Year.ToString().Contains(keyword) ||
                        (x.Title ?? "").ToLower().Contains(keyword)
                    ).ToList();
                }

                dgvEts.DataSource = null;
                dgvEts.DataSource = filtered;
                lblTotal.Text = "Tổng số: " + filtered.Count;
            }
            catch
            {
                // bỏ qua lỗi nhỏ khi search realtime
            }
        }

        #endregion

        #region Read Input

        private AdminEtsDTO ReadInputForCreate()
        {
            return new AdminEtsDTO
            {
                Year = Convert.ToInt32(nudYear.Value),
                Title = txtTitle.Text.Trim()
            };
        }

        private AdminEtsDTO ReadInputForUpdate()
        {
            if (_selectedEtsId <= 0)
                throw new Exception("Bạn chưa chọn ETS để cập nhật.");

            return new AdminEtsDTO
            {
                EtsId = _selectedEtsId,
                Year = Convert.ToInt32(nudYear.Value),
                Title = txtTitle.Text.Trim(),
                IsActive = chkIsActive.Checked
            };
        }

        #endregion

        #region Helper

        private void SelectRowByEtsId(int etsId)
        {
            foreach (DataGridViewRow row in dgvEts.Rows)
            {
                if (row.DataBoundItem is AdminEtsDTO dto && dto.EtsId == etsId)
                {
                    row.Selected = true;
                    dgvEts.CurrentCell = row.Cells[0];
                    SetEditMode(dto);
                    return;
                }
            }
        }

        #endregion
    }
}