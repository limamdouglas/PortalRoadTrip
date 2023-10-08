using portal_roadtrip.Application.DTO;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IEventoFuncionarioService
{
    Task<EventoFuncionario> AddEventoFuncionario(EventoFuncionarioDTO dto);
    Task<EventoFuncionario> UpdateEventoFuncionario(EventoFuncionario EventoFuncionario);
    Task<bool> DeleteEventoFuncionario(int EventoFuncionarioId);
    Task<List<EscalaDTO>> ListarEventoFuncionarios();
    Task<EventoFuncionarioDTO> ListarEventosFuncionarios(int eventoId);
    Task<EventoFuncionario> BuscarEventoFuncionario(int EventoFuncionarioId);
}
