
use DBSM


--***************************Login*********************
alter Procedure Sp_Login
@UserName nvarchar(50),
@Pass nvarchar(30)
As
Begin
	Set nocount on
	Select *
	From Usuario 
	where UserName = @UserName And Contraseña = @Pass
End
select * from estado

-- ***************************Empleado************************
Create procedure Sp_MostrarDatos
as
	begin
	set nocount on 
	Select E.IdEmpleado, E.Nombre,  E.Apellido, E.Direccion,E.Telefono,E.Correo, S.Sexo
	From Empleado E inner join Sexo S on E.IdSexo = S.IdSexo
end

Create Procedure Sp_InsertEmpleado
@IdEmpleado nvarchar(15),
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Direccion nvarchar(300),
@Telefono nvarchar(10),
@Correo nvarchar(60),
@Sexo int
As
	Begin
	Set Nocount On
	Insert into Empleado
	Values(@IdEmpleado,@Nombre,@Apellido,@Direccion,@Telefono,@Correo,@Sexo)
End

Create Procedure Sp_UpdateEmpleado
@IdEmpleado nvarchar(15),
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Direccion nvarchar(300),
@Telefono nvarchar(10),
@Correo nvarchar(60),
@Sexo int
As
	Begin
	Set Nocount On
	Update Empleado set Nombre=@Nombre, Apellido=@Apellido, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, IdSexo=@Sexo
	Where IdEmpleado = @IdEmpleado
End

Create Procedure Sp_DeleteEmpleado
@IdEmpleado nvarchar(15)
As
	Begin
	Set nocount on
	Delete from Empleado Where IdEmpleado = @IdEmpleado
End

Create Procedure Sp_LlenarComboSexo
As
	Begin 
		set nocount on 
		select IdSexo ,Sexo
		From Sexo 
		order by Sexo asc	
	End
GO



create procedure Sp_ExisteEmpleado
@IdEmpleado nvarchar(15)
as
	Begin
		Set nocount on 
		Select count(*)
		from Empleado
		where IdEmpleado=@IdEmpleado
	End 
GO


-- ***********************Busqueda Empleado********************
Create procedure Sp_BuscarXNombre
@Nombre nvarchar(30)
as
	begin
	set nocount on 
	Select E.IdEmpleado, E.Nombre,  E.Apellido, E.Direccion,E.Telefono,E.Correo, S.Sexo
	From Empleado E inner join Sexo S on E.IdSexo = S.IdSexo
	where Nombre = @Nombre
end

Create procedure Sp_BuscarXId
@IdEmpleado nvarchar(15)
as
	begin
	set nocount on 
	Select E.IdEmpleado, E.Nombre,  E.Apellido, E.Direccion,E.Telefono,E.Correo, S.Sexo
	From Empleado E inner join Sexo S on E.IdSexo = S.IdSexo
	where IdEmpleado = @IdEmpleado
end

--********************Usuario**********************

Create Procedure Sp_MostrarUsuario
As
	Begin
	Set nocount on
	Select U.IdUsuario, U.UserName, U.Contraseña, E.Estado, EM.IdEmpleado, TU.Usuario
	From Usuario U inner join Estado E on U.IdEstado = E.IdEstado
				   inner join Empleado EM on U.IdEmpleado = EM.IdEmpleado
				   inner join TipoUsuario TU on U.IdTipoUsuario = TU.IdTipoUsuario
End

Create Procedure Sp_LlenarComboEstado
As
	Begin 
		set nocount on 
		select IdEStado , Estado
		From Estado 
		order by Estado asc	
	End
GO

Create Procedure Sp_LlenarComboTipoUsuario
As
	Begin 
		set nocount on 
		select IdTipoUsuario , Usuario
		From TipoUsuario 
		order by Usuario asc	
	End
GO

Create procedure Sp_MostrarIdUsuarioIdentity
as
	Begin 
		Set nocount on
		Select max(IdUsuario) + 1 as Id
		from Usuario
	End
GO

Create Procedure Sp_InsertUsuario
@Username nvarchar(50),
@Contraseña nvarchar(30),
@IdEstado int,
@IdEmpleado nvarchar(15),
@IdTipoUsuario int
As 
	Begin
	Set nocount on
	Insert into Usuario
	Values(@Username,@Contraseña,@IdEstado,@IdEmpleado,@IdTipoUsuario)
End

