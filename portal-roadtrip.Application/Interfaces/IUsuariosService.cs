using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IUsuariosService
{
    Task<Usuario> AddUsuario(Usuario usuario);
    Task<Usuario> UpdateUsuario(Usuario usuario);
    Task<bool> DeleteUsuario(int usuarioId);
    Task<List<Usuario>> ListarUsuarios();
    Task<Usuario> BuscarUsuario(int usuarioId);
}
