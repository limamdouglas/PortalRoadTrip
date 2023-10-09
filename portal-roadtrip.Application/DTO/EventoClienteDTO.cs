using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class EventoClienteDTO
{
    public int Id { get; set; }
    public int Evento { get; set; }
    public int ClienteId { get; set; }
    public int Quantidade { get; set; }
    public bool EhReserva { get; set; }
    public string? NomeEvento { get; set; }
    public string? Usuario { get; set; }
    public string? cpf { get; set; }
}
