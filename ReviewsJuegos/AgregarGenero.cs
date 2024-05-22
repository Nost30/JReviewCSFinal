using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ReviewsJuegos
{

    public partial class AgregarGenero
    {
        public AgregarGenero()
        {
            InitializeComponent();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crear parámetros para el procedimiento almacenado
            int IdUsuario = 1;
            var parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@Genero", TxtAgGenero.Text);
            parametros[1] = new SqlParameter("@IdUsuarioCrea ", IdUsuario);




            // Ejecutar el procedimiento almacenado
            ConexionSQL.ExecuteStoredProcedure("SP_AgregarGenero", parametros);
            Interaction.MsgBox("Registro exitoso");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAgGenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}