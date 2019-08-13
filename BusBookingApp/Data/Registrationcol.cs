using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    [Table("Registration")]
    public class Registrationcol
    {
        [Key]
        [Column("UserName", Order = 0)]
        [Required]
        public string UserName { get; set; }

        [Column(Order = 2)]
        [Required]
        public int Age { get; set; }

        [Column("DateOfBirth", Order = 1)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column("MobileNumber", Order = 4)]
        [Required]
        public string MobileNumber { get; set; }

        [Column("MailId", Order = 3)]
        [Required]
        public string MailId { get; set; }

        [Column("UserId", Order = 5)]
        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [Column("Password", Order = 6)]
        [Required]
        public string Password { get; set; }
    }
}
