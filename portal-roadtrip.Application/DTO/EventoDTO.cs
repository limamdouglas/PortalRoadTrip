using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class EventoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public string Data { get; set; }
    public int QtdVagas { get; set; }
    public int QtdVagasDisponiveis { get; set; }
    public string Descricao { get; set; }
    public string Roteiro { get; set; }
    public List<string> PontoEmbarque { get; set; }
    public double Preco { get; set; }
    public List<StaffDTO> Staff { get; set; } = new List<StaffDTO>();
    public List<ClienteDTO> Cliente { get; set; } = new List<ClienteDTO>();
}
