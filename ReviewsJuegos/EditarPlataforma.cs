using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ReviewsJuegos
{

    public partial class EditarPlataforma
    {
        public EditarPlataforma()
        {
            InitializeComponent();
        }

        private void EditarPlataforma_Load(object sender, EventArgs e)
        {
            CargarPlataformas();

        }

        private void CargarPlataformas()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SELECT Id, NombrePlataforma FROM Plataforma";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();

                adapter.Fill(table);

                Cbxplataf.DisplayMember = "NombrePlataforma";
                Cbxplataf.ValueMember = "Id";
                Cbxplataf.DataSource = table;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Cbxplataf.SelectedIndex != -1 & !string.IsNullOrEmpty(TxtPlatafEdit.Text))
            {
                int idPlataforma = Conversions.ToInteger(Cbxplataf.SelectedValue);
                string nuevoNombre = TxtPlatafEdit.Text;

                ActualizarNombrePlataforma(idPlataforma, nuevoNombre);
            }
            else
            {
                MessageBox.Show("Seleccione una plataforma y escriba el nuevo nombre.");
            }
        }

        private void ActualizarNombrePlataforma(int idPlataforma, string nuevoNombre)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            string query = "SP_ActualizarPlataforma";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdPlataforma", idPlataforma);
                command.Parameters.AddWithValue("@NombrePlataforma", nuevoNombre);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Nombre de la Plataforma actualizado correctamente.");
                CargarPlataformas(); // Recargar la lista de desarrolladoras
            }
        }
    }
}