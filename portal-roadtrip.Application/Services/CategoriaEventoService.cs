using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class CategoriaEventoService : ICategoriaEventoService
{
    private readonly ICategoriaEventoRepository _categoriaEventoRepository;
    public CategoriaEventoService(ICategoriaEventoRepository categoriaEventoRepository)
    {
        _categoriaEventoRepository = categoriaEventoRepository;
    }
    public Task<CategoriaEvento> AddCategoriaEventoo(CategoriaEvento CategoriaEvento)
    {
        throw new NotImplementedException();
    }

    public Task<CategoriaEvento> BuscarCategoriaEvento(int CategoriaEventoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCategoriaEvento(int CategoriaEventoId)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoriaEvento>> ListarCategoriaEventos()
    {
        throw new NotImplementedException();
    }

    public Task<CategoriaEvento> UpdateCategoriaEvento(CategoriaEvento CategoriaEvento)
    {
        throw new NotImplementedException();
    }
}
