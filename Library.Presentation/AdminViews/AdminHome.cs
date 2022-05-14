using Library.Business;
using Library.Data.Domain;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Presentation
{
    public partial class AdminHome : MaterialForm
    {
        UnitOfWork _unitOfWork;
        public AdminHome()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            var genres = _unitOfWork.GenreRepository.GetAll();
            foreach(var item in genres)
            {
                genreCheckedListBox.Items.Add(item.Name);
            }
            
        }

        private void searchBook_Click(object sender, System.EventArgs e)
        {
            var search_book_name = string.IsNullOrEmpty(bookTextBox.Text) ? null : bookTextBox.Text;
            var search_book_isbn = Convert.ToInt32(string.IsNullOrEmpty(isbnTextBox.Text) ? null : isbnTextBox.Text);
            var search_book_author = string.IsNullOrEmpty(authorTextBox.Text) ? null : authorTextBox.Text;
            List<Genre> search_book_genres = new List<Genre>();
            foreach (var item in genreCheckedListBox.Items)
            {
                if (item.Checked)
                {
                    search_book_genres.Add(_unitOfWork.GenreRepository.Get(g => g.Name == item.Text).FirstOrDefault());
                }
            }
            var authors = _unitOfWork.AuthorRepository.Get(a => a.Name == search_book_author).FirstOrDefault();

            var books = _unitOfWork.BookRepository.Get(b =>
            (search_book_name == null || b.Name.Contains(search_book_name)) &&
            (search_book_isbn == 0 || (b.ISBN == search_book_isbn)) &&
            (search_book_author == null || (b.AuthorID == authors.AuthorID))); // &&
           // (search_book_genres.Count == 0 || b.Genres.All(search_book_genres.Contains)));
        //    u => u.OrderBy(i => i.Name));

        }
    }
}
