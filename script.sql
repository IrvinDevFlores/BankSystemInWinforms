CREATE database bankdb;

use bankdb;


create table Transacciones(
	TransaccionId int primary key identity(1,1),
                    ClienteId int ,
                    Saldo_Anterior decimal(9,2) not null,
                    Importe decimal(9,2) not null,
                    Saldo_Nuevo decimal(9,2) not null,
                    TipoOperacionId int,
                    EmpleadoId int,
                    Fecha_Transaccion datetime
)

create proc MostrarTablaTransaciones
as
select * from Transacciones
