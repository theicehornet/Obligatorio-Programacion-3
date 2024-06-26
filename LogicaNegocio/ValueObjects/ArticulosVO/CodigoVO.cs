﻿using LogicaNegocio.Excepciones.Articulo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects.ArticulosVO
{
    [Owned]
    [Index(nameof(Codigo),IsUnique =true)]
    public class CodigoVO
    {
        [MinLength(13, ErrorMessage = "Debe tener al menos 13 caracteres")]
        [MaxLength(13, ErrorMessage = "Debe tener como máximo 13 caracteres")]
        public string Codigo { get; }

        public CodigoVO(string codigo) {
            Codigo = codigo;
            Validar();
        }

        public void Validar()
        {
            ValidarCodigo();
        }

        /// <summary>
        /// Valida que el codigo tenga los 13 caracteres correspondientes
        /// </summary>
        /// <exception cref="ArticuloException"></exception>
        private void ValidarCodigo()
        {
            if (Codigo.Length != 13)
                throw new ArticuloException("El codigo del articulo debe tener solamente 13 caracteres.");
            //^-> COMIENZA CON EL SIGUIENTE PATRON
            //[0-9]-> QUE DEBE TENER SOLO NUMEROS DEL 0 AL 9
            //+-> QUE SE REPITE
            //$->QUE LA CADENA DEBE TERMINAR CON ESE PATRON
            if (!new Regex(@"^[0-9]+$").IsMatch(Codigo))
                throw new ArticuloException("El codigo solo debe contener digitos");
        }
    }
}
