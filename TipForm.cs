// Lab 2
// CIS 199-XX
// Due: 9/15/2019
// By: Andrew L. Wright (students use Grading ID)

// This program prompts the user for the price of a meal
// and then calculates 3 different tip amounts, 15%,
// 18%, and 20%.

// Solution B
// This version uses the Form's Load event
// to programmatically change the tip rate label controls.
// Also has set the Form's AcceptButton property, so 
// can hit enter in textbox and cause calcTipBtn
// to be clicked. Neither is required. Switched
// from decimal to float, just to show how to use.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class TipForm : Form
    {
        // These must be fields now to be seen in both the Load
        // event and the button's Click event handler. Could be
        // public here, too, without risk, since const can't change.
        private const float TIPRATE1 = 0.15f; // 15% rate
        private const float TIPRATE2 = 0.18f; // 18% rate
        private const float TIPRATE3 = 0.20f; // 20% rate

        public TipForm()
        {
            InitializeComponent();
        }

        // Calculate and display tips
        private void calcTipBtn_Click(object sender, EventArgs e)
        {
            float price; // Price of meal
            float tip1;  // Tip amount for rate 1
            float tip2;  // Tip amount for rate 2
            float tip3;  // Tip amount for rate 3

            // Convert input into decimal
            price = float.Parse(priceTxt.Text);

            // Calculate tip amounts
            tip1 = TIPRATE1 * price;
            tip2 = TIPRATE2 * price;
            tip3 = TIPRATE3 * price;

            // Display tip amounts
            tip1Lbl.Text = $"{tip1:C}";
            tip2Lbl.Text = $"{tip2:C}";
            tip3Lbl.Text = $"{tip3:C}";
        }

        // Add the tip rates into labels on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            rate1Lbl.Text = $"{TIPRATE1:P0}"; // Percent format with no decimals
            rate2Lbl.Text = $"{TIPRATE2:P0}";
            rate3Lbl.Text = $"{TIPRATE3:P0}";
        }
    }
}
