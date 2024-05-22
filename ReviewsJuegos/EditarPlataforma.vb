Imports System.Data.SqlClient

Public Class EditarPlataforma

    Private Sub EditarPlataforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPlataformas()

    End Sub

    Private Sub CargarPlataformas()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SELECT Id, NombrePlataforma FROM Plataforma"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            Cbxplataf.DisplayMember = "NombrePlataforma"
            Cbxplataf.ValueMember = "Id"
            Cbxplataf.DataSource = table
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cbxplataf.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtPlatafEdit.Text) Then
            Dim idPlataforma As Integer = CInt(Cbxplataf.SelectedValue)
            Dim nuevoNombre As String = TxtPlatafEdit.Text

            ActualizarNombrePlataforma(idPlataforma, nuevoNombre)
        Else
            MessageBox.Show("Seleccione una plataforma y escriba el nuevo nombre.")
        End If
    End Sub

    Private Sub ActualizarNombrePlataforma(idPlataforma As Integer, nuevoNombre As String)
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SP_ActualizarPlataforma"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@IdPlataforma", idPlataforma)
            command.Parameters.AddWithValue("@NombrePlataforma", nuevoNombre)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Nombre de la Plataforma actualizado correctamente.")
            CargarPlataformas() ' Recargar la lista de desarrolladoras
        End Using
    End Sub
End Class