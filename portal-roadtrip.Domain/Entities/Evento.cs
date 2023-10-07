namespace portal_roadtrip.Domain.Entities;

public class Evento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Roteiro { get; set; }
    public DateTime Data { get; set; }
    public double Preco { get; set; }
    public int QuantidadeVagasReservas { get; set; }
    public int QuantidadeVagas { get; set; }
    public virtual List<EventoCliente> EventoCliente { get; set; }
    public virtual List<EventoPontoEmbarque> EventoPontoEmbarque { get; set; }
    public int CategoriaEventoId { get; set; }
    public virtual CategoriaEvento CategoriaEvento { get; set; }

}