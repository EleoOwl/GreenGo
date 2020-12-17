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
        public DbSet<Inverter> Inverters { get; set; }
        public DbSet<SolarStation> SolarStations { get; set; }
        public DbSet<WindTurbine> WindTurbines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Panel>().HasData(
                new Panel()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Company = "Green Life",
                    Power = 45,
                    height = 40,
                    width = 50,
                    Price = 4500
                },
                new Panel()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Company = "Yellow Life",
                    Power =60,
                    height = 50,
                    width = 50,
                    Price = 7500
                },
                new Panel()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Company = "Blue Life",
                    Power = 70,
                    height = 60,
                    width = 60,
                    Price = 9500
                },
                new Panel()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Company = "Violet Life",
                    Power = 100,
                    height = 90,
                    width = 80,
                    Price = 10500
                }
                );

            modelBuilder.Entity<SolarStation>().HasData(
                new SolarStation { Id = Guid.NewGuid()}
                );
 

             base.OnModelCreating(modelBuilder);
        }
    }

}

