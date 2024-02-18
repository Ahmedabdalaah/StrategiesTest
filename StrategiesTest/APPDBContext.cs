using Microsoft.EntityFrameworkCore;
using StrategiesTest.Models;
using System.Diagnostics.Contracts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StrategiesTest
{
    public class APPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connection.source);
        }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Manager>();
        }     
    }
}
