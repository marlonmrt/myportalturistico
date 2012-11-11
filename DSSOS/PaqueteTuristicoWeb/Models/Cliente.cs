using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public String NombreCliente { get; set; }
        public String ApellidosCliente { get; set; }
        public String DNI { get; set; }
        public String CorreoCliente { get; set; }
    }
}