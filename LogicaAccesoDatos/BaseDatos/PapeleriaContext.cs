﻿using LogicaNegocio.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.BaseDatos
{
    public class PapeleriaContext:DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Linea> Lineas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<PedidoComun> PedidosComunes { get; set; }
        public DbSet<PedidoExpress> PedidosExpress { get; set; }
        public DbSet<MovimientosStock> Movimientos {  get; set; }
        public DbSet<TipoMovimiento> TiposDeMovimiento { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public PapeleriaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasOne(u => u.RolUsuario).WithMany(r=>r.Usuarios).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pedido>().UseTphMappingStrategy();
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
