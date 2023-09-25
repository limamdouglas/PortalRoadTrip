using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.Persistence.FluentAPI;

public class ConexaoUsuarioConfiguration : IEntityTypeConfiguration<ConexaoUsuario>
{
    public void Configure(EntityTypeBuilder<ConexaoUsuario> builder)
    {
        builder.ToTable("Conexao_Usuario").HasKey(x => x.Id);
        builder.HasOne(x => x.Usuario1).WithMany().HasForeignKey(x => x.UsuarioId1);
        builder.HasOne(x => x.Usuario2).WithMany().HasForeignKey(x => x.UsuarioId2);
    }
}
