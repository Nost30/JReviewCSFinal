<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarGenero
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
        Me.TxtAgGenero = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar genero"
        '
        'TxtAgGenero
        '
        Me.TxtAgGenero.Location = New System.Drawing.Point(107, 91)
        Me.TxtAgGenero.Name = "TxtAgGenero"
        Me.TxtAgGenero.Size = New System.Drawing.Size(75, 23)
        Me.TxtAgGenero.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(55, 152)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Aceptar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(181, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AgregarGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 213)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtAgGenero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarGenero"
        Me.Text = "AgregarGenero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAgGenero As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Button2 As Button
End Class
