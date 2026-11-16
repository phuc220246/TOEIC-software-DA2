using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL;
using TOEIC_Practice.BLL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;
using System.IO;
using TOEIC_Practice.Helpers;

namespace TOEIC_Practice.GUI.Admin
{
    public partial class FrmAdminGroup : Form
    {
        private readonly AdminTestBLL _testBLL = new AdminTestBLL();
        private readonly AdminGroupBLL _groupBLL = new AdminGroupBLL();

        private List<AdminTestDTO> _testList = new List<AdminTestDTO>();
        private List<AdminQuestionGroupDTO> _groupList = new List<AdminQuestionGroupDTO>();

        private int _selectedGroupId = 0;
        private bool _isLoading = false;

        public FrmAdminGroup()
        {
            InitializeComponent();
        }

        private void FrmAdminGroup_Load(object sender, EventArgs e)
        {
            try
            {
                _isLoading = true;

                InitGrid();
                LoadTestCombobox();
                LoadPartCombobox();

                cboGroupType.Items.Clear();
                cboGroupType.Items.Add("SINGLE");
                cboGroupType.Items.Add("CONVERSATION");
                cboGroupType.Items.Add("PASSAGE");

                LoadGroupList();
                SetCreateMode();
                ApplyPartRulesToUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load form Admin Group:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }

        #region Init UI

        private void InitGrid()
        {
            dgvGroup.AutoGenerateColumns = false;
            dgvGroup.Columns.Clear();
            dgvGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroup.MultiSelect = false;
            dgvGroup.ReadOnly = true;
            dgvGroup.AllowUserToAddRows = false;
            dgvGroup.AllowUserToDeleteRows = false;
            dgvGroup.RowHeadersVisible = false;
            dgvGroup.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGroup.BackgroundColor = System.Drawing.Color.White;

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGroupId",
                HeaderText = "ID",
                DataPropertyName = "GroupId",
                Width = 60
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTestId",
                HeaderText = "Test",
                DataPropertyName = "TestId",
                Width = 70
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPartId",
                HeaderText = "Part",
                DataPropertyName = "PartId",
                Width = 70
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGroupType",
                HeaderText = "Group Type",
                DataPropertyName = "GroupType",
                Width = 130
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOrderNo",
                HeaderText = "Order",
                DataPropertyName = "OrderNo",
                Width = 80
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAudioPath",
                HeaderText = "Audio",
                DataPropertyName = "AudioPath",
                Width = 140
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colImagePath",
                HeaderText = "Image",
                DataPropertyName = "ImagePath",
                Width = 140
            });

