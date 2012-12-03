using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class TipoPaquete
    {
        [DataMember]
        public int CodTipoPaquete { get; set; }
        [DataMember]
        public string NombreTipoPaquete { get; set; }
    }
}