using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteTuristicoWeb.Utiles
{
    public class Funciones
    {

        public static DateTime creaFecha(string fechaString)
        {
            int dia;
            int mes;
            int anho;

            //fecha inicio en formato dia/mes/anho
            dia = int.Parse(Left(fechaString.Trim(), 2));
            mes = int.Parse(Mid(fechaString.Trim(), 4, 2));
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