namespace TOEIC_Practice.GUI.Admin
{
    partial class FrmAdminGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTestFilter;
        private System.Windows.Forms.ComboBox cboTestFilter;
        private System.Windows.Forms.Label lblPartFilter;
        private System.Windows.Forms.ComboBox cboPartFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnBrowseAudio;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.NumericUpDown nudOrderNo;
        private System.Windows.Forms.ComboBox cboGroupType;
        private System.Windows.Forms.ComboBox cboPartEdit;
        private System.Windows.Forms.ComboBox cboTestEdit;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.TextBox txtPassageText;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblGroupType;
        private System.Windows.Forms.Label lblPartEdit;
        private System.Windows.Forms.Label lblTestEdit;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblAudioPath;
        private System.Windows.Forms.Label lblPassageText;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;

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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnBrowseAudio = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.nudOrderNo = new System.Windows.Forms.NumericUpDown();
            this.cboGroupType = new System.Windows.Forms.ComboBox();
            this.cboPartEdit = new System.Windows.Forms.ComboBox();
            this.cboTestEdit = new System.Windows.Forms.ComboBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.txtPassageText = new System.Windows.Forms.TextBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblGroupType = new System.Windows.Forms.Label();
            this.lblPartEdit = new System.Windows.Forms.Label();
            this.lblTestEdit = new System.Windows.Forms.Label();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblAudioPath = new System.Windows.Forms.Label();
            this.lblPassageText = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderNo)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTestFilter);
            this.pnlTop.Controls.Add(this.cboTestFilter);
            this.pnlTop.Controls.Add(this.lblPartFilter);
            this.pnlTop.Controls.Add(this.cboPartFilter);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.lblTotal);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1141, 56);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTestFilter
            // 
            this.lblTestFilter.AutoSize = true;
            this.lblTestFilter.Location = new System.Drawing.Point(14, 19);
            this.lblTestFilter.Name = "lblTestFilter";
            this.lblTestFilter.Size = new System.Drawing.Size(34, 16);
            this.lblTestFilter.TabIndex = 0;
            this.lblTestFilter.Text = "Test";
            // 
            // cboTestFilter
            // 
            this.cboTestFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestFilter.FormattingEnabled = true;
            this.cboTestFilter.Location = new System.Drawing.Point(72, 14);
            this.cboTestFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTestFilter.Name = "cboTestFilter";
            this.cboTestFilter.Size = new System.Drawing.Size(220, 24);
            this.cboTestFilter.TabIndex = 1;
            this.cboTestFilter.SelectedIndexChanged += new System.EventHandler(this.cboTestFilter_SelectedIndexChanged);
            // 
            // lblPartFilter
            // 
            this.lblPartFilter.AutoSize = true;
            this.lblPartFilter.Location = new System.Drawing.Point(309, 19);
            this.lblPartFilter.Name = "lblPartFilter";
            this.lblPartFilter.Size = new System.Drawing.Size(31, 16);
            this.lblPartFilter.TabIndex = 2;
            this.lblPartFilter.Text = "Part";
            // 
            // cboPartFilter
            // 
            this.cboPartFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartFilter.FormattingEnabled = true;
            this.cboPartFilter.Location = new System.Drawing.Point(357, 16);
            this.cboPartFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPartFilter.Name = "cboPartFilter";
            this.cboPartFilter.Size = new System.Drawing.Size(151, 24);
            this.cboPartFilter.TabIndex = 3;
            this.cboPartFilter.SelectedIndexChanged += new System.EventHandler(this.cboPartFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(529, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(607, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(873, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 26);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1036, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Tổng số: 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRight);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 553);
            this.splitContainer1.SplitterDistance = 684;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvGroup
            // 
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowHeadersWidth = 62;
            this.dgvGroup.RowTemplate.Height = 28;
            this.dgvGroup.Size = new System.Drawing.Size(684, 553);
            this.dgvGroup.TabIndex = 0;
            this.dgvGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellClick);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblMode);
            this.pnlRight.Controls.Add(this.grpInfo);
            this.pnlRight.Controls.Add(this.pnlButton);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(453, 553);
            this.pnlRight.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Padding = new System.Windows.Forms.Padding(9, 8, 0, 8);
            this.lblMode.Size = new System.Drawing.Size(453, 38);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Chế độ: Thêm mới";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnBrowseImage);
            this.grpInfo.Controls.Add(this.btnBrowseAudio);
            this.grpInfo.Controls.Add(this.chkIsActive);
            this.grpInfo.Controls.Add(this.nudOrderNo);
            this.grpInfo.Controls.Add(this.cboGroupType);
            this.grpInfo.Controls.Add(this.cboPartEdit);
            this.grpInfo.Controls.Add(this.cboTestEdit);
            this.grpInfo.Controls.Add(this.txtImagePath);
            this.grpInfo.Controls.Add(this.txtAudioPath);
            this.grpInfo.Controls.Add(this.txtPassageText);
            this.grpInfo.Controls.Add(this.lblIsActive);
            this.grpInfo.Controls.Add(this.lblOrderNo);
            this.grpInfo.Controls.Add(this.lblGroupType);
            this.grpInfo.Controls.Add(this.lblPartEdit);
            this.grpInfo.Controls.Add(this.lblTestEdit);
            this.grpInfo.Controls.Add(this.lblImagePath);
            this.grpInfo.Controls.Add(this.lblAudioPath);
            this.grpInfo.Controls.Add(this.lblPassageText);
            this.grpInfo.Location = new System.Drawing.Point(14, 48);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Size = new System.Drawing.Size(425, 378);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin Group";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(337, 185);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(64, 25);
            this.btnBrowseImage.TabIndex = 11;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnBrowseAudio
            // 
            this.btnBrowseAudio.Location = new System.Drawing.Point(337, 142);
            this.btnBrowseAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseAudio.Name = "btnBrowseAudio";
            this.btnBrowseAudio.Size = new System.Drawing.Size(64, 25);
            this.btnBrowseAudio.TabIndex = 8;
            this.btnBrowseAudio.Text = "...";
            this.btnBrowseAudio.UseVisualStyleBackColor = true;
            this.btnBrowseAudio.Click += new System.EventHandler(this.btnBrowseAudio_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(171, 340);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(18, 17);
            this.chkIsActive.TabIndex = 17;
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // nudOrderNo
            // 
            this.nudOrderNo.Location = new System.Drawing.Point(143, 302);
            this.nudOrderNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOrderNo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudOrderNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrderNo.Name = "nudOrderNo";
            this.nudOrderNo.Size = new System.Drawing.Size(107, 22);
            this.nudOrderNo.TabIndex = 15;
            this.nudOrderNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboGroupType
            // 
            this.cboGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupType.FormattingEnabled = true;
            this.cboGroupType.Location = new System.Drawing.Point(143, 100);
            this.cboGroupType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGroupType.Name = "cboGroupType";
            this.cboGroupType.Size = new System.Drawing.Size(258, 24);
            this.cboGroupType.TabIndex = 5;
            // 
            // cboPartEdit
            // 
            this.cboPartEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartEdit.FormattingEnabled = true;
            this.cboPartEdit.Location = new System.Drawing.Point(143, 66);
            this.cboPartEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPartEdit.Name = "cboPartEdit";
            this.cboPartEdit.Size = new System.Drawing.Size(258, 24);
            this.cboPartEdit.TabIndex = 3;
            this.cboPartEdit.SelectedIndexChanged += new System.EventHandler(this.cboPartEdit_SelectedIndexChanged);
            // 
            // cboTestEdit
            // 
            this.cboTestEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestEdit.FormattingEnabled = true;
            this.cboTestEdit.Location = new System.Drawing.Point(143, 33);
            this.cboTestEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTestEdit.Name = "cboTestEdit";
            this.cboTestEdit.Size = new System.Drawing.Size(258, 24);
            this.cboTestEdit.TabIndex = 1;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(143, 186);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(171, 22);
            this.txtImagePath.TabIndex = 10;
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Location = new System.Drawing.Point(143, 144);
            this.txtAudioPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.ReadOnly = true;
            this.txtAudioPath.Size = new System.Drawing.Size(171, 22);
            this.txtAudioPath.TabIndex = 7;
            // 
            // txtPassageText
            // 
            this.txtPassageText.Location = new System.Drawing.Point(143, 229);
            this.txtPassageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassageText.Multiline = true;
            this.txtPassageText.Name = "txtPassageText";
            this.txtPassageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassageText.Size = new System.Drawing.Size(258, 59);
            this.txtPassageText.TabIndex = 13;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(24, 340);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(102, 16);
            this.lblIsActive.TabIndex = 16;
            this.lblIsActive.Text = "Đang hoạt động";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(24, 304);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(59, 16);
            this.lblOrderNo.TabIndex = 14;
            this.lblOrderNo.Text = "OrderNo";
            // 
            // lblGroupType
            // 
            this.lblGroupType.AutoSize = true;
            this.lblGroupType.Location = new System.Drawing.Point(24, 102);
            this.lblGroupType.Name = "lblGroupType";
            this.lblGroupType.Size = new System.Drawing.Size(113, 16);
            this.lblGroupType.TabIndex = 4;
            this.lblGroupType.Text = "GroupType (auto)";
            // 
            // lblPartEdit
            // 
            this.lblPartEdit.AutoSize = true;
            this.lblPartEdit.Location = new System.Drawing.Point(24, 69);
            this.lblPartEdit.Name = "lblPartEdit";
            this.lblPartEdit.Size = new System.Drawing.Size(31, 16);
            this.lblPartEdit.TabIndex = 2;
            this.lblPartEdit.Text = "Part";
            // 
            // lblTestEdit
            // 
            this.lblTestEdit.AutoSize = true;
            this.lblTestEdit.Location = new System.Drawing.Point(24, 35);
            this.lblTestEdit.Name = "lblTestEdit";
            this.lblTestEdit.Size = new System.Drawing.Size(34, 16);
            this.lblTestEdit.TabIndex = 0;
            this.lblTestEdit.Text = "Test";
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(24, 189);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(72, 16);
            this.lblImagePath.TabIndex = 9;
            this.lblImagePath.Text = "ImagePath";
            // 
            // lblAudioPath
            // 
            this.lblAudioPath.AutoSize = true;
            this.lblAudioPath.Location = new System.Drawing.Point(24, 146);
            this.lblAudioPath.Name = "lblAudioPath";
            this.lblAudioPath.Size = new System.Drawing.Size(69, 16);
            this.lblAudioPath.TabIndex = 6;
            this.lblAudioPath.Text = "AudioPath";
            // 
            // lblPassageText
            // 
            this.lblPassageText.AutoSize = true;
            this.lblPassageText.Location = new System.Drawing.Point(24, 231);
            this.lblPassageText.Name = "lblPassageText";
            this.lblPassageText.Size = new System.Drawing.Size(88, 16);
            this.lblPassageText.TabIndex = 12;
            this.lblPassageText.Text = "PassageText";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnDeactivate);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 477);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(453, 76);
            this.pnlButton.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nhập mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(334, 22);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(98, 32);
            this.btnDeactivate.TabIndex = 3;
            this.btnDeactivate.Text = "Vô hiệu hóa";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(229, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAdminGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 609);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Quản lý Group";
            this.Load += new System.EventHandler(this.FrmAdminGroup_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderNo)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}