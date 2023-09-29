using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly IEventoService EventoService;
    public EventoController(IEventoService eventoService)
    {
        EventoService = eventoService;
    }

    [HttpGet("ListarEventos")]
    public async Task<List<Evento>> ListarEventos()
    {
        return await EventoService.ListarEventos();
    }

    [HttpGet("BuscarEvento")]
    public async Task<ActionResult<Evento>> BuscarEventoAsync(int eventoId)
    {
        return await EventoService.BuscarEvento(eventoId);
    }

    [HttpPost("AddEvento")]
    public async Task<Evento> AddEvento([FromBody] EventoDTO dto)
    {
        return await EventoService.AddEvento(dto);
        //try
        //{
        //    var evento = await EventoService.AddEvento(dto);
        //    if (evento == null) return NoContent();

        //    return Ok(evento);
        //}
        //catch (Exception ex)
        //{
        //    return this.StatusCode(StatusCodes.Status500InternalServerError,
        //        $"Erro ao tentar adicionar eventos. Erro: {ex.Message}");
        //}
    }

    [HttpDelete("DeletarEvento")]
    public async Task<ActionResult<bool>> DeletarEvento([FromBody] Evento evento)
    {
        return await EventoService.DeleteEvento(evento.Id);
    }

    [HttpPut("EditarEvento")]
    public async Task<ActionResult<Evento>> EditarEvento([FromBody] Evento evento)
    {
        return await EventoService.UpdateEvento(evento);
    }
}
