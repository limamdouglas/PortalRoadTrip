using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.Interfaces;

public interface IEstornoService
{
    Task<Estorno> SalvarEstorno(Estorno dto);
    Task<List<Estorno>> ListarEstornos();
    Task<Estorno> BuscarEstorno(string cpf);
}
