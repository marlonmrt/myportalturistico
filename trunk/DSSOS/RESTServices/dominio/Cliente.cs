using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public String nombreCli { get; set; }

        [DataMember]
        public String apellidoCli{ get; set; }

        [DataMember]
        public String dni { get; set; }

        [DataMember]
        public String correo { get; set; }
    }
}