// Grading ID: T6181
// Program 3
// 4/3/2020
// Selects the book in which to edit
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditBookForm : Form
    {
        private List<LibraryBook> _books; //Declares the book variable
        public EditBookForm(List<LibraryBook> bookList) //Declares the list of books
        {
            InitializeComponent();
            _books = bookList; // Matches the book variable to the list of books
        }
        //Precondition: none
        //Postcondition: Outputs the list of books when the user clicks on the combo box
        private void EditBookForm_Load(object sender, EventArgs e) 
        {
            foreach (LibraryBook book in _books) 
                bookCombo.Items.Add($"{book.Author}, {book.CallNumber}, {book.CopyrightYear}," +
                    $"{book.LoanPeriod}, {book.Patron}, {book.Publisher}, {book.Title}");
        }
        public int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return bookCombo.SelectedIndex;
            }
        }
        //Precondition: none
        //Postcondition: Outputs the values of the selected book into the edit book form
        private void bookButton_Click(object sender, EventArgs e)
        {
            LibraryBook b = _lib._patrons[BookIndex];

            BookForm pf = new BookForm();

            pf.BookAuthor = b.Author;

            pf.ItemCopyrightYear = b.CopyrightYear;

            pf.ItemCallNumber = b.CallNumber;

            pf.ItemLoanPeriod = b.LoanPeriod;

            pf.ItemPublisher = b.Publisher;

            pf.ItemTitle = b.Title;

            DialogResult result = pf.ShowDialog();
            //Precondition: The result is valid
            //Postcondition: Outputs the values of the selected book into the edit book form
            if (result == DialogResult.OK)
            {
                b.Author = pf.BookAuthor;

                b.CopyrightYear = pf.ItemCopyrightYear;

                b.CallNumber = pf.ItemCallNumber;

                b.LoanPeriod = pf.ItemLoanPeriod;

                b.Publisher = pf.ItemPublisher;

                b.Title = pf.ItemTitle;
            }
        }
    }
}
