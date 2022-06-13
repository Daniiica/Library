using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Bussiness
{
    public class Reservation
    {
        public static List<ReservationsModel> MyReservationList()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var myReservation = _unitOfWork.ReservationsBookRepository.Get(r => r.UserID == Program.Current.User.UserID && r.DeleteDateReservation == null)
            .Select(i => new ReservationsModel   // select prolazi kroz svaki objekat i premapira
            {
                BookID = i.BookID,
                BookName = i.Book.Name,
                Author = i.Book.Author.Name,
                ISBN = i.Book.ISBN,
                UserID = i.UserID,
                FromDate = i.FromDate,
                ToDate = i.ToDate,
                Realized = i.Realized ? "YES" : "NO"
            }).ToList();
            return myReservation;
        }
        public static void AddReservation(int bookID, DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            Reservations reservation = new Reservations();
            var reserveBook = _unitOfWork.BookRepository.Get(b => b.BookID == bookID).FirstOrDefault();

            var alreadyReservedBooks = _unitOfWork.ReservationsBookRepository.Get(b => b.BookID == bookID).Where(r => (r.ToDate > dateTimeFrom) &&
                                                                                                                       (r.FromDate < dateTimeTo) &&
                                                                                                                       (dateTimeFrom > r.FromDate) &&
                                                                                                                       r.DeleteDateReservation == null);
            var alreadyRentalBooks = _unitOfWork.RentalsRepository.Get(n => n.BookID == bookID && n.RentalDate > dateTimeFrom && n.ReturnDate == null);


            if (reserveBook.Amount <= alreadyReservedBooks.Count() + alreadyRentalBooks.Count())
            {
                DateTime freeBookDate;

                if (alreadyRentalBooks.Count() == 0)
                {
                    freeBookDate = alreadyReservedBooks.Min(m => m.ToDate);
                }
                else if (alreadyReservedBooks.Count() == 0)
                {
                    freeBookDate = alreadyRentalBooks.Min(m => m.RentalDate);
                }
                else
                {
                    var firstAvailableBookFromRentals = alreadyRentalBooks.Min(m => m.RentalDate);
                    var firstAvailableBookFromReservations = alreadyReservedBooks.Min(m => m.ToDate);
                    freeBookDate = freeBookDate = firstAvailableBookFromRentals < firstAvailableBookFromReservations ? firstAvailableBookFromRentals : firstAvailableBookFromReservations;
                }

                MaterialMessageBox.Show("No more books available. First free book will be " + freeBookDate.ToString("dd/MM/yyyy") + ".");
                return;
            }

            var alreadyReserverBookInDateRange = _unitOfWork.ReservationsBookRepository.Get(b => b.BookID == bookID ).Where(r => r.FromDate < dateTimeFrom && r.DeleteDateReservation == null);
           
            reservation.Book = reserveBook;
            reservation.UserID = Program.Current.User.UserID;
            reservation.FromDate = dateTimeFrom;
            reservation.ToDate = dateTimeTo;
            reservation.DeleteDateReservation = null;
            reservation.Realized = false;

            _unitOfWork.ReservationsBookRepository.Insert(reservation);
            _unitOfWork.Save();
            if (alreadyReserverBookInDateRange.Count() != 0)
            {
                var freeBookDateTo = alreadyReserverBookInDateRange.Min(m => m.FromDate);
                MaterialMessageBox.Show("Reservation has successfully added, but you must return book " + freeBookDateTo.ToString("dd/MM/yyyy") + ".");
                return;
            }
            MaterialMessageBox.Show("Reservation has successfully added");
        }
        public static void DeleteReservation(int reservationID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var deleteReservation = _unitOfWork.ReservationsBookRepository.Get(r => r.ReservationsID == reservationID).FirstOrDefault();
            deleteReservation.DeleteDateReservation = DateTime.Now;
            _unitOfWork.ReservationsBookRepository.Update(deleteReservation);
            _unitOfWork.Save();
        }
        public static bool CheckReservationForRental(int rentalBookISBN, string rentalBookName, DateTime rentalDate)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            DateTime dateReservationMinValue = DateTime.Now.AddDays(-2);
            var book = _unitOfWork.BookRepository.Get(b => b.ISBN == rentalBookISBN && b.Name == rentalBookName).FirstOrDefault();
            var reservation = _unitOfWork.ReservationsBookRepository.Get(r => r.FromDate < rentalDate && r.FromDate > dateReservationMinValue && r.BookID == book.BookID && r.DeleteDateReservation == null);

            if (reservation.Count() < book.Amount)
                return true;
            else
                return false;
        }
        public static Reservations FindReservation(string rentalUserIndexNumber, int rentalBookISBN, string rentalBookName)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var reservation = _unitOfWork.ReservationsBookRepository.Get(r => r.User.IndexNumber == rentalUserIndexNumber &&
                                                                                r.Book.ISBN == rentalBookISBN &&
                                                                                r.Book.Name == rentalBookName).FirstOrDefault();
            return reservation;
        }
        public static void SetToRealized(int reservationID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var reservation = _unitOfWork.ReservationsBookRepository.Get(r => r.ReservationsID == reservationID).FirstOrDefault();
            reservation.Realized = true;
            _unitOfWork.ReservationsBookRepository.Update(reservation);
            _unitOfWork.Save();

        }
        public static void DeleteOldReservation()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            DateTime dateLimit = DateTime.Now.AddDays(-2);
            var oldReservations = _unitOfWork.ReservationsBookRepository.Get(r => r.FromDate < dateLimit && r.DeleteDateReservation == null);
            foreach(var item in oldReservations)
            {
                item.Realized = false;
                item.DeleteDateReservation = DateTime.Now;
                _unitOfWork.ReservationsBookRepository.Update(item);
            }
            _unitOfWork.Save();
        }
    }
}
