insert into Tipopaquete (NombreTipoPaquete) values ('Full Day') 
insert into Tipopaquete (NombreTipoPaquete) values ('Excursiones')
go
insert into Agente (RazonSocial,RUC, CorreoAgente, Direccion, NroCuentaInterbancaria ) 
values ('Viajes Falabella', '10098273099', 'informes@viajesfalabella.com', 'Av primavera 2263', '123456789123')
go
insert into Cliente (NombreCliente, ApellidoCliente, DNI,CorreoCliente ) values ('Julio', 'Vilca','09827309', 'julio.vilca@gmail.com'  )
go
insert into Paquete (codTipoPaquete,NombrePaquete, FechaInicio, FechaFin, 
HoraInicio, HoraFin,Descripcion, Lugares, InformacionAdicional,Precio, Cupos, Registrados, codAgente) 
values (1, 'Full Day Caral', '20121120','20121125', 8, 20, 'Viva la Aventura del Canotaje full day Lunahuana',
        'Lunahuana', 'Informes agenciaifc@hotmail.com teléfonos 451-8567, 451-8568', 40.5, 10, 0, 1 )
go
-- R Reservado
-- C Confirmado
insert into Reserva (CodPaquete, CodCliente, Estado, FechaReserva)values(1,1,'R', '20121209')