using FileHelpers;

namespace Library.Presentation.Models
{
    [DelimitedRecord(",")]
    public class RaitingModel
    {
        public RaitingModel()
        {

        }
        public RaitingModel(Library.Data.Domain.Raiting raiting)
        {
            this.RaitingID = raiting.RaitingID;
            this.BookID = raiting.BookID;
            this.Author = raiting.Book.Author.Name;
            this.Publisher = raiting.Book.Publisher.Name;
            this.Language = raiting.Book.Language.Caption;
            this.ISBN = raiting.Book.ISBN;
            this.Book = raiting.Book.Name;
            this.UserFirstName = raiting.User.FirstName;
            this.UserLastName = raiting.User.LastName;
            this.UserIndexNumber = raiting.User.IndexNumber;
            this.Assessment = raiting.Assessment;
        }
        [FieldHidden]
        public int RaitingID { get; set; }
        [FieldCaption("Book")]
        public string Book { get; set; }
        [FieldHidden]
        public int BookID { get; set; }
        [FieldCaption("Author")]
        public string Author { get; set; }
        [FieldCaption("Publisher")]
        public string Publisher { get; set; }
        [FieldCaption("Language")]
        public string Language { get; set; }
        
        [FieldCaption("ISBN")]
        public int ISBN { get; set; }
        [FieldCaption("UserFirstName")]
        public string UserFirstName { get; set; }
        [FieldCaption("UserLastName")]
        public string UserLastName { get; set; }
        [FieldCaption("UserIndexNumber")]
        public string UserIndexNumber { get; set; }

        [FieldCaption("Assessment")]
        public decimal Assessment { get; set; }
    }
}
