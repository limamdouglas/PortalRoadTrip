using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Domain.Entities;

public class Credito
{
    public int CreditoId { get; set; }
    public int ClienteId { get; set; }
    public string? Vencimento { get; set; }
    public long? Pedido { get; }
    public string? Status { get; set; }
    public string? QuandoFoiUtilizado { get; set; }
    public string? EventoUtilizado { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal ValorUtilizado { get; set; }
    public decimal ValorRestante { get; set; }
    public string? Observacao { get; set; }
    public virtual Cliente Cliente { get; set; }
}
