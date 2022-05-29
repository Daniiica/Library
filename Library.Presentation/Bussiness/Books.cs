using FileHelpers;
using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library.Presentation.Bussiness
{
    public class Books
    {
        public static List<BookModel> GetAllBooks() {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var books = _unitOfWork.BookRepository.Get(b => b.DeleteDate == null).Select(i => new BookModel   // select prolazi kroz svaki objekat i premapira
            {
                BookID = i.BookID,
                Description = i.Description,
                ISBN = i.ISBN,
                AuthorID = i.AuthorID,
                LanguageID = i.LanguageID,
                Author = i.Author.Name,
                PublisherID = i.PublishingHouseId,
                Name = i.Name,
                Amount = i.Amount
            }).ToList();
            return books;
        }
        public static Book GetBookById(int bookID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var book = _unitOfWork.BookRepository.Get(b => b.BookID == bookID).FirstOrDefault();
            return book; 
        }
        public static void AddNewBook(string bookName, int authorID, string description, int publisherID, int isbn, int languageID, string amount, List<Genre> genres)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existBook = _unitOfWork.BookRepository.Get(b => b.Name == bookName && b.AuthorID == authorID && b.ISBN == isbn && b.PublishingHouseId == publisherID).FirstOrDefault();
            if(existBook != null)
            {
                MaterialMessageBox.Show("Book already exists");
                return;
            }
            Book bookForAdd = new Book
            {
                Name = bookName,
                AuthorID = authorID,
                PublishingHouseId = publisherID,
                Description = description,
                ISBN = isbn,
                LanguageID = languageID,
                Amount = Convert.ToInt32(amount),
                Genres = genres,
                InsertDate = DateTime.Now
            };
            _unitOfWork.BookRepository.Insert(bookForAdd);
            _unitOfWork.Save();
        }
        public static void UpdateBook(int bookID ,string bookName, int authorID, string description, int publisherID, int isbn, int languageID, string amount, List<Genre> genres)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existBook = _unitOfWork.BookRepository.Get(b => b.BookID != bookID &&  b.Name == bookName && b.AuthorID == authorID && b.ISBN == isbn && b.PublishingHouseId == publisherID).FirstOrDefault();
            if (existBook != null)
            {
                MaterialMessageBox.Show("Book already exists");
                return;
            }
            Book book = GetBookById(bookID);
            book.Name = bookName;
            book.AuthorID = authorID;
            book.PublishingHouseId = publisherID;
            book.Description = description;
            book.ISBN = isbn;
            book.LanguageID = languageID;
            book.Amount = Convert.ToInt32(amount);
            book.Genres = genres;
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Save();
        }
        public static List<BookModel> GetSearchedBooks(string search_book_name, int search_book_isbn, string search_book_author, List<Genre> search_book_genres)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var authors = _unitOfWork.AuthorRepository.Get(a => a.Name == search_book_author).FirstOrDefault();

            var books = _unitOfWork.BookRepository.Get(b =>
            (search_book_name == null || b.Name.Contains(search_book_name)) &&
            (search_book_isbn == 0 || (b.ISBN == search_book_isbn)) &&
            (search_book_author == null || (b.AuthorID == authors.AuthorID)) &&
            (search_book_genres.Count == 0 || search_book_genres.All(b.Genres.Contains)))//b.Genres.All(search_book_genres.Contains)))
                .Select(i => new BookModel
                {
                    BookID = i.BookID,
                    Description = i.Description,
                    ISBN = i.ISBN,
                    AuthorID = i.AuthorID,
                    LanguageID = i.LanguageID,
                    Author = i.Author.Name,
                    PublisherID = i.PublishingHouseId,
                    Name = i.Name,
                    Amount = i.Amount
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
            if(existsRaiting != null)
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
                               ISBN = Convert.ToInt32(row.Cells["ISBN"].Value),
                               Amount = Convert.ToInt32(row.Cells["Amount"].Value)
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

        public struct RaitingStruct
        {
            public int bookID;
            public decimal avgRaiting;
        }
        public static List<RaitingStruct> TopRaitingBooks()
        {
            /*     var raitings = _unitOfWork.RaitingsRepository.GetAll().Join(_unitOfWork.BookRepository.GetAll(),
                     raiting => raiting.BookID,
                     book => book.BookID,
                     (r,b) => new { Raiting = r, Book = b}).ToList(); // GroupBy(b => b.BookID);
             */
            UnitOfWork _unitOfWork = new UnitOfWork();

            var allRaitings = _unitOfWork.RaitingsRepository.GetAll().GroupBy(b => b.BookID);
            List<RaitingStruct> raitings = new List<RaitingStruct>();
            decimal sum = 0;
            int num = 0;
            RaitingStruct raiting = new RaitingStruct();
            foreach (var item in allRaitings)
            {
                foreach (var avg in item)
                {
                    sum += avg.Assessment;
                    num++;
                    raiting.bookID = avg.BookID;
                }
                sum = sum / num;
                raiting.avgRaiting = sum;
                raitings.Add(raiting);
                sum = 0;
                num = 0;
            }
            return raitings;
        }
        
    }
}
