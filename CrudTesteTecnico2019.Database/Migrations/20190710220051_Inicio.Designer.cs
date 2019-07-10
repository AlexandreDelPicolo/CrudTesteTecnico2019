﻿// <auto-generated />
using System;
using CrudTesteTecnico2019.Database.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudTesteTecnico2019.Database.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190710220051_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudTesteTecnico2019.Domain.Usuario.Entity.UsuarioDomain", b =>
                {
                    b.Property<long>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Perfil");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario_tb","CrudTesteTecnico");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1L,
                            Nome = "Alexandre",
                            Perfil = 4,
                            Sobrenome = "Del Picolo"
                        },
                        new
                        {
                            UsuarioId = 2L,
                            Nome = "Rafael",
                            Perfil = 1,
                            Sobrenome = "Garcia"
                        },
                        new
                        {
                            UsuarioId = 3L,
                            Nome = "Luciano",
                            Perfil = 3,
                            Sobrenome = "Lima"
                        },
                        new
                        {
                            UsuarioId = 4L,
                            Nome = "Bruno",
                            Perfil = 3,
                            Sobrenome = "Lima"
                        });
                });

            modelBuilder.Entity("CrudTesteTecnico2019.Domain.Usuario.Entity.UsuarioDomain", b =>
                {
                    b.OwnsOne("CrudTesteTecnico2019.Domain.Usuario.ObjectValue.DataNascimento", "DataNascimento", b1 =>
                        {
                            b1.Property<long>("UsuarioDomainUsuarioId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<DateTime>("Value")
                                .HasColumnName("DataNascimento");

                            b1.HasKey("UsuarioDomainUsuarioId");

                            b1.ToTable("Usuario_tb","CrudTesteTecnico");

                            b1.HasOne("CrudTesteTecnico2019.Domain.Usuario.Entity.UsuarioDomain")
                                .WithOne("DataNascimento")
                                .HasForeignKey("CrudTesteTecnico2019.Domain.Usuario.ObjectValue.DataNascimento", "UsuarioDomainUsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioDomainUsuarioId = 1L,
                                    Value = new DateTime(2019, 7, 10, 19, 0, 50, 64, DateTimeKind.Local).AddTicks(5232)
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 2L,
                                    Value = new DateTime(1990, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(525)
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 3L,
                                    Value = new DateTime(1992, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(915)
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 4L,
                                    Value = new DateTime(1992, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(1223)
                                });
                        });

                    b.OwnsOne("CrudTesteTecnico2019.Domain.Usuario.ObjectValue.Email", "Email", b1 =>
                        {
                            b1.Property<long>("UsuarioDomainUsuarioId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasMaxLength(300);

                            b1.HasKey("UsuarioDomainUsuarioId");

                            b1.ToTable("Usuario_tb","CrudTesteTecnico");

                            b1.HasOne("CrudTesteTecnico2019.Domain.Usuario.Entity.UsuarioDomain")
                                .WithOne("Email")
                                .HasForeignKey("CrudTesteTecnico2019.Domain.Usuario.ObjectValue.Email", "UsuarioDomainUsuarioId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new
                                {
                                    UsuarioDomainUsuarioId = 1L,
                                    Value = "administrator@administrator.com"
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 2L,
                                    Value = "rafaelfgx@gmail.com"
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 3L,
                                    Value = "lucishow@gmail.com"
                                },
                                new
                                {
                                    UsuarioDomainUsuarioId = 4L,
                                    Value = "bruno.lima@gmail.com"
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}