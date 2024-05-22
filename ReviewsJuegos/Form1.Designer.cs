using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
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

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridView1 = new DataGridView();
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            BtnBuscar = new Button();
            BtnBuscar.Click += new EventHandler(BtnBuscar_Click);
            ComboBoxJuego = new ComboBox();
            ComboBoxJuego.SelectedIndexChanged += new EventHandler(ComboBoxJuego_SelectedIndexChanged);
            TxtJuego = new TextBox();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Label2 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(btnEliminarJuego_Click);
            TxtId = new TextBox();
            TxtId.TextChanged += new EventHandler(TxtId_TextChanged);
            Label3 = new Label();
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnRefrescar = new Button();
            BtnRefrescar.Click += new EventHandler(BtnRefrescar_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            BtnAgregarPlata = new Button();
            BtnAgregarPlata.Click += new EventHandler(BtnAgregarPlata_Click);
            BtnAgDesarrolladora = new Button();
            BtnAgDesarrolladora.Click += new EventHandler(BtnAgDesarrolladora_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(48, 165);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.Size = new Size(467, 184);
            DataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(48, 395);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(440, 122);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ComboBoxJuego
            // 
            ComboBoxJuego.FormattingEnabled = true;
            ComboBoxJuego.Location = new Point(238, 122);
            ComboBoxJuego.Name = "ComboBoxJuego";
            ComboBoxJuego.Size = new Size(187, 23);
            ComboBoxJuego.TabIndex = 5;
            // 
            // TxtJuego
            // 
            TxtJuego.Location = new Point(112, 122);
            TxtJuego.Name = "TxtJuego";
            TxtJuego.Size = new Size(110, 23);
            TxtJuego.TabIndex = 6;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(48, 367);
            Label1.Name = "Label1";
            Label1.Size = new Size(154, 15);
            Label1.TabIndex = 7;
            Label1.Text = "¿Deseas agregar otro juego?";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(48, 27);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(187, 67);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 8;
            PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(432, 367);
            Label2.Name = "Label2";
            Label2.Size = new Size(83, 15);
            Label2.TabIndex = 9;
            Label2.Text = "Eliminar juego";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(440, 395);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(48, 122);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(41, 23);
            TxtId.TabIndex = 11;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(48, 439);
            Label3.Name = "Label3";
            Label3.Size = new Size(151, 15);
            Label3.TabIndex = 12;
            Label3.Text = "¿Desea actualizar los datos?";
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(48, 457);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 13;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnRefrescar
            // 
            BtnRefrescar.Location = new Point(440, 45);
            BtnRefrescar.Name = "BtnRefrescar";
            BtnRefrescar.Size = new Size(75, 23);
            BtnRefrescar.TabIndex = 14;
            BtnRefrescar.Text = "Refrescar";
            BtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(579, 167);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 44);
            Button1.TabIndex = 15;
            Button1.Text = "Agregar genero";
            Button1.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarPlata
            // 
            BtnAgregarPlata.Location = new Point(579, 215);
            BtnAgregarPlata.Name = "BtnAgregarPlata";
            BtnAgregarPlata.Size = new Size(75, 40);
            BtnAgregarPlata.TabIndex = 16;
            BtnAgregarPlata.Text = "Agregar plataforma";
            BtnAgregarPlata.UseVisualStyleBackColor = true;
            // 
            // BtnAgDesarrolladora
            // 
            BtnAgDesarrolladora.Location = new Point(565, 266);
            BtnAgDesarrolladora.Name = "BtnAgDesarrolladora";
            BtnAgDesarrolladora.Size = new Size(105, 60);
            BtnAgDesarrolladora.TabIndex = 17;
            BtnAgDesarrolladora.Text = "Agregar Desarrolladora";
            BtnAgDesarrolladora.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(694, 266);
            Button2.Name = "Button2";
            Button2.Size = new Size(91, 60);
            Button2.TabIndex = 18;
            Button2.Text = "Eliminar desarrolladora";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(694, 215);
            Button3.Name = "Button3";
            Button3.Size = new Size(91, 38);
            Button3.TabIndex = 19;
            Button3.Text = "Eliminar plataforma";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Location = new Point(696, 170);
            Button4.Name = "Button4";
            Button4.Size = new Size(89, 39);
            Button4.TabIndex = 20;
            Button4.Text = "Eliminar genero";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Location = new Point(814, 271);
            Button7.Name = "Button7";
            Button7.Size = new Size(97, 50);
            Button7.TabIndex = 23;
            Button7.Text = "Editar Desarrolladora";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Location = new Point(822, 215);
            Button5.Name = "Button5";
            Button5.Size = new Size(89, 38);
            Button5.TabIndex = 24;
            Button5.Text = "Editar plataforma";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Location = new Point(815, 170);
            Button6.Name = "Button6";
            Button6.Size = new Size(89, 39);
            Button6.TabIndex = 25;
            Button6.Text = "Editar genero";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = BtnBuscar;
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(943, 516);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button7);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(BtnAgDesarrolladora);
            Controls.Add(BtnAgregarPlata);
            Controls.Add(Button1);
            Controls.Add(BtnRefrescar);
            Controls.Add(BtnActualizar);
            Controls.Add(Label3);
            Controls.Add(TxtId);
            Controls.Add(BtnEliminar);
            Controls.Add(Label2);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Controls.Add(TxtJuego);
            Controls.Add(ComboBoxJuego);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Button BtnAgregar;
        internal Button BtnBuscar;
        internal ComboBox ComboBoxJuego;
        internal TextBox TxtJuego;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label Label2;
        internal Button BtnEliminar;
        internal TextBox TxtId;
        internal Label Label3;
        internal Button BtnActualizar;
        internal Button BtnRefrescar;
        internal Button Button1;
        internal Button BtnAgregarPlata;
        internal Button BtnAgDesarrolladora;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button7;
        internal Button Button5;
        internal Button Button6;
    }
}