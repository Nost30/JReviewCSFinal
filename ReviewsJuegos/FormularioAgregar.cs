using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ReviewsJuegos
{

    public partial class FormularioAgregar
    {
        private string query;
        private bool auto;
        // Create a constructor
        public FormularioAgregar()
        {
            auto = true;
            // This call is required by the designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.
            // Create a new instance of the Connection class
            // CBXGENERO
            query = "SELECT Id,Genero FROM Genero";
            ComboBoxGenero.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxGenero.DisplayMember = "Genero";
            ComboBoxGenero.ValueMember = "id";
            auto = false;
            // CBXDESARROLLADORA
            query = "SELECT Id,Desarrolladora FROM Desarrolladora";
            ComboBoxDesarrolladora.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxDesarrolladora.DisplayMember = "Desarrolladora";
            ComboBoxDesarrolladora.ValueMember = "id";
            auto = false;
            // 'CBXPLATAFORMA
            query = "SELECT Id,NombrePlataforma FROM Plataforma";
            ComboBoxPlataforma.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxPlataforma.DisplayMember = "NombrePlataforma";
            ComboBoxPlataforma.ValueMember = "id";
            auto = false;



        }

        private void BtnAgregarJuego_Click(object sender, EventArgs e)
        {

            // Crear parámetros para el procedimiento almacenado
            var parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@NombreJuego", TxtJuego.Text);
            parametros[1] = new SqlParameter("@IdGenero", ComboBoxGenero.SelectedValue);
            parametros[2] = new SqlParameter("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue);
            parametros[3] = new SqlParameter("@IdPlataforma", ComboBoxPlataforma.SelectedValue);
            parametros[4] = new SqlParameter("@FechaLanzamiento", DTTFechaLanzamiento.Value);
            parametros[5] = new SqlParameter("@NumeroJugadores", TxtNumJugadores.Text);
            parametros[6] = new SqlParameter("@Metascore", TxtMetascore.Text);
            parametros[7] = new SqlParameter("@PuntajeUsuario", TxtPuntajeUsuario.Text);
            parametros[8] = new SqlParameter("@IdUsuarioCrea", 1);



            // Ejecutar el procedimiento almacenado
            ConexionSQL.ExecuteStoredProcedure("SP_AgregarJuego", parametros);
            Interaction.MsgBox("Registro exitoso");



        }

        // Declaración de la conexión a la base de datos
        private string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";

        // Método para obtener la próxima ID disponible para un nuevo juego
        private int GetNextAvailableGameId()
        {
            int nextId = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MAX(Id) + 1 FROM Juego";
                    var command = new SqlCommand(query, connection);
                    nextId = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la próxima ID disponible: " + ex.Message);
                }
            }

            return nextId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener la próxima ID disponible
            int nextId = GetNextAvailableGameId();

            // Asignar la próxima ID disponible al campo de texto txtIdJuego
            TxtId.Text = nextId.ToString();

            // Establecer el TextBox como de solo lectura
            TxtId.ReadOnly = true;
        }


        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}