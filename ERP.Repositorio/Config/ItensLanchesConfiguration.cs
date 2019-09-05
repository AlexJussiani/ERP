using ERP.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Config
{
    class ItensLanchesConfiguration : IEntityTypeConfiguration<ItensLanches>
    {
        public void Configure(EntityTypeBuilder<ItensLanches> builder)
        {
            builder.HasKey(i => i.id);

            builder.Property(i => i.IngredienteId).IsRequired();

            builder.Property(i => i.lancheId).IsRequired();
        }
    }
}
