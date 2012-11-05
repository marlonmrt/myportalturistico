using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaqueteTuristicoWeb.Models;

namespace PaqueteTuristicoWeb.Controllers
{
    public class PaqueteController : Controller
    {

        private List<TipoPaquete> CrearTiposPaquete()
        {
            List<TipoPaquete> tiposPaquete = new List<TipoPaquete>();
            tiposPaquete.Add(new TipoPaquete()
            {
                Codigo = 1,
                Nombre = "Full Day"
            });
            tiposPaquete.Add(new TipoPaquete()
            {
                Codigo = 2,
                Nombre = "Excursiones"
            });
            tiposPaquete.Add(new TipoPaquete()
            {
                Codigo = 3,
                Nombre = "Turismo ecológico"
            });

            return tiposPaquete;
        }

        private TipoPaquete ObtenerTipoPaquete(int Codigo)
        {
            List<TipoPaquete> tiposPaquete = CrearTiposPaquete();
            TipoPaquete model = tiposPaquete.Single(delegate(TipoPaquete tipoPaquete)
            {
                if (tipoPaquete.Codigo == Codigo) return true;
                else return false;
            });
            return model;
        }
       
        
        private List<Paquete> CrearPaquetes()
        {
            TipoPaquete fullDay = new TipoPaquete() { Codigo = 1, Nombre = "Full Day" };
            TipoPaquete excursion = new TipoPaquete() { Codigo = 2, Nombre = "Excursiones" };

            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new Paquete() { Codigo = 1,
                                         TipoPaquete = fullDay, 
                                         Nombre = "Full Day Caral", 
                                         FechaInicio = "18/03/2012",
                                         FechaFin = "18/03/2012",
                                         HoraInicio = "8 am",
                                         HoraFin = "8 pm",
                                         Descripcion = "Viva la Aventura del Canotaje full day Lunahuana", 
                                         Lugares = "Lunahuana",
                                         InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                                         Precio = 40.5M
                                         });
            paquetes.Add(new Paquete()
            {
                Codigo = 2,
                TipoPaquete = fullDay,
                Nombre = "Full Day Paracas",
                FechaInicio = "18/06/2012",
                FechaFin = "18/06/2012",
                HoraInicio = "8 am",
                HoraFin = "8 pm",
                Descripcion = "Descubre el encanto de las Dunas de Ica Full Day Paracas/Ica",
                Lugares = "Paracas, Islas Ballestas",
                InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                Precio = 56.3M
            });
            paquetes.Add(new Paquete()
            {
                Codigo = 3,
                TipoPaquete = excursion,
                Nombre = "Tour Noches de Luna Lllena",
                FechaInicio = "18/03/2012",
                FechaFin = "18/03/2012",
                HoraInicio = "8 am",
                HoraFin = "8 pm",
                Descripcion = "Tour nocturno al cementerio Presbítero Maestro",
                Lugares = "cementerio Presbítero Maestro, Lima",
                InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                Precio = 40.5M
            });
            return paquetes;
        }
        private Paquete ObtenerPaquete(int Codigo)
        {
            List<Paquete> paquetes = (List<Paquete>)Session["paquetes"];
            Paquete model = paquetes.Single(delegate(Paquete paquete)
            {
                if (paquete.Codigo == Codigo) return true;
                else return false;
            });
            return model;
        }
        
        //
        // GET: /Paquete/
        // muestra página con listado de paquetes
        public ActionResult Index()
        {
            // inicializo el listado de paquetes
            if (Session["paquetes"] == null)
                Session["paquetes"] = CrearPaquetes();
            List<Paquete> model = (List<Paquete>)Session["paquetes"];

            return View(model);
        }

        //
        // GET: /Paquete/Details/5
        // muestra página con datos de un paquete
        public ActionResult Details(int id)
        {
            Paquete model = ObtenerPaquete(id);
            return View(model);
        }

        //
        // GET: /Paquete/Create
        //muestra página para ingresar datos de creación
        public ActionResult Create()
        {
           /*
            // inicializo el listado de tiposPaquetes
            if (Session["tiposPaquete"] == null)
                Session["tiposPaquete"] = CrearTiposPaquete();
            List<TipoPaquete> modelTipoPaquete = (List<TipoPaquete>)Session["tiposPaquete"];
            
            return View(modelTipoPaquete);
            * 
            * */

            var list = new SelectList(CrearTiposPaquete(), "Codigo", "Nombre");
            ViewData["tiposPaquete"] = list;
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
                int p = int.Parse(collection["tiposPaquete"]);
                //obtenemos el tipoPaquete
                TipoPaquete tipoPaquete = ObtenerTipoPaquete(int.Parse(collection["tiposPaquete"]));
                

                //de la variable collection llenamos la lista de paquetes
                List<Paquete> paquetes = (List<Paquete>)Session["paquetes"];
                paquetes.Add(new Paquete()
                {
                    Codigo = int.Parse(collection["Codigo"]),
                    TipoPaquete = new TipoPaquete()
                    {
                        Codigo = tipoPaquete.Codigo,
                        Nombre = tipoPaquete.Nombre,
                    },
                    Nombre = collection["Nombre"],
                    FechaInicio = collection["FechaInicio"],
                    FechaFin = collection["FechaFin"],
                    HoraInicio = collection["HoraInicio"],
                    HoraFin = collection["HoraFin"],
                    Descripcion = collection["Descripcion"],
                    Lugares = collection["Lugares"],
                    InformacionAdicional = collection["InformacionAdicional"],
                    Precio = decimal.Parse(collection["Precio"])
                });
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
            Paquete model = ObtenerPaquete(id);
            //hallamos el tipo de paquete elegido
            var list = new SelectList( CrearTiposPaquete(), "Codigo", "Nombre", model.TipoPaquete.Codigo);
            ViewData["tiposPaquete"] = list;
            
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
                // TODO: Add update logic here
                int p = int.Parse(collection["tiposPaquete"]);
                //obtenemos el tipoPaquete
                TipoPaquete tipoPaquete = ObtenerTipoPaquete(int.Parse(collection["tiposPaquete"]));

                Paquete model = ObtenerPaquete(id);
                model.TipoPaquete.Codigo = tipoPaquete.Codigo;
                model.TipoPaquete.Nombre = tipoPaquete.Nombre;
                model.Nombre = collection["Nombre"];
                model.FechaInicio = collection["FechaInicio"];
                model.FechaFin = collection["FechaFin"];
                model.HoraInicio = collection["HoraInicio"];
                model.HoraFin = collection["HoraFin"];
                model.Descripcion = collection["Descripcion"];
                model.Lugares = collection["Lugares"];
                model.InformacionAdicional = collection["InformacionAdicional"];
                model.Precio = decimal.Parse(collection["Precio"]);
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
            Paquete model = ObtenerPaquete(id);
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
                List<Paquete> paquetes = (List<Paquete>)Session["paquetes"];
                paquetes.Remove(ObtenerPaquete(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
