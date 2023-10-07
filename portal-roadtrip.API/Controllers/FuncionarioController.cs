using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioService FuncionarioService; 
    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        FuncionarioService = funcionarioService;
    }
    [HttpGet("ListarFuncionarios")]
    public async Task<List<FuncionarioDTO>> ListarFuncionarios()
    {
        return await FuncionarioService.ListarFuncionarios();
    }

    [HttpGet("BuscarFuncionario")]
    public async Task<ActionResult<FuncionarioDTO>> BuscarFuncionario(int cargoId)
    {
        return await FuncionarioService.BuscarFuncionario(cargoId);
    }

    [HttpPost("AddFuncionario")]
    public async Task<ActionResult<FuncionarioDTO>> AddFuncionario([FromBody] FuncionarioCadastroDTO dto)
    {
        return await FuncionarioService.AddFuncionario(dto);
    }
}
