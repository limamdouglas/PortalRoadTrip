using Microsoft.EntityFrameworkCore;
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

public class FuncionarioService : IFuncionarioService
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    public FuncionarioService(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Funcionario> AddFuncionario(Funcionario funcionario)
    {
        try
        {
            var response = await _funcionarioRepository.AddAsycn(funcionario);

            await _funcionarioRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<Funcionario> BuscarFuncionario(int funcionarioId)
    {
        var funcionarioAux = await _funcionarioRepository.AsQueryable().Where(x => x.Id == funcionarioId).FirstOrDefaultAsync();
        return funcionarioAux;
    }

    public async Task<bool> DeleteFuncionario(int funcionarioId)
    {
        try
        {
            var FuncionarioAux = await _funcionarioRepository.AsQueryable().Where(x => x.Id == funcionarioId).FirstOrDefaultAsync();
            if (FuncionarioAux == null) return false;

            _funcionarioRepository.Delete(FuncionarioAux);
            await _funcionarioRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<Funcionario>> ListarFuncionarios()
    {
        try
        {
            var listaFuncionario = await _funcionarioRepository.AsQueryable().ToListAsync();
            return listaFuncionario;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<Funcionario> UpdateFuncionario(Funcionario funcionario)
    {
        try
        {
            var FuncionarioAux = await _funcionarioRepository.AsQueryable().Where(x => x.Id == funcionario.Id).FirstOrDefaultAsync();
            if (FuncionarioAux == null) return null;

            var response = _funcionarioRepository.UpdateAsycn(funcionario);
            await _funcionarioRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
