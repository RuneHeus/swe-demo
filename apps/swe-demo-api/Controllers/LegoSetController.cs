using Microsoft.AspNetCore.Mvc;
using SweDemoBackend.Application.UseCases;
using SweDemoBackend.Contracts.Dtos;

namespace swe_demo_api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LegoSetController : ControllerBase
  {
    [HttpGet]
    public async Task<ActionResult<List<LegoSetDto>>> GetAllLegoSets(
        [FromServices] LegoSetUseCase useCase,
        CancellationToken ct)
    {
      var dto = await useCase.GetAllLegoSets(ct);
      return Ok(dto);
    }
  }
}
