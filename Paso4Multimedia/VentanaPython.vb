Public Class VentanaPython

    Private Sub AbrirVentanaVideo()
        Dim vv As New VentanaVideo(VentanaInicio.VENTANA_PYTHON)
        vv.Show()
        Hide()
    End Sub

    Private Sub AbrirVentanaAudio()
        Dim va As New VentanaAudio(VentanaInicio.VENTANA_PYTHON)
        va.Show()
        Hide()
    End Sub

    Private Sub AbrirVentanaTexto()
        Dim vt As New VentanaTexto(VentanaInicio.VENTANA_PYTHON)
        vt.Show()
        Hide()
    End Sub

    Private Sub AbrirVentanaImagen()
        Dim vi As New VentanaImagen(VentanaInicio.VENTANA_PYTHON)
        vi.Show()
        Hide()
    End Sub
    'Video
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Cursor = Cursors.Hand
    End Sub
    'Audio
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        Cursor = Cursors.Hand
    End Sub
    'Texto
    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub Label4_MouseClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        Cursor = Cursors.Hand
    End Sub
    'Imagen
    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        Cursor = Cursors.Hand
    End Sub

    Private Sub VentanaPython_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Cursor = Cursors.Default
    End Sub

    Private Sub VentanaPython_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim vInicio As New VentanaInicio()
        vInicio.Show()
        Dispose()
    End Sub
End Class