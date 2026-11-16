namespace TOEIC_Practice.GUI.Admin
{
    partial class FrmAdminMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAdminEts;
        private System.Windows.Forms.Button btnAdminTest;
        private System.Windows.Forms.Button btnAdminGroup;
        private System.Windows.Forms.Button btnAdminQuestion;
        private System.Windows.Forms.Button btnAdminAccount;
        private System.Windows.Forms.Button btnAdminStats;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Panel pnlMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdminStats = new System.Windows.Forms.Button();
            this.btnAdminAccount = new System.Windows.Forms.Button();
            this.btnAdminQuestion = new System.Windows.Forms.Button();
            this.btnAdminGroup = new System.Windows.Forms.Button();
            this.btnAdminTest = new System.Windows.Forms.Button();
            this.btnAdminEts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(20, 649);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(198, 40);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAdminStats);
            this.pnlMenu.Controls.Add(this.btnAdminAccount);
            this.pnlMenu.Controls.Add(this.btnAdminQuestion);
            this.pnlMenu.Controls.Add(this.btnAdminGroup);
            this.pnlMenu.Controls.Add(this.btnAdminTest);
            this.pnlMenu.Controls.Add(this.btnAdminEts);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 70);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 360);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAdminStats
            // 
            this.btnAdminStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminStats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminStats.ForeColor = System.Drawing.Color.White;
            this.btnAdminStats.Location = new System.Drawing.Point(20, 302);
            this.btnAdminStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminStats.Name = "btnAdminStats";
            this.btnAdminStats.Size = new System.Drawing.Size(198, 40);
            this.btnAdminStats.TabIndex = 7;
            this.btnAdminStats.Text = "Thống kê";
            this.btnAdminStats.UseVisualStyleBackColor = false;
            this.btnAdminStats.Click += new System.EventHandler(this.btnAdminStats_Click);
            // 
            // btnAdminAccount
            // 
            this.btnAdminAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminAccount.ForeColor = System.Drawing.Color.White;
            this.btnAdminAccount.Location = new System.Drawing.Point(20, 256);
            this.btnAdminAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminAccount.Name = "btnAdminAccount";
            this.btnAdminAccount.Size = new System.Drawing.Size(198, 40);
            this.btnAdminAccount.TabIndex = 6;
            this.btnAdminAccount.Text = "Quản lý Account";
            this.btnAdminAccount.UseVisualStyleBackColor = false;
            this.btnAdminAccount.Click += new System.EventHandler(this.btnAdminAccount_Click);
            // 
            // btnAdminQuestion
            // 
            this.btnAdminQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAdminQuestion.Location = new System.Drawing.Point(20, 210);
            this.btnAdminQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminQuestion.Name = "btnAdminQuestion";
            this.btnAdminQuestion.Size = new System.Drawing.Size(198, 40);
            this.btnAdminQuestion.TabIndex = 5;
            this.btnAdminQuestion.Text = "Quản lý Question";
            this.btnAdminQuestion.UseVisualStyleBackColor = false;
            this.btnAdminQuestion.Click += new System.EventHandler(this.btnAdminQuestion_Click);
            // 
            // btnAdminGroup
            // 
            this.btnAdminGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminGroup.ForeColor = System.Drawing.Color.White;
            this.btnAdminGroup.Location = new System.Drawing.Point(20, 164);
            this.btnAdminGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminGroup.Name = "btnAdminGroup";
            this.btnAdminGroup.Size = new System.Drawing.Size(198, 40);
            this.btnAdminGroup.TabIndex = 4;
            this.btnAdminGroup.Text = "Quản lý Group";
            this.btnAdminGroup.UseVisualStyleBackColor = false;
            this.btnAdminGroup.Click += new System.EventHandler(this.btnAdminGroup_Click);
            // 
            // btnAdminTest
            // 
            this.btnAdminTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminTest.ForeColor = System.Drawing.Color.White;
            this.btnAdminTest.Location = new System.Drawing.Point(20, 118);
            this.btnAdminTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminTest.Name = "btnAdminTest";
            this.btnAdminTest.Size = new System.Drawing.Size(198, 40);
            this.btnAdminTest.TabIndex = 3;
            this.btnAdminTest.Text = "Quản lý Test";
            this.btnAdminTest.UseVisualStyleBackColor = false;
            this.btnAdminTest.Click += new System.EventHandler(this.btnAdminTest_Click);
            // 
            // btnAdminEts
            // 
            this.btnAdminEts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAdminEts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnAdminEts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdminEts.ForeColor = System.Drawing.Color.White;
            this.btnAdminEts.Location = new System.Drawing.Point(20, 72);
            this.btnAdminEts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminEts.Name = "btnAdminEts";
            this.btnAdminEts.Size = new System.Drawing.Size(198, 40);
            this.btnAdminEts.TabIndex = 2;
            this.btnAdminEts.Text = "Quản lý ETS";
            this.btnAdminEts.UseVisualStyleBackColor = false;
            this.btnAdminEts.Click += new System.EventHandler(this.btnAdminEts_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 26);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(198, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Trang chính";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlLogo.Controls.Add(this.lblAdminTitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 70);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAdminTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdminTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(240, 70);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "ADMIN";
            this.lblAdminTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblSystemName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(240, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1120, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateTime.Location = new System.Drawing.Point(861, 39);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(235, 20);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Ngày giờ";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWelcome.Location = new System.Drawing.Point(731, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(365, 23);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào, Admin";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSystemName.Location = new System.Drawing.Point(22, 21);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(266, 30);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "TOEIC PRACTICE ADMIN";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(240, 70);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1120, 630);
            this.pnlContainer.TabIndex = 2;
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 700);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FrmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOEIC Practice - Admin";
            this.Load += new System.EventHandler(this.FrmAdminMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}