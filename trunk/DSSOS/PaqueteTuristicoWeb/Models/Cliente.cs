using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DNI { get; set; }
        public string CorreoCliente { get; set; }
    }
}