namespace portal_roadtrip.Domain.Entities;

public  class EventoCliente
{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public int ClienteID { get; set; }
    public int QuantidadeVaga { get; set; }
    public bool EhReserva { get; set; }
    public virtual Evento Evento { get; set; }
    public virtual Cliente Cliente { get; set; }
}
