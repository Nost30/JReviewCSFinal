using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarPlataforma : Form
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
            TxtAgPlata = new TextBox();
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            BtnCerrar = new Button();
            BtnCerrar.Click += new EventHandler(BtnCerrar_Click);
            Label1 = new Label();
            SuspendLayout();
            // 
            // TxtAgPlata
            // 
            TxtAgPlata.Location = new Point(132, 133);
            TxtAgPlata.Name = "TxtAgPlata";
            TxtAgPlata.Size = new Size(100, 23);
            TxtAgPlata.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(50, 197);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(226, 197);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(75, 23);
            BtnCerrar.TabIndex = 2;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(90, 80);
            Label1.Name = "Label1";
            Label1.Size = new Size(177, 15);
            Label1.TabIndex = 3;
            Label1.Text = "Escribe una plataforma de juego";
            // 
            // AgregarPlataforma
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 305);
            Controls.Add(Label1);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtAgPlata);
            Name = "AgregarPlataforma";
            Text = "AgregarPlataforma";
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TxtAgPlata;
        internal Button BtnAgregar;
        internal Button BtnCerrar;
        internal Label Label1;
    }
}