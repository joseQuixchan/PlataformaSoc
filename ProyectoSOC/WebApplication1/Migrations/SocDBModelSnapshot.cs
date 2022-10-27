﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoSOC.Data;

#nullable disable

namespace ProyectoSOC.Migrations
{
    [DbContext(typeof(SocDB))]
    partial class SocDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoSOC.Models.Entity.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("UsuarioApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UsuarioCambioPass")
                        .HasColumnType("bit");

                    b.Property<string>("UsuarioCorreo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UsuarioEstado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UsuarioFechaCambioPass")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UsuarioFechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UsuarioFechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UsuarioFechaSesion")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioIntentos")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioPasswordAnterior")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
