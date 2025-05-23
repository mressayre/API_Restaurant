using EFRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace EFRestaurant.Data;

public class RestaurantContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Manager> Managers { get; set; } = null!;
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Shift> Shifts { get; set; } = null!;
    public DbSet<ShiftAssignment> ShiftAssignments { get; set; } = null!;
    public string DbPath { get; private set; }

    public RestaurantContext()
    {
        // Path to SQLite database file
        DbPath = "EFTodo.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}
