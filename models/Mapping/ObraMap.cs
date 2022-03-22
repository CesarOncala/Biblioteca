using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.models.Mapping
{
    public class ObraMap : IEntityTypeConfiguration<Obra>
    {
        public void Configure(EntityTypeBuilder<Obra> builder)
        {
            builder.HasKey(o => o.CodObr);
        }
    }
}