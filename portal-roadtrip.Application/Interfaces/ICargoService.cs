using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface ICargoService
{
    Task<Cargo> AddCargo(Cargo Cargo);
    Task<Cargo> UpdateCargo(Cargo Cargo);
    Task<bool> DeleteCargo(int CargoId);
    Task<List<Cargo>> ListarCargos();
    Task<Cargo> BuscarCargo(int CargoId);
}
