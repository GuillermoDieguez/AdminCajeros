Module Mdprincipal

#Region "Constantes Colores"

    'Constante colores para UI
    Public ReadOnly Colorformulario As New List(Of Integer)(New Integer() {243, 246, 225})
    Public ReadOnly Colorpanelactivo As New List(Of Integer)(New Integer() {233, 239, 235})
    Public ReadOnly Colorpanelprincipal As New List(Of Integer)(New Integer() {234, 244, 227})
    Public ReadOnly Colortitulo As New List(Of Integer)(New Integer() {202, 216, 122})
    Public ReadOnly Colordetalleef As New List(Of Integer)(New Integer() {223, 235, 249})

    Public Const Scolorcierredia As String = "Khaki"

    Public Const Scolordeposito As String = "Yellow"
    Public Const Scolorcorte As String = "Silver"
    Public Const Scolorretiro As String = "DodgerBlue"

    Public Const Scolorfaltantes As String = "LightGreen"
    Public Const Scolorsobrantes As String = "LightGray"

#End Region

#Region "Constantes Programa"

    'Constantes usadas en el programa
    Public Const Smsgerror As String = "Error"
    Public Const Smsginfo As String = "Informacion"
    Public Const Caracteresvalidos As String = "0123456789."

    Public Const Fpvalidas As String = "'EF', 'TJ'"
    Public Const Idbancoemisorvalidos As String = "0, 1, 2, 4, 5, 6"

#End Region

#Region "Variables Publicas"

    'Variables publicas del programa
    Public Sconexionsuperpos As String
    Public Sconexiondbforma24 As String
    Public Snombreusuario As String
    Public Snombretienda As String
    Public Sfechaserver As String
    Public Sfecha As String

    Public Sucursallocal As Integer
    Public Inivelusuario As Integer
    Public Idusuario As Integer

    Public Ddepositomaximo As Double

#End Region

End Module