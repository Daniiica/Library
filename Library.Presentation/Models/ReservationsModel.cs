using FileHelpers;
using Library.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Models
{
    [DelimitedRecord(",")]
    public class ReservationsModel
    {
        public ReservationsModel()
        {

        }
        public ReservationsModel(Reservations reservation)
        {
            this.ReservationsID = reservation.ReservationsID;
            this.UserID = reservation.UserID;
            this.BookID = reservation.BookID;
            this.BookName = reservation.Book.Name;
            this.Author = reservation.Book.Author.Name;
            this.ISBN = reservation.Book.ISBN;
            this.FromDate = reservation.FromDate;
            this.ToDate = reservation.ToDate;

        }
        [FieldHidden]
        public int ReservationsID { get; set; }
        [FieldHidden]
        public int UserID { get; set; }
        [FieldHidden]
        public int BookID { get; set; }
        [FieldCaption("Book")]
        public string BookName { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
    
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
