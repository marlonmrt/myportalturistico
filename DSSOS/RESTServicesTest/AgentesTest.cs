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
    
    [TestClass]
    public class AgentesTest
    {

        [TestMethod]
        public void TestCrearAgente1()
        {
            
            //creacion POST //cambiar RUC para que salga OK el test//////////////////////
            string postdata = "{\"RazonSocial\":\"Viajes Falabella\",\"RUC\":\"10098273099\",\"CorreoAgente\":\"informes@viajesfalabella.com\",\"Direccion\":\"Av primavera 2263\",\"NroCuentaInterbancaria\":\"12345678912356\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30000/Agentes.svc/Agentes");
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
                string agenteJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Agente agenteCreado = js.Deserialize<Agente>(agenteJson);

                Assert.AreEqual("Viajes Falabella", agenteCreado.RazonSocial);
                Assert.AreEqual("10098273099", agenteCreado.RUC);
                Assert.AreEqual("informes@viajesfalabella.com", agenteCreado.CorreoAgente);
                Assert.AreEqual("Av primavera 2263", agenteCreado.Direccion);
                Assert.AreEqual("12345678912356", agenteCreado.NroCuentaInterbancaria);
               
            }
            catch (WebException e) //caso negativo
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error objetoError = js.Deserialize<Error>(error);
                
                Assert.AreEqual("Error4", objetoError.CodigoNegocio);
                Assert.AreEqual("El Agente 10098273099 ya existe !!!!!", objetoError.MensajeNegocio);
            }
           
        }

       
        [TestMethod]
        public void TestCrearAgente2()
        {
            //creacion POST //cambiar RUC para que salga OK el test//////////////////////
            string postdata = "{\"RazonSocial\":\"Viajes Falabella\",\"RUC\":\"10098273099\",\"CorreoAgente\":\"informes@viajesfalabella.com\",\"Direccion\":\"Av primavera 2263\",\"NroCuentaInterbancaria\":\"\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30000/Agentes.svc/Agentes");
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
                string agenteJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Agente agenteCreado = js.Deserialize<Agente>(agenteJson);

                Assert.AreEqual("Viajes Falabella", agenteCreado.RazonSocial);
                Assert.AreEqual("10098273099", agenteCreado.RUC);
                Assert.AreEqual("informes@viajesfalabella.com", agenteCreado.CorreoAgente);
                Assert.AreEqual("Av primavera 2263", agenteCreado.Direccion);
                Assert.AreEqual("12345678912356", agenteCreado.NroCuentaInterbancaria);

            }
            catch (WebException e) //caso negativo
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error objetoError = js.Deserialize<Error>(error);

                Assert.AreEqual("Error1", objetoError.CodigoNegocio);
                Assert.AreEqual("Se requiere el ingreso de todos los datos", objetoError.MensajeNegocio);
            }
           
        }

    }
}
