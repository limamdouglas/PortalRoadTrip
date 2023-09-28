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

public class EventoService : IEventoService
{
    private readonly IEventoRepository _eventoRepository;
    public EventoService(IEventoRepository eventoRepository)
    {
        _eventoRepository = eventoRepository;
    }

    public async Task<Evento> AddEvento(EventoDTO dto)
    {
        try
        {
            var response = await _eventoRepository.AddAsycn(new Evento());

            await _eventoRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<Evento> BuscarEvento(int eventoId)
    {
        var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == eventoId).FirstOrDefaultAsync();
        return eventoAux;
    }

    public async Task<bool> DeleteEvento(int eventoId)
    {
        try
        {
            var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == eventoId).FirstOrDefaultAsync();
            if (eventoAux == null) return false;

            _eventoRepository.Delete(eventoAux);
            await _eventoRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<Evento>> ListarEventos()
    {
        try
        {
            var listaUsuario = await _eventoRepository.AsQueryable().ToListAsync();
            return listaUsuario;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<Evento> UpdateEvento(Evento evento)
    {
        try
        {
            var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == evento.Id).FirstOrDefaultAsync();
            if (eventoAux == null) return null;

            var response = _eventoRepository.UpdateAsycn(evento);
            await _eventoRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
