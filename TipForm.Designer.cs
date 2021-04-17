namespace Lab2
{
    partial class TipForm
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
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.rate1Lbl = new System.Windows.Forms.Label();
            this.tip1Lbl = new System.Windows.Forms.Label();
            this.tip2Lbl = new System.Windows.Forms.Label();
            this.rate2Lbl = new System.Windows.Forms.Label();
            this.tip3Lbl = new System.Windows.Forms.Label();
            this.rate3Lbl = new System.Windows.Forms.Label();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(40, 13);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(98, 13);
            this.priceLbl.TabIndex = 0;
            this.priceLbl.Text = "Enter price of meal:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(141, 10);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 1;
            // 
            // rate1Lbl
            // 
            this.rate1Lbl.AutoSize = true;
            this.rate1Lbl.Location = new System.Drawing.Point(111, 42);
            this.rate1Lbl.Name = "rate1Lbl";
            this.rate1Lbl.Size = new System.Drawing.Size(29, 13);
            this.rate1Lbl.TabIndex = 2;
            this.rate1Lbl.Text = "XX%";
            // 
            // tip1Lbl
            // 
            this.tip1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip1Lbl.Location = new System.Drawing.Point(141, 41);
            this.tip1Lbl.Name = "tip1Lbl";
            this.tip1Lbl.Size = new System.Drawing.Size(100, 20);
            this.tip1Lbl.TabIndex = 3;
            // 
            // tip2Lbl
            // 
            this.tip2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip2Lbl.Location = new System.Drawing.Point(141, 79);
            this.tip2Lbl.Name = "tip2Lbl";
            this.tip2Lbl.Size = new System.Drawing.Size(100, 20);
            this.tip2Lbl.TabIndex = 5;
            // 
            // rate2Lbl
            // 
            this.rate2Lbl.AutoSize = true;
            this.rate2Lbl.Location = new System.Drawing.Point(111, 80);
            this.rate2Lbl.Name = "rate2Lbl";
            this.rate2Lbl.Size = new System.Drawing.Size(29, 13);
            this.rate2Lbl.TabIndex = 4;
            this.rate2Lbl.Text = "XX%";
            // 
            // tip3Lbl
            // 
            this.tip3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip3Lbl.Location = new System.Drawing.Point(141, 118);
            this.tip3Lbl.Name = "tip3Lbl";
            this.tip3Lbl.Size = new System.Drawing.Size(100, 20);
            this.tip3Lbl.TabIndex = 7;
            // 
            // rate3Lbl
            // 
            this.rate3Lbl.AutoSize = true;
            this.rate3Lbl.Location = new System.Drawing.Point(111, 119);
            this.rate3Lbl.Name = "rate3Lbl";
            this.rate3Lbl.Size = new System.Drawing.Size(29, 13);
            this.rate3Lbl.TabIndex = 6;
            this.rate3Lbl.Text = "XX%";
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.AutoSize = true;
            this.calcTipBtn.Location = new System.Drawing.Point(103, 163);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(79, 23);
            this.calcTipBtn.TabIndex = 8;
            this.calcTipBtn.Text = "Calculate Tip";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            this.calcTipBtn.Click += new System.EventHandler(this.calcTipBtn_Click);
            // 
            // TipForm
            // 
            this.AcceptButton = this.calcTipBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.tip3Lbl);
            this.Controls.Add(this.rate3Lbl);
            this.Controls.Add(this.tip2Lbl);
            this.Controls.Add(this.rate2Lbl);
            this.Controls.Add(this.tip1Lbl);
            this.Controls.Add(this.rate1Lbl);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLbl);
            this.Name = "TipForm";
            this.Text = "Lab 2 - Solution B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label rate1Lbl;
        private System.Windows.Forms.Label tip1Lbl;
        private System.Windows.Forms.Label tip2Lbl;
        private System.Windows.Forms.Label rate2Lbl;
        private System.Windows.Forms.Label tip3Lbl;
        private System.Windows.Forms.Label rate3Lbl;
        private System.Windows.Forms.Button calcTipBtn;
    }
}

