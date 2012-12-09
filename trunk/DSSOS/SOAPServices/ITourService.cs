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

        /*
        [OperationContract]
        Agente CrearAgente(string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaBancaria);
         [OperationContract]
         Agente ModificarAgente(int codigo, string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaInterBancaria);
         [OperationContract]
         void EliminarAgente(int codigo);
       */

        
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
        Reserva ObtenerReserva(int CodReserva);
        [OperationContract]
        Reserva ModificarReserva(int CodReserva, int codPaquete, int codCliente, string Estado, DateTime FechaReserva);
        [OperationContract]
        void EliminarReserva(int CodReserva);
        [OperationContract]
        List<Reserva> ListarReservas();


    }
}