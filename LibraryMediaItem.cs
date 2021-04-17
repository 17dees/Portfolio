// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    public abstract class LibraryMediaItem : LibraryItem
    {
        public string Title;
        public string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public string CallNumber;
        public double duration;
        public MediaType medium;

        
        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }
        // Precondition:  none
        // Postcondition: The media item has been initialized with the following
        //                7 parameters
        public LibraryMediaItem(string _title, string _publisher, int _copyrightYear
            , int _loanPeriod, string _callNumber, double theDuration, MediaType theMedium)
            :base(_title, _publisher, _callNumber, _copyrightYear, _loanPeriod)
        {
            Title = _title;
            Publisher = _publisher;
            CopyrightYear = _copyrightYear;
            LoanPeriod = _loanPeriod;
            CallNumber = _callNumber;
            Duration = theDuration;
            Medium = theMedium;
        }
        // Precondition: none
        // Postcondition: gets and sets the length for the media items
        public double Duration
        {
            // Precondition:  None
            // Postcondition: The duration of the media items is returned
            get
            {
                return duration;
            }
            // Precondition:  value must be greater than 0
            // Postcondition: The duration is outputted or thrown
            set
            {
                if (value >= 0)
                    duration = value;
                else
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Duration)}, contains an invalid value!");
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the type of medium
        public abstract MediaType Medium { get; set;}

        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Duration: {Duration}{NL}Media Type: {Medium}";
        }
    } 
}
