<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPlataforma
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
        Me.TxtAgPlata = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtAgPlata
        '
        Me.TxtAgPlata.Location = New System.Drawing.Point(132, 133)
        Me.TxtAgPlata.Name = "TxtAgPlata"
        Me.TxtAgPlata.Size = New System.Drawing.Size(100, 23)
        Me.TxtAgPlata.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(50, 197)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(226, 197)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Escribe una plataforma de juego"
        '
        'AgregarPlataforma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 305)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtAgPlata)
        Me.Name = "AgregarPlataforma"
        Me.Text = "AgregarPlataforma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAgPlata As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
End Class
