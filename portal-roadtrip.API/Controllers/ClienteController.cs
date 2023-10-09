using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : Controller
{
    private readonly IClienteService _clienteService;
    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet("ListarClientes")]
    public async Task<List<ClienteDTO>> ListarClientes()
    {
        return await _clienteService.ListarClientes();
    }

    [HttpGet("BuscarCliente/{cpf}")]
    public async Task<ClienteDTO> BuscarCliente(string cpf)
    {
        return await _clienteService.BuscarCliente(cpf);
    }

    [HttpPost("SalvarCliente")]
    public async Task<ActionResult<ClienteDTO>> SalvarCliente([FromBody] ClienteCadastroDTO dto)
    {
        return await _clienteService.SalvarCliente(dto);
    }
}