Create Procedure Sp_UpdateUsuario
@IdUsuario int,
@Username nvarchar(50),
@Contraseña nvarchar(30),
@IdEstado int,
@IdEmpleado nvarchar(15),
@IdTipoUsuario int
As 
	Begin
	Set nocount on
	Update Usuario set UserName = @Username, Contraseña = @Contraseña, IdEstado = @IdEstado, IdEmpleado = @IdEmpleado, IdTipoUsuario = @IdTipoUsuario
	Where IdUsuario = @IdUsuario
End

create procedure Sp_ExisteUsuario
@Usuario nvarchar(50)
as
	Begin
		Set nocount on 
		Select count(*)
		from Usuario
		where UserName=@Usuario
	End 
GO

--***************************Busqueda Usuario***********************

Create Procedure Sp_BuscarUsuarioXNombre
@Nombre nvarchar(50)
As
	Begin
	Set nocount on
	Select U.IdUsuario, U.UserName, U.Contraseña, E.Estado, EM.IdEmpleado, TU.Usuario
	From Usuario U inner join Estado E on U.IdEstado = E.IdEstado
				   inner join Empleado EM on U.IdEmpleado = EM.IdEmpleado
				   inner join TipoUsuario TU on U.IdTipoUsuario = TU.IdTipoUsuario
	Where UserName = @Nombre
End

Create Procedure Sp_BuscarUsuarioXId
@Id Int
As
	Begin
	Set nocount on
	Select U.IdUsuario, U.UserName, U.Contraseña, E.Estado, EM.IdEmpleado, TU.Usuario
	From Usuario U inner join Estado E on U.IdEstado = E.IdEstado
				   inner join Empleado EM on U.IdEmpleado = EM.IdEmpleado
				   inner join TipoUsuario TU on U.IdTipoUsuario = TU.IdTipoUsuario
	Where IdUsuario = @Id
End



--******************Programa**************


Create procedure Sp_MostrarIdProgramaIdentity
as
	Begin 
		Set nocount on
		Select max(IdPrograma) + 1 as Id
		from Programa
	End
GO

Create procedure Sp_ExistePrograma
@Nombre nvarchar(50)
as
	Begin
		Set nocount on 
		Select count(*)
		from Programa
		where Programa=@Nombre
End 

Create Procedure Sp_LlenarComboTipoPrograma
As
	Begin 
		set nocount on 
		select IdTipoPrograma , TipoPrograma
		From TipoPrograma
		order by TipoPrograma asc	
	End
GO

Create Procedure Sp_UpdatePrograma
@IdPrograma int,
@Nombre nvarchar(50),
@Descripcion nvarchar(100),
@TipoPrograma int
As 
	Begin
	Set nocount on
	Update Programa set Programa = @Nombre, Descripsion=@Descripcion, IdTipoPrograma=@TipoPrograma
	Where IdPrograma =@IdPrograma
End


Create Procedure Sp_MostrarProgramas
As
	Begin
	Set nocount on
	Select P.IdPrograma, P.Programa, P.Descripsion, TP.TipoPrograma
	From Programa P inner join TipoPrograma TP on P.IdTipoPrograma = TP.IdTipoPrograma
End

--*****************Busqueda Programa**********************

Create Procedure Sp_BuscarProgramaXNombre
@Programa nvarchar(50)
As
	Begin
	Set nocount on
	Select P.IdPrograma, P.Programa, P.Descripsion, TP.TipoPrograma
	From Programa P inner join TipoPrograma TP on P.IdTipoPrograma = TP.IdTipoPrograma
	Where P.Programa = @Programa
End

Create Procedure Sp_BuscarProgramaXId
@IdPrograma int
As
	Begin
	Set nocount on
	Select P.IdPrograma, P.Programa, P.Descripsion, TP.TipoPrograma
	From Programa P inner join TipoPrograma TP on P.IdTipoPrograma = TP.IdTipoPrograma
	Where P.IdPrograma = @IdPrograma
End

--*******************Asignacion Programa**************

Create procedure Sp_MostrarIdAsignacionProgramaIdentity
as
	Begin 
		Set nocount on
		Select max(IdSoftware) + 1 as Id
		from AsignacionPrograma
	End
GO

Create procedure Sp_MostrarNumComputadoraPrograma
as
	Begin 
		Set nocount on
		Select NumComputadora
		from Computadora
		order by NumComputadora asc
	End
GO

Create Procedure Sp_LlenarComboPrograma
As
	Begin 
		set nocount on 
		select IdPrograma , Programa
		From Programa
		order by Programa asc	
	End
