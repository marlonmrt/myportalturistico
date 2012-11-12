using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITourService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITourService
    {
        // ********* para TipoPaquete ************************
        [OperationContract]
        TipoPaquete ObtenerTipoPaquete(int codigo);
        //*********** para  Agente  ****************************
        [OperationContract]
        Agente CrearAgente(string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaBancaria);
        [OperationContract]
        Agente ObtenerAgente(int codigo);
        [OperationContract]
        Agente ModificarAgente(int codigo, string razonSocial, string ruc, string correoAgente, string direccion, string nroCuentaInterBancaria);
        [OperationContract]
        void EliminarAgente(int codigo);
        [OperationContract]
        List<Agente> ListarAgentes();
        //*********** para Paquete  ****************************
        [OperationContract]
        Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente);
        [OperationContract]
        Paquete ObtenerPaquete(int codigo);
        [OperationContract]
        Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, DateTime fechaInicio, DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, Decimal precio, int cupos, int registrados, int agente);
        [OperationContract]
        void EliminarPaquete(int codigo);
        [OperationContract]
        List<Paquete> ListarPaquetes();
    }
}
