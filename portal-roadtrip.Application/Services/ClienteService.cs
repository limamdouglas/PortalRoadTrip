using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

public sealed class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    public async Task<ClienteDTO> SalvarCliente(ClienteCadastroDTO dto)
    {
        try
        {
            var cliente = new Cliente()
            {
                Nome = dto.Nome,
                Sobrenome = dto.Sobrenome,
                CPF = dto.CPF,
                RG = dto.RG,
                OrgaoEmissor = dto.OrgaoEmissor,
                DataNascimento = dto.DataNascimento,
                Email = dto.Email,
                Telefone = dto.Telefone,
                RegiaoOndeMora = dto.Regiao
            };

            var response = await _clienteRepository.AddAsycn(cliente);
            await _clienteRepository.SaveChangesAsync();

            return new ClienteDTO();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<ClienteDTO>> ListarClientes()
    {
        var clientes = await _clienteRepository.AsQueryable().ToListAsync();

        var respose = new List<ClienteDTO>();
        foreach (var item in clientes)
        {
            var dto = new ClienteDTO() {
                Nome = item.Nome,
                Sobrenome = item.Sobrenome,
                CPF = item.CPF,
                RG = item.RG,
                OrgaoEmissor = item.OrgaoEmissor,
                DataNascimento = item.DataNascimento,
                Email = item.Email,
                Telefone = item.Telefone,
                Regiao = item.RegiaoOndeMora
            };
            respose.Add(dto);
        }

        return respose;
    }
}
