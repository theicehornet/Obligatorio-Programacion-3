﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUMovimientoStock.Interfaces
{
    public interface ICUObtenerCantidadDeMovimientosDadoArticuloYTipoMovimiento
    {
        int ObtenerCantidadDeMovimientosDadoArticuloYTipoMovimiento(int idArticulo, int idTipoMovimiento);
    }
}
