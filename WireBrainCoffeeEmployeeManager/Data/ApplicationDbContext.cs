using Microsoft.EntityFrameworkCore;
using WireBrainCoffeeEmployeeManager.Models;

namespace WireBrainCoffeeEmployeeManager.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    
    public DbSet<Employee> Employees  => Set<Employee>();
    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>().HasData(
            new Department {Id = 1, Name = "Finance"},
            new Department {Id = 2, Name = "Sales"},
            new Department {Id = 3, Name = "Marketing"},
            new Department {Id = 4, Name = "Human Resource"},
            new Department {Id = 5, Name = "IT"}
        );

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, FirstName = "Ain", LastName = "Mor", DepartmentId = 2},
            new Employee { Id = 2, FirstName = "Suresh", LastName = "Mor", DepartmentId = 5, IsDeveloper = true},
            new Employee { Id = 3, FirstName = "Vivaan", LastName = "Mor", DepartmentId = 5, IsDeveloper = true},
            new Employee { Id = 4, FirstName = "Umesh", LastName = "Mor", DepartmentId = 1},
            new Employee { Id = 5, FirstName = "Lokesh", LastName = "Mor", DepartmentId = 4},
            new Employee { Id = 6, FirstName = "Naman", LastName = "Mor", DepartmentId = 3},
            new Employee { Id = 7, FirstName = "Maulik", LastName = "Mor", DepartmentId = 5, IsDeveloper = true}
        );
    }
}