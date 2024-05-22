using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ReviewsJuegos
{
    public partial class EditarDesarrolladora
    {
        public EditarDesarrolladora()
        {
            InitializeComponent();
        }

        private void ActualizarDesarrolladora_Load(object sender, EventArgs e)
        {
            CargarDesarrolladoras();
        }

        private void CargarDesarrolladoras()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SELECT Id, Desarrolladora FROM Desarrolladora";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                adapter.Fill(table);

                CbxDesa.DisplayMember = "Desarrolladora";
                CbxDesa.ValueMember = "Id";
                CbxDesa.DataSource = table;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CbxDesa.SelectedIndex != -1 & !string.IsNullOrEmpty(TxtDesaEdit.Text))
            {
                int idDesarrolladora = Conversions.ToInteger(CbxDesa.SelectedValue);
                string nuevoNombre = TxtDesaEdit.Text;

                ActualizarNombreDesarrolladora(idDesarrolladora, nuevoNombre);
            }
            else
            {
                MessageBox.Show("Seleccione una desarrolladora y escriba el nuevo nombre.");
            }
        }

        private void ActualizarNombreDesarrolladora(int idDesarrolladora, string nuevoNombre)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SP_ActualizarDesarrolladora";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdDesarrolladora", idDesarrolladora);
                command.Parameters.AddWithValue("@NombreDesarrolladora", nuevoNombre);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Nombre de la desarrolladora actualizado correctamente.");
                CargarDesarrolladoras(); // Recargar la lista de desarrolladoras
            }
        }
    }
}