            dgvGroup.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 70
            });

            dgvGroup.Columns.Add(new DataGridViewTextBoxColumn
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

        private void LoadTestCombobox()
        {
            _testList = _testBLL.GetAll();

            cboTestFilter.DataSource = null;
            cboTestEdit.DataSource = null;

            List<TestFilterItem> filterItems = new List<TestFilterItem>();
            filterItems.Add(new TestFilterItem
            {
                TestId = 0,
                DisplayText = "-- Tất cả Test --"
            });

            foreach (AdminTestDTO item in _testList)
            {
                filterItems.Add(new TestFilterItem
                {
                    TestId = item.TestId,
                    DisplayText = BuildTestDisplay(item)
                });
            }

            cboTestFilter.DisplayMember = "DisplayText";
            cboTestFilter.ValueMember = "TestId";
            cboTestFilter.DataSource = filterItems;

            var editItems = _testList
                .Where(x => x.IsActive)
                .Select(x => new TestFilterItem
                {
                    TestId = x.TestId,
                    DisplayText = BuildTestDisplay(x)
                })
                .ToList();

            cboTestEdit.DisplayMember = "DisplayText";
            cboTestEdit.ValueMember = "TestId";
            cboTestEdit.DataSource = editItems;

            if (cboTestFilter.Items.Count > 0)
                cboTestFilter.SelectedIndex = 0;

            if (cboTestEdit.Items.Count > 0)
                cboTestEdit.SelectedIndex = 0;
        }

        private void LoadPartCombobox()
        {
            List<PartItem> filterParts = new List<PartItem>();
            filterParts.Add(new PartItem { PartId = 0, PartName = "-- Tất cả Part --" });
            for (int i = 1; i <= 7; i++)
            {
                filterParts.Add(new PartItem { PartId = i, PartName = "Part " + i });
            }

            cboPartFilter.DisplayMember = "PartName";
            cboPartFilter.ValueMember = "PartId";
            cboPartFilter.DataSource = filterParts;

            List<PartItem> editParts = new List<PartItem>();
            for (int i = 1; i <= 7; i++)
            {
                editParts.Add(new PartItem { PartId = i, PartName = "Part " + i });
            }

            cboPartEdit.DisplayMember = "PartName";
            cboPartEdit.ValueMember = "PartId";
            cboPartEdit.DataSource = editParts;

            if (cboPartFilter.Items.Count > 0)
                cboPartFilter.SelectedIndex = 0;

            if (cboPartEdit.Items.Count > 0)
                cboPartEdit.SelectedIndex = 0;
        }

        private void LoadGroupList()
        {
            int testId = 0;
            int partId = 0;

            if (cboTestFilter.SelectedValue != null)
                int.TryParse(cboTestFilter.SelectedValue.ToString(), out testId);

            if (cboPartFilter.SelectedValue != null)
                int.TryParse(cboPartFilter.SelectedValue.ToString(), out partId);

            if (testId > 0 && partId > 0)
                _groupList = _groupBLL.GetByTestPart(testId, partId);
            else if (testId > 0)
                _groupList = _groupBLL.GetByTest(testId);
            else
                _groupList = new List<AdminQuestionGroupDTO>();

            dgvGroup.DataSource = null;
            dgvGroup.DataSource = _groupList;

            lblTotal.Text = "Tổng số: " + _groupList.Count;
        }

        private string BuildTestDisplay(AdminTestDTO test)
        {
            string yearText = test.EtsYear > 0 ? test.EtsYear.ToString() : "ETS";
            return yearText + " - Test " + test.TestNo + " - " + (test.Title ?? "");
        }

        private void ClearInput()
        {
            _selectedGroupId = 0;

            if (cboTestEdit.Items.Count > 0)
                cboTestEdit.SelectedIndex = 0;

            if (cboPartEdit.Items.Count > 0)
                cboPartEdit.SelectedIndex = 0;

            txtAudioPath.Clear();
            txtImagePath.Clear();
            txtPassageText.Clear();
            nudOrderNo.Value = 1;
            chkIsActive.Checked = true;

            lblMode.Text = "Chế độ: Thêm mới";

            ApplyPartRulesToUI();
            ClearUnusedFieldsByPart(GetSelectedPartId());
        }

        private void SetCreateMode()
        {
            ClearInput();

            cboTestEdit.Enabled = true;
            cboPartEdit.Enabled = true;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDeactivate.Enabled = false;

            ApplyPartRulesToUI();
        }

        private void SetEditMode(AdminQuestionGroupDTO dto)
        {
            if (dto == null) return;

            _selectedGroupId = dto.GroupId;

            cboTestEdit.SelectedValue = dto.TestId;
            cboPartEdit.SelectedValue = dto.PartId;

            if (!string.IsNullOrWhiteSpace(dto.GroupType))
            {
                int index = cboGroupType.FindStringExact(dto.GroupType.Trim().ToUpper());
                if (index >= 0)
                    cboGroupType.SelectedIndex = index;
            }

            txtAudioPath.Text = dto.AudioPath;
            txtImagePath.Text = dto.ImagePath;
            txtPassageText.Text = dto.PassageText;

            if (dto.OrderNo >= nudOrderNo.Minimum && dto.OrderNo <= nudOrderNo.Maximum)
                nudOrderNo.Value = dto.OrderNo;

            chkIsActive.Checked = dto.IsActive;

            cboTestEdit.Enabled = false;
            cboPartEdit.Enabled = false;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDeactivate.Enabled = true;

            lblMode.Text = "Chế độ: Cập nhật";

            ApplyPartRulesToUI();
        }

        #endregion

        #region Part Rules UI

        private int GetSelectedPartId()
        {
            if (cboPartEdit.SelectedValue == null)
                return 0;

            int partId;
            int.TryParse(cboPartEdit.SelectedValue.ToString(), out partId);
            return partId;
        }
        private string GetPartFolder()
        {
            int partId = GetSelectedPartId();

            if (partId < 1 || partId > 7)
                throw new Exception("Bạn chưa chọn Part hợp lệ.");

            return "Part" + partId;
        }

        private void ValidateMediaFileNameMatchPart(string filePath, int partId, string mediaType)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new Exception("Thiếu file " + mediaType + ".");

            string fileName = Path.GetFileName(filePath);

            string expectedPartToken = "_P" + partId + "_";
            if (!fileName.ToUpper().Contains(expectedPartToken.ToUpper()))
            {
                DialogResult rs = MessageBox.Show(
                    mediaType + " bạn chọn có tên file không khớp Part hiện tại.\n" +
                    "File: " + fileName + "\n" +
                    "Part đang chọn: Part " + partId + "\n\n" +
                    "Bạn vẫn muốn tiếp tục chứ?",
                    "Xác nhận media",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs != DialogResult.Yes)
                    throw new Exception("Đã hủy chọn " + mediaType + " do không khớp Part.");
            }
        }
        private void SetAudioVisible(bool visible)
        {
            lblAudioPath.Visible = visible;
            txtAudioPath.Visible = visible;
            btnBrowseAudio.Visible = visible;
        }

        private void SetImageVisible(bool visible)
        {
            lblImagePath.Visible = visible;
            txtImagePath.Visible = visible;
            btnBrowseImage.Visible = visible;
        }

        private void SetPassageVisible(bool visible)
        {
            lblPassageText.Visible = visible;
            txtPassageText.Visible = visible;
        }

        private void SetGroupTypeEnabled(bool enabled)
        {
            cboGroupType.Enabled = enabled;
        }

        private void SetGroupTypeByPart(int partId)
        {
            switch (partId)
            {
                case 1:
                case 2:
                case 5:
                    cboGroupType.SelectedItem = "SINGLE";
                    break;

                case 3:
                case 4:
                    cboGroupType.SelectedItem = "CONVERSATION";
                    break;

                case 6:
                case 7:
                    cboGroupType.SelectedItem = "PASSAGE";
                    break;

                default:
                    if (cboGroupType.Items.Count > 0)
                        cboGroupType.SelectedIndex = 0;
                    break;
            }
        }

        private void ClearUnusedFieldsByPart(int partId)
        {
            switch (partId)
            {
                case 1:
                    txtPassageText.Clear();
                    break;

                case 2:
                    txtImagePath.Clear();
                    txtPassageText.Clear();
                    break;

                case 3:
                case 4:
                    txtPassageText.Clear();
                    break;

                case 5:
                    txtAudioPath.Clear();
                    txtImagePath.Clear();
                    txtPassageText.Clear();
                    break;

                case 6:
                case 7:
                    txtAudioPath.Clear();
                    txtImagePath.Clear();
                    break;
            }
        }

        private void ApplyPartRulesToUI()
        {
            int partId = GetSelectedPartId();

            switch (partId)
            {
                case 1:
                    SetAudioVisible(true);
                    SetImageVisible(true);
                    SetPassageVisible(false);
                    SetGroupTypeByPart(partId);
                    SetGroupTypeEnabled(false);
                    break;

                case 2:
                    SetAudioVisible(true);
                    SetImageVisible(false);
                    SetPassageVisible(false);
                    SetGroupTypeByPart(partId);
                    SetGroupTypeEnabled(false);
                    break;

                case 3:
                case 4:
                    SetAudioVisible(true);
                    SetImageVisible(true);
                    SetPassageVisible(false);
                    SetGroupTypeByPart(partId);
                    SetGroupTypeEnabled(false);
                    break;

                case 5:
                    SetAudioVisible(false);
                    SetImageVisible(false);
                    SetPassageVisible(false);
                    SetGroupTypeByPart(partId);
                    SetGroupTypeEnabled(false);
                    break;

                case 6:
                case 7:
                    SetAudioVisible(false);
                    SetImageVisible(false);
                    SetPassageVisible(true);
                    SetGroupTypeByPart(partId);
                    SetGroupTypeEnabled(false);
                    break;

                default:
                    SetAudioVisible(true);
                    SetImageVisible(true);
                    SetPassageVisible(true);
                    SetGroupTypeEnabled(true);
                    break;
            }
        }

        private void ValidateGroupInputByPart()
        {
            int partId = GetSelectedPartId();

            if (cboTestEdit.SelectedValue == null)
                throw new Exception("Bạn chưa chọn Test.");

            if (partId < 1 || partId > 7)
                throw new Exception("Bạn chưa chọn Part hợp lệ.");

            if (nudOrderNo.Value <= 0)
                throw new Exception("OrderNo phải lớn hơn 0.");

            switch (partId)
            {
                case 1:
                    if (string.IsNullOrWhiteSpace(txtAudioPath.Text))
                        throw new Exception("Part 1 bắt buộc có AudioPath.");
                    if (string.IsNullOrWhiteSpace(txtImagePath.Text))
                        throw new Exception("Part 1 bắt buộc có ImagePath.");

                    ValidateAudioExistsInAssets();
                    ValidateImageExistsInAssets();
                    break;

                case 2:
                    if (string.IsNullOrWhiteSpace(txtAudioPath.Text))
                        throw new Exception("Part 2 bắt buộc có AudioPath.");

                    ValidateAudioExistsInAssets();
                    break;

                case 3:
                case 4:
                    if (string.IsNullOrWhiteSpace(txtAudioPath.Text))
                        throw new Exception("Part này bắt buộc có AudioPath.");

                    ValidateAudioExistsInAssets();

                    if (!string.IsNullOrWhiteSpace(txtImagePath.Text))
                        ValidateImageExistsInAssets();
                    break;

                case 6:
                case 7:
                    if (string.IsNullOrWhiteSpace(txtPassageText.Text))
                        throw new Exception("Part này bắt buộc có PassageText.");
                    break;
            }
        }
        private void ValidateAudioExistsInAssets()
        {
            if (string.IsNullOrWhiteSpace(txtAudioPath.Text))
                return;

            string fullPath = MediaPathHelper.GetAbsoluteAudioPath(txtAudioPath.Text.Trim());
            if (!File.Exists(fullPath))
                throw new Exception("AudioPath không tồn tại trong Assets:\n" + fullPath);
        }

        private void ValidateImageExistsInAssets()
        {
            if (string.IsNullOrWhiteSpace(txtImagePath.Text))
                return;

            string fullPath = MediaPathHelper.GetAbsoluteImagePath(txtImagePath.Text.Trim());
            if (!File.Exists(fullPath))
                throw new Exception("ImagePath không tồn tại trong Assets:\n" + fullPath);
        }

        #endregion

        #region Events

        private void cboTestFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadGroupList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lọc theo Test:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboPartFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadGroupList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lọc theo Part:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboPartEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            ApplyPartRulesToUI();
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                AdminQuestionGroupDTO dto = dgvGroup.Rows[e.RowIndex].DataBoundItem as AdminQuestionGroupDTO;
                if (dto == null) return;

                SetEditMode(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn dòng Group:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateGroupInputByPart();

                AdminQuestionGroupDTO dto = ReadInputForCreate();
                int newId = _groupBLL.Create(dto);

                MessageBox.Show(
                    "Thêm Group thành công. ID mới = " + newId,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadGroupList();
                SelectRowByGroupId(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm Group thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateGroupInputByPart();

                AdminQuestionGroupDTO dto = ReadInputForUpdate();
                _groupBLL.Update(dto);

                MessageBox.Show(
                    "Cập nhật Group thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadGroupList();
                SelectRowByGroupId(dto.GroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cập nhật Group thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedGroupId <= 0)
                    throw new Exception("Bạn chưa chọn Group cần Vô hiêu hóa.");

                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn Vô hiêu hóa Group này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs != DialogResult.Yes)
                    return;

                _groupBLL.Deactivate(_selectedGroupId);

                MessageBox.Show(
                    "Vô hiêu hóa Group thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadGroupList();
                SetCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Vô hiêu hóa Group thất bại:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn chuyển sang chế độ nhập mới không? Dữ liệu hiện tại sẽ bị xóa.",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs != DialogResult.Yes)
                return;

            SetCreateMode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTestCombobox();
                LoadPartCombobox();
                LoadGroupList();
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

                List<AdminQuestionGroupDTO> filtered = _groupList;

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    filtered = _groupList.Where(x =>
                        x.GroupId.ToString().Contains(keyword) ||
                        x.TestId.ToString().Contains(keyword) ||
                        x.PartId.ToString().Contains(keyword) ||
                        x.OrderNo.ToString().Contains(keyword) ||
                        (x.GroupType ?? "").ToLower().Contains(keyword) ||
                        (x.AudioPath ?? "").ToLower().Contains(keyword) ||
                        (x.ImagePath ?? "").ToLower().Contains(keyword) ||
                        (x.PassageText ?? "").ToLower().Contains(keyword)
                    ).ToList();
                }

                dgvGroup.DataSource = null;
                dgvGroup.DataSource = filtered;
                lblTotal.Text = "Tổng số: " + filtered.Count;
            }
            catch
            {
            }
        }

        private void btnBrowseAudio_Click(object sender, EventArgs e)
        {
            try
            {
                int partId = GetSelectedPartId();
                if (partId < 1 || partId > 7)
                    throw new Exception("Bạn cần chọn Part trước khi chọn Audio.");

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn file Audio";
                    ofd.Filter = "Audio files|*.mp3;*.wav;*.wma";

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    ValidateMediaFileNameMatchPart(ofd.FileName, partId, "Audio");

                    string partFolder = GetPartFolder();
                    string relativePath = MediaStorageHelper.SaveAudioToAssets(ofd.FileName, partFolder);

                    txtAudioPath.Text = relativePath;

                    MessageBox.Show(
                        "Đã copy Audio vào Assets thành công.\nPath lưu DB: " + relativePath,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn Audio:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                int partId = GetSelectedPartId();
                if (partId < 1 || partId > 7)
                    throw new Exception("Bạn cần chọn Part trước khi chọn Image.");

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn file Image";
                    ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.webp";

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    ValidateMediaFileNameMatchPart(ofd.FileName, partId, "Image");

                    string partFolder = GetPartFolder();
                    string relativePath = MediaStorageHelper.SaveImageToAssets(ofd.FileName, partFolder);

                    txtImagePath.Text = relativePath;

                    MessageBox.Show(
                        "Đã copy Image vào Assets thành công.\nPath lưu DB: " + relativePath,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn Image:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Read Input

        private AdminQuestionGroupDTO ReadInputForCreate()
        {
            if (cboTestEdit.SelectedValue == null)
                throw new Exception("Bạn chưa chọn Test.");

            if (cboPartEdit.SelectedValue == null)
                throw new Exception("Bạn chưa chọn Part.");

            AdminQuestionGroupDTO dto = new AdminQuestionGroupDTO
            {
                TestId = Convert.ToInt32(cboTestEdit.SelectedValue),
                PartId = Convert.ToInt32(cboPartEdit.SelectedValue),
                GroupType = cboGroupType.Text.Trim(),
                AudioPath = NullIfEmpty(txtAudioPath.Text),
                ImagePath = NullIfEmpty(txtImagePath.Text),
                PassageText = NullIfEmpty(txtPassageText.Text),
                OrderNo = Convert.ToInt32(nudOrderNo.Value)
            };

            return dto;
        }

        private AdminQuestionGroupDTO ReadInputForUpdate()
        {
            if (_selectedGroupId <= 0)
                throw new Exception("Bạn chưa chọn Group để cập nhật.");

            if (cboTestEdit.SelectedValue == null)
                throw new Exception("Thiếu Test.");

            if (cboPartEdit.SelectedValue == null)
                throw new Exception("Thiếu Part.");

            AdminQuestionGroupDTO dto = new AdminQuestionGroupDTO
            {
                GroupId = _selectedGroupId,
                TestId = Convert.ToInt32(cboTestEdit.SelectedValue),
                PartId = Convert.ToInt32(cboPartEdit.SelectedValue),
                GroupType = cboGroupType.Text.Trim(),
                AudioPath = NullIfEmpty(txtAudioPath.Text),
                ImagePath = NullIfEmpty(txtImagePath.Text),
                PassageText = NullIfEmpty(txtPassageText.Text),
                OrderNo = Convert.ToInt32(nudOrderNo.Value),
                IsActive = chkIsActive.Checked
            };

            return dto;
        }

        private string NullIfEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        #endregion

        #region Helper

        private void SelectRowByGroupId(int groupId)
        {
            foreach (DataGridViewRow row in dgvGroup.Rows)
            {
                if (row.DataBoundItem is AdminQuestionGroupDTO dto && dto.GroupId == groupId)
                {
                    row.Selected = true;
                    dgvGroup.CurrentCell = row.Cells[0];
                    SetEditMode(dto);
                    return;
                }
            }
        }

        private class TestFilterItem
        {
            public int TestId { get; set; }
            public string DisplayText { get; set; }
        }

        private class PartItem
        {
            public int PartId { get; set; }
            public string PartName { get; set; }
        }

        #endregion

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}