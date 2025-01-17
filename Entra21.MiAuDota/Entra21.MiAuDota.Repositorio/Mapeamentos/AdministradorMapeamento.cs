﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.MiAuDota.Repositorio.Mapeamentos
{
    public class AdministradorMapeamento : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("administrador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(13)
                .IsRequired()
                .HasColumnName("nome");

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnName("email");

            builder.Property(x => x.Senha)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("senha");

            builder.HasData(
            new Administrador
            {
                Id = 1,
                Nome = "Administrador",
                Email = "admin@admin.com",
                Senha = "0192023A7BBD73250516F069DF18B500",
            }
            );
        }
    }
}