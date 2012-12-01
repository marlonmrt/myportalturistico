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

        //[TestMethod]
        public void TestCrearCliente1()
        {
            // /*
            //creacion POST //cambiar DNI para que salga OK el test//////////////////////
            string postdata = "{\"apellidoCli\":\"Villayzan\",\"correo\":\"gab2k@me.com\",\"dni\":\"45157029\",\"nombreCli\":\"Gabo\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1020/Clientes.svc/Clientes");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;

            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string alumnoJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Cliente clienteCreado = js.Deserialize<Cliente>(alumnoJson);

                Assert.AreEqual("45157029", clienteCreado.dni);
                Assert.AreEqual("Gabo", clienteCreado.nombreCli);
                Assert.AreEqual("Villayzan", clienteCreado.apellidoCli);
                Assert.AreEqual("gab2k@me.com", clienteCreado.correo);
               
            }
            catch (WebException e) //caso negativo
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error objetoError = js.Deserialize<Error>(error);
                
                Assert.AreEqual("Error1", objetoError.CodigoNegocio);
                Assert.AreEqual("El cliente 45157029 ya existe !!!!!", objetoError.MensajeNegocio);
            }

           
        }

        [TestMethod]
        public void TestCrearCliente2()
        {
            // /*
            //creacion POST //cambiar DNI para que salga OK el test//////////////////////
            string postdata = "{\"apellidoCli\":\"\",\"correo\":\"gab2k@me.com\",\"dni\":\"45157029\",\"nombreCli\":\"Gabo\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1020/Clientes.svc/Clientes");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;

            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string alumnoJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Cliente clienteCreado = js.Deserialize<Cliente>(alumnoJson);

                Assert.AreEqual("45157029", clienteCreado.dni);
                Assert.AreEqual("Gabo", clienteCreado.nombreCli);
                Assert.AreEqual("Villayzan", clienteCreado.apellidoCli);
                Assert.AreEqual("gab2k@me.com", clienteCreado.correo);

            }
            catch (WebException e) //caso negativo
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error objetoError = js.Deserialize<Error>(error);

                Assert.AreEqual("Error2", objetoError.CodigoNegocio);
                Assert.AreEqual("Ingrese su información completa", objetoError.MensajeNegocio);
            }


        }

       
        // [TestMethod]
        public void TestGeneralCliente()
        {

            /*
        ////prueba obtener GET
        HttpWebRequest req2 = (HttpWebRequest)WebRequest
            .Create("http://localhost:1020/Clientes.svc/Clientes/45157029");
        req2.Method = "GET";
        HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
        StreamReader reader2 = new StreamReader(res2.GetResponseStream());
        string clienteJson2 = reader2.ReadToEnd();
        JavaScriptSerializer js2 = new JavaScriptSerializer();
        Cliente clienteObtenido = js2.Deserialize<Cliente>(clienteJson2);

        Assert.AreEqual("45157029", clienteObtenido.dni);
        Assert.AreEqual("Gabo", clienteObtenido.nombreCli);
          */

            /*
        //prueba LISTAR GET
        HttpWebRequest req3 = (HttpWebRequest)WebRequest
            .Create("http://localhost:1020/Clientes.svc/TodosClientes");
        req3.Method = "GET";
        HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();
        StreamReader reader3 = new StreamReader(res3.GetResponseStream());
        string clienteJson3 = reader3.ReadToEnd();
        JavaScriptSerializer js3 = new JavaScriptSerializer();
        List<Cliente> clientesObtenidos = js3.Deserialize<List<Cliente>>(clienteJson3);

        Assert.AreEqual(2, clientesObtenidos.Count);
        //Assert.AreEqual("user4", alumnosObtenidos.Nombre);
             */

            /*
        //////////////////elimina y valida el elimina //////////////////
        ///////prueba eliminar DELETE
        HttpWebRequest req4 = (HttpWebRequest)WebRequest
            .Create("http://localhost:1020/Clientes.svc/Clientes/45157029");
        req4.Method = "DELETE";
        HttpWebResponse res4 = (HttpWebResponse)req4.GetResponse();
        StreamReader reader4 = new StreamReader(res4.GetResponseStream());

        ////prueba obtener GET para validar el eliminar
        HttpWebRequest req5 = (HttpWebRequest)WebRequest
            .Create("http://localhost:1020/Clientes.svc/Clientes/45157029");
        req5.Method = "GET";
        HttpWebResponse res5 = (HttpWebResponse)req5.GetResponse();
        StreamReader reader5 = new StreamReader(res5.GetResponseStream());
        string clienteJson5 = reader5.ReadToEnd();
        JavaScriptSerializer js5 = new JavaScriptSerializer();
        Cliente clientebtenido = js5.Deserialize<Cliente>(clienteJson5);
        Assert.AreEqual(null, clientebtenido);
             */

            /*
          ////MODIFICACION PUT similar a creacion POST
          string postdata2 = "{\"apellidoCli\":\"Vilca\",\"correo\":\"julio.vilca@upc.edu.pe\",\"dni\":\"09827309\",\"nombreCli\":\"Felix\"}";
          byte[] data2 = Encoding.UTF8.GetBytes(postdata2);
          HttpWebRequest req6 = (HttpWebRequest)WebRequest
              .Create("http://localhost:1020/Clientes.svc/Clientes");
          req6.Method = "PUT";
          req6.ContentLength = data2.Length;
          req6.ContentType = "application/json";

          var reqStream6 = req6.GetRequestStream();
          reqStream6.Write(data2, 0, data2.Length);

          var res6 = (HttpWebResponse)req6.GetResponse(); //// aca fallaaaa
          StreamReader reader6 = new StreamReader(res6.GetResponseStream());
          string ClienteJson = reader6.ReadToEnd();
          JavaScriptSerializer js = new JavaScriptSerializer();
          Cliente ClienteCreado = js.Deserialize<Cliente>(ClienteJson);

          Assert.AreEqual("09827309", ClienteCreado.dni);
          Assert.AreEqual("Felix", ClienteCreado.nombreCli);

           */
        }
    }
}
