using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class CargoService : ICargoService
{
    private readonly ICargoRepository _cargoRepository;
    public CargoService(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }

    public Task<Cargo> AddCargo(Cargo Cargo)
    {
        throw new NotImplementedException();
    }

    public Task<Cargo> BuscarCargo(int CargoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCargo(int CargoId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Cargo>> ListarCargos()
    {
        throw new NotImplementedException();
    }

    public Task<Cargo> UpdateCargo(Cargo Cargo)
    {
        throw new NotImplementedException();
    }
}
