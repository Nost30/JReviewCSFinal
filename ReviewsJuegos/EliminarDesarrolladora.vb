Imports System.Data.SqlClient

Public Class EliminarDesarrolladora

    Private Sub EliminarDesarrolladora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDesarrolladoras()
    End Sub

    Private Sub CargarDesarrolladoras()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "EXEC SP_ObtenerDesarrolladoras"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                CbxEliminar.DisplayMember = "Desarrolladora"
                CbxEliminar.ValueMember = "Id"
                CbxEliminar.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar las desarrolladoras: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Asegurarse de que se haya seleccionado una desarrolladora
        If CbxEliminar.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una desarrolladora.")
            Exit Sub
        End If

        ' Obtener el ID de la desarrolladora seleccionada
        Dim idDesarrolladora As Integer
        If Integer.TryParse(CbxEliminar.SelectedValue.ToString(), idDesarrolladora) Then
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query As String = "SP_EliminarDesarrolladora"

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@IdDesarrolladora", idDesarrolladora))

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Desarrolladora eliminada correctamente.")
                    CargarDesarrolladoras() ' Recargar la lista después de eliminar
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar la desarrolladora: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            MessageBox.Show("El ID de la desarrolladora seleccionada no es válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
