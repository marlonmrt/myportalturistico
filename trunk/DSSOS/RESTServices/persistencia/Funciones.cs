using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace RESTServices.persistencia
{
    public class Funciones
    {

        public static bool es_email(string email)
        {

            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            // Resultado: 
            //       Valid: david.jones@proseware.com 
            //       Valid: d.j@server1.proseware.com 
            //       Valid: jones@ms1.proseware.com 
            //       Invalid: j.@server1.proseware.com 
            //       Invalid: j@proseware.com9 
            //       Valid: js#internal@proseware.com 
            //       Valid: j_9@[129.126.118.1] 
            //       Invalid: j..s@proseware.com 
            //       Invalid: js*@proseware.com 
            //       Invalid: js@proseware..com 
            //       Invalid: js@proseware.com9 
            //       Valid: j.s@server1.proseware.com

            return regex.IsMatch(email);

        }
        
        //**********************************************************
        /*
        Función que valida que un DNI sean correctos en PERU
         */
        public static bool ValidaDNI(string dni)
        {
            return Regex.Match(dni, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success;
        }

       // Función que valida que un RUC sea correcto en PERU         
        public static bool ValidaRUC(string ruc)
        {
            return Regex.Match(ruc, @"^[1-2][0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success;
        }

        // Función que valida que un RUC sea correcto en PERU
        public static bool ValidaCCI(string cci)
        {
            return Regex.Match(cci, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success;
        }
    }

}