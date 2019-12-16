<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaImagen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaImagen))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ListaImagenesMySQL = New System.Windows.Forms.ImageList(Me.components)
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListaImagenesPython = New System.Windows.Forms.ImageList(Me.components)
        Me.ListaImagenesScrum = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(77, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        '
        'ListaImagenesMySQL
        '
        Me.ListaImagenesMySQL.ImageStream = CType(resources.GetObject("ListaImagenesMySQL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenesMySQL.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenesMySQL.Images.SetKeyName(0, "relacion_muchos_a_muchos.png")
        Me.ListaImagenesMySQL.Images.SetKeyName(1, "relacion_uno_a_muchos.png")
        Me.ListaImagenesMySQL.Images.SetKeyName(2, "relacion_uno_a_uno.png")
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(12, 37)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(322, 310)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Imagen.TabIndex = 1
        Me.Imagen.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(385, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Anterior"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListaImagenesPython
        '
        Me.ListaImagenesPython.ImageStream = CType(resources.GetObject("ListaImagenesPython.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenesPython.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenesPython.Images.SetKeyName(0, "python1.jpg")
        Me.ListaImagenesPython.Images.SetKeyName(1, "python2.jpg")
        Me.ListaImagenesPython.Images.SetKeyName(2, "python3.png")
        '
        'ListaImagenesScrum
        '
        Me.ListaImagenesScrum.ImageStream = CType(resources.GetObject("ListaImagenesScrum.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenesScrum.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenesScrum.Images.SetKeyName(0, "scrum1.png")
        Me.ListaImagenesScrum.Images.SetKeyName(1, "scrum2.png")
        Me.ListaImagenesScrum.Images.SetKeyName(2, "scrum3.png")
        '
        'VentanaImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 359)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.Name = "VentanaImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaImagen"
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents ListaImagenesMySQL As ImageList
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListaImagenesPython As ImageList
    Friend WithEvents ListaImagenesScrum As ImageList
End Class
