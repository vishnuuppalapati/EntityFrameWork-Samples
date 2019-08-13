using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("Busses")]
    public class Bus
    {
        [Key]
        [Column("BusTime", Order = 0)]
        [Required]
        public DateTime BusTime { get; set; }

        [Column("BusRoute", Order = 1)]
        [Required]
        public string BusRoute { get; set; }

        [Column("BusName", Order = 2)]
        [Required]
        public string BusName { get; set; }


        [Column("BusNumber", Order = 3)]
        [Required]
        public string BusNumber { get; set; }

        public virtual IEnumerable<DriverDetails> Drivers {get;set;}
    }
}
