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
    public class RentalsModel
    {
        public RentalsModel()
        {

        }
        public RentalsModel(Rentals rental)
        {
            this.RentalsID = rental.RentalsID;
            this.BookID = rental.BookID;
            this.UserID = rental.UserID;
            this.Book = rental.Book.Name;
            this.ISBN = rental.Book.ISBN;
            this.Author = rental.Book.Author.Name;
            this.ReturnDate = rental.ReturnDate;
            this.RentalDate = rental.RentalDate;
        }
        [FieldHidden]
        public int RentalsID { get; set; }
        [FieldHidden]
        public int BookID { get; set; }
        [FieldHidden]
        public int UserID { get; set; }
        [FieldCaption("Book")]
        public string Book { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
        [FieldCaption("Rental Date")]
        public DateTime RentalDate { get; set; }
        [FieldCaption("Return Date")]
        public DateTime ReturnDate { get; set; }
        
       

    }
}
