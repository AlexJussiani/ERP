using ERP.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Repositorio.Config
{
    class LanchesConfiguration : IEntityTypeConfiguration<Lanches>
    {
        public void Configure(EntityTypeBuilder<Lanches> builder)
        {
            builder.HasKey(p => p.id);

            builder
                .Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.preco)
                .IsRequired();
        }
    }
}
