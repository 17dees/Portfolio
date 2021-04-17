// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01

using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    public abstract class LibraryItem
    {
        private string Title;
        private string Publisher;
        private string CallNumber;
        private int _CopyrightYear;
        private int _LoanPeriod;
        // Precondition:  none
        // Postcondition: The items have been initialized with the following
        //               5 parameters 
        public LibraryItem(string _title, string _publisher, string _callNumber, 
            int _copyrightYear, int _loanPeriod)
        {
            BookTitle = _title;
            BookPublisher = _publisher;
            CallNum = _callNumber;
            CopyrightYear = _copyrightYear;
            LoanPeriod = _loanPeriod;
            
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the book title
        public string BookTitle
        {
            // Precondition:  None
            // Postcondition: The title name is returned
            get
            {
                return Title;
            }
            // Precondition:  value must be not null or have white space
            // Postcondition: The title name is outputted or thrown
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(BookTitle)}", value,
                        $"{nameof(BookTitle)} must not be null or empty");
                else
                    Title = value.Trim();
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the book publisher
        public string BookPublisher
        {
            // Precondition:  None
            // Postcondition: The publisher name is returned
            get
            {
                return Publisher;
            }
            // Precondition:  value must be not null or have white space
            // Postcondition: The title name is outputted or thrown
            set
            {
                Publisher = (value == null ? string.Empty : value.Trim());
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the call number
        public string CallNum
        {
            // Precondition:  None
            // Postcondition: The call number is returned
            get
            {
                return CallNumber;
            }
            // Precondition:  value must be not null or have white space
            // Postcondition: The call number is outputted or thrown
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(CallNum)}", value,
                        $"{nameof(CallNum)} must not be null or empty");
                else
                    CallNumber = value.Trim();
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the copyright year
        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year is returned
            get
            {
                return _CopyrightYear;
            }
            // Precondition:  value must be greater than 0
            // Postcondition: The year is outputted or thrown
            set
            {
                if (value >= 0)
                    _CopyrightYear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
            }
        
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the loan period
        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The loan period is returned
            get
            {
                return _LoanPeriod;
            }
            // Precondition:  value must be greater than 0
            // Postcondition: The period is outputted or thrown
            set
            {
                if (value >= 0)
                    _LoanPeriod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
            }
        }
        public string Patron
        {
            // Precondition:  None
            // Postcondition: The book's patron has been returned
            get;  // Auto-implement is fine

            // Helper
            // Precondition:  None
            // Postcondition: The book's patron has been set to the specified value
             set; // Auto-implement is fine 
        }
        public void CheckOut(string thePatron)
        {
            if (thePatron != null)
                Patron = thePatron;
            else
                throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
        }

        // Precondition:  None
        // Postcondition: The book is not checked out
        public void ReturnToShelf()
        {
            Patron = null; // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return Patron != null; // The item is checked out if there is a Patron
        }

        //Precondition: none
        //Postcondition: abstract method, so none in this class
        public abstract void CalcLateFee();

        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Title: {Title}{NL}Publisher: {Publisher} Call Number: {CallNum}" +
                $"Copyright Year:{CopyrightYear} Loan Period: {LoanPeriod}";
        }


    }

}

    
    

