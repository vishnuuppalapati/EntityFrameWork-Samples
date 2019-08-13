using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("Logins")]
    public class Login
    {
        [Key]
        [Column("UserId", Order = 0)]
        [Required]
        public string UserId { get; set; }

        [Column("Password", Order = 0)]
        [Required]
        public string Password { get; set; }
    }
}
