// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    class LibraryJournal : LibraryPeriodical
    {
        const double journalFee = 0.75;
        public new string Title;
        public new string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public new string CallNumber;
        public new int Volume;
        public new int Number;
        public string _Discipline;
        public string _Editor;
        // Precondition:  none
        // Postcondition: The journal has been initialized with the following
        //               9 parameters
        public LibraryJournal(string _title, string _publisher, int _copyrightYear, int _loanPeriod
             , string _callNumber, int theVolume, int theNumber, string theDiscipline, string theEditor)
            :base(_title, _publisher, _copyrightYear, _loanPeriod, _callNumber, theVolume, theNumber)
        {
            Discipline = theDiscipline;
            Editor = theEditor;
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the type of discipline
        public string Discipline
        {
            // Precondition:  None
            // Postcondition: The discipline value is returned
            get
            {
                return _Discipline;
            }
            // Precondition:  value must be not null or have white space
            // Postcondition: The discipline is outputted or thrown
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} must not be null or empty");
                else
                    _Discipline = value.Trim();
            }
        }
        // Precondition: none
        // Postcondition: gets and sets name of the editor
        public string Editor
        {
           // Precondition: none
           // Postcondition: the editors name is returned
            get
            {
                return _Editor;
            }
            // Precondition: the value must not be null or have white space
            // Postcondition: the editors name is stored or thrown
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");
                else
                    _Editor = value.Trim();
            }
        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the Journals
        public override void CalcLateFee()
        {
            Console.WriteLine($"The fee is {journalFee} for journals");
        }
        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Discipline: {Discipline}{NL}Editor: {Editor}";

        }
    }
}
