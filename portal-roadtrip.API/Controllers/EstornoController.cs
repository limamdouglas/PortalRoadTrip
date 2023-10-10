using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EstornoController : ControllerBase
{
    private readonly IEstornoService _estornoService;
    public EstornoController(IEstornoService estornoService)
    {
        _estornoService = estornoService;
    }

    [HttpGet("ListarEstornos")]
    public async Task<List<Estorno>> ListarEstornos()
    {
        return await _estornoService.ListarEstornos();
    }

    [HttpGet("BuscarEstorno/{cpf}")]
    public async Task<Estorno> BuscarEstorno(string cpf)
    {
        return await _estornoService.BuscarEstorno(cpf);
    }

    [HttpPost("SalvarEstorno")]
    public async Task<ActionResult<Estorno>> SalvarEstorno([FromBody] Estorno dto)
    {
        return await _estornoService.SalvarEstorno(dto);
    }
}
