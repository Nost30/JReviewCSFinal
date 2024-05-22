Imports System.Data.SqlClient

Public Class FormularioActualizar
    Private query As String
    Private auto As Boolean
    Public Sub New()

        auto = True
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ' Create a new instance of the Connection class
        'CBXGENERO
        query = "SELECT Id,Genero FROM Genero"
        ComboBoxGenero.DataSource = ConexionSQL.SelectQuery(query)
        ComboBoxGenero.DisplayMember = "Genero"
        ComboBoxGenero.ValueMember = "id"
        auto = False
        'CBXDESARROLLADORA
        query = "SELECT Id,Desarrolladora FROM Desarrolladora"
        ComboBoxDesarrolladora.DataSource = ConexionSQL.SelectQuery(query)
        ComboBoxDesarrolladora.DisplayMember = "Desarrolladora"
        ComboBoxDesarrolladora.ValueMember = "id"
        auto = False
        ''CBXPLATAFORMA
        query = "SELECT Id,NombrePlataforma FROM Plataforma"
        ComboBoxPlataforma.DataSource = ConexionSQL.SelectQuery(query)
        ComboBoxPlataforma.DisplayMember = "NombrePlataforma"
        ComboBoxPlataforma.ValueMember = "id"
        auto = False



    End Sub

    Private Sub btnActualizarJuego_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()
            Dim command As New SqlCommand("SP_ActualizarJuego", connection)
            command.CommandType = CommandType.StoredProcedure

            ' Parámetros del procedimiento almacenado
            command.Parameters.AddWithValue("@IdJuego", txtIdJuego.Text)
            command.Parameters.AddWithValue("@NombreJuego", txtNombreJuego.Text)
            command.Parameters.AddWithValue("@IdGenero", ComboBoxGenero.SelectedValue)
            command.Parameters.AddWithValue("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue)
            command.Parameters.AddWithValue("@IdPlataforma", ComboBoxPlataforma.SelectedValue)
            command.Parameters.AddWithValue("@FechaLanzamiento", DTTFechaLanzamiento.Value)
            command.Parameters.AddWithValue("@NumeroJugadores", TxtNumJugadores.Text)
            command.Parameters.AddWithValue("@Metascore", txtMetascore.Text)
            command.Parameters.AddWithValue("@PuntajeUsuario", txtPuntajeUsuario.Text)
            command.Parameters.AddWithValue("@IdUsuarioModifica", 1)

            command.ExecuteNonQuery()
            MessageBox.Show("Juego actualizado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el juego: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


End Class


