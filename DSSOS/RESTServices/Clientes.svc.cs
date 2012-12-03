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
           //esta primera parte valida si e ha ingresado algun campo vacío
            //para nuestro caso, deben ingresarse todos, sino, sale error
            if (clienteACrear.DNI.Equals("") || clienteACrear.NombreCliente.Equals("") || clienteACrear.CorreoCliente.Equals("") || clienteACrear.ApellidoCliente.Equals(""))
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error2",
                        MensajeNegocio = "La información ingresada debe estar completa"
                    },
                    HttpStatusCode.BadRequest);

            // validamos si el dni ingresado es uno correcto
            //uso una Funciones que coloqué en la clase decimal funciones
            if (Funciones.ValidaDNI(clienteACrear.DNI.Trim()) == false)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error4",
                        MensajeNegocio = "El DNI ingresado es incorrecto."
                    },
                    HttpStatusCode.InternalServerError);

            // validamos si el correo ingresado es uno correcto
            //uso una Funciones que coloqué en la clase decimal funciones
            if (Funciones.es_email(clienteACrear.CorreoCliente.Trim()) == false)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error3",
                        MensajeNegocio = "El correo ingresado es incorrecto."
                    },
                    HttpStatusCode.InternalServerError);

            //ahora validamnos si el cliente ya existe por su DNI 
            Cliente existe = ObtenerCliente(clienteACrear.DNI);
            if (existe != null)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error1",
                        MensajeNegocio = "El cliente " + clienteACrear.DNI + " ya existe !!!!!"
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
