Imports System.Data.SqlClient
Public Class FrmAsignacionPrograma

    Private Sub FrmAsignacionPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call LLenarComboEstadoLicencia()
        Call LlenarComboboxNumComputadora()
        Call LlenarComboboxPrograma()
        Call MostrarAsignacion()
        CboNumComputadora.Text = Nothing
        CboEstado.Text = Nothing
        CboPrograma.Text = Nothing
    End Sub

    Sub HabilitarControles(ByVal Agregar As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Agregar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlDatos.Enabled = Panel
    End Sub

    Private Sub Limpiar()
        TxtCodSoftware.Clear()
        CboEstado.SelectedItem = -1
        TxtNumLicencia.Clear()
        CboNumComputadora.SelectedItem = -1
        CboPrograma.SelectedItem = -1
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If chkVer.Checked = True Then
            Me.Height = 739
        Else
            Me.Height = 565
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call MostrarCodSofwareIdentity()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarControles(True, False, False, False, False)
        If Validar() Then
            If ExisteAsignacion() = False Then
                Call InsertarAsignacion()
            End If
            Call Limpiar()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call ActualizarAsignacion()
        Call Limpiar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub MostrarCodSofwareIdentity()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarCodSoftware As New SqlCommand("Sp_MostrarIdAsignacionProgramaIdentity")
            ListarCodSoftware.CommandType = CommandType.StoredProcedure
            ListarCodSoftware.Connection = cnn
            Dim Listarsofwares As SqlDataReader
            cnn.Open()
            Listarsofwares = ListarCodSoftware.ExecuteReader
            If Listarsofwares.Read = True Then
                If Listarsofwares("Id") Is DBNull.Value Then
                    TxtCodSoftware.Text = 1
                Else
                    TxtCodSoftware.Text = Listarsofwares("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LLenarComboEstadoLicencia()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Valor")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Valor") = "1"
        dr("Descripcion") = "Si"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Valor") = "0"
        dr("Descripcion") = "No"
        dt.Rows.Add(dr)

        CboEstado.DataSource = dt
        CboEstado.ValueMember = "Valor"
        CboEstado.DisplayMember = "Descripcion"
    End Sub

    Private Sub LlenarComboboxNumComputadora()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarNumComputadoraPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoPrograma")
                Me.CboNumComputadora.DataSource = ds.Tables(0)
                Me.CboNumComputadora.ValueMember = ds.Tables(0).Columns("NumComputadora").ToString
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al listar numero de computadora" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LlenarComboboxPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Programa")
                Me.CboPrograma.DataSource = ds.Tables(0)
                Me.CboPrograma.DisplayMember = ds.Tables(0).Columns("Programa").ToString
                Me.CboPrograma.ValueMember = ds.Tables(0).Columns("IdPrograma").ToString
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al listar estado" + ex.Message)
        Finally
            cnn.Close()
        End Try
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


    Private Function ExisteAsignacion() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteAsignacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = CboNumComputadora.SelectedValue
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CboPrograma.SelectedValue
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra asignado este programa.", "DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub InsertarAsignacion()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertAsignacionPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados

                    If CboEstado.Text = "Si" Then
                        .Parameters.Add("@EstadoLicencia", SqlDbType.Bit, 50).Value = 1
                    Else
                        .Parameters.Add("@EstadoLicencia", SqlDbType.Bit, 50).Value = 0
                    End If
                    .Parameters.Add("@NumLicencia", SqlDbType.NVarChar, 30).Value = Trim(TxtNumLicencia.Text)
                    .Parameters.Add("@FechaAdquisicion", SqlDbType.Date).Value = Trim(DtpFechaAdquisicion.Text)
                    .Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = Trim(DtpFechaVencimiento.Text)
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = Trim(CboNumComputadora.SelectedValue)
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = Trim(CboPrograma.SelectedValue)
                    .Parameters.Add("@FechaInstalacionSoftware", SqlDbType.Date).Value = Trim(DtpFechaInstalacion.Text)
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = FrmPrincipal.TssIdUsuario.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro se ha almacenado Satisfactoriamente", "DBMS")
                    Call MostrarAsignacion()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al almacenar el registro" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActualizarAsignacion()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_UpdateAsignacionPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados

                    If CboEstado.Text = "Si" Then
                        .Parameters.Add("@EstadoLicencia", SqlDbType.Bit, 50).Value = 1
                    Else
                        .Parameters.Add("@EstadoLicencia", SqlDbType.Bit, 50).Value = 0
                    End If
                    .Parameters.Add("IdSoftware", SqlDbType.Int).Value = Trim(TxtCodSoftware.Text)
                    .Parameters.Add("@NumLicencia", SqlDbType.NVarChar, 30).Value = Trim(TxtNumLicencia.Text)
                    .Parameters.Add("@FechaAdquisicion", SqlDbType.Date).Value = Trim(DtpFechaAdquisicion.Text)
                    .Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = Trim(DtpFechaVencimiento.Text)
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = Trim(CboNumComputadora.SelectedValue)
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = Trim(CboPrograma.SelectedValue)
                    .Parameters.Add("@FechaInstalacionSoftware", SqlDbType.Date).Value = Trim(DtpFechaInstalacion.Text)
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 1
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro se ha actualizado Satisfactoriamente", "DBMS")
                    Call MostrarAsignacion()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub EliminarAsignacion()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If


        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_DeleteAsignacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados

                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = LsvAsignacion.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("La asignacion ha sido eliminada Satisfactoriamente", "DBMS")
                    Call MostrarAsignacion()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro" + ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If CboEstado.Text = Nothing And TxtNumLicencia.Text = Nothing And CboNumComputadora.Text = Nothing And CboPrograma.Text = Nothing Then
            MessageBox.Show("Ingrese todos los datos.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboEstado.Focus()
            estado = False
        ElseIf CboEstado.Text = Nothing Then
            MessageBox.Show("Seleccione un estado.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboEstado.Focus()
            estado = False
        ElseIf TxtNumLicencia.Text = Nothing Then
            MessageBox.Show("Ingrese el número de licencia.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtNumLicencia.Focus()
            estado = False
        ElseIf CboNumComputadora.Text = Nothing Then
            MessageBox.Show("Seleccione una computadora.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboNumComputadora.Focus()
            estado = False
        ElseIf CboEstado.Text = Nothing Then
            MessageBox.Show("Seleccione un estado.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboEstado.Focus()
            estado = False
        ElseIf CboPrograma.Text = Nothing Then
            MessageBox.Show("Seleccione un programa.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboPrograma.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)

        TxtCodSoftware.Text = LsvAsignacion.FocusedItem.SubItems(0).Text
        CboEstado.Text = LsvAsignacion.FocusedItem.SubItems(1).Text
        TxtNumLicencia.Text = LsvAsignacion.FocusedItem.SubItems(2).Text
        DtpFechaAdquisicion.Text = LsvAsignacion.FocusedItem.SubItems(3).Text
        DtpFechaVencimiento.Text = LsvAsignacion.FocusedItem.SubItems(4).Text
        CboNumComputadora.Text = LsvAsignacion.FocusedItem.SubItems(5).Text
        CboPrograma.Text = LsvAsignacion.FocusedItem.SubItems(6).Text
        DtpFechaInstalacion.Text = LsvAsignacion.FocusedItem.SubItems(7).Text
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Call EliminarAsignacion()
    End Sub

    Private Sub BtnPrograma_Click(sender As Object, e As EventArgs) Handles BtnPrograma.Click
        FrmPrograma.ShowDialog()
    End Sub
End Class