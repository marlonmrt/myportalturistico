using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Paquete
    {
        public int CodPaquete { get; set; }
        public TipoPaquete TipoPaquete { get; set; }
        public string NombrePaquete { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public string Descripcion { get; set; }
        public string Lugares { get; set; }
        public string InformacionAdicional { get; set; }
        public decimal Precio { get; set; }
        public int Cupos { get; set; }
        public int Registrados { get; set; }
        public Agente Agente { get; set; }  //se lleva el objeto Agente , pues está relacionado con él
    }
}