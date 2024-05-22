Imports System.Data.SqlClient

Public Class FormularioAgregar
    Private query As String
    Private auto As Boolean
    ' Create a constructor
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

    Private Sub BtnAgregarJuego_Click(sender As Object, e As EventArgs) Handles BtnAgregarJuego.Click

        ' Crear parámetros para el procedimiento almacenado
        Dim parametros(8) As SqlParameter
        parametros(0) = New SqlParameter("@NombreJuego", TxtJuego.Text)
        parametros(1) = New SqlParameter("@IdGenero", ComboBoxGenero.SelectedValue)
        parametros(2) = New SqlParameter("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue)
        parametros(3) = New SqlParameter("@IdPlataforma", ComboBoxPlataforma.SelectedValue)
        parametros(4) = New SqlParameter("@FechaLanzamiento", DTTFechaLanzamiento.Value)
        parametros(5) = New SqlParameter("@NumeroJugadores", TxtNumJugadores.Text)
        parametros(6) = New SqlParameter("@Metascore", TxtMetascore.Text)
        parametros(7) = New SqlParameter("@PuntajeUsuario", TxtPuntajeUsuario.Text)
        parametros(8) = New SqlParameter("@IdUsuarioCrea", 1)



        ' Ejecutar el procedimiento almacenado
        ConexionSQL.ExecuteStoredProcedure("SP_AgregarJuego", parametros)
        MsgBox("Registro exitoso")



    End Sub

    ' Declaración de la conexión a la base de datos
    Private connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"

    ' Método para obtener la próxima ID disponible para un nuevo juego
    Private Function GetNextAvailableGameId() As Integer
        Dim nextId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT MAX(Id) + 1 FROM Juego"
                Dim command As New SqlCommand(query, connection)
                nextId = Convert.ToInt32(command.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show("Error al obtener la próxima ID disponible: " & ex.Message)
            End Try
        End Using

        Return nextId
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtener la próxima ID disponible
        Dim nextId As Integer = GetNextAvailableGameId()

        ' Asignar la próxima ID disponible al campo de texto txtIdJuego
        TxtId.Text = nextId.ToString()

        ' Establecer el TextBox como de solo lectura
        TxtId.ReadOnly = True
    End Sub


    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
