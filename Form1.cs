//Grading ID: J8143
//Lab 7
//Due: Sunday Novmber 9, 2019
//CIS 199-01
//This lab tells you how much you have to invest today to get the amount of money you want

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        //What happens when  you click the calculate button
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            double Future;  //Holds what the user enters for future value
            double Rate;    //Holds what the user enters for the Rate
            int Year;       //Holds what the user enters for years


            //If to make sure TryPArse works
            if(double.TryParse(txtFurtureValue.Text, out Future) == true && double.TryParse(txtRate.Text, out Rate) == true && int.TryParse(txtYear.Text, out Year) == true)
            {
                lblAnswer.Text = $"{CalcPresentValue(Future, Rate, Year):c}"; //Calling the method
            }
            
            //Method to calcualte present value
            double CalcPresentValue(double future, double rate, int year)
            {
                double answer;          //The present value
                double pow = 1 + rate;  //Demoinator of the formula

                answer = future / Math.Pow(pow, year); //Present value formula

                return answer;
            }


        }
    }
}
