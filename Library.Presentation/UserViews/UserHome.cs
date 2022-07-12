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
            if(rating > 5)
            {
                MaterialMessageBox.Show("Rating must be in range (0 - 5)");
                return;
            }
            try
            {
                Bussiness.Books.RateBook(book, isbn, Program.Current.User.UserID, rating); // message box kad snimam ili nesto nije dobro, i da to stavim na Book formu

            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Book and ISBN don't match!");
            }
            Helpers.DataGridManager.InitializeTopRatingBooksDataGrid(topRatingBooksDataGrid);
        }
        //User ---> Rentals
        private void rentalsTab_Click(object sender, EventArgs e)
        {
            var books = Bussiness.Rentals.FindRentals(Program.Current.User);
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
        //User ---> Profile
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
        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            var firstName = string.IsNullOrEmpty(FirstNameTextBox.Text) ? null : FirstNameTextBox.Text;
            var lastName = string.IsNullOrEmpty(LastNameTextBox.Text) ? null : LastNameTextBox.Text;
            var email = string.IsNullOrEmpty(EmailTextBox.Text) ? null : EmailTextBox.Text;
            var phone = string.IsNullOrEmpty(PhoneTextBox.Text) ? null : PhoneTextBox.Text;

            if (firstName == null || lastName == null || email == null || phone == null)
            {
                MaterialMessageBox.Show("Please enter all information.");
                return;
            }
            Bussiness.Users.ChangeProfile(firstName, lastName, email, phone);

        }
        //User ---> WishBook
        
        private void addWishBookButton_Click(object sender, EventArgs e)
        {
            var wishBook = string.IsNullOrEmpty(wishBookTextBox.Text) ? null : wishBookTextBox.Text;
            var wishBookAuthor = string.IsNullOrEmpty(wishAuthorTextBox.Text) ? null : wishAuthorTextBox.Text;
            var wishBookIsbn = string.IsNullOrEmpty(wishISBNTextBox.Text) ? null : wishISBNTextBox.Text;

            Bussiness.WishBooks.AddBookToWishList(wishBook, wishBookAuthor, Convert.ToInt32(wishBookIsbn));
            Helpers.DataGridManager.InitializeMyWishBookDataGrid(wishBookDataGrid);
        }
        //User ---> Reservation
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
                Helpers.DataGridManager.InitializeMyReservationDataGrid(myReservationDataGrid);
            }
        }
        private void BookDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, BookDataGrid);
          
            select_validation = true;
        }
        private void saveToCsvReservation_Click(object sender, EventArgs e)
        {
            Bussiness.Books.SaveBooksToCsv(BookDataGrid);
            
        }
    }
}
