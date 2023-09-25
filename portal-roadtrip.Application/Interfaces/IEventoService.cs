using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IEventoService
{
    Task<Evento> AddEvento(Evento evento);
    Task<Evento> UpdateEvento(Evento evento);
    Task<bool> DeleteEvento(int eventoId);
    Task<List<Evento>> ListarEventos();
    Task<Evento> BuscarEvento(int eventoId);
}
