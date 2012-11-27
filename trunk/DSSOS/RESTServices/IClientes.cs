using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTServices.dominio;

namespace RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientes" in both code and config file together.
    [ServiceContract]
    public interface IClientes
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        Cliente CrearAlumno(Cliente clienteACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Cliente ObtenerCliente(string dni);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        Cliente ModificarCliente(Cliente clienteAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Clientes/{dni}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarCliente(string dni);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "TodosClientes", ResponseFormat = WebMessageFormat.Json)]
        List<Cliente> ListarClientes();
    }
}
