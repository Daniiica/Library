using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Domain
{
    public class Reservations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReservationsID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime? DeleteDateReservation { get; set; }
        public bool Realized { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
