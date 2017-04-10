
Imports System.Data.SqlClient
Public Class FrmAsignacionComputadoraA
    Private Sub FrmAsignacionComputadoraA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        Call LlenarCboNumComputadora()
        Call LlenarCboIdAlumno()
        Call Limpiar()
        Call Mostrar()
    End Sub

    Private Sub LlenarCboNumComputadora()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Computadora")
                Me.CboCompu.DataSource = ds.Tables(0)
                Me.CboCompu.DisplayMember = ds.Tables(0).Columns("NumComputadora").ToString
                Me.CboCompu.ValueMember = ds.Tables(0).Columns("NumComputadora").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub
    Private Sub LlenarCboIdAlumno()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LLenarComboAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Alumno")
                Me.CboAlumno.DataSource = ds.Tables(0)
                Me.CboAlumno.DisplayMember = ds.Tables(0).Columns("IdAlumno").ToString
                Me.CboAlumno.ValueMember = ds.Tables(0).Columns("IdAlumno").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub
    Private Sub chkVertodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVertodo.CheckedChanged
        If ChkVertodo.CheckState = CheckState.Checked Then
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
        PlACA.Enabled = Panel
    End Sub

    Sub Limpiar()
        CboAlumno.SelectedIndex = -1
        CboCompu.SelectedIndex = -1
        TxtAsignacioC.Text = ""
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        CboCompu.Focus()
        ChkVertodo.Checked = False
        ChkVertodo.Enabled = False
        Limpiar()
    End Sub
    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "DBSM", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(CboCompu, "Debe Selecionar el codigo de una computadora") Then
        ElseIf Validar(CboAlumno, "Seleccione el codigo de un alumno") Then
        ElseIf Validar(DtpFechaA, "Debe ingresar la fecha de la asignacion de la computadora") Then
        ElseIf Validar(TxtAsignacioC, "ingrese el estado en que se entrego la computadora") Then
        Else
            Agregar()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
            ChkVertodo.Enabled = True
            Mostrar()
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(CboCompu, "Debe Selecionar el codigo de una computadora") Then
        ElseIf Validar(CboAlumno, "Seleccione el codigo de un alumno") Then
        ElseIf Validar(DtpFechaA, "Debe ingresar la fecha de la asignacion de la computadora") Then
        ElseIf Validar(TxtAsignacioC, "ingrese el estado en que se entrego la computadora") Then
        Else
            Actualizar()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
            Mostrar()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        ChkVertodo.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        Mostrar()
        HabilitarBotones(True, False, False, False, False)
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        CboCompu.Text = LsvAsignacionCA.FocusedItem.SubItems(0).Text
        CboAlumno.Text = LsvAsignacionCA.FocusedItem.SubItems(1).Text

        TxtAsignacioC.Text = LsvAsignacionCA.FocusedItem.SubItems(4).Text
        HabilitarBotones(False, False, True, True, True)
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
                LsvAsignacionCA.Items.Clear()

                While VerEquipo.Read = True
                    With Me.LsvAsignacionCA.Items.Add(VerEquipo("NumComputadora").ToString)
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
    Private Sub Agregar()

        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertarAsignacionCA"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = CboCompu.SelectedValue
                        .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = CboAlumno.SelectedValue
                        .Parameters.Add("@FechaAsignacion", SqlDbType.Date).Value = DtpFechaA.Value
                        .Parameters.Add("@FechaEntrega", SqlDbType.Date).Value = DtpFechaE.Value
                        .Parameters.Add("@EstadoEntrega", SqlDbType.NVarChar, 150).Value = TxtAsignacioC.Text.Trim
                        .Connection = cnn
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro de la asignacion de la computadora ha sido guardado con exito", "DBSM", MessageBoxButtons.OK)
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub Actualizar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarAsignacionCA"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = CboCompu.SelectedValue
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = CboAlumno.SelectedValue
                    .Parameters.Add("@FechaAsignacion", SqlDbType.Date).Value = DtpFechaA.Value
                    .Parameters.Add("@FechaEntrega", SqlDbType.Date).Value = DtpFechaE.Value
                    .Parameters.Add("@EstadoEntrega", SqlDbType.NVarChar, 150).Value = TxtAsignacioC.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la asignacion de computadora fue actualizado", "DBSM", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave ya existente") Then
                MessageBox.Show("Ya se encuentra registrada esta asignacion computadora", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    .CommandText = "Sp_EliminarAsignacionCA"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumComputadora", SqlDbType.Int).Value = LsvAsignacionCA.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la asignacion  computadora ha sido eliminado", "DBSM", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
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
                    .CommandText = "SP_ExisteAsignacionCA"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 10).Value = CboAlumno.SelectedValue
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrada esta asignacion de  computadora", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function
End Class