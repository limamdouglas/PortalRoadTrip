using portal_roadtrip.Domain.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Shared;

public static class DadosMeses
{
    public static List<Mes> GetMeses()
    {
        var meses = new List<Mes>()
        {
            new Mes()
            {
                Id = 1,
                Nome = "Janeiro"
            },
            new Mes()
            {
                Id = 2,
                Nome = "Fevereiro"
            },
            new Mes()
            {
                Id = 3,
                Nome = "Março"
            },
            new Mes()
            {
                Id = 4,
                Nome = "Abril"
            },
            new Mes()
            {
                Id = 5,
                Nome = "Maio"
            },
            new Mes()
            {
                Id = 6,
                Nome = "Junho"
            },
            new Mes()
            {
                Id = 7,
                Nome = "Julho"
            },
            new Mes()
            {
                Id = 8,
                Nome = "Agosto"
            },
            new Mes()
            {
                Id = 9,
                Nome = "Setembro"
            },
            new Mes()
            {
                Id = 10,
                Nome = "Outubro"
            },
            new Mes()
            {
                Id = 11,
                Nome = "Novembro"
            },
            new Mes()
            {
                Id = 12,
                Nome = "Dezembro"
            }
        };

        return meses;
    }
}
