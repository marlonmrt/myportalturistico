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
                CodTipoPaquete = 1,
                NombreTipoPaquete = "Full Day"
            });
            tiposPaquete.Add(new TipoPaquete()
            {
                CodTipoPaquete = 2,
                NombreTipoPaquete = "Excursiones"
            });
            tiposPaquete.Add(new TipoPaquete()
            {
                CodTipoPaquete = 3,
                NombreTipoPaquete = "Turismo ecológico"
            });

            return tiposPaquete;
        }

        private TipoPaquete ObtenerTipoPaquete(int Codigo)
        {
            List<TipoPaquete> tiposPaquete = CrearTiposPaquete();
            TipoPaquete model = tiposPaquete.Single(delegate(TipoPaquete tipoPaquete)
            {
                if (tipoPaquete.CodTipoPaquete == Codigo) return true;
                else return false;
            });
            return model;
        }
       //*****************************************************************************************
        
        private List<Paquete> CrearPaquetes()
        {
            
            //creo los tipos de paquete para armar el paquete 
            TipoPaquete fullDay = new TipoPaquete() { CodTipoPaquete = 1, NombreTipoPaquete = "Full Day" };
            TipoPaquete excursion = new TipoPaquete() { CodTipoPaquete = 2, NombreTipoPaquete = "Excursiones" };

           //creo que los agentes para asociarlos a los paquetes
            Agente agente1 = new Agente()
            {
                CodAgente = 1,
                RazonSocial = "Viajes Falabella",
                RUC = "10098273099",
                CorreoAgente = "informes@viajesfalabella.com",
                Direccion = "Av primavera 2263",
                NroCuentaInterbancaria = "123456789123"
            };
            Agente agente2 = new Agente()
            {
                CodAgente = 2,
                RazonSocial = "Paisajes Móviles",
                RUC = "10098273055",
                CorreoAgente = "informes@paisajesmov.com",
                Direccion = "Av San Juan 2263",
                NroCuentaInterbancaria = "05263963367455"
            };
           Agente agente3 = new Agente()
            {
                CodAgente = 3,
                RazonSocial = "Ica Tours",
                RUC = "10098273100",
                CorreoAgente = "informes@icatours.com",
                Direccion = "Av san miguel 2263",
                NroCuentaInterbancaria = "45296335456"
            };
            
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new Paquete() { CodPaquete = 1,
                                         TipoPaquete = fullDay, 
                                         NombrePaquete = "Full Day Caral", 
                                         FechaInicio = "18/03/2012",
                                         FechaFin = "18/03/2012",
                                         HoraInicio = "8 am",
                                         HoraFin = "8 pm",
                                         Descripcion = "Viva la Aventura del Canotaje full day Lunahuana", 
                                         Lugares = "Lunahuana",
                                         InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                                         Precio = 40.5M,
                                         Cupos = 10,
                                         Registrados = 0,
                                         Agente = agente1
                                         });
            paquetes.Add(new Paquete()
            {
                CodPaquete = 2,
                TipoPaquete = fullDay,
                NombrePaquete = "Full Day Paracas",
                FechaInicio = "18/06/2012",
                FechaFin = "18/06/2012",
                HoraInicio = "8 am",
                HoraFin = "8 pm",
                Descripcion = "Descubre el encanto de las Dunas de Ica Full Day Paracas/Ica",
                Lugares = "Paracas, Islas Ballestas",
                InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                Precio = 56.3M,
                Cupos = 20,
                Registrados = 0,
                Agente = agente3
            });
            paquetes.Add(new Paquete()
            {
                CodPaquete = 3,
                TipoPaquete = excursion,
                NombrePaquete = "Tour Noches de Luna Lllena",
                FechaInicio = "18/03/2012",
                FechaFin = "18/03/2012",
                HoraInicio = "8 am",
                HoraFin = "8 pm",
                Descripcion = "Tour nocturno al cementerio Presbítero Maestro",
                Lugares = "cementerio Presbítero Maestro, Lima",
                InformacionAdicional = "Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568",
                Precio = 40.5M,
                Cupos = 15,
                Registrados = 0,
                Agente = agente2
            });
            return paquetes;
        }
        private Paquete ObtenerPaquete(int Codigo)
        {
            List<Paquete> paquetes = (List<Paquete>)Session["paquetes"];
            Paquete model = paquetes.Single(delegate(Paquete paquete)
            {
                if (paquete.CodPaquete == Codigo) return true;
                else return false;
            });
            return model;
        }
        
        // ****************************************************************************************

        private List<Agente> CrearAgente()
        {
            List<Agente> agentes = new List<Agente>();
            agentes.Add(new Agente()
            {
                CodAgente = 1,
                RazonSocial = "Viajes Falabella",
                RUC = "10098273099",
                CorreoAgente = "informes@viajesfalabella.com",
                Direccion = "Av primavera 2263",
                NroCuentaInterbancaria = "123456789123"
            });
            agentes.Add(new Agente()
            {
                CodAgente = 2,
                RazonSocial = "Paisajes Móviles",
                RUC = "10098273055",
                CorreoAgente = "informes@paisajesmov.com",
                Direccion = "Av San Juan 2263",
                NroCuentaInterbancaria = "05263963367455"
            });
            agentes.Add(new Agente()
            {
                CodAgente = 3,
                RazonSocial = "Ica Tours",
                RUC = "10098273100",
                CorreoAgente = "informes@icatours.com",
                Direccion = "Av san miguel 2263",
                NroCuentaInterbancaria = "45296335456"
            });

            return agentes;
        }
        private Agente ObtenerAgente(int Codigo)
        {
            List<Agente> agentes = (List<Agente>)Session["agentes"];
            Agente model = agentes.Single(delegate(Agente agente)
            {
                if (agente.CodAgente == Codigo) return true;
                else return false;
            });
            return model;
        }

        // ****************************************************************************************


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
                    CodPaquete = int.Parse(collection["Codigo"]),
                    TipoPaquete = new TipoPaquete()
                    {
                        CodTipoPaquete = tipoPaquete.CodTipoPaquete,
                        NombreTipoPaquete = tipoPaquete.NombreTipoPaquete,
                    },
                    NombrePaquete = collection["Nombre"],
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
            var list = new SelectList( CrearTiposPaquete(), "Codigo", "Nombre", model.TipoPaquete.CodTipoPaquete);
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
                model.TipoPaquete.CodTipoPaquete = tipoPaquete.CodTipoPaquete;
                model.TipoPaquete.NombreTipoPaquete = tipoPaquete.NombreTipoPaquete;
                model.NombrePaquete = collection["Nombre"];
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
