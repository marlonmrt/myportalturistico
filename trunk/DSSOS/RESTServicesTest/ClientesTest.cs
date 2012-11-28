using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RESTServicesTest
{
    /// <summary>
    /// Summary description for Clientes
    /// </summary>
    [TestClass]
    public class ClientesTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ////creacion POST //cambiar DNI para que salga OK el test//////////////////////
            //string postdata = "{\"apellidoCli\":\"Villayzan\",\"correo\":\"gab2k@me.com\",\"dni\":\"45157029\",\"nombreCli\":\"Gabo\"}";
            //byte[] data = Encoding.UTF8.GetBytes(postdata);
            //HttpWebRequest req = (HttpWebRequest)WebRequest
            //    .Create("http://localhost:61984/Clientes.svc/Clientes");
            //req.Method = "POST";
            //req.ContentLength = data.Length;
            //req.ContentType = "application/json";

            //var reqStream = req.GetRequestStream();
            //reqStream.Write(data, 0, data.Length);

            //var res = (HttpWebResponse)req.GetResponse();
            //StreamReader reader = new StreamReader(res.GetResponseStream());
            //string alumnoJson = reader.ReadToEnd();
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //Cliente clienteCreado = js.Deserialize<Cliente>(alumnoJson);

            //Assert.AreEqual("45157029", clienteCreado.dni);
            //Assert.AreEqual("Gabo", clienteCreado.nombreCli);


            ////prueba obtener GET
            //HttpWebRequest req2 = (HttpWebRequest)WebRequest
            //    .Create("http://localhost:61984/Clientes.svc/Clientes/45157029");
            //req2.Method = "GET";
            //HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            //StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            //string clienteJson2 = reader2.ReadToEnd();
            //JavaScriptSerializer js2 = new JavaScriptSerializer();
            //Cliente clienteObtenido = js2.Deserialize<Cliente>(clienteJson2);

            //Assert.AreEqual("45157029", clienteObtenido.dni);
            //Assert.AreEqual("Gabo", clienteObtenido.nombreCli);




            //prueba LISTAR GET
            HttpWebRequest req3 = (HttpWebRequest)WebRequest
                .Create("http://localhost:61984/Clientes.svc/TodosClientes");
            req3.Method = "GET";
            HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();
            StreamReader reader3 = new StreamReader(res3.GetResponseStream());
            string clienteJson3 = reader3.ReadToEnd();
            JavaScriptSerializer js3 = new JavaScriptSerializer();
            List<Cliente> clientesObtenidos = js3.Deserialize<List<Cliente>>(clienteJson3);

            Assert.AreEqual(2, clientesObtenidos.Count);
            //Assert.AreEqual("user4", alumnosObtenidos.Nombre);


        }
    }
}
