Imports System.Data.SqlClient

Public Class EditarGenero

    Private Sub EditarGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGeneros()
    End Sub

    Private Sub CargarGeneros()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SELECT Id, Genero FROM Genero"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            CbxGene.DisplayMember = "Genero"
            CbxGene.ValueMember = "Id"
            CbxGene.DataSource = table
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbxGene.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtGenEdit.Text) Then
            Dim idGenero As Integer = CInt(CbxGene.SelectedValue)
            Dim nuevoNombre As String = TxtGenEdit.Text

            ActualizarNombreGenero(idGenero, nuevoNombre)
        Else
            MessageBox.Show("Seleccione un género y escriba el nuevo nombre.")
        End If
    End Sub

    Private Sub ActualizarNombreGenero(idGenero As Integer, nuevoNombre As String)
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim query As String = "SP_ActualizarGenero"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@IdGenero", idGenero)
            command.Parameters.AddWithValue("@NombreGenero", nuevoNombre)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Nombre del género actualizado correctamente.")
            CargarGeneros() ' Recargar la lista de géneros
        End Using
    End Sub
End Class
