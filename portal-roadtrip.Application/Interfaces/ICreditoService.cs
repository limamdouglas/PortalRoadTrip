using portal_roadtrip.Application.DTO;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface ICreditoService
{
    Task<Credito> SalvarCredito(Credito dto);
    Task<List<Credito>> ListarCreditos();
    Task<Credito> BuscarCredito(string cpf);
}
