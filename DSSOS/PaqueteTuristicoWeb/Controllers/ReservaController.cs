using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaqueteTuristicoWeb.Models;
using PaqueteTuristicoWeb.Utiles;

namespace PaqueteTuristicoWeb.Controllers
{
    public class ReservaController : Controller
    {
        TourWS.TourServiceClient proxy = new TourWS.TourServiceClient();
        

        public ActionResult Index()
        {
            //List<TourWS.Reserva> model = proxy.ListarReservas();
            return View(proxy.ListarReservas());

        }

        public ActionResult Details(int id)
        {
            TourWS.Reserva model = proxy.ObtenerReserva(id);
            return View(model);
        }
        public ActionResult Create()
        {
            //hallamos el paquete elegido
            var list = new SelectList(proxy.ListarPaquetes(), "CodPaquete", "NombrePaquete");
            ViewData["paquetes"] = list;

            //hallamos el cliente
            var list2 = new SelectList(proxy.ListarClientes(), "CodCliente", "NombreCliente");
            ViewData["clientes"] = list2;

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //int codReserva = int.Parse(collection["reservas"]);
                int codPaquete = int.Parse(collection["paquetes"]);
                int codCliente = int.Parse(collection["clientes"]);
                string estado = "R";  //de Reservado;
                DateTime fechaReserva = DateTime.Now;

                //se inserta
                proxy.CrearReserva(codPaquete, codCliente, estado, fechaReserva);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View();
            }
        }

        //POST/Reserva/Edit/5
        public ActionResult Edit(int id)
        {
            
            TourWS.Reserva model = proxy.ObtenerReserva(id);

            //hallamos el paquete elegido
            var list = new SelectList(proxy.ListarPaquetes(), "CodPaquete", "NombrePaquete", model.Paquete.CodPaquete);
            ViewData["paquetes"] = list;

            //hallamos el cliente
            var list2 = new SelectList(proxy.ListarClientes(), "CodCliente", "NombreCliente", model.Cliente.CodCliente);
            ViewData["clientes"] = list2;

            return View(model);
        }

        //
        // POST: /Reserva/Edit/5
        //recibe datos del formulario y realiza modificación
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                int codReserva = id;
                int codPaquete = int.Parse(collection["paquetes"]);
                int codCliente = int.Parse(collection["clientes"]);
                string estado = (string)collection["Estado"];
                DateTime fechaReserva = Funciones.creaFecha(collection["FechaReserva"]);

                //se inserta
                proxy.ModificarReserva(codReserva,codPaquete, codCliente, estado, fechaReserva);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}