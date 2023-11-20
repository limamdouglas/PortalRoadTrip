namespace portal_roadtrip.Domain.Entities;

public class EventoPontoEmbarque
{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public int PontoEmbarqueId { get; set; }
    public string Horario { get; set; }
    public virtual Evento Evento { get; set; }
    public virtual PontoEmbarque PontoEmbarque { get; set; }
}