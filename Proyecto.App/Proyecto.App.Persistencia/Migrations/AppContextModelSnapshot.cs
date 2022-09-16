﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Proyecto.App.Dominio.Cita", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClientePersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Servicio")
                        .HasColumnType("int");

                    b.Property<int?>("TecnicoPersonaId")
                        .HasColumnType("int");

                    b.HasKey("CitaId");

                    b.HasIndex("ClientePersonaId");

                    b.HasIndex("TecnicoPersonaId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.HasKey("HorarioId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Administrador")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int?>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaId");

                    b.HasIndex("LoginId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("Proyecto.App.Dominio.Persona");

                    b.Property<int>("Membresia")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Tecnico", b =>
                {
                    b.HasBaseType("Proyecto.App.Dominio.Persona");

                    b.Property<int?>("HorarioId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("HorarioId");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Cita", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClientePersonaId");

                    b.HasOne("Proyecto.App.Dominio.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoPersonaId");

                    b.Navigation("Cliente");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Persona", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId");

                    b.Navigation("Login");
                });

            modelBuilder.Entity("Proyecto.App.Dominio.Tecnico", b =>
                {
                    b.HasOne("Proyecto.App.Dominio.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId");

                    b.Navigation("Horario");
                });
#pragma warning restore 612, 618
        }
    }
}