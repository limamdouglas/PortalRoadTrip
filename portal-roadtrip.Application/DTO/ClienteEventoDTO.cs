using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class ClienteEventoDTO
{
    public int Id { get; set; }
    public string Evento { get; set; }
    public string Data { get; set; }
    public int QtdDias { get; set; }
    public bool PodeAvaliar { get; set; }
}
