using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class EstornoService : IEstornoService
{
    private readonly IEstornoRepository _estornoRepository;
    public EstornoService(IEstornoRepository estornoRepository)
    {
        _estornoRepository = estornoRepository;
    }

    public Task<Estorno> BuscarEstorno(string cpf)
    {
        throw new NotImplementedException();
    }

    public Task<List<Estorno>> ListarEstornos()
    {
        throw new NotImplementedException();
    }

    public Task<Estorno> SalvarEstorno(Estorno dto)
    {
        throw new NotImplementedException();
    }
}
