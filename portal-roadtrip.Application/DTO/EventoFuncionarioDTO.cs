using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class EventoFuncionarioDTO
{
    public int EventoId { get; set; }
    public List<StaffDTO> Staff { get; set; } = new List<StaffDTO>();
    public List<StaffDTO> StaffEvento { get; set; } = new List<StaffDTO>();
}
