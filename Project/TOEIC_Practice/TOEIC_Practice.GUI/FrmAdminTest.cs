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
    public partial class FrmAdminTest : Form
    {
        private readonly AdminEtsBLL _etsBLL = new AdminEtsBLL();
        private readonly AdminTestBLL _testBLL = new AdminTestBLL();

        private List<AdminEtsDTO> _etsList = new List<AdminEtsDTO>();
        private List<AdminTestDTO> _testList = new List<AdminTestDTO>();

        private int _selectedTestId = 0;
        private bool _isLoading = false;

        public FrmAdminTest()
        {
            InitializeComponent();
        }

        private void FrmAdminTest_Load(object sender, EventArgs e)
        {
            try
            {
                _isLoading = true;

                InitGrid();
                LoadEtsToCombobox();
                LoadTestList();

                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form Admin Test:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }

        #region Init UI

        private void InitGrid()
        {
            dgvTest.AutoGenerateColumns = false;
            dgvTest.Columns.Clear();
            dgvTest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTest.MultiSelect = false;
            dgvTest.ReadOnly = true;
            dgvTest.AllowUserToAddRows = false;
            dgvTest.AllowUserToDeleteRows = false;
            dgvTest.RowHeadersVisible = false;
            dgvTest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTest.BackgroundColor = System.Drawing.Color.White;

            dgvTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTestId",
                HeaderText = "ID",
                DataPropertyName = "TestId",
                Width = 60
            });

            dgvTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEtsYear",
                HeaderText = "ETS Year",
                DataPropertyName = "EtsYear",
                Width = 90
            });

            dgvTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTestNo",
                HeaderText = "Test No",
                DataPropertyName = "TestNo",
                Width = 80
            });

            dgvTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTitle",
                HeaderText = "Title",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvTest.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 70
            });

            dgvTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUpdatedAt",
                HeaderText = "Updated At",
                DataPropertyName = "UpdatedAt",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            });
        }

        private void LoadEtsToCombobox()
        {
            _etsList = _etsBLL.GetAll();

            cboEtsFilter.DataSource = null;
            cboEtsEdit.DataSource = null;

            var etsFilterList = new List<AdminEtsDTO>(_etsList);
            etsFilterList.Insert(0, new AdminEtsDTO
            {
                EtsId = 0,
                Year = 0,
                Title = "-- Tất cả ETS --",
                IsActive = true
            });

            cboEtsFilter.DisplayMember = "Title";
            cboEtsFilter.ValueMember = "EtsId";
            cboEtsFilter.DataSource = etsFilterList;

            cboEtsEdit.DisplayMember = "Title";
            cboEtsEdit.ValueMember = "EtsId";
            cboEtsEdit.DataSource = _etsList.Where(x => x.IsActive).ToList();

            if (cboEtsFilter.Items.Count > 0)
                cboEtsFilter.SelectedIndex = 0;

            if (cboEtsEdit.Items.Count > 0)
                cboEtsEdit.SelectedIndex = 0;
        }

        private void LoadTestList()
        {
            int etsId = 0;

            if (cboEtsFilter.SelectedValue != null)
            {
                int.TryParse(cboEtsFilter.SelectedValue.ToString(), out etsId);
            }

            if (etsId > 0)
                _testList = _testBLL.GetByEts(etsId);
            else
                _testList = _testBLL.GetAll();

            dgvTest.DataSource = null;
            dgvTest.DataSource = _testList;

            lblTotal.Text = "Tổng số: " + _testList.Count;
        }

        private void ClearInput()
        {
            _selectedTestId = 0;

            if (cboEtsEdit.Items.Count > 0)
                cboEtsEdit.SelectedIndex = 0;

            nudTestNo.Value = 1;
            txtTitle.Clear();
            chkIsActive.Checked = true;

            lblMode.Text = "Chế độ: Thêm mới";
        }

        private void SetCreateMode()
        {
            ClearInput();

            cboEtsEdit.Enabled = true;
            nudTestNo.Enabled = true;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDeactivate.Enabled = false;
        }

        private void SetEditMode(AdminTestDTO dto)
        {
            if (dto == null) return;

            _selectedTestId = dto.TestId;

            cboEtsEdit.SelectedValue = dto.EtsId;
            nudTestNo.Value = dto.TestNo;
            txtTitle.Text = dto.Title;
            chkIsActive.Checked = dto.IsActive;

            cboEtsEdit.Enabled = false;
            nudTestNo.Enabled = false;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDeactivate.Enabled = true;

            lblMode.Text = "Chế độ: Cập nhật";
        }

        #endregion

        #region Event

        private void cboEtsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadTestList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc danh sách Test:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTestCellClickSafe(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                AdminTestDTO dto = dgvTest.Rows[e.RowIndex].DataBoundItem as AdminTestDTO;
                if (dto == null) return;

                SetEditMode(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn dòng Test:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AdminTestDTO dto = ReadInputForCreate();
                int newId = _testBLL.Create(dto);

                MessageBox.Show("Thêm Test thành công. ID mới = " + newId,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTestList();
                SelectRowByTestId(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Test thất bại:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AdminTestDTO dto = ReadInputForUpdate();
                _testBLL.Update(dto);

                MessageBox.Show("Cập nhật Test thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTestList();
                SelectRowByTestId(dto.TestId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật Test thất bại:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedTestId <= 0)
                    throw new Exception("Bạn chưa chọn Test cần deactivate.");

                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn deactivate Test này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs != DialogResult.Yes)
                    return;

                _testBLL.Deactivate(_selectedTestId);

                MessageBox.Show("Deactivate Test thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTestList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deactivate Test thất bại:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadEtsToCombobox();
                LoadTestList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh thất bại:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                List<AdminTestDTO> filtered = _testList;

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    filtered = _testList.Where(x =>
                        (x.Title ?? "").ToLower().Contains(keyword) ||
                        x.TestId.ToString().Contains(keyword) ||
                        x.TestNo.ToString().Contains(keyword) ||
                        x.EtsYear.ToString().Contains(keyword)
                    ).ToList();
                }

                dgvTest.DataSource = null;
                dgvTest.DataSource = filtered;
                lblTotal.Text = "Tổng số: " + filtered.Count;
            }
            catch
            {
                // bỏ qua lỗi nhỏ khi search realtime
            }
        }

        #endregion

        #region Read Input

        private AdminTestDTO ReadInputForCreate()
        {
            if (cboEtsEdit.SelectedValue == null)
                throw new Exception("Bạn chưa chọn ETS.");

            AdminTestDTO dto = new AdminTestDTO
            {
                EtsId = Convert.ToInt32(cboEtsEdit.SelectedValue),
                TestNo = Convert.ToByte(nudTestNo.Value),
                Title = txtTitle.Text.Trim()
            };

            return dto;
        }

        private AdminTestDTO ReadInputForUpdate()
        {
            if (_selectedTestId <= 0)
                throw new Exception("Bạn chưa chọn Test để cập nhật.");

            AdminTestDTO dto = new AdminTestDTO
            {
                TestId = _selectedTestId,
                Title = txtTitle.Text.Trim(),
                IsActive = chkIsActive.Checked
            };

            return dto;
        }

        #endregion

        #region Helper

        private void SelectRowByTestId(int testId)
        {
            foreach (DataGridViewRow row in dgvTest.Rows)
            {
                if (row.DataBoundItem is AdminTestDTO dto && dto.TestId == testId)
                {
                    row.Selected = true;
                    dgvTest.CurrentCell = row.Cells[0];
                    SetEditMode(dto);
                    return;
                }
            }
        }

        #endregion
    }
}