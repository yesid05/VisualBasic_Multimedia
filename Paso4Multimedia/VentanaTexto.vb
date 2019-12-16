Public Class VentanaTexto

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

    Private Sub VentanaTexto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub VentanaTexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Valor
            Case VentanaInicio.VENTANA_MYSQL
                DocumentoPDF.LoadFile("c:\JoseRodrigoRomero\texto\MySql.pdf")
            Case VentanaInicio.VENTANA_PYTHON
                DocumentoPDF.LoadFile("c:\JoseRodrigoRomero\texto\python.pdf")
            Case VentanaInicio.VENTANA_SCRUM
                DocumentoPDF.LoadFile("c:\JoseRodrigoRomero\texto\scrum.pdf")
        End Select
    End Sub
End Class