using portal_roadtrip.Application.DTO;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IPontoEmbarqueService
{
    Task<PontoEmbarque> AddPontoEmbarque(PontoEmbarque PontoEmbarque);
    Task<PontoEmbarque> UpdatePontoEmbarque(PontoEmbarque PontoEmbarque);
    Task<bool> DeletePontoEmbarque(int PontoEmbarqueId);
    Task<List<PontoEmbarque>> ListarPontoEmbarques();
    Task<PontoEmbarque> BuscarPontoEmbarque(int PontoEmbarqueId);
    Task<List<PontoEmbarqueEventoDTO>> ListarPontoEmbarquesPorEvento(int idEvento);
}
