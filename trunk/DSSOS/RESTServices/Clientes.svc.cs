using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.persistencia;
using RESTServices.dominio;

namespace RESTServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO dao = new ClienteDAO();

        public Cliente CrearAlumno(Cliente clienteACrear)
        {
            return dao.Crear(clienteACrear);
        }

        public Cliente ObtenerCliente(string dni)
        {
            return dao.Obtener(dni);
        }

        public Cliente ModificarCliente(Cliente clienteAModificar)
        {
            return dao.Modificar(clienteAModificar);
        }

        public void EliminarCliente(string dni)
        {
            dao.Eliminar(dni);
        }

        public List<Cliente> ListarClientes()
        {
            return dao.ListarTodos();
        }

    }
}
