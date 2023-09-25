namespace portal_roadtrip.Domain.Entities;

public class Evento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public int CategoriaEventoId { get; set; }
    public virtual CategoriaEvento CategoriaEvento { get; set; }
}