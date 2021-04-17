// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    public class LibraryMovie : LibraryMediaItem
    {
        const double DVDFee = 1.00;
        const double BluRayFee = 1.50;
        public new string Title;
        public new string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public new string CallNumber;
        public new double Duration;
        public string _Director;
        public LibraryMediaItem.MediaType _Medium;
        public MPAARatings _Rating;


        // Precondition:  none
        // Postcondition: The movie has been initialized with the following
        //                7 parameters
        public LibraryMovie(string _title, string _publisher, int _copyrightYear, int _loanPeriod
            , string _callNumber, double theDuration, string theDirector,
            LibraryMediaItem.MediaType theMedium, MPAARatings theRating)
            :base(_title, _publisher, _copyrightYear, _loanPeriod, _callNumber, theDuration, theMedium)
        {
            Title = _title;
            Publisher = _publisher;
            CopyrightYear = _copyrightYear;
            LoanPeriod = _loanPeriod;
            CallNumber = _callNumber;
            Duration = theDuration;
            Director = theDirector;
            Medium = theMedium;
            Rating = theRating;
        }
        public enum MPAARatings { G, PG, PG13, R, NC17, U }
        // Precondition: none
        // Postcondition: gets and sets the value for the name of the director
        public string Director
        {
            // Precondition:  None
            // Postcondition: The name of the director is returned
            get
            {
                return _Director;
            }
            // Precondition:  value must be not null or have white space
            // Postcondition: The author's name is outputted or thrown
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                        $"{nameof(Director)} must not be null or empty");
                else
                    _Director = value.Trim();
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the type of medium
        public new LibraryMediaItem.MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The type of medium is returned
            get
            {
                return _Medium;
            }
            // Precondition:  value must equal DVD, BLURAY, or VHS
            // Postcondition: The type of medium is outputted or thrown
            set
            {
                if (value == MediaType.DVD)
                    _Medium = value;
                else if (value == MediaType.BLURAY)
                    _Medium = value;
                else if (value == MediaType.VHS)
                    _Medium = value;
                else
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(Medium)}, contains an invalid value!");

            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the type of rating
        public MPAARatings Rating
        {
            // Precondition:  None
            // Postcondition: The type of rating is returned
            get
            {
                return _Rating;
            }
            // Precondition:  none
            // Postcondition: The type of rating is stored
            set
            {
               _Rating = value;
            }

        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the movies
        public override void CalcLateFee()
        {
            Console.WriteLine($"Fee is {DVDFee} per day for DVD and VHS" +
                $"Fee is {BluRayFee} for BLURAY");
        }
        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Rating: {Rating}{NL}Media Type: {Medium} Director: {Director}";
        }
    } 
}
