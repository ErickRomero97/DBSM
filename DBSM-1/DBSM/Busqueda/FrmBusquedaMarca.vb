Imports System.Data.SqlClient
Public Class FrmBusquedaMarca
    Private Sub FrmBusquedaMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarMarcas()
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
                LsvMarca.Items.Clear()
                While VerMarca.Read = True
                    With Me.LsvMarca.Items.Add(VerMarca("IdMarca").ToString)
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
    Private Sub MostrarXCodMarca()
        If ExisteMarcaxCodigo() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarxMarca"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdMarca", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerMarca As SqlDataReader
                    VerMarca = cmd.ExecuteReader()
                    LsvMarca.Items.Clear()
                    While VerMarca.Read = True
                        With Me.LsvMarca.Items.Add(VerMarca("IdMarca").ToString)
                            .SubItems.Add(VerMarca("Marca").ToString)
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

    Private Sub MostrarxNombreMarca()
        If ExisteMarcaxNombre() = True Then

            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn.Open()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "Sp_MostrarXNombreMarca"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@Marca", SqlDbType.NVarChar).Value = TxtBuscar.Text.Trim
                        .Connection = cnn
                    End With
                    Dim VerMarca As SqlDataReader
                    VerMarca = cmd.ExecuteReader()
                    LsvMarca.Items.Clear()
                    While VerMarca.Read = True
                        With Me.LsvMarca.Items.Add(VerMarca("IdMarca").ToString)
                            .SubItems.Add(VerMarca("Marca").ToString)
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

    Private Function ExisteMarcaxCodigo() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteMarcaXCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvMarca.Items.Clear()
                    MessageBox.Show("No existe ninguna marca con ese codigo", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Function ExisteMarcaxNombre() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Dim Val As Boolean = False


        cnn.Open()
        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ExisteMarcaXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text.Trim
                    .Connection = cnn
                End With

                Dim existe As Integer = cmd.ExecuteScalar()

                If existe = 0 Then
                    LsvMarca.Items.Clear()
                    MessageBox.Show("No existe ninguna marca con ese nombre", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Val = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
        Return Val
    End Function

    Private Sub rdoCodMarca_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCodMarca.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True

    End Sub

    Private Sub rdoNombreMarca_CheckedChanged(sender As Object, e As EventArgs) Handles RdoNombreMarca.CheckedChanged
        TxtBuscar.Enabled = True
        TxtBuscar.Focus()
        BtnBuscar.Enabled = True
    End Sub



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RdoCodMarca.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El código de la marca es requerido", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarXCodMarca()
                TxtBuscar.Focus()
            End If
        End If

        If RdoNombreMarca.Checked = True Then
            If TxtBuscar.Text.Trim = Nothing Then
                MessageBox.Show("El nombre de la marca es requerido", "DBSM", MessageBoxButtons.OK)
                TxtBuscar.Focus()
            Else
                MostrarxNombreMarca()
                TxtBuscar.Focus()
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            MostrarMarcas()
        End If
    End Sub
End Class