using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int CodCliente { get; set; }
        [DataMember]
        public string NombreCliente { get; set; }
        [DataMember]
        public string ApellidoCliente { get; set; }
        [DataMember]
        public string DNI { get; set; }
        [DataMember]
        public string CorreoCliente { get; set; }
    }
}