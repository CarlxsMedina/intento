--create database DBLogin
create table Usuarios (
	id_usuario int primary key identity,
	usuario varchar(50),
	contraseña varchar(50),
	cargo varchar(50)
)

--se insertan los primeros valores como prueba
insert into Usuarios values ('josue', 'josue123', 'administrador')