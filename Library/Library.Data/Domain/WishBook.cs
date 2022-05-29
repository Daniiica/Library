using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Domain
{
    public class WishBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int WishBookID { get; set; }
        public int UserID { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int ISBN { get; set; }
        public DateTime? ApproveDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public virtual User User { get; set; }


    }
}
