//Granding ID: T6181
//CIS 200-01
//4/3/2020
//Program 3
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
    public partial class EditPatronForm : Form
    {
        private List<LibraryPatron> _patrons; //Declares the patron variable
        public EditPatronForm(List<LibraryPatron> patronList) //Declares the patron list
        {
            InitializeComponent();
            _patrons = patronList; //Matches the patron variable to the list
        }
        //Precondition: none
        //Postcondition: Outputs the list of patrons when the user clicks on the combo box
        private void EditPatronForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patronBox.Items.Add($"{patron.PatronName}, {patron.PatronID}");
        }
        public int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return patronBox.SelectedIndex;
            }
        }
        //Precondition: none
        //Postcondition: Validates the combo box
        private void patronCbo_Validating(object sender, CancelEventArgs e)
        {
            if (patronBox.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider.SetError(patronBox, "Must select Patron");
            }
        }
        //Precondition: none
        //Postcondition: Outputs the values of the selected patron into the edit book form
        private void editButton_Click(object sender, EventArgs e)
        {
            LibraryPatron b = _lib._patrons[PatronIndex];

            PatronForm pf = new PatronForm();
            
            pf.PatronID = b.PatronID;
            
            pf.PatronName = b.PatronName;
            
            DialogResult result = pf.ShowDialog();

            if(result == DialogResult.OK)
            {
                b.PatronID = pf.PatronID;

                b.PatronName = pf.PatronName;
            }
        }
    }
}
