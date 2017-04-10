Imports System.Data.SqlClient
Public Class FrmBuscarUsuario
    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarTodo()
    End Sub

    Private Sub MostrarTodo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_MostrarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("IdEmpleado").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los usuarios" + ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarXNombre()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarUsuarioXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("IdEmpleado").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarUsuarioXId()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarUsuarioXId"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Id", SqlDbType.Int).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("IdEmpleado").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtBuscar.Text = Nothing Then
            MessageBox.Show("Ingrese un dato para buscar.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtBuscar.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = Nothing Then
            Call MostrarTodo()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Validar() Then
            If RdbNombre.Checked = True Then
                Call BuscarXNombre()
            ElseIf RdbId.Checked = True Then
                Call BuscarUsuarioXId()
            End If
        End If
    End Sub
End Class