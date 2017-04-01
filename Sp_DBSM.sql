

Create Procedure Sp_Login
@UserName nvarchar(50),
@Pass nvarchar(30)
As
Begin
	Set nocount on
	Select IdUsuario, UserName, Contraseña
	From Usuario
	where UserName = @UserName And Contraseña = @Pass
End
