namespace TOEIC_Practice.GUI.Admin
{
    partial class FrmAdminQuestion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTestFilter;
        private System.Windows.Forms.ComboBox cboTestFilter;
        private System.Windows.Forms.Label lblPartFilter;
        private System.Windows.Forms.ComboBox cboPartFilter;
        private System.Windows.Forms.Label lblGroupFilter;
        private System.Windows.Forms.ComboBox cboGroupFilter;

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitRight;

        private System.Windows.Forms.GroupBox grpQuestionList;
        private System.Windows.Forms.DataGridView dgvQuestion;
        private System.Windows.Forms.Label lblQuestionCount;

        private System.Windows.Forms.GroupBox grpQuestionEditor;
        private System.Windows.Forms.Label lblQuestionMode;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label lblQuestionOrder;
        private System.Windows.Forms.NumericUpDown nudQuestionOrder;
        private System.Windows.Forms.Label lblQuestionIsActive;
        private System.Windows.Forms.CheckBox chkQuestionIsActive;
        private System.Windows.Forms.Button btnQuestionNew;
        private System.Windows.Forms.Button btnQuestionAdd;
        private System.Windows.Forms.Button btnQuestionUpdate;
        private System.Windows.Forms.Button btnQuestionDeactivate;

        private System.Windows.Forms.GroupBox grpAnswerEditor;
        private System.Windows.Forms.DataGridView dgvAnswer;
        private System.Windows.Forms.Label lblAnswerCount;
        private System.Windows.Forms.Label lblAnswerMode;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.TextBox txtAnswerText;
        private System.Windows.Forms.Label lblIsCorrect;
        private System.Windows.Forms.CheckBox chkIsCorrect;
        private System.Windows.Forms.Label lblAnswerIsActive;
        private System.Windows.Forms.CheckBox chkAnswerIsActive;
        private System.Windows.Forms.Button btnAnswerNew;
        private System.Windows.Forms.Button btnAnswerAdd;
        private System.Windows.Forms.Button btnAnswerUpdate;
        private System.Windows.Forms.Button btnAnswerDeactivate;
        private System.Windows.Forms.Label lblAnswerValidate;

