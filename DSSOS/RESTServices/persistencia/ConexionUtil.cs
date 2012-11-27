using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.persistencia
{
    public class ConexionUtil
    {
        public static String Cadena
        {
            get
            {
                return "Data Source=(local); Initial Catalog=bdPaquetesTuristicos; Integrated Security=SSPI;";
            }
        }
    }
}