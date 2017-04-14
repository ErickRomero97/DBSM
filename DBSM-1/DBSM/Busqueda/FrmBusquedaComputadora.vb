Imports System.Data.SqlClient
Public Class FrmBusquedaComputadora
    Private Sub MostrarEquipo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoEquipo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerEquipo As SqlDataReader
                VerEquipo = cmd.ExecuteReader()
                LsvEquipo.Items.Clear()

                While VerEquipo.Read = True
                    With Me.LsvEquipo.Items.Add(VerEquipo("NumComputadora").ToString)
                        .SubItems.Add(VerEquipo("SerieComputadora").ToString)
                        .SubItems.Add(VerEquipo("Marca").ToString)
                        .SubItems.Add(VerEquipo("Modelo").ToString)
                        If Convert.ToBoolean(VerEquipo("Mouse")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If
                        If Convert.ToBoolean(VerEquipo("Teclado")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If

                        .SubItems.Add(VerEquipo("Monitor").ToString)
                        .SubItems.Add(VerEquipo("Capram").ToString)
                        .SubItems.Add(VerEquipo("CapDisco").ToString)
                        .SubItems.Add(VerEquipo("DescripcionProcesador").ToString)
                        .SubItems.Add(VerEquipo("TipoPC").ToString)
                        .SubItems.Add(VerEquipo("RevolucionesDisco").ToString)
                        If Convert.ToBoolean(VerEquipo("EstadoAsignacion")) = True Then
                            .SubItems.Add("Si")
                        Else
                            .SubItems.Add("No")
                        End If
                        .SubItems.Add(VerEquipo("SerieComputadora").ToString)


                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub
    Private Sub MostrarEquipoxMaquina()
        If ExisteEquipoNumMaquina() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarTodoEquipoBusqueda"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerEquipo As SqlDataReader
                    VerEquipo = cmd.ExecuteReader()
                    LsvEquipo.Items.Clear()

                    While VerEquipo.Read = True
                        With Me.LsvEquipo.Items.Add(VerEquipo("NumComputadora").ToString)
                            .SubItems.Add(VerEquipo("SerieComputadora").ToString)
                            .SubItems.Add(VerEquipo("Marca").ToString)
                            .SubItems.Add(VerEquipo("Modelo").ToString)
                            .SubItems.Add(VerEquipo("Mouse").ToString)
                            .SubItems.Add(VerEquipo("Teclado").ToString)
                            .SubItems.Add(VerEquipo("Monitor").ToString)
                            .SubItems.Add(VerEquipo("Capram").ToString)
                            .SubItems.Add(VerEquipo("CapDisco").ToString)
                            .SubItems.Add(VerEquipo("DescripcionProcesador").ToString)
                            .SubItems.Add(VerEquipo("TipoPC").ToString)
                            .SubItems.Add(VerEquipo("RevolucionesDisco").ToString)
                            .SubItems.Add(VerEquipo("EstadoAsignacion").ToString)
                            .SubItems.Add(VerEquipo("SerieComputadora").ToString)
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

    Private Sub MostrarEquipoxSerie()
        If ExisteEquipoSerie() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarTodoEquipoBusquedaSerie"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@SerieComputadora", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerEquipo As SqlDataReader
                    VerEquipo = cmd.ExecuteReader()
                    LsvEquipo.Items.Clear()

                    While VerEquipo.Read = True
                        With Me.LsvEquipo.Items.Add(VerEquipo("NumComputadora").ToString)
                            .SubItems.Add(VerEquipo("SerieComputadora").ToString)
                            .SubItems.Add(VerEquipo("Marca").ToString)
                            .SubItems.Add(VerEquipo("Modelo").ToString)
                            .SubItems.Add(VerEquipo("Mouse").ToString)
                            .SubItems.Add(VerEquipo("Teclado").ToString)
                            .SubItems.Add(VerEquipo("Monitor").ToString)
                            .SubItems.Add(VerEquipo("Capram").ToString)
                            .SubItems.Add(VerEquipo("CapDisco").ToString)
                            .SubItems.Add(VerEquipo("DescripcionProcesador").ToString)
                            .SubItems.Add(VerEquipo("TipoPC").ToString)
                            .SubItems.Add(VerEquipo("RevolucionesDisco").ToString)
                            .SubItems.Add(VerEquipo("EstadoAsignacion").ToString)
                            .SubItems.Add(VerEquipo("SerieComputadora").ToString)
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

    Private Sub BuscarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBuscar.Enabled = False
        BtnBuscar.Enabled = False
        RdoNumMaquina.Checked = False
        RdoSerieCom.Checked = False
        MostrarEquipo()
    End Sub

    Private Sub rdoMaquina_CheckedChanged(sender As Object, e As EventArgs) Handles RdoNumMaquina.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub rdoSerie_CheckedChanged(sender As Object, e As EventArgs) Handles RdoSerieCom.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoNumMaquina.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El número de maquina de la computadora es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarEquipoxMaquina()
                TxtBuscar.Focus()
            End If
        End If

        If RdoSerieCom.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El número de serie de la Compuatadora es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarEquipoxSerie()
                TxtBuscar.Focus()
            End If
        End If
    End Sub


    Private Function ExisteEquipoSerie() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "SP_ExisteEquipoBusqueda"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@SerieComputadora", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvEquipo.Items.Clear()
                    MessageBox.Show("No existe ninguna computadora con esa serie", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function ExisteEquipoNumMaquina() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "SP_ExisteEquipoXNumMaquinaBusqueda"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvEquipo.Items.Clear()
                    MessageBox.Show("No existe ninguna computadora con ese numero", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            MostrarEquipo()
        End If
    End Sub
End Class