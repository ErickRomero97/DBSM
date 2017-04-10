Imports System.Data.SqlClient
Public Class FrmBuscarAsignacionPrograma
    Private Sub FrmBuscarAsignacionPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarAsignacion()
    End Sub

    Private Sub MostrarAsignacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_MostrarAsignacionPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarAsignacion As SqlDataReader
                MostrarAsignacion = cmd.ExecuteReader
                LsvAsignacion.Items.Clear()

                While MostrarAsignacion.Read = True
                    With LsvAsignacion.Items.Add(MostrarAsignacion("IdSoftware").ToString)
                        If (MostrarAsignacion("EstadoLicencia")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If
                        .SubItems.Add(MostrarAsignacion("NumLicencia").ToString)
                        .SubItems.Add(MostrarAsignacion("FechaAdquisicion").ToString)
                        .SubItems.Add(MostrarAsignacion("FechaVencimineto").ToString)
                        .SubItems.Add(MostrarAsignacion("NumComputadora").ToString)
                        .SubItems.Add(MostrarAsignacion("Programa").ToString)
                        .SubItems.Add(MostrarAsignacion("FechaInstalacionSoftware").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los programas." + ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarXPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarAsignacionXPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Programa", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarDatos As SqlDataReader
                MostrarDatos = cmd.ExecuteReader
                LsvAsignacion.Items.Clear()

                While MostrarDatos.Read = True
                    With LsvAsignacion.Items.Add(MostrarDatos("IdSoftware").ToString)
                        If (MostrarDatos("EstadoLicencia")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If
                        .SubItems.Add(MostrarDatos("NumLicencia").ToString)
                        .SubItems.Add(MostrarDatos("FechaAdquisicion").ToString)
                        .SubItems.Add(MostrarDatos("FechaVencimineto").ToString)
                        .SubItems.Add(MostrarDatos("NumComputadora").ToString)
                        .SubItems.Add(MostrarDatos("Programa").ToString)
                        .SubItems.Add(MostrarDatos("FechaInstalacionSoftware").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarXNumComputadora()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarAsignacionXComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtBuscar.Text
                    .Connection = cnn
                End With

                Dim MostrarDatos As SqlDataReader
                MostrarDatos = cmd.ExecuteReader
                LsvAsignacion.Items.Clear()

                While MostrarDatos.Read = True
                    With LsvAsignacion.Items.Add(MostrarDatos("IdSoftware").ToString)
                        If (MostrarDatos("EstadoLicencia")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If
                        .SubItems.Add(MostrarDatos("NumLicencia").ToString)
                        .SubItems.Add(MostrarDatos("FechaAdquisicion").ToString)
                        .SubItems.Add(MostrarDatos("FechaVencimineto").ToString)
                        .SubItems.Add(MostrarDatos("NumComputadora").ToString)
                        .SubItems.Add(MostrarDatos("Programa").ToString)
                        .SubItems.Add(MostrarDatos("FechaInstalacionSoftware").ToString)
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
            If RdbPrograma.Checked = True Then
                Call BuscarXPrograma()
            ElseIf RdbNumComputadora.Checked = True Then
                Call BuscarXNumComputadora()
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = Nothing Then
            Call MostrarAsignacion()
        End If
    End Sub
End Class