using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class EventoDTO
{
    public string Evento { get; set; }
    public string Categoria { get; set; }
    public string DataEvento { get; set; }
    public int QtdVagas { get; set; }
}
