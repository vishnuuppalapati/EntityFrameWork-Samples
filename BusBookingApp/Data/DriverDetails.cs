using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("DriversDetails")]
    public class DriverDetails
    {
        [Key]
        [Required]
        [Column("DriverName",Order =0)]
        public string DriverName { get; set; }

        [Column("DriverContactNumber", Order = 1)]
        [Required]
        public string DriverContactNumber { get; set; }
    }
}
