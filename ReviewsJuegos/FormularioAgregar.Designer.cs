using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FormularioAgregar : Form
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
            TxtJuego = new TextBox();
            TxtNumJugadores = new TextBox();
            TxtMetascore = new TextBox();
            TxtPuntajeUsuario = new TextBox();
            DTTFechaLanzamiento = new DateTimePicker();
            ComboBoxGenero = new ComboBox();
            ComboBoxDesarrolladora = new ComboBox();
            ComboBoxPlataforma = new ComboBox();
            BtnAgregarJuego = new Button();
            BtnAgregarJuego.Click += new EventHandler(BtnAgregarJuego_Click);
            TxtId = new TextBox();
            Label9 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(46, 105);
            Label1.Name = "Label1";
            Label1.Size = new Size(104, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre del Juego";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(46, 166);
            Label2.Name = "Label2";
            Label2.Size = new Size(45, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Genero";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(46, 240);
            Label3.Name = "Label3";
            Label3.Size = new Size(83, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Desarrolladora";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(46, 320);
            Label4.Name = "Label4";
            Label4.Size = new Size(65, 15);
            Label4.TabIndex = 3;
            Label4.Text = "Plataforma";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(343, 44);
            Label5.Name = "Label5";
            Label5.Size = new Size(125, 15);
            Label5.TabIndex = 4;
            Label5.Text = "Fecha de Lanzamiento";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(346, 105);
            Label6.Name = "Label6";
            Label6.Size = new Size(122, 15);
            Label6.TabIndex = 5;
            Label6.Text = "Numero de jugadores";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(347, 179);
            Label7.Name = "Label7";
            Label7.Size = new Size(121, 15);
            Label7.TabIndex = 6;
            Label7.Text = "Puntaje de Metascore";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(347, 259);
            Label8.Name = "Label8";
            Label8.Size = new Size(106, 15);
            Label8.TabIndex = 7;
            Label8.Text = "Puntaje de Usuario";
            // 
            // TxtJuego
            // 
            TxtJuego.Location = new Point(50, 123);
            TxtJuego.Name = "TxtJuego";
            TxtJuego.Size = new Size(100, 23);
            TxtJuego.TabIndex = 8;
            // 
            // TxtNumJugadores
            // 
            TxtNumJugadores.Location = new Point(346, 143);
            TxtNumJugadores.Name = "TxtNumJugadores";
            TxtNumJugadores.Size = new Size(100, 23);
            TxtNumJugadores.TabIndex = 9;
            // 
            // TxtMetascore
            // 
            TxtMetascore.Location = new Point(343, 217);
            TxtMetascore.Name = "TxtMetascore";
            TxtMetascore.Size = new Size(100, 23);
            TxtMetascore.TabIndex = 10;
            // 
            // TxtPuntajeUsuario
            // 
            TxtPuntajeUsuario.Location = new Point(346, 289);
            TxtPuntajeUsuario.Name = "TxtPuntajeUsuario";
            TxtPuntajeUsuario.Size = new Size(100, 23);
            TxtPuntajeUsuario.TabIndex = 11;
            // 
            // DTTFechaLanzamiento
            // 
            DTTFechaLanzamiento.Location = new Point(346, 72);
            DTTFechaLanzamiento.Name = "DTTFechaLanzamiento";
            DTTFechaLanzamiento.Size = new Size(200, 23);
            DTTFechaLanzamiento.TabIndex = 12;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(46, 204);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(121, 23);
            ComboBoxGenero.TabIndex = 13;
            // 
            // ComboBoxDesarrolladora
            // 
            ComboBoxDesarrolladora.FormattingEnabled = true;
            ComboBoxDesarrolladora.Location = new Point(46, 278);
            ComboBoxDesarrolladora.Name = "ComboBoxDesarrolladora";
            ComboBoxDesarrolladora.Size = new Size(121, 23);
            ComboBoxDesarrolladora.TabIndex = 14;
            // 
            // ComboBoxPlataforma
            // 
            ComboBoxPlataforma.FormattingEnabled = true;
            ComboBoxPlataforma.Location = new Point(46, 350);
            ComboBoxPlataforma.Name = "ComboBoxPlataforma";
            ComboBoxPlataforma.Size = new Size(121, 23);
            ComboBoxPlataforma.TabIndex = 15;
            // 
            // BtnAgregarJuego
            // 
            BtnAgregarJuego.Location = new Point(601, 74);
            BtnAgregarJuego.Name = "BtnAgregarJuego";
            BtnAgregarJuego.Size = new Size(75, 23);
            BtnAgregarJuego.TabIndex = 16;
            BtnAgregarJuego.Text = "Agregar";
            BtnAgregarJuego.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(46, 58);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 17;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(46, 40);
            Label9.Name = "Label9";
            Label9.Size = new Size(17, 15);
            Label9.TabIndex = 18;
            Label9.Text = "Id";
            // 
            // FormularioAgregar
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label9);
            Controls.Add(TxtId);
            Controls.Add(BtnAgregarJuego);
            Controls.Add(ComboBoxPlataforma);
            Controls.Add(ComboBoxDesarrolladora);
            Controls.Add(ComboBoxGenero);
            Controls.Add(DTTFechaLanzamiento);
            Controls.Add(TxtPuntajeUsuario);
            Controls.Add(TxtMetascore);
            Controls.Add(TxtNumJugadores);
            Controls.Add(TxtJuego);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "FormularioAgregar";
            Text = "FormularioAgregar";
            Load += new EventHandler(Form1_Load);
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
        internal TextBox TxtJuego;
        internal TextBox TxtNumJugadores;
        internal TextBox TxtMetascore;
        internal TextBox TxtPuntajeUsuario;
        internal DateTimePicker DTTFechaLanzamiento;
        internal ComboBox ComboBoxGenero;
        internal ComboBox ComboBoxDesarrolladora;
        internal ComboBox ComboBoxPlataforma;
        internal Button BtnAgregarJuego;
        internal TextBox TxtId;
        internal Label Label9;
    }
}