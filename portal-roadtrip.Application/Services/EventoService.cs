using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Interfaces;
using portal_roadtrip.Persistence.Repositorys;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Services;

public class EventoService : IEventoService
{
    private readonly IEventoRepository _eventoRepository;
    private readonly IEventoPontoEmbarqueRepository _eventoPontoEmbarqueRepository;
    private readonly IEventoClienteRepository _eventoClienteRepository;
    private readonly IEventoFuncionarioRepository _funcionarioRepository;
    public EventoService(IEventoRepository eventoRepository, IEventoPontoEmbarqueRepository eventoPontoEmbarqueRepository,
        IEventoClienteRepository eventoClienteRepository, IEventoFuncionarioRepository funcionarioRepository)
    {
        _eventoRepository = eventoRepository;
        _eventoPontoEmbarqueRepository = eventoPontoEmbarqueRepository;
        _eventoClienteRepository = eventoClienteRepository;
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Evento> AddEvento(EventoCadastroDTO dto)
    {
        try
        {
            var evento = new Evento()
            {
                CategoriaEventoId = Convert.ToInt32(dto.Categoria),
                Data = new DateTime(Convert.ToInt32(dto.Data.Substring(0,4)),
                                    Convert.ToInt32(dto.Data.Substring(5, 2)),
                                    Convert.ToInt32(dto.Data.Substring(8, 2))),
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Preco = dto.Preco,
                QuantidadeVagas = dto.QtdVagas,
                Roteiro = dto.Roteiro
            };
            var response = await _eventoRepository.AddAsycn(evento);

            await _eventoRepository.SaveChangesAsync();

            foreach (var item in dto.PontoEmbarque)
            {
                var eventoPontoEmbarque = new EventoPontoEmbarque()
                {
                    EventoId = response.Id,
                    PontoEmbarqueId = item
                };

                await _eventoPontoEmbarqueRepository.AddAsycn(eventoPontoEmbarque);
            }

            await _eventoPontoEmbarqueRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<Evento> BuscarEvento(int eventoId)
    {
        var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == eventoId).FirstOrDefaultAsync();
        return eventoAux;
    }

    public async Task<bool> DeleteEvento(int eventoId)
    {
        try
        {
            var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == eventoId).FirstOrDefaultAsync();
            if (eventoAux == null) return false;

            _eventoRepository.Delete(eventoAux);
            await _eventoRepository.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<EventoDTO>> ListarEventos()
    {
        try
        {
            var listaEventos = await _eventoRepository.AsQueryable()
                .Include(x => x.CategoriaEvento)
                .Include(x => x.EventoPontoEmbarque)
                .ThenInclude(y => y.PontoEmbarque)
                .Include(x => x.EventoCliente)
                .ThenInclude(y => y.Cliente)
                .OrderBy(x => x.Data).ToListAsync();
            var dto = new List<EventoDTO>();

            
            foreach (var item in listaEventos)
            {

                var pontoEmbarque = await _eventoPontoEmbarqueRepository.AsQueryable().Include(x => x.PontoEmbarque).Where(x => x.EventoId == item.Id).ToListAsync();
                var eventoCliente = await _eventoClienteRepository.AsQueryable().Include(x => x.Cliente).Where(x => x.EventoId == item.Id).ToListAsync();
                var funcionarios = await _funcionarioRepository.AsQueryable().Include(x => x.Funcionario).ThenInclude(y => y.Cargo).Where(x => x.EventoId == item.Id).ToListAsync();

                var eventoDto = new EventoDTO()
                {
                    Categoria = item.CategoriaEvento.Descricao,
                    Nome = item.Nome,
                    Data = item.Data.ToShortDateString(),
                    Id = item.Id,
                    QtdVagas = item.QuantidadeVagas,
                    QtdVagasDisponiveis = (item.QuantidadeVagas) - (eventoCliente.Count),
                    Descricao = item.Descricao,
                    Roteiro = item.Roteiro,
                    Preco = item.Preco,
                    PontoEmbarque = pontoEmbarque.Select(x => x.PontoEmbarque.Descricao).ToList()
                };

                foreach (var cliente in eventoCliente)
                {
                    var clienteDto = new ClienteDTO()
                    {
                        Nome = cliente.Cliente.Nome + cliente.Cliente.Sobrenome,
                        CPF = cliente.Cliente.CPF,
                        Telefone = cliente.Cliente.Telefone,
                        RG = cliente.Cliente.RG,
                        OrgaoEmissor = cliente.Cliente.OrgaoEmissor,
                        Email = cliente.Cliente.Email
                    };

                    eventoDto.Cliente.Add(clienteDto);
                }

                foreach (var funcionario in funcionarios)
                {
                    var staff = new StaffDTO()
                    {
                        Nome = funcionario.Funcionario.Nome,
                        Cargo = funcionario.Funcionario.Cargo.Descricao
                    };

                    eventoDto.Staff.Add(staff);
                }
                dto.Add(eventoDto);
            }
            return dto;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<Evento> UpdateEvento(Evento evento)
    {
        try
        {
            var eventoAux = await _eventoRepository.AsQueryable().Where(x => x.Id == evento.Id).FirstOrDefaultAsync();
            if (eventoAux == null) return null;

            var response = _eventoRepository.UpdateAsycn(evento);
            await _eventoRepository.SaveChangesAsync();
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
