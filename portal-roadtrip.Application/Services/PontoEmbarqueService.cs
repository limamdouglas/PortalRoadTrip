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

public class PontoEmbarqueService : IPontoEmbarqueService
{
    private readonly IPontoEmbarqueRepository PontoEmbarqueRepository;
    public PontoEmbarqueService(IPontoEmbarqueRepository pontoEmbarqueRepository)
    {
        PontoEmbarqueRepository = pontoEmbarqueRepository;
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

    public Task<PontoEmbarque> UpdatePontoEmbarque(PontoEmbarque PontoEmbarque)
    {
        throw new NotImplementedException();
    }
}
