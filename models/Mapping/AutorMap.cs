using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.HasKey(o => o.CodAut);

            builder.HasOne(o => o.Pais)
                    .WithMany(o => o.Autores)
                    .HasForeignKey(o => o.CodPai)
                    .OnDelete(DeleteBehavior.SetNull);
        }
    }
}