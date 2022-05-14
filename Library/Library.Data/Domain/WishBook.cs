using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
