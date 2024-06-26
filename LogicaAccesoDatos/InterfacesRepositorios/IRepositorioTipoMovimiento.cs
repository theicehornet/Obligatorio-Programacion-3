﻿using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.InterfacesRepositorios
{
    public interface IRepositorioTipoMovimiento : IRepositorio<TipoMovimiento>
    {
        bool TipoMovimientoExiste(int id);

        bool TipoDeMovimientoNoTipoTraslado(int id);
    }
}
