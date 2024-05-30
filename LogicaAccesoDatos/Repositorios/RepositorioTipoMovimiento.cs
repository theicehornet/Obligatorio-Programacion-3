﻿using LogicaAccesoDatos.BaseDatos;
using LogicaAccesoDatos.InterfacesRepositorios;
using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.Excepciones.TipoMovimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioTipoMovimiento : IRepositorioTipoMovimiento
    {
        public PapeleriaContext Context { get; set; }
        public RepositorioTipoMovimiento(PapeleriaContext con)
        {
            Context = con;
        }

        public void Add(TipoMovimiento item)
        {
            item.Validar();
            Context.Add(item);
        }

        public void Delete(int id)
        {
            TipoMovimiento? tp = Context.TiposDeMovimiento.SingleOrDefault(t=>t.Id==id);
            ValidarTipoMovimientoSinAsociados(tp);
            Context.TiposDeMovimiento.Remove(tp);
        }

        public IEnumerable<TipoMovimiento> FindAll()
        {
            return Context.TiposDeMovimiento.ToList();
        }

        public TipoMovimiento FindById(int id)
        {
            return Context.TiposDeMovimiento.SingleOrDefault(tp=>tp.Id==id) ?? throw new TipoMovimientoException("El Tipo de Movimiento no existe.");
        }

        public void Update(TipoMovimiento item)
        {
            TipoMovimiento? tp = Context.TiposDeMovimiento.SingleOrDefault(t => t.Id == item.Id);
            ValidarTipoMovimientoSinAsociados(tp);
            tp.NombreMovimiento = item.NombreMovimiento;
            tp.Validar();
            Context.TiposDeMovimiento.Update(tp);
        }

        private void ValidarTipoMovimientoSinAsociados(TipoMovimiento? item)
        {
            if (item == null)
                throw new TipoMovimientoException("No existe el tipo de movimiento.");
            if (item.Movimientos.Any())
                throw new TipoMovimientoException("El tipo de movimiento tiene movimientos asociados");
        }
    }
}