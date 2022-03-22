using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.HasKey(o => new { o.CodObr, o.NumExe, o.CodUsu, o.DatIni });


            builder.HasOne(o => o.Obra)
            .WithMany(o => o.Emprestimos)
            .HasForeignKey(o => o.CodObr)
            .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(o => o.Usuario)
            .WithMany(o => o.Emprestimos)
            .HasForeignKey(o => o.CodUsu)
            .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(o => o.Exemplar)
            .WithMany(o => o.Emprestimos)
            .HasForeignKey(o => new { o.NumExe, o.CodObr })
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}