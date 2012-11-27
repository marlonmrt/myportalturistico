using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.dominio
{
    [DataContract]
    public class TipoPaquete
    {
        [DataMember]
        public int CodTipoPaquete { get; set; }
        [DataMember]
        public String NombreTipoPaquete { get; set; }
    }
}