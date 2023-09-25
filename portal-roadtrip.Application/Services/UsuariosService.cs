using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;

namespace portal_roadtrip.Application.Services;

public class UsuariosService : IUsuariosService
{
    private readonly IUsuarioRepository _usuarioRepository;
    public UsuariosService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<List<Usuario>> ListarUsuarios()
    {
        try
        {
            var listaUsuario = await _usuarioRepository.AsQueryable().ToListAsync();
            return listaUsuario;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public async Task<Usuario> BuscarUsuario(int usuarioId)
    {
        var usuarioAux = await _usuarioRepository.AsQueryable().Where(x => x.Id == usuarioId).FirstOrDefaultAsync();
        return usuarioAux;
    }
    public async Task<Usuario> AddUsuario(Usuario usuario)
    {
        try
        {
            var response = await _usuarioRepository.AddAsycn(usuario);

            await _usuarioRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public async Task<Usuario> UpdateUsuario(Usuario usuario)
    {
        try
        {
            var usuarioAux = await _usuarioRepository.AsQueryable().Where(x => x.Id == usuario.Id).FirstOrDefaultAsync();
            if (usuarioAux == null) return null;

            var response = _usuarioRepository.UpdateAsycn(usuario);
            await _usuarioRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public async Task<bool> DeleteUsuario(int usuarioId)
    {
        try
        {
            var usuarioAux = await _usuarioRepository.AsQueryable().Where(x => x.Id == usuarioId).FirstOrDefaultAsync();
            if (usuarioAux == null) return false;

            _usuarioRepository.Delete(usuarioAux);
            await _usuarioRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }


}
