// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    class LibraryMagazine : LibraryPeriodical
    {
        const double magazineFee = 0.25;
        public new string Title;
        public new string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public new string CallNumber;
        public new int Volume;
        public new int Number;
        // Precondition:  none
        // Postcondition: The magazine has been initialized with the following
        //                7 parameters
        public LibraryMagazine(string _title, string _publisher, int _copyrightYear, int _loanPeriod
              , string _callNumber, int theVolume, int theNumber)
            :base(_title, _publisher, _copyrightYear, _loanPeriod, _callNumber, theVolume, theNumber)
        {

        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the magazines
        public override void CalcLateFee()
        {
          Console.WriteLine($"The fee for magazines is {magazineFee}");
        }
        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Late Fee: {magazineFee}";

        }

    }
}
