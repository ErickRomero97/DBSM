﻿Imports System.Data.SqlClient
Public Class FrmEquipo
    Private Sub FrmEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        LlenarComboTipoM()
        LLenarComboTeclado()
        LLenarComboMouse()
        LlenarComboTipoPC()
        LlenarComboMarca()
        LLenarComboAsignacionCompu()
        Limpiar()
        MostrarEquipo()
    End Sub
    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMarca.SelectedIndexChanged
        CboModelo.Enabled = True
        LlenarComboModelo()
        CboModelo.SelectedIndex = -1
    End Sub

    Private Sub chkVertodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVerTodo.CheckedChanged
        If ChkVerTodo.CheckState = CheckState.Checked Then
            Height = 633
            CenterToScreen()
        Else
            Height = 487
            CenterToScreen()
        End If
    End Sub

    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        PlCom.Enabled = Panel
    End Sub

    Sub Limpiar()
        TxtNumMaquina.Text = ""
        TxtSerieCompu.Text = ""
        TxtDescPro.Text = ""
        CboModelo.SelectedIndex = -1
        CboMouse.SelectedIndex = -1
        CboTeclado.SelectedIndex = -1
        TxtCapDisco.Text = ""
        TxtCapRAM.Text = ""
        TxtRevoDisco.Text = ""
        CboEstadoA.SelectedIndex = -1
        CboTipoMonitor.SelectedIndex = -1
        CboTipoPC.SelectedIndex = -1
        CboMarca.SelectedIndex = -1
        TxtSerieMonitor.Text = ""
        CboModelo.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        TxtSerieCompu.Focus()
        ChkVerTodo.Checked = False
        ChkVerTodo.Enabled = False
        Limpiar()
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(TxtSerieCompu, "El número de la serie de la computadora es requerido") Then
        ElseIf Validar(CboMarca, "Seleccione una marca") Then
        ElseIf Validar(CboModelo, "Seleccione un modelo") Then
        ElseIf Validar(CboTeclado, "Seleccione el estado del teclado") Then
        ElseIf Validar(CboMouse, "Seleccones el estado del mouse") Then
        ElseIf Validar(TxtSerieMonitor, "el numero de la serie del monitor es requerido") Then
        ElseIf Validar(TxtCapRAM, " la capacidad de RAM es requerida") Then
        ElseIf Validar(TxtCapDisco, "la capacidad de Disco Duro es requerida") Then
        ElseIf Validar(CboTipoPC, "Seleccione el tipo de PC") Then
        ElseIf Validar(TxtDescPro, "la descripcion del procesador es requerida") Then
        ElseIf Validar(CboTipoMonitor, "Seleccione el tipo de monitor") Then
        ElseIf Validar(CboEstadoA, "Seleccione el estado de asignacion de la computadora") Then
        ElseIf Validar(TxtRevoDisco, "las revoluciones del disco son requeridas") Then
        Else
            AgregarEquipo()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
            ChkVerTodo.Enabled = True
            MostrarEquipo()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(TxtSerieCompu, "El número de la serie de la computadora es requerido") Then
        ElseIf Validar(CboMarca, "Seleccione una marca") Then
        ElseIf Validar(CboModelo, "Seleccione un modelo") Then
        ElseIf Validar(CboTeclado, "Seleccione el estado del teclado") Then
        ElseIf Validar(CboMouse, "Seleccones el estado del mouse") Then
        ElseIf Validar(TxtSerieMonitor, "el numero de la serie del monitor es requerido") Then
        ElseIf Validar(TxtCapRAM, " la capacidad de RAM es requerida") Then
        ElseIf Validar(TxtCapDisco, "la capacidad de Disco Duro es requerida") Then
        ElseIf Validar(CboTipoPC, "Seleccione el tipo de PC") Then
        ElseIf Validar(TxtDescPro, "la descripcion del procesador es requerida") Then
        ElseIf Validar(CboTipoMonitor, "Seleccione el tipo de monitor") Then
        ElseIf Validar(CboEstadoA, "Seleccione el estado de asignacion de la computadora") Then
        ElseIf Validar(TxtRevoDisco, "las revoluciones del disco son requeridas") Then
        Else
            ActualizarEquipo()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
            MostrarEquipo()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        ChkVerTodo.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        MostrarEquipo()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumMaquina.Text = LsvEquipo.FocusedItem.SubItems(0).Text
        TxtSerieCompu.Text = LsvEquipo.FocusedItem.SubItems(1).Text
        TxtCapRAM.Text = LsvEquipo.FocusedItem.SubItems(7).Text
        TxtCapDisco.Text = LsvEquipo.FocusedItem.SubItems(8).Text
        TxtDescPro.Text = LsvEquipo.FocusedItem.SubItems(9).Text
        TxtRevoDisco.Text = LsvEquipo.FocusedItem.SubItems(11).Text
        TxtSerieMonitor.Text = LsvEquipo.FocusedItem.SubItems(13).Text
        HabilitarBotones(False, False, True, True, True)
    End Sub


    Public Sub LlenarComboTipoM()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboboxTipoMonitor"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoMonitor")
                Me.CboTipoMonitor.DataSource = ds.Tables(0)
                Me.CboTipoMonitor.DisplayMember = ds.Tables(0).Columns("Monitor").ToString
                Me.CboTipoMonitor.ValueMember = ds.Tables(0).Columns("IdTipoMonitor").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Sub LLenarComboMouse()
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

        CboMouse.DataSource = dt
        CboMouse.ValueMember = "Valor"
        CboMouse.DisplayMember = "Descripcion"
    End Sub

    Sub LLenarComboTeclado()
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

        CboTeclado.DataSource = dt
        CboTeclado.ValueMember = "Valor"
        CboTeclado.DisplayMember = "Descripcion"
    End Sub

    Sub LLenarComboAsignacionCompu()
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

        CboEstadoA.DataSource = dt
        CboEstadoA.ValueMember = "Valor"
        CboEstadoA.DisplayMember = "Descripcion"
    End Sub

    Private Sub LlenarComboTipoPC()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboboxTipoPC"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoPC")
                Me.CboTipoPC.DataSource = ds.Tables(0)
                Me.CboTipoPC.DisplayMember = ds.Tables(0).Columns("TipoPC").ToString
                Me.CboTipoPC.ValueMember = ds.Tables(0).Columns("IdTipoPC").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub


    Public Sub LlenarComboMarca()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboboxMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Marca")
                Me.CboMarca.DataSource = ds.Tables(0)
                Me.CboMarca.DisplayMember = ds.Tables(0).Columns("Marca").ToString
                Me.CboMarca.ValueMember = ds.Tables(0).Columns("IdMarca").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

    Public Sub LlenarComboModelo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboboxModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CboMarca.SelectedValue
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                Me.CboModelo.DataSource = ds.Tables(0)
                Me.CboModelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                Me.CboModelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString
            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub

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
                'LsvEquipo.Items.Clear()

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
                        .SubItems.Add(VerEquipo("IdMarca").ToString)
                        .SubItems.Add(VerEquipo("IdModelo").ToString)
                        .SubItems.Add(VerEquipo("IdTipoMonitor").ToString)
                        .SubItems.Add(VerEquipo("IdTipoPC").ToString)

                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub AgregarEquipo()

        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertarComputadora"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@SerieComputadora", SqlDbType.NVarChar, 50).Value = TxtSerieCompu.Text.Trim
                        .Parameters.Add("@CapRam", SqlDbType.Int).Value = TxtCapRAM.Text.Trim
                        .Parameters.Add("@CapDisco", SqlDbType.Int).Value = TxtCapDisco.Text.Trim
                        .Parameters.Add("@RevolucionesDisco", SqlDbType.NVarChar, 20).Value = TxtRevoDisco.Text.Trim
                        .Parameters.Add("@Mouse", SqlDbType.Int).Value = CboMouse.SelectedValue
                        .Parameters.Add("@Teclado", SqlDbType.Int).Value = CboTeclado.SelectedValue
                        .Parameters.Add("@DescripcionProcesador", SqlDbType.NVarChar, 50).Value = TxtDescPro.Text.Trim
                        .Parameters.Add("@SerieMonitor", SqlDbType.NVarChar, 50).Value = TxtSerieMonitor.Text.Trim
                        .Parameters.Add("@EstadoAsignacion", SqlDbType.Int).Value = CboEstadoA.SelectedValue
                        .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CboModelo.SelectedValue
                        .Parameters.Add("@IdTipoMonitor", SqlDbType.Int).Value = CboTipoMonitor.SelectedValue
                        .Parameters.Add("@IdTipoPC", SqlDbType.Int).Value = CboTipoPC.SelectedValue
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 2
                        '.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(MDIPrincipal.lblID.Text)
                        .Connection = cnn
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de equipo ha sido guardado", "DBSM", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub ActualizarEquipo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = TxtNumMaquina.Text.Trim
                    .Parameters.Add("@SerieComputadora", SqlDbType.NVarChar, 50).Value = TxtSerieCompu.Text.Trim
                    .Parameters.Add("@CapRam", SqlDbType.Int).Value = TxtCapRAM.Text.Trim
                    .Parameters.Add("@CapDisco", SqlDbType.Int).Value = TxtCapDisco.Text.Trim
                    .Parameters.Add("@RevolucionesDisco", SqlDbType.NVarChar, 20).Value = TxtRevoDisco.Text.Trim
                    .Parameters.Add("@Mouse", SqlDbType.Int).Value = CboMouse.SelectedValue
                    .Parameters.Add("@Teclado", SqlDbType.Int).Value = CboTeclado.SelectedValue
                    .Parameters.Add("@DescripcionProcesador", SqlDbType.NVarChar, 50).Value = TxtDescPro.Text.Trim
                    .Parameters.Add(" @SerieMonitor", SqlDbType.NVarChar, 50).Value = TxtSerieMonitor.Text.Trim
                    .Parameters.Add("@EstadoAsignacion", SqlDbType.Int).Value = CboEstadoA.SelectedValue
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CboModelo.SelectedValue
                    .Parameters.Add("@IdTipoMonitor", SqlDbType.Int).Value = CboTipoMonitor.SelectedValue
                    .Parameters.Add("@IdTipoPC", SqlDbType.Int).Value = CboTipoPC.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 2
                    '.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(MDIPrincipal.lblID.Text)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de computadora fue actualizado", "DBSM", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave ya existente") Then
                MessageBox.Show("Ya se encuentra registrada esta computadora", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Eliminar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = LsvEquipo.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la computadora ha sido eliminado", "DBSM", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Sub InvestigarCorrelativo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarEquipo As New SqlCommand("Sp_MostrarComputadoraIdentity", cnn)
            ListarEquipo.CommandType = CommandType.StoredProcedure
            Dim ListarEquipos As SqlDataReader
            cnn.Open()
            ListarEquipos = ListarEquipo.ExecuteReader
            If ListarEquipos.Read = True Then
                If ListarEquipos("Id") Is DBNull.Value Then
                    TxtNumMaquina.Text = 1
                Else
                    TxtNumMaquina.Text = ListarEquipos("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function ExisteRegistro() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "SP_ExisteEquipo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@SerieComputadora", SqlDbType.NVarChar, 50).Value = TxtSerieCompu.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado esta computadora", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "DBSM", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

    Private Sub btnIrMarca_Click(sender As Object, e As EventArgs) Handles BtnIrMarca.Click
        Me.Hide()
        Marca.Show()
        Marca.regreso = 1
    End Sub

    Private Sub btnIrModelo_Click(sender As Object, e As EventArgs) Handles btnIrModelo.Click
        Me.Hide()
        FrmModelo.Show()
        FrmModelo.regreso = 1
    End Sub
End Class