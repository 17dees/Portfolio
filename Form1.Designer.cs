namespace Program2
{
    partial class Form1
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
            this.LastName = new System.Windows.Forms.Label();
            this.CreditHours = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.HoursInput = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(68, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(122, 13);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "First Letter of last name?";
            // 
            // CreditHours
            // 
            this.CreditHours.AutoSize = true;
            this.CreditHours.Location = new System.Drawing.Point(68, 125);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(183, 13);
            this.CreditHours.TabIndex = 1;
            this.CreditHours.Text = "How many credit hours do you have?";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(329, 58);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 4;
            // 
            // HoursInput
            // 
            this.HoursInput.Location = new System.Drawing.Point(329, 125);
            this.HoursInput.Name = "HoursInput";
            this.HoursInput.Size = new System.Drawing.Size(100, 20);
            this.HoursInput.TabIndex = 5;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(232, 202);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Calculate!";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 245);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.HoursInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CreditHours);
            this.Controls.Add(this.LastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label CreditHours;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox HoursInput;
        private System.Windows.Forms.Button CalcButton;
    }
}

