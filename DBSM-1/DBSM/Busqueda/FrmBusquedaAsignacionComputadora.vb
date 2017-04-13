Imports System.Data.SqlClient
Public Class FrmBusquedaAsignacionComputadora
    Private Sub FrmBusquedaAsignacionComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Mostrar()
    End Sub
    Private Sub Mostrar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoAsignacionCA"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEquipo As SqlDataReader
                VerEquipo = cmd.ExecuteReader()
                LsvBusquedaCompuA.Items.Clear()

                While VerEquipo.Read = True
                    With Me.LsvBusquedaCompuA.Items.Add(VerEquipo("NumComputadora").ToString)
                        .SubItems.Add(VerEquipo("IdAlumno").ToString)
                        .SubItems.Add(VerEquipo("FechaAsigancion").ToString)
                        .SubItems.Add(VerEquipo("FechaEntrega").ToString)
                        .SubItems.Add(VerEquipo("EstadoEntrega").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub MostrarXIdAlumno()
        If ExisteAlumnoA() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarxIdAlumno"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerAsignacion As SqlDataReader
                    VerAsignacion = cmd.ExecuteReader()
                    LsvBusquedaCompuA.Items.Clear()
                    While VerAsignacion.Read = True
                        With Me.LsvBusquedaCompuA.Items.Add(VerAsignacion("NumComputadora").ToString)
                            .SubItems.Add(VerAsignacion("IdAlumno").ToString)
                            .SubItems.Add(VerAsignacion("FechaAsigancion").ToString)
                            .SubItems.Add(VerAsignacion("FechaEntrega").ToString)
                            .SubItems.Add(VerAsignacion("EstadoEntrega").ToString)
                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using

        End If
    End Sub

    Private Sub MostrarxNumComputadora()
        If ExisteComputadoraA() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarxNumComputadora"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim Ver As SqlDataReader
                    Ver = cmd.ExecuteReader()
                    LsvBusquedaCompuA.Items.Clear()
                    While Ver.Read = True
                        With Me.LsvBusquedaCompuA.Items.Add(Ver("NumComputadora").ToString)
                            .SubItems.Add(Ver("IdAlumno").ToString)
                            .SubItems.Add(Ver("FechaAsigancion").ToString)
                            .SubItems.Add(Ver("FechaEntrega").ToString)
                            .SubItems.Add(Ver("EstadoEntrega").ToString)
                        End With
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try
            End Using

        End If
    End Sub

    Private Function ExisteComputadoraA() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteAsignacionCompu"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvBusquedaCompuA.Items.Clear()
                    MessageBox.Show("No existe ninguna computadora asignada con ese codigo", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function ExisteAlumnoA() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteAsignacionA"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvBusquedaCompuA.Items.Clear()
                    MessageBox.Show("No existe ninguna computadora asignada con ese codigo de alumno", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Sub rdoCodMarca_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCodCompuA.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub rdoNombreMarca_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCodAlumnoA.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoCodCompuA.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El código de la computadora es requerido", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarxNumComputadora()
                TxtBuscar.Focus()
            End If
        End If

        If RdoCodAlumnoA.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El codigo del alumno es requerido", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarXIdAlumno()
                TxtBuscar.Focus()
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            Mostrar()
        End If
    End Sub
End Class