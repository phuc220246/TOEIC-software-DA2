namespace TOEIC_Practice.GUI
{
    partial class FrmKetQua
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlRoot;

        private System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblBadgePart;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderButtons;
        public System.Windows.Forms.Button btnXemDapAn;
        public System.Windows.Forms.Button btnQuayVe;

        private System.Windows.Forms.TableLayoutPanel tblMain;

        // Left summary card
        private System.Windows.Forms.Panel cardSummary;
        private System.Windows.Forms.Label lblSummaryTitle;

        private System.Windows.Forms.TableLayoutPanel tblSummary;
        private System.Windows.Forms.Label lblKetQuaText;
        public System.Windows.Forms.Label lblKetQuaValue;     // ví dụ: 12/30

        private System.Windows.Forms.Label lblAccuracyText;
        public System.Windows.Forms.Label lblAccuracyValue;   // ví dụ: 40.0%

        private System.Windows.Forms.Label lblTimeText;
        public System.Windows.Forms.Label lblTimeValue;       // ví dụ: 00:11:21

        // Right cards container
        private System.Windows.Forms.TableLayoutPanel tblCards;

        private System.Windows.Forms.Panel cardCorrect;
        private System.Windows.Forms.Label lblCorrectTitle;
        public System.Windows.Forms.Label lblCorrectValue;
        private System.Windows.Forms.Label lblCorrectUnit;

        private System.Windows.Forms.Panel cardWrong;
        private System.Windows.Forms.Label lblWrongTitle;
        public System.Windows.Forms.Label lblWrongValue;
        private System.Windows.Forms.Label lblWrongUnit;

        private System.Windows.Forms.Panel cardSkipped;
        private System.Windows.Forms.Label lblSkippedTitle;
        public System.Windows.Forms.Label lblSkippedValue;
        private System.Windows.Forms.Label lblSkippedUnit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.tblSummary = new System.Windows.Forms.TableLayoutPanel();
            this.lblKetQuaText = new System.Windows.Forms.Label();
            this.lblKetQuaValue = new System.Windows.Forms.Label();
            this.lblAccuracyText = new System.Windows.Forms.Label();
            this.lblAccuracyValue = new System.Windows.Forms.Label();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectTitle = new System.Windows.Forms.Label();
            this.lblCorrectValue = new System.Windows.Forms.Label();
            this.lblCorrectUnit = new System.Windows.Forms.Label();
            this.cardWrong = new System.Windows.Forms.Panel();
            this.lblWrongTitle = new System.Windows.Forms.Label();
            this.lblWrongValue = new System.Windows.Forms.Label();
            this.lblWrongUnit = new System.Windows.Forms.Label();
            this.cardSkipped = new System.Windows.Forms.Panel();
            this.lblSkippedTitle = new System.Windows.Forms.Label();
            this.lblSkippedValue = new System.Windows.Forms.Label();
            this.lblSkippedUnit = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBadgePart = new System.Windows.Forms.Label();
            this.flpHeaderButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXemDapAn = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.pnlRoot.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.cardSummary.SuspendLayout();
            this.tblSummary.SuspendLayout();
            this.tblCards.SuspendLayout();
            this.cardCorrect.SuspendLayout();
            this.cardWrong.SuspendLayout();
            this.cardSkipped.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flpHeaderButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.White;
            this.pnlRoot.Controls.Add(this.tblMain);
            this.pnlRoot.Controls.Add(this.pnlHeader);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(18);
            this.pnlRoot.Size = new System.Drawing.Size(1180, 650);
            this.pnlRoot.TabIndex = 0;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.cardSummary, 0, 0);
            this.tblMain.Controls.Add(this.tblCards, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(18, 108);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1144, 524);
            this.tblMain.TabIndex = 0;
            // 
            // cardSummary
            // 
            this.cardSummary.BackColor = System.Drawing.Color.White;
            this.cardSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSummary.Controls.Add(this.lblSummaryTitle);
            this.cardSummary.Controls.Add(this.tblSummary);
            this.cardSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSummary.Location = new System.Drawing.Point(0, 10);
            this.cardSummary.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.cardSummary.Name = "cardSummary";
            this.cardSummary.Padding = new System.Windows.Forms.Padding(16);
            this.cardSummary.Size = new System.Drawing.Size(346, 514);
            this.cardSummary.TabIndex = 0;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(105, 25);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Tổng quát";
            // 
            // tblSummary
            // 
            this.tblSummary.ColumnCount = 2;
            this.tblSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tblSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tblSummary.Controls.Add(this.lblKetQuaText, 0, 0);
            this.tblSummary.Controls.Add(this.lblKetQuaValue, 1, 0);
            this.tblSummary.Controls.Add(this.lblAccuracyText, 0, 1);
            this.tblSummary.Controls.Add(this.lblAccuracyValue, 1, 1);
            this.tblSummary.Controls.Add(this.lblTimeText, 0, 2);
            this.tblSummary.Controls.Add(this.lblTimeValue, 1, 2);
            this.tblSummary.Location = new System.Drawing.Point(16, 48);
            this.tblSummary.Name = "tblSummary";
            this.tblSummary.RowCount = 3;
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSummary.Size = new System.Drawing.Size(320, 160);
            this.tblSummary.TabIndex = 1;
            // 
            // lblKetQuaText
            // 
            this.lblKetQuaText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQuaText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaText.Location = new System.Drawing.Point(3, 0);
            this.lblKetQuaText.Name = "lblKetQuaText";
            this.lblKetQuaText.Size = new System.Drawing.Size(192, 50);
            this.lblKetQuaText.TabIndex = 0;
            this.lblKetQuaText.Text = "Kết quả làm bài";
            this.lblKetQuaText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKetQuaValue
            // 
            this.lblKetQuaValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQuaValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaValue.Location = new System.Drawing.Point(201, 0);
            this.lblKetQuaValue.Name = "lblKetQuaValue";
            this.lblKetQuaValue.Size = new System.Drawing.Size(116, 50);
            this.lblKetQuaValue.TabIndex = 1;
            this.lblKetQuaValue.Text = "0/0";
            this.lblKetQuaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccuracyText
            // 
            this.lblAccuracyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccuracyText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccuracyText.Location = new System.Drawing.Point(3, 50);
            this.lblAccuracyText.Name = "lblAccuracyText";
            this.lblAccuracyText.Size = new System.Drawing.Size(192, 50);
            this.lblAccuracyText.TabIndex = 2;
            this.lblAccuracyText.Text = "Độ chính xác";
            this.lblAccuracyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccuracyValue
            // 
            this.lblAccuracyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccuracyValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccuracyValue.Location = new System.Drawing.Point(201, 50);
            this.lblAccuracyValue.Name = "lblAccuracyValue";
            this.lblAccuracyValue.Size = new System.Drawing.Size(116, 50);
            this.lblAccuracyValue.TabIndex = 3;
            this.lblAccuracyValue.Text = "0.0%";
            this.lblAccuracyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeText
            // 
            this.lblTimeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeText.Location = new System.Drawing.Point(3, 100);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(192, 60);
            this.lblTimeText.TabIndex = 4;
            this.lblTimeText.Text = "Thời gian hoàn thành";
            this.lblTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimeValue.Location = new System.Drawing.Point(201, 100);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(116, 60);
            this.lblTimeValue.TabIndex = 5;
            this.lblTimeValue.Text = "00:00:00";
            this.lblTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblCards
            // 
            this.tblCards.ColumnCount = 3;
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblCards.Controls.Add(this.cardCorrect, 0, 0);
            this.tblCards.Controls.Add(this.cardWrong, 1, 0);
            this.tblCards.Controls.Add(this.cardSkipped, 2, 0);
            this.tblCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCards.Location = new System.Drawing.Point(363, 13);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 1;
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCards.Size = new System.Drawing.Size(778, 508);
            this.tblCards.TabIndex = 1;
            // 
            // cardCorrect
            // 
            this.cardCorrect.BackColor = System.Drawing.Color.White;
            this.cardCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardCorrect.Controls.Add(this.lblCorrectTitle);
            this.cardCorrect.Controls.Add(this.lblCorrectValue);
            this.cardCorrect.Controls.Add(this.lblCorrectUnit);
            this.cardCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCorrect.Location = new System.Drawing.Point(0, 0);
            this.cardCorrect.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cardCorrect.Name = "cardCorrect";
            this.cardCorrect.Padding = new System.Windows.Forms.Padding(16);
            this.cardCorrect.Size = new System.Drawing.Size(249, 508);
            this.cardCorrect.TabIndex = 0;
            // 
            // lblCorrectTitle
            // 
            this.lblCorrectTitle.AutoSize = true;
            this.lblCorrectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCorrectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblCorrectTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCorrectTitle.Name = "lblCorrectTitle";
            this.lblCorrectTitle.Size = new System.Drawing.Size(127, 28);
            this.lblCorrectTitle.TabIndex = 0;
            this.lblCorrectTitle.Text = "Trả lời đúng";
            // 
            // lblCorrectValue
            // 
            this.lblCorrectValue.AutoSize = true;
            this.lblCorrectValue.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCorrectValue.Location = new System.Drawing.Point(16, 55);
            this.lblCorrectValue.Name = "lblCorrectValue";
            this.lblCorrectValue.Size = new System.Drawing.Size(50, 60);
            this.lblCorrectValue.TabIndex = 1;
            this.lblCorrectValue.Text = "0";
            // 
            // lblCorrectUnit
            // 
            this.lblCorrectUnit.AutoSize = true;
            this.lblCorrectUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCorrectUnit.Location = new System.Drawing.Point(20, 108);
            this.lblCorrectUnit.Name = "lblCorrectUnit";
            this.lblCorrectUnit.Size = new System.Drawing.Size(74, 25);
            this.lblCorrectUnit.TabIndex = 2;
            this.lblCorrectUnit.Text = "câu hỏi";
            // 
            // cardWrong
            // 
            this.cardWrong.BackColor = System.Drawing.Color.White;
            this.cardWrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardWrong.Controls.Add(this.lblWrongTitle);
            this.cardWrong.Controls.Add(this.lblWrongValue);
            this.cardWrong.Controls.Add(this.lblWrongUnit);
            this.cardWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardWrong.Location = new System.Drawing.Point(259, 0);
            this.cardWrong.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cardWrong.Name = "cardWrong";
            this.cardWrong.Padding = new System.Windows.Forms.Padding(16);
            this.cardWrong.Size = new System.Drawing.Size(249, 508);
            this.cardWrong.TabIndex = 1;
            // 
            // lblWrongTitle
            // 
            this.lblWrongTitle.AutoSize = true;
            this.lblWrongTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWrongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblWrongTitle.Location = new System.Drawing.Point(16, 16);
            this.lblWrongTitle.Name = "lblWrongTitle";
            this.lblWrongTitle.Size = new System.Drawing.Size(104, 28);
            this.lblWrongTitle.TabIndex = 0;
            this.lblWrongTitle.Text = "Trả lời sai";
            // 
            // lblWrongValue
            // 
            this.lblWrongValue.AutoSize = true;
            this.lblWrongValue.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblWrongValue.Location = new System.Drawing.Point(16, 55);
            this.lblWrongValue.Name = "lblWrongValue";
            this.lblWrongValue.Size = new System.Drawing.Size(50, 60);
            this.lblWrongValue.TabIndex = 1;
            this.lblWrongValue.Text = "0";
            // 
            // lblWrongUnit
            // 
            this.lblWrongUnit.AutoSize = true;
            this.lblWrongUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWrongUnit.Location = new System.Drawing.Point(20, 108);
            this.lblWrongUnit.Name = "lblWrongUnit";
            this.lblWrongUnit.Size = new System.Drawing.Size(74, 25);
            this.lblWrongUnit.TabIndex = 2;
            this.lblWrongUnit.Text = "câu hỏi";
            // 
            // cardSkipped
            // 
            this.cardSkipped.BackColor = System.Drawing.Color.White;
            this.cardSkipped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSkipped.Controls.Add(this.lblSkippedTitle);
            this.cardSkipped.Controls.Add(this.lblSkippedValue);
            this.cardSkipped.Controls.Add(this.lblSkippedUnit);
            this.cardSkipped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSkipped.Location = new System.Drawing.Point(518, 0);
            this.cardSkipped.Margin = new System.Windows.Forms.Padding(0);
            this.cardSkipped.Name = "cardSkipped";
            this.cardSkipped.Padding = new System.Windows.Forms.Padding(16);
            this.cardSkipped.Size = new System.Drawing.Size(260, 508);
            this.cardSkipped.TabIndex = 2;
            // 
            // lblSkippedTitle
            // 
            this.lblSkippedTitle.AutoSize = true;
            this.lblSkippedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSkippedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSkippedTitle.Location = new System.Drawing.Point(16, 16);
            this.lblSkippedTitle.Name = "lblSkippedTitle";
            this.lblSkippedTitle.Size = new System.Drawing.Size(78, 28);
            this.lblSkippedTitle.TabIndex = 0;
            this.lblSkippedTitle.Text = "Bỏ qua";
            // 
            // lblSkippedValue
            // 
            this.lblSkippedValue.AutoSize = true;
            this.lblSkippedValue.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblSkippedValue.Location = new System.Drawing.Point(16, 55);
            this.lblSkippedValue.Name = "lblSkippedValue";
            this.lblSkippedValue.Size = new System.Drawing.Size(50, 60);
            this.lblSkippedValue.TabIndex = 1;
            this.lblSkippedValue.Text = "0";
            // 
            // lblSkippedUnit
            // 
            this.lblSkippedUnit.AutoSize = true;
            this.lblSkippedUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSkippedUnit.Location = new System.Drawing.Point(20, 108);
            this.lblSkippedUnit.Name = "lblSkippedUnit";
            this.lblSkippedUnit.Size = new System.Drawing.Size(74, 25);
            this.lblSkippedUnit.TabIndex = 2;
            this.lblSkippedUnit.Text = "câu hỏi";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblBadgePart);
            this.pnlHeader.Controls.Add(this.flpHeaderButtons);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1144, 90);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kết quả luyện tập: TOEIC Test";
            // 
            // lblBadgePart
            // 
            this.lblBadgePart.AutoSize = true;
            this.lblBadgePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblBadgePart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBadgePart.ForeColor = System.Drawing.Color.White;
            this.lblBadgePart.Location = new System.Drawing.Point(520, 18);
            this.lblBadgePart.Name = "lblBadgePart";
            this.lblBadgePart.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblBadgePart.Size = new System.Drawing.Size(74, 31);
            this.lblBadgePart.TabIndex = 1;
            this.lblBadgePart.Text = "";
            // 
            // flpHeaderButtons
            // 
            this.flpHeaderButtons.AutoSize = true;
            this.flpHeaderButtons.Controls.Add(this.btnXemDapAn);
            this.flpHeaderButtons.Controls.Add(this.btnQuayVe);
            this.flpHeaderButtons.Location = new System.Drawing.Point(6, 50);
            this.flpHeaderButtons.Name = "flpHeaderButtons";
            this.flpHeaderButtons.Size = new System.Drawing.Size(316, 100);
            this.flpHeaderButtons.TabIndex = 2;
            this.flpHeaderButtons.WrapContents = false;
            // 
            // btnXemDapAn
            // 
            this.btnXemDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnXemDapAn.FlatAppearance.BorderSize = 0;
            this.btnXemDapAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDapAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemDapAn.ForeColor = System.Drawing.Color.White;
            this.btnXemDapAn.Location = new System.Drawing.Point(3, 3);
            this.btnXemDapAn.Name = "btnXemDapAn";
            this.btnXemDapAn.Size = new System.Drawing.Size(130, 34);
            this.btnXemDapAn.TabIndex = 0;
            this.btnXemDapAn.Text = "Xem đáp án";
            this.btnXemDapAn.UseVisualStyleBackColor = false;
            this.btnXemDapAn.Click += new System.EventHandler(this.btnXemDapAn_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.White;
            this.btnQuayVe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnQuayVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnQuayVe.Location = new System.Drawing.Point(146, 0);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(170, 34);
            this.btnQuayVe.TabIndex = 1;
            this.btnQuayVe.Text = "Quay về trang đề thi";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // FrmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Controls.Add(this.pnlRoot);
            this.Name = "FrmKetQua";
            this.Text = "Kết quả luyện tập";
            this.Load += new System.EventHandler(this.FrmKetQua_Load);
            this.pnlRoot.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.cardSummary.ResumeLayout(false);
            this.cardSummary.PerformLayout();
            this.tblSummary.ResumeLayout(false);
            this.tblCards.ResumeLayout(false);
            this.cardCorrect.ResumeLayout(false);
            this.cardCorrect.PerformLayout();
            this.cardWrong.ResumeLayout(false);
            this.cardWrong.PerformLayout();
            this.cardSkipped.ResumeLayout(false);
            this.cardSkipped.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.flpHeaderButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}