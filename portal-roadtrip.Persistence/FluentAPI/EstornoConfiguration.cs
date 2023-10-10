using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.FluentAPI;

public class EstornoConfiguration : IEntityTypeConfiguration<Estorno>
{
    public void Configure(EntityTypeBuilder<Estorno> builder)
    {
        builder.ToTable("Estorno").HasKey(x => x.EstornoId);
        builder.HasOne(x => x.Cliente).WithMany().HasForeignKey(x => x.ClienteId);
        builder.HasOne(x => x.Evento).WithMany().HasForeignKey(x => x.EventoId);
    }
}
