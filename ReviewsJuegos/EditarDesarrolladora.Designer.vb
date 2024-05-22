<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarDesarrolladora
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
        Me.CbxDesa = New System.Windows.Forms.ComboBox()
        Me.TxtDesaEdit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busca una desarrolladora"
        '
        'CbxDesa
        '
        Me.CbxDesa.FormattingEnabled = True
        Me.CbxDesa.Location = New System.Drawing.Point(103, 88)
        Me.CbxDesa.Name = "CbxDesa"
        Me.CbxDesa.Size = New System.Drawing.Size(121, 23)
        Me.CbxDesa.TabIndex = 1
        '
        'TxtDesaEdit
        '
        Me.TxtDesaEdit.Location = New System.Drawing.Point(103, 184)
        Me.TxtDesaEdit.Name = "TxtDesaEdit"
        Me.TxtDesaEdit.Size = New System.Drawing.Size(100, 23)
        Me.TxtDesaEdit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¿Como quieres que se llame ahora?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EditarDesarrolladora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 304)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDesaEdit)
        Me.Controls.Add(Me.CbxDesa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarDesarrolladora"
        Me.Text = "EditarDesarrolladora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbxDesa As ComboBox
    Friend WithEvents TxtDesaEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
