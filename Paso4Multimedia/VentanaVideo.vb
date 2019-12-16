Public Class VentanaVideo

    Dim Valor As Integer

    Public Sub New(i As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Valor = i
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub VentanaVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Valor
            Case VentanaInicio.VENTANA_MYSQL
                Dim vMySQL As New VentanaMySQL()
                vMySQL.Show()
                Dispose()
            Case VentanaInicio.VENTANA_PYTHON
                Dim vPython As New VentanaPython()
                vPython.Show()
                Dispose()
            Case VentanaInicio.VENTANA_SCRUM
                Dim vScrum As New VentanaScrum()
                vScrum.Show()
                Dispose()
        End Select

    End Sub

    Private Sub VentanaVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Valor
            Case VentanaInicio.VENTANA_MYSQL
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\SubConsultas.mp4"
            Case VentanaInicio.VENTANA_PYTHON
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\python.mp4"
            Case VentanaInicio.VENTANA_SCRUM
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\Scrum.mp4"
        End Select
    End Sub
End Class