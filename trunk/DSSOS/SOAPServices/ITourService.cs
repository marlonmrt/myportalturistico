using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    [ServiceContract]
    public interface ITourService
    {
        // ********* para TipoPaquete ************************
        [OperationContract]
        TipoPaquete ObtenerTipoPaquete(int codigo);
        [OperationContract]
        List<TipoPaquete> ListarTiposPaquete();
        //*********** para  Agente  ****************************
       
        [OperationContract]
        Agente ObtenerAgente(int codigo);
        [OperationContract]
        List<Agente> ListarAgentes();
        //*********** para Cliente  ****************************
        [OperationContract]
        Cliente ObtenerCliente(int codigo);
        [OperationContract]
        List<Cliente> ListarClientes();
        //*********** para Paquete  ****************************
        //JV 08/12/2012
        [OperationContract]
        [FaultContract(typeof(Error))]
        Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente);
        
        [OperationContract]
        Paquete ObtenerPaquete(int codigo);
        //JV 08/12/2012
        [OperationContract]
        [FaultContract(typeof(Error))]
        Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente);
        
        [OperationContract]
        List<Paquete> ListarPaquetes();
        [OperationContract]
        void EliminarPaquete(int codigo);
        

        //*********Reserva**********
        [OperationContract]
        Reserva CrearReserva(int codPaquete, int codCliente, string Estado, DateTime FechaReserva);
        [OperationContract]
        Reserva ObtenerReserva(int codigo);
        [OperationContract]
        Reserva ModificarReserva(int codigo, int codPaquete, int codCliente, string Estado, DateTime FechaReserva);
        [OperationContract]
        void EliminarReserva(int codigo);
        [OperationContract]
        List<Reserva> ListarReservas();


    }
}