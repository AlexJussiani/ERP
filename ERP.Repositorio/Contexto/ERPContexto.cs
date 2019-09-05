using ERP.Dominio.Entidades;
using ERP.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Contexto
{
    public class ERPContexto : DbContext
    {
        public DbSet<Lanches> lanches { get; set; }
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<ItensLanches> itensLanches { get; set; }
        public DbSet<Clientes> clientes { get; set; }

        public ERPContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new ClientesConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientesConfiguration());
            modelBuilder.ApplyConfiguration(new ItensLanchesConfiguration());
            modelBuilder.ApplyConfiguration(new LanchesConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
