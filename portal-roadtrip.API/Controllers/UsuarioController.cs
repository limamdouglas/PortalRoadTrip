using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;


[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuariosService UsuarioService;
    public UsuarioController(IUsuariosService usuarioService)
    {
        UsuarioService = usuarioService;
    }

    [HttpGet("ListarUsuarios")]
    public async Task<List<Usuario>> ListarUsuarios()
    {
        return await UsuarioService.ListarUsuarios();
    }

    [HttpGet("BuscarUsuario")]
    public async Task<ActionResult<Usuario>> BuscarUsuarioAsync(int usuarioId)
    {
        return await UsuarioService.BuscarUsuario(usuarioId);
    }

    [HttpPost("AddUsuario")]
    public async Task<ActionResult<Usuario>> BuscarUsuarioAsync([FromBody] Usuario usuario)
    {
        return await UsuarioService.AddUsuario(usuario);
    }

    [HttpDelete("DeletarUsuario")]
    public async Task<ActionResult<bool>> DeletarUsuario([FromBody] Usuario usuario)
    {
        return await UsuarioService.DeleteUsuario(usuario.Id);
    }

    [HttpPut("EditarUsuario")]
    public async Task<ActionResult<Usuario>> EditarUsuario([FromBody] Usuario usuario)
    {
        return await UsuarioService.UpdateUsuario(usuario);
    }
}
