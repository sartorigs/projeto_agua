﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Projeto_Aplicado.Context;

namespace Projeto_Aplicado.Migrations
{
    [DbContext(typeof(AguaContext))]
    [Migration("20221102182944_Remoção Categoria")]
    partial class RemoçãoCategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Projeto_Aplicado.Entidades.PowerBi", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.Property<int>("value1")
                        .HasColumnType("integer");

                    b.Property<int>("value2")
                        .HasColumnType("integer");

                    b.Property<int>("value3")
                        .HasColumnType("integer");

                    b.Property<int>("value4")
                        .HasColumnType("integer");

                    b.Property<int>("value5")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PowerBis");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Projeto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Imagem")
                        .HasColumnType("text");

                    b.Property<string>("Itens")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.HasKey("Id");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Regiao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("Cidade")
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Regioes");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.UsuarioProjeto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Deslikes")
                        .HasColumnType("integer");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<long>("ProjetoId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioProjeto");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.PowerBi", b =>
                {
                    b.HasOne("Projeto_Aplicado.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Regiao", b =>
                {
                    b.HasOne("Projeto_Aplicado.Entidades.Usuario", "Usuario")
                        .WithOne("Regiao")
                        .HasForeignKey("Projeto_Aplicado.Entidades.Regiao", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.UsuarioProjeto", b =>
                {
                    b.HasOne("Projeto_Aplicado.Entidades.Usuario", "Usuario")
                        .WithMany("UsuarioProjeto")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projeto_Aplicado.Entidades.Projeto", "Projeto")
                        .WithMany("UsuarioProjeto")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Projeto", b =>
                {
                    b.Navigation("UsuarioProjeto");
                });

            modelBuilder.Entity("Projeto_Aplicado.Entidades.Usuario", b =>
                {
                    b.Navigation("Regiao");

                    b.Navigation("UsuarioProjeto");
                });
#pragma warning restore 612, 618
        }
    }
}
