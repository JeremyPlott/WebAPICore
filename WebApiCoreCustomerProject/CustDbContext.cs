using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoreCustomerProject.Models;
using WebApiCoreCustomerProject;

namespace WebApiCoreCustomerProject {

    public class CustDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public CustDbContext(DbContextOptions<CustDbContext> context) : base(context) { }

        public DbSet<WebApiCoreCustomerProject.Models.Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { // this method adds to db in the index folder of the table
                                                                             // this must be in context file
            modelBuilder.Entity<Employee>(entity => {
                entity.HasIndex(e => e.Username)
                    .HasName("IDX_Username")
                    .IsUnique();

            });
        }
    }
}
