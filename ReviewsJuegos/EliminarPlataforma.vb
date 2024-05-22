Imports System.Data.SqlClient

Public Class EliminarPlataforma
    Private Sub EliminarPlataforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPlataformas()

    End Sub

    Private Sub CargarPlataformas()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "EXEC SP_ObtenerPlataformas"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                CbxPlataf.DisplayMember = "NombrePlataforma"
                CbxPlataf.ValueMember = "Id"
                CbxPlataf.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar las desarrolladoras: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Asegurarse de que se haya seleccionado una desarrolladora
        If CbxPlataf.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una Plataforma.")
            Exit Sub
        End If

        ' Obtener el ID de la desarrolladora seleccionada
        Dim idPlataforma As Integer
        If Integer.TryParse(CbxPlataf.SelectedValue.ToString(), idPlataforma) Then
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query As String = "SP_EliminarPlataforma"


            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@IdPlataforma", idPlataforma))

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Plataforma eliminada correctamente.")
                    CargarPlataformas() ' Recargar la lista después de eliminar
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar la Plataforma: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            MessageBox.Show("El ID de la Plataforma seleccionada no es válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class