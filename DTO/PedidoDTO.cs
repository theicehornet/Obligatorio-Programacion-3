﻿using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public DateTime FechaEntrega { get; set; }
        public ClienteDTO Cliente { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
