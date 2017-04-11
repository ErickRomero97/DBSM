Imports System.Data.SqlClient
Public Class FrmBusquedaModelo
    Private Sub FrmBusquedaModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarModelos()
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
                LsvModeloBu.Items.Clear()
                While VerModelo.Read = True
                    With Me.LsvModeloBu.Items.Add(VerModelo("IdModelo").ToString)
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        If RdoCodigoMo.Checked = True Then
            If TxtBuscarMo.Text.Trim = Nothing Then
                MessageBox.Show("El código de modelo es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscarMo.Focus()
            Else
                MostrarModeloCodigo()
                TxtBuscarMo.Text = ""
            End If
        End If

        If RdoNombreMo.Checked = True Then
            If TxtBuscarMo.Text.Trim = Nothing Then
                MessageBox.Show("El nombre de modelo es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscarMo.Focus()
            Else
                MostrarModeloNombre()
                TxtBuscarMo.Text = ""
            End If
        End If
    End Sub

    Private Sub MostrarModeloCodigo()
        If ExisteModeloCodigo() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarModeloXCodigo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdModelo", SqlDbType.Int).Value = TxtBuscarMo.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerModelo As SqlDataReader
                    VerModelo = cmd.ExecuteReader()
                    LsvModeloBu.Items.Clear()
                    While VerModelo.Read = True
                        With Me.LsvModeloBu.Items.Add(VerModelo("IdModelo").ToString)
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

        End If
    End Sub

    Private Sub MostrarModeloNombre()
        If ExisteModeloNombre() = True Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarModeloXNombre"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = TxtBuscarMo.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerModelo As SqlDataReader
                    VerModelo = cmd.ExecuteReader()
                    LsvModeloBu.Items.Clear()
                    While VerModelo.Read = True
                        With Me.LsvModeloBu.Items.Add(VerModelo("IdModelo").ToString)
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
        End If
    End Sub

    Private Function ExisteModeloNombre() As Boolean
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
                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtBuscarMo.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvModeloBu.Items.Clear()
                    MessageBox.Show("No existe ningun registro con ese nombre de modelo", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function ExisteModeloCodigo() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteModeloXCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = TxtBuscarMo.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvModeloBu.Items.Clear()
                    MessageBox.Show("No existe ningun modelo con ese codigo", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub RdoCodigoMo_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCodigoMo.CheckedChanged
        TxtBuscarMo.Enabled = True
        TxtBuscarMo.Focus()
        BtnBuscar.Enabled = True
        TxtBuscarMo.Text = ""
        LsvModeloBu.Items.Clear()
    End Sub

    Private Sub RdoNombreMo_CheckedChanged(sender As Object, e As EventArgs) Handles RdoNombreMo.CheckedChanged
        TxtBuscarMo.Enabled = True
        TxtBuscarMo.Focus()
        BtnBuscar.Enabled = True
        TxtBuscarMo.Text = ""
        LsvModeloBu.Items.Clear()
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If RdoCodigoMo.Checked = True Then
            e.Handled = txtNumerico(TxtBuscarMo, e.KeyChar, True)
        End If
    End Sub

End Class