GO

Create Procedure Sp_MostrarAsignacionPrograma
As
	Begin
	Set nocount on
	Select A.IdSoftware, A.EstadoLicencia, A.NumLicencia, A.FechaAdquisicion, A.FechaVencimineto, A.NumComputadora, P.Programa, A.FechaInstalacionSoftware
	From AsignacionPrograma A inner Join Programa P on A.IdPrograma = P.IdPrograma
End


Create Procedure Sp_InsertAsignacionPrograma
@EstadoLicencia bit,
@NumLicencia nvarchar(30),
@FechaAdquisicion date,
@FechaVencimiento date,
@NumComputadora int,
@IdPrograma int,
@FechaInstalacionSoftware date,
@IdUsuario int
As 
	Begin
	Set nocount on
	Insert into AsignacionPrograma values(@EstadoLicencia,@NumLicencia,@FechaAdquisicion,@FechaVencimiento,@NumComputadora,@IdPrograma,@FechaInstalacionSoftware,@IdUsuario)
End

Create Procedure Sp_UpdateAsignacionPrograma
@IdSoftware int,
@EstadoLicencia bit,
@NumLicencia nvarchar(30),
@FechaAdquisicion date,
@FechaVencimiento date,
@NumComputadora int,
@IdPrograma int,
@FechaInstalacionSoftware date,
@IdUsuario int
As 
	Begin
	Set nocount on
	Update AsignacionPrograma Set EstadoLicencia=@EstadoLicencia, NumLicencia = @NumLicencia, FechaAdquisicion=@FechaAdquisicion,FechaVencimineto=@FechaVencimiento,NumComputadora=@NumComputadora,IdPrograma=@IdPrograma,FechaInstalacionSoftware=@FechaInstalacionSoftware,IdUsuario=@IdUsuario
	Where IdSoftware=@IdSoftware
End

Create procedure Sp_ExisteAsignacion
@NumComputadora int,
@IdPrograma int
as
	Begin
		Set nocount on 
		Select count(*)
		from AsignacionPrograma
		where NumComputadora=@NumComputadora and IdPrograma= @IdPrograma
End 

Create Procedure Sp_DeleteAsignacion
@IdSoftware int
As
	Begin
	Set nocount on
	Delete from AsignacionPrograma Where IdSoftware = @IdSoftware
End

Select * From Usuario
Select * From AsignacionPRograma

--***************************Busqueda Asignacion de Programa*********************

Create Procedure Sp_BuscarAsignacionXPrograma
@Programa nvarchar(50)
As
	Begin
	Set nocount on
	Select A.IdSoftware, A.EstadoLicencia, A.NumLicencia, A.FechaAdquisicion, A.FechaVencimineto, A.NumComputadora, P.Programa, A.FechaInstalacionSoftware
	From AsignacionPrograma A inner Join Programa P on A.IdPrograma = P.IdPrograma
	Where Programa = @Programa
End

Create Procedure Sp_BuscarAsignacionXComputadora
@NumComputadora int
As
	Begin
	Set nocount on
	Select A.IdSoftware, A.EstadoLicencia, A.NumLicencia, A.FechaAdquisicion, A.FechaVencimineto, A.NumComputadora, P.Programa, A.FechaInstalacionSoftware
	From AsignacionPrograma A inner Join Programa P on A.IdPrograma = P.IdPrograma
	Where NumComputadora = @NumComputadora
End
use DBSM
--Procedimientos Almacenados de la Relacion Marca
create procedure Sp_ActualizarMarca
@IdMarca int , @Marca nvarchar(50)
as 
	begin 
	set nocount on
	update Marca set Marca=@Marca where IdMarca=@IdMarca
end 


create procedure Sp_EliminarMarca
@IdMarca int
as 
	begin 
	set nocount on
	delete from Marca where idMarca=@IdMarca
end 


create  procedure  Sp_ExisteMarca
@Marca nvarchar(50)
as
	Begin 
		set nocount on
		select count(*) from Marca where Marca=@Marca
End


create Procedure Sp_InsertarMarca
@Marca nvarchar(50)
as 
	begin
		set nocount on
		insert into Marca values(@Marca)
end 


create procedure Sp_MostrarMarca
as 
	begin 
		set nocount on
		select * from Marca
end 


create Procedure Sp_MostrarMarcaIdentity
as
	begin 
	set nocount on
		select max(IdMarca) +1 AS Id from Marca
End


