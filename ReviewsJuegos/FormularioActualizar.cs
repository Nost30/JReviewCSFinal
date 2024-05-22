using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviewsJuegos
{

    public partial class FormularioActualizar
    {
        private string query;
        private bool auto;
        public FormularioActualizar()
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

        private void btnActualizarJuego_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                var command = new SqlCommand("SP_ActualizarJuego", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento almacenado
                command.Parameters.AddWithValue("@IdJuego", TxtIdJuego.Text);
                command.Parameters.AddWithValue("@NombreJuego", TxtNombreJuego.Text);
                command.Parameters.AddWithValue("@IdGenero", ComboBoxGenero.SelectedValue);
                command.Parameters.AddWithValue("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue);
                command.Parameters.AddWithValue("@IdPlataforma", ComboBoxPlataforma.SelectedValue);
                command.Parameters.AddWithValue("@FechaLanzamiento", DTTFechaLanzamiento.Value);
                command.Parameters.AddWithValue("@NumeroJugadores", TxtNumJugadores.Text);
                command.Parameters.AddWithValue("@Metascore", TxtMetascore.Text);
                command.Parameters.AddWithValue("@PuntajeUsuario", TxtPuntajeUsuario.Text);
                command.Parameters.AddWithValue("@IdUsuarioModifica", 1);

                command.ExecuteNonQuery();
                MessageBox.Show("Juego actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el juego: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}