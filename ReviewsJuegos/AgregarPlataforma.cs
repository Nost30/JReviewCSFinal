using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ReviewsJuegos
{

    public partial class AgregarPlataforma
    {
        public AgregarPlataforma()
        {
            InitializeComponent();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crear parámetros para el procedimiento almacenado
            int IdUsuario = 1;
            var parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@NombrePlataforma", TxtAgPlata.Text);
            parametros[1] = new SqlParameter("@IdUsuarioCrea ", IdUsuario);




            // Ejecutar el procedimiento almacenado
            ConexionSQL.ExecuteStoredProcedure("SP_AgregarPlataforma", parametros);
            Interaction.MsgBox("Registro exitoso");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}