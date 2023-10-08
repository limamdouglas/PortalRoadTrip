using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoFuncionarioController : ControllerBase
{
    private readonly IEventoFuncionarioService _eventoFuncionarioService;
    public EventoFuncionarioController(IEventoFuncionarioService eventoFuncionarioService)
    {
        _eventoFuncionarioService = eventoFuncionarioService;
    }

    [HttpGet("ListarEventosFuncionarios")]
    public async Task<List<EscalaDTO>> ListarEventosFuncionarios()
    {
        return await _eventoFuncionarioService.ListarEventoFuncionarios();
    }

    [HttpGet("ListarEventosFuncionarios/{eventoId}")]
    public async Task<EventoFuncionarioDTO> ListarEventosFuncionarios(int eventoId)
    {
        return await _eventoFuncionarioService.ListarEventosFuncionarios(eventoId);
    }

    [HttpGet("BuscarEventoFuncionario")]
    public async Task<ActionResult<EventoFuncionario>> BuscarEventoFuncionarioAsync(int eventoFuncionarioId)
    {
        return await _eventoFuncionarioService.BuscarEventoFuncionario(eventoFuncionarioId);
    }

    [HttpPost("AddEventoFuncionario")]
    public async Task<ActionResult<EventoFuncionario>> BuscarEventoFuncionario([FromBody] EventoFuncionarioDTO eventoFuncionario)
    {
        return await _eventoFuncionarioService.AddEventoFuncionario(eventoFuncionario);
    }

    [HttpDelete("DeletarEventoFuncionario")]
    public async Task<ActionResult<bool>> DeletarEventoFuncionario([FromBody] EventoFuncionario eventoFuncionario)
    {
        return await _eventoFuncionarioService.DeleteEventoFuncionario(eventoFuncionario.Id);
    }

    [HttpPut("EditarEventoFuncionario")]
    public async Task<ActionResult<EventoFuncionario>> EditarEventoFuncionario([FromBody] EventoFuncionario eventoFuncionario)
    {
        return await _eventoFuncionarioService.UpdateEventoFuncionario(eventoFuncionario);
    }
}
