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
            this.User = rental.User;
            this.UserFirstName = rental.User.FirstName;
            this.UserLastName = rental.User.LastName;
            this.UserIndexNumber = rental.User.IndexNumber;
            this.Book = rental.Book.Name;
            this.ISBN = rental.Book.ISBN;
            this.Author = rental.Book.Author.Name;
            this.ReturnDate = rental.ReturnDate.ToString();
            this.RentalDate = rental.RentalDate.ToString();
        }
        [FieldHidden]
        public int RentalsID { get; set; }
        [FieldHidden]
        public int BookID { get; set; }
        [FieldHidden]
        public User User { get; set; }
        [FieldCaption("User First Name")]
        public string UserFirstName { get; set; }
        [FieldCaption("User Last Name")]
        public string UserLastName { get; set; }
        [FieldCaption("User Index Number")]
        public string UserIndexNumber { get; set; }
        [FieldCaption("Book")]
        public string Book { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
        [FieldCaption("Rental Date")]
        public string RentalDate { get; set; }
        [FieldCaption("Return Date")]
        public string ReturnDate { get; set; }
        
       

    }
}
