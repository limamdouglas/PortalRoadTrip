using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Application.Shared;
using portal_roadtrip.Domain.Shared.Models;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MesController : ControllerBase
{
    public MesController()
    {
    }

    [HttpGet("ListarMeses")]
    public List<Mes> ListarMeses()
    {
        return MesService.GetMeses();
    }
}
