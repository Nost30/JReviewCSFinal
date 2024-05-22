<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPlataforma
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
        Me.Cbxplataf = New System.Windows.Forms.ComboBox()
        Me.TxtPlatafEdit = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciona una paltaforma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Como quieres llamarla?"
        '
        'Cbxplataf
        '
        Me.Cbxplataf.FormattingEnabled = True
        Me.Cbxplataf.Location = New System.Drawing.Point(72, 70)
        Me.Cbxplataf.Name = "Cbxplataf"
        Me.Cbxplataf.Size = New System.Drawing.Size(121, 23)
        Me.Cbxplataf.TabIndex = 2
        '
        'TxtPlatafEdit
        '
        Me.TxtPlatafEdit.Location = New System.Drawing.Point(80, 175)
        Me.TxtPlatafEdit.Name = "TxtPlatafEdit"
        Me.TxtPlatafEdit.Size = New System.Drawing.Size(100, 23)
        Me.TxtPlatafEdit.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EditarPlataforma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 290)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPlatafEdit)
        Me.Controls.Add(Me.Cbxplataf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarPlataforma"
        Me.Text = "EditarPlataforma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbxplataf As ComboBox
    Friend WithEvents TxtPlatafEdit As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
