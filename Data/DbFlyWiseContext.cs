using FlyWiseBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWiseBackend.Data
{
    public class DbFlyWiseContext : DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; } = null!;
        public DbSet<Passenger> Passengers {  get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;

        public DbFlyWiseContext() : base() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=C:\\Users\\nazariiklymok\\source\\repos\\FlyWise\\FlyWiseBackend\\FlyWiseBackend\\FlyWise.db")
                .LogTo(s => System.Diagnostics.Debug.WriteLine(s));
        }
    }
}
