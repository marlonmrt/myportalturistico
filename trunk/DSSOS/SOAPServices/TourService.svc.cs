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

       
        //*****************************************************************
        
        public TipoPaquete ObtenerTipoPaquete(int codigo)
        {
            return TipoPaqueteDAO.Obtener(codigo);
        }
        public List<TipoPaquete> ListarTiposPaquete()
        {
            return TipoPaqueteDAO.ListarTodos().ToList();
        }
        //*****************************************************************
        public Agente ObtenerAgente(int codigo)
        {
            return AgenteDAO.Obtener(codigo);
        }

        public List<Agente> ListarAgentes()
        {
            return AgenteDAO.ListarTodos().ToList();
        }
        //*****************************************************************
        public Cliente ObtenerCliente(int codigo)
        {
            return ClienteDAO.Obtener(codigo);
        }

        public List<Cliente> ListarClientes()
        {
            return ClienteDAO.ListarTodos().ToList();
        }
       
        //*****************************************************************
        
        public Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente)
        {
            Paquete paqueteAux = null;
            try
            {
                //valida que la fecha de inicio sea menor que la fecha de fin
                if (DateTime.Compare(fechaInicio, fechaFin) > 0)
                {
                    FaultReason code = new FaultReason("Operación inválida");
                    throw new FaultException<Error>(
                        new Error()
                        {
                            CodigoNegocio = "Error1",
                            MensajeNegocio = "La fecha de fin no puede ser menor que la del inicio"

                        }, code);
                }
                else
                {
                    //valida que la hora de inicio sea menor que la hora de fin
                    if (horaInicio > horaFin)
                    {
                        FaultReason code = new FaultReason("Operación inválida");
                        throw new FaultException<Error>(
                            new Error()
                            {
                                CodigoNegocio = "Error1",
                                MensajeNegocio = "La hora de fin no puede ser menor que la del inicio"

                            }, code);
                    }
                    else
                    {

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

                        paqueteAux = PaqueteDAO.Crear(paqueteACrear);
                    }
                }
            }
            catch (FaultException<Error> faulte1)
            {
                throw faulte1;
            }
            catch (Exception e)
            {
                throw e;
            }

            return paqueteAux;
          
        }
        //*****************************************************************
        public Paquete ObtenerPaquete(int codigo)
        {
            return PaqueteDAO.Obtener(codigo);
        }
        //*****************************************************************
        public Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente)
        {
            Paquete paqueteAux = null;
            try
            {
                //valida que la fecha de inicio sea menor que la fecha de fin
                if (DateTime.Compare(fechaInicio, fechaFin) > 0)
                {
                    FaultReason code = new FaultReason("Operacion invalida");
                    throw new FaultException<Error>(
                        new Error()
                        {
                            CodigoNegocio = "Error1",
                            MensajeNegocio = "La fecha de fin no puede ser menor que la del inicio"

                        }, code);
                }
                else
                {
                    //valida que la hora de inicio sea menor que la hora de fin
                    if (horaInicio > horaFin)
                    {
                        FaultReason code = new FaultReason("Error general");
                        throw new FaultException<Error>(
                            new Error()
                            {
                                CodigoNegocio = "Error1",
                                MensajeNegocio = "La hora de fin no puede ser menor que la del inicio"

                            }, code);
                    }
                    else
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

                        paqueteAux = PaqueteDAO.Modificar(paqueteAModificar);
                    }
                }
            }
            catch (FaultException<Error> faultEx)
            {
                throw faultEx;
            }
            catch (Exception e)
            {
                throw e;
            }

            return paqueteAux;
            
            
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
            Paquete paqueteExistente = PaqueteDAO.Obtener(codPaquete);
            Cliente clienteExistente = ClienteDAO.Obtener(codCliente);

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
        public Reserva ModificarReserva(int codigo, int codPaquete, int codCliente, string estado, DateTime fechaReserva) 
        {
            Cliente clienteExistente = ClienteDAO.Obtener(codCliente); 
            Paquete paqueteExistente = PaqueteDAO.Obtener(codPaquete);
           
            Reserva reservaAModificar = new Reserva()
            {
                CodReserva = codigo,
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