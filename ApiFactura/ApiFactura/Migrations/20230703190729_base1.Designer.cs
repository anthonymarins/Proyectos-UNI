﻿// <auto-generated />
using System;
using ApiFactura.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFactura.Migrations
{
    [DbContext(typeof(FacturaContext))]
    [Migration("20230703190729_base1")]
    partial class base1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiFactura.Modelo.Clientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ApiFactura.Modelo.DetalleFactura", b =>
                {
                    b.Property<int>("idFactura")
                        .HasColumnType("int");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<int>("catidad")
                        .HasColumnType("int");

                    b.HasKey("idFactura", "idProducto");

                    b.HasIndex("idProducto");

                    b.ToTable("detallesFactura");
                });

            modelBuilder.Entity("ApiFactura.Modelo.Facturas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idCliente");

                    b.ToTable("facturas");
                });

            modelBuilder.Entity("ApiFactura.Modelo.Productos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("ApiFactura.Modelo.DetalleFactura", b =>
                {
                    b.HasOne("ApiFactura.Modelo.Facturas", "facturas")
                        .WithMany()
                        .HasForeignKey("idFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiFactura.Modelo.Productos", "productos")
                        .WithMany()
                        .HasForeignKey("idProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("facturas");

                    b.Navigation("productos");
                });

            modelBuilder.Entity("ApiFactura.Modelo.Facturas", b =>
                {
                    b.HasOne("ApiFactura.Modelo.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
