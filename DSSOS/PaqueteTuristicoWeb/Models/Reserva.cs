using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Reserva
    {
        public int CodReserva {get; set;}
        public Paquete Paquete { get; set; }
        public Cliente Cliente { get; set; }
        public String Estado { get; set; }  //R: reservado, C: confirmado
        public String FechaReserva { get; set; }
    }
}