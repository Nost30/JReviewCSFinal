<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarGenero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CbxGene = New System.Windows.Forms.ComboBox()
        Me.TxtGenEdit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciona el genero del juego"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lo llamaras..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CbxGene
        '
        Me.CbxGene.FormattingEnabled = True
        Me.CbxGene.Location = New System.Drawing.Point(141, 77)
        Me.CbxGene.Name = "CbxGene"
        Me.CbxGene.Size = New System.Drawing.Size(121, 23)
        Me.CbxGene.TabIndex = 4
        '
        'TxtGenEdit
        '
        Me.TxtGenEdit.Location = New System.Drawing.Point(141, 177)
        Me.TxtGenEdit.Name = "TxtGenEdit"
        Me.TxtGenEdit.Size = New System.Drawing.Size(100, 23)
        Me.TxtGenEdit.TabIndex = 5
        '
        'EditarGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 292)
        Me.Controls.Add(Me.TxtGenEdit)
        Me.Controls.Add(Me.CbxGene)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarGenero"
        Me.Text = "EditarGenero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CbxGene As ComboBox
    Friend WithEvents TxtGenEdit As TextBox
End Class
