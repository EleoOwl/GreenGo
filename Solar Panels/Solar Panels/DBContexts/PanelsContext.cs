using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreenGo.DB.API.Entities;

namespace GreenGo.DB.API.DBContexts
{
    public class PanelsContext : DbContext
    {
        public PanelsContext(DbContextOptions<PanelsContext> options)
           : base(options)
        {
        }

        public DbSet<Panel> Panels { get; set; }
        public DbSet<SolarStation> SolarStations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Panel>().HasData(
                new Panel()
                {
                    Company = "Green Life",
                    Power = 45,
                    height = 40,
                    width = 50,
                    Price = 4500
                },
                new Panel()
                {
                    Company = "Yellow Life",
                    Power =60,
                    height = 50,
                    width = 50,
                    Price = 7500
                },
                new Panel()
                {
                    Company = "Blue Life",
                    Power = 70,
                    height = 60,
                    width = 60,
                    Price = 9500
                },
                new Panel()
                {
                    Company = "Violet Life",
                    Power = 100,
                    height = 90,
                    width = 80,
                    Price = 10500
                }
                );

            modelBuilder.Entity<SolarStation>().HasData(
                new SolarStation()
                );
 

             base.OnModelCreating(modelBuilder);
        }
    }

}
}
