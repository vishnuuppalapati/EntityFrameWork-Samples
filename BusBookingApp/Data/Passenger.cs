using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("Passengers")]
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassengerId { get; set; }

        [Required]
        [Column("PassengerName", Order = 0)]
        public string PassengerName { get; set; }

        [Column("PassengerAge", Order = 1)]
        [Required]
        public int PassengerAge { get; set; }

        [Column("PassengerContactNumber", Order = 2)]
        [Required]
        public string PassengerContactNumber { get; set; }

        [ForeignKey("PTicketNumber")]
        public string PassengerTicketId{get;set;}

        public TicketDetail Tickets { get; set;}

    }
}
