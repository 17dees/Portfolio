// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    public class LibraryBook : LibraryItem
    {
        
        private string _Author;     // The book's author
        

        public LibraryBook(string _title, string _author, string _publisher
            , string _callNumber, int _copyrightYear, int _loanPeriod):
            base(_title,_publisher, _callNumber, _copyrightYear, _loanPeriod)
        {
            
            _Author = _author;
            
        }
        public string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _Author;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Author)}", value,
                        $"{nameof(Author)} must not be null or empty");
                else
                    _Author = value.Trim();

            }

        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the movies
        public override void  CalcLateFee()
        {

        }
        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Title:{LibraryItem.BookTitle}
        }
    }
}