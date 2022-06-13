using FileHelpers;
using Library.Business;
using Library.Data.DataContext;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;


namespace Library.Presentation.Bussiness
{
    public class Books
    {
        public static List<BookModel> GetAllBooks()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var books = _unitOfWork.BookRepository.Get(b => b.DeleteDate == null).Select(i => new BookModel   // select prolazi kroz svaki objekat i premapira
            {
                BookID = i.BookID,
                Description = i.Description,
                ISBN = i.ISBN,
                AuthorID = i.AuthorID,
                LanguageID = i.LanguageID,
                Language = i.Language.Caption,
                Publisher = i.Publisher.Name,
                Author = i.Author.Name,
                PublisherID = i.PublishingHouseId,
                Name = i.Name,
                Amount = i.Amount,
                Genres = string.Join(", ", from item in i.Genres select item.Name)
        }).ToList();
            return books;
        }
        public static Book GetBookById(int bookID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var book = _unitOfWork.BookRepository.Get(b => b.BookID == bookID).FirstOrDefault();
            return book;
        }
        public static List<Genre> GetSelectedGenresFromCheckList(UnitOfWork _unitOfWork, MaterialCheckedListBox genreCheckBox)
        {
            List<Genre> search_book_genres = new List<Genre>();
            Genre genres;
            foreach (var item in genreCheckBox.Items)
            {
                if (item.Checked)
                {
                    genres = _unitOfWork.GenreRepository.Get(g => g.Name == item.Text).Single();
                    search_book_genres.Add(genres);
                }
            }
            return search_book_genres;
        }
        public static void AddNewBook(string bookName, int bookAuthorID, string description, int bookPublisherID, int isbn, int bookLanguageID, string amount,MaterialCheckedListBox genreCheckedListBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existBook = _unitOfWork.BookRepository.Get(b => b.Name == bookName && b.AuthorID == bookAuthorID && b.ISBN == isbn && b.PublishingHouseId == bookPublisherID).FirstOrDefault();
            if (existBook != null)
            {
                MaterialMessageBox.Show("Book already exists");
                return;
            }
           var search_book_genres = GetSelectedGenresFromCheckList(_unitOfWork, genreCheckedListBox);

            Book bookForAdd = new Book
            {
                Name = bookName,
                AuthorID = bookAuthorID,
                PublishingHouseId = bookPublisherID,
                Description = description,
                ISBN = isbn,
                LanguageID = bookLanguageID,
                Amount = Convert.ToInt32(amount),
                Genres = search_book_genres, //new List<Genre>(genres.Select(s => new Genre { GenreID = s.GenreID , Name = s.Name})),
                InsertDate = DateTime.Now,
                DeleteDate = null
            };
            _unitOfWork.BookRepository.Insert(bookForAdd);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Book added");
        }
        public static void UpdateBook(int bookID, string bookName, int authorID, string description, int publisherID, int isbn, int languageID, string amount, MaterialCheckedListBox genreCheckedListBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existBook = _unitOfWork.BookRepository.Get(b => b.BookID != bookID && b.Name == bookName && b.AuthorID == authorID && b.ISBN == isbn && b.PublishingHouseId == publisherID).FirstOrDefault();
            if (existBook != null)
            {
                MaterialMessageBox.Show("Book already exists");
                return;
            }
            var search_book_genres = GetSelectedGenresFromCheckList(_unitOfWork, genreCheckedListBox);

            Book book = _unitOfWork.BookRepository.Get(b => b.BookID == bookID).FirstOrDefault();

            book.Name = bookName;
            book.AuthorID = authorID;
            book.PublishingHouseId = publisherID;
            book.Description = description;
            book.ISBN = isbn;
            book.LanguageID = languageID;
            book.Amount = Convert.ToInt32(amount);
            book.Genres.Clear();
            foreach (var item in search_book_genres)
            {
                book.Genres.Add(item);
            }
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Book updated");
        }
        public static List<BookModel> GetSearchedBooks(string search_book_name, int search_book_isbn, string search_book_author, List<Genre> search_book_genres)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var authors = _unitOfWork.AuthorRepository.Get(a => a.Name == search_book_author).FirstOrDefault();


