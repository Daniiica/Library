using Library.Business;
using Library.Data.Domain;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Presentation
{
    public partial class BookForm : MaterialForm
    {
        int bookID = 0;
        int authorID = 0;
        bool select_validation_author = false;
        private bool update_author;

        public BookForm()
        {
            InitializeComponent();
            InitializeListBoxs();
        }
        public BookForm(int bookid)
        {
            bookID = bookid;
            InitializeComponent();
            InitializeListBoxs();
            InitializeComponentForUpdateBook(bookID);
        }
        private void InitializeListBoxs()
        {
            Helpers.ComboBoxManager.SetValuesToAuthorComboBox(AuthorComboBox);
            Helpers.ComboBoxManager.SetValuesToPublisherComboBox(PublisherComboBox);
            Helpers.ComboBoxManager.SetValuesToLanguageComboBox(LanguageComboBox);
            Helpers.CheckListManager.InitializeCheckListGenres(GenreCheckBox);
            Helpers.DataGridManager.InitializeAuthorsDataGrid(AuthorsDataGrid);
        }
        private void InitializeComponentForUpdateBook(int bookID)
        {
            var book = Bussiness.Books.GetBookById(bookID);

            bookNameTextBox.Text = book.Name;
            AuthorComboBox.SelectedItem = book.Author.Name;
            DescriptionMultiLineBox.Text = book.Description;
            PublisherComboBox.SelectedItem = book.Publisher.Name;
            ISBNTextBox.Text = Convert.ToString(book.ISBN);
            LanguageComboBox.SelectedItem = book.Language.Caption;
            AmountTextBox.Text = Convert.ToString(book.Amount);
            Helpers.CheckListManager.SelectGenresInCheckList(book.Genres, GenreCheckBox);
        }
        private void InitializeComponentForUpdateAuthor(int authorID)
        {
            var author = Bussiness.Authors.GetAuthorById(authorID);
            AuthorNameTextBox.Text = author.Name;
            CountryTextBox.Text = author.Country;
            BiographyMultiLineTextBox.Text = author.Biography;
            DateOfBirthPicker.Value = author.DateOfBirth;
            if(author.DateOfDeath == null)
            {
                DateOfDeathPicker.Enabled = false;
            }
            else
            {
                DateTime date = Convert.ToDateTime(author.DateOfDeath); 
                DateOfDeathPicker.Value = date;
            }
        }

        private void OKBookButton_Click(object sender, EventArgs e)
        {
            var bookName = bookNameTextBox.Text;
            var author = AuthorComboBox.Text;
            var description = DescriptionMultiLineBox.Text;
            var publisher = PublisherComboBox.Text;
            var isbn = Convert.ToInt32(ISBNTextBox.Text);
            var language = LanguageComboBox.Text;
            var amount = AmountTextBox.Text;
            List<Genre> genres = Helpers.CheckListManager.GetSelectedGenresFromCheckList(GenreCheckBox);

            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(description)
                || string.IsNullOrEmpty(publisher) || (isbn == 0) || string.IsNullOrEmpty(language)
                || string.IsNullOrEmpty(amount) || (genres.Count == 0))
            {
                MaterialMessageBox.Show("Enter all data");
                return;
            }
            var bookAuthorID = Bussiness.Authors.GetAuthorIDByName(author);
            var bookPublisherID = Bussiness.Publisher.GetPublisherIDByName(publisher);
            var bookLanguageID = Bussiness.Languages.GetLanguageIDByCaption(language);

            if (bookID == 0)
            {
                Bussiness.Books.AddNewBook(bookName, bookAuthorID, description, bookPublisherID, isbn, bookLanguageID, amount, GenreCheckBox);

            }
            else
            {
                Bussiness.Books.UpdateBook(bookID, bookName, bookAuthorID, description, bookPublisherID, isbn, bookLanguageID, amount, GenreCheckBox);
                bookID = 0;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //BookForm ---> Author
        private void AuthorsDataGrid_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            authorID = Helpers.DataGridManager.SelectRowInDataGrid(sender, e, AuthorsDataGrid);
            if (authorID == 0)
            {
                return;
            }
            else
            {
                select_validation_author = true;
            }
        }

        private void DeleteAuthorButton_Click(object sender, EventArgs e)
        {
            if (select_validation_author == true)
            {
                Bussiness.Authors.DeleteAuthor(authorID);
                Helpers.DataGridManager.InitializeAuthorsDataGrid(AuthorsDataGrid);
                MaterialMessageBox.Show("Author deleted");
            }
            else
            {
                MaterialMessageBox.Show("Please select author");
                return;
            }
        }

        private void UpdateAuthorButton_Click(object sender, EventArgs e)
        {
            if (select_validation_author == true)
            {
                InitializeComponentForUpdateAuthor(authorID);
                update_author = false;
            }
            else
            {
                MaterialMessageBox.Show("Please select author");
                return;
            }
        }

        private void OKAuthorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AuthorNameTextBox.Text) ||
                string.IsNullOrEmpty(CountryTextBox.Text) ||
                string.IsNullOrEmpty(BiographyMultiLineTextBox.Text))
            {
                MaterialMessageBox.Show("Please enter all data");
                return;
            }
            if (DateOfBirthPicker.Value > DateOfDeathPicker.Value && DateOfDeathPicker.Enabled == true)
            {
                MaterialMessageBox.Show("Please select valid Date of Birth and Date Of Death");
                return;
            }
            var authorDeathDate = DateOfDeathPicker.Enabled == false ? (DateTime?) null : DateOfDeathPicker.Value;
            if (authorID != 0)
            {
                Bussiness.Authors.UpdateAuthor(authorID,
                    AuthorNameTextBox.Text,
                    CountryTextBox.Text,
                    BiographyMultiLineTextBox.Text,
                    DateOfBirthPicker.Value,
                    authorDeathDate);
                MaterialMessageBox.Show("Author updated");
                Helpers.DataGridManager.InitializeAuthorsDataGrid(AuthorsDataGrid);
                update_author = false;
            }
            else
            {
                Bussiness.Authors.AddAuthor(
                    AuthorNameTextBox.Text,
                    CountryTextBox.Text,
                    BiographyMultiLineTextBox.Text,
                    DateOfBirthPicker.Value,
                    authorDeathDate);
                MaterialMessageBox.Show("Author added");
                Helpers.DataGridManager.InitializeAuthorsDataGrid(AuthorsDataGrid);
            }
        }

        private void resetAuthorButton_Click(object sender, EventArgs e)
        {
            authorID = 0;
            AuthorNameTextBox.Text = "";
            CountryTextBox.Text = "";
            BiographyMultiLineTextBox.Text = "";
            DateOfBirthPicker.Value = DateTime.UtcNow;
            DateOfDeathPicker.Value = DateTime.UtcNow;
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Helpers.FormManager.OpenAdminHomeForm();
        }

        private void disableDateOfDeathAuthorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(disableDateOfDeathAuthorRadioButton.Checked)
            {
                DateOfDeathPicker.Enabled = false;
            }
            else
            {
                DateOfDeathPicker.Enabled = true;
            }
        }
    }
}
