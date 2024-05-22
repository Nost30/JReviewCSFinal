Imports System.Data.SqlClient

Public Class EliminarGenero

    Private Sub EliminarPlataforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGeneros()

    End Sub

    Private Sub CargarGeneros()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "EXEC SP_ObtenerGeneros"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                CbxGen.DisplayMember = "Genero"
                CbxGen.ValueMember = "Id"
                CbxGen.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar las generos: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
    Private Sub EliminarGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Asegurarse de que se haya seleccionado una desarrolladora
        If CbxGen.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un genero.")
            Exit Sub
        End If

        ' Obtener el ID de la desarrolladora seleccionada
        Dim idDesarrolladora As Integer
        If Integer.TryParse(CbxGen.SelectedValue.ToString(), idDesarrolladora) Then
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query As String = "SP_EliminarGenero"

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@IdGenero", idDesarrolladora))

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Genero eliminada correctamente.")
                    CargarGeneros() ' Recargar la lista después de eliminar
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el genero: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            MessageBox.Show("El ID del genero seleccionado no es válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class