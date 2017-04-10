Imports System.Data.SqlClient
Public Class FrmPrograma
    Private Sub FrmPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarPrograma()
        Call LlenarComboboxTipoPrograma()
    End Sub

    Private Sub HabilitarControles(ByVal Agregar As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal GroupBox As Boolean)
        BtnNuevo.Enabled = Agregar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        GbPrograma.Enabled = GroupBox
    End Sub

    Private Sub Limpiar()
        TxtCodPrograma.Clear()
        TxtNombreMPrograma.Clear()
        TxtDescripcion.Clear()
        CboTipoPrograma.SelectedIndex = -1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)

        Call MostrarIdPrograma()

        Call LlenarComboboxTipoPrograma()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarControles(True, False, False, False, False)

        If Validar() Then
            If ExistePrograma() = False Then
                Call InsertarPrograma()
            End If

            Call Limpiar()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call ActualizarPrograma()
        Call Limpiar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub MostrarIdPrograma()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarPrograma As New SqlCommand("Sp_MostrarIdProgramaIdentity")
            ListarPrograma.CommandType = CommandType.StoredProcedure
            ListarPrograma.Connection = cnn
            Dim ListarProgramas As SqlDataReader
            cnn.Open()
            ListarProgramas = ListarPrograma.ExecuteReader
            If ListarProgramas.Read = True Then
                If ListarProgramas("Id") Is DBNull.Value Then
                    TxtCodPrograma.Text = 1
                Else
                    TxtCodPrograma.Text = ListarProgramas("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarComboboxTipoPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboTipoPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoPrograma")
                Me.CboTipoPrograma.DataSource = ds.Tables(0)
                Me.CboTipoPrograma.DisplayMember = ds.Tables(0).Columns("TipoPrograma").ToString
                Me.CboTipoPrograma.ValueMember = ds.Tables(0).Columns("IdTipoPrograma").ToString
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al listar estado" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub MostrarPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_MostrarProgramas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarPrograma As SqlDataReader
                MostrarPrograma = cmd.ExecuteReader
                LsvPrograma.Items.Clear()

                While MostrarPrograma.Read = True
                    With LsvPrograma.Items.Add(MostrarPrograma("IdPrograma").ToString)
                        .SubItems.Add(MostrarPrograma("Programa").ToString)
                        .SubItems.Add(MostrarPrograma("Descripsion").ToString)
                        .SubItems.Add(MostrarPrograma("TipoPrograma").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los programas." + ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Function ExistePrograma() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExistePrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombreMPrograma.Text
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este programa.", "DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub InsertarPrograma()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Trim(TxtNombreMPrograma.Text)
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = Trim(TxtDescripcion.Text)
                    .Parameters.Add("@TipoPrograma", SqlDbType.Int).Value = Trim(CboTipoPrograma.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro se ha almacenado Satisfactoriamente", "DBMS")
                    Call MostrarPrograma()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al almacenar el registro" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActualizarPrograma()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_UpdatePrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados
                    .Parameters.Add("IdPrograma", SqlDbType.Int).Value = Trim(TxtCodPrograma.Text)
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = Trim(TxtNombreMPrograma.Text)
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = Trim(TxtDescripcion.Text)
                    .Parameters.Add("@TipoPrograma", SqlDbType.Int).Value = Trim(CboTipoPrograma.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro se ha actualizado Satisfactoriamente", "DBMS")
                    Call MostrarPrograma()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean

        If TxtNombreMPrograma.Text = Nothing And TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese todos los valores.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtNombreMPrograma.Focus()
            Estado = False
        ElseIf TxtNombreMPrograma.Text = Nothing Then
            MessageBox.Show("Ingrese el nombre del programa.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtNombreMPrograma.Focus()
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese una descripción del programa.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtDescripcion.Focus()
        Else
            Estado = True
        End If

        Return Estado
    End Function

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodPrograma.Text = LsvPrograma.FocusedItem.SubItems(0).Text
        TxtNombreMPrograma.Text = LsvPrograma.FocusedItem.SubItems(1).Text
        TxtDescripcion.Text = LsvPrograma.FocusedItem.SubItems(2).Text
        CboTipoPrograma.Text = LsvPrograma.FocusedItem.SubItems(3).Text

        Call HabilitarControles(False, False, True, True, True)
    End Sub

    Private Sub ChkMostrarTodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarTodo.CheckedChanged
        If ChkMostrarTodo.Checked = True Then
            Me.Height = 522
        Else
            Me.Height = 366
        End If
    End Sub
End Class