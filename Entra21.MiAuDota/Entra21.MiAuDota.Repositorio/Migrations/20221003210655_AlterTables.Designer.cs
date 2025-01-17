﻿// <auto-generated />
using System;
using Entra21.MiAuDota.Repositorio.BancoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    [DbContext(typeof(MiAuDotaContexto))]
    [Migration("20221003210655_AlterTables")]
    partial class AlterTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("VARCHAR(13)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("administrador", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            Nome = "Administrador",
                            Senha = "0192023A7BBD73250516F069DF18B500"
                        });
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Alergias")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("alergias");

                    b.Property<decimal>("Altura")
                        .HasPrecision(3, 2)
                        .HasColumnType("DECIMAL(3,2)")
                        .HasColumnName("altura");

                    b.Property<bool>("Castrado")
                        .HasColumnType("BIT")
                        .HasColumnName("cadastro");

                    b.Property<DateTime?>("DataAdocao")
                        .HasColumnType("DATETIME2")
                        .HasColumnName("data_adocao");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("especie");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("VARCHAR(300)")
                        .HasColumnName("caminho_arquivo");

                    b.Property<byte>("Genero")
                        .HasColumnType("TINYINT")
                        .HasColumnName("genero");

                    b.Property<byte>("Idade")
                        .HasColumnType("TINYINT")
                        .HasColumnName("idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("nome");

                    b.Property<string>("OutrasInformacoesMedicas")
                        .HasColumnType("TEXT")
                        .HasColumnName("outras_infos_medicas");

                    b.Property<decimal>("Peso")
                        .HasPrecision(5, 2)
                        .HasColumnType("DECIMAL(5,2)")
                        .HasColumnName("peso");

                    b.Property<byte>("Porte")
                        .HasColumnType("TINYINT")
                        .HasColumnName("porte");

                    b.Property<int>("ProtetorId")
                        .HasColumnType("INT")
                        .HasColumnName("protetor_id");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("raca");

                    b.Property<string>("Sobre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("sobre");

                    b.Property<byte>("Status")
                        .HasColumnType("TINYINT")
                        .HasColumnName("status");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INT")
                        .HasColumnName("usuario_id");

                    b.Property<string>("Vacinas")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("vacinas");

                    b.HasKey("Id");

                    b.HasIndex("ProtetorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("animais", (string)null);
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Protetor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("celular");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(18)
                        .HasColumnType("VARCHAR(18)")
                        .HasColumnName("cnpj");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("confirmar_senha");

                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("endereco");

                    b.Property<string>("Facebook")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("facebook");

                    b.Property<string>("Instagram")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("instagram");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT")
                        .HasColumnName("conta_esta_ativa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("nome");

                    b.Property<string>("Pix")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("pix");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("senha");

                    b.Property<string>("Sobre")
                        .HasColumnType("TEXT")
                        .HasColumnName("sobre");

                    b.Property<string>("Telefone")
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("protetores", (string)null);
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("celular");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("confirmar_senha");

                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("DATETIME2")
                        .HasColumnName("data_nascimento");

                    b.Property<bool>("EhVoluntario")
                        .HasColumnType("BIT")
                        .HasColumnName("eh_voluntario");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("endereco");

                    b.Property<string>("Especialidade")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("especialidade");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT")
                        .HasColumnName("conta_esta_ativa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Animal", b =>
                {
                    b.HasOne("Entra21.MiAuDota.Repositorio.Entidades.Protetor", "Protetor")
                        .WithMany("Animais")
                        .HasForeignKey("ProtetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entra21.MiAuDota.Repositorio.Entidades.Usuario", "Usuario")
                        .WithMany("Animais")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Protetor");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Protetor", b =>
                {
                    b.Navigation("Animais");
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Usuario", b =>
                {
                    b.Navigation("Animais");
                });
#pragma warning restore 612, 618
        }
    }
}
