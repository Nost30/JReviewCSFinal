using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviewsJuegos
{

    public partial class EliminarGenero
    {
        public EliminarGenero()
        {
            InitializeComponent();
        }

        private void EliminarPlataforma_Load(object sender, EventArgs e)
        {
            CargarGeneros();

        }

        private void CargarGeneros()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "EXEC SP_ObtenerGeneros";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    CbxGen.DisplayMember = "Genero";
                    CbxGen.ValueMember = "Id";
                    CbxGen.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las generos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void EliminarGenero_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Asegurarse de que se haya seleccionado una desarrolladora
            if (CbxGen.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un genero.");
                return;
            }

            // Obtener el ID de la desarrolladora seleccionada
            int idDesarrolladora;
            if (int.TryParse(CbxGen.SelectedValue.ToString(), out idDesarrolladora))
            {
                string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
                string query = "SP_EliminarGenero";

                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IdGenero", idDesarrolladora));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Genero eliminada correctamente.");
                        CargarGeneros(); // Recargar la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el genero: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("El ID del genero seleccionado no es válido.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}