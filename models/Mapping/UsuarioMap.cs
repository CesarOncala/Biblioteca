using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(o => o.CodUsu);

            builder.HasOne(o=> o.TipoUsuario)
            .WithMany(o=> o.Usuarios)
            .HasForeignKey(o=> o.TipUsu)
            .OnDelete(DeleteBehavior.SetNull);
        }
    }
}