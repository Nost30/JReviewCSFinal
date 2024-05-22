using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviewsJuegos
{

    public partial class Form1
    {
        private string query;
        private bool auto;
        // Create a constructor
        public Form1()
        {
            auto = true;
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            query = "SELECT id,Genero FROM Genero";
            ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxJuego.DisplayMember = "Genero";
            ComboBoxJuego.ValueMember = "id";
            auto = false;
            DataGridView1.ReadOnly = true;

            query = "SELECT * FROM VW_JuegoReview";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);



        }





        private void ComboBoxJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxJuego.Text is null)
            {
                return;
            }
            query = @"SELECT * FROM VW_JuegoReview
where Genero='" + ComboBoxJuego.Text + "'";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = TxtJuego.Text.Trim();
            string query = "";
            query = @"SELECT * FROM VW_JuegoReview
WHERE nombrejuego LIKE '%" + buscarTexto + "%'";
            // Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
            var dt = ConexionSQL.SelectQuery(query);

            DataGridView1.DataSource = dt;



        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            int buscarId;

            // Verificar si el texto en el TxtId es un número válido
            if (int.TryParse(TxtId.Text.Trim(), out buscarId))
            {
                // Iterar sobre las filas del DataGridView para encontrar la que corresponde al ID buscado
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["IdJuego"].Value) == buscarId)
                    {
                        // Seleccionar la fila encontrada y salir del bucle
                        DataGridView1.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                // Si el texto no es un número válido, limpiar la selección del DataGridView
                DataGridView1.ClearSelection();
            }
        }


        private void btnEliminarJuego_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                var command = new SqlCommand("SP_EliminarJuego", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Suponiendo que el procedimiento almacenado toma el ID del juego como parámetro
                command.Parameters.AddWithValue("@IdJuego", TxtId.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Juego eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el juego: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView con la lista actualizada de juegos
            query = "SELECT * FROM VW_JuegoReview";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FormularioAgregar.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FormularioActualizar.Show();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            query = "SELECT id,Genero FROM Genero";
            ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxJuego.DisplayMember = "Genero";
            ComboBoxJuego.ValueMember = "id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarGenero.Show();
        }

        private void BtnAgregarPlata_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarPlataforma.Show();
        }

        private void BtnAgDesarrolladora_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AgregarDesarrolladora.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EliminarDesarrolladora.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EliminarPlataforma.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EliminarGenero.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EditarDesarrolladora.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EditarPlataforma.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.EditarGenero.Show();
        }
    }
}