using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Domain
{
    public class Raiting
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RaitingID { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }

        [DataType("decimal(18,1)")]
        public decimal Assessment { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
