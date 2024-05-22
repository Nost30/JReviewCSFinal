using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FormularioActualizar : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(btnActualizarJuego_Click);
            TxtIdJuego = new TextBox();
            TxtNombreJuego = new TextBox();
            TxtNumJugadores = new TextBox();
            TxtMetascore = new TextBox();
            TxtPuntajeUsuario = new TextBox();
            ComboBoxGenero = new ComboBox();
            ComboBoxDesarrolladora = new ComboBox();
            ComboBoxPlataforma = new ComboBox();
            DTTFechaLanzamiento = new DateTimePicker();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(78, 59);
            Label1.Name = "Label1";
            Label1.Size = new Size(17, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Id";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(77, 116);
            Label2.Name = "Label2";
            Label2.Size = new Size(104, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre del Juego";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(77, 184);
            Label3.Name = "Label3";
            Label3.Size = new Size(45, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Genero";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(78, 242);
            Label4.Name = "Label4";
            Label4.Size = new Size(83, 15);
            Label4.TabIndex = 3;
            Label4.Text = "Desarrolladora";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(78, 302);
            Label5.Name = "Label5";
            Label5.Size = new Size(65, 15);
            Label5.TabIndex = 4;
            Label5.Text = "Plataforma";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(342, 60);
            Label6.Name = "Label6";
            Label6.Size = new Size(122, 15);
            Label6.TabIndex = 5;
            Label6.Text = "Fecha de lanzamiento";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(342, 107);
            Label7.Name = "Label7";
            Label7.Size = new Size(122, 15);
            Label7.TabIndex = 6;
            Label7.Text = "Numero de jugadores";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(342, 185);
            Label8.Name = "Label8";
            Label8.Size = new Size(121, 15);
            Label8.TabIndex = 7;
            Label8.Text = "Puntaje de metascore";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(342, 243);
            Label9.Name = "Label9";
            Label9.Size = new Size(90, 15);
            Label9.TabIndex = 8;
            Label9.Text = "Puntaje Usuario";
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(529, 201);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 10;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // TxtIdJuego
            // 
            TxtIdJuego.Location = new Point(77, 78);
            TxtIdJuego.Name = "TxtIdJuego";
            TxtIdJuego.Size = new Size(100, 23);
            TxtIdJuego.TabIndex = 11;
            // 
            // TxtNombreJuego
            // 
            TxtNombreJuego.Location = new Point(77, 134);
            TxtNombreJuego.Name = "TxtNombreJuego";
            TxtNombreJuego.Size = new Size(100, 23);
            TxtNombreJuego.TabIndex = 12;
            // 
            // TxtNumJugadores
            // 
            TxtNumJugadores.Location = new Point(342, 135);
            TxtNumJugadores.Name = "TxtNumJugadores";
            TxtNumJugadores.Size = new Size(100, 23);
            TxtNumJugadores.TabIndex = 17;
            // 
            // TxtMetascore
            // 
            TxtMetascore.Location = new Point(342, 203);
            TxtMetascore.Name = "TxtMetascore";
            TxtMetascore.Size = new Size(100, 23);
            TxtMetascore.TabIndex = 18;
            // 
            // TxtPuntajeUsuario
            // 
            TxtPuntajeUsuario.Location = new Point(342, 261);
            TxtPuntajeUsuario.Name = "TxtPuntajeUsuario";
            TxtPuntajeUsuario.Size = new Size(100, 23);
            TxtPuntajeUsuario.TabIndex = 19;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(76, 210);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(121, 23);
            ComboBoxGenero.TabIndex = 21;
            // 
            // ComboBoxDesarrolladora
            // 
            ComboBoxDesarrolladora.FormattingEnabled = true;
            ComboBoxDesarrolladora.Location = new Point(77, 271);
            ComboBoxDesarrolladora.Name = "ComboBoxDesarrolladora";
            ComboBoxDesarrolladora.Size = new Size(121, 23);
            ComboBoxDesarrolladora.TabIndex = 22;
            // 
            // ComboBoxPlataforma
            // 
            ComboBoxPlataforma.FormattingEnabled = true;
            ComboBoxPlataforma.Location = new Point(77, 342);
            ComboBoxPlataforma.Name = "ComboBoxPlataforma";
            ComboBoxPlataforma.Size = new Size(121, 23);
            ComboBoxPlataforma.TabIndex = 23;
            // 
            // DTTFechaLanzamiento
            // 
            DTTFechaLanzamiento.Location = new Point(342, 81);
            DTTFechaLanzamiento.Name = "DTTFechaLanzamiento";
            DTTFechaLanzamiento.Size = new Size(200, 23);
            DTTFechaLanzamiento.TabIndex = 24;
            // 
            // FormularioActualizar
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(DTTFechaLanzamiento);
            Controls.Add(ComboBoxPlataforma);
            Controls.Add(ComboBoxDesarrolladora);
            Controls.Add(ComboBoxGenero);
            Controls.Add(TxtPuntajeUsuario);
            Controls.Add(TxtMetascore);
            Controls.Add(TxtNumJugadores);
            Controls.Add(TxtNombreJuego);
            Controls.Add(TxtIdJuego);
            Controls.Add(BtnActualizar);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "FormularioActualizar";
            Text = "FormularioActualizar";
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Button BtnActualizar;
        internal TextBox TxtIdJuego;
        internal TextBox TxtNombreJuego;
        internal TextBox TxtNumJugadores;
        internal TextBox TxtMetascore;
        internal TextBox TxtPuntajeUsuario;
        internal ComboBox ComboBoxGenero;
        internal ComboBox ComboBoxDesarrolladora;
        internal ComboBox ComboBoxPlataforma;
        internal DateTimePicker DTTFechaLanzamiento;
    }
}