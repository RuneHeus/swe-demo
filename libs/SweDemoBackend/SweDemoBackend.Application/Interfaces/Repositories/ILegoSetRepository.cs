using SweDemoBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweDemoBackend.Application.Interfaces.Repositories
{
  public interface ILegoSetRepository
  {
    Task<IEnumerable<LegoSet>> GetLegoSetsAsync(CancellationToken ct = default);
  }
}

