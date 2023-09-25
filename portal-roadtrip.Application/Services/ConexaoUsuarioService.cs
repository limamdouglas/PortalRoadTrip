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

public class ConexaoUsuarioService : IConexaoUsuarioService
{
    private readonly IConexaoUsuarioRepository _conexaoUsuarioRepository;
    public ConexaoUsuarioService(IConexaoUsuarioRepository conexaoUsuarioRepository)
    {
        _conexaoUsuarioRepository = conexaoUsuarioRepository;
    }

    public async Task<ConexaoUsuario> AddConexaoUsuario(ConexaoUsuario conexaoUsuario)
    {
        try
        {
            var response = await _conexaoUsuarioRepository.AddAsycn(conexaoUsuario);

            await _conexaoUsuarioRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<ConexaoUsuario> BuscarConexaoUsuario(int conexaoUsuarioId)
    {
        var usuarioAux = await _conexaoUsuarioRepository.AsQueryable().Where(x => x.Id == conexaoUsuarioId).FirstOrDefaultAsync();
        return usuarioAux;
    }

    public async Task<bool> DeleteConexaoUsuario(int conexaoUsuarioId)
    {
        try
        {
            var usuarioAux = await _conexaoUsuarioRepository.AsQueryable().Where(x => x.Id == conexaoUsuarioId).FirstOrDefaultAsync();
            if (usuarioAux == null) return false;

            _conexaoUsuarioRepository.Delete(usuarioAux);
            await _conexaoUsuarioRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<ConexaoUsuario>> ListarConexaoUsuarios()
    {
        try
        {
            var listaUsuario = await _conexaoUsuarioRepository.AsQueryable().ToListAsync();
            return listaUsuario;
        }
        catch (Exception ex)
        {
            return null;
        };
    }

    public async Task<ConexaoUsuario> UpdateConexaoUsuario(ConexaoUsuario conexaoUsuario)
    {
        try
        {
            var usuarioAux = await _conexaoUsuarioRepository.AsQueryable().Where(x => x.Id == conexaoUsuario.Id).FirstOrDefaultAsync();
            if (usuarioAux == null) return null;

            var response = _conexaoUsuarioRepository.UpdateAsycn(conexaoUsuario);
            await _conexaoUsuarioRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
