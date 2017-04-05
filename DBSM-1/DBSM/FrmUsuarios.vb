Imports System.Data.SqlClient
Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call LlenarComboboxEstado()
        Call LlenarComboboxTipoUsuario()
        Call MostrarTodo()
        CboEstado.SelectedIndex = -1
        CboTipoUsuario.SelectedIndex = -1
    End Sub

    Private Sub HabilitarControles(ByVal Agregar As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal GroupBox As Boolean)
        BtnNuevo.Enabled = Agregar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        GbDatosUsuario.Enabled = GroupBox
    End Sub

    Private Sub limpiar()
        TxtIdUsuario.Text = Nothing
        TxtUsuario.Text = Nothing
        TxtContraseña.Text = Nothing
        CboEstado.SelectedIndex = -1
        MtbIdEmpleado.Text = Nothing
        CboTipoUsuario.SelectedIndex = -1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call MostrarIdUsuario()
        Call HabilitarControles(False, True, False, True, True)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call InsertarUsuario()
        Call limpiar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call limpiar()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtIdUsuario.Text = LsvMostrarUsuario.FocusedItem.SubItems(0).Text
        TxtUsuario.Text = LsvMostrarUsuario.FocusedItem.SubItems(1).Text
        TxtContraseña.Text = LsvMostrarUsuario.FocusedItem.SubItems(2).Text
        CboEstado.Text = LsvMostrarUsuario.FocusedItem.SubItems(3).Text
        MtbIdEmpleado.Text = LsvMostrarUsuario.FocusedItem.SubItems(4).Text
        CboTipoUsuario.Text = LsvMostrarUsuario.FocusedItem.SubItems(5).Text

        Call HabilitarControles(False, False, True, True, True)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call ActualizarUsuario()
        Call limpiar()
    End Sub

    Private Sub MostrarTodo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_MostrarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarUsuario As SqlDataReader
                MostrarUsuario = cmd.ExecuteReader
                LsvMostrarUsuario.Items.Clear()

                While MostrarUsuario.Read = True
                    With LsvMostrarUsuario.Items.Add(MostrarUsuario("IdUsuario").ToString)
                        .SubItems.Add(MostrarUsuario("UserName").ToString)
                        .SubItems.Add(MostrarUsuario("Contraseña").ToString)
                        .SubItems.Add(MostrarUsuario("Estado").ToString)
                        .SubItems.Add(MostrarUsuario("IdEmpleado").ToString)
                        .SubItems.Add(MostrarUsuario("Usuario").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los usuarios" + ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub ChkMostrarTodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarTodo.CheckedChanged
        If ChkMostrarTodo.Checked = True Then
            Me.Height = 541
        Else
            Me.Height = 374
        End If
    End Sub

    Private Sub LlenarComboboxEstado()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboEstado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Estado")
                Me.CboEstado.DataSource = ds.Tables(0)
                Me.CboEstado.DisplayMember = ds.Tables(0).Columns("Estado").ToString
                Me.CboEstado.ValueMember = ds.Tables(0).Columns("IdEstado").ToString
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al listar estado" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LlenarComboboxTipoUsuario()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_LlenarComboTipoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoUsuario")
                Me.CboTipoUsuario.DataSource = ds.Tables(0)
                Me.CboTipoUsuario.DisplayMember = ds.Tables(0).Columns("Usuario").ToString
                Me.CboTipoUsuario.ValueMember = ds.Tables(0).Columns("IdTipoUsuario").ToString
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al listar Ttipo usuario" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub MostrarIdUsuario()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarUsuario As New SqlCommand("Sp_MostrarIdUsuarioIdentity", cnn)
            ListarUsuario.CommandType = CommandType.StoredProcedure
            Dim ListarUsuarios As SqlDataReader
            cnn.Open()
            ListarUsuarios = ListarUsuario.ExecuteReader
            If ListarUsuarios.Read = True Then
                If ListarUsuarios("Id") Is DBNull.Value Then
                    TxtIdUsuario.Text = 1
                Else
                    TxtIdUsuario.Text = ListarUsuarios("Id").ToString
                End If
            End If
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ExisteUsuario() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este usuario", "DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub InsertarUsuario()
        If ExisteUsuario() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

            Try
                cnn.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertUsuario"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn

                        'Establecer los procedimientos almacenados

                        .Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = Trim(TxtUsuario.Text)
                        .Parameters.Add("@Contraseña", SqlDbType.NVarChar, 30).Value = Trim(TxtContraseña.Text)
                        .Parameters.Add("@IdEstado", SqlDbType.Int).Value = Trim(CboEstado.SelectedValue)
                        .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 15).Value = Trim(MtbIdEmpleado.Text)
                        .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = Trim(CboTipoUsuario.SelectedValue)
                        .ExecuteNonQuery()
                        MessageBox.Show("El registro se ha almacenado Satisfactoriamente", "DBMS")
                        Call MostrarTodo()
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al almacenar el registro" + ex.Message)
                Call MostrarTodo()
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub ActualizarUsuario()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_UpdateUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Trim(TxtIdUsuario.Text)
                    .Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = Trim(TxtUsuario.Text)
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar, 30).Value = Trim(TxtContraseña.Text)
                    .Parameters.Add("@IdEstado", SqlDbType.Int).Value = Trim(CboEstado.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 15).Value = Trim(MtbIdEmpleado.Text)
                    .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = Trim(CboTipoUsuario.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro se ha almacenado Satisfactoriamente", "DBMS")
                    Call MostrarTodo()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al almacenar el registro" + ex.Message)
            Call MostrarTodo()
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub BtnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmpleado.Click
        FrmBuscarEmpleado.ShowDialog()
    End Sub
End Class