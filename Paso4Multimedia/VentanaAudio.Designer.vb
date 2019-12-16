<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaAudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaAudio))
        Me.ReproductorAudio = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.ReproductorAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReproductorAudio
        '
        Me.ReproductorAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReproductorAudio.Enabled = True
        Me.ReproductorAudio.Location = New System.Drawing.Point(0, 0)
        Me.ReproductorAudio.Name = "ReproductorAudio"
        Me.ReproductorAudio.OcxState = CType(resources.GetObject("ReproductorAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ReproductorAudio.Size = New System.Drawing.Size(453, 83)
        Me.ReproductorAudio.TabIndex = 0
        '
        'VentanaAudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 83)
        Me.Controls.Add(Me.ReproductorAudio)
        Me.Name = "VentanaAudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaAudio"
        CType(Me.ReproductorAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReproductorAudio As AxWMPLib.AxWindowsMediaPlayer
End Class
