using Car_To_Go.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DataContext
{
    public class CarToGoDataContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Status> Statuses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KEVIN-PC;DataBase=CarToGoDB;Trusted_Connection=True;");
        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(q => q.id);
            modelBuilder.Entity<Car>().Property(e => e.id).IsRequired().UseSqlServerIdentityColumn()
                 .HasMaxLength(50).IsRequired();
        }*/
    }
}
