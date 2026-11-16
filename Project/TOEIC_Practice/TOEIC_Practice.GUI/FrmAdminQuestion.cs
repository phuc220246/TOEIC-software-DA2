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
    public partial class FrmAdminQuestion : Form
    {
        private readonly AdminTestBLL _testBLL = new AdminTestBLL();
        private readonly AdminGroupBLL _groupBLL = new AdminGroupBLL();
        private readonly AdminQuestionBLL _questionBLL = new AdminQuestionBLL();
        private readonly AdminAnswerBLL _answerBLL = new AdminAnswerBLL();
        private readonly AdminQuestionOptionBLL _optionBLL = new AdminQuestionOptionBLL();

        private List<AdminTestDTO> _testList = new List<AdminTestDTO>();
        private List<AdminQuestionGroupDTO> _groupList = new List<AdminQuestionGroupDTO>();
        private List<AdminQuestionDTO> _questionList = new List<AdminQuestionDTO>();
        private List<AdminAnswerDTO> _answerList = new List<AdminAnswerDTO>();
        private List<AdminQuestionOptionDTO> _optionList = new List<AdminQuestionOptionDTO>();

        private int _selectedQuestionId = 0;
        private int _selectedAnswerId = 0;
        private int _currentPartId = 0;

        private bool _isLoading = false;

        public FrmAdminQuestion()
        {
            InitializeComponent();
        }

        private void FrmAdminQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                _isLoading = true;

                InitQuestionGrid();
                InitAnswerGrid();
                InitOptionGrid();

                LoadTestCombobox();
                LoadPartCombobox();
                LoadGroupCombobox();

                SetQuestionCreateMode();
                SetAnswerCreateMode();
                ClearOptionEditor();
                ApplyOptionUiByPart();

                LoadQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load form Admin Question:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }

        #region Init Grid

        private void InitQuestionGrid()
        {
            dgvQuestion.AutoGenerateColumns = false;
            dgvQuestion.Columns.Clear();
            dgvQuestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestion.MultiSelect = false;
            dgvQuestion.ReadOnly = true;
            dgvQuestion.AllowUserToAddRows = false;
            dgvQuestion.AllowUserToDeleteRows = false;
            dgvQuestion.RowHeadersVisible = false;
            dgvQuestion.BackgroundColor = System.Drawing.Color.White;

            dgvQuestion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuestionId",
                HeaderText = "ID",
                DataPropertyName = "QuestionId",
                Width = 60
            });

            dgvQuestion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOrderInGroup",
                HeaderText = "Order",
                DataPropertyName = "OrderInGroup",
                Width = 70
            });

            dgvQuestion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuestionText",
                HeaderText = "Question",
                DataPropertyName = "QuestionText",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvQuestion.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colQuestionIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 70
            });
        }

        private void InitAnswerGrid()
        {
            dgvAnswer.AutoGenerateColumns = false;
            dgvAnswer.Columns.Clear();
            dgvAnswer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnswer.MultiSelect = false;
            dgvAnswer.ReadOnly = true;
            dgvAnswer.AllowUserToAddRows = false;
            dgvAnswer.AllowUserToDeleteRows = false;
            dgvAnswer.RowHeadersVisible = false;
            dgvAnswer.BackgroundColor = System.Drawing.Color.White;

            dgvAnswer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAnswerId",
                HeaderText = "ID",
                DataPropertyName = "AnswerId",
                Width = 60
            });

            dgvAnswer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAnswerText",
                HeaderText = "Answer",
                DataPropertyName = "AnswerText",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAnswer.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsCorrect",
                HeaderText = "Correct",
                DataPropertyName = "IsCorrect",
                Width = 70
            });

            dgvAnswer.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colAnswerIsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 70
            });
        }

        private void InitOptionGrid()
        {
            dgvOption.AutoGenerateColumns = false;
            dgvOption.Columns.Clear();
            dgvOption.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOption.MultiSelect = false;
            dgvOption.ReadOnly = true;
            dgvOption.AllowUserToAddRows = false;
            dgvOption.AllowUserToDeleteRows = false;
            dgvOption.RowHeadersVisible = false;
            dgvOption.BackgroundColor = System.Drawing.Color.White;

            dgvOption.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOptionLabel",
                HeaderText = "Label",
                DataPropertyName = "OptionLabel",
                Width = 70
            });

            dgvOption.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOptionAnswerId",
                HeaderText = "AnswerId",
                DataPropertyName = "AnswerId",
                Width = 80
            });

            dgvOption.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOptionAnswerText",
                HeaderText = "Answer Text",
                DataPropertyName = "AnswerText",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvOption.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colOptionCorrect",
                HeaderText = "Correct",
                DataPropertyName = "IsCorrect",
                Width = 70
            });
        }

        #endregion

        #region Load Combobox

        private void LoadTestCombobox()
        {
            _testList = _testBLL.GetAll();

            var filterItems = new List<TestFilterItem>();
            filterItems.Add(new TestFilterItem
            {
                TestId = 0,
                DisplayText = "-- Chọn Test --"
            });

            foreach (var test in _testList)
            {
                filterItems.Add(new TestFilterItem
                {
                    TestId = test.TestId,
                    DisplayText = BuildTestDisplay(test)
                });
            }

            cboTestFilter.DataSource = null;
            cboTestFilter.DisplayMember = "DisplayText";
            cboTestFilter.ValueMember = "TestId";
            cboTestFilter.DataSource = filterItems;
        }

        private void LoadPartCombobox()
        {
            var parts = new List<PartItem>();
            parts.Add(new PartItem { PartId = 0, PartName = "-- Chọn Part --" });
            for (int i = 1; i <= 7; i++)
            {
                parts.Add(new PartItem { PartId = i, PartName = "Part " + i });
            }

            cboPartFilter.DataSource = null;
            cboPartFilter.DisplayMember = "PartName";
            cboPartFilter.ValueMember = "PartId";
            cboPartFilter.DataSource = parts;
        }

        private void LoadGroupCombobox()
        {
            int testId = GetSelectedTestId();
            int partId = GetSelectedPartId();

            cboGroupFilter.DataSource = null;
            _groupList = new List<AdminQuestionGroupDTO>();

            if (testId > 0 && partId > 0)
            {
                _groupList = _groupBLL.GetByTestPart(testId, partId);
            }

            var groupItems = new List<GroupFilterItem>();
            groupItems.Add(new GroupFilterItem
            {
                GroupId = 0,
                DisplayText = "-- Chọn Group --"
            });

            foreach (var g in _groupList)
            {
                groupItems.Add(new GroupFilterItem
                {
                    GroupId = g.GroupId,
                    DisplayText = BuildGroupDisplay(g)
                });
            }

            cboGroupFilter.DisplayMember = "DisplayText";
            cboGroupFilter.ValueMember = "GroupId";
            cboGroupFilter.DataSource = groupItems;
        }

        #endregion

        #region Load Data

        private void LoadQuestionList()
        {
            int groupId = GetSelectedGroupId();

            if (groupId <= 0)
            {
                _questionList = new List<AdminQuestionDTO>();
                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = _questionList;
                lblQuestionCount.Text = "Questions: 0";

                ClearQuestionInput();
                ClearAnswerSection();
                ClearOptionSection();
                return;
            }

            _questionList = _questionBLL.GetByGroup(groupId);

            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = _questionList;

            lblQuestionCount.Text = "Questions: " + _questionList.Count;

            ClearQuestionInput();
            ClearAnswerSection();
            ClearOptionSection();
        }

        private void LoadAnswerList(int questionId)
        {
            if (questionId <= 0)
            {
                _answerList = new List<AdminAnswerDTO>();
                dgvAnswer.DataSource = null;
                dgvAnswer.DataSource = _answerList;
                lblAnswerCount.Text = "Answers: 0";
                lblAnswerValidate.Text = "Answer Validate: -";
                return;
            }

            _answerList = _answerBLL.GetByQuestion(questionId) ?? new List<AdminAnswerDTO>();

            dgvAnswer.DataSource = null;
            dgvAnswer.DataSource = _answerList;

            lblAnswerCount.Text = "Answers: " + _answerList.Count;

            try
            {
                UpdateAnswerValidationLabel(questionId);
            }
            catch (Exception ex)
            {
                lblAnswerValidate.Text = "Answer Validate lỗi: " + ex.Message;
            }
        }

        private void LoadOptionList(int questionId)
        {
            if (questionId <= 0)
            {
                _optionList = new List<AdminQuestionOptionDTO>();
                dgvOption.DataSource = null;
                dgvOption.DataSource = _optionList;
                lblOptionValidate.Text = "Option Validate: -";
                return;
            }

            _optionList = _optionBLL.GetByQuestion(questionId) ?? new List<AdminQuestionOptionDTO>();

            dgvOption.DataSource = null;
            dgvOption.DataSource = _optionList;

            BindOptionCombos(questionId);
            SetSelectedOptionCombosByExistingOptions();

            try
            {
                UpdateOptionValidationLabel(questionId);
            }
            catch (Exception ex)
            {
                lblOptionValidate.Text = "Option Validate lỗi: " + ex.Message;
            }
        }

        #endregion

        #region Build Display

        private string BuildTestDisplay(AdminTestDTO test)
        {
            if (test.EtsYear > 0)
                return test.EtsYear + " - Test " + test.TestNo + " - " + (test.Title ?? "");

            return "Test " + test.TestNo + " - " + (test.Title ?? "");
        }

        private string BuildGroupDisplay(AdminQuestionGroupDTO group)
        {
            return "Group " + group.GroupId
                   + " | Part " + group.PartId
                   + " | Order " + group.OrderNo
                   + " | " + (group.GroupType ?? "");
        }

        #endregion

        #region Filter Getters

        private int GetSelectedTestId()
        {
            if (cboTestFilter.SelectedValue == null) return 0;

            int id;
            int.TryParse(cboTestFilter.SelectedValue.ToString(), out id);
            return id;
        }

        private int GetSelectedPartId()
        {
            if (cboPartFilter.SelectedValue == null) return 0;

            int id;
            int.TryParse(cboPartFilter.SelectedValue.ToString(), out id);
            return id;
        }

        private int GetSelectedGroupId()
        {
            if (cboGroupFilter.SelectedValue == null) return 0;

            int id;
            int.TryParse(cboGroupFilter.SelectedValue.ToString(), out id);
            return id;
        }

        #endregion

        #region Question CRUD

        private void SetQuestionCreateMode()
        {
            _selectedQuestionId = 0;

            txtQuestionText.Clear();
            txtExplanation.Clear();
            nudQuestionOrder.Value = 1;
            chkQuestionIsActive.Checked = true;

            btnQuestionAdd.Enabled = true;
            btnQuestionUpdate.Enabled = false;
            btnQuestionDeactivate.Enabled = false;

            lblQuestionMode.Text = "Question Mode: Thêm mới";
        }

        private void SetQuestionEditMode(AdminQuestionDTO dto)
        {
            if (dto == null) return;

            _selectedQuestionId = dto.QuestionId;

            _currentPartId = dto.PartId > 0 ? dto.PartId : GetSelectedPartId();

            txtQuestionText.Text = dto.QuestionText;
            txtExplanation.Text = dto.Explanation;

            if (dto.OrderInGroup >= nudQuestionOrder.Minimum && dto.OrderInGroup <= nudQuestionOrder.Maximum)
                nudQuestionOrder.Value = dto.OrderInGroup;
            else
                nudQuestionOrder.Value = 1;

            chkQuestionIsActive.Checked = dto.IsActive;

            btnQuestionAdd.Enabled = false;
            btnQuestionUpdate.Enabled = true;
            btnQuestionDeactivate.Enabled = true;

            lblQuestionMode.Text = "Question Mode: Cập nhật";
        }

        private void ClearQuestionInput()
        {
            SetQuestionCreateMode();
        }

        private AdminQuestionDTO ReadQuestionForCreate()
        {
            int groupId = GetSelectedGroupId();
            int partId = GetSelectedPartId();

            if (groupId <= 0)
                throw new Exception("Bạn chưa chọn Group.");

            return new AdminQuestionDTO
            {
                GroupId = groupId,
                PartId = partId,
                QuestionText = NullIfEmpty(txtQuestionText.Text),
                Explanation = NullIfEmpty(txtExplanation.Text),
                OrderInGroup = Convert.ToInt32(nudQuestionOrder.Value)
            };
        }

        private AdminQuestionDTO ReadQuestionForUpdate()
        {
            int groupId = GetSelectedGroupId();
            int partId = GetSelectedPartId();

            if (_selectedQuestionId <= 0)
                throw new Exception("Bạn chưa chọn Question.");

            return new AdminQuestionDTO
            {
                QuestionId = _selectedQuestionId,
                GroupId = groupId,
                PartId = partId,
                QuestionText = NullIfEmpty(txtQuestionText.Text),
                Explanation = NullIfEmpty(txtExplanation.Text),
                OrderInGroup = Convert.ToInt32(nudQuestionOrder.Value),
                IsActive = chkQuestionIsActive.Checked
            };
        }

        #endregion

        #region Answer CRUD

        private void SetAnswerCreateMode()
        {
            _selectedAnswerId = 0;

            txtAnswerText.Clear();
            chkIsCorrect.Checked = false;
            chkAnswerIsActive.Checked = true;

            btnAnswerAdd.Enabled = true;
            btnAnswerUpdate.Enabled = false;
            btnAnswerDeactivate.Enabled = false;

            lblAnswerMode.Text = "Answer Mode: Thêm mới";
        }

        private void SetAnswerEditMode(AdminAnswerDTO dto)
        {
            if (dto == null) return;

            _selectedAnswerId = dto.AnswerId;

            txtAnswerText.Text = dto.AnswerText;
            chkIsCorrect.Checked = dto.IsCorrect;
            chkAnswerIsActive.Checked = dto.IsActive;

            btnAnswerAdd.Enabled = false;
            btnAnswerUpdate.Enabled = true;
            btnAnswerDeactivate.Enabled = true;

            lblAnswerMode.Text = "Answer Mode: Cập nhật";
        }

        private void ClearAnswerInput()
        {
            SetAnswerCreateMode();
        }

        private AdminAnswerDTO ReadAnswerForCreate()
        {
            if (_selectedQuestionId <= 0)
                throw new Exception("Bạn chưa chọn Question.");

            return new AdminAnswerDTO
            {
                QuestionId = _selectedQuestionId,
                AnswerText = NullIfEmpty(txtAnswerText.Text),
                IsCorrect = chkIsCorrect.Checked
            };
        }

        private AdminAnswerDTO ReadAnswerForUpdate()
        {
            if (_selectedAnswerId <= 0)
                throw new Exception("Bạn chưa chọn Answer.");

            return new AdminAnswerDTO
            {
                AnswerId = _selectedAnswerId,
                QuestionId = _selectedQuestionId,
                AnswerText = NullIfEmpty(txtAnswerText.Text),
                IsCorrect = chkIsCorrect.Checked,
                IsActive = chkAnswerIsActive.Checked
            };
        }

        #endregion

        #region Option Editor

        private void BindOptionCombos(int questionId)
        {
            List<AdminAnswerDTO> activeAnswers = _answerBLL.GetByQuestion(questionId)
                .Where(x => x.IsActive)
                .ToList();

            BindAnswerCombo(cboOptionA, activeAnswers);
            BindAnswerCombo(cboOptionB, activeAnswers);
            BindAnswerCombo(cboOptionC, activeAnswers);
            BindAnswerCombo(cboOptionD, activeAnswers);
        }

        private void BindAnswerCombo(ComboBox cbo, List<AdminAnswerDTO> answers)
        {
            cbo.DataSource = null;
            cbo.DisplayMember = "AnswerText";
            cbo.ValueMember = "AnswerId";
            cbo.DataSource = answers.ToList();
        }

        private void SetSelectedOptionCombosByExistingOptions()
        {
            SetComboValueByLabel("A", cboOptionA);
            SetComboValueByLabel("B", cboOptionB);
            SetComboValueByLabel("C", cboOptionC);
            SetComboValueByLabel("D", cboOptionD);
        }

        private void SetComboValueByLabel(string label, ComboBox cbo)
        {
            var item = _optionList.FirstOrDefault(x => string.Equals(x.OptionLabel, label, StringComparison.OrdinalIgnoreCase));
            if (item != null)
                cbo.SelectedValue = item.AnswerId;
            else
                cbo.SelectedIndex = cbo.Items.Count > 0 ? 0 : -1;
        }

        private void ClearOptionEditor()
        {
            cboOptionA.DataSource = null;
            cboOptionB.DataSource = null;
            cboOptionC.DataSource = null;
            cboOptionD.DataSource = null;

            lblOptionValidate.Text = "Option Validate: -";
        }

        private void ApplyOptionUiByPart()
        {
            bool isPart2 = _currentPartId == 2;

            lblOptionD.Visible = !isPart2;
            cboOptionD.Visible = !isPart2;

            if (isPart2)
            {
                cboOptionD.DataSource = null;
            }
        }

        private AdminQuestionOptionBatchDTO ReadOptionBatch()
        {
            if (_selectedQuestionId <= 0)
                throw new Exception("Bạn chưa chọn Question.");

            if (cboOptionA.SelectedValue == null || cboOptionB.SelectedValue == null || cboOptionC.SelectedValue == null)
                throw new Exception("Bạn phải chọn đủ A, B, C.");

            return new AdminQuestionOptionBatchDTO
            {
                QuestionId = _selectedQuestionId,
                AnswerId_A = Convert.ToInt32(cboOptionA.SelectedValue),
                AnswerId_B = Convert.ToInt32(cboOptionB.SelectedValue),
                AnswerId_C = Convert.ToInt32(cboOptionC.SelectedValue),
                AnswerId_D = _currentPartId == 2
                    ? (int?)null
                    : (cboOptionD.SelectedValue == null ? (int?)null : Convert.ToInt32(cboOptionD.SelectedValue))
            };
        }

        #endregion

        #region Validation Labels

        private void UpdateAnswerValidationLabel(int questionId)
        {
            ValidationResultDTO vr = _answerBLL.ValidateByQuestion(questionId);

            if (vr == null)
            {
                lblAnswerValidate.Text = "Answer Validate: -";
                return;
            }

            lblAnswerValidate.Text = "Answer Validate: " + vr.Message;
        }

        private void UpdateOptionValidationLabel(int questionId)
        {
            ValidationResultDTO vr = _optionBLL.ValidateByQuestion(questionId);

            if (vr == null)
            {
                lblOptionValidate.Text = "Option Validate: -";
                return;
            }

            lblOptionValidate.Text = "Option Validate: " + vr.Message;
        }

        #endregion

        #region Clear Sections

        private void ClearAnswerSection()
        {
            _selectedAnswerId = 0;
            _answerList = new List<AdminAnswerDTO>();

            dgvAnswer.DataSource = null;
            dgvAnswer.DataSource = _answerList;

            lblAnswerCount.Text = "Answers: 0";
            lblAnswerValidate.Text = "Answer Validate: -";

            ClearAnswerInput();
        }

        private void ClearOptionSection()
        {
            _optionList = new List<AdminQuestionOptionDTO>();

            dgvOption.DataSource = null;
            dgvOption.DataSource = _optionList;

            ClearOptionEditor();
            ApplyOptionUiByPart();
        }

        #endregion

        #region Events - Filter

        private void cboTestFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadGroupCombobox();
                LoadQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc Test:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPartFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadGroupCombobox();
                LoadQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc Part:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboGroupFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            try
            {
                LoadQuestionList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc Group:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events - Question

        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                AdminQuestionDTO dto = dgvQuestion.Rows[e.RowIndex].DataBoundItem as AdminQuestionDTO;
                if (dto == null) return;

                SetQuestionEditMode(dto);

                LoadAnswerList(dto.QuestionId);
                LoadOptionList(dto.QuestionId);
                ApplyOptionUiByPart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn Question:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuestionNew_Click(object sender, EventArgs e)
        {
            SetQuestionCreateMode();
            ClearAnswerSection();
            ClearOptionSection();
        }

        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AdminQuestionDTO dto = ReadQuestionForCreate();
                int newId = _questionBLL.Create(dto);

                MessageBox.Show("Thêm Question thành công. ID mới = " + newId,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadQuestionList();
                SelectQuestionRow(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Question thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuestionUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AdminQuestionDTO dto = ReadQuestionForUpdate();
                _questionBLL.Update(dto);

                MessageBox.Show("Cập nhật Question thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadQuestionList();
                SelectQuestionRow(dto.QuestionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật Question thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuestionDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedQuestionId <= 0)
                    throw new Exception("Bạn chưa chọn Question.");

                if (MessageBox.Show(
                        "Bạn có chắc muốn deactivate Question này không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _questionBLL.Deactivate(_selectedQuestionId);

                MessageBox.Show("Deactivate Question thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadQuestionList();
                ClearAnswerSection();
                ClearOptionSection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deactivate Question thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events - Answer

        private void dgvAnswer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                AdminAnswerDTO dto = dgvAnswer.Rows[e.RowIndex].DataBoundItem as AdminAnswerDTO;
                if (dto == null) return;

                SetAnswerEditMode(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn Answer:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnswerNew_Click(object sender, EventArgs e)
        {
            SetAnswerCreateMode();
        }

        private void btnAnswerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAnswerDTO dto = ReadAnswerForCreate();
                int newId = _answerBLL.Create(dto);

                MessageBox.Show("Thêm Answer thành công. ID mới = " + newId,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAnswerList(_selectedQuestionId);
                LoadOptionList(_selectedQuestionId);
                SelectAnswerRow(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Answer thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnswerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAnswerDTO dto = ReadAnswerForUpdate();
                _answerBLL.Update(dto);

                MessageBox.Show("Cập nhật Answer thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAnswerList(_selectedQuestionId);
                LoadOptionList(_selectedQuestionId);
                SelectAnswerRow(dto.AnswerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật Answer thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnswerDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAnswerId <= 0)
                    throw new Exception("Bạn chưa chọn Answer.");

                if (MessageBox.Show(
                        "Bạn có chắc muốn deactivate Answer này không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _answerBLL.Deactivate(_selectedAnswerId);

                MessageBox.Show("Deactivate Answer thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAnswerList(_selectedQuestionId);
                LoadOptionList(_selectedQuestionId);
                SetAnswerCreateMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deactivate Answer thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events - Option

        private void btnOptionSave_Click(object sender, EventArgs e)
        {
            try
            {
                AdminQuestionOptionBatchDTO dto = ReadOptionBatch();
                _optionBLL.SaveBatch(dto);

                MessageBox.Show("Lưu QuestionOption thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOptionList(_selectedQuestionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu QuestionOption thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helpers

        private void SelectQuestionRow(int questionId)
        {
            foreach (DataGridViewRow row in dgvQuestion.Rows)
            {
                if (row.DataBoundItem is AdminQuestionDTO dto && dto.QuestionId == questionId)
                {
                    row.Selected = true;
                    dgvQuestion.CurrentCell = row.Cells[0];
                    SetQuestionEditMode(dto);
                    LoadAnswerList(dto.QuestionId);
                    LoadOptionList(dto.QuestionId);
                    ApplyOptionUiByPart();
                    return;
                }
            }
        }

        private void SelectAnswerRow(int answerId)
        {
            foreach (DataGridViewRow row in dgvAnswer.Rows)
            {
                if (row.DataBoundItem is AdminAnswerDTO dto && dto.AnswerId == answerId)
                {
                    row.Selected = true;
                    dgvAnswer.CurrentCell = row.Cells[0];
                    SetAnswerEditMode(dto);
                    return;
                }
            }
        }

        private string NullIfEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        #endregion

        #region Inner DTO for Filter

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

        private class GroupFilterItem
        {
            public int GroupId { get; set; }
            public string DisplayText { get; set; }
        }

        #endregion
    }
}