namespace portal_roadtrip.Domain.Entities;

public class EventoFuncionario
{
    public int Id { get; set; }
    public int EventoId { get; set; }
    public int FuncionarioId { get; set; }
    public virtual Evento Evento { get; set; }
    public virtual Funcionario Funcionario { get; set; }
}