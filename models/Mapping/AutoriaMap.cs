using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class AutoriaMap : IEntityTypeConfiguration<Autoria>
    {
        public void Configure(EntityTypeBuilder<Autoria> builder)
        {
            builder.HasKey(o => new { o.CodAut, o.CodObr });


            builder.HasOne(o => o.Autor)
            .WithMany(o => o.Autorias)
            .HasForeignKey(o => o.CodAut)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Obra)
            .WithMany(o => o.Autorias)
            .HasForeignKey(o => o.CodObr)
            .OnDelete(DeleteBehavior.Restrict);


            //   builder.HasMany(p => p.Obras)
            // .WithMany(p => p.Autores)
            // .UsingEntity<Autoria>(
            //      j => j
            //         .HasOne(pt => pt.Obra)
            //         .WithMany(p => p.Autorias)
            //         .HasForeignKey(pt => pt.CodObr),
            //     j => j
            //         .HasOne(pt => pt.Autor)
            //         .WithMany(t => t.Autorias)
            //         .HasForeignKey(pt => pt.CodAut),
            //     j =>
            //     {
            //         j.HasKey(t => new { t.CodObr, t.CodAut });
            //     });



        }
    }
}