create database factoria_f5
go

use factoria_f5
go


create table Imagenes(
	Id bigint not null primary key identity(1,1),
	Titulo varchar(200) not null,
	Directorio varchar (300) not null,
	Estado bit default 1
)
go

insert into Imagenes(Titulo, Directorio)
values ('Test1', 'placeholder_01.jpg')
insert into Imagenes(Titulo, Directorio)
values ('Test2', 'placeholder_02.png')
insert into Imagenes(Titulo, Directorio, Estado)
values ('Test3', 'logo.png', 0)
go


create procedure listar(
	@estado bit
)
as
begin 
	select 
		i.Id,
		i.Titulo,
		i.Directorio
	from Imagenes i
	where i.Estado = @estado
end
go

create procedure guardar(
	@Titulo varchar(200),
	@Directorio varchar(300)
)
as
begin
	insert into Imagenes (Titulo, Directorio)
	values (@Titulo, @Directorio)
end
go

create procedure eliminarLogico(
	@Id bigint
)
as
begin
	update Imagenes 
	set Estado = 0
	where Id = @Id
end
go

create procedure cargar(
	@Id bigint
)
as
begin 
	select 
		i.Titulo,
		i.Directorio
	from Imagenes i
	where i.Id = @Id
end
go

create procedure modificar(
	@Id bigint,
	@Titulo varchar(200)

)
as
begin
	update Imagenes
	set Titulo = @Titulo
	where Id = @Id
end
go

create procedure restaurar(
	@Id bigint
)
as
begin
	update Imagenes
	set Estado = 1
	where Id = @Id
end
go

create procedure eliminarFisico
as
begin
	delete from Imagenes
	where Estado = 0
end
go

