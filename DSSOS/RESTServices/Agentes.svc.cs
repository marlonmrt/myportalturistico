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
    public class Agentes : IAgentes
    {
        private AgenteDAO dao = new AgenteDAO();

        public Agente CrearAgente(Agente agenteACrear)
        {
            //esta primera parte valida si e ha ingresado algun campo vacío
            //para nuestro caso, deben ingresarse todos, sino, sale error
            if (agenteACrear.RUC.Equals("") || agenteACrear.RazonSocial.Equals("") || agenteACrear.Direccion.Equals("") || agenteACrear.CorreoAgente.Equals(""))
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error1",
                        MensajeNegocio = "La información ingresada debe estar completa"
                    },
                    HttpStatusCode.BadRequest);

            // validamos si el ruc ingresado es uno correcto
            //uso una Funciones que coloqué en la clase decimal funciones
            if (Funciones.ValidaRUC(agenteACrear.RUC.Trim()) == false)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error2",
                        MensajeNegocio = "El RUC ingresado es incorrecto."
                    },
                    HttpStatusCode.InternalServerError);

            // validamos si el correo ingresado es uno correcto
            //uso una Funciones que coloqué en la clase decimal funciones
            if (Funciones.es_email(agenteACrear.CorreoAgente.Trim()) == false)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error3",
                        MensajeNegocio = "El correo ingresado es incorrecto."
                    },
                    HttpStatusCode.InternalServerError);

            //ahora validamnos si el agente ya existe por su RUC 
            Agente existe = ObtenerAgente(agenteACrear.RUC);
            if (existe != null)
                throw new WebFaultException<Error>(
                    new Error()
                    {
                        CodigoNegocio = "Error4",
                        MensajeNegocio = "El Agente " + agenteACrear.RUC + " ya existe !!!!!"
                    },
                    HttpStatusCode.InternalServerError);


            return dao.Crear(agenteACrear);
        }

        public Agente ObtenerAgente(string ruc)
        {
            return dao.Obtener(ruc);
        }


        public List<Agente> ListarAgentes()
        {
            return dao.ListarTodos();
        }
    }
}
