namespace TOEIC_Practice.GUI
{
    partial class UcP5_SingleQuestion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.grpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(118, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Câu ? / Part 5";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuestion.Location = new System.Drawing.Point(13, 38);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(760, 70);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAnswers.Controls.Add(this.rdoD);
            this.grpAnswers.Controls.Add(this.rdoC);
            this.grpAnswers.Controls.Add(this.rdoB);
            this.grpAnswers.Controls.Add(this.rdoA);
            this.grpAnswers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAnswers.Location = new System.Drawing.Point(13, 118);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(760, 130);
            this.grpAnswers.TabIndex = 2;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Chọn đáp án";
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(14, 101);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(99, 27);
            this.rdoD.TabIndex = 3;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D. (chưa)";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.Answer_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(14, 74);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(98, 27);
            this.rdoC.TabIndex = 2;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C. (chưa)";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.Answer_CheckedChanged);
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(14, 47);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(97, 27);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B. (chưa)";
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.Answer_CheckedChanged);
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(14, 20);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(98, 27);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A. (chưa)";
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.Answer_CheckedChanged);
            // 
            // UcP5_SingleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblHeader);
            this.Name = "UcP5_SingleQuestion";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(790, 265);
            this.Load += new System.EventHandler(this.UcP5_SingleQuestion_Load);
            this.grpAnswers.ResumeLayout(false);
            this.grpAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoD;
    }
}