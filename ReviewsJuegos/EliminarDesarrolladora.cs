using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviewsJuegos
{

    public partial class EliminarDesarrolladora
    {
        public EliminarDesarrolladora()
        {
            InitializeComponent();
        }

        private void EliminarDesarrolladora_Load(object sender, EventArgs e)
        {
            CargarDesarrolladoras();
        }

        private void CargarDesarrolladoras()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "EXEC SP_ObtenerDesarrolladoras";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    CbxEliminar.DisplayMember = "Desarrolladora";
                    CbxEliminar.ValueMember = "Id";
                    CbxEliminar.DataSource = table;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Asegurarse de que se haya seleccionado una desarrolladora
            if (CbxEliminar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una desarrolladora.");
                return;
            }

            // Obtener el ID de la desarrolladora seleccionada
            int idDesarrolladora;
            if (int.TryParse(CbxEliminar.SelectedValue.ToString(), out idDesarrolladora))
            {
                string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
                string query = "SP_EliminarDesarrolladora";

                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IdDesarrolladora", idDesarrolladora));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Desarrolladora eliminada correctamente.");
                        CargarDesarrolladoras(); // Recargar la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la desarrolladora: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("El ID de la desarrolladora seleccionada no es válido.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}