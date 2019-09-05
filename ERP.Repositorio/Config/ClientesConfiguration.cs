using ERP.Dominio.Contrato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Repositorio.Config
{
    class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.HasKey(u => u.id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.sexo)
                .IsRequired()
                .HasMaxLength(5);
            builder
                .Property(u => u.telefone)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
