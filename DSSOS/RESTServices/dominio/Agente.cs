using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.dominio
{
    [DataContract]
    public class Agente
    {
         [DataMember]
        public int CodAgente { get; set; }
         [DataMember]
        public String RazonSocial { get; set; }
         [DataMember]
        public String RUC { get; set; }
         [DataMember]
        public String CorreoAgente { get; set; }
         [DataMember]
        public String Direccion { get; set; }
         [DataMember]
        public String NroCuentaInterbancaria { get; set; }
    }
}