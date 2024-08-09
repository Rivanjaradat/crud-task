using crud_task.Configurations;
using crud_task.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_task.Data
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=crud_task1;Trusted_Connection=True;TrustServerCertificate=True;");

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigrations());
            modelBuilder.ApplyConfiguration(new OrderConfigrations());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }



    }
}
