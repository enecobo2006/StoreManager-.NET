using Microsoft.EntityFrameworkCore;
using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL
{
    public class StoreDbContent : DbContext
    {
        string _connectionString = "Data Source=MARJO\\SQLEXPRESS01;Initial Catalog=StoreDB;User ID=sa;Trust Server Certificate=True;Password=marjo2005!";
        public DbSet<Entities.Client>? Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(StoreDbContent)));
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
