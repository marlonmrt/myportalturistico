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
            return View();
        }

        //
        // GET: /Agente/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cliente/Create

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
                string postdata = "{\"RazonSocial\":\"" + collection["RazonSocial"] + "\",\"Direccion\":\"" + collection["Direccion"] + "\",\"RUC\":\"" + collection["RUC"] + "\",\"CorreoAgente\":\"" + collection["CorreoAgente"] + "\"}";
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

        //
        // GET: /Agente/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Agente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Agente/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Agente/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
