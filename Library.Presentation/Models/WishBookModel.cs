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
    public class WishBookModel
    {
        public WishBookModel()
        {

        }
        public WishBookModel(WishBook wishBook)
        {
            this.User = wishBook.User;
            this.UsersFirstName = wishBook.User.FirstName;
            this.UsersLastName = wishBook.User.LastName;
            this.UsersIndexNumber = wishBook.User.IndexNumber;
            this.Name = wishBook.Name;
            this.ISBN = wishBook.ISBN;
            this.Author = wishBook.Author;
            this.ApproveDate = wishBook.ApproveDate;
            this.DeleteDate = wishBook.DeleteDate;
        }
        [FieldHidden]
        public int WishBookID { get; set; }
        [FieldHidden]
        public User User { get; set; }
        [FieldCaption("Users First Name")]
        public string UsersFirstName { get; set; }
        [FieldCaption("Users Last Name")]
        public string UsersLastName { get; set; }
        [FieldCaption("Users Index Number")]
        public string UsersIndexNumber { get; set; }

        [FieldCaption("Book")]
        public string Name { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
        [FieldCaption("Approve Date")]
        public DateTime? ApproveDate { get; set; }
        [FieldCaption("Delete Date")]
        public DateTime? DeleteDate { get; set; }

    }
}
