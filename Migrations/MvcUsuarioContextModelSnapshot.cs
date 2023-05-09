﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcUsuario.Data;

#nullable disable

namespace Parcial1.Migrations
{
    [DbContext(typeof(MvcUsuarioContext))]
    partial class MvcUsuarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Parcial1.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsAlumno")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Esprofesor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Parcial1.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RolId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Usuarioo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("documento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("domicilio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fechanacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nacionalidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("telefono")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("terminos")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Parcial1.Models.Rol", b =>
                {
                    b.HasOne("Parcial1.Models.Usuario", "Usuario")
                        .WithOne("Rol")
                        .HasForeignKey("Parcial1.Models.Rol", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Parcial1.Models.Usuario", b =>
                {
                    b.Navigation("Rol")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
