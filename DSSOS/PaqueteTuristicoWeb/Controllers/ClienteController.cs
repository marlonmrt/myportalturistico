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
    public class ClienteController : Controller
    {
        private string clienteRESTService = "http://localhost:30000/Clientes.svc/Clientes";
        JavaScriptSerializer js = new JavaScriptSerializer();


        // GET: /Cliente/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Cliente/Details/5

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
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //aqui se rellenan los datos que viene de la pantalla
                string postdata = "{\"NombreCliente\":\"" + collection["NombreCliente"] + "\",\"ApellidoCliente\":\"" + collection["ApellidoCliente"] + "\",\"DNI\":\"" + collection["DNI"] + "\",\"CorreoCliente\":\"" + collection["CorreoCliente"] + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(clienteRESTService);
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();

                //se manda el mensaje para que se vea en pantalla
                ViewData["mensaje"] = "Cliente creado";
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
               

            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                //se manda el mensaje para que se vea en pantalla
                ViewData["mensaje"] = "Error en el ingreso: " + e.Message;
               
            }

            return View();
        }
        
        //
        // GET: /Cliente/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Edit/5

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
        // GET: /Cliente/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Delete/5

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
