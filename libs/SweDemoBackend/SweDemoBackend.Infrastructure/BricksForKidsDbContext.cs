using Microsoft.EntityFrameworkCore;
using SweDemoBackend.Domain.Entities;

public class BricksForKidsDbContext : DbContext
{
  public BricksForKidsDbContext(DbContextOptions<BricksForKidsDbContext> options) : base(options) { }

  public DbSet<LegoSet> LegoSets { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(BricksForKidsDbContext).Assembly);

    modelBuilder.Entity<LegoSet>().HasData(
              new LegoSet() { Id = Guid.Parse("f3c73d8d-5f8a-4f2a-9c11-2c9a1c2f8d2e"), Name = "Harry Potter Zweinstein", NumberOfPieces = 1540 }
          );
  }
}
