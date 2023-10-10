using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class CreditoService : ICreditoService
{
    private readonly ICreditoRepository _creditoRepository;
    public CreditoService(ICreditoRepository creditoRepository)
    {
        _creditoRepository = creditoRepository;
    }
    public Task<Credito> BuscarCredito(string cpf)
    {
        throw new NotImplementedException();
    }

    public Task<List<Credito>> ListarCreditos()
    {
        throw new NotImplementedException();
    }

    public Task<Credito> SalvarCredito(Credito dto)
    {
        throw new NotImplementedException();
    }
}
