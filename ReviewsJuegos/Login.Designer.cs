using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            TxtUsuario = new TextBox();
            TxtContra = new TextBox();
            Label2 = new Label();
            Label3 = new Label();
            BtnLogin = new Button();
            BtnLogin.Click += new EventHandler(ButtonLogin_Click);
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(121, 74);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContra
            // 
            TxtContra.Location = new Point(121, 143);
            TxtContra.Name = "TxtContra";
            TxtContra.Size = new Size(100, 23);
            TxtContra.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(124, 56);
            Label2.Name = "Label2";
            Label2.Size = new Size(47, 15);
            Label2.TabIndex = 4;
            Label2.Text = "Usuario";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(123, 116);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 15);
            Label3.TabIndex = 5;
            Label3.Text = "Contraseña";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(124, 206);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 306);
            Controls.Add(BtnLogin);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(TxtContra);
            Controls.Add(TxtUsuario);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();

        }
        internal TextBox TxtUsuario;
        internal TextBox TxtContra;
        internal Label Label2;
        internal Label Label3;
        internal Button BtnLogin;
    }
}