using EntityFrameWorkCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkCore;

public class PersonsDbContext : DbContext
{
    public PersonsDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Country> Countries { get; set; } 
    public DbSet<Person> Persons { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    // Calling the parent class method.
    //    base.OnModelCreating(modelBuilder);

    //   Configuring the table names for the entities, Names can be different from the Entity name.
    //    modelBuilder.Entity<Country>().ToTable("Countries");
    //    modelBuilder.Entity<Person>().ToTable("Persons");
    //}
}
