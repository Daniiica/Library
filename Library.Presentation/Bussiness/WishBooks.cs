using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Bussiness
{
    public class WishBooks
    {
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
                    User = i.User,
                    ApproveDate = i.ApproveDate,
                    DeleteDate = i.DeleteDate,
                    ISBN = i.ISBN
                }).ToList();
            return myWishBooks;
        }
        public static List<WishBookModel> AllWishBook()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var allWishBooks = _unitOfWork.WishBookRepository.Get(w => w.ApproveDate == null && w.DeleteDate == null).Select(i => new WishBookModel
            {
                WishBookID = i.WishBookID,
                Name = i.Name,
                Author = i.Author,
                User = i.User,
                UsersFirstName = i.User.FirstName,
                UsersLastName = i.User.LastName,
                UsersIndexNumber = i.User.IndexNumber,
                ApproveDate = i.ApproveDate,
                DeleteDate = i.DeleteDate,
                ISBN = i.ISBN
            }).ToList();
            return allWishBooks;
        }


        public static void ApproveWishBook(int bookID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var approveBook = _unitOfWork.WishBookRepository.Get(w => w.WishBookID == bookID).FirstOrDefault();
            approveBook.ApproveDate = DateTime.Now;
            _unitOfWork.Save();
        }
        public static void DeleteWishBook(int bookID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var deleteWishBook = _unitOfWork.WishBookRepository.Get(w => w.WishBookID == bookID).FirstOrDefault();
            deleteWishBook.DeleteDate = DateTime.Now;
            _unitOfWork.Save();

        }
    }
}
