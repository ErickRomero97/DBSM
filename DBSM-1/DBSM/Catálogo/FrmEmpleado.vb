Imports System.Data.SqlClient
Public Class FrmEmpleado
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarComboboxSexo()
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodo()
        CboSexo.Text = Nothing
    End Sub

    Private Sub HabilitarControles(ByVal Agregar As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal GroupBox As Boolean)
        BtnAgregar.Enabled = Agregar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        GbEmpleado.Enabled = GroupBox
    End Sub

    Private Sub Limpiar()
        MtbCodEmpleado.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        MtbTelefono.Clear()
        TxtCorreo.Clear()
        CboSexo.Text = Nothing
    End Sub

    Private Sub LlenarComboboxSexo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()
                With cmd
                    .CommandText = "Sp_LlenarComboSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al listar sexo" + ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarTodo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_MostrarDatos"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvDatosEmpleado.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvDatosEmpleado.Items.Add(MostrarEmpleado("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleado("Nombre").ToString)
                        .SubItems.Add(MostrarEmpleado("Apellido").ToString)
                        .SubItems.Add(MostrarEmpleado("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleado("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleado("Correo").ToString)
                        .SubItems.Add(MostrarEmpleado("Sexo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar las empleado" + ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call HabilitarControles(False, True, False, True, True)
        MtbCodEmpleado.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call HabilitarControles(True, False, False, False, False)

        If Validar() Then
            Call Guardar()
            Call Limpiar()
        End If


    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        MtbCodEmpleado.Text = LsvDatosEmpleado.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvDatosEmpleado.FocusedItem.SubItems(1).Text
        TxtApellido.Text = LsvDatosEmpleado.FocusedItem.SubItems(2).Text
        TxtDireccion.Text = LsvDatosEmpleado.FocusedItem.SubItems(3).Text
        MtbTelefono.Text = LsvDatosEmpleado.FocusedItem.SubItems(4).Text
        TxtCorreo.Text = LsvDatosEmpleado.FocusedItem.SubItems(5).Text
        CboSexo.Text = LsvDatosEmpleado.FocusedItem.SubItems(6).Text

        Call HabilitarControles(False, False, True, True, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Function ExisteEmpleado() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 40).Value = MtbCodEmpleado.Text
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Empleado", "DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function

    Private Sub Guardar()
        If ExisteEmpleado() = False Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

            Try
                cnn.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertEmpleado"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn

                        'Establecer los procedimientos almacenados

                        .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 15).Value = Trim(MtbCodEmpleado.Text)
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = Trim(TxtNombre.Text)
                        .Parameters.Add("@Apellido", SqlDbType.NVarChar, 30).Value = Trim(TxtApellido.Text)
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(TxtDireccion.Text)
                        .Parameters.Add("@Telefono", SqlDbType.NVarChar, 10).Value = Trim(MtbTelefono.Text)
                        .Parameters.Add("@Correo", SqlDbType.NVarChar, 60).Value = Trim(TxtCorreo.Text)
                        .Parameters.Add("@Sexo", SqlDbType.Int).Value = Trim(CboSexo.SelectedValue)
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

    Private Sub Actualizar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If


        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_UpdateEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados

                    .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 15).Value = Trim(MtbCodEmpleado.Text)
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = Trim(TxtNombre.Text)
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar, 30).Value = Trim(TxtApellido.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(TxtDireccion.Text)
                    .Parameters.Add("@Telefono", SqlDbType.NVarChar, 10).Value = Trim(MtbTelefono.Text)
                    .Parameters.Add("@Correo", SqlDbType.NVarChar, 60).Value = Trim(TxtCorreo.Text)
                    .Parameters.Add("@Sexo", SqlDbType.Int).Value = Trim(CboSexo.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("Modificación almacenada Satisfactoriamente", "DBMS")
                    Call MostrarTodo()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro" + ex.Message)
            Call MostrarTodo()
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Eliminar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If


        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_DeleteEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'Establecer los procedimientos almacenados

                    .Parameters.Add("@IdEmpleado", SqlDbType.NVarChar, 15).Value = LsvDatosEmpleado.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("El empleado ha sido eliminado Satisfactoriamente", "DBMS")
                    Call MostrarTodo()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro" + ex.Message)
            Call MostrarTodo()
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If MtbCodEmpleado.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing And TxtDireccion.Text = Nothing And MtbTelefono.Text = Nothing And CboSexo.Text = Nothing Then
            MessageBox.Show("Ingrese todo los valores.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            MtbCodEmpleado.Focus()
            estado = False
        ElseIf MtbCodEmpleado.Text = Nothing Then
            MessageBox.Show("Ingrese el número de identidad.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            MtbCodEmpleado.Focus()
            estado = False
        ElseIf TxtNombre.Text = Nothing Then
            MessageBox.Show("Ingrese el nombre.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtNombre.Focus()
            estado = False
        ElseIf TxtApellido.Text = Nothing Then
            MessageBox.Show("Ingrese el apellido.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtApellido.Focus()
            estado = False
        ElseIf TxtDireccion.Text = Nothing Then
            MessageBox.Show("Ingrese la dirección.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            TxtDireccion.Focus()
            estado = False
        ElseIf MtbTelefono.Text = Nothing Then
            MessageBox.Show("Ingre el número de teléfono.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            MtbTelefono.Focus()
            estado = False
        ElseIf CboSexo.Text = Nothing Then
            MessageBox.Show("Seleccione el sexo.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HabilitarControles(False, True, False, True, True)
            CboSexo.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call Actualizar()
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub ChkMostrarTodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarTodo.CheckedChanged
        If ChkMostrarTodo.Checked = True Then
            Call MostrarTodo()
            Me.Height = 541
        Else
            Me.Height = 420
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Call Eliminar()
        Call Limpiar()
        Call HabilitarControles(True, False, False, False, False)
    End Sub
End Class