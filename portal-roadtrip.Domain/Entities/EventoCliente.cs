namespace portal_roadtrip.Domain.Entities;

public  class EventoCliente
{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public int UsuarioID { get; set; }
    public virtual Evento Evento { get; set; }
    public virtual Usuario Usuario { get; set; }
}
