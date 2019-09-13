﻿// <auto-generated />
using System;
using ERP.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERP.Repositorio.Migrations
{
    [DbContext(typeof(ERPContexto))]
    partial class ERPContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ERP.Dominio.Entidades.Clientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("endereco");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ERP.Dominio.Entidades.Ingredientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasMaxLength(500);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("ingredientes");
                });

            modelBuilder.Entity("ERP.Dominio.Entidades.ItensLanches", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredienteId");

                    b.Property<int?>("Ingredientesid");

                    b.Property<int>("lancheId");

                    b.Property<int?>("lanchesid");

                    b.HasKey("id");

                    b.HasIndex("Ingredientesid");

                    b.HasIndex("lanchesid");

                    b.ToTable("itensLanches");
                });

            modelBuilder.Entity("ERP.Dominio.Entidades.Lanches", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("preco");

                    b.HasKey("id");

                    b.ToTable("lanches");
                });

            modelBuilder.Entity("ERP.Dominio.Entidades.ItensLanches", b =>
                {
                    b.HasOne("ERP.Dominio.Entidades.Ingredientes", "Ingredientes")
                        .WithMany()
                        .HasForeignKey("Ingredientesid");

                    b.HasOne("ERP.Dominio.Entidades.Lanches", "lanches")
                        .WithMany()
                        .HasForeignKey("lanchesid");
                });
#pragma warning restore 612, 618
        }
    }
}
