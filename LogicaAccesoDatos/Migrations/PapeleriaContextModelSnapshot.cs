﻿// <auto-generated />
using System;
using LogicaAccesoDatos.BaseDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogicaAccesoDatos.Migrations
{
    [DbContext(typeof(PapeleriaContext))]
    partial class PapeleriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("PrecioPublico")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DireccionId")
                        .HasColumnType("int");

                    b.Property<double>("DistanciaPapeleria")
                        .HasColumnType("float");

                    b.Property<string>("RUT")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DireccionId");

                    b.HasIndex("RUT")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Linea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("CantArticulo")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Lineas");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Parametro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Parametros");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAnulado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pedido");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordEncriptada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.PedidoComun", b =>
                {
                    b.HasBaseType("LogicaNegocio.EntidadesNegocio.Pedido");

                    b.HasDiscriminator().HasValue("PedidoComun");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.PedidoExpress", b =>
                {
                    b.HasBaseType("LogicaNegocio.EntidadesNegocio.Pedido");

                    b.HasDiscriminator().HasValue("PedidoExpress");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Articulo", b =>
                {
                    b.OwnsOne("LogicaNegocio.ValueObjects.ArticulosVO.CodigoVO", "CodigoArticulo", b1 =>
                        {
                            b1.Property<int>("ArticuloId")
                                .HasColumnType("int");

                            b1.Property<string>("Codigo")
                                .IsRequired()
                                .HasMaxLength(13)
                                .HasColumnType("nvarchar(13)");

                            b1.HasKey("ArticuloId");

                            b1.HasIndex("Codigo")
                                .IsUnique();

                            b1.ToTable("Articulos");

                            b1.WithOwner()
                                .HasForeignKey("ArticuloId");
                        });

                    b.OwnsOne("LogicaNegocio.ValueObjects.ArticulosVO.DescripcionVO", "DescripcionArticulo", b1 =>
                        {
                            b1.Property<int>("ArticuloId")
                                .HasColumnType("int");

                            b1.Property<string>("Descripcion")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("ArticuloId");

                            b1.HasIndex("Descripcion");

                            b1.ToTable("Articulos");

                            b1.WithOwner()
                                .HasForeignKey("ArticuloId");
                        });

                    b.OwnsOne("LogicaNegocio.ValueObjects.ArticulosVO.NombreVO", "NombreArticulo", b1 =>
                        {
                            b1.Property<int>("ArticuloId")
                                .HasColumnType("int");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("ArticuloId");

                            b1.HasIndex("Nombre")
                                .IsUnique();

                            b1.ToTable("Articulos");

                            b1.WithOwner()
                                .HasForeignKey("ArticuloId");
                        });

                    b.Navigation("CodigoArticulo")
                        .IsRequired();

                    b.Navigation("DescripcionArticulo")
                        .IsRequired();

                    b.Navigation("NombreArticulo")
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Cliente", b =>
                {
                    b.HasOne("LogicaNegocio.EntidadesNegocio.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("DireccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Linea", b =>
                {
                    b.HasOne("LogicaNegocio.EntidadesNegocio.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogicaNegocio.EntidadesNegocio.Pedido", null)
                        .WithMany("Lineas")
                        .HasForeignKey("PedidoId");

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Pedido", b =>
                {
                    b.HasOne("LogicaNegocio.EntidadesNegocio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Usuario", b =>
                {
                    b.OwnsOne("LogicaNegocio.ValueObjects.UsuarioVO.ApellidoVO", "ApellidoUsuario", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Apellido")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("UsuarioId");

                            b1.HasIndex("Apellido");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.OwnsOne("LogicaNegocio.ValueObjects.UsuarioVO.EmailVO", "EmailUsuario", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("UsuarioId");

                            b1.HasIndex("Email")
                                .IsUnique();

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.OwnsOne("LogicaNegocio.ValueObjects.UsuarioVO.NombreVO", "NombreUsuario", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("UsuarioId");

                            b1.HasIndex("Nombre");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.OwnsOne("LogicaNegocio.ValueObjects.UsuarioVO.PasswordVO", "PasswordUsuario", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("UsuarioId");

                            b1.HasIndex("Password");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.Navigation("ApellidoUsuario")
                        .IsRequired();

                    b.Navigation("EmailUsuario")
                        .IsRequired();

                    b.Navigation("NombreUsuario")
                        .IsRequired();

                    b.Navigation("PasswordUsuario")
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.EntidadesNegocio.Pedido", b =>
                {
                    b.Navigation("Lineas");
                });
#pragma warning restore 612, 618
        }
    }
}
