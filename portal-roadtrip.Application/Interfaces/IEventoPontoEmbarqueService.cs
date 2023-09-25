using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IEventoPontoEmbarqueService
{
    Task<EventoPontoEmbarque> AddEventoPontoEmbarque(EventoPontoEmbarque EventoPontoEmbarque);
    Task<EventoPontoEmbarque> UpdateEventoPontoEmbarque(EventoPontoEmbarque EventoPontoEmbarque);
    Task<bool> DeleteEventoPontoEmbarque(int EventoPontoEmbarqueId);
    Task<List<EventoPontoEmbarque>> ListarEventoPontoEmbarques();
    Task<EventoPontoEmbarque> BuscarEventoPontoEmbarque(int EventoPontoEmbarqueId);
}
