﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaVideo))
        Me.ReproductorVideo = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.ReproductorVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReproductorVideo
        '
        Me.ReproductorVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReproductorVideo.Enabled = True
        Me.ReproductorVideo.Location = New System.Drawing.Point(0, 0)
        Me.ReproductorVideo.Name = "ReproductorVideo"
        Me.ReproductorVideo.OcxState = CType(resources.GetObject("ReproductorVideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ReproductorVideo.Size = New System.Drawing.Size(761, 401)
        Me.ReproductorVideo.TabIndex = 0
        '
        'VentanaVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 401)
        Me.Controls.Add(Me.ReproductorVideo)
        Me.Name = "VentanaVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaVideo"
        CType(Me.ReproductorVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReproductorVideo As AxWMPLib.AxWindowsMediaPlayer
End Class
