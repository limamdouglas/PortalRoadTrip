using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CargoController : ControllerBase
{
    private readonly ICargoService CargoService;
    public CargoController(ICargoService cargoService)
    {
        CargoService = cargoService;
    }

    [HttpGet("ListarCargos")]
    public async Task<List<Cargo>> ListarCargos()
    {
        return await CargoService.ListarCargos();
    }

    [HttpGet("BuscarCargo")]
    public async Task<ActionResult<Cargo>> BuscarCargoAsync(int cargoId)
    {
        return await CargoService.BuscarCargo(cargoId);
    }

    [HttpPost("AddCargo")]
    public async Task<ActionResult<Cargo>> AddCargo([FromBody] Cargo cargo)
    {
        return await CargoService.AddCargo(cargo);
    }

    [HttpDelete("DeletarCargo")]
    public async Task<ActionResult<bool>> DeletarCargo([FromBody] Cargo cargo)
    {
        return await CargoService.DeleteCargo(cargo.Id);
    }

    [HttpPut("EditarCargo")]
    public async Task<ActionResult<Cargo>> EditarCargo([FromBody] Cargo cargo)
    {
        return await CargoService.UpdateCargo(cargo);
    }
}
