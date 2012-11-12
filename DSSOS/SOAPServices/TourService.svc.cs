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
        
        //*****************************************************************
        
        public TipoPaquete ObtenerTipoPaquete(int codigo)
        {
            return TipoPaqueteDAO.Obtener(codigo);
        }
        //*****************************************************************
        public Agente CrearAgente(string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaInterBancaria)
        {
            Agente agenteACrear = new Agente()
            {

                RazonSocial = razonSocial,
                RUC = ruc,
                CorreoAgente = correoAgente,
                Direccion = direccion,
                NroCuentaInterbancaria = nroCuentaInterBancaria

            };

            return AgenteDAO.Crear(agenteACrear);

        }

        public Agente ObtenerAgente(int codigo)
        {
            return AgenteDAO.Obtener(codigo);
        }

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

        public void EliminarAgente(int codigo)
        {
            Agente agenteExistente = AgenteDAO.Obtener(codigo);
            AgenteDAO.Eliminar(agenteExistente);
        }

        public List<Agente> ListarAgentes()
        {
            return AgenteDAO.ListarTodos().ToList();
        }
        //*****************************************************************
        public Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente)
        {

            TipoPaquete tipoPaqueteExistente = TipoPaqueteDAO.Obtener(tipoPaquete);
            Agente  agenteExistente = AgenteDAO.Obtener(agente);

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

        }

        public Paquete ObtenerPaquete(int codigo)
        {
            return PaqueteDAO.Obtener(codigo);
        }

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

        public void EliminarPaquete(int codigo)
        {
            Paquete paqueteExistente = PaqueteDAO.Obtener(codigo);
            PaqueteDAO.Eliminar(paqueteExistente);
        }

        public List<Paquete> ListarPaquetes()
        {
            return PaqueteDAO.ListarTodos().ToList();
        }

        #endregion
    }
}
