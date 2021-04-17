// Grading ID: T6181
// Program 1A
// 2/12/20
// CIS 200-01
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1A
{
    class LibraryMusic : LibraryMediaItem
    {
        const double musicFee = 0.50;
        public new string Title;
        public new string Publisher;
        public new int CopyrightYear;
        public new int LoanPeriod;
        public new string CallNumber;
        public new double Duration;
        public string _Artist;
        public LibraryMediaItem.MediaType _Medium;
        public int TotalTracks;

        // Precondition:  none
        // Postcondition: The music has been initialized with the following
        //                7 parameters
        public LibraryMusic(string _title, string _publisher, int _copyrightYear, int _loanPeriod
           , string _callNumber, double theDuration, string theArtist,
           LibraryMediaItem.MediaType theMedium, int theTotalTracks):
            base(_title, _publisher, _copyrightYear, _loanPeriod, _callNumber, theDuration, theMedium) // Constructor with 7 parameters and a base class
        {
            Artist = theArtist;
            Medium = theMedium;
            TrackCount = theTotalTracks;
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the Artist's name
        public string Artist
        {
            // Precondition:  None
            // Postcondition: The artist's name has been returned
            get
            {
                return _Artist;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The author's name has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                        $"{nameof(Artist)} must not be null or empty");
                else
                    _Artist = value.Trim();
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the type of medium
        public override LibraryMediaItem.MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The type of medium is returned
            get
            {
                return _Medium;
            }
            // Precondition:  value must equal CD, SACD, or VINYL
            // Postcondition: The type of medium is outputted or thrown
            set
            {
                if (value == MediaType.CD)
                    _Medium = value;
                else if (value == MediaType.SACD)
                    _Medium = value;
                else if (value == MediaType.VINYL)
                    _Medium = value;
                else
                    throw new ArgumentOutOfRangeException(
                                nameof(value), value, $"{nameof(Medium)}, contains an invalid value!");
            }
        }
        // Precondition: none
        // Postcondition: gets and sets the value for the total tracks
        public int TrackCount
        {
            // Precondition:  None
            // Postcondition: The total tracks is returned
            get
            {
                return TotalTracks;
            }
            // Precondition:  value must be greater than 1
            // Postcondition: The track count is outputted or thrown
            set
            {
                if (value >= 1)
                    TotalTracks = value;
                else
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(TrackCount)}, contains an invalid value!");
            }
        }
        //Precondition: none
        //Postcondition: Outputs the late fee for the music
        public override void CalcLateFee()
        {
            Console.WriteLine($"Fee for music is {musicFee} per day");
        }
        //Precondition: none
        //Postcondition: Puts the data in a string
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Total tracks: {TrackCount}{NL}Media Type: {Medium} Artist: {Artist}";

        }

    }
}
    
