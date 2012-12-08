using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Text;
using System.Net;
using System.IO;
using PaqueteTuristicoWeb.Models;

namespace PaqueteTuristicoWeb.Controllers
{
    public class AgenteController : Controller
    {
        private string agenteRESTService = "http://localhost:30000/Agentes.svc/Agentes";
        JavaScriptSerializer js = new JavaScriptSerializer();


        // GET: /Agente/
        public ActionResult Index()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string agentesJson = reader.ReadToEnd();
            List<Agente> agentes = js.Deserialize<List<Agente>>(agentesJson);
            return View(agentes);
        }

        //
        // GET: /Agente/Details/5

        public ActionResult Details(string id)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService + "/" + id);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string agenteJson = reader.ReadToEnd();
            Agente agente = js.Deserialize<Agente>(agenteJson);
            return View(agente);
        }

        //
        // GET: /Agente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Agente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //aqui se rellenan los datos que viene de la pantalla
                string postdata = "{\"RazonSocial\":\"" + collection["RazonSocial"] + "\",\"RUC\":\"" + collection["RUC"] + "\",\"CorreoAgente\":\"" + collection["CorreoAgente"] + "\",\"Direccion\":\"" + collection["Direccion"] + "\",\"NroCuentaInterbancaria\":\"" + collection["NroCuentaInterbancaria"] + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService);
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();

                //se manda el mensaje para que se vea en pantalla
                ViewData["mensaje"] = "Agente creado";
                return View();
                //return RedirectToAction("Index");
            }
            catch (WebException e) //caso negativo
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error objetoError = js.Deserialize<Error>(error);

                ModelState.AddModelError("Error", objetoError.MensajeNegocio);
                //se manda el mensaje para que se vea en pantalla
                ViewData["mensaje"] = "Error en el ingreso: " + objetoError.MensajeNegocio;
                return View();

            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                //se manda el mensaje para que se vea en pantalla
                ViewData["mensaje"] = "Error en el ingreso: " + e.Message;
                return View();
            }
        }

        // GET: /Agente/Edit/5 
        public ActionResult Edit(string id)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService + "/" + id);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string agenteJson = reader.ReadToEnd();
            Agente agente = js.Deserialize<Agente>(agenteJson);
            return View(agente);
        }

        // POST: /Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                string postdata = "{\"RazonSocial\":\"" + collection["RazonSocial"] + "\",\"RUC\":\"" + collection["RUC"] + "\",\"CorreoAgente\":\"" + collection["CorreoAgente"] + "\",\"Direccion\":\"" + collection["Direccion"] + "\",\"NroCuentaInterbancaria\":\"" + collection["NroCuentaInterbancaria"] + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService);
                req.Method = "PUT";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Alumno/Delete/5
        public ActionResult Delete(string id)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService + "/" + id);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string agenteJson = reader.ReadToEnd();
            Agente agente = js.Deserialize<Agente>(agenteJson);
            return View(agente);
        }

        // POST: /Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                string postdata = "\"" + id + "\"";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(agenteRESTService);
                req.Method = "DELETE";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

  

    }
}