CREATE procedure Sp_MostrarXNombreMarca
@Marca nvarchar (50)
as 
	Begin
		Set nocount on 
		Select * from Marca Where Marca = @Marca
End

create  procedure Sp_ExisteMarca1
@Marca nvarchar(50)
as
	Begin 
		set nocount on
		select count(*) from Marca where Marca=@Marca
End


create procedure Sp_ExisteMarcaXCodigo
@IdMarca int
as
	Begin
		Set nocount on 
		Select count(*) from Marca where IdMarca=@IdMarca 
End

create  procedure  Sp_ExisteMarcaXNombre
@Marca nvarchar(50)
as
	Begin 
		set nocount on
		select count(*) from Marca where Marca = @Marca
End

create procedure Sp_MostrarxMarca
@IdMarca int 
as 
	Begin
		Set nocount on 
		Select * from Marca Where IdMarca=@IdMarca
End


--Procedimientos Almacenado de la relacion Modelo
create procedure Sp_LlenarComboboxMarca
as
	Begin
		Set nocount on
		Select IdMarca, Marca from Marca order by Marca Asc
End

create procedure Sp_MostrarTodoModeloInner 
as 
	begin 
		set nocount on
		select a.IdModelo,a.Modelo,b.Marca
		from modelo a inner join marca b on a.idmarca=b.idmarca
end 

create procedure Sp_InsertarModelo
 @Modelo nvarchar(50), @IdMarca int
 as
	Begin 
		Set nocount on 
		Insert into Modelo values(@Modelo,@IdMarca)
End

create procedure Sp_ActualizarModelo
@IdModelo int, @Modelo nvarchar(50), @IdMarca int
as	
	Begin 
		Set nocount on 
		Update Modelo set Modelo = @Modelo, IdMarca = @IdMarca where IdModelo=@IdModelo
End

create procedure Sp_EliminarModelo
@IdModelo int
As
	Begin 
		Set nocount on
		Delete from Modelo where IdModelo=@IdModelo
End

create procedure Sp_MostrarModeloIdentity
as
	Begin
		Set nocount on
		Select max(IdModelo) + 1 as Id From Modelo
End

create  procedure Sp_ExisteModelo
@Modelo nvarchar(50)
as
	Begin 
		set nocount on
		select count(*) from Modelo where Modelo=@Modelo
End

CREATE procedure Sp_MostrarModeloXCodigo
@IdModelo int
as 
	Begin
		Set nocount on 
		Select a.IdModelo,a.Modelo,b.Marca 
		from Modelo a inner join Marca b on a.IdMarca = b.IdMarca 
		Where IdModelo=@IdModelo
End

CREATE procedure Sp_MostrarModeloXNombre
@Modelo nvarchar(50)
as 
	Begin
		Set nocount on 
		Select a.IdModelo,a.Modelo, b.Marca 
		from Modelo a inner join Marca b on a.IdMarca = b.IdMarca 
		Where Modelo like @Modelo + '%'
End
select * from modelo

CREATE  procedure Sp_ExisteModeloXCodigo
@IdModelo int
as
	Begin 
		set nocount on
		select count(*) from Modelo
		where IdModelo=@IdModelo 
End

--insercion de TipoPC
Insert into TipoPc(TipoPC)
values ('Escritorio'),
	   ('Personal')

--insercion de TipoMonitor
Insert into TipoMonitor(Monitor)
values ('CRT'),
	   ('LCD')

-- Procedimientos almacenados de Computadora
create procedure Sp_LlenarComboboxTipoMonitor
as
	Begin
		Set nocount on
		Select * from TipoMonitor Order by IdTipoMonitor Asc
End

create procedure Sp_LlenarComboboxTipoPC
as
	Begin
		Set nocount on 
		Select * from TipoPC Order by TipoPC Asc
End

create procedure Sp_LlenarComboModelo
@IdMarca int
as
	Begin
		Set nocount on 
		Select * from Modelo where IdMarca=@IdMarca order by IdModelo asc 
End

create procedure Sp_MostrarTodoEquipo
as
	Begin 
	set nocount on
	Select e.NumComputadora, e.SerieComputadora, ma.Marca, m.Modelo, e.Mouse, e.Teclado, tm.Monitor, 
		   e.capram, e.capdisco, e.DescripcionProcesador,tp.TipoPC, e.RevolucionesDisco, 
		   e.EstadoAsignacion, e.SerieComputadora
	from Computadora e inner join Modelo m on e.IdModelo=m.IdModelo
				       inner join TipoMonitor tm on e.IdTipoMonitor = tm.IdTipoMonitor
		               inner join TipoPC tp on e.IdTipoPC = tp.IdTipoPC
		               inner join Marca ma on ma.IdMarca = m.IdMarca 
