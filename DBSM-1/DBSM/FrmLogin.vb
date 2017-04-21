Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Validar() Then
            Call Login()
        End If
    End Sub

    Private Sub Login()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            cnn.Open()
            Using cmd As New SqlCommand

                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = TxtUserName.Text
                    .Parameters.Add("@Pass", SqlDbType.NVarChar, 30).Value = TxtPassword.Text
                End With
                Dim reader As SqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    Dim Estado As Integer
                    Estado = reader.GetValue(3).ToString

                    If Estado = 1 Then
                        FrmPrincipal.TssIdUsuario.Text = reader.GetValue(0).ToString
                        FrmPrincipal.TssUsuario.Text = reader.GetValue(1).ToString
                        If reader.GetValue(5).ToString = 1 Then
                            FrmPrincipal.Show()
                        Else
                            FrmPrincipal.BtnEquipo.Enabled = False
                            FrmPrincipal.BtnAP.Enabled = False
                            FrmPrincipal.BtnAC.Enabled = False
                            FrmPrincipal.UsuariosToolStripMenuItem.Enabled = False
                            FrmPrincipal.BuscarUsuarioToolStripMenuItem.Enabled = False
                            FrmPrincipal.Show()
                        End If
                        Me.Close()
                    Else
                            MsgBox("Este usuario está inactivo.")

                    End If

                Else
                        MsgBox("Usuario o Contrasena invalido")
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtUserName.Text = Nothing And TxtPassword.Text = Nothing Then
            MessageBox.Show("Ingrese todos los datos.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtUserName.Focus()
            estado = False
        ElseIf TxtUserName.Text = Nothing Then
            MessageBox.Show("Ingrese el ususario.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtUserName.Focus()
            estado = False
        ElseIf TxtPassword.Text = Nothing Then
            MessageBox.Show("Ingrese la contraseña.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPassword.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function



    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        TxtPassword.Focus()
        TxtPassword.Text = ""
        TxtPassword.PasswordChar = "*"

    End Sub


    Private Sub TxtUserName_Click(sender As Object, e As EventArgs) Handles TxtUserName.Click
        TxtUserName.Focus()
        TxtUserName.Text = ""

    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlVer.MouseMove
        TxtPassword.PasswordChar = ""
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles PnlVer.MouseLeave
        TxtPassword.PasswordChar = "*"
    End Sub

    Private Sub TxtUserName_TextChanged(sender As Object, e As EventArgs) Handles TxtUserName.TextChanged
        PnlVer.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
