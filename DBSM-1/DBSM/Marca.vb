Imports System.Data.SqlClient
Public Class Marca
    Public regreso As Integer = 0

    Private Sub Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, False)
        MostrarMarcas()
    End Sub

    Private Sub ChkVertodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVertodo.CheckedChanged
        If ChkVertodo.CheckState = CheckState.Checked Then
            Height = 429
            CenterToScreen()
        Else
            Height = 277
            CenterToScreen()
        End If
    End Sub
    Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Editar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnEditar.Enabled = Editar
        BtnCancelar.Enabled = Cancelar
        PlMarca.Enabled = Panel
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        TxtCodM.Focus()
        ChkVertodo.Checked = False
        Limpiar()
        ChkVertodo.Enabled = False
        InvestigarCorrelativo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Validar(TxtNombreM, "Debe ingresar el Nombre de la Marca") Then
        Else
            AgregarMarca()
            HabilitarBotones(True, False, False, False, False)
            Limpiar()
            MostrarMarcas()
            ChkVertodo.Enabled = True
        End If
    End Sub

    Private Sub Btneditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Validar(TxtNombreM, "El nombre de la marca es requerido") Then
        Else
            Actualizar()
            MostrarMarcas()
            Limpiar()
            HabilitarBotones(True, False, False, False, False)
        End If

    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, False)
        Limpiar()
        ChkVertodo.Enabled = True
    End Sub

    Sub Limpiar()
        TxtCodM.Text = ""
        TxtNombreM.Text = ""
    End Sub

    Private Sub MostrarMarcas()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostrarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim VerMarca As SqlDataReader
                VerMarca = cmd.ExecuteReader()
                lsvMarca.Items.Clear()
                While VerMarca.Read = True
                    With Me.lsvMarca.Items.Add(VerMarca("IdMarca").ToString)
                        .SubItems.Add(VerMarca("Marca").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End Using
    End Sub

    Private Sub AgregarMarca()
        If ExisteRegistro() = False Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()
            Try
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Sp_InsertarMarca"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cnn
                        .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtNombreM.Text.Trim
                        .ExecuteNonQuery()
                        MessageBox.Show("El Reguistro de La Marca fue guardado existosamente", "DBMS", MessageBoxButtons.OK)
                    End With
                End Using

            Catch ex As Exception

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
                    .CommandText = "Sp_ActualizarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = TxtCodM.Text
                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtNombreM.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de la Marca ha sido actualizado", "DBMS", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("La Clave ya existe") Then
                MessageBox.Show("Ya se encuentra registrada esta marca", "DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    .CommandText = "Sp_EliminarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = lsvMarca.FocusedItem.SubItems(0).Text
                    .ExecuteNonQuery()
                    MessageBox.Show("La marca a sido Eliminado Satisfactoriamente", "DBMS", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodM.Text = lsvMarca.FocusedItem.SubItems(0).Text
        TxtNombreM.Text = lsvMarca.FocusedItem.SubItems(1).Text
        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
        MostrarMarcas()
        HabilitarBotones(True, False, False, False, False)
    End Sub

    Sub InvestigarCorrelativo()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Dim ListarMarca As New SqlCommand("SP_MostrarMarcaIdentity", cnn)
            ListarMarca.CommandType = CommandType.StoredProcedure
            Dim ListarMarcas As SqlDataReader
            cnn.Open()
            ListarMarcas = ListarMarca.ExecuteReader
            If ListarMarcas.Read = True Then
                If ListarMarcas("Id") Is DBNull.Value Then
                    TxtCodM.Text = 1
                Else
                    TxtCodM.Text = ListarMarcas("Id").ToString
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
                    .CommandText = "Sp_ExisteMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 12).Value = TxtNombreM.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                Else
                    Val = True
                    MessageBox.Show("Ya se encuentra registrada esta marca", "IMMG", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function


    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            MessageBox.Show(Mensaje, "IMMG", MessageBoxButtons.OK)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class