using Fantasy.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Fantasy.Backend.Data;

public class DateContext : DbContext
{
    public DateContext(DbContextOptions<DateContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
    }
}