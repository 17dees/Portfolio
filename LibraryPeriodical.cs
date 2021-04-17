// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    class LibraryPeriodical : LibraryItem
    {
        public string Title;
        public string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public string CallNumber;
        public int _Volume;
        public int _Number;
        // Precondition:  none
        // Postcondition: The journal has been initialized with the following
        //               7 parameters
        public LibraryPeriodical(string _title, string _publisher, int _copyrightYear, int _loanPeriod
              , string _callNumber, int theVolume, int theNumber)
            :base(_title, _publisher, _callNumber, _copyrightYear, _loanPeriod)
        {
            Volume = theVolume;
            Number = theNumber;
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the volume level
        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume level is returned
            get
            {
                return _Volume;
            }
            // Precondition:  value must be greater than 1
            // Postcondition: The volume level is outputted or thrown
            set
            {
                if (value >= 1)
                    Volume = value;
                else
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Volume)}, contains an invalid value!");
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the periodical number
        public int Number
        {
            // Precondition:  None
            // Postcondition: The number value is returned
            get
            {
                return _Number;
            }
            // Precondition:  value must be greater than 1
            // Postcondition: The number is outputted or thrown
            set
            {
                if (value >= 1)
                    Number = value;
                else
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Number)}, contains an invalid value!");
            }
        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the periodicals
        public override void CalcLateFee()
        {

        }

        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Volume: {Volume}{NL}Number: {Number}";

        }
    }
}
