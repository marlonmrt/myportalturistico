using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Agente
    {
        public int CodAgente { get; set; }
        public String RazonSocial { get; set; }
        public String RUC { get; set; }
        public String CorreoAgente { get; set; }
        public String Direccion { get; set; }
        public String NroCuentaInterbancaria { get; set; }
    }
}