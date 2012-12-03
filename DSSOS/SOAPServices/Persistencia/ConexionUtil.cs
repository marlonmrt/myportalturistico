using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
          return "Data Source=(local);Initial Catalog=bdPaquetesTuristicos;Integrated Security=SSPI;";
        }
    }
}