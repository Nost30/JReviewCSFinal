using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EliminarPlataforma : Form
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
            CbxPlataf = new ComboBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(117, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(136, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Selecciona la plataforma";
            // 
            // Button1
            // 
            Button1.Location = new Point(66, 158);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Eliminar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(240, 158);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // CbxPlataf
            // 
            CbxPlataf.FormattingEnabled = true;
            CbxPlataf.Location = new Point(117, 87);
            CbxPlataf.Name = "CbxPlataf";
            CbxPlataf.Size = new Size(121, 23);
            CbxPlataf.TabIndex = 3;
            // 
            // EliminarPlataforma
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 248);
            Controls.Add(CbxPlataf);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Name = "EliminarPlataforma";
            Text = "EliminarPlataforma";
            Load += new EventHandler(EliminarPlataforma_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Button Button1;
        internal Button Button2;
        internal ComboBox CbxPlataf;
    }
}