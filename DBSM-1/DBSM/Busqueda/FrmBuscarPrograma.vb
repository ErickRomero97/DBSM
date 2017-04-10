Imports System.Data.SqlClient
Public Class FrmBuscarPrograma
    Private Sub FrmBuscarPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarPrograma()
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

    Private Sub BuscarXPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarProgramaXNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Programa", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text
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
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarXIdPrograma()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cnn.Open()

                With cmd
                    .CommandText = "Sp_BuscarProgramaXId"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = TxtBuscar.Text
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
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()

            End Try
        End Using
    End Sub

    Private Function Validar() As Boolean
        Dim estado As Boolean

        If TxtBuscar.Text = Nothing Then
            MessageBox.Show("Ingrese un dato para buscar.", "DBSM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtBuscar.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Validar() Then
            If RdbPrograma.Checked = True Then
                Call BuscarXPrograma()
            ElseIf RdbCodPrograma.Checked = True Then
                Call BuscarXIdPrograma()
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = Nothing Then
            Call MostrarPrograma()
        End If
    End Sub
End Class