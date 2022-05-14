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
            this.UserID = wishBook.UserID;
            this.Name = wishBook.Name;
            this.ISBN = wishBook.ISBN;
            this.Author = wishBook.Author;
            this.ApproveDate = wishBook.ApproveDate;
            this.DeleteDate = wishBook.DeleteDate;
        }
        [FieldHidden]
        public int WishBookID { get; set; }
        [FieldHidden]
        public int UserID { get; set; }
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
