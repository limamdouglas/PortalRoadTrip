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

public class EventoPontoEmbarqueService : IEventoPontoEmbarqueService
{
    private readonly IEventoPontoEmbarqueRepository _eventoPontoEmbarqueRepository;
    public EventoPontoEmbarqueService(IEventoPontoEmbarqueRepository eventoPontoEmbarqueRepository)
    {
        _eventoPontoEmbarqueRepository = eventoPontoEmbarqueRepository;
    }

    public async Task<EventoPontoEmbarque> AddEventoPontoEmbarque(EventoPontoEmbarque eventoPontoEmbarque)
    {
        try
        {
            var response = await _eventoPontoEmbarqueRepository.AddAsycn(eventoPontoEmbarque);

            await _eventoPontoEmbarqueRepository.SaveChangesAsync();

            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<EventoPontoEmbarque> BuscarEventoPontoEmbarque(int eventoPontoEmbarqueId)
    {
        var usuarioAux = await _eventoPontoEmbarqueRepository.AsQueryable().Where(x => x.Id == eventoPontoEmbarqueId).FirstOrDefaultAsync();
        return usuarioAux;
    }

    public async Task<bool> DeleteEventoPontoEmbarque(int eventoPontoEmbarqueId)
    {
        try
        {
            var usuarioAux = await _eventoPontoEmbarqueRepository.AsQueryable().Where(x => x.Id == eventoPontoEmbarqueId).FirstOrDefaultAsync();
            if (usuarioAux == null) return false;

            _eventoPontoEmbarqueRepository.Delete(usuarioAux);
            await _eventoPontoEmbarqueRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<EventoPontoEmbarque>> ListarEventoPontoEmbarques()
    {
        try
        {
            var listaUsuario = await _eventoPontoEmbarqueRepository.AsQueryable().ToListAsync();
            return listaUsuario;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<EventoPontoEmbarque> UpdateEventoPontoEmbarque(EventoPontoEmbarque eventoPontoEmbarque)
    {
        try
        {
            var usuarioAux = await _eventoPontoEmbarqueRepository.AsQueryable().Where(x => x.Id == eventoPontoEmbarque.Id).FirstOrDefaultAsync();
            if (usuarioAux == null) return null;

            var response = _eventoPontoEmbarqueRepository.UpdateAsycn(eventoPontoEmbarque);
            await _eventoPontoEmbarqueRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
