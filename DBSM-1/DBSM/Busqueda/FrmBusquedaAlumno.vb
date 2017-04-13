Imports System.Data.SqlClient
Public Class FrmBusquedaAlumno
    Private Sub MostrarAlumno()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarAlumnos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerAlumno As SqlDataReader
                VerAlumno = cmd.ExecuteReader()
                lsbAlumno.Items.Clear()
                While VerAlumno.Read = True
                    With Me.lsbAlumno.Items.Add(VerAlumno("IdAlumno").ToString)
                        .SubItems.Add(VerAlumno("Nombre").ToString)
                        .SubItems.Add(VerAlumno("Apellido").ToString)
                        .SubItems.Add(VerAlumno("Direccion").ToString)
                        .SubItems.Add(VerAlumno("Telefono").ToString)
                        .SubItems.Add(VerAlumno("Correo").ToString)
                        .SubItems.Add(VerAlumno("Sexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub BusquedaAlumno()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_BusquedaIdAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Alumno", SqlDbType.NVarChar).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With
                Dim VerAlumno As SqlDataReader
                VerAlumno = cmd.ExecuteReader()
                lsbAlumno.Items.Clear()
                While VerAlumno.Read = True
                    With Me.lsbAlumno.Items.Add(VerAlumno("IdAlumno").ToString)
                        .SubItems.Add(VerAlumno("Nombre").ToString)
                        .SubItems.Add(VerAlumno("Apellido").ToString)
                        .SubItems.Add(VerAlumno("Direccion").ToString)
                        .SubItems.Add(VerAlumno("Telefono").ToString)
                        .SubItems.Add(VerAlumno("Correo").ToString)
                        .SubItems.Add(VerAlumno("Sexo").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using


    End Sub



    Private Sub FrmBusquedaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAlumno()
    End Sub



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtBuscar.Text = "" Then
            MostrarAlumno()
            MessageBox.Show("El Nombre o Codigo del Alumno es Necesario parala Busqueda", "DBSM", MessageBoxButtons.OK)
            TxtBuscar.Focus()
        Else
            BusquedaAlumno()
            TxtBuscar.Focus()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            MostrarAlumno()
        End If
    End Sub
End Class