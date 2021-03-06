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
            this.Genres = string.Join(", ", from item in book.Genres select item.Name);
            /*  this.Publisher = book.Publisher.Name;
              this.Language = book.Language.Caption;
              this.Genres = book.Genres
            */

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
        [FieldCaption("Publisher")]
        public string Publisher { get; set; }
        [FieldCaption("Language")]
        public string Language { get; set; }
        [FieldCaption("ISBN")]
        
        public int ISBN { get; set; }
        [FieldCaption("Description")]
        public string Description { get; set; }
        [FieldCaption("Amount")]
        public int Amount { get; set; }
        [FieldCaption("Genres")]
        public string Genres { get; set; }
        /*
        [FieldCaption("Publisher")]
        public string Publisher { get; set; }
        [FieldCaption("Language")]
        public string Language { get; set; }
        [FieldCaption("Genres")]
        public List<string> Genres { get; set; }
        */
    }
}
