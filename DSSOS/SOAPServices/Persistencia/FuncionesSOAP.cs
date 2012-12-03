using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class FuncionesSOAP
    {
        public static List<object> ConvertArrayToList(object[] array)
        {
            List<object> list = new List<object>();

            foreach (object obj in array)
                list.Add(obj);

            return list;
        }
    }

}