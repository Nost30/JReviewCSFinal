using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EditarPlataforma : Form
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
            Cbxplataf = new ComboBox();
            TxtPlatafEdit = new TextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(72, 34);
            Label1.Name = "Label1";
            Label1.Size = new Size(147, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Selecciona una paltaforma";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(57, 137);
            Label2.Name = "Label2";
            Label2.Size = new Size(136, 15);
            Label2.TabIndex = 1;
            Label2.Text = "¿Como quieres llamarla?";
            // 
            // Cbxplataf
            // 
            Cbxplataf.FormattingEnabled = true;
            Cbxplataf.Location = new Point(72, 70);
            Cbxplataf.Name = "Cbxplataf";
            Cbxplataf.Size = new Size(121, 23);
            Cbxplataf.TabIndex = 2;
            // 
            // TxtPlatafEdit
            // 
            TxtPlatafEdit.Location = new Point(80, 175);
            TxtPlatafEdit.Name = "TxtPlatafEdit";
            TxtPlatafEdit.Size = new Size(100, 23);
            TxtPlatafEdit.TabIndex = 3;
            // 
            // Button1
            // 
            Button1.Location = new Point(37, 218);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 4;
            Button1.Text = "Editar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(155, 218);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 5;
            Button2.Text = "Salir";
            Button2.UseVisualStyleBackColor = true;
            // 
            // EditarPlataforma
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 290);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(TxtPlatafEdit);
            Controls.Add(Cbxplataf);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "EditarPlataforma";
            Text = "EditarPlataforma";
            Load += new EventHandler(EditarPlataforma_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal ComboBox Cbxplataf;
        internal TextBox TxtPlatafEdit;
        internal Button Button1;
        internal Button Button2;
    }
}