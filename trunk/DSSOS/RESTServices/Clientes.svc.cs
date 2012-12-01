using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.persistencia;
using RESTServices.dominio;
using System.ServiceModel.Web;
using System.Net;

namespace RESTServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO dao = new ClienteDAO();

        public Cliente CrearCliente(Cliente clienteACrear)
        {
           
            if (clienteACrear.dni.Equals("") || clienteACrear.nombreCli.Equals("") || clienteACrear.correo.Equals("") || clienteACrear.apellidoCli.Equals(""))
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error2",
                        MensajeNegocio = "Ingrese su información completa"
                    },
                    HttpStatusCode.InternalServerError);


            Cliente existe = ObtenerCliente(clienteACrear.dni);
            if (existe != null)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error1",
                        MensajeNegocio = "El cliente " + clienteACrear.dni + " ya existe !!!!!"
                    },
                    HttpStatusCode.InternalServerError);

            
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
