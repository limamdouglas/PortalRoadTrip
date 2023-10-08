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

public class EventoFuncionarioService : IEventoFuncionarioService
{
    private readonly IEventoFuncionarioRepository _eventoFuncionarioRepository;
    private readonly IFuncionarioRepository _funcionarioRepository;
    public EventoFuncionarioService(IEventoFuncionarioRepository eventoFuncionarioRepository,
        IFuncionarioRepository funcionarioRepository)
    {
        _eventoFuncionarioRepository = eventoFuncionarioRepository;
        _funcionarioRepository = funcionarioRepository;
    }
    public async Task<EventoFuncionario> AddEventoFuncionario(EventoFuncionarioDTO dto)
    {
        try
        {
            var eventoId = dto.EventoId;
            var relacionamentoEventoFuncionario = await _eventoFuncionarioRepository
            .AsQueryable()
            .Where(x => x.EventoId == eventoId)
            .ToListAsync();

            var funcionariosEmStaffEvento = dto.StaffEvento.Select(s => s.Id).ToList();

            foreach (var relacionamento in relacionamentoEventoFuncionario)
            {
                if (!funcionariosEmStaffEvento.Contains(relacionamento.FuncionarioId))
                {
                    _eventoFuncionarioRepository.Delete(relacionamento);
                }
            }

            foreach (var funcionarioId in funcionariosEmStaffEvento)
            {
                if (!relacionamentoEventoFuncionario.Any(x => x.FuncionarioId == funcionarioId))
                {
                    var novoRelacionamento = new EventoFuncionario
                    {
                        EventoId = eventoId,
                        FuncionarioId = funcionarioId
                    };

                    await _eventoFuncionarioRepository.AddAsycn(novoRelacionamento);
                }
            }

            await _eventoFuncionarioRepository.SaveChangesAsync();

            return new EventoFuncionario();
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<EventoFuncionario> BuscarEventoFuncionario(int eventoFuncionarioId)
    {
        var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionarioId).FirstOrDefaultAsync();
        return usuarioAux;
    }

    public async Task<bool> DeleteEventoFuncionario(int eventoFuncionarioId)
    {
        try
        {
            var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionarioId).FirstOrDefaultAsync();
            if (usuarioAux == null) return false;

            _eventoFuncionarioRepository.Delete(usuarioAux);
            await _eventoFuncionarioRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<EscalaDTO>> ListarEventoFuncionarios()
    {
        try
        {
            var listaUsuario = await _eventoFuncionarioRepository
                .AsQueryable()
                .Include(x => x.Evento)
                .Include(x => x.Funcionario)
                .ThenInclude(x => x.Cargo)
                .ToListAsync();

            var response = listaUsuario
                .GroupBy(x => x.Evento.Nome)
                .Select(group => new EscalaDTO
                {
                    Evento = group.Key,
                    Guia = group.FirstOrDefault(item => item.Funcionario.Cargo.Descricao == "Guia")?.Funcionario.Nome,
                    Suporte = group.FirstOrDefault(item => item.Funcionario.Cargo.Descricao == "Suporte de Guia")?.Funcionario.Nome,
                    Fotografo = group.FirstOrDefault(item => item.Funcionario.Cargo.Descricao == "Fotografo")?.Funcionario.Nome
                })
                .ToList();

            return response;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<EventoFuncionarioDTO> ListarEventosFuncionarios(int eventoId)
    {
        try
        {
            var listaFuncionario = await _funcionarioRepository.AsQueryable()
               .Include(x => x.Cargo)
               .Where(x => (x.CargoId == 5) || (x.CargoId == 7) || (x.CargoId == 8))
               .ToListAsync();

            var listaRelacionamentoFuncionarioEvento = await _eventoFuncionarioRepository.AsQueryable()
                .Include(x => x.Funcionario)
                .ThenInclude(x => x.Cargo)
                .Where(x => x.EventoId == eventoId)
                .ToListAsync();

            var response = new EventoFuncionarioDTO();

            var listaFuncionarioDTO = new List<StaffDTO>();
            var listaRelacionamentoFuncionarioEventoDTO = new List<StaffDTO>();

            foreach (var item in listaFuncionario)
            {
                listaFuncionarioDTO.Add(new StaffDTO()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Cargo = item.Cargo.Descricao
                });
            }

            foreach (var item in listaRelacionamentoFuncionarioEvento)
            {
                listaRelacionamentoFuncionarioEventoDTO.Add(new StaffDTO()
                {
                    Id = item.FuncionarioId,
                    Nome = item.Funcionario.Nome,
                    Cargo = item.Funcionario.Cargo.Descricao
                });
            }

            response.Staff = listaFuncionarioDTO;
            response.StaffEvento = listaRelacionamentoFuncionarioEventoDTO;
            return response;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<EventoFuncionario> UpdateEventoFuncionario(EventoFuncionario eventoFuncionario)
    {
        try
        {
            var usuarioAux = await _eventoFuncionarioRepository.AsQueryable().Where(x => x.Id == eventoFuncionario.Id).FirstOrDefaultAsync();
            if (usuarioAux == null) return null;

            var response = _eventoFuncionarioRepository.UpdateAsycn(eventoFuncionario);
            await _eventoFuncionarioRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
