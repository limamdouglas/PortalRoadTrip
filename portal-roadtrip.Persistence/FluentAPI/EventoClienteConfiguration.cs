using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.Persistence.FluentAPI;

public class EventoClienteConfiguration : IEntityTypeConfiguration<EventoCliente>
{
    public void Configure(EntityTypeBuilder<EventoCliente> builder)
    {
        builder.ToTable("Evento_Cliente").HasKey(x => x.Id);
        builder.HasOne(x => x.Evento).WithMany().HasForeignKey(x => x.EventoId);
        builder.HasOne(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioID);
    }
}
