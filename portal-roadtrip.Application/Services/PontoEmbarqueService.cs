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

public class PontoEmbarqueService : IPontoEmbarqueService
{
    private readonly IPontoEmbarqueRepository PontoEmbarqueRepository;
    private readonly IEventoPontoEmbarqueRepository EventoPontoEmbarqueRepository;
    public PontoEmbarqueService(IPontoEmbarqueRepository pontoEmbarqueRepository, IEventoPontoEmbarqueRepository eventoPontoEmbarqueRepository)
    {
        PontoEmbarqueRepository = pontoEmbarqueRepository;
        EventoPontoEmbarqueRepository = eventoPontoEmbarqueRepository;
    }
    public Task<PontoEmbarque> AddPontoEmbarque(PontoEmbarque PontoEmbarque)
    {
        throw new NotImplementedException();
    }

    public Task<PontoEmbarque> BuscarPontoEmbarque(int PontoEmbarqueId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePontoEmbarque(int PontoEmbarqueId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PontoEmbarque>> ListarPontoEmbarques()
    {
        try
        {
            var listaPontoEmbarque = await PontoEmbarqueRepository.AsQueryable().ToListAsync();
            return listaPontoEmbarque;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<PontoEmbarqueEventoDTO>> ListarPontoEmbarquesPorEvento(int idEvento)
    {
        try
        {
            var listaPontoEmbarqueEvento = await EventoPontoEmbarqueRepository.AsQueryable()
                                     .Include(x => x.PontoEmbarque)
                                     .Where(x => x.EventoId == idEvento).ToListAsync();

            var listaPontoEmbarque = new List<PontoEmbarqueEventoDTO>();

            foreach (var item in listaPontoEmbarqueEvento)
            {
                var pontoEmbarque = new PontoEmbarqueEventoDTO()
                {
                    Id = item.Id,
                    Descricao = item.PontoEmbarque.Descricao,
                    Horario = item.Horario
                };

                listaPontoEmbarque.Add(pontoEmbarque);
            }
            return listaPontoEmbarque;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public Task<PontoEmbarque> UpdatePontoEmbarque(PontoEmbarque PontoEmbarque)
    {
        throw new NotImplementedException();
    }
}