            var books = _unitOfWork.BookRepository.Get(bb => bb.DeleteDate == null).Where(b =>
            (search_book_name == null || b.Name.Contains(search_book_name)) &&
            (search_book_isbn == 0 || (b.ISBN == search_book_isbn)) &&
            (search_book_author == null || (b.Author == authors)) && 
            (search_book_genres.Count == 0 || search_book_genres.All(x => b.Genres.Any(y => y.GenreID == x.GenreID)))) 
                          .Select(i => new BookModel
                          {
                              BookID = i.BookID,
                              Description = i.Description,
                              ISBN = i.ISBN,
                              AuthorID = i.AuthorID,
                              LanguageID = i.LanguageID,
                              Author = i.Author.Name,
                              Publisher = i.Publisher.Name,
                              Language = i.Language.Caption,
                              PublisherID = i.PublishingHouseId,
                              Name = i.Name,
                              Amount = i.Amount,
                              Genres = string.Join(", ", from item in i.Genres select item.Name)
                          }).ToList(); 
            return books;
        }
        public static void RateBook(string bookName, int isbn, int userID, decimal value)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var book = _unitOfWork.BookRepository.Get(b => b.Name == bookName && b.ISBN == isbn).FirstOrDefault();

            Raiting rating = new Raiting
            {
                BookID = book.BookID,
                UserID = userID,
                Assessment = value
            };
            var existsRaiting = _unitOfWork.RaitingsRepository.Get(r => r.BookID == rating.BookID && r.UserID == rating.UserID).FirstOrDefault();
            if (existsRaiting != null)
            {
                MaterialMessageBox.Show("Already rate this book");
                return;
            }
            _unitOfWork.RaitingsRepository.Insert(rating);
            _unitOfWork.Save();
            MessageBox.Show("Succesfull");
        }

        internal static void SaveBooksToCsv(DataGridView booksDataGrid)
        {
            var books = (from row in booksDataGrid.Rows.OfType<DataGridViewRow>()
                         select new BookModel()
                         {
                             Name = row.Cells["Name"].Value.ToString(),
                             Description = row.Cells["Description"].Value.ToString(),
                             Author = row.Cells["Author"].Value.ToString(),
                             Publisher = row.Cells["Publisher"].Value.ToString(),
                             Language = row.Cells["Language"].Value.ToString(),
                             ISBN = Convert.ToInt32(row.Cells["ISBN"].Value),
                             Amount = Convert.ToInt32(row.Cells["Amount"].Value),
                             Genres = row.Cells["Genres"].Value.ToString()
                         }).ToList();
            string path = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                FileName = "books",

                DefaultExt = "csv",
                //  Filter = "csv files (*.xlsx)|*.xlsx",
                //  FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                var engine = new FileHelperEngine<BookModel>();
                engine.HeaderText = engine.GetFileHeader();
                engine.WriteFile(path, books);
                MaterialMessageBox.Show("File was saved.");
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                MaterialMessageBox.Show("Problem with saving file.");
            }
        }

        public static void DeleteBook(int bookID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var book = _unitOfWork.BookRepository.GetByID(bookID);
            book.DeleteDate = DateTime.UtcNow;
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Save();
        }

        public static List<RaitingModel> TopRaitingBooks()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var allRaitings = _unitOfWork.RaitingsRepository.Get().GroupBy(l => l.BookID)
                .Select(i => new RaitingModel
                {
                    BookID = i.First().BookID,
                    Book = i.First().Book.Name,
                    Author = i.First().Book.Author.Name,
                    ISBN = i.First().Book.ISBN,
                    Publisher = i.First().Book.Publisher.Name,
                    Language = i.First().Book.Language.Caption,
                    Assessment = i.Sum(c => c.Assessment) / i.Count(),
                }).ToList();

            return allRaitings;
        }

    }
}
