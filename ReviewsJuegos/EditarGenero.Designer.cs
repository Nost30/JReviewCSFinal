using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditarGenero : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            CbxGene = new ComboBox();
            TxtGenEdit = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(141, 44);
            Label1.Name = "Label1";
            Label1.Size = new Size(167, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Selecciona el genero del juego";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(157, 133);
            Label2.Name = "Label2";
            Label2.Size = new Size(76, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Lo llamaras...";
            // 
            // Button1
            // 
            Button1.Location = new Point(58, 234);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Editar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(230, 234);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // CbxGene
            // 
            CbxGene.FormattingEnabled = true;
            CbxGene.Location = new Point(141, 77);
            CbxGene.Name = "CbxGene";
            CbxGene.Size = new Size(121, 23);
            CbxGene.TabIndex = 4;
            // 
            // TxtGenEdit
            // 
            TxtGenEdit.Location = new Point(141, 177);
            TxtGenEdit.Name = "TxtGenEdit";
            TxtGenEdit.Size = new Size(100, 23);
            TxtGenEdit.TabIndex = 5;
            // 
            // EditarGenero
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 292);
            Controls.Add(TxtGenEdit);
            Controls.Add(CbxGene);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "EditarGenero";
            Text = "EditarGenero";
            Load += new EventHandler(EditarGenero_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Button Button1;
        internal Button Button2;
        internal ComboBox CbxGene;
        internal TextBox TxtGenEdit;
    }
}