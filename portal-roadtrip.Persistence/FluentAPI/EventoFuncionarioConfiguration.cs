using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.Persistence.FluentAPI;

public class EventoFuncionarioConfiguration : IEntityTypeConfiguration<EventoFuncionario>
{
    public void Configure(EntityTypeBuilder<EventoFuncionario> builder)
    {
        builder.ToTable("Evento_Funcionario").HasKey(x => x.Id);
        builder.HasOne(x => x.Evento).WithMany().HasForeignKey(x => x.EventoId);
        builder.HasOne(x => x.Funcionario).WithMany().HasForeignKey(x => x.FuncionarioId);
    }
}
