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
        public DbSet<ReferenceTables> ReferenceTables { get; set; }

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
                    Power = 60,
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
            
            modelBuilder.Entity<Inverter>().HasData(
                new Inverter
                {
                    Id = Guid.Parse("15f8c53b-e896-4c7f-891b-31393cd1736d"),
                    Company = "not THE BEST COMPANY",
                    Power = 24,
                    Price = 8000
                },
                new Inverter
                {
                    Id = Guid.Parse("98c1c7d6-3afc-4ae9-9b0b-6c270676e65b"),
                    Company = "THE BEST COMPANY",
                    Power = 45,
                    Price = 10000
                },
                new Inverter
                {
                    Id = Guid.Parse("1f08fc57-42e4-4af1-9409-1a92d3318980"),
                    Company = "THE BEST COMPANY",
                    Power = 45,
                    Price = 10000
                }

                );

            modelBuilder.Entity<SolarStation>().HasData(
                new SolarStation
                {
                    Id = Guid.Parse("5de324e0-203d-4478-8fb2-e19d686500eb"),
                    IdInverter = Guid.Parse("15f8c53b-e896-4c7f-891b-31393cd1736d")
                },
                 new SolarStation
                 {
                     Id = Guid.Parse("d5db0978-13b6-4ba6-a20a-777de3d9b660"),
                     IdInverter = Guid.Parse("98c1c7d6-3afc-4ae9-9b0b-6c270676e65b")
                 },
                  new SolarStation
                  {
                      Id = Guid.Parse("c8e840fc-f108-4a75-bff6-099d7f979bd0"),
                      IdInverter = Guid.Parse("1f08fc57-42e4-4af1-9409-1a92d3318980")
                  }
                );
            modelBuilder.Entity<ReferenceTables>().HasData(
                new ReferenceTables
                {
                    Id = Guid.NewGuid(),
                    IdPanel = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    IdStation = Guid.Parse("5de324e0-203d-4478-8fb2-e19d686500eb")
                }
                );
            modelBuilder.Entity<WindTurbine>().HasData(
                
                new WindTurbine
                {
                    Id = Guid.Parse("fcee8747-7253-4fd5-a89f-2d37fc4ec079"),
                    Company = "Wind company",
                    Price = 100000
                },
                new WindTurbine
                {
                    Id = Guid.Parse("07681fb5-983a-440d-9384-8cf01ef41c87"),
                    Company = "Summer breeeze",
                    Price = 220000
                },
                new WindTurbine
                {
                    Id = Guid.Parse("bfa2c8ac-3f83-4381-9ab0-fe8a834aab72"),
                    Company = "Nice barrey",
                    Price = 1001324
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }

}

