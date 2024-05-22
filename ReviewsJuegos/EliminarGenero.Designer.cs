using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EliminarGenero : Form
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
            CbxGen = new ComboBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(114, 56);
            Label1.Name = "Label1";
            Label1.Size = new Size(115, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Selecciona el genero";
            // 
            // Button1
            // 
            Button1.Location = new Point(65, 166);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Eliminar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(208, 166);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // CbxGen
            // 
            CbxGen.FormattingEnabled = true;
            CbxGen.Location = new Point(108, 101);
            CbxGen.Name = "CbxGen";
            CbxGen.Size = new Size(121, 23);
            CbxGen.TabIndex = 3;
            // 
            // EliminarGenero
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 252);
            Controls.Add(CbxGen);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Name = "EliminarGenero";
            Text = "EliminarGenero";
            Load += new EventHandler(EliminarPlataforma_Load);
            Load += new EventHandler(EliminarGenero_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Button Button1;
        internal Button Button2;
        internal ComboBox CbxGen;
    }
}