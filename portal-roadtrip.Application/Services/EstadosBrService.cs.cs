using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Shared.Models;
using portal_roadtrip.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class EstadosBrService : IEstadosBrService
{
    public List<EstadosBr> ListarEstadosBr()
    {
        return DadosEstadosBr.GetEstados();
    }
}
