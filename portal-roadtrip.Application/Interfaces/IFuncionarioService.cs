using portal_roadtrip.Application.DTO;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IFuncionarioService
{
    Task<FuncionarioDTO> AddFuncionario(FuncionarioCadastroDTO Funcionario);
    Task<Funcionario> UpdateFuncionario(Funcionario Funcionario);
    Task<bool> DeleteFuncionario(int FuncionarioId);
    Task<List<FuncionarioDTO>> ListarFuncionarios();
    Task<FuncionarioDTO> BuscarFuncionario(int FuncionarioId);
}
