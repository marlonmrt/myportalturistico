﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTServices.dominio;

namespace RESTServices
{
    
    [ServiceContract]
    public interface IAgentes
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Agentes", ResponseFormat = WebMessageFormat.Json)]
        Agente CrearAgente(Agente agenteACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Agentes/{ruc}", ResponseFormat = WebMessageFormat.Json)]
        Agente ObtenerAgente(string ruc);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Agentes", ResponseFormat = WebMessageFormat.Json)]
        Agente ModificarAgente(Agente agenteAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Agentes", ResponseFormat = WebMessageFormat.Json)]
        void EliminarAgente(string ruc);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Agentes", ResponseFormat = WebMessageFormat.Json)]
        List<Agente> ListarAgentes();

    }
}

