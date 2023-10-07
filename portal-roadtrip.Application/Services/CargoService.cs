using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using portal_roadtrip.Persistence.Repositorys;
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

    public async Task<Cargo> AddCargo(Cargo cargo)
    {
        var response = await _cargoRepository.AddAsycn(cargo);

        await _cargoRepository.SaveChangesAsync();

        return new Cargo()
        {
            Id = response.Id,
            Descricao = response.Descricao
        };
    }

    public Task<Cargo> BuscarCargo(int CargoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCargo(int CargoId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Cargo>> ListarCargos()
    {
        return await _cargoRepository.AsQueryable().ToListAsync();
    }

    public Task<Cargo> UpdateCargo(Cargo Cargo)
    {
        throw new NotImplementedException();
    }
}
