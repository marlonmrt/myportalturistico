using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Utiles
{
    public class Funciones
    {

        // metodo que crea una fecha dd/mm/aaaa a partir de un DateTime
        public static string creaFechaString(DateTime fecha)
        {
            string diaString ="";
            string mesString = "";
            int anho;

            //fecha inicio en formato dia/mes/anho
            if (fecha.Day < 10)
                diaString = "0" + fecha.Day.ToString();
            else
                diaString = fecha.Day.ToString();
            if (fecha.Month < 10)
                mesString = "0" + fecha.Month.ToString();
            else
                mesString = fecha.Month.ToString();

            anho = fecha.Year;
            string fechaString = diaString +"/"+mesString+"/"+anho.ToString();

            return fechaString;

        }
        //*****************************************
        // metodo que crea una fecha DateTime  a partir de una cadena con formato dd/mm/aaaa 
        public static DateTime creaFecha(string fechaString)
        {
            int dia;
            int mes;
            int anho;

            //fecha inicio en formato dia/mes/anho
            dia = int.Parse(Left(fechaString.Trim(), 2));
            mes = int.Parse(Mid(fechaString.Trim(), 3, 2));
            anho = int.Parse(Right(fechaString.Trim(), 4));
            DateTime fecha = new System.DateTime(anho, mes, dia);

            return fecha;

        }
        //******************************************
        public static string Left(string param, int length)
        {

            string result = param.Substring(0, length);
            return result;
        }
        //******************************************
        public static string Right(string param, int length)
        {

            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        //******************************************
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            return result;
        }
    }
}