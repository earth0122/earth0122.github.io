using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc7_Boostrap_Clone.Models;

namespace Mvc7_Boostrap_Clone.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc7_Boostrap_Clone.Models.Employee> Employee { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "David", Mobile = "0933-152667", Email = "david@gmail.com", Department = "總經理室", Title = "CEO" },
                new Employee { Id = 2, Name = "Mary", Mobile = "0938-456889", Email = "mary@gmail.com", Department = "人事部", Title = "管理師" },
                new Employee { Id = 3, Name = "Joe", Mobile = "0925-331225", Email = "joe@gmail.com", Department = "財務部", Title = "經理" },
                new Employee { Id = 4, Name = "Mark", Mobile = "0935-863991", Email = "mark@gmail.com", Department = "業務部", Title = "業務員" },
                new Employee { Id = 5, Name = "Rose", Mobile = "0987-335668", Email = "rose@gmail.com", Department = "資訊部", Title = "工程師" },
                new Employee { Id = 6, Name = "May", Mobile = "0955-259885", Email = "may@gmail.com", Department = "資訊部", Title = "工程師" },
                new Employee { Id = 7, Name = "John", Mobile = "0921-123456", Email = "john@gmail.com", Department = "業務部", Title = "業務員" }
                );
        }
        
    }
}
