using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviewsJuegos
{

    public partial class EliminarPlataforma
    {
        public EliminarPlataforma()
        {
            InitializeComponent();
        }
        private void EliminarPlataforma_Load(object sender, EventArgs e)
        {
            CargarPlataformas();

        }

        private void CargarPlataformas()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "EXEC SP_ObtenerPlataformas";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    CbxPlataf.DisplayMember = "NombrePlataforma";
                    CbxPlataf.ValueMember = "Id";
                    CbxPlataf.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las desarrolladoras: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Asegurarse de que se haya seleccionado una desarrolladora
            if (CbxPlataf.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una Plataforma.");
                return;
            }

            // Obtener el ID de la desarrolladora seleccionada
            int idPlataforma;
            if (int.TryParse(CbxPlataf.SelectedValue.ToString(), out idPlataforma))
            {
                string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
                string query = "SP_EliminarPlataforma";


                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IdPlataforma", idPlataforma));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Plataforma eliminada correctamente.");
                        CargarPlataformas(); // Recargar la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la Plataforma: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("El ID de la Plataforma seleccionada no es válido.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}