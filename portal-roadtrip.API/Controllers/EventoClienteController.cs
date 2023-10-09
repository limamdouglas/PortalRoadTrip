using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoClienteController : ControllerBase
{
    private readonly IEventoClienteService _eventoClienteService;
    public EventoClienteController(IEventoClienteService eventoClienteService)
    {
        _eventoClienteService = eventoClienteService;
    }

    [HttpGet("ListarEventosCliente")]
    public async Task<List<EventoClienteDTO>> ListarEventosCliente()
    {
        return await _eventoClienteService.ListarEventosCliente();
    }

    [HttpPost("SalvarEventoCliente")]
    public async Task<ActionResult<EventoClienteDTO>> SalvarEventoCliente([FromBody] EventoClienteDTO dto)
    {
        return await _eventoClienteService.SalvarEventoCliente(dto);
    }
}
