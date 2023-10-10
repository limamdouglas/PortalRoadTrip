using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditoController : ControllerBase
{
    private readonly ICreditoService _creditoService;
    public CreditoController(ICreditoService creditoService)
    {
        _creditoService = creditoService;
    }

    [HttpGet("ListarCreditos")]
    public async Task<List<Credito>> ListarCreditos()
    {
        return await _creditoService.ListarCreditos();
    }

    [HttpGet("BuscarCredito/{cpf}")]
    public async Task<Credito> BuscarCredito(string cpf)
    {
        return await _creditoService.BuscarCredito(cpf);
    }

    [HttpPost("SalvarCredito")]
    public async Task<ActionResult<Credito>> SalvarCredito([FromBody] Credito dto)
    {
        return await _creditoService.SalvarCredito(dto);
    }
}
