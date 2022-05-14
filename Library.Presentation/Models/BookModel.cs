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
    public class BookModel
    {
        public BookModel()
        {

        }
        public BookModel(Library.Data.Domain.Book book)
        {
            this.BookID = book.BookID;
            this.AuthorID = book.AuthorID;
            this.PublisherID = book.PublishingHouseId;
            this.LanguageID = book.LanguageID;
            this.ISBN = book.ISBN;
            this.Name = book.Name;
            this.Description = book.Description;
            this.Amount = book.Amount;
        }
        [FieldHidden]
        public int BookID { get; set; }
        [FieldHidden]
        public int AuthorID { get; set; }
        [FieldHidden]
        public int PublisherID { get; set; }
        [FieldHidden]
        public int LanguageID { get; set; }
        [FieldCaption("Book Name")]
        public string Name { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
        [FieldCaption("Description")]
        public string Description { get; set; }
        [FieldCaption("Amount")]
        public int Amount { get; set; }
       
    }
}
