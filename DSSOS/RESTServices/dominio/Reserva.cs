﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.dominio
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
        public String FechaReserva { get; set; }

    }
}