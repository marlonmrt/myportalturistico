﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServicesTest.TourWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoPaquete", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class TipoPaquete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodTipoPaqueteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreTipoPaqueteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodTipoPaquete {
            get {
                return this.CodTipoPaqueteField;
            }
            set {
                if ((this.CodTipoPaqueteField.Equals(value) != true)) {
                    this.CodTipoPaqueteField = value;
                    this.RaisePropertyChanged("CodTipoPaquete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreTipoPaquete {
            get {
                return this.NombreTipoPaqueteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreTipoPaqueteField, value) != true)) {
                    this.NombreTipoPaqueteField = value;
                    this.RaisePropertyChanged("NombreTipoPaquete");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agente", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Agente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodAgenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoAgenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroCuentaInterbancariaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RUCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RazonSocialField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodAgente {
            get {
                return this.CodAgenteField;
            }
            set {
                if ((this.CodAgenteField.Equals(value) != true)) {
                    this.CodAgenteField = value;
                    this.RaisePropertyChanged("CodAgente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoAgente {
            get {
                return this.CorreoAgenteField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoAgenteField, value) != true)) {
                    this.CorreoAgenteField = value;
                    this.RaisePropertyChanged("CorreoAgente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroCuentaInterbancaria {
            get {
                return this.NroCuentaInterbancariaField;
            }
            set {
                if ((object.ReferenceEquals(this.NroCuentaInterbancariaField, value) != true)) {
                    this.NroCuentaInterbancariaField = value;
                    this.RaisePropertyChanged("NroCuentaInterbancaria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RUC {
            get {
                return this.RUCField;
            }
            set {
                if ((object.ReferenceEquals(this.RUCField, value) != true)) {
                    this.RUCField = value;
                    this.RaisePropertyChanged("RUC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonSocial {
            get {
                return this.RazonSocialField;
            }
            set {
                if ((object.ReferenceEquals(this.RazonSocialField, value) != true)) {
                    this.RazonSocialField = value;
                    this.RaisePropertyChanged("RazonSocial");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreClienteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoCliente {
            get {
                return this.ApellidoClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoClienteField, value) != true)) {
                    this.ApellidoClienteField = value;
                    this.RaisePropertyChanged("ApellidoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodCliente {
            get {
                return this.CodClienteField;
            }
            set {
                if ((this.CodClienteField.Equals(value) != true)) {
                    this.CodClienteField = value;
                    this.RaisePropertyChanged("CodCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoCliente {
            get {
                return this.CorreoClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoClienteField, value) != true)) {
                    this.CorreoClienteField = value;
                    this.RaisePropertyChanged("CorreoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCliente {
            get {
                return this.NombreClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreClienteField, value) != true)) {
                    this.NombreClienteField = value;
                    this.RaisePropertyChanged("NombreCliente");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paquete", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Paquete : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAPServicesTest.TourWS.Agente AgenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodPaqueteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CuposField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaInicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoraFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoraInicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InformacionAdicionalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LugaresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePaqueteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RegistradosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAPServicesTest.TourWS.TipoPaquete TipoPaqueteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAPServicesTest.TourWS.Agente Agente {
            get {
                return this.AgenteField;
            }
            set {
                if ((object.ReferenceEquals(this.AgenteField, value) != true)) {
                    this.AgenteField = value;
                    this.RaisePropertyChanged("Agente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodPaquete {
            get {
                return this.CodPaqueteField;
            }
            set {
                if ((this.CodPaqueteField.Equals(value) != true)) {
                    this.CodPaqueteField = value;
                    this.RaisePropertyChanged("CodPaquete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cupos {
            get {
                return this.CuposField;
            }
            set {
                if ((this.CuposField.Equals(value) != true)) {
                    this.CuposField = value;
                    this.RaisePropertyChanged("Cupos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaFin {
            get {
                return this.FechaFinField;
            }
            set {
                if ((this.FechaFinField.Equals(value) != true)) {
                    this.FechaFinField = value;
                    this.RaisePropertyChanged("FechaFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaInicio {
            get {
                return this.FechaInicioField;
            }
            set {
                if ((this.FechaInicioField.Equals(value) != true)) {
                    this.FechaInicioField = value;
                    this.RaisePropertyChanged("FechaInicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HoraFin {
            get {
                return this.HoraFinField;
            }
            set {
                if ((this.HoraFinField.Equals(value) != true)) {
                    this.HoraFinField = value;
                    this.RaisePropertyChanged("HoraFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HoraInicio {
            get {
                return this.HoraInicioField;
            }
            set {
                if ((this.HoraInicioField.Equals(value) != true)) {
                    this.HoraInicioField = value;
                    this.RaisePropertyChanged("HoraInicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InformacionAdicional {
            get {
                return this.InformacionAdicionalField;
            }
            set {
                if ((object.ReferenceEquals(this.InformacionAdicionalField, value) != true)) {
                    this.InformacionAdicionalField = value;
                    this.RaisePropertyChanged("InformacionAdicional");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lugares {
            get {
                return this.LugaresField;
            }
            set {
                if ((object.ReferenceEquals(this.LugaresField, value) != true)) {
                    this.LugaresField = value;
                    this.RaisePropertyChanged("Lugares");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombrePaquete {
            get {
                return this.NombrePaqueteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePaqueteField, value) != true)) {
                    this.NombrePaqueteField = value;
                    this.RaisePropertyChanged("NombrePaquete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Registrados {
            get {
                return this.RegistradosField;
            }
            set {
                if ((this.RegistradosField.Equals(value) != true)) {
                    this.RegistradosField = value;
                    this.RaisePropertyChanged("Registrados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAPServicesTest.TourWS.TipoPaquete TipoPaquete {
            get {
                return this.TipoPaqueteField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoPaqueteField, value) != true)) {
                    this.TipoPaqueteField = value;
                    this.RaisePropertyChanged("TipoPaquete");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoNegocioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeNegocioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoNegocio {
            get {
                return this.CodigoNegocioField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoNegocioField, value) != true)) {
                    this.CodigoNegocioField = value;
                    this.RaisePropertyChanged("CodigoNegocio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeNegocio {
            get {
                return this.MensajeNegocioField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeNegocioField, value) != true)) {
                    this.MensajeNegocioField = value;
                    this.RaisePropertyChanged("MensajeNegocio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reserva", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Reserva : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAPServicesTest.TourWS.Cliente ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAPServicesTest.TourWS.Paquete PaqueteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAPServicesTest.TourWS.Cliente Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodReserva {
            get {
                return this.CodReservaField;
            }
            set {
                if ((this.CodReservaField.Equals(value) != true)) {
                    this.CodReservaField = value;
                    this.RaisePropertyChanged("CodReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaReserva {
            get {
                return this.FechaReservaField;
            }
            set {
                if ((this.FechaReservaField.Equals(value) != true)) {
                    this.FechaReservaField = value;
                    this.RaisePropertyChanged("FechaReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAPServicesTest.TourWS.Paquete Paquete {
            get {
                return this.PaqueteField;
            }
            set {
                if ((object.ReferenceEquals(this.PaqueteField, value) != true)) {
                    this.PaqueteField = value;
                    this.RaisePropertyChanged("Paquete");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TourWS.ITourService")]
    public interface ITourService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ObtenerTipoPaquete", ReplyAction="http://tempuri.org/ITourService/ObtenerTipoPaqueteResponse")]
        SOAPServicesTest.TourWS.TipoPaquete ObtenerTipoPaquete(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ListarTiposPaquete", ReplyAction="http://tempuri.org/ITourService/ListarTiposPaqueteResponse")]
        System.Collections.Generic.List<SOAPServicesTest.TourWS.TipoPaquete> ListarTiposPaquete();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ObtenerAgente", ReplyAction="http://tempuri.org/ITourService/ObtenerAgenteResponse")]
        SOAPServicesTest.TourWS.Agente ObtenerAgente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ListarAgentes", ReplyAction="http://tempuri.org/ITourService/ListarAgentesResponse")]
        System.Collections.Generic.List<SOAPServicesTest.TourWS.Agente> ListarAgentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ObtenerCliente", ReplyAction="http://tempuri.org/ITourService/ObtenerClienteResponse")]
        SOAPServicesTest.TourWS.Cliente ObtenerCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ListarClientes", ReplyAction="http://tempuri.org/ITourService/ListarClientesResponse")]
        System.Collections.Generic.List<SOAPServicesTest.TourWS.Cliente> ListarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/CrearPaquete", ReplyAction="http://tempuri.org/ITourService/CrearPaqueteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAPServicesTest.TourWS.Error), Action="http://tempuri.org/ITourService/CrearPaqueteErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
        SOAPServicesTest.TourWS.Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, System.DateTime fechaInicio, System.DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, decimal precio, int cupos, int registrados, int agente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ObtenerPaquete", ReplyAction="http://tempuri.org/ITourService/ObtenerPaqueteResponse")]
        SOAPServicesTest.TourWS.Paquete ObtenerPaquete(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ModificarPaquete", ReplyAction="http://tempuri.org/ITourService/ModificarPaqueteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAPServicesTest.TourWS.Error), Action="http://tempuri.org/ITourService/ModificarPaqueteErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
        SOAPServicesTest.TourWS.Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, System.DateTime fechaInicio, System.DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, decimal precio, int cupos, int registrados, int agente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ListarPaquetes", ReplyAction="http://tempuri.org/ITourService/ListarPaquetesResponse")]
        System.Collections.Generic.List<SOAPServicesTest.TourWS.Paquete> ListarPaquetes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/EliminarPaquete", ReplyAction="http://tempuri.org/ITourService/EliminarPaqueteResponse")]
        void EliminarPaquete(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/CrearReserva", ReplyAction="http://tempuri.org/ITourService/CrearReservaResponse")]
        SOAPServicesTest.TourWS.Reserva CrearReserva(int codPaquete, int codCliente, string Estado, System.DateTime FechaReserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ObtenerReserva", ReplyAction="http://tempuri.org/ITourService/ObtenerReservaResponse")]
        SOAPServicesTest.TourWS.Reserva ObtenerReserva(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ModificarReserva", ReplyAction="http://tempuri.org/ITourService/ModificarReservaResponse")]
        SOAPServicesTest.TourWS.Reserva ModificarReserva(int codigo, int codPaquete, int codCliente, string Estado, System.DateTime FechaReserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/EliminarReserva", ReplyAction="http://tempuri.org/ITourService/EliminarReservaResponse")]
        void EliminarReserva(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITourService/ListarReservas", ReplyAction="http://tempuri.org/ITourService/ListarReservasResponse")]
        System.Collections.Generic.List<SOAPServicesTest.TourWS.Reserva> ListarReservas();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITourServiceChannel : SOAPServicesTest.TourWS.ITourService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TourServiceClient : System.ServiceModel.ClientBase<SOAPServicesTest.TourWS.ITourService>, SOAPServicesTest.TourWS.ITourService {
        
        public TourServiceClient() {
        }
        
        public TourServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TourServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TourServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServicesTest.TourWS.TipoPaquete ObtenerTipoPaquete(int codigo) {
            return base.Channel.ObtenerTipoPaquete(codigo);
        }
        
        public System.Collections.Generic.List<SOAPServicesTest.TourWS.TipoPaquete> ListarTiposPaquete() {
            return base.Channel.ListarTiposPaquete();
        }
        
        public SOAPServicesTest.TourWS.Agente ObtenerAgente(int codigo) {
            return base.Channel.ObtenerAgente(codigo);
        }
        
        public System.Collections.Generic.List<SOAPServicesTest.TourWS.Agente> ListarAgentes() {
            return base.Channel.ListarAgentes();
        }
        
        public SOAPServicesTest.TourWS.Cliente ObtenerCliente(int codigo) {
            return base.Channel.ObtenerCliente(codigo);
        }
        
        public System.Collections.Generic.List<SOAPServicesTest.TourWS.Cliente> ListarClientes() {
            return base.Channel.ListarClientes();
        }
        
        public SOAPServicesTest.TourWS.Paquete CrearPaquete(int tipoPaquete, string nombrePaquete, System.DateTime fechaInicio, System.DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, decimal precio, int cupos, int registrados, int agente) {
            return base.Channel.CrearPaquete(tipoPaquete, nombrePaquete, fechaInicio, fechaFin, horaInicio, horaFin, descripcion, lugares, informacionAdicional, precio, cupos, registrados, agente);
        }
        
        public SOAPServicesTest.TourWS.Paquete ObtenerPaquete(int codigo) {
            return base.Channel.ObtenerPaquete(codigo);
        }
        
        public SOAPServicesTest.TourWS.Paquete ModificarPaquete(int codigo, int tipoPaquete, string nombrePaquete, System.DateTime fechaInicio, System.DateTime fechaFin, int horaInicio, int horaFin, string descripcion, string lugares, string informacionAdicional, decimal precio, int cupos, int registrados, int agente) {
            return base.Channel.ModificarPaquete(codigo, tipoPaquete, nombrePaquete, fechaInicio, fechaFin, horaInicio, horaFin, descripcion, lugares, informacionAdicional, precio, cupos, registrados, agente);
        }
        
        public System.Collections.Generic.List<SOAPServicesTest.TourWS.Paquete> ListarPaquetes() {
            return base.Channel.ListarPaquetes();
        }
        
        public void EliminarPaquete(int codigo) {
            base.Channel.EliminarPaquete(codigo);
        }
        
        public SOAPServicesTest.TourWS.Reserva CrearReserva(int codPaquete, int codCliente, string Estado, System.DateTime FechaReserva) {
            return base.Channel.CrearReserva(codPaquete, codCliente, Estado, FechaReserva);
        }
        
        public SOAPServicesTest.TourWS.Reserva ObtenerReserva(int codigo) {
            return base.Channel.ObtenerReserva(codigo);
        }
        
        public SOAPServicesTest.TourWS.Reserva ModificarReserva(int codigo, int codPaquete, int codCliente, string Estado, System.DateTime FechaReserva) {
            return base.Channel.ModificarReserva(codigo, codPaquete, codCliente, Estado, FechaReserva);
        }
        
        public void EliminarReserva(int codigo) {
            base.Channel.EliminarReserva(codigo);
        }
        
        public System.Collections.Generic.List<SOAPServicesTest.TourWS.Reserva> ListarReservas() {
            return base.Channel.ListarReservas();
        }
    }
}
