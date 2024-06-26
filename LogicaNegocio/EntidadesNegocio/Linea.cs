﻿using LogicaNegocio.Excepciones.Linea;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Linea : IEquatable<Linea>
    {
        public int Id { get; set; }
        public Articulo Articulo { get; set; }
        public int CantArticulo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Linea() { }

        public decimal PrecioTotal()
        {
            return CantArticulo * PrecioUnitario;
        }

        /// <summary>
        /// Valida que las propiedades de la clase Linea 
        /// </summary>
        public void Validar()
        {
            if (Articulo.Id == 0)
            {
                throw new LineaException("El articulo no existe");
            }
            ValidarCantArticulo();
            ValidarPrecioUnitario();
        }

        /// <summary>
        /// Valida que la cantidad cantidad del Articulo deba ser mayor a 0
        /// </summary>
        /// <exception cref="LineaException"></exception>
        private void ValidarCantArticulo()
        {
            if (CantArticulo <= 0)
                throw new LineaException("La cantidad de del articulo debe ser mayor a 0");
            if (CantArticulo > Articulo.Stock)
                throw new LineaException("La cantidad deseada supera el stock del articulo");
        }
        /// <summary>
        /// Valida que el precio unitario deba ser mayor a 0
        /// </summary>
        /// <exception cref="LineaException"></exception>
        private void ValidarPrecioUnitario()
        {
            if (PrecioUnitario < 0)
                throw new LineaException("La Precio Unitario del articulo debe ser mayor a 0");
        }

        public bool Equals(Linea? other)
        {
            return other.Articulo.Equals(Articulo);
        }
    }
}