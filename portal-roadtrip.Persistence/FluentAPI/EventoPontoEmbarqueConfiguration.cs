using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.Persistence.FluentAPI;

public class EventoPontoEmbarqueConfiguration : IEntityTypeConfiguration<EventoPontoEmbarque>
{
    public void Configure(EntityTypeBuilder<EventoPontoEmbarque> builder)
    {
        builder.ToTable("Evento_Ponto_Embarque").HasKey(x => x.Id);
        builder.HasOne(x => x.Evento).WithMany().HasForeignKey(x => x.EventoId);
        builder.HasOne(x => x.PontoEmbarque).WithMany().HasForeignKey(x => x.PontoEmbarqueId);
    }
}
