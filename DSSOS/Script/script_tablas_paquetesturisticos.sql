create database bdPaquetesTuristicos
go
use bdPaquetesTuristicos
go 
create table Cliente
(
  CodCliente int primary key identity(1,1),
  NombreCliente varchar(100) not null,  
  ApellidoCliente varchar(100) not null,  
  DNI varchar(20) not null,
  CorreoCliente  varchar(100) not null
)
go
create table Agente
(
  CodAgente int primary key identity(1,1),
  RazonSocial varchar(100) not null,  
  RUC varchar(20) not null,
  CorreoAgente varchar(100) not null,
  Direccion varchar(100) not null,
  NroCuentaInterbancaria varchar(20) not null
)
go
create table TipoPaquete
(
  CodTipoPaquete int primary key identity(1,1),
  NombreTipoPaquete varchar(100) not null
)
create table Paquete
(
    CodPaquete int primary key identity(1,1),
    NombrePaquete varchar(100) not null,
	FechaInicio datetime not null,
	FechaFin datetime not null,
	HoraInicio int not null,
	HoraFin int not null,
	Descripcion varchar(1000) not null,
	Lugares varchar(250) not null,
	InformacionAdicional varchar(1000) not null,
	Precio float not null,
	Cupos  int not null,
	Registrados int not null,
	CodAgente int not null,
    CodTipoPaquete int not null
)
go
alter table Paquete
add constraint fk_CodAgente
foreign key(CodAgente) references Agente(CodAgente)
go
alter table Paquete
add constraint fk_CodTipoPaquete
foreign key(CodTipoPaquete) references TipoPaquete(CodTipoPaquete)
go
create table Reserva
(
   CodReserva int primary key identity(1,1),
   Estado char(1) not null, --R: reservado, C: confirmado
   FechaReserva datetime not null,  
   CodPaquete int not null,
   CodCliente int not null
)
go
alter table Reserva
add constraint fk_CodPaquete
foreign key(CodPaquete) references Paquete(CodPaquete)
go
alter table Reserva
add constraint fk_CodCliente
foreign key(CodCliente) references Cliente(CodCliente)
go