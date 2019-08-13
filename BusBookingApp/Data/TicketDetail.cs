using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("TicketDetails")]
    public class TicketDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TicketNumber", Order = 0)]
        public int TicketNumber { get; set; }

        [Column("DateTime", Order = 1)]
        [Required]
        public DateTime DateTime { get; set; }

        [Column("TicketAmount", Order = 2)]
        [Required]
        public double TicketAmoumt { get; set; }
    }
}
