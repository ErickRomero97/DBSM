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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoCodigoMo.Checked = True Then
            If TxtBuscarMo.Text.Trim = Nothing Then
                MessageBox.Show("El código de modelo es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscarMo.Focus()
            Else
                MostrarModeloCodigo()
                TxtBuscarMo.Focus()
            End If
        End If

        If RdoNombreMo.Checked = True Then
            If TxtBuscarMo.Text.Trim = Nothing Then
                MessageBox.Show("El nombre de modelo es necesario", "DBSM", MessageBoxButtons.OK)
                TxtBuscarMo.Focus()
            Else
                MostrarModeloNombre()
                TxtBuscarMo.Focus()
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
    Private Sub RdoCodigoMo_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCodigoMo.CheckedChanged
        TxtBuscarMo.Enabled = True
        TxtBuscarMo.Focus()
        BtnBuscar.Enabled = True
    End Sub
    Private Sub RdoNombreMo_CheckedChanged(sender As Object, e As EventArgs) Handles RdoNombreMo.CheckedChanged
        TxtBuscarMo.Enabled = True
        TxtBuscarMo.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub TxtBuscarMo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarMo.TextChanged
        If TxtBuscarMo.Text = "" Then
            MostrarModelos()
        End If
    End Sub
End Class