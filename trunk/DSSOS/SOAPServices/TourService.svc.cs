using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TourService" en el código, en svc y en el archivo de configuración a la vez.
    public class TourService : ITourService
    {
        
        #region Miembros de ITourService

        private TipoPaqueteDAO tipoPaqueteDAO = null;
        private TipoPaqueteDAO TipoPaqueteDAO
        {
            get
            {
                if (tipoPaqueteDAO == null)
                    tipoPaqueteDAO = new TipoPaqueteDAO();
                return tipoPaqueteDAO;
            }
        }

        private AgenteDAO agenteDAO = null;
        private AgenteDAO AgenteDAO
        {
            get
            {
                if (agenteDAO == null)
                    agenteDAO = new AgenteDAO();
                return agenteDAO;
            }
        }

        private PaqueteDAO paqueteDAO = null;
        private PaqueteDAO PaqueteDAO
        {
            get
            {
                if (paqueteDAO == null)
                    paqueteDAO = new PaqueteDAO();
                return paqueteDAO;
            }
        }

        private ReservaDAO reservaDAO = null;
        private ReservaDAO ReservaDAO 
        {
            get
            {
                if (reservaDAO == null)
                    reservaDAO = new ReservaDAO();
                return reservaDAO;
            }
        }

        private ClienteDAO clienteDAO = null;
        private ClienteDAO ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDAO();
                return clienteDAO;
            }
        }

        //*****************************************************************
        
        public TipoPaquete ObtenerTipoPaquete(int codigo)
        {
            return TipoPaqueteDAO.Obtener(codigo);
        }
        //*****************************************************************
       /*
        public Agente CrearAgente(String razonSocial, String ruc, String correoAgente, String direccion, String nroCuentaInterBancaria)
        {
            Agente agenteACrear = new Agente()
            {
                RazonSocial = razonSocial,
                RUC = ruc,
                CorreoAgente = correoAgente,
                Direccion = direccion,
                NroCuentaInterbancaria = nroCuentaInterBancaria

            };
            //return AgenteDAO.Crear(agenteACrear); // falta terminar el codigo para ingreso a DB
            return agenteACrear;

        }
        * */

        public Agente ObtenerAgente(int codigo)
        {
            return AgenteDAO.Obtener(codigo);
        }

        /*
        public Agente ModificarAgente(int codigo, string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaInterBancaria)
        {

            Agente agenteAModificar = new Agente()
            {
                CodAgente = codigo,
                RUC = ruc,
                CorreoAgente = correoAgente,
                Direccion = direccion,
                NroCuentaInterbancaria = nroCuentaInterBancaria

            };

            return AgenteDAO.Modificar(agenteAModificar);

        }
         * */
        /*
        public void EliminarAgente(int codigo)
        {
            Agente agenteExistente = AgenteDAO.Obtener(codigo);
            AgenteDAO.Eliminar(agenteExistente);
        }
         * */

        public List<Agente> ListarAgentes()
        {
            return AgenteDAO.ListarTodos().ToList();
        }
        //*****************************************************************

        public List<TipoPaquete> ListarTiposPaquete()
        {
            return TipoPaqueteDAO.ListarTodos().ToList();
        }
        //*****************************************************************
        
        public Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente)
        {
            /*
            try
            {
                if(DateTime.Compare(fechaInicio,fechaFin) >0){
                    throw new System.ArgumentException("la fecha de fin no puede ser menor que la del inicio", "original");
                }

            */
                TipoPaquete tipoPaqueteExistente = TipoPaqueteDAO.Obtener(tipoPaquete);
                Agente agenteExistente = AgenteDAO.Obtener(agente);

                Paquete paqueteACrear = new Paquete()
                {
                    TipoPaquete = tipoPaqueteExistente,
                    NombrePaquete = nombrePaquete,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    HoraInicio = horaInicio,
                    HoraFin = horaFin,
                    Descripcion = descripcion,
                    Lugares = lugares,
                    InformacionAdicional = informacionAdicional,
                    Precio = precio,
                    Cupos = cupos,
                    Registrados = registrados,
                    Agente = agenteExistente

                };

                return PaqueteDAO.Crear(paqueteACrear);
            /*
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            */
           
        }
        //*****************************************************************
        public Paquete ObtenerPaquete(int codigo)
        {
            return PaqueteDAO.Obtener(codigo);
        }
        //*****************************************************************
        public Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente)
        {
            TipoPaquete tipoPaqueteExistente = TipoPaqueteDAO.Obtener(tipoPaquete);
            Agente agenteExistente = AgenteDAO.Obtener(agente);

            Paquete paqueteAModificar = new Paquete()
            {
                CodPaquete = codigo,
                TipoPaquete = tipoPaqueteExistente,
                NombrePaquete = nombrePaquete,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                HoraInicio = horaInicio,
                HoraFin = horaFin,
                Descripcion = descripcion,
                Lugares = lugares,
                InformacionAdicional = informacionAdicional,
                Precio = precio,
                Cupos = cupos,
                Registrados = registrados,
                Agente = agenteExistente

            };

            return PaqueteDAO.Modificar(paqueteAModificar);
        }
        //*****************************************************************
        public void EliminarPaquete(int codigo)
        {
            Paquete paqueteExistente = PaqueteDAO.Obtener(codigo);
            PaqueteDAO.Eliminar(paqueteExistente);
        }
        //*****************************************************************
        public List<Paquete> ListarPaquetes()
        {
            return PaqueteDAO.ListarTodos().ToList();
        }
        //*****************************************************************

        public Reserva CrearReserva(int codPaquete, int codCliente, string estado, DateTime fechaReserva)
        {
            Paquete paqueteExistente = paqueteDAO.Obtener(codPaquete);
            Cliente clienteExistente = clienteDAO.Obtener(codCliente);

            Reserva reservaACrear = new Reserva()
            {
                Paquete = paqueteExistente,
                Cliente = clienteExistente,
                Estado = estado,
                FechaReserva = fechaReserva


            };
            return ReservaDAO.Crear(reservaACrear);
        }

        public Reserva ObtenerReserva(int codReserva) 
        {
            return ReservaDAO.Obtener(codReserva);
        }
        public Reserva ModificarReserva(int codReserva, int codPaquete, int codCliente, string estado, DateTime fechaReserva) 
        {
            Reserva reservaExistente = reservaDAO.Obtener(codReserva);
            Paquete paqueteExistente = paqueteDAO.Obtener(codPaquete);
            Cliente clienteExistente = clienteDAO.Obtener(codCliente); 

            Reserva reservaAModificar = new Reserva()
            {
                CodReserva = codReserva,
                Paquete = paqueteExistente,
                Cliente = clienteExistente,
                Estado = estado,
                FechaReserva = fechaReserva


            };
            return ReservaDAO.Modificar(reservaAModificar);
        }
        public void EliminarReserva(int codReserva) 
        {
            Reserva reservaExistente = ReservaDAO.Obtener(codReserva);
            ReservaDAO.Eliminar(reservaExistente);
        }
        public List<Reserva> ListarReservas()
        {
            return ReservaDAO.ListarTodos().ToList();
        }
        #endregion
    }
}