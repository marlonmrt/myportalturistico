using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaqueteTuristicoWeb.Models;
using PaqueteTuristicoWeb.Utiles;

namespace PaqueteTuristicoWeb.Controllers
{
    public class PaqueteController : Controller
    {
        TourWS.TourServiceClient proxy = new TourWS.TourServiceClient();


        // ****************************************************************************************

        //
        // GET: /Paquete/
        // muestra página con listado de paquetes
        public ActionResult Index()
        {
            return View(proxy.ListarPaquetes());
        }

        //
        // GET: /Paquete/Details/5
        // muestra página con datos de un paquete
        public ActionResult Details(int id)
        {
            TourWS.Paquete model = proxy.ObtenerPaquete(id);
            return View(model);
        }

        //
        // GET: /Paquete/Create
        //muestra página para ingresar datos de creación
        public ActionResult Create()
        {

            var list = new SelectList(proxy.ListarTiposPaquete(), "CodTipoPaquete", "NombreTipoPaquete");
            ViewData["tiposPaquete"] = list;

            var list2 = new SelectList(proxy.ListarAgentes(), "CodAgente", "RazonSocial");
            ViewData["agentes"] = list2;

            return View();
        }

        //
        // POST: /Paquete/Create
        //recibe los datos del formulario y realiza creación
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //el codigo no porque es autogenerado en la base
                int codTipoPaquete = int.Parse(collection["tiposPaquete"]);
                int codAgente = int.Parse(collection["agentes"]);
                string NombrePaquete = (string)collection["NombrePaquete"];
                //el método creaFecha crea una fecha a partir de la cadena dd/mm/aaaa recibida
                DateTime FechaInicio = Funciones.creaFecha(collection["FechaInicio"]);
                DateTime FechaFin = Funciones.creaFecha(collection["FechaFin"]);
                int HoraInicio = int.Parse(collection["HoraInicio"]);
                int HoraFin = int.Parse(collection["HoraFin"]);
                string Descripcion = (string)collection["Descripcion"];
                string Lugares = (string)collection["Lugares"];
                string InformacionAdicional = (string)collection["InformacionAdicional"];
                decimal Precio = decimal.Parse(collection["Precio"]);
                int Cupos = int.Parse(collection["Cupos"]);
                int Registrados = int.Parse(collection["Registrados"]);

                //se inserta
                proxy.CrearPaquete(codTipoPaquete, NombrePaquete, FechaInicio, FechaFin, HoraInicio, HoraFin, Descripcion, Lugares, InformacionAdicional, Precio, Cupos, Registrados, codAgente);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Paquete/Edit/5
        //muestra página con los datos a editar
        public ActionResult Edit(int id)
        {
            TourWS.Paquete model = proxy.ObtenerPaquete(id);
            //hallamos el tipo de paquete elegido
            var list = new SelectList(proxy.ListarTiposPaquete(), "CodTipoPaquete", "NombreTipoPaquete", model.TipoPaquete.CodTipoPaquete);
            ViewData["tiposPaquete"] = list;

            var list2 = new SelectList(proxy.ListarAgentes(), "CodAgente", "RazonSocial", model.Agente.CodAgente);
            ViewData["agentes"] = list2;

            return View(model);
        }

        //
        // POST: /Paquete/Edit/5
        //recibe datos del formulario y realiza modificación
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //ahora el código si
                int codPaquete = id;
                int codTipoPaquete = int.Parse(collection["tiposPaquete"]);
                int codAgente = int.Parse(collection["agentes"]);
                string NombrePaquete = (string)collection["NombrePaquete"];
                //el método creaFecha crea una fecha a partir de la cadena dd/mm/aaaa recibida
                DateTime FechaInicio = Funciones.creaFecha(collection["FechaInicio"]);
                DateTime FechaFin = Funciones.creaFecha(collection["FechaFin"]);
                int HoraInicio = int.Parse(collection["HoraInicio"]);
                int HoraFin = int.Parse(collection["HoraFin"]);
                string Descripcion = (string)collection["Descripcion"];
                string Lugares = (string)collection["Lugares"];
                string InformacionAdicional = (string)collection["InformacionAdicional"];
                decimal Precio = decimal.Parse(collection["Precio"]);
                int Cupos = int.Parse(collection["Cupos"]);
                int Registrados = int.Parse(collection["Registrados"]);

                //se inserta
                proxy.ModificarPaquete(codPaquete, codTipoPaquete, NombrePaquete, FechaInicio, FechaFin, HoraInicio, HoraFin, Descripcion, Lugares, InformacionAdicional, Precio, Cupos, Registrados, codAgente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Paquete/Delete/5

        public ActionResult Delete(int id)
        {
            TourWS.Paquete model = proxy.ObtenerPaquete(id);
            return View(model);
        }

        //
        // POST: /Paquete/Delete/5
        //realiza la eliminación
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                /*
                List<Paquete> paquetes = (List<Paquete>)Session["paquetes"];
                paquetes.Remove(ObtenerPaquete(id));
                 * */
                proxy.EliminarPaquete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
