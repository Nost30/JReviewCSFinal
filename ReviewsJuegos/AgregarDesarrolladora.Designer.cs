using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarDesarrolladora : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            TxtAgDesarrolladora = new TextBox();
            TxtAgDesarrolladora.TextChanged += new EventHandler(TxtAgDesarrolladora_TextChanged);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(57, 72);
            Label1.Name = "Label1";
            Label1.Size = new Size(185, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Agregar una nueva desarrolladora";
            // 
            // Button1
            // 
            Button1.Location = new Point(35, 170);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Agregar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(167, 170);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Cerrar";
            Button2.UseVisualStyleBackColor = true;
            // 
            // TxtAgDesarrolladora
            // 
            TxtAgDesarrolladora.Location = new Point(87, 116);
            TxtAgDesarrolladora.Name = "TxtAgDesarrolladora";
            TxtAgDesarrolladora.Size = new Size(100, 23);
            TxtAgDesarrolladora.TabIndex = 3;
            // 
            // AgregarDesarrolladora
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 266);
            Controls.Add(TxtAgDesarrolladora);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Name = "AgregarDesarrolladora";
            Text = "AgregarDesarrolladora";
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Button Button1;
        internal Button Button2;
        internal TextBox TxtAgDesarrolladora;
    }
}