End
select * from Computadora
create procedure Sp_InsertarComputadora
@SerieComputadora nvarchar(50), @IdUsuario int, @Idmodelo int,  @Mouse bit,  @Teclado bit, @IdTipoMonitor int,  @CapRam int ,  @CapDisco int, 
@DescripcionProcesador nvarchar(50), @IdTipoPC int, @RevolucionesDisco nvarchar(20), @SerieMonitor nvarchar(50), @EstadoAsignacion bit
as
	Begin 
		Set nocount on 
		Insert into Computadora
		values(@SerieComputadora,@CapRam,@CapDisco, @RevolucionesDisco ,@Mouse,@Teclado, @DescripcionProcesador ,
				 @SerieMonitor, @EstadoAsignacion, @Idmodelo, @IdTipoMonitor, @IdTipoPC, @IdUsuario)
End


CREATE procedure Sp_ActualizarComputadora
@NumComputadora int ,@SerieComputadora nvarchar(50), @IdUsuario int, @Idmodelo int,  @Mouse bit,  @Teclado bit, @IdTipoMonitor int,  @CapRam int ,  @CapDisco int, 
@DescripcionProcesador nvarchar(50), @IdTipoPC int, @RevolucionesDisco nvarchar(20), @SerieMonitor nvarchar(50), @EstadoAsignacion bit
as	
	Begin 
		Set nocount on 
		Update Computadora
		set SerieComputadora=@SerieComputadora,CapRam=@CapRam,CapDisco=@CapDisco, RevolucionesDisco=@RevolucionesDisco ,
		Mouse=@Mouse,Teclado=@Teclado, DescripcionProcesador=@DescripcionProcesador ,SerieMonitor=@SerieMonitor, 
		EstadoAsignacion=@EstadoAsignacion, Idmodelo=@Idmodelo, IdTipoMonitor=@IdTipoMonitor, IdTipoPC=@IdTipoPC, IdUsuario= @IdUsuario
		where NumComputadora=@NumComputadora
End

create procedure Sp_EliminarComputadora
@NumComputadora int
As
	Begin 
		Set nocount on
		Delete from Computadora where NumComputadora=@NumComputadora
End

create procedure Sp_MostrarComputadoraIdentity
as
	Begin
		Set nocount on
		Select max(NumComputadora) + 1 as Id From Computadora
End

create  Procedure SP_ExisteEquipo
@SerieComputadora nvarchar(50)
as
	begin 
		set nocount on
		select count(*) from Computadora
		where SerieComputadora  = @SerieComputadora 
End

-- Insercion Sexo
Insert into Sexo(Sexo)
values ('Masculino'),
	   ('Femenino')

-- Insercion Estado
Insert into Estado(Estado)
values ('Activo'),
	   ('Desactivo')

-- Insercion TipoUsuario
Insert into TipoUsuario(Usuario)
values ('SuperUsuario'),
	   ('Usuario'),
	   ('Usuario Normal'),
	   ('Usuario Administrador')

	   
select * from sexo
select * from empleado
select * from estado

insert into Empleado values ('1709-1997-01153','walter','cruz','b° la cruz',87876247,'walter@gmail.com',1)
select * from Usuario
insert into Usuario values('WalterCruz','Walter100',1,'1709-1997-01153',1)

--Procedimientos Almacenados Busqueda de Computadora
create procedure Sp_MostrarTodoEquipoBusqueda
@NumComputadora int 
as
	Begin 
	set nocount on
	Select e.NumComputadora, e.SerieComputadora, ma.Marca, m.Modelo, e.Mouse, e.Teclado, tm.Monitor, 
		   e.capram, e.capdisco, e.DescripcionProcesador,tp.TipoPC, e.RevolucionesDisco, 
		   e.EstadoAsignacion, e.SerieComputadora
	from Computadora e inner join Modelo m on e.IdModelo=m.IdModelo
				       inner join TipoMonitor tm on e.IdTipoMonitor = tm.IdTipoMonitor
		               inner join TipoPC tp on e.IdTipoPC = tp.IdTipoPC
		               inner join Marca ma on ma.IdMarca = m.IdMarca where NumComputadora=@NumComputadora
End

create procedure Sp_MostrarTodoEquipoBusquedaSerie
@SerieComputadora nvarchar(50) 
as
	Begin 
	set nocount on
	Select e.NumComputadora, e.SerieComputadora, ma.Marca, m.Modelo, e.Mouse, e.Teclado, tm.Monitor, 
		   e.capram, e.capdisco, e.DescripcionProcesador,tp.TipoPC, e.RevolucionesDisco, 
		   e.EstadoAsignacion, e.SerieComputadora
	from Computadora e inner join Modelo m on e.IdModelo=m.IdModelo
				       inner join TipoMonitor tm on e.IdTipoMonitor = tm.IdTipoMonitor
		               inner join TipoPC tp on e.IdTipoPC = tp.IdTipoPC
		               inner join Marca ma on ma.IdMarca = m.IdMarca where SerieComputadora=@SerieComputadora
End

create  Procedure SP_ExisteEquipoBusqueda
@SerieComputadora  nvarchar(50)
as
	begin 
		set nocount on
		select count(*) from Computadora  where SerieComputadora  = @SerieComputadora  
End

create  Procedure SP_ExisteEquipoXNumMaquinaBusqueda
@NumComputadora int
as
	begin 
		set nocount on
		select count(*)
		from Computadora
		where NumComputadora  = @NumComputadora
End




--Procedimientos almacenados asignacioncomputadora

create procedure Sp_LLenarComboComputadora
as
	Begin
	Set nocount on 
		select NumComputadora
		from Computadora
		order by Numcomputadora Asc
End

create procedure Sp_LLenarComboAlumno
as
	Begin
	Set nocount on 
		select IdAlumno
		from Alumno
		order by IdAlumno Asc
End


create procedure Sp_LlenarComboboxAlumno
as
	Begin
		Set nocount on 
		Select * from Alumno Order by Nombre
End

select * from Computadora

select * from alumno
insert into Alumno values ('1709-1998-01153','Alcides','cruz','b° la cruz',99436804,'walteraca97@gmail.com',1)

create procedure Sp_MostrarTodoAsignacionCA
as
	Begin 
	set nocount on
		Select *
		from AsignacionComputadora
End

Create procedure Sp_InsertarAsignacionCA
@NumComputadora int, @IdAlumno nvarchar(15), @FechaAsignacion date ,  @FechaEntrega date,  @EstadoEntrega nvarchar(150)
as
	Begin 
		Set nocount on 
		Insert into AsignacionComputadora
		values(@NumComputadora, @IdAlumno , @FechaAsignacion ,  @FechaEntrega,  @EstadoEntrega)
End


CREATE procedure Sp_ActualizarAsignacionCA
@NumComputadora int, @IdAlumno nvarchar(15), @FechaAsignacion date ,  @FechaEntrega date,  @EstadoEntrega nvarchar(150)
as	
	Begin 
		Set nocount on 
		Update AsignacionComputadora
		set NumComputadora=@NumComputadora, IdAlumno=@IdAlumno, FechaAsigancion=@FechaAsignacion ,  FechaEntrega=@FechaEntrega,  EstadoEntrega=@EstadoEntrega
		where NumComputadora=@NumComputadora
End

create procedure Sp_EliminarAsignacionCA
@NumComputadora int
As
	Begin 
		Set nocount on
		Delete from AsignacionComputadora where NumComputadora=@NumComputadora
End

create  Procedure SP_ExisteAsignacionCA
@IdAlumno nvarchar(15)
as
	begin 
		set nocount on
		select count(*) from AsignacionComputadora
		where IdAlumno  = @IdAlumno
End


create procedure Sp_ExisteAsignacionCompu
@NumComputadora int
as
	Begin
		Set nocount on 
		Select count(*) from AsignacionComputadora where NumComputadora=@NumComputadora
End

create  procedure  Sp_ExisteAsignacionA
@IdAlumno nvarchar(15)
as
	Begin 
		set nocount on
		select count(*) from AsignacionComputadora where IdAlumno = @IdAlumno
End

Create procedure Sp_MostrarxIdAlumno
@IdAlumno nvarchar(15)
as 
	Begin
		Set nocount on 
		Select * from AsignacionComputadora Where IdAlumno=@IdAlumno
End

Create procedure Sp_MostrarxNumComputadora
@NumComputadora int
as 
	Begin
		Set nocount on 
		Select * from AsignacionComputadora Where NumComputadora=@NumComputadora
End


