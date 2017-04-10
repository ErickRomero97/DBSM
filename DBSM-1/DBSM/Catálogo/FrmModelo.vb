Imports System.Data.SqlClient
Public Class FrmModelo
    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombobox()
        MostrarModelos()
        Limpiar()
        HabilitarBotones(True, False, False, False, False)
    End Sub
    Public regreso As Integer = 0


    Private Sub Chkvertodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chkvertodo.CheckedChanged
        If Chkvertodo.CheckState = CheckState.Checked Then
            Height = 451
            CenterToScreen()
        Else
            Height = 315
            CenterToScreen()
        End If
    End Sub

    Sub Limpiar()
        TxtCodModelo.Text = ""
        TxtModelo.Text = ""
        CboMarca.SelectedIndex = -1
    End Sub

    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        PlModelo.Enabled = Panel

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
        InvestigarCorrelativo()
        HabilitarBotones(False, True, False, True, True)
        Chkvertodo.Checked = False
        Chkvertodo.Enabled = False
        TxtModelo.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(TxtModelo, "El nombre es necesario") Then
        ElseIf Validar(CboMarca, "Seleccione una marca") Then
        Else
            AgregarModelo()
            Limpiar()
            MostrarModelos()
            HabilitarBotones(True, False, False, False, False)
            Chkvertodo.Enabled = True
        End If
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(TxtModelo, "El nombre es necesario") Then
        ElseIf Validar(CboMarca, "Seleccione una marca") Then
        Else

            Actualizar()
            MostrarModelos()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        Chkvertodo.Enabled = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodModelo.Text = LsvModelo.FocusedItem.SubItems(0).Text
        TxtModelo.Text = LsvModelo.FocusedItem.SubItems(1).Text
        HabilitarBotones(False, False, True, True, True)
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        MostrarModelos()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Private Sub LlenarCombobox()
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

    Private Sub MostrarModelos()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarTodoModeloInner"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerModelo As SqlDataReader
                VerModelo = cmd.ExecuteReader()
                LsvModelo.Items.Clear()
                While VerModelo.Read = True
                    With Me.LsvModelo.Items.Add(VerModelo("IdModelo").ToString)
                        .SubItems.Add(VerModelo("Modelo").ToString)
                        .SubItems.Add(VerModelo("Marca").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    ' Insercion del modelo
    Private Sub AgregarModelo()

        If ExisteRegistro() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertarModelo"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
                        .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CboMarca.SelectedValue
                        .ExecuteNonQuery()
                        MessageBox.Show("El nuevo Modelo Fue guardado exitosamente", "DBSM", MessageBoxButtons.OK)
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
                    .CommandText = "Sp_ActualizarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = TxtCodModelo.Text.Trim
                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CboMarca.SelectedValue
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de modelo ha sido actualizado", "DBSM", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave ya existente") Then
                MessageBox.Show("Ya existe un registro con ese nombre de modelo", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message)
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
                    .CommandText = "Sp_EliminarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = LsvModelo.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de modelo ha sido eliminado", "DBSM", MessageBoxButtons.OK)
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
            Dim ListarModelo As New SqlCommand("Sp_MostrarModeloIdentity", cnn)
            ListarModelo.CommandType = CommandType.StoredProcedure
            Dim ListarModelos As SqlDataReader
            cnn.Open()
            ListarModelos = ListarModelo.ExecuteReader
            If ListarModelos.Read = True Then
                If ListarModelos("Id") Is DBNull.Value Then
                    TxtCodModelo.Text = 1
                Else
                    TxtCodModelo.Text = ListarModelos("Id").ToString
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
                    .CommandText = "Sp_ExisteModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("ese modelo ya existe en el software ", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class