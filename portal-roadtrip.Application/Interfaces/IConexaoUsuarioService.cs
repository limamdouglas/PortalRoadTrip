using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IConexaoUsuarioService
{
    Task<ConexaoUsuario> AddConexaoUsuario(ConexaoUsuario ConexaoUsuario);
    Task<ConexaoUsuario> UpdateConexaoUsuario(ConexaoUsuario ConexaoUsuario);
    Task<bool> DeleteConexaoUsuario(int ConexaoUsuarioId);
    Task<List<ConexaoUsuario>> ListarConexaoUsuarios();
    Task<ConexaoUsuario> BuscarConexaoUsuario(int ConexaoUsuarioId);
}
