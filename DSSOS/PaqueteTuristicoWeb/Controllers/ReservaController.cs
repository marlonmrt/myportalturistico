using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaqueteTuristicoWeb.Models;

namespace ReservaTuristicoWeb.Controllers
{
    public class ReservaController : Controller
    {
        
        //data hardcodeada
        private List<Reserva> CrearReservas()
        {

            //creo que los clientes para asociarlos a los paquetes
            Cliente cliente1 = new Cliente()
            {
                CodCliente = 1,
                NombreCliente = "Julio",
                ApellidoCliente = "Vilca",
                DNI = "09827309",
                CorreoCliente = "julio.vilca@gmail.com"
            };
            Cliente cliente2 = new Cliente()
            {
                CodCliente = 2,
                NombreCliente = "Ruth",
                ApellidoCliente = "García",
                DNI = "09827308",
                CorreoCliente = "ruthgarcia@gmail.com"
            };


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
            
            
            //creo los tipos de paquete para asociarlos a los paquetes 
            TipoPaquete fullDay = new TipoPaquete() { CodTipoPaquete = 1, NombreTipoPaquete = "Full Day" };
            TipoPaquete excursion = new TipoPaquete() { CodTipoPaquete = 2, NombreTipoPaquete = "Excursiones" };

           //creamos los paquetes harcodeados 

           Paquete paquete1 = new Paquete()
            {
                CodPaquete = 1,
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
            };

            Paquete paquete2 = new Paquete()
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
            };
            Paquete paquete3 = new Paquete()
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
            };

            //aqui lleno las reservas 
            List<Reserva> reservas = new List<Reserva>();
            reservas.Add(new Reserva()
            {
                CodReserva = 1,
                Paquete = paquete1,
                Cliente = cliente1,
                FechaReserva = "11/11/2012",
                Estado = "R"
            });

            return reservas;
        }
        private Reserva ObtenerReserva(int Codigo)
        {
            List<Reserva> Reservas = (List<Reserva>)Session["Reservas"];
            Reserva model = Reservas.Single(delegate(Reserva Reserva)
            {
                if (Reserva.CodReserva == Codigo) return true;
                else return false;
            });
            return model;
        }
        
        
        
        
        
        
        
        
        
        
        
        //
        // GET: /Reserva/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Reserva/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reserva/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Reserva/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Reserva/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Edit/5

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
        // GET: /Reserva/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Delete/5

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
