using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Domain.Shared.Models;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EstadosBrController : ControllerBase
{
    private readonly IEstadosBrService EstadosBrService;
    public EstadosBrController(IEstadosBrService estadosBrService)
    {
        EstadosBrService = estadosBrService;
    }

    [HttpGet("ListarCategoriaEventos")]
    public List<EstadosBr> ListarEstadosBr()
    {
        return EstadosBrService.ListarEstadosBr();
    }
}
