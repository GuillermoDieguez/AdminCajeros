Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class Frmmenu

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    ReadOnly _dsconexion As New DataSet

    Dim smenu As String

    Private Sub frmmenu_FormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub FrmmenuLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim tipocambio As Decimal
        Dim drtemp As DataRow

        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.menu.GetHicon())
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))

        pbdeposito.Image = My.Resources.deposito
        pbretiro.Image = My.Resources.retiro
        pbmodificarfp.Image = My.Resources.modificarfp
        pbsalir.Image = My.Resources.salir
        pbreportes.Image = My.Resources.reporte

        Try
            'Configura la aplicacion 
            'Lee el archivo de conexion 
            _dsconexion.ReadXml(Application.StartupPath & "\arconexion.xml")
        Catch ex As Exception
            MessageBox.Show("Hubo un error a la hora de leer la configuración del programa" & vbCrLf & "Comuniquese a sistemas", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        'Configura las variables globales de conexion con la cadena de conexion desencriptada
        Sconexiondbforma24 = "server=" & _dsconexion.Tables(0).Rows(0)(0) & "; initial catalog=" & _dsconexion.Tables(0).Rows(0)(1) & "; user id=" & _dsconexion.Tables(0).Rows(0)(2) & "; password=" & DesencriptarCadena(_dsconexion.Tables(0).Rows(0)(3)) & "; port=" & _dsconexion.Tables(0).Rows(0)(4) & ";"
        Sconexionsuperpos = "server=" & _dsconexion.Tables(0).Rows(1)(0) & "; initial catalog=" & _dsconexion.Tables(0).Rows(1)(1) & "; user id=" & _dsconexion.Tables(0).Rows(1)(2) & "; password=" & DesencriptarCadena(_dsconexion.Tables(0).Rows(1)(3)) & "; port=" & _dsconexion.Tables(0).Rows(1)(4) & ";"

        _conexionsuperpos.ConnectionString = Sconexionsuperpos
        _conexionforma24.ConnectionString = Sconexiondbforma24

        Try
            _conexionsuperpos.Open()
        Catch x As MySqlException
            _conexionsuperpos.Close()
            MessageBox.Show("Error de conexion " & x.Message, Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        'Obtiene la fecha del servidor para los proceso en el sistema
        Sfechaserver = DevuelveDato("SELECT DATE(NOW())", _conexionsuperpos)
        Sfecha = String.Format("{0:yyyy/MM/dd}", CDate(Sfechaserver))

        'Configura las variables globales de sucursallocal y nivel de usuario
        drtemp = DevuelveFila("SELECT id, nombre FROM sucursales WHERE LOCAL = '1'", _conexionsuperpos)
        Sucursallocal = drtemp("id")
        Snombretienda = drtemp("nombre")

        drtemp = DevuelveFila("SELECT idnivel, usuario FROM usuarios WHERE activo = 1 AND id = " & Idusuario, _conexionsuperpos)
        Inivelusuario = drtemp("idnivel")
        Snombreusuario = drtemp("usuario")

        'Obtiene el tipo de cambio del dia y lo inserta en la base de datos dbforma24, siempre y cuando no haya sido insertado antes
        Try
            _conexionforma24.Open()
        Catch x As MySqlException
            _conexionforma24.Close()
            MessageBox.Show("Error de conexion", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        If DevuelveDato("SELECT COUNT(*) tot FROM histtipocambio WHERE fecha = '" & Sfecha & "'", _conexionforma24) = 0 Then
            tipocambio = DevuelveDato("SELECT nombre FROM pagosdetalles WHERE codigopago = 'DL' AND fecha = '" & Sfecha & "' LIMIT 1", _conexionsuperpos)
            If tipocambio > 0 Then
                EjecutaComandosql("INSERT INTO histtipocambio (fecha, tipocambio, usuario) VALUES ('" & Sfecha & "', " & tipocambio & ", '" & Snombreusuario & "')", _conexionforma24)
            End If
        End If

        'Obtiene los parametros para las opciones del menu
        smenu = DevuelveDato("SELECT opcionesmenu FROM parametrosadmincajeros", _conexionforma24)

        _conexionforma24.Close()
        _conexionsuperpos.Close()

        estadopicturebox(smenu(0), pbdeposito, lbldeposito)
        estadopicturebox(smenu(1), pbretiro, lblretiro)
        estadopicturebox(smenu(2), pbmodificarfp, lblmodificarfp)
        estadopicturebox(smenu(3), pbreportes, lblreportes)
    End Sub

#Region "Label EventHandlers"

    Private Sub LbldepositoClick(ByVal sender As Object, ByVal e As EventArgs) Handles lbldeposito.Click, pbdeposito.Click
        Frmdeposito.Show()
    End Sub

    Private Sub LblretiroClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblretiro.Click, pbretiro.Click
        Frmretiro.Show()
    End Sub

    Private Sub LblnmodificarFpClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblmodificarfp.Click, pbmodificarfp.Click
        Frmmodificarfp.Show()
    End Sub

    Private Sub lblreportesClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblreportes.Click, pbreportes.Click
        frmreportes.Show()
    End Sub

    Private Sub lblsalirClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblsalir.Click, pbsalir.Click
        End
    End Sub

#End Region

    Shared Sub estadopicturebox(ByVal sestado As String, ByVal picture As PictureBox, ByVal lbl As Label)

        If sestado = "1" Then
            picture.Enabled = True
            lbl.Enabled = True
        Else
            picture.Enabled = False
            lbl.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmgiftcard.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class