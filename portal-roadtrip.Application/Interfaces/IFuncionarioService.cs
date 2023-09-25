using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IFuncionarioService
{
    Task<Funcionario> AddFuncionario(Funcionario Funcionario);
    Task<Funcionario> UpdateFuncionario(Funcionario Funcionario);
    Task<bool> DeleteFuncionario(int FuncionarioId);
    Task<List<Funcionario>> ListarFuncionarios();
    Task<Funcionario> BuscarFuncionario(int FuncionarioId);
}
