using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Domain
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublishingHouseId { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int ISBN { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public virtual Author Author { get; set; }
        public virtual PublishingHouse Publisher { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual Language Language { get; set; }

        //public virtual List<Language> languages { get; set; } = new List<Language>();
    }
}
