<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaTexto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaTexto))
        Me.DocumentoPDF = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.DocumentoPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentoPDF
        '
        Me.DocumentoPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentoPDF.Enabled = True
        Me.DocumentoPDF.Location = New System.Drawing.Point(0, 0)
        Me.DocumentoPDF.Name = "DocumentoPDF"
        Me.DocumentoPDF.OcxState = CType(resources.GetObject("DocumentoPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DocumentoPDF.Size = New System.Drawing.Size(559, 503)
        Me.DocumentoPDF.TabIndex = 0
        '
        'VentanaTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 503)
        Me.Controls.Add(Me.DocumentoPDF)
        Me.Name = "VentanaTexto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaTexto"
        CType(Me.DocumentoPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentoPDF As AxAcroPDFLib.AxAcroPDF
End Class
