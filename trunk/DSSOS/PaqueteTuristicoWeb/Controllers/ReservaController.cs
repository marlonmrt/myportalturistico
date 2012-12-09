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
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //int codReserva = int.Parse(collection["reservas"]);
                int codPaquete = int.Parse(collection["CodPaquete"]);
                int codCliente = int.Parse(collection["CodCliente"]);
                string estado = (string)collection["Estado"];
                DateTime fechaReserva = Funciones.creaFecha(collection["FecharReserva"]);

                //se inserta
                proxy.CrearReserva(codPaquete, codCliente, estado, fechaReserva);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }    
    }
}