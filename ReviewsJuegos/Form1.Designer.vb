<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ComboBoxJuego = New System.Windows.Forms.ComboBox()
        Me.TxtJuego = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnRefrescar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAgregarPlata = New System.Windows.Forms.Button()
        Me.BtnAgDesarrolladora = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(467, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(48, 395)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(440, 122)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ComboBoxJuego
        '
        Me.ComboBoxJuego.FormattingEnabled = True
        Me.ComboBoxJuego.Location = New System.Drawing.Point(238, 122)
        Me.ComboBoxJuego.Name = "ComboBoxJuego"
        Me.ComboBoxJuego.Size = New System.Drawing.Size(187, 23)
        Me.ComboBoxJuego.TabIndex = 5
        '
        'TxtJuego
        '
        Me.TxtJuego.Location = New System.Drawing.Point(112, 122)
        Me.TxtJuego.Name = "TxtJuego"
        Me.TxtJuego.Size = New System.Drawing.Size(110, 23)
        Me.TxtJuego.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "¿Deseas agregar otro juego?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Eliminar juego"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(440, 395)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(48, 122)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(41, 23)
        Me.TxtId.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "¿Desea actualizar los datos?"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(48, 457)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnRefrescar
        '
        Me.BtnRefrescar.Location = New System.Drawing.Point(440, 45)
        Me.BtnRefrescar.Name = "BtnRefrescar"
        Me.BtnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefrescar.TabIndex = 14
        Me.BtnRefrescar.Text = "Refrescar"
        Me.BtnRefrescar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Agregar genero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAgregarPlata
        '
        Me.BtnAgregarPlata.Location = New System.Drawing.Point(579, 215)
        Me.BtnAgregarPlata.Name = "BtnAgregarPlata"
        Me.BtnAgregarPlata.Size = New System.Drawing.Size(75, 40)
        Me.BtnAgregarPlata.TabIndex = 16
        Me.BtnAgregarPlata.Text = "Agregar plataforma"
        Me.BtnAgregarPlata.UseVisualStyleBackColor = True
        '
        'BtnAgDesarrolladora
        '
        Me.BtnAgDesarrolladora.Location = New System.Drawing.Point(565, 266)
        Me.BtnAgDesarrolladora.Name = "BtnAgDesarrolladora"
        Me.BtnAgDesarrolladora.Size = New System.Drawing.Size(105, 60)
        Me.BtnAgDesarrolladora.TabIndex = 17
        Me.BtnAgDesarrolladora.Text = "Agregar Desarrolladora"
        Me.BtnAgDesarrolladora.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(694, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 60)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Eliminar desarrolladora"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(694, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 38)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Eliminar plataforma"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(696, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 39)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Eliminar genero"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(814, 271)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 50)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Editar Desarrolladora"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(822, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 38)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Editar plataforma"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(815, 170)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 39)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Editar genero"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(943, 516)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAgDesarrolladora)
        Me.Controls.Add(Me.BtnAgregarPlata)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRefrescar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtJuego)
        Me.Controls.Add(Me.ComboBoxJuego)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents ComboBoxJuego As ComboBox
    Friend WithEvents TxtJuego As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnRefrescar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAgregarPlata As Button
    Friend WithEvents BtnAgDesarrolladora As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
