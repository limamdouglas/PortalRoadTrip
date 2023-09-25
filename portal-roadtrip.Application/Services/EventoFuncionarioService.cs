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

public class EventoFuncionarioService : IEventoFuncionarioService
{
    private readonly IEventoFuncionarioRepository _eventoFuncionarioRepository;
    public EventoFuncionarioService(IEventoFuncionarioRepository eventoFuncionarioRepository)
    {
        _eventoFuncionarioRepository = eventoFuncionarioRepository;
    }
    public async Task<EventoFuncionario> AddEventoFuncionario(EventoFuncionario eventoFuncionario)
    {
        try
        {
            var response = await _eventoFuncionarioRepository.AddAsycn(eventoFuncionario);

            await _eventoFuncionarioRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
        
    public async Task<EventoFuncionario> BuscarEventoFuncionario(int eventoFuncionarioId)
    {
        var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionarioId).FirstOrDefaultAsync();
        return usuarioAux;
    }

    public async Task<bool> DeleteEventoFuncionario(int eventoFuncionarioId)
    {
            try
            {
                var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionarioId).FirstOrDefaultAsync();
                if (usuarioAux == null) return false;

            _eventoFuncionarioRepository.Delete(usuarioAux);
                await _eventoFuncionarioRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    public async Task<List<EventoFuncionario>> ListarEventoFuncionarios()
    {
            try
            {
                var listaUsuario = await _eventoFuncionarioRepository.AsQueryable().ToListAsync();
                return listaUsuario;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    public async Task<EventoFuncionario> UpdateEventoFuncionario(EventoFuncionario eventoFuncionario)
    {
            try
            {
                var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionario.Id).FirstOrDefaultAsync();
                if (usuarioAux == null) return null;

                var response = _eventoFuncionarioRepository.UpdateAsycn(eventoFuncionario);
                await _eventoFuncionarioRepository.SaveChangesAsync();
                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }
}
