namespace Lab7
{
    partial class Lab7
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtFurtureValue = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Location = new System.Drawing.Point(27, 24);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(73, 13);
            this.lblFutureValue.TabIndex = 0;
            this.lblFutureValue.Text = "Furture Value:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(27, 67);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(107, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Annual Interest Rate:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(27, 108);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "No. of Years:";
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Location = new System.Drawing.Point(27, 172);
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.Size = new System.Drawing.Size(76, 13);
            this.lblPresentValue.TabIndex = 3;
            this.lblPresentValue.Text = "Present Value:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Location = new System.Drawing.Point(154, 171);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblAnswer.TabIndex = 4;
            // 
            // txtFurtureValue
            // 
            this.txtFurtureValue.Location = new System.Drawing.Point(154, 21);
            this.txtFurtureValue.Name = "txtFurtureValue";
            this.txtFurtureValue.Size = new System.Drawing.Size(100, 20);
            this.txtFurtureValue.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(154, 64);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(154, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(103, 213);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Calculate";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 245);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFurtureValue);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblPresentValue);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFutureValue);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPresentValue;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtFurtureValue;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnEnter;
    }
}

