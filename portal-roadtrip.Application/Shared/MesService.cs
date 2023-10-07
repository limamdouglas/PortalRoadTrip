using portal_roadtrip.Domain.Shared.Models;
using portal_roadtrip.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Shared;

public static class MesService
{
    public static List<Mes> GetMeses()
    {
        return DadosMeses.GetMeses();
    }
}
