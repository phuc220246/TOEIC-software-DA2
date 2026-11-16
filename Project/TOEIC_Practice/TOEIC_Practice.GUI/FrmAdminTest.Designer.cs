namespace TOEIC_Practice.GUI.Admin
{
    partial class FrmAdminTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboEtsFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.nudTestNo = new System.Windows.Forms.NumericUpDown();
            this.cboEtsEdit = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTestNo = new System.Windows.Forms.Label();
            this.lblEts = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestNo)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Controls.Add(this.cboEtsFilter);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.lblTotal);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1052, 51);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(14, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(59, 16);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Lọc ETS";
            // 
            // cboEtsFilter
            // 
            this.cboEtsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtsFilter.FormattingEnabled = true;
            this.cboEtsFilter.Location = new System.Drawing.Point(98, 15);
            this.cboEtsFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEtsFilter.Name = "cboEtsFilter";
            this.cboEtsFilter.Size = new System.Drawing.Size(224, 24);
            this.cboEtsFilter.TabIndex = 1;
            this.cboEtsFilter.SelectedIndexChanged += new System.EventHandler(this.cboEtsFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(358, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(426, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(687, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(949, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Tổng số: 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRight);
            this.splitContainer1.Size = new System.Drawing.Size(1052, 478);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTest.Location = new System.Drawing.Point(0, 0);
            this.dgvTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowHeadersWidth = 62;
            this.dgvTest.RowTemplate.Height = 28;
            this.dgvTest.Size = new System.Drawing.Size(659, 478);
            this.dgvTest.TabIndex = 0;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestCellClickSafe);
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
            this.pnlRight.Size = new System.Drawing.Size(389, 478);
            this.pnlRight.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Padding = new System.Windows.Forms.Padding(9, 8, 0, 8);
            this.lblMode.Size = new System.Drawing.Size(389, 38);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Chế độ: Thêm mới";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chkIsActive);
            this.grpInfo.Controls.Add(this.nudTestNo);
            this.grpInfo.Controls.Add(this.cboEtsEdit);
            this.grpInfo.Controls.Add(this.txtTitle);
            this.grpInfo.Controls.Add(this.lblIsActive);
            this.grpInfo.Controls.Add(this.lblTitle);
            this.grpInfo.Controls.Add(this.lblTestNo);
            this.grpInfo.Controls.Add(this.lblEts);
            this.grpInfo.Location = new System.Drawing.Point(15, 48);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Size = new System.Drawing.Size(359, 223);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin Test";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(151, 183);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(18, 17);
            this.chkIsActive.TabIndex = 7;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // nudTestNo
            // 
            this.nudTestNo.Location = new System.Drawing.Point(119, 75);
            this.nudTestNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTestNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTestNo.Name = "nudTestNo";
            this.nudTestNo.Size = new System.Drawing.Size(85, 22);
            this.nudTestNo.TabIndex = 3;
            this.nudTestNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboEtsEdit
            // 
            this.cboEtsEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtsEdit.FormattingEnabled = true;
            this.cboEtsEdit.Location = new System.Drawing.Point(119, 34);
            this.cboEtsEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEtsEdit.Name = "cboEtsEdit";
            this.cboEtsEdit.Size = new System.Drawing.Size(215, 24);
            this.cboEtsEdit.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(119, 118);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(215, 49);
            this.txtTitle.TabIndex = 5;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(23, 184);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(102, 16);
            this.lblIsActive.TabIndex = 6;
            this.lblIsActive.Text = "Đang hoạt động";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // lblTestNo
            // 
            this.lblTestNo.AutoSize = true;
            this.lblTestNo.Location = new System.Drawing.Point(23, 77);
            this.lblTestNo.Name = "lblTestNo";
            this.lblTestNo.Size = new System.Drawing.Size(52, 16);
            this.lblTestNo.TabIndex = 2;
            this.lblTestNo.Text = "TestNo";
            // 
            // lblEts
            // 
            this.lblEts.AutoSize = true;
            this.lblEts.Location = new System.Drawing.Point(23, 36);
            this.lblEts.Name = "lblEts";
            this.lblEts.Size = new System.Drawing.Size(34, 16);
            this.lblEts.TabIndex = 0;
            this.lblEts.Text = "ETS";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnDeactivate);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 402);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(389, 76);
            this.pnlButton.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(282, 22);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(92, 32);
            this.btnDeactivate.TabIndex = 3;
            this.btnDeactivate.Text = "Vô hiệu hóa";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Lưu mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAdminTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 529);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Quản lý Test";
            this.Load += new System.EventHandler(this.FrmAdminTest_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestNo)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboEtsFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.NumericUpDown nudTestNo;
        private System.Windows.Forms.ComboBox cboEtsEdit;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTestNo;
        private System.Windows.Forms.Label lblEts;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}