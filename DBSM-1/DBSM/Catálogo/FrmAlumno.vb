Imports System.Data.SqlClient

Public Class FrmAlumno
    Private Sub FrmAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        MostrarAlumno()
        LlenarCombobox()
        Me.Height = 450
    End Sub

    Private Sub HabilitarBotones(ByVal nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal PanelAlumno As Boolean)
        BtnNuevo.Enabled = nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        PnlAlumno.Enabled = PanelAlumno

    End Sub
    Private Sub LlenarCombobox()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_Sexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                Me.CboSexo.DataSource = ds.Tables(0)
                Me.CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
                Me.CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString

            End Using
        Catch ex As Exception

        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        MtbIdAlumno.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
    End Sub
    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function
    Private Sub Limpiar()
        MtbIdAlumno.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        TxtEmail.Text = Nothing
        Mtbtelefono.Text = Nothing
        TxtDireccion.Text = Nothing
        CboSexo.SelectedIndex = -1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar(MtbIdAlumno, "Debe ingresar el IdAlumno") Then
        ElseIf Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(Mtbtelefono, "Debe ingresar unnúmero de teléfono") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un sexo") Then
        Else
            HabilitarBotones(True, False, False, False, False)


            AgregarCliente()
            MostrarAlumno()

        End If

    End Sub

    Private Function ExistenciaAlumno() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False
        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExistenciaAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = MtbIdAlumno.Text.Trim
                    .Connection = cnn
                End With
                Dim existe As Integer = cmd.ExecuteScalar()
                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrado este Alumno", "DBS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return Val
    End Function




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

    Private Sub AgregarCliente()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "SP_InsertarAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = MtbIdAlumno.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar, 30).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@correo", SqlDbType.NVarChar, 60).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.NVarChar, 10).Value = Mtbtelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de Alumno Agregado", "DBS", MessageBoxButtons.OK)
                    Limpiar()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub CboSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSexo.SelectedIndexChanged

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        MtbIdAlumno.Text = lsbAlumno.FocusedItem.SubItems(0).Text
        TxtNombre.Text = lsbAlumno.FocusedItem.SubItems(1).Text
        TxtApellido.Text = lsbAlumno.FocusedItem.SubItems(2).Text
        TxtEmail.Text = lsbAlumno.FocusedItem.SubItems(3).Text
        Mtbtelefono.Text = lsbAlumno.FocusedItem.SubItems(4).Text
        TxtDireccion.Text = lsbAlumno.FocusedItem.SubItems(5).Text
        CboSexo.Text = lsbAlumno.FocusedItem.SubItems(6).Text
        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarAlumno()
        MostrarAlumno()
    End Sub
    Private Sub EliminarAlumno()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminaAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    'estableser los parametros
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = lsbAlumno.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro eliminado Exitosamente", "DBS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call MostrarAlumno()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro al eliminar la ciudad" + ex.Message)

        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(MtbIdAlumno, "Debe ingresar el IdAlumno") Then
        ElseIf Validar(TxtNombre, "Debe ingresar un nombre de empleado") Then
        ElseIf Validar(TxtApellido, "Debe ingresar un apellido") Then
        ElseIf Validar(TxtEmail, "Debe seleccionar un Email") Then
        ElseIf Validar(Mtbtelefono, "Debe ingresar unnúmero de teléfono") Then
        ElseIf Validar(TxtDireccion, "Debe ingresar una dirección") Then
        ElseIf Validar(CboSexo, "Debe seleccionar un sexo") Then
        Else
            HabilitarBotones(True, False, False, False, False)


            EditarAlumno()
            MostrarAlumno()

        End If
    End Sub


    Private Sub EditarAlumno()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarAlumno"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdAlumno", SqlDbType.NVarChar, 15).Value = MtbIdAlumno.Text.Trim
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellido", SqlDbType.NVarChar, 30).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@correo", SqlDbType.NVarChar, 60).Value = TxtEmail.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.NVarChar, 10).Value = Mtbtelefono.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro a sido editado", "DBS", MessageBoxButtons.OK)
                    Limpiar()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub ChkVertodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVertodo.CheckedChanged
        If ChkVertodo.CheckState = CheckState.Checked Then
            Me.Height = 666
            Call MostrarAlumno()
        Else
            Me.Height = 487
        End If
    End Sub
End Class