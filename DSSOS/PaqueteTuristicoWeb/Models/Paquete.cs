using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Paquete
    {
        public int Codigo { get; set; }
        public TipoPaquete TipoPaquete { get; set; }
        public String Nombre { get; set; }
        public String FechaInicio { get; set; }
        public String FechaFin { get; set; }
        public String HoraInicio { get; set; }
        public String HoraFin { get; set; }
        public String Descripcion { get; set; }
        public String Lugares { get; set; }
        public String InformacionAdicional { get; set; }
        public Decimal Precio { get; set; }
    }
}