﻿using LogicaAccesoDatos.InterfacesRepositorios;
using LogicaAplicacion.CasosUso.CUPedido.Interfaces;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUPedido.Implementacion;
public class CUAltaPedido:ICUAltaPedido
{
	public IRepositorio<Pedido> RepoPedidos { get; set; }
	public CuAltaArticulo(IRepositorio<Pedido> repoPedidos)
	{
		RepoPedidos = repoPedidos;
	}

	public void AltaPedido(Pedido pedido)
	{
		RepoPedidos.Add(pedido);
	}
}