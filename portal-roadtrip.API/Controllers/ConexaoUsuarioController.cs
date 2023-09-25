using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ConexaoUsuarioController : ControllerBase
{
    private readonly IConexaoUsuarioService _conexaoUsuarioService;
    public ConexaoUsuarioController(IConexaoUsuarioService conexaoUsuarioService)
    {
        _conexaoUsuarioService = conexaoUsuarioService;
    }

    [HttpGet("ListarConexaoUsuarios")]
    public async Task<List<ConexaoUsuario>> ListarConexaoUsuarios()
    {
        return await _conexaoUsuarioService.ListarConexaoUsuarios();
    }

    [HttpGet("BuscarConexaoUsuario")]
    public async Task<ActionResult<ConexaoUsuario>> BuscarConexaoUsuarioAsync(int conexaoUsuarioId)
    {
        return await _conexaoUsuarioService.BuscarConexaoUsuario(conexaoUsuarioId);
    }

    [HttpPost("AddConexaoUsuario")]
    public async Task<ActionResult<ConexaoUsuario>> AddConexaoUsuario([FromBody] ConexaoUsuario conexaoUsuario)
    {
        return await _conexaoUsuarioService.AddConexaoUsuario(conexaoUsuario);
    }

    [HttpDelete("DeletarConexaoUsuario")]
    public async Task<ActionResult<bool>> DeletarConexaoUsuario([FromBody] ConexaoUsuario conexaoUsuario)
    {
        return await _conexaoUsuarioService.DeleteConexaoUsuario(conexaoUsuario.Id);
    }

    [HttpPut("EditarConexaoUsuario")]
    public async Task<ActionResult<ConexaoUsuario>> EditarConexaoUsuario([FromBody] ConexaoUsuario conexaoUsuario)
    {
        return await _conexaoUsuarioService.UpdateConexaoUsuario(conexaoUsuario);
    }
}
