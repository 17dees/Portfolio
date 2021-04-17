// Grading ID: J7186
// Program 2
// 10/16/19
// CIS 199-01
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            {
                float CreditHours; //Declares the credit hour variable
                char NameLetter; //Declares the letter variable 
                const int Senior = 90; //Sets senior hours  parameter
                const int Junior = 60; //Sets junior hours parameter
                const int Sophmore = 30; //Sets sophmore hours parameter
                const int Freshman = 0; //Sets freshman hours parameter


                string FirstDate = "Monday, November 4th"; //Sets the first date
                string SecondDate = "Tuesday, November 5th "; //Sets the second date
                string ThirdDate = "Wednesday, November 6th"; //Sets the third date
                string FourthDate = "Thursday, November 7th"; //Sets the fourth date
                string FifthDate = "Friday, November 8th"; //Sets the fifth date
                string SixthDate = "Monday, November 11th"; //Sets the sixth date


                string FirstTime = "8:30 AM"; //Sets the first time
                string SecondTime = "10:00 AM"; //Sets the second time
                string ThirdTime = "11:30 AM"; //Sets the third time
                string FourthTime = "2:00 PM"; //Sets the fourth time
                string FifthTime = "4:00 PM"; //Sets the fifth time

                NameLetter = Char.Parse(NameInput.Text); //Declares the value of the letter variable based on input
                NameLetter = char.ToLower(NameLetter);
                CreditHours = float.Parse(HoursInput.Text); //Declares the value of the credit hour variable based on input


               
                if (CreditHours >= Junior) //Sets the parameters for all juniors and seniors
                {
                    if (NameLetter >= 'p' && NameLetter <= 's') //Sets the parameters for the letters p and s
                    {
                        if (CreditHours >= Senior)
                            MessageBox.Show($"{FirstDate} at {FirstTime}"); //Output for seniors with last name starting with a letter between p and s

                        else if (CreditHours >= Junior && CreditHours < Senior) //Outputfor juniors whose last name start with a letter between p and s
                            MessageBox.Show($"{SecondDate} at {FirstTime}");
                    }
                    else if (NameLetter >= 't' && NameLetter <= 'z') //Sets the parameters for the letters t and z
                    {
                        if (CreditHours >= Senior)
                            MessageBox.Show($"{FirstDate} at {SecondTime}"); //Output for seniors with last name starting with a letter between t and z

                        else if (CreditHours >= Junior && CreditHours < Senior) //Output for juniors with last name starting with a letter between t and z
                            MessageBox.Show($"{SecondDate} at {SecondTime}");
                    }
                    else if (NameLetter >= 'a' && NameLetter <= 'd') //Sets the oarameters for the letters a and d
                    {
                        if (CreditHours >= Senior)  
                            MessageBox.Show($"{FirstDate} at {ThirdTime}"); //Output for seniors with last name starting with a letter between and d 
                        else if (CreditHours >= Junior && CreditHours < Senior)
                            MessageBox.Show($"{SecondDate} at {ThirdTime}"); //Output for juniors with last name starting with a letter between and d
                    }
                    else if (NameLetter >= 'e' && NameLetter <= 'i') //Sets the parameters for the letters e and i
                    {
                        if (CreditHours >= Senior)
                            MessageBox.Show($"{FirstDate} at {FourthTime}"); //Output for juniors with last name starting with a letter between e and i

                        else if (CreditHours >= Junior && CreditHours < Senior)
                            MessageBox.Show($"{SecondDate} at {FourthTime}"); //Output for seniors with last name starting with a letter between e and i
                    }
                    else if (NameLetter >= 'j' && NameLetter <= 'o') //Sets the parameters for the letters j and o
                    {
                        if (CreditHours >= Senior)
                            MessageBox.Show($"{FirstDate} at {FifthTime}"); //Output for seniors with last name starting with a letter between j and o

                        else if (CreditHours >= Junior && CreditHours < Senior) //Output for juniors with last name starting with a letter between j and o
                            MessageBox.Show($"{SecondDate} at {FifthTime}");
                    }
                }
                else if (CreditHours >= Freshman) //Sets the parameters for freshman and sophmores
                {
                    if (NameLetter >= 'p' && NameLetter <= 'q') //Sets the parameters for p and q
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{ThirdDate} at {FirstTime}"); //Output for sophmores with last name starting with a letter between p and q
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{FifthDate} at {FirstTime}"); //Output for freshman with last name starting with a letter between p and q
                    }
                    else if (NameLetter >= 'r' && NameLetter <= 's') //Sets the parameters for r and s 
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{ThirdDate} at {SecondTime}"); //Output for sophmores with last name starting with a letter between r and s
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{FifthDate} at {SecondTime}"); //Output for freshman with last name starting with a letter between r and s
                    }
                    else if (NameLetter >= 't' && NameLetter <= 'v') //Sets the parameters for t and v
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{ThirdDate} at {ThirdTime}"); //Output for sophmores with last name starting with a letter between t and v
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{FifthDate} at {ThirdTime}"); //Output for freshman with last name starting with a letter between t and v
                    }
                    else if (NameLetter >= 'w' && NameLetter <= 'z') //Sets the parameters for w and z
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{ThirdDate} at {FourthTime}"); //Output for sophmores with last name starting with a letter between w and z
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{FifthDate} at {FourthTime}"); //Output for freshman with last name starting with a letter between w and z
                    }
                    else if (NameLetter >= 'a' && NameLetter <= 'b') //Sets the parameters for a and b
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{ThirdDate} at {FifthTime}"); //Output for sophmores with last name starting with a letter between a and b
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{FifthDate} at {FifthTime}"); //Output for freshman with last name starting with a letter between a and b
                    }
                    else if (NameLetter >= 'c' && NameLetter <= 'd') //Sets the parameters for c and d
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{FourthDate} at {FirstTime}"); //Output for sophmores with last name starting with a letter between c and d
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{SixthDate} at {FirstTime}"); //Output for freshman with last name starting with a letter between c and d
                    }
                    else if (NameLetter >= 'e' && NameLetter <= 'f') //Sets the parameters for e and f
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{FourthDate} at {SecondTime}"); //Output for sophmores with last name starting with a letter between e and f
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{SixthDate} at {SecondTime}"); //Output for freshman with last name starting with a letter between e and f
                    }
                    else if (NameLetter >= 'g' && NameLetter <= 'i') //Sets the parameters for g and i
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{FourthDate} at {ThirdTime}"); //Output for sophmores with last name starting with a letter between g and i
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{SixthDate} at {ThirdTime}"); //Output for freshman with last name starting with a letter between g and i
                    }
                    else if (NameLetter >= 'j' && NameLetter <= 'l') //Sets the parameters for j and l
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{FourthDate} at {FourthTime}"); //Output for sophmores with last name starting with a letter between j and l
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{SixthDate} at {FourthTime}"); //Output for freshman with last name starting with a letter between j and l
                    }
                    else if (NameLetter >= 'm' && NameLetter <= 'o') //Sets the parameters for m and o
                    {
                        if (CreditHours >= Sophmore)
                            MessageBox.Show($"{FourthDate} at {FifthTime}"); //Output for sophmores with last name starting with a letter between m and o
                        else if (CreditHours >= Freshman)
                            MessageBox.Show($"{SixthDate} at {FifthTime}"); //Output for freshman with last name starting with a letter between m and o
                    }
                }
            }
    }
    }
}
