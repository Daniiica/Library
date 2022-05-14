using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public static void RateBook(string bookName, int isbn, int userID, decimal value)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var book = _unitOfWork.BookRepository.Get(b => b.Name == bookName && b.ISBN == isbn).FirstOrDefault();

            Raiting rating = new Raiting();

            rating.BookID = book.BookID;
            rating.UserID = userID;
            rating.Assessment = value;

            _unitOfWork.RaitingsRepository.Insert(rating);
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
        public static void AddBookToWishList(string book, string author, int isbn)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var wishBook = new WishBook();

            wishBook.Name = book;
            wishBook.ISBN = isbn;
            wishBook.Author = author;
            wishBook.UserID = Program.Current.User.UserID;
            wishBook.ApproveDate = null;
            wishBook.DeleteDate = null;

            _unitOfWork.WishBookRepository.Insert(wishBook);
            _unitOfWork.Save();

        }
        public static List<WishBookModel> MyWishList()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var myWishBooks = _unitOfWork.WishBookRepository.Get(w => w.UserID == Program.Current.User.UserID)
                .Select(i => new WishBookModel   // select prolazi kroz svaki objekat i premapira
                {
                    Name = i.Name,
                    Author = i.Author,
                    UserID = i.UserID,
                    ApproveDate = i.ApproveDate,
                    DeleteDate = i.DeleteDate,
                    ISBN = i.ISBN
                }).ToList(); 
            return myWishBooks;
        }
        public static List<ReservationsModel> MyReservationList()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var myReservation = _unitOfWork.ReservationsBookRepository.Get(r => r.UserID == Program.Current.User.UserID)
            .Select(i => new ReservationsModel   // select prolazi kroz svaki objekat i premapira
             {
                 BookID = i.BookID,
                 BookName = i.Book.Name,
                 Author = i.Book.Author.Name,
                 ISBN = i.Book.ISBN,
                 UserID = i.UserID,
                 FromDate = i.FromDate,
                 ToDate = i.ToDate
             }).ToList();
            return myReservation;
        }
        public static void AddReservation(int bookID, DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            Reservations reservation = new Reservations();
            var reserveBook = _unitOfWork.BookRepository.Get(b => b.BookID == bookID).FirstOrDefault();

            reservation.Book = reserveBook;
            reservation.UserID = Program.Current.User.UserID;
            reservation.FromDate = dateTimeFrom;       
            reservation.ToDate = dateTimeTo;  

            _unitOfWork.ReservationsBookRepository.Insert(reservation);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Reservation has successfully added");
        }
        public static List<RentalsModel> MyRentals()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentalList = _unitOfWork.RentalsRepository.Get(r => r.UserID == Program.Current.User.UserID)
                .Select(i => new RentalsModel
                {
                    RentalsID = i.RentalsID,
                    BookID = i.BookID,
                    UserID = i.UserID,
                    RentalDate = i.RentalDate,
                    ReturnDate = i.ReturnDate,
                    Book = i.Book.Name,
                    Author = i.Book.Author.Name,
                    ISBN = i.Book.ISBN
                }).ToList();
            return rentalList;
        }
    }
}
