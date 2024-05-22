using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditarDesarrolladora : Form
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
            CbxDesa = new ComboBox();
            TxtDesaEdit = new TextBox();
            Label2 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(94, 42);
            Label1.Name = "Label1";
            Label1.Size = new Size(139, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Busca una desarrolladora";
            // 
            // CbxDesa
            // 
            CbxDesa.FormattingEnabled = true;
            CbxDesa.Location = new Point(103, 88);
            CbxDesa.Name = "CbxDesa";
            CbxDesa.Size = new Size(121, 23);
            CbxDesa.TabIndex = 1;
            // 
            // TxtDesaEdit
            // 
            TxtDesaEdit.Location = new Point(103, 184);
            TxtDesaEdit.Name = "TxtDesaEdit";
            TxtDesaEdit.Size = new Size(100, 23);
            TxtDesaEdit.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(72, 136);
            Label2.Name = "Label2";
            Label2.Size = new Size(193, 15);
            Label2.TabIndex = 3;
            Label2.Text = "¿Como quieres que se llame ahora?";
            // 
            // Button1
            // 
            Button1.Location = new Point(69, 247);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 4;
            Button1.Text = "Editar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(184, 247);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 5;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // EditarDesarrolladora
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 304);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label2);
            Controls.Add(TxtDesaEdit);
            Controls.Add(CbxDesa);
            Controls.Add(Label1);
            Name = "EditarDesarrolladora";
            Text = "EditarDesarrolladora";
            Load += new EventHandler(ActualizarDesarrolladora_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal ComboBox CbxDesa;
        internal TextBox TxtDesaEdit;
        internal Label Label2;
        internal Button Button1;
        internal Button Button2;
    }
}