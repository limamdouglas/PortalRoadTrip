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

public class FuncionarioService : IFuncionarioService
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    public FuncionarioService(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<FuncionarioDTO> AddFuncionario(FuncionarioCadastroDTO dto)
    {
        try
        {
            var funcionario = new Funcionario()
            {
                CargoId = dto.CargoId,
                CPF = dto.CPF,
                DataAdmissao = DateTime.Now.ToString(),
                Nome = dto.Nome,
                OrgaoEmissor = dto.OrgaoEmissor,
                RG = dto.RG
            };
            var response = await _funcionarioRepository.AddAsycn(funcionario);

            await _funcionarioRepository.SaveChangesAsync();

            return new FuncionarioDTO()
            {
                Id = response.Id,
                Nome = response.Nome
            };
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<FuncionarioDTO> BuscarFuncionario(int funcionarioId)
    {
        var funcionarioAux = await _funcionarioRepository.AsQueryable().Where(x => x.Id == funcionarioId).FirstOrDefaultAsync();
        var dto = new FuncionarioDTO()
        {
            Cargo = funcionarioAux.Cargo.Descricao,
            CPF = funcionarioAux.CPF,
            DataAdmissao = funcionarioAux.DataAdmissao,
            DataDemissao = funcionarioAux.DataDemissao,
            Id = funcionarioAux.Id,
            Nome = funcionarioAux.Nome,
            OrgaoEmissor = funcionarioAux.OrgaoEmissor,
            RG = funcionarioAux.RG
        };
        return dto;
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

    public async Task<List<FuncionarioDTO>> ListarFuncionarios()
    {
        try
        {
            var listaFuncionario = await _funcionarioRepository.AsQueryable()
                .Include(x => x.Cargo)
                .Where(x => (x.CargoId == 5) || (x.CargoId == 7) || (x.CargoId == 8))
                .ToListAsync();

            var response = new List<FuncionarioDTO>();

            foreach (var item in listaFuncionario)
            {
                var dto = new FuncionarioDTO()
                {
                    Cargo = item.Cargo.Descricao,
                    CPF = item.CPF,
                    DataAdmissao = item.DataAdmissao,
                    DataDemissao = item.DataDemissao,
                    Id = item.Id,
                    Nome = item.Nome,
                    OrgaoEmissor = item.OrgaoEmissor,
                    RG = item.RG
                };

                response.Add(dto);
            }
            return response;
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
