using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class EventoCadastroDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public string Data { get; set; }
    public int QtdVagas { get; set; }
    public string Descricao { get; set; }
    public string Roteiro { get; set; }
    public List<int> PontoEmbarque { get; set; }
    public float Preco { get; set; }
}
