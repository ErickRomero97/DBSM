Imports System.Data.SqlClient
Public Class FrmBuscarEmpleado
    Private Sub FrmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    .CommandText = "Sp_MostrarDatos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvDatosEmpleado.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvDatosEmpleado.Items.Add(MostrarEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleado("Nombre").ToString)
                        .SubItems.Add(MostrarEmpleado("Apellido").ToString)
                        .SubItems.Add(MostrarEmpleado("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleado("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleado("Correo").ToString)
                        .SubItems.Add(MostrarEmpleado("Sexo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar las empleado" + ex.Message)
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
                    .CommandText = "Sp_BuscarXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvDatosEmpleado.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvDatosEmpleado.Items.Add(MostrarEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleado("Nombre").ToString)
                        .SubItems.Add(MostrarEmpleado("Apellido").ToString)
                        .SubItems.Add(MostrarEmpleado("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleado("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleado("Correo").ToString)
                        .SubItems.Add(MostrarEmpleado("Sexo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarXId()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarXId"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvDatosEmpleado.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvDatosEmpleado.Items.Add(MostrarEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleado("Nombre").ToString)
                        .SubItems.Add(MostrarEmpleado("Apellido").ToString)
                        .SubItems.Add(MostrarEmpleado("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleado("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleado("Correo").ToString)
                        .SubItems.Add(MostrarEmpleado("Sexo").ToString)
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Validar() Then
            If RdbNombre.Checked = True Then
                Call BuscarXNombre()
            ElseIf RdbIdentidad.Checked = True Then
                Call BuscarXId()
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = Nothing Then
            Call MostrarTodo()
        End If
    End Sub


    Private Sub LsvDatosEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles LsvDatosEmpleado.DoubleClick
        FrmUsuarios.MtbIdEmpleado.Text = LsvDatosEmpleado.FocusedItem.SubItems(0).Text
        Me.Close()
    End Sub
End Class