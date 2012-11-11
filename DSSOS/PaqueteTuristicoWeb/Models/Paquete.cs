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
        public String NombrePaquete { get; set; }
        public String FechaInicio { get; set; }
        public String FechaFin { get; set; }
        public String HoraInicio { get; set; }
        public String HoraFin { get; set; }
        public String Descripcion { get; set; }
        public String Lugares { get; set; }
        public String InformacionAdicional { get; set; }
        public Decimal Precio { get; set; }
        public int Cupos { get; set; }
        public int Registrados { get; set; }
        public Agente Agente { get; set; }  //se lleva el objeto Agente , pues está relacionado con él
    }
}