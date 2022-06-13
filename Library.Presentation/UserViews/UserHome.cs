using Library.Presentation.UserViews;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Forms;

namespace Library.Presentation
{
    public partial class UserHome : MaterialForm
    {
            int bookID;
            bool select_validation = false;

        public UserHome()
        {
            InitializeComponent();
            SetValueOnProfile();
            Helpers.DataGridManager.InitializeAllBookDataGrid(BookDataGrid);
            Helpers.DataGridManager.InitializeMyWishBookDataGrid(wishBookDataGrid);
            Helpers.DataGridManager.InitializeMyReservationDataGrid(myReservationDataGrid);
            Helpers.DataGridManager.InitializeMyRentalsDataGrid(myRentalsDataGrid);
            Helpers.DataGridManager.InitializeTopRatingBooksDataGrid(topRatingBooksDataGrid);
            Helpers.ComboBoxManager.SetValuesToBooksComboBox(bookAddRatingComboBox);
            Helpers.ComboBoxManager.SetValuesToISBNComboBox(ISBNAddRatingComboBox);
            //Helpers.MultilineTextBoxManager.InitializeHomeTabDescription(homeDescriptionMultilineTextBox);
            // welcomeLabelUserHome.DataBindings.Control.ForeColor = Color.Red;
            //welcomeLabelUserHome.Font.Bold = true;
        }
        //User ---> Home
        private void AddRaiting_Click(object sender, EventArgs e)
        {
            var book = bookAddRatingComboBox.Text;
            var isbn = Convert.ToInt32(ISBNAddRatingComboBox.Text);
            var rating = Convert.ToDecimal(assessmentTextBox.Text);
            try
            {
                Bussiness.Books.RateBook(book, isbn, Program.Current.User.UserID, rating); // message box kad snimam ili nesto nije dobro, i da to stavim na Book formu

            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Error occured");
            }
        }
        public void SetValueOnProfile()
        {
            FirstNameTextBox.Text = Program.Current.User.FirstName;
            LastNameTextBox.Text = Program.Current.User.LastName;
            EmailTextBox.Text = Program.Current.User.Email;
            
            IndexNumberTextBox.Enabled = true;
            IndexNumberTextBox.Text = Program.Current.User.IndexNumber;
            IndexNumberTextBox.Enabled = false;
            PhoneTextBox.Text = Program.Current.User.Phone;
        }
        private void rentalsTab_Click(object sender, EventArgs e)
        {
            var books = Bussiness.Rentals.FindRentals(Program.Current.User);
        }
        private void addWishBookButton_Click(object sender, EventArgs e)
        {
            var wishBook = wishBookTextBox.Text;
            var wishBookAuthor = wishAuthorTextBox.Text;
            var wishBookIsbn = Convert.ToInt32(wishISBNTextBox.Text);

            Bussiness.WishBooks.AddBookToWishList(wishBook,wishBookAuthor,wishBookIsbn);
            Helpers.DataGridManager.InitializeWishBookDataGrid(wishBookDataGrid);
        }
        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var email = EmailTextBox.Text;
            var phone = PhoneTextBox.Text;

            Bussiness.Users.ChangeProfile(firstName, lastName, email, phone);
            
        }
        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            if (select_validation == false)
            {
                MaterialMessageBox.Show("Please select book");
            }
            else
            {       
                using (var form = new ReservationDate())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        DateTime dateTimeFrom = form.dateTimeFrom;
                        DateTime dateTimeTo = form.dateTimeTo;
                        Bussiness.Reservation.AddReservation(bookID, dateTimeFrom, dateTimeTo);
                    }
                }
            }
        }
        private void BookDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, BookDataGrid);
          
            select_validation = true;
        }


        private void onlyActiveMyRentalsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onlyActiveMyRentalsCheckBox.Checked)
            {
                Helpers.DataGridManager.InitializeOnlyMyActiveRentalsDataGrid(myRentalsDataGrid);
            }
            else
            {
                Helpers.DataGridManager.InitializeMyRentalsDataGrid(myRentalsDataGrid);
            }
        }

        private void wishBookDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToCsvReservation_Click(object sender, EventArgs e)
        {
            Bussiness.Books.SaveBooksToCsv(BookDataGrid);
            MaterialMessageBox.Show("File was saved");
        }
    }
}