        private System.Windows.Forms.GroupBox grpOptionEditor;
        private System.Windows.Forms.DataGridView dgvOption;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.ComboBox cboOptionA;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.ComboBox cboOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.ComboBox cboOptionC;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.ComboBox cboOptionD;
        private System.Windows.Forms.Button btnOptionSave;
        private System.Windows.Forms.Label lblOptionValidate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTestFilter = new System.Windows.Forms.Label();
            this.cboTestFilter = new System.Windows.Forms.ComboBox();
            this.lblPartFilter = new System.Windows.Forms.Label();
            this.cboPartFilter = new System.Windows.Forms.ComboBox();
            this.lblGroupFilter = new System.Windows.Forms.Label();
            this.cboGroupFilter = new System.Windows.Forms.ComboBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.grpQuestionList = new System.Windows.Forms.GroupBox();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.dgvQuestion = new System.Windows.Forms.DataGridView();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.grpQuestionEditor = new System.Windows.Forms.GroupBox();
            this.lblQuestionMode = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.lblQuestionOrder = new System.Windows.Forms.Label();
            this.nudQuestionOrder = new System.Windows.Forms.NumericUpDown();
            this.lblQuestionIsActive = new System.Windows.Forms.Label();
            this.chkQuestionIsActive = new System.Windows.Forms.CheckBox();
            this.btnQuestionNew = new System.Windows.Forms.Button();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.btnQuestionUpdate = new System.Windows.Forms.Button();
            this.btnQuestionDeactivate = new System.Windows.Forms.Button();
            this.grpOptionEditor = new System.Windows.Forms.GroupBox();
            this.lblOptionValidate = new System.Windows.Forms.Label();
            this.btnOptionSave = new System.Windows.Forms.Button();
            this.cboOptionD = new System.Windows.Forms.ComboBox();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.cboOptionC = new System.Windows.Forms.ComboBox();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.cboOptionB = new System.Windows.Forms.ComboBox();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.cboOptionA = new System.Windows.Forms.ComboBox();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.dgvOption = new System.Windows.Forms.DataGridView();
            this.grpAnswerEditor = new System.Windows.Forms.GroupBox();
            this.lblAnswerValidate = new System.Windows.Forms.Label();
            this.btnAnswerDeactivate = new System.Windows.Forms.Button();
            this.btnAnswerUpdate = new System.Windows.Forms.Button();
            this.btnAnswerAdd = new System.Windows.Forms.Button();
            this.btnAnswerNew = new System.Windows.Forms.Button();
            this.chkAnswerIsActive = new System.Windows.Forms.CheckBox();
            this.lblAnswerIsActive = new System.Windows.Forms.Label();
            this.chkIsCorrect = new System.Windows.Forms.CheckBox();
            this.lblIsCorrect = new System.Windows.Forms.Label();
            this.txtAnswerText = new System.Windows.Forms.TextBox();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblAnswerMode = new System.Windows.Forms.Label();
            this.lblAnswerCount = new System.Windows.Forms.Label();
            this.dgvAnswer = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpQuestionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.grpQuestionEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestionOrder)).BeginInit();
            this.grpOptionEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).BeginInit();
            this.grpAnswerEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTestFilter);
            this.pnlTop.Controls.Add(this.cboTestFilter);
            this.pnlTop.Controls.Add(this.lblPartFilter);
            this.pnlTop.Controls.Add(this.cboPartFilter);
            this.pnlTop.Controls.Add(this.lblGroupFilter);
            this.pnlTop.Controls.Add(this.cboGroupFilter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1316, 53);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTestFilter
            // 
            this.lblTestFilter.AutoSize = true;
            this.lblTestFilter.Location = new System.Drawing.Point(14, 18);
            this.lblTestFilter.Name = "lblTestFilter";
            this.lblTestFilter.Size = new System.Drawing.Size(34, 16);
            this.lblTestFilter.TabIndex = 0;
            this.lblTestFilter.Text = "Test";
            // 
            // cboTestFilter
            // 
            this.cboTestFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestFilter.FormattingEnabled = true;
            this.cboTestFilter.Location = new System.Drawing.Point(51, 15);
            this.cboTestFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTestFilter.Name = "cboTestFilter";
            this.cboTestFilter.Size = new System.Drawing.Size(249, 24);
            this.cboTestFilter.TabIndex = 1;
            this.cboTestFilter.SelectedIndexChanged += new System.EventHandler(this.cboTestFilter_SelectedIndexChanged);
            // 
            // lblPartFilter
            // 
            this.lblPartFilter.AutoSize = true;
            this.lblPartFilter.Location = new System.Drawing.Point(316, 18);
            this.lblPartFilter.Name = "lblPartFilter";
            this.lblPartFilter.Size = new System.Drawing.Size(31, 16);
            this.lblPartFilter.TabIndex = 2;
            this.lblPartFilter.Text = "Part";
            // 
            // cboPartFilter
            // 
            this.cboPartFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartFilter.FormattingEnabled = true;
            this.cboPartFilter.Location = new System.Drawing.Point(352, 15);
            this.cboPartFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPartFilter.Name = "cboPartFilter";
            this.cboPartFilter.Size = new System.Drawing.Size(143, 24);
            this.cboPartFilter.TabIndex = 3;
            this.cboPartFilter.SelectedIndexChanged += new System.EventHandler(this.cboPartFilter_SelectedIndexChanged);
            // 
            // lblGroupFilter
            // 
            this.lblGroupFilter.AutoSize = true;
            this.lblGroupFilter.Location = new System.Drawing.Point(514, 18);
            this.lblGroupFilter.Name = "lblGroupFilter";
            this.lblGroupFilter.Size = new System.Drawing.Size(44, 16);
            this.lblGroupFilter.TabIndex = 4;
            this.lblGroupFilter.Text = "Group";
            // 
            // cboGroupFilter
            // 
            this.cboGroupFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupFilter.FormattingEnabled = true;
            this.cboGroupFilter.Location = new System.Drawing.Point(563, 15);
            this.cboGroupFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGroupFilter.Name = "cboGroupFilter";
            this.cboGroupFilter.Size = new System.Drawing.Size(303, 24);
            this.cboGroupFilter.TabIndex = 5;
            this.cboGroupFilter.SelectedIndexChanged += new System.EventHandler(this.cboGroupFilter_SelectedIndexChanged);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 53);
            this.splitMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.grpQuestionList);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(1316, 651);
            this.splitMain.SplitterDistance = 462;
            this.splitMain.TabIndex = 1;
            // 
            // grpQuestionList
            // 
            this.grpQuestionList.Controls.Add(this.lblQuestionCount);
            this.grpQuestionList.Controls.Add(this.dgvQuestion);
            this.grpQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQuestionList.Location = new System.Drawing.Point(0, 0);
            this.grpQuestionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuestionList.Name = "grpQuestionList";
            this.grpQuestionList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuestionList.Size = new System.Drawing.Size(462, 651);
            this.grpQuestionList.TabIndex = 0;
            this.grpQuestionList.TabStop = false;
            this.grpQuestionList.Text = "Danh sách Question";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestionCount.Location = new System.Drawing.Point(3, 17);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Padding = new System.Windows.Forms.Padding(7, 5, 0, 5);
            this.lblQuestionCount.Size = new System.Drawing.Size(456, 27);
            this.lblQuestionCount.TabIndex = 1;
            this.lblQuestionCount.Text = "Questions: 0";
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestion.Location = new System.Drawing.Point(3, 17);
            this.dgvQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.RowHeadersWidth = 62;
            this.dgvQuestion.RowTemplate.Height = 28;
            this.dgvQuestion.Size = new System.Drawing.Size(456, 632);
            this.dgvQuestion.TabIndex = 0;
            this.dgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellClick);
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.grpQuestionEditor);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.grpOptionEditor);
            this.splitRight.Panel2.Controls.Add(this.grpAnswerEditor);
            this.splitRight.Size = new System.Drawing.Size(850, 651);
            this.splitRight.SplitterDistance = 219;
            this.splitRight.SplitterWidth = 3;
            this.splitRight.TabIndex = 0;
            // 
            // grpQuestionEditor
            // 
            this.grpQuestionEditor.Controls.Add(this.lblQuestionMode);
            this.grpQuestionEditor.Controls.Add(this.lblQuestionText);
            this.grpQuestionEditor.Controls.Add(this.txtQuestionText);
            this.grpQuestionEditor.Controls.Add(this.lblExplanation);
            this.grpQuestionEditor.Controls.Add(this.txtExplanation);
            this.grpQuestionEditor.Controls.Add(this.lblQuestionOrder);
            this.grpQuestionEditor.Controls.Add(this.nudQuestionOrder);
            this.grpQuestionEditor.Controls.Add(this.lblQuestionIsActive);
            this.grpQuestionEditor.Controls.Add(this.chkQuestionIsActive);
            this.grpQuestionEditor.Controls.Add(this.btnQuestionNew);
            this.grpQuestionEditor.Controls.Add(this.btnQuestionAdd);
            this.grpQuestionEditor.Controls.Add(this.btnQuestionUpdate);
            this.grpQuestionEditor.Controls.Add(this.btnQuestionDeactivate);
            this.grpQuestionEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQuestionEditor.Location = new System.Drawing.Point(0, 0);
            this.grpQuestionEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuestionEditor.Name = "grpQuestionEditor";
            this.grpQuestionEditor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuestionEditor.Size = new System.Drawing.Size(850, 219);
            this.grpQuestionEditor.TabIndex = 0;
            this.grpQuestionEditor.TabStop = false;
            this.grpQuestionEditor.Text = "Question Editor";
            // 
            // lblQuestionMode
            // 
            this.lblQuestionMode.AutoSize = true;
            this.lblQuestionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestionMode.Location = new System.Drawing.Point(16, 25);
            this.lblQuestionMode.Name = "lblQuestionMode";
            this.lblQuestionMode.Size = new System.Drawing.Size(139, 18);
            this.lblQuestionMode.TabIndex = 0;
            this.lblQuestionMode.Text = "Question Mode: -";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(16, 58);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(60, 16);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Question";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(100, 55);
            this.txtQuestionText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionText.Size = new System.Drawing.Size(413, 53);
            this.txtQuestionText.TabIndex = 2;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(16, 121);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(77, 16);
            this.lblExplanation.TabIndex = 3;
            this.lblExplanation.Text = "Explanation";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(100, 118);
            this.txtExplanation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplanation.Size = new System.Drawing.Size(587, 49);
            this.txtExplanation.TabIndex = 4;
            // 
            // lblQuestionOrder
            // 
            this.lblQuestionOrder.AutoSize = true;
            this.lblQuestionOrder.Location = new System.Drawing.Point(535, 58);
            this.lblQuestionOrder.Name = "lblQuestionOrder";
            this.lblQuestionOrder.Size = new System.Drawing.Size(41, 16);
            this.lblQuestionOrder.TabIndex = 5;
            this.lblQuestionOrder.Text = "Order";
            // 
            // nudQuestionOrder
            // 
            this.nudQuestionOrder.Location = new System.Drawing.Point(595, 58);
            this.nudQuestionOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuestionOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQuestionOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuestionOrder.Name = "nudQuestionOrder";
            this.nudQuestionOrder.Size = new System.Drawing.Size(92, 22);
            this.nudQuestionOrder.TabIndex = 6;
            this.nudQuestionOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuestionIsActive
            // 
            this.lblQuestionIsActive.AutoSize = true;
            this.lblQuestionIsActive.Location = new System.Drawing.Point(535, 92);
            this.lblQuestionIsActive.Name = "lblQuestionIsActive";
            this.lblQuestionIsActive.Size = new System.Drawing.Size(54, 16);
            this.lblQuestionIsActive.TabIndex = 7;
            this.lblQuestionIsActive.Text = "IsActive";
            // 
            // chkQuestionIsActive
            // 
            this.chkQuestionIsActive.AutoSize = true;
            this.chkQuestionIsActive.Location = new System.Drawing.Point(618, 93);
            this.chkQuestionIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkQuestionIsActive.Name = "chkQuestionIsActive";
            this.chkQuestionIsActive.Size = new System.Drawing.Size(18, 17);
            this.chkQuestionIsActive.TabIndex = 8;
            this.chkQuestionIsActive.UseVisualStyleBackColor = true;
            // 
            // btnQuestionNew
            // 
            this.btnQuestionNew.Location = new System.Drawing.Point(100, 181);
            this.btnQuestionNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuestionNew.Name = "btnQuestionNew";
            this.btnQuestionNew.Size = new System.Drawing.Size(89, 29);
            this.btnQuestionNew.TabIndex = 9;
            this.btnQuestionNew.Text = "Nhập mới";
            this.btnQuestionNew.UseVisualStyleBackColor = true;
            this.btnQuestionNew.Click += new System.EventHandler(this.btnQuestionNew_Click);
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Location = new System.Drawing.Point(203, 181);
            this.btnQuestionAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(89, 29);
            this.btnQuestionAdd.TabIndex = 10;
            this.btnQuestionAdd.Text = "Thêm";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // btnQuestionUpdate
            // 
            this.btnQuestionUpdate.Location = new System.Drawing.Point(306, 181);
            this.btnQuestionUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuestionUpdate.Name = "btnQuestionUpdate";
            this.btnQuestionUpdate.Size = new System.Drawing.Size(89, 29);
            this.btnQuestionUpdate.TabIndex = 11;
            this.btnQuestionUpdate.Text = "Cập nhật";
            this.btnQuestionUpdate.UseVisualStyleBackColor = true;
            this.btnQuestionUpdate.Click += new System.EventHandler(this.btnQuestionUpdate_Click);
            // 
            // btnQuestionDeactivate
            // 
            this.btnQuestionDeactivate.Location = new System.Drawing.Point(409, 181);
            this.btnQuestionDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuestionDeactivate.Name = "btnQuestionDeactivate";
            this.btnQuestionDeactivate.Size = new System.Drawing.Size(98, 29);
            this.btnQuestionDeactivate.TabIndex = 12;
            this.btnQuestionDeactivate.Text = "Vô hiệu hóa";
            this.btnQuestionDeactivate.UseVisualStyleBackColor = true;
            this.btnQuestionDeactivate.Click += new System.EventHandler(this.btnQuestionDeactivate_Click);
            // 
            // grpOptionEditor
            // 
            this.grpOptionEditor.Controls.Add(this.lblOptionValidate);
            this.grpOptionEditor.Controls.Add(this.btnOptionSave);
            this.grpOptionEditor.Controls.Add(this.cboOptionD);
            this.grpOptionEditor.Controls.Add(this.lblOptionD);
            this.grpOptionEditor.Controls.Add(this.cboOptionC);
            this.grpOptionEditor.Controls.Add(this.lblOptionC);
            this.grpOptionEditor.Controls.Add(this.cboOptionB);
            this.grpOptionEditor.Controls.Add(this.lblOptionB);
            this.grpOptionEditor.Controls.Add(this.cboOptionA);
            this.grpOptionEditor.Controls.Add(this.lblOptionA);
            this.grpOptionEditor.Controls.Add(this.dgvOption);
            this.grpOptionEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptionEditor.Location = new System.Drawing.Point(462, 0);
            this.grpOptionEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOptionEditor.Name = "grpOptionEditor";
            this.grpOptionEditor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOptionEditor.Size = new System.Drawing.Size(388, 429);
            this.grpOptionEditor.TabIndex = 1;
            this.grpOptionEditor.TabStop = false;
            this.grpOptionEditor.Text = "QuestionOption Editor";
            // 
            // lblOptionValidate
            // 
            this.lblOptionValidate.AutoSize = true;
            this.lblOptionValidate.Location = new System.Drawing.Point(15, 403);
            this.lblOptionValidate.Name = "lblOptionValidate";
            this.lblOptionValidate.Size = new System.Drawing.Size(109, 16);
            this.lblOptionValidate.TabIndex = 10;
            this.lblOptionValidate.Text = "Option Validate: -";
            // 
            // btnOptionSave
            // 
            this.btnOptionSave.Location = new System.Drawing.Point(270, 368);
            this.btnOptionSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOptionSave.Name = "btnOptionSave";
            this.btnOptionSave.Size = new System.Drawing.Size(100, 29);
            this.btnOptionSave.TabIndex = 9;
            this.btnOptionSave.Text = "SaveBatch";
            this.btnOptionSave.UseVisualStyleBackColor = true;
            this.btnOptionSave.Click += new System.EventHandler(this.btnOptionSave_Click);
            // 
            // cboOptionD
            // 
            this.cboOptionD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptionD.FormattingEnabled = true;
            this.cboOptionD.Location = new System.Drawing.Point(56, 370);
            this.cboOptionD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOptionD.Name = "cboOptionD";
            this.cboOptionD.Size = new System.Drawing.Size(200, 24);
            this.cboOptionD.TabIndex = 8;
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Location = new System.Drawing.Point(15, 373);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(17, 16);
            this.lblOptionD.TabIndex = 7;
            this.lblOptionD.Text = "D";
            // 
            // cboOptionC
            // 
            this.cboOptionC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptionC.FormattingEnabled = true;
            this.cboOptionC.Location = new System.Drawing.Point(56, 340);
            this.cboOptionC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOptionC.Name = "cboOptionC";
            this.cboOptionC.Size = new System.Drawing.Size(200, 24);
            this.cboOptionC.TabIndex = 6;
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(15, 342);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(16, 16);
            this.lblOptionC.TabIndex = 5;
            this.lblOptionC.Text = "C";
            // 
            // cboOptionB
            // 
            this.cboOptionB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptionB.FormattingEnabled = true;
            this.cboOptionB.Location = new System.Drawing.Point(56, 310);
            this.cboOptionB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOptionB.Name = "cboOptionB";
            this.cboOptionB.Size = new System.Drawing.Size(200, 24);
            this.cboOptionB.TabIndex = 4;
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(15, 312);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(16, 16);
            this.lblOptionB.TabIndex = 3;
            this.lblOptionB.Text = "B";
            // 
            // cboOptionA
            // 
            this.cboOptionA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptionA.FormattingEnabled = true;
            this.cboOptionA.Location = new System.Drawing.Point(56, 279);
            this.cboOptionA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOptionA.Name = "cboOptionA";
            this.cboOptionA.Size = new System.Drawing.Size(200, 24);
            this.cboOptionA.TabIndex = 2;
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(15, 282);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(16, 16);
            this.lblOptionA.TabIndex = 1;
            this.lblOptionA.Text = "A";
            // 
            // dgvOption
            // 
            this.dgvOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOption.Location = new System.Drawing.Point(19, 25);
            this.dgvOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOption.Name = "dgvOption";
            this.dgvOption.RowHeadersWidth = 62;
            this.dgvOption.RowTemplate.Height = 28;
            this.dgvOption.Size = new System.Drawing.Size(351, 240);
            this.dgvOption.TabIndex = 0;
            // 
            // grpAnswerEditor
            // 
            this.grpAnswerEditor.Controls.Add(this.lblAnswerValidate);
            this.grpAnswerEditor.Controls.Add(this.btnAnswerDeactivate);
            this.grpAnswerEditor.Controls.Add(this.btnAnswerUpdate);
            this.grpAnswerEditor.Controls.Add(this.btnAnswerAdd);
            this.grpAnswerEditor.Controls.Add(this.btnAnswerNew);
            this.grpAnswerEditor.Controls.Add(this.chkAnswerIsActive);
            this.grpAnswerEditor.Controls.Add(this.lblAnswerIsActive);
            this.grpAnswerEditor.Controls.Add(this.chkIsCorrect);
            this.grpAnswerEditor.Controls.Add(this.lblIsCorrect);
            this.grpAnswerEditor.Controls.Add(this.txtAnswerText);
            this.grpAnswerEditor.Controls.Add(this.lblAnswerText);
            this.grpAnswerEditor.Controls.Add(this.lblAnswerMode);
            this.grpAnswerEditor.Controls.Add(this.lblAnswerCount);
            this.grpAnswerEditor.Controls.Add(this.dgvAnswer);
            this.grpAnswerEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAnswerEditor.Location = new System.Drawing.Point(0, 0);
            this.grpAnswerEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswerEditor.Name = "grpAnswerEditor";
            this.grpAnswerEditor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswerEditor.Size = new System.Drawing.Size(462, 429);
            this.grpAnswerEditor.TabIndex = 0;
            this.grpAnswerEditor.TabStop = false;
            this.grpAnswerEditor.Text = "Answer Editor";
            // 
            // lblAnswerValidate
            // 
            this.lblAnswerValidate.AutoSize = true;
            this.lblAnswerValidate.Location = new System.Drawing.Point(12, 402);
            this.lblAnswerValidate.Name = "lblAnswerValidate";
            this.lblAnswerValidate.Size = new System.Drawing.Size(114, 16);
            this.lblAnswerValidate.TabIndex = 13;
            this.lblAnswerValidate.Text = "Answer Validate: -";
            // 
            // btnAnswerDeactivate
            // 
            this.btnAnswerDeactivate.Location = new System.Drawing.Point(350, 370);
            this.btnAnswerDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerDeactivate.Name = "btnAnswerDeactivate";
            this.btnAnswerDeactivate.Size = new System.Drawing.Size(98, 27);
            this.btnAnswerDeactivate.TabIndex = 12;
            this.btnAnswerDeactivate.Text = "Vô hiệu hóa";
            this.btnAnswerDeactivate.UseVisualStyleBackColor = true;
            this.btnAnswerDeactivate.Click += new System.EventHandler(this.btnAnswerDeactivate_Click);
            // 
            // btnAnswerUpdate
            // 
            this.btnAnswerUpdate.Location = new System.Drawing.Point(256, 370);
            this.btnAnswerUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerUpdate.Name = "btnAnswerUpdate";
            this.btnAnswerUpdate.Size = new System.Drawing.Size(89, 27);
            this.btnAnswerUpdate.TabIndex = 11;
            this.btnAnswerUpdate.Text = "Cập nhật";
            this.btnAnswerUpdate.UseVisualStyleBackColor = true;
            this.btnAnswerUpdate.Click += new System.EventHandler(this.btnAnswerUpdate_Click);
            // 
            // btnAnswerAdd
            // 
            this.btnAnswerAdd.Location = new System.Drawing.Point(162, 370);
            this.btnAnswerAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerAdd.Name = "btnAnswerAdd";
            this.btnAnswerAdd.Size = new System.Drawing.Size(89, 27);
            this.btnAnswerAdd.TabIndex = 10;
            this.btnAnswerAdd.Text = "Thêm";
            this.btnAnswerAdd.UseVisualStyleBackColor = true;
            this.btnAnswerAdd.Click += new System.EventHandler(this.btnAnswerAdd_Click);
            // 
            // btnAnswerNew
            // 
            this.btnAnswerNew.Location = new System.Drawing.Point(68, 370);
            this.btnAnswerNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerNew.Name = "btnAnswerNew";
            this.btnAnswerNew.Size = new System.Drawing.Size(89, 27);
            this.btnAnswerNew.TabIndex = 9;
            this.btnAnswerNew.Text = "Nhập mới";
            this.btnAnswerNew.UseVisualStyleBackColor = true;
            this.btnAnswerNew.Click += new System.EventHandler(this.btnAnswerNew_Click);
            // 
            // chkAnswerIsActive
            // 
            this.chkAnswerIsActive.AutoSize = true;
            this.chkAnswerIsActive.Location = new System.Drawing.Point(430, 341);
            this.chkAnswerIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnswerIsActive.Name = "chkAnswerIsActive";
            this.chkAnswerIsActive.Size = new System.Drawing.Size(18, 17);
            this.chkAnswerIsActive.TabIndex = 8;
            this.chkAnswerIsActive.UseVisualStyleBackColor = true;
            // 
            // lblAnswerIsActive
            // 
            this.lblAnswerIsActive.AutoSize = true;
            this.lblAnswerIsActive.Location = new System.Drawing.Point(356, 340);
            this.lblAnswerIsActive.Name = "lblAnswerIsActive";
            this.lblAnswerIsActive.Size = new System.Drawing.Size(54, 16);
            this.lblAnswerIsActive.TabIndex = 7;
            this.lblAnswerIsActive.Text = "IsActive";
            // 
            // chkIsCorrect
            // 
            this.chkIsCorrect.AutoSize = true;
            this.chkIsCorrect.Location = new System.Drawing.Point(318, 339);
            this.chkIsCorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsCorrect.Name = "chkIsCorrect";
            this.chkIsCorrect.Size = new System.Drawing.Size(18, 17);
            this.chkIsCorrect.TabIndex = 6;
            this.chkIsCorrect.UseVisualStyleBackColor = true;
            // 
            // lblIsCorrect
            // 
            this.lblIsCorrect.AutoSize = true;
            this.lblIsCorrect.Location = new System.Drawing.Point(253, 339);
            this.lblIsCorrect.Name = "lblIsCorrect";
            this.lblIsCorrect.Size = new System.Drawing.Size(50, 16);
            this.lblIsCorrect.TabIndex = 5;
            this.lblIsCorrect.Text = "Correct";
            // 
            // txtAnswerText
            // 
            this.txtAnswerText.Location = new System.Drawing.Point(96, 334);
            this.txtAnswerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswerText.Name = "txtAnswerText";
            this.txtAnswerText.Size = new System.Drawing.Size(151, 22);
            this.txtAnswerText.TabIndex = 4;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Location = new System.Drawing.Point(12, 337);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(51, 16);
            this.lblAnswerText.TabIndex = 3;
            this.lblAnswerText.Text = "Answer";
            // 
            // lblAnswerMode
            // 
            this.lblAnswerMode.AutoSize = true;
            this.lblAnswerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAnswerMode.Location = new System.Drawing.Point(12, 312);
            this.lblAnswerMode.Name = "lblAnswerMode";
            this.lblAnswerMode.Size = new System.Drawing.Size(126, 18);
            this.lblAnswerMode.TabIndex = 2;
            this.lblAnswerMode.Text = "Answer Mode: -";
            // 
            // lblAnswerCount
            // 
            this.lblAnswerCount.AutoSize = true;
            this.lblAnswerCount.Location = new System.Drawing.Point(12, 25);
            this.lblAnswerCount.Name = "lblAnswerCount";
            this.lblAnswerCount.Size = new System.Drawing.Size(71, 16);
            this.lblAnswerCount.TabIndex = 1;
            this.lblAnswerCount.Text = "Answers: 0";
            // 
            // dgvAnswer
            // 
            this.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswer.Location = new System.Drawing.Point(16, 46);
            this.dgvAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnswer.Name = "dgvAnswer";
            this.dgvAnswer.RowHeadersWidth = 62;
            this.dgvAnswer.RowTemplate.Height = 28;
            this.dgvAnswer.Size = new System.Drawing.Size(432, 256);
            this.dgvAnswer.TabIndex = 0;
            this.dgvAnswer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnswer_CellClick);
            // 
            // FrmAdminQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 704);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Quản lý Question / Answer / Option";
            this.Load += new System.EventHandler(this.FrmAdminQuestion_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpQuestionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.grpQuestionEditor.ResumeLayout(false);
            this.grpQuestionEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestionOrder)).EndInit();
            this.grpOptionEditor.ResumeLayout(false);
            this.grpOptionEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).EndInit();
            this.grpAnswerEditor.ResumeLayout(false);
            this.grpAnswerEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).EndInit();
            this.ResumeLayout(false);

        }
    }
}