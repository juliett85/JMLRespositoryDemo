using Microsoft.EntityFrameworkCore;
using Kavak.DomainLayer.Models;
using Kavak.DomainLayer.Models.Coders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kavak.Infra.DataLayer
{
    public class KavakDbContext : DbContext
    {
        public KavakDbContext() { }
        public KavakDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<DomainLayer.Models.Version> Versions { get; set; }//tengo q poner esto asi?????
        public DbSet<Year> Years { get; set; }
        public DbSet<YearModel> YearsModels { get; set; }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Doors> Doorss { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Status> State { get; set; }
        public DbSet<Traction> Tractions { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }

    }
}
