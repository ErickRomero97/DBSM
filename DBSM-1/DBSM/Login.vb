Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Call Login()
    End Sub

    Private Sub Login()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            cnn.Open()
            Dim user As String = Replace(TxtUserName.Text, "'", "")
            Dim pass As String = (TxtPassword.Text)
            Using cmd As New SqlCommand

                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtUserName.Text
                    .Parameters.Add("@Pass", SqlDbType.NVarChar).Value = TxtPassword.Text
                End With
                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    FrmPrincipal.Show()
                Else
                    MsgBox("Usuario o Contrasena invalido")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
