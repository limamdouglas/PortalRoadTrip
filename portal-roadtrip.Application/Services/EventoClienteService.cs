using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class EventoClienteService : IEventoClienteService
{
    private readonly IEventoClienteRepository _eventoClienteRepository;
    private readonly IEventoRepository _eventoRepository;
    public EventoClienteService(IEventoClienteRepository eventoClienteRepository, IEventoRepository eventoRepository)
    {
        _eventoClienteRepository = eventoClienteRepository;
        _eventoRepository = eventoRepository;
    }

    public Task<EventoClienteDTO> BuscarEventoClienteDTO()
    {
        throw new NotImplementedException();
    }

    public Task<List<EventoClienteDTO>> ListarEventosCliente()
    {
        throw new NotImplementedException();
    }

    public async Task<List<ClienteEventoDTO>> ListarEventosPorCliente()
    {
        try
        {
            var eventos = await _eventoClienteRepository.AsQueryable()
                                                        .Include(x => x.Evento)
                                                        .Where(x => x.ClienteID == 1)
                                                        .OrderBy(x => x.Evento.Data).ToListAsync();

            var eventosDTO = new List<ClienteEventoDTO>();

            foreach (var item in eventos)
            {
                var evento = new ClienteEventoDTO()
                {
                    Data = item.Evento.Data.ToShortDateString(),
                    Evento = item.Evento.Nome,
                    PodeAvaliar = (item.Evento.Data <= DateTime.Now) ? true : false,
                    QtdDias = (item.Evento.Data < DateTime.Now) ? 0 : (item.Evento.Data - DateTime.Now).Days
                };

                eventosDTO.Add(evento);
            }

            return eventosDTO;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<EventoClienteDTO> SalvarEventoCliente(EventoClienteDTO dto)
    {
        try
        {
            var eventoCliente = new EventoCliente()
            {
                ClienteID = dto.ClienteId,
                EhReserva = dto.EhReserva,
                EventoId = dto.Evento,
                QuantidadeVaga = dto.Quantidade
            };

            await _eventoClienteRepository.AddAsycn(eventoCliente);

            await _eventoClienteRepository.SaveChangesAsync();
            return dto;
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
