using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface ICategoriaEventoService 
{
    Task<CategoriaEvento> AddCategoriaEventoo(CategoriaEvento CategoriaEvento);
    Task<CategoriaEvento> UpdateCategoriaEvento(CategoriaEvento CategoriaEvento);
    Task<bool> DeleteCategoriaEvento(int CategoriaEventoId);
    Task<List<CategoriaEvento>> ListarCategoriaEventos();
    Task<CategoriaEvento> BuscarCategoriaEvento(int CategoriaEventoId);
}
