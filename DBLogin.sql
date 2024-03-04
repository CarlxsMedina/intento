--create database DBLogin
create table Usuarios (
	id_usuario int primary key identity,
	usuario varchar(50),
	contraseña varchar(50),
	cargo varchar(50)
)


insert into Usuarios values ('carlos', 'carlos123', 'administrador'),
--se insertan los primeros valores como prueba
('josue', 'josue123', 'administrador')

