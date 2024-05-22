using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EliminarDesarrolladora : Form
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
            CbxEliminar = new ComboBox();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Label1 = new Label();
            SuspendLayout();
            // 
            // CbxEliminar
            // 
            CbxEliminar.FormattingEnabled = true;
            CbxEliminar.Location = new Point(94, 95);
            CbxEliminar.Name = "CbxEliminar";
            CbxEliminar.Size = new Size(121, 23);
            CbxEliminar.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(61, 171);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 1;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(179, 171);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(86, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(129, 15);
            Label1.TabIndex = 3;
            Label1.Text = "Busca la Desarrolladora";
            // 
            // EliminarDesarrolladora
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 228);
            Controls.Add(Label1);
            Controls.Add(Button2);
            Controls.Add(BtnEliminar);
            Controls.Add(CbxEliminar);
            Name = "EliminarDesarrolladora";
            Text = "EliminarDesarrolladora";
            Load += new EventHandler(EliminarDesarrolladora_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal ComboBox CbxEliminar;
        internal Button BtnEliminar;
        internal Button Button2;
        internal Label Label1;
    }
}