using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaEventoController : ControllerBase
{
    private readonly ICategoriaEventoService CategoriaEventoService;
    public CategoriaEventoController(ICategoriaEventoService categoriaEventoService)
    {
        CategoriaEventoService = categoriaEventoService;
    }

    [HttpGet("ListarCategoriaEventos")]
    public async Task<List<CategoriaEvento>> ListarCategoriaEventos()
    {
        return await CategoriaEventoService.ListarCategoriaEventos();
    }
}
