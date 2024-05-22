using System;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text;
            string password = TxtContra.Text;

            // Aquí deberías tener código para verificar las credenciales.
            // Esto podría involucrar la comparación con una base de datos, un archivo de texto, etc.
            // Aquí tienes un ejemplo muy básico:

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Inicio de sesión exitoso");

                var ReviewsJuegos = new Form1();
                ReviewsJuegos.Show();

                Hide(); // Cierra el formulario de inicio de sesión
            }

            else
            {

                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }
    }
}