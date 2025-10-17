using SweDemoBackend.Application.Interfaces.Repositories;
using SweDemoBackend.Contracts.Dtos;

namespace SweDemoBackend.Application.UseCases
{
  public class LegoSetUseCase
  {
    private readonly ILegoSetRepository _repo;

    public LegoSetUseCase(ILegoSetRepository repo)
    {
      _repo = repo;
    }

    public async Task<IEnumerable<LegoSetDto>> GetAllLegoSets(CancellationToken ct = default)
    {
      var entities = await _repo.GetLegoSetsAsync(ct);

      //Mapping
      List<LegoSetDto> dtos = new List<LegoSetDto>();

      entities.ToList().ForEach(e =>
      dtos.Add(new LegoSetDto()
      {
        Id = e.Id,
        Name = e.Name,
        NumberOfPieces = e.NumberOfPieces,
      }));

      return dtos;
    }
  }
}
