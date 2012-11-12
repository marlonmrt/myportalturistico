using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Paquete
    {
        [DataMember]
        public int CodPaquete { get; set; }
        [DataMember]
        public TipoPaquete TipoPaquete { get; set; }
        [DataMember]
        public String NombrePaquete { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public DateTime FechaFin { get; set; }
        [DataMember]
        public int HoraInicio { get; set; }
        [DataMember]
        public int HoraFin { get; set; }
        [DataMember]
        public String Descripcion { get; set; }
        [DataMember]
        public String Lugares { get; set; }
        [DataMember]
        public String InformacionAdicional { get; set; }
        [DataMember]
        public Decimal Precio { get; set; }
        [DataMember]
        public int Cupos { get; set; }
        [DataMember]
        public int Registrados { get; set; }
        [DataMember]
        public Agente Agente { get; set; }  //se lleva el objeto Agente , pues está relacionado con él
    }
}