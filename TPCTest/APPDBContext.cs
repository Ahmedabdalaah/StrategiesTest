using Microsoft.EntityFrameworkCore;
using TPCTest.Models;
using System.Diagnostics.Contracts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TPCTest
{
    public class APPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connection.source);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
            modelBuilder.Entity<Customer>().ToTable("customers");
            modelBuilder.Entity<Employee>().ToTable("employees");
            modelBuilder.Entity<Manager>().ToTable("managers");
        }
    }
}
