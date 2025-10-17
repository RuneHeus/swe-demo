using Microsoft.EntityFrameworkCore;
using SweDemoBackend.Application.Interfaces.Repositories;
using SweDemoBackend.Domain.Entities;

namespace SweDemoBackend.Infrastructure.Repositories
{
  public class LegoSetRepository : ILegoSetRepository
  {
    private readonly BricksForKidsDbContext _db;

    public LegoSetRepository(BricksForKidsDbContext db)
    {
      _db = db;
    }

    public async Task<IEnumerable<LegoSet>> GetLegoSetsAsync(CancellationToken ct = default)
    {
      return await _db.LegoSets.ToListAsync();
    }
  }
}
