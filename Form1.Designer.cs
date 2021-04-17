namespace Lab_4
{
    partial class LabThreeForm
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
            this.AcceptedButton = new System.Windows.Forms.Button();
            this.GPALAbel = new System.Windows.Forms.Label();
            this.AdmissionTSLabel = new System.Windows.Forms.Label();
            this.AcceptLabel = new System.Windows.Forms.Label();
            this.RejectLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.GPAInput = new System.Windows.Forms.TextBox();
            this.ScoreInput = new System.Windows.Forms.TextBox();
            this.AccRej = new System.Windows.Forms.TextBox();
            this.NumAccepted = new System.Windows.Forms.TextBox();
            this.NumReject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AcceptedButton
            // 
            this.AcceptedButton.Location = new System.Drawing.Point(396, 42);
            this.AcceptedButton.Name = "AcceptedButton";
            this.AcceptedButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptedButton.TabIndex = 0;
            this.AcceptedButton.Text = "Accepted";
            this.AcceptedButton.UseVisualStyleBackColor = true;
            this.AcceptedButton.Click += new System.EventHandler(this.AcceptedButton_Click);
            // 
            // GPALAbel
            // 
            this.GPALAbel.AutoSize = true;
            this.GPALAbel.Location = new System.Drawing.Point(91, 28);
            this.GPALAbel.Name = "GPALAbel";
            this.GPALAbel.Size = new System.Drawing.Size(32, 13);
            this.GPALAbel.TabIndex = 1;
            this.GPALAbel.Text = "GPA:";
            this.GPALAbel.Click += new System.EventHandler(this.GPALAbel_Click);
            // 
            // AdmissionTSLabel
            // 
            this.AdmissionTSLabel.AutoSize = true;
            this.AdmissionTSLabel.Location = new System.Drawing.Point(66, 84);
            this.AdmissionTSLabel.Name = "AdmissionTSLabel";
            this.AdmissionTSLabel.Size = new System.Drawing.Size(112, 13);
            this.AdmissionTSLabel.TabIndex = 2;
            this.AdmissionTSLabel.Text = "Admission Test Score:";
            // 
            // AcceptLabel
            // 
            this.AcceptLabel.AutoSize = true;
            this.AcceptLabel.Location = new System.Drawing.Point(91, 194);
            this.AcceptLabel.Name = "AcceptLabel";
            this.AcceptLabel.Size = new System.Drawing.Size(44, 13);
            this.AcceptLabel.TabIndex = 3;
            this.AcceptLabel.Text = "Accept:";
            // 
            // RejectLabel
            // 
            this.RejectLabel.AutoSize = true;
            this.RejectLabel.Location = new System.Drawing.Point(91, 256);
            this.RejectLabel.Name = "RejectLabel";
            this.RejectLabel.Size = new System.Drawing.Size(41, 13);
            this.RejectLabel.TabIndex = 5;
            this.RejectLabel.Text = "Reject:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(91, 128);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result:";
            // 
            // GPAInput
            // 
            this.GPAInput.Location = new System.Drawing.Point(223, 21);
            this.GPAInput.Name = "GPAInput";
            this.GPAInput.Size = new System.Drawing.Size(100, 20);
            this.GPAInput.TabIndex = 8;
            // 
            // ScoreInput
            // 
            this.ScoreInput.Location = new System.Drawing.Point(223, 81);
            this.ScoreInput.Name = "ScoreInput";
            this.ScoreInput.Size = new System.Drawing.Size(100, 20);
            this.ScoreInput.TabIndex = 9;
            // 
            // AccRej
            // 
            this.AccRej.Location = new System.Drawing.Point(223, 125);
            this.AccRej.Name = "AccRej";
            this.AccRej.Size = new System.Drawing.Size(100, 20);
            this.AccRej.TabIndex = 10;
            // 
            // NumAccepted
            // 
            this.NumAccepted.Location = new System.Drawing.Point(223, 186);
            this.NumAccepted.Name = "NumAccepted";
            this.NumAccepted.Size = new System.Drawing.Size(100, 20);
            this.NumAccepted.TabIndex = 11;
            // 
            // NumReject
            // 
            this.NumReject.Location = new System.Drawing.Point(223, 249);
            this.NumReject.Name = "NumReject";
            this.NumReject.Size = new System.Drawing.Size(100, 20);
            this.NumReject.TabIndex = 12;
            // 
            // LabThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 397);
            this.Controls.Add(this.NumReject);
            this.Controls.Add(this.NumAccepted);
            this.Controls.Add(this.AccRej);
            this.Controls.Add(this.ScoreInput);
            this.Controls.Add(this.GPAInput);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.RejectLabel);
            this.Controls.Add(this.AcceptLabel);
            this.Controls.Add(this.AdmissionTSLabel);
            this.Controls.Add(this.GPALAbel);
            this.Controls.Add(this.AcceptedButton);
            this.Name = "LabThreeForm";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptedButton;
        private System.Windows.Forms.Label GPALAbel;
        private System.Windows.Forms.Label AdmissionTSLabel;
        private System.Windows.Forms.Label AcceptLabel;
        private System.Windows.Forms.Label RejectLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox GPAInput;
        private System.Windows.Forms.TextBox ScoreInput;
        private System.Windows.Forms.TextBox AccRej;
        private System.Windows.Forms.TextBox NumAccepted;
        private System.Windows.Forms.TextBox NumReject;
    }
}

