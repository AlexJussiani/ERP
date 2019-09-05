using ERP.Dominio.Contrato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Repositorio.Config
{
    class IngredientesConfiguration : IEntityTypeConfiguration<Ingredientes>
    {
        public void Configure(EntityTypeBuilder<Ingredientes> builder)
        {
            builder.HasKey(p => p.id);

            builder
                .Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.descricao)
                .HasMaxLength(500);

        }
    }
}
