using portal_roadtrip.Application.DTO;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IEventoClienteService
{
    Task<EventoClienteDTO> SalvarEventoCliente(EventoClienteDTO dto);
    Task<List<EventoClienteDTO>> ListarEventosCliente();
    Task<EventoClienteDTO> BuscarEventoClienteDTO();
    Task<List<ClienteEventoDTO>> ListarEventosPorCliente(int idCliente);
}
