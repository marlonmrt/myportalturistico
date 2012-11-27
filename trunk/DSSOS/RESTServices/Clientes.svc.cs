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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Clientes" in code, svc and config file together.
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
            throw new NotImplementedException();
        }

        public void EliminarCliente(string dni)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }

    }
}
