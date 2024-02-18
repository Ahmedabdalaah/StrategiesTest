using Microsoft.EntityFrameworkCore;
using TPTTest.Models;

namespace TPTTest
{
    public class APPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connection.source);
        }
        public DbSet<Person> Persons { get; set; }  
        public DbSet<Employee> Employees { get; set;  }    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Manager { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTptMappingStrategy();
        }

    }
}
