using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class ExemplarMap : IEntityTypeConfiguration<Exemplar>
    {
        public void Configure(EntityTypeBuilder<Exemplar> builder)
        {
            builder.HasKey(o => new {o.CodObr, o.NumExe});

            builder.HasOne(o=> o.Editora)
            .WithMany(o=> o.Exemplares)
            .HasForeignKey(o=> o.CodEdi)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}