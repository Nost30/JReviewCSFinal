<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioActualizar
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtIdJuego = New System.Windows.Forms.TextBox()
        Me.TxtNombreJuego = New System.Windows.Forms.TextBox()
        Me.TxtNumJugadores = New System.Windows.Forms.TextBox()
        Me.TxtMetascore = New System.Windows.Forms.TextBox()
        Me.TxtPuntajeUsuario = New System.Windows.Forms.TextBox()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDesarrolladora = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPlataforma = New System.Windows.Forms.ComboBox()
        Me.DTTFechaLanzamiento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Juego"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Desarrolladora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Plataforma"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de lanzamiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(342, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Numero de jugadores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(342, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Puntaje de metascore"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Puntaje Usuario"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(529, 201)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtIdJuego
        '
        Me.TxtIdJuego.Location = New System.Drawing.Point(77, 78)
        Me.TxtIdJuego.Name = "TxtIdJuego"
        Me.TxtIdJuego.Size = New System.Drawing.Size(100, 23)
        Me.TxtIdJuego.TabIndex = 11
        '
        'TxtNombreJuego
        '
        Me.TxtNombreJuego.Location = New System.Drawing.Point(77, 134)
        Me.TxtNombreJuego.Name = "TxtNombreJuego"
        Me.TxtNombreJuego.Size = New System.Drawing.Size(100, 23)
        Me.TxtNombreJuego.TabIndex = 12
        '
        'TxtNumJugadores
        '
        Me.TxtNumJugadores.Location = New System.Drawing.Point(342, 135)
        Me.TxtNumJugadores.Name = "TxtNumJugadores"
        Me.TxtNumJugadores.Size = New System.Drawing.Size(100, 23)
        Me.TxtNumJugadores.TabIndex = 17
        '
        'TxtMetascore
        '
        Me.TxtMetascore.Location = New System.Drawing.Point(342, 203)
        Me.TxtMetascore.Name = "TxtMetascore"
        Me.TxtMetascore.Size = New System.Drawing.Size(100, 23)
        Me.TxtMetascore.TabIndex = 18
        '
        'TxtPuntajeUsuario
        '
        Me.TxtPuntajeUsuario.Location = New System.Drawing.Point(342, 261)
        Me.TxtPuntajeUsuario.Name = "TxtPuntajeUsuario"
        Me.TxtPuntajeUsuario.Size = New System.Drawing.Size(100, 23)
        Me.TxtPuntajeUsuario.TabIndex = 19
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Location = New System.Drawing.Point(76, 210)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxGenero.TabIndex = 21
        '
        'ComboBoxDesarrolladora
        '
        Me.ComboBoxDesarrolladora.FormattingEnabled = True
        Me.ComboBoxDesarrolladora.Location = New System.Drawing.Point(77, 271)
        Me.ComboBoxDesarrolladora.Name = "ComboBoxDesarrolladora"
        Me.ComboBoxDesarrolladora.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxDesarrolladora.TabIndex = 22
        '
        'ComboBoxPlataforma
        '
        Me.ComboBoxPlataforma.FormattingEnabled = True
        Me.ComboBoxPlataforma.Location = New System.Drawing.Point(77, 342)
        Me.ComboBoxPlataforma.Name = "ComboBoxPlataforma"
        Me.ComboBoxPlataforma.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxPlataforma.TabIndex = 23
        '
        'DTTFechaLanzamiento
        '
        Me.DTTFechaLanzamiento.Location = New System.Drawing.Point(342, 81)
        Me.DTTFechaLanzamiento.Name = "DTTFechaLanzamiento"
        Me.DTTFechaLanzamiento.Size = New System.Drawing.Size(200, 23)
        Me.DTTFechaLanzamiento.TabIndex = 24
        '
        'FormularioActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.Controls.Add(Me.DTTFechaLanzamiento)
        Me.Controls.Add(Me.ComboBoxPlataforma)
        Me.Controls.Add(Me.ComboBoxDesarrolladora)
        Me.Controls.Add(Me.ComboBoxGenero)
        Me.Controls.Add(Me.TxtPuntajeUsuario)
        Me.Controls.Add(Me.TxtMetascore)
        Me.Controls.Add(Me.TxtNumJugadores)
        Me.Controls.Add(Me.TxtNombreJuego)
        Me.Controls.Add(Me.TxtIdJuego)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioActualizar"
        Me.Text = "FormularioActualizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtIdJuego As TextBox
    Friend WithEvents TxtNombreJuego As TextBox
    Friend WithEvents TxtNumJugadores As TextBox
    Friend WithEvents TxtMetascore As TextBox
    Friend WithEvents TxtPuntajeUsuario As TextBox
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents ComboBoxDesarrolladora As ComboBox
    Friend WithEvents ComboBoxPlataforma As ComboBox
    Friend WithEvents DTTFechaLanzamiento As DateTimePicker
End Class
