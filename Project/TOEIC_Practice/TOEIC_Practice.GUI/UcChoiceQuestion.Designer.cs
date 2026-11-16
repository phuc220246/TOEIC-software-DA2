namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    partial class UcChoiceQuestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.rdoD);
            this.pnlMain.Controls.Add(this.rdoC);
            this.pnlMain.Controls.Add(this.rdoB);
            this.pnlMain.Controls.Add(this.rdoA);
            this.pnlMain.Controls.Add(this.lblQuestionText);
            this.pnlMain.Controls.Add(this.lblQuestionNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(900, 220);
            this.pnlMain.TabIndex = 0;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoD.Location = new System.Drawing.Point(20, 176);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(45, 27);
            this.rdoD.TabIndex = 5;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D.";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoC.Location = new System.Drawing.Point(20, 141);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(45, 27);
            this.rdoC.TabIndex = 4;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C.";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoB.Location = new System.Drawing.Point(20, 106);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(44, 27);
            this.rdoB.TabIndex = 3;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B.";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoA.Location = new System.Drawing.Point(20, 71);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(45, 27);
            this.rdoA.TabIndex = 2;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A.";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionText.AutoSize = false;
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestionText.Location = new System.Drawing.Point(58, 18);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(820, 48);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Question text";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNo.Location = new System.Drawing.Point(17, 18);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(25, 23);
            this.lblQuestionNo.TabIndex = 0;
            this.lblQuestionNo.Text = "1.";
            // 
            // UcChoiceQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UcChoiceQuestion";
            this.Size = new System.Drawing.Size(980, 220);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoD;
    }
}