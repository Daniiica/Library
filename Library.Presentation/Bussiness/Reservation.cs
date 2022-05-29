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
    }
}
