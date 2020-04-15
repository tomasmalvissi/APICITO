﻿using APICITO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICITO.Repositorios
{
    public class RPClientes
    {
        public static List<Cliente> _listaClientes = new List<Cliente>()
        {
            new Cliente() { Id = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" },
            new Cliente() { Id = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" },
            new Cliente() { Id = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" }
        };

        public IEnumerable<Cliente> ObtenerClientes()
        {
            return _listaClientes;
        }

        public Cliente ObtenerCliente(int id)
        {
            var cliente = _listaClientes.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(Cliente nuevoCliente)
        {
            _listaClientes.Add(nuevoCliente);
        }
    }
}
