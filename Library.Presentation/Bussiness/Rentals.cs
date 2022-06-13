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
    class Rentals
    {
        public static List<RentalsModel> MyRentals()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentalList = _unitOfWork.RentalsRepository.Get(r => r.UserID == Program.Current.User.UserID)
                .Select(i => new RentalsModel
                {
                    RentalsID = i.RentalsID,
                    BookID = i.BookID,
                    User = i.User,
                    RentalDate = i.RentalDate.ToString(),
                    ReturnDate = i.ReturnDate.ToString(),
                    Book = i.Book.Name,
                    Author = i.Book.Author.Name,
                    ISBN = i.Book.ISBN
                }).ToList();
            return rentalList;
        }
        public static List<RentalsModel> AllRentals()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentalList = _unitOfWork.RentalsRepository.GetAll()
                .Select(i => new RentalsModel
                {
                    RentalsID = i.RentalsID,
                    BookID = i.BookID,
                    User = i.User,
                    UserFirstName = i.User.FirstName,
                    UserLastName = i.User.LastName,
                    UserIndexNumber = i.User.IndexNumber,
                    RentalDate = i.RentalDate.ToString(),
                    ReturnDate = i.ReturnDate.ToString(),
                    Book = i.Book.Name,
                    Author = i.Book.Author.Name,
                    ISBN = i.Book.ISBN
                }).ToList();
            return rentalList;
        }
        public static List<Book> FindRentals(UserModel user)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentals = _unitOfWork.RentalsRepository.Get(r => r.UserID == user.UserID,
                r => r.OrderBy(i => i.RentalDate));
            List<Book> books = new List<Book>();
            for (int i = 0; i < rentals.Count(); i++)
            {
                var ren = rentals.ElementAt(i);
                var book = _unitOfWork.BookRepository.Get(b => b.BookID == ren.BookID).FirstOrDefault();
                books.Add(book);
            }
            return books;
        }
        public static void SaveRentalsToCsv(DataGridView rentalDataGrid)
        {
            var rentals = (from row in rentalDataGrid.Rows.OfType<DataGridViewRow>()
                               select new RentalsModel()
                               {
                                   UserFirstName = row.Cells["UserFirstName"].Value.ToString(),
                                   UserLastName = row.Cells["UserLastName"].Value.ToString(),
                                   UserIndexNumber = row.Cells["UserIndexNumber"].Value.ToString(),
                                   Book = row.Cells["Book"].Value.ToString(),
                                   Author = row.Cells["Author"].Value.ToString(),
                                   ISBN = Convert.ToInt32( row.Cells["ISBN"].Value),
                                   RentalDate = row.Cells["RentalDate"].Value.ToString(),
                                   ReturnDate = row.Cells["ReturnDate"].Value.ToString()
                               }).ToList();
            string path = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                FileName = "rentals",

                DefaultExt = "csv",
                //  Filter = "csv files (*.xlsx)|*.xlsx",
                //  FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                var engine = new FileHelperEngine<RentalsModel>();
                engine.HeaderText = engine.GetFileHeader();
                engine.WriteFile(path, rentals);
                MaterialMessageBox.Show("File was saved");
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                MaterialMessageBox.Show("Problem with saving file.");
            }
        }
        public static List<RentalsModel> GetSearchRentals(string searchRentalBook, string searchRentalUserFirstName,string stringsearchRentalUserLastName,string stringsearchRentalUserIndexNumber)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var searchRentals = _unitOfWork.RentalsRepository.Get(r =>
            (searchRentalBook == null || r.Book.Name.Contains(searchRentalBook)) &&
            (searchRentalUserFirstName == null || r.User.FirstName.Contains(searchRentalUserFirstName)) &&
            (stringsearchRentalUserLastName == null || r.User.LastName.Contains(stringsearchRentalUserLastName)) &&
            (stringsearchRentalUserIndexNumber == null || r.User.IndexNumber.Contains(stringsearchRentalUserIndexNumber)))
                .Select(i => new RentalsModel
                {
                    BookID = i.BookID,
                    UserFirstName = i.User.FirstName,
                    UserLastName = i.User.LastName,
                    UserIndexNumber = i.User.IndexNumber,
                    User = i.User,
                    Author = i.Book.Author.Name,
                    ISBN = i.Book.ISBN,
                    RentalDate = i.RentalDate.ToString(),
                    ReturnDate = i.ReturnDate.ToString(),
                    RentalsID = i.RentalsID,
                    Book = i.Book.Name
                }).ToList();
            return searchRentals;
        }
        public static List<RentalsModel> ExpireSoonRentals()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var timeLimitDate = DateTime.Now.AddDays(5);
            var expireSoonRentals = _unitOfWork.RentalsRepository.Get(r => r.RentalDate <= timeLimitDate && r.ReturnDate == null)
                .Select(i => new RentalsModel
                {
                    RentalsID = i.RentalsID,
                    BookID = i.BookID,
                    User = i.User,
                    UserFirstName = i.User.FirstName,
                    UserLastName = i.User.LastName,
                    UserIndexNumber = i.User.IndexNumber,
                    RentalDate = i.RentalDate.ToString(),
                    ReturnDate = i.ReturnDate.ToString(),
                    Book = i.Book.Name,
                    Author = i.Book.Author.Name,
                    ISBN = i.Book.ISBN
                }).ToList();
            return expireSoonRentals;
        }
        public static RentalsModel GetRentalById(int rentalID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rental = _unitOfWork.RentalsRepository.Get(r => r.RentalsID == rentalID).Select(i => new RentalsModel
            {
                BookID = i.BookID,
                UserFirstName = i.User.FirstName,
                UserLastName = i.User.LastName,
                UserIndexNumber = i.User.IndexNumber,
                User = i.User,
                Author = i.Book.Author.Name,
                ISBN = i.Book.ISBN,
                RentalDate = i.RentalDate.ToString(),
                ReturnDate = i.ReturnDate.ToString(),
                RentalsID = i.RentalsID,
                Book = i.Book.Name
            }).FirstOrDefault();
            return rental;
        }
        public static void ReturnBook(int rentalID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rental = _unitOfWork.RentalsRepository.Get(r => r.RentalsID == rentalID && r.ReturnDate == null).FirstOrDefault();
            if(rental == null)
            {
                MaterialMessageBox.Show("Rental already returned");
                return;
            }
            rental.ReturnDate = DateTime.Now;
            _unitOfWork.Save();
            MaterialMessageBox.Show("The book was returned");
        }
        public static void AddNewRental(string rentalUserIndexNumber,string rentalBookName,int rentalBookISBN, DateTime rentalDate)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentalBook = _unitOfWork.BookRepository.Get(b => b.Name == rentalBookName && b.ISBN == rentalBookISBN).FirstOrDefault();
            var rentalUser = _unitOfWork.UserRepository.Get(u => u.IndexNumber == rentalUserIndexNumber && u.DeleteDateUtc == null).FirstOrDefault();

            if(rentalBook == null || rentalUser == null || rentalDate < DateTime.Now)
            {
                MaterialMessageBox.Show("Enter valid data");
                return;
            }
            var amountRentalBook = _unitOfWork.RentalsRepository.Get(r => r.BookID == rentalBook.BookID && r.ReturnDate == null).ToList().Count;
            if(amountRentalBook == rentalBook.Amount)
            {
                MaterialMessageBox.Show("All this books are rented");
                return;
            }
            Data.Domain.Rentals rental = new Data.Domain.Rentals
            {
                Book = rentalBook,
                BookID = rentalBook.BookID,
                User = rentalUser,
                UserID = rentalUser.UserID,
                RentalDate = rentalDate,
                ReturnDate = null
            };
            _unitOfWork.RentalsRepository.Insert(rental);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Rental added");
        }
        public static void UpdateRental(int rentalID, string rentalUserIndexNumber, string rentalBookName, int rentalBookISBN, DateTime rentalDate)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var rental = _unitOfWork.RentalsRepository.Get(r => r.RentalsID == rentalID).FirstOrDefault();

            var rentalBook = _unitOfWork.BookRepository.Get(b => b.Name == rentalBookName && b.ISBN == rentalBookISBN).FirstOrDefault();
            var rentalUser = _unitOfWork.UserRepository.Get(u => u.IndexNumber == rentalUserIndexNumber && u.DeleteDateUtc == null).FirstOrDefault();

            if (rentalBook == null || rentalUser == null || rentalDate < DateTime.Now)
            {
                MaterialMessageBox.Show("Enter valid data");
                return;
            }
            var amountRentalBook = _unitOfWork.RentalsRepository.Get(r => r.BookID == rentalBook.BookID && r.ReturnDate == null).ToList().Count;
            if (amountRentalBook >= rentalBook.Amount && rentalBook.BookID != rental.BookID)
            {
                MaterialMessageBox.Show("All this books are rented");
                return;
            }
            rental.Book = rentalBook;
            rental.BookID = rentalBook.BookID;
            rental.User = rentalUser;
            rental.UserID = rental.UserID;
            rental.RentalDate = rentalDate;
            _unitOfWork.RentalsRepository.Update(rental);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Rental updated");
        }
        public static void DeleteRental(int rentalID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rental = _unitOfWork.RentalsRepository.GetByID(rentalID);
            _unitOfWork.RentalsRepository.Delete(rental);
            _unitOfWork.Save();
        }
        public static List<RentalsModel> OnlyActiveRentals()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var rentals = _unitOfWork.RentalsRepository.Get(r => r.ReturnDate == null)
                .Select(i => new RentalsModel
            {
                BookID = i.BookID,
                UserFirstName = i.User.FirstName,
                UserLastName = i.User.LastName,
                UserIndexNumber = i.User.IndexNumber,
                User = i.User,
                Author = i.Book.Author.Name,
                ISBN = i.Book.ISBN,
                RentalDate = i.RentalDate.ToString(),
                ReturnDate = i.ReturnDate.ToString(),
                RentalsID = i.RentalsID,
                Book = i.Book.Name
            }).ToList();
            return rentals;
        }
    }
}
