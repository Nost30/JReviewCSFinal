using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarGenero : Form
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
            TxtAgGenero = new TextBox();
            TxtAgGenero.TextChanged += new EventHandler(TxtAgGenero_TextChanged);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(93, 43);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Agregar genero";
            // 
            // TxtAgGenero
            // 
            TxtAgGenero.Location = new Point(107, 91);
            TxtAgGenero.Name = "TxtAgGenero";
            TxtAgGenero.Size = new Size(75, 23);
            TxtAgGenero.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(55, 152);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 2;
            BtnAgregar.Text = "Aceptar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(181, 152);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Cerrar";
            Button2.UseVisualStyleBackColor = true;
            // 
            // AgregarGenero
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 213);
            Controls.Add(Button2);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtAgGenero);
            Controls.Add(Label1);
            Name = "AgregarGenero";
            Text = "AgregarGenero";
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox TxtAgGenero;
        internal Button BtnAgregar;
        internal Button Button2;
    }
}