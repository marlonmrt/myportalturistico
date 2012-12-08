using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Reserva
    {
        [DataMember]
        public int CodReserva { get; set; }
        [DataMember]
        public Paquete Paquete { get; set; }
        [DataMember]
        public Cliente Cliente { get; set; }
        [DataMember]
        public String Estado { get; set; }  //R: reservado, C: confirmado
        [DataMember]
        public DateTime FechaReserva { get; set; }

    }
}