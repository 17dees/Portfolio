//Grading Id:J1619
//Lab 4
//Due:9-29-19
//Course:CIS 199-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class LabThreeForm : Form
    {
        int acceptNum;   //holds the number of accpted
        private int rejectNum;   //holds the number of reject

        public int AccNum { get; private set; }
        public object AccRej { get; private set; }
        public int RejNum { get; private set; }

        public LabThreeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GPALAbel_Click(object sender, EventArgs e)
        {

        }

        private void AcceptedButton_Click(object sender, EventArgs e)
        {
            string accNum = "Accepted",
                Rej = "Rejected";
            //Valus for testing
            const int GpaMin = 0;
            const int GpaMax = 4;
            const int scoreMin = 0;
            const int ScoreMax = 100;
            const int GpaHigh = 3;
            const int ScoreLow = 60;
            const int ScoreHigh = 80;

            double Gpa,
                   Score;


            if(double.TryParse(GPAInput.Text, out Gpa) && Gpa >= GpaMin && Gpa <= GpaMax) //Test the Gpa in between 0 and 4
                if(double.TryParse(ScoreInput.Text, out Score) &&Score >= scoreMin && Score <= ScoreMax) //Test the score in between0 and 100
                {
                    if(Gpa >= GpaHigh)    //test if Gpa is >= the highest gpa allows lower test scores
                    {
                        if(Score >= ScoreLow)
                        {

                            AcceptRejectRule.Text = acc; //Write the accepted text in the accepted box
                            AccNum++;    //adds 1 count in the stored in the int value in the accNum

                        }
                        else
                        {
                            AccRej.Text = Rej;    //Write rejected text in the rejected box
                                RejNum++;     //Adds 1 count in the rejected box
                        }
                    }
                    else if(Score >= ScoreHigh)
                    {
                        .Text = Rej;  //Write rejected in the Rej string variable
                        RejNum++;                     // Add 1 count in stored int value in the accNum
                    }
                    else
                    {
                        AcceptRejectRule.Text = Rej;
                        RejNum++;
                    }
                }
            else
                {
                    MessageBox.Show("Please enter a valid Score");
                }
            else
            {
                MessageBox.Show("Please enter a valid Gpa");
            };

            NumAccept.Text = AccNum.ToString("F0");
            NumReject.Text = RejNum.ToString("F0");
        }
    }
}
