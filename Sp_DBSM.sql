

Create Procedure Sp_Login
@UserName nvarchar(50),
@Pass nvarchar(30)
As
Begin
	Set nocount on
	Select IdUsuario, UserName, Contrase�a
	From Usuario
	where UserName = @UserName And Contrase�a = @Pass
End
