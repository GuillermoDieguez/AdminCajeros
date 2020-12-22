Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class frmautorizacion

    Public bancontraseña As Boolean

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim iidcajero As Integer
    Dim snombrecajero As String

    Private Sub btnaceptarClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        bancontraseña = DevuelveDato("SELECT COUNT(*) tot FROM usuarios WHERE usuario = '" & txtnombreusuario.Text & "' AND PASSWORD = '" & txtcontraseña.Text & "'", _conexionsuperpos)
        If bancontraseña = True Then
            'Guarda linea de log con la autorizacion del corte con advertencias 

            EjecutaComandosql("INSERT INTO logautorizacioncorte SET fecha = '" & Sfecha & "',  idsucursales = " & Sucursallocal & ", idcajero = " & iidcajero & ", nombre = '" & snombrecajero & "', usuario = '" & Snombreusuario & "' ON DUPLICATE KEY UPDATE usuario = '" & Snombreusuario & "'", _conexionforma24)
            Me.Close()
        Else
            lblmensaje.Visible = True
            txtnombreusuario.Focus()
        End If
    End Sub

    Private Sub frmautorizacionLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _conexionsuperpos.ConnectionString = Sconexionsuperpos
        _conexionforma24.ConnectionString = Sconexiondbforma24

        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.login.GetHicon())
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))

        btnaceptar.Image = My.Resources.aceptarlogin
        btncancelar.Image = My.Resources.cancelarlogin

        iidcajero = frmcorte.lblcajero.Text.Substring(0, frmcorte.lblcajero.Text.IndexOf(" "))
        snombrecajero = Trim(frmcorte.lblcajero.Text.Substring(frmcorte.lblcajero.Text.IndexOf(" ")))

        AddHandler txtnombreusuario.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
        AddHandler txtcontraseña.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
    End Sub

    Private Sub btncancelarClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        bancontraseña = False
        Me.Close()
    End Sub

    Private Sub txtTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombreusuario.TextChanged, txtcontraseña.TextChanged
        lblmensaje.Visible = False
    End Sub

End Class