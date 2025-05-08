using CompanyProject.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<SubDepartment> SubDepartments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<SubDepartment>()
                .HasOne(sd => sd.Department)
                .WithMany(d => d.SubDepartments)
                .HasForeignKey(sd => sd.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.SubDepartment)
                .WithMany(sd => sd.Employees)
                .HasForeignKey(e => e.SubDepartmentId)
                .OnDelete(DeleteBehavior.Cascade);


        /*
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Name = "Engineering",
                    Description = "Product development"
                },
                new Department
                { 
                    Name = "Marketing",
                    Description = "Promotion & sales"
                },
                new Department
                {
                    Name = "Operations",
                    Description = "Company operations"
                }
            );

            modelBuilder.Entity<SubDepartment>().HasData(
                new SubDepartment {  DepartmentId = 1, Name = "Software Dev", Description = "Application development" },
                new SubDepartment {  DepartmentId = 1, Name = "QA", Description = "Quality assurance" },
                new SubDepartment {  DepartmentId = 2, Name = "Digital Marketing", Description = "Online campaigns" },
                new SubDepartment {  DepartmentId = 2, Name = "Market Research", Description = "Customer analysis" },
                new SubDepartment {  DepartmentId = 3, Name = "HR", Description = "Human resources" },
                new SubDepartment {  DepartmentId = 3, Name = "Facilities", Description = "Office management" }
            );*/
        }



    }
    
}
