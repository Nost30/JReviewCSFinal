Imports System.Data.SqlClient
Public Class EditarDesarrolladora

    Private Sub ActualizarDesarrolladora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDesarrolladoras()
    End Sub

    Private Sub CargarDesarrolladoras()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SELECT Id, Desarrolladora FROM Desarrolladora"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            CbxDesa.DisplayMember = "Desarrolladora"
            CbxDesa.ValueMember = "Id"
            CbxDesa.DataSource = table
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbxDesa.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtDesaEdit.Text) Then
            Dim idDesarrolladora As Integer = CInt(CbxDesa.SelectedValue)
            Dim nuevoNombre As String = TxtDesaEdit.Text

            ActualizarNombreDesarrolladora(idDesarrolladora, nuevoNombre)
        Else
            MessageBox.Show("Seleccione una desarrolladora y escriba el nuevo nombre.")
        End If
    End Sub

    Private Sub ActualizarNombreDesarrolladora(idDesarrolladora As Integer, nuevoNombre As String)
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SP_ActualizarDesarrolladora"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@IdDesarrolladora", idDesarrolladora)
            command.Parameters.AddWithValue("@NombreDesarrolladora", nuevoNombre)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Nombre de la desarrolladora actualizado correctamente.")
            CargarDesarrolladoras() ' Recargar la lista de desarrolladoras
        End Using
    End Sub
End Class