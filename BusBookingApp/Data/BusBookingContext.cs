using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Data
{
    public class BusBookingContext:DbContext
    {
        public BusBookingContext(DbContextOptions options):base(options)
        {

        }
        //Entities for BussBookingApp

        public DbSet<Registrationcol> Registrationcols { get; set; }
        public DbSet<Login> Logins{ get; set; }
        public DbSet<Bus> Buses{ get; set; }
        public DbSet<Passenger> Passengers{ get; set; }
        public DbSet<TicketDetail> TicketDetails{ get; set; }
        public DbSet<DriverDetails> DriversDetails{ get; set; }
    }
}
