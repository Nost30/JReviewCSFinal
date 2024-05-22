using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ReviewsJuegos
{

    public partial class EditarGenero
    {
        public EditarGenero()
        {
            InitializeComponent();
        }

        private void EditarGenero_Load(object sender, EventArgs e)
        {
            CargarGeneros();
        }

        private void CargarGeneros()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SELECT Id, Genero FROM Genero";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                adapter.Fill(table);

                CbxGene.DisplayMember = "Genero";
                CbxGene.ValueMember = "Id";
                CbxGene.DataSource = table;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CbxGene.SelectedIndex != -1 & !string.IsNullOrEmpty(TxtGenEdit.Text))
            {
                int idGenero = Conversions.ToInteger(CbxGene.SelectedValue);
                string nuevoNombre = TxtGenEdit.Text;

                ActualizarNombreGenero(idGenero, nuevoNombre);
            }
            else
            {
                MessageBox.Show("Seleccione un género y escriba el nuevo nombre.");
            }
        }

        private void ActualizarNombreGenero(int idGenero, string nuevoNombre)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SP_ActualizarGenero";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdGenero", idGenero);
                command.Parameters.AddWithValue("@NombreGenero", nuevoNombre);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Nombre del género actualizado correctamente.");
                CargarGeneros(); // Recargar la lista de géneros
            }
        }
    }
}