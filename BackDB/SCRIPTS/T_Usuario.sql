use Bolsa;
create table usuarios(
id_usuario int primary key identity (1,1) not null,
nombre_usuario varchar(40) not null,
clave varchar(40) not null,
nombre varchar(40) not null,
apellido varchar(40) not null,
email varchar(40) not null,
habilitado bit not null,
)