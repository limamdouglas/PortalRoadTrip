using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Domain.Entities;

public class Estorno
{
    public int EstornoId { get; set; }
    public int ClienteId { get; set; }
    public int EventoId { get; set; }
    public string? DataPagamento { get; set; }
    public string? DataSolicitacao { get; set; }
    public string? IdTransacao { get; set; }
    public string? Plataforma { get; set; }
    public int Quantidade { get; set; }
    public decimal PorcentagemDevolvida { get; set; }
    public decimal Valor { get; set; }
    public decimal Estornado { get; set; }
    public string? FormaPg { get; set; }
    public string? PrazoEstimado { get; set; }
    public string? Acompanhamento { get; set; }
    public string? Status { get; set; }
    public string? Motivo { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual Evento Evento { get; set; }

}
