--create database DBLogin
create table Usuarios (
	id_usuario int primary key identity,
	usuario varchar(50),
	contraseņa varchar(50),
	cargo varchar(50)
)