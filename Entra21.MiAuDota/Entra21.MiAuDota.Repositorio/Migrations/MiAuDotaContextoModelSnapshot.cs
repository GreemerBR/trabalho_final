﻿// <auto-generated />
using System;
using Entra21.MiAuDota.Repositorio.BancoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    [DbContext(typeof(MiAuDotaContexto))]
    partial class MiAuDotaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<int>("Idade")
                        .HasColumnType("TYNYINT")
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
                        .IsRequired()
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alergias = "nenhuma",
                            Altura = 0.7m,
                            Castrado = true,
                            DataAdocao = new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Especie = "Cão",
                            Foto = "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg",
                            Genero = (byte)1,
                            Idade = 1,
                            Nome = "bob",
                            Peso = 2.3m,
                            ProtetorId = 1,
                            Raca = "Pastor",
                            Sobre = "bonito",
                            Status = (byte)2,
                            UsuarioId = 1,
                            Vacinas = "Gripe"
                        });
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Protetor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("celular");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(18)
                        .HasColumnType("VARCHAR(18)")
                        .HasColumnName("cnpf");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("confirmar_senha");

                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<bool>("EhProtetor")
                        .HasColumnType("BIT")
                        .HasColumnName("eh_protetor");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("sobre");

                    b.Property<byte>("StatusConta")
                        .HasColumnType("TINYINT")
                        .HasColumnName("status_conta");

                    b.Property<string>("Telefone")
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("protetores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Celular = "47 99999-1246",
                            ConfirmarSenha = "123123123",
                            Cpf = "123.123.123-00",
                            EhProtetor = false,
                            Email = "greg@gmail.com",
                            Endereco = "Rua tãnãnã",
                            Nome = "Greg",
                            Senha = "123123123",
                            Sobre = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            StatusConta = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            Celular = "47 98895-1246",
                            ConfirmarSenha = "156156156",
                            Cpf = "186.123.892-00",
                            EhProtetor = false,
                            Email = "douh@gmail.com",
                            Endereco = "Rua São Paulo",
                            Nome = "DOug",
                            Senha = "156156156",
                            Sobre = "Printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            StatusConta = (byte)0
                        });
                });

            modelBuilder.Entity("Entra21.MiAuDota.Repositorio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)")
                        .HasColumnName("celular");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("confirmar_senha");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATETIME2")
                        .HasColumnName("data_nascimento");

                    b.Property<bool>("EhUsuario")
                        .HasColumnType("BIT")
                        .HasColumnName("eh_usuario");

                    b.Property<bool>("EhVoluntario")
                        .HasColumnType("BIT")
                        .HasColumnName("eh_voluntario");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("endereco");

                    b.Property<string>("Especialidade")
                        .HasMaxLength(45)
                        .HasColumnType("VARCHAR(45)")
                        .HasColumnName("especialidade");

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

                    b.Property<byte>("StatusConta")
                        .HasColumnType("TINYINT")
                        .HasColumnName("status_conta");

                    b.HasKey("Id");

                    b.ToTable("usuarios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Celular = "47 99888-1246",
                            ConfirmarSenha = "123123123",
                            Cpf = "145.889.265-00",
                            DataNascimento = new DateTime(1992, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EhUsuario = true,
                            EhVoluntario = false,
                            Email = "ana@gmail.com",
                            Endereco = "Rua tal",
                            Especialidade = "Salto em distância",
                            Nome = "Ana",
                            Senha = "123123123",
                            StatusConta = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            Celular = "47 98865-1246",
                            ConfirmarSenha = "123123123",
                            Cpf = "189.456.789-00",
                            DataNascimento = new DateTime(1993, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EhUsuario = true,
                            EhVoluntario = true,
                            Email = "amanda@gmail.com",
                            Endereco = "Rua alt",
                            Especialidade = "Corrida",
                            Nome = "Amanda",
                            Senha = "123123123",
                            StatusConta = (byte)0
                        });
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
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
