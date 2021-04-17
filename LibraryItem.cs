using System;
using System.Collections.Generic;
using System.Text;

namespace Prog4
{
    class LibraryItems
    {
        public abstract class LibraryItem : IComparable<LibraryItem>
        {
            private string _title;      // The book's title
            private string _publisher;  // The book's publisher
            private int _copyrightYear; // The book's year of copyright
            private string _callNumber; // The book's call number in the library
            private int _loanPeriod;    // The item's loan period

            // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0
            //                theTitle and theCallNumber must not be null or empty
            // Postcondition: The library item has been initialized with the specified
            //                values for title, publisher, copyright year, loan period and
            //                call number. The item is not checked out.
            public LibraryItem(string theTitle, string thePublisher, int theCopyrightYear,
                int theLoanPeriod, string theCallNumber)
            {
                Title = theTitle;
                Publisher = thePublisher;
                CopyrightYear = theCopyrightYear;
                LoanPeriod = theLoanPeriod;
                CallNumber = theCallNumber;

                
            }

            public string Title
            {
                // Precondition:  None
                // Postcondition: The title has been returned
                get
                {
                    return _title;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The title has been set to the specified value
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                            $"{nameof(Title)} must not be null or empty");
                    else
                        _title = value.Trim();
                }
            }

            public string Publisher
            {
                // Precondition:  None
                // Postcondition: The publisher has been returned
                get
                {
                    return _publisher;
                }

                // Precondition:  None
                // Postcondition: The publisher has been set to the specified value
                set
                {
                    // Since empty publisher is OK, just change null to empty string
                    _publisher = (value == null ? string.Empty : value.Trim());
                }
            }

            public int CopyrightYear
            {
                // Precondition:  None
                // Postcondition: The copyright year has been returned
                get
                {
                    return _copyrightYear;
                }

                // Precondition:  value >= 0
                // Postcondition: The copyright year has been set to the specified value
                set
                {
                    if (value >= 0)
                        _copyrightYear = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                            $"{nameof(CopyrightYear)} must be >= 0");
                }
            }

            public string CallNumber
            {
                // Precondition:  None
                // Postcondition: The call number has been returned
                get
                {
                    return _callNumber;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The call number has been set to the specified value
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                            $"{nameof(CallNumber)} must not be null or empty");
                    else
                        _callNumber = value.Trim();
                }
            }

            public int LoanPeriod
            {
                // Precondition:  None
                // Postcondition: The loan period has been returned
                get
                {
                    return _loanPeriod;
                }

                // Precondition:  value >= 0
                // Postcondition: The loan period has been set to the specified value
                set
                {
                    if (value >= 0)
                        _loanPeriod = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                            $"{nameof(LoanPeriod)} must be >= 0");
                }
            }

            public int CompareTo(LibraryItem item)
            {
                if (item == null)
                    return 1;
                else  
                    return this.Title.CompareTo(item.Title);
            }

        }
    }
}
