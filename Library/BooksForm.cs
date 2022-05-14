using Library.Business;
using Library.Data.Domain;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using static Library.LibraryDBDataSet1;

namespace Library
{
    public partial class BooksForm : Form
    {
        private UnitOfWork _unitOfWork;
        public BooksForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();

            
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDBDataSet1.Books);

            List<Genre> genres = new List<Genre>();
            genres = _unitOfWork.GenreRepository.GetAll();
            for (int i = 0; i < genres.Count; i++)
            {
                GenreCheckListBox.Items.Add(genres[i].Name);
            }
           

        }
        int bookId;
        private void BooksDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BooksDataGrid.SelectedRows)
            {
                bookId = (int)row.Cells[0].Value;

            }
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBooksForm booksForm = new AddBooksForm();
            booksForm.Show();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            var deleteBook = _unitOfWork.BookRepository.GetByID(bookId);
            if (deleteBook == null)
            {
                MessageBox.Show("Please select book.");
            }
            else
            {
                deleteBook.DeleteDate = DateTime.UtcNow;
                _unitOfWork.Save();
                MessageBox.Show("Book was successfully deleted!");
                foreach (DataGridViewRow row in BooksDataGrid.SelectedRows)
                {
                    BooksDataGrid.Rows.Remove(row);
                }

            }
        }

        private void UpdateBookButton_Click(object sender, EventArgs e)
        {
            Book updateBook = new Book { };
            updateBook = _unitOfWork.BookRepository.GetByID(bookId);
            if (updateBook == null)
            {
                MessageBox.Show("Please select book.");
                return;
            }
            else
            {
                AddBooksForm addBook = new AddBooksForm(updateBook);
                //addBook.MdiParent = this;
                addBook.Show();
            }
            BooksDataGrid.Update();
            BooksDataGrid.Refresh();
        }
        /*
        private void BooksDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = BooksDataGrid.Rows[indexRow];

            bookId = (int)row.Cells[0].Value;
        }
*/
        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            /*
            var search_book_text = string.IsNullOrEmpty(NameTextBox.Text) ? null : NameTextBox.Text;
            var search_author_text = string.IsNullOrEmpty(AuthorTextBox.Text) ? null : AuthorTextBox.Text;
            var search_isbn_text = string.IsNullOrEmpty(ISBNTextBox.Text) ? null : ISBNTextBox.Text;
           // var search_genre_text = string.IsNullOrEmpty(GenreCheckListBox.Text) ? null : GenreCheckListBox.Text;

       /*     var rentals = _unitOfWork.BookRepository.Get(r =>
            (search_book_text == null || r.Name == search_book_text) &&
            (search_author_text == null || (r.Author.Name.Contains(search_author_text))) &&
            (search_isbn_text == null || (r.ISBN.Contains(search_isbn_text))) &&
            (search_genre_text == null || (r.Genres.Contains(search_genre_text))),
            r => r.OrderBy(i => i.Name));
       */
        }
    }
}
