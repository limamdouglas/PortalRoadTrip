using portal_roadtrip.Domain.Shared.Models;

namespace portal_roadtrip.Persistence.Shared;

public static class DadosEstadosBr
{
    public static List<EstadosBr> GetEstados()
    {
        var listaEstadosBr = new List<EstadosBr>()
        {
            new EstadosBr()
            {
                Id = 1,
                Sigla = "AC",
                Nome = "Acre"
            },
            new EstadosBr()
            {
                Id = 2,
                Sigla = "AL",
                Nome = "Alagoas"
            },
            new EstadosBr()
            {
                Id = 3,
                Sigla = "AM",
                Nome = "Amazonas"
            },
            new EstadosBr()
            {
                Id = 4,
                Sigla = "AP",
                Nome = "Amapá"
            },
            new EstadosBr()
            {
                Id = 5,
                Sigla = "BA",
                Nome = "Bahia"
            },
            new EstadosBr()
            {
                Id = 6,
                Sigla = "CE",
                Nome = "Ceara"
            },
            new EstadosBr()
            {
                Id = 7,
                Sigla = "DF",
                Nome = "Distrito Federal"
            },
            new EstadosBr()
            {
                Id = 8,
                Sigla = "ES",
                Nome = "Espírito Santo"
            },
            new EstadosBr()
            {
                Id = 9,
                Sigla = "GO",
                Nome = "Goiás"
            },
            new EstadosBr()
            {
                Id = 10,
                Sigla = "MA",
                Nome = "Maranhão"
            },
            new EstadosBr()
            {
                Id = 11,
                Sigla = "MG",
                Nome = "Minas Gerais"
            },
            new EstadosBr()
            {
                Id = 12,
                Sigla = "MS",
                Nome = "Mato Grosso do Sul"
            },
            new EstadosBr()
            {
                Id = 13,
                Sigla = "MT",
                Nome = "Mato Grosso"
            },
            new EstadosBr()
            {
                Id = 14,
                Sigla = "PA",
                Nome = "Pará"
            },
            new EstadosBr()
            {
                Id = 15,
                Sigla = "PB",
                Nome = "Paraíba"
            },
            new EstadosBr()
            {
                Id = 16,
                Sigla = "PE",
                Nome = "Pernambuco"
            },
            new EstadosBr()
            {
                Id = 17,
                Sigla = "PI",
                Nome = "Piauí"
            },
            new EstadosBr()
            {
                Id = 18,
                Sigla = "PR",
                Nome = "Paraná"
            },
            new EstadosBr()
            {
                Id = 19,
                Sigla = "RJ",
                Nome = "Rio de Janeiro"
            },
            new EstadosBr()
            {
                Id = 20,
                Sigla = "RN",
                Nome = "Rio Grande do Norte"
            },
            new EstadosBr()
            {
                Id = 21,
                Sigla = "RO",
                Nome = "Rondônia"
            },
            new EstadosBr()
            {
                Id = 22,
                Sigla = "RR",
                Nome = "Roraima"
            },
            new EstadosBr()
            {
                Id = 23,
                Sigla = "RS",
                Nome = "Rio Grande do Sul"
            },
            new EstadosBr()
            {
                Id = 24,
                Sigla = "SC",
                Nome = "Santa Catarina"
            },
            new EstadosBr()
            {
                Id = 25,
                Sigla = "SE",
                Nome = "Sergipe"
            },
            new EstadosBr()
            {
                Id = 26,
                Sigla = "SP",
                Nome = "São Paulo"
            },new EstadosBr()
            {
                Id = 27,
                Sigla = "TO",
                Nome = "Tocantins"
            }
        };

        return listaEstadosBr;
    }
}
