Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class Frmlogin

    ReadOnly _dsconexion As New DataSet
    ReadOnly _conexionsuperpos As New MySqlConnection

    Private Sub FrmloginLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _dsconexion.ReadXml(Application.StartupPath & "\arconexion.xml")
        Sconexionsuperpos = "server=" & _dsconexion.Tables(0).Rows(1)(0) & "; initial catalog=" & _dsconexion.Tables(0).Rows(1)(1) & "; user id=" & _dsconexion.Tables(0).Rows(1)(2) & "; password=" & DesencriptarCadena(_dsconexion.Tables(0).Rows(1)(3)) & "; port=" & _dsconexion.Tables(0).Rows(1)(4) & ";"
        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        'Configura el color del formulario y la imagen de los botones
        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.login.GetHicon())
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))

        btnaceptar.Image = My.Resources.aceptarlogin
        btncancelar.Image = My.Resources.cancelarlogin

        AddHandler txtnombreusuario.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
        AddHandler txtcontraseña.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
    End Sub

    Private Sub BtnaceptarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnaceptar.Click
        'Verifica el nombre, contraseña y el nivel del usuario 
        Dim drtemp As DataRow

        If txtcontraseña.Text.Length > 0 And txtnombreusuario.Text.Length > 0 Then
            drtemp = DevuelveFila("SELECT id FROM usuarios WHERE activo = 1 AND idnivel = 2 AND usuario = '" & Trim(txtnombreusuario.Text.ToUpper) & "' AND PASSWORD = '" & Trim(txtcontraseña.Text) & "'", _conexionsuperpos)
            If Not drtemp Is Nothing Then
                Idusuario = drtemp("id")
                Visible = False
                Frmmenu.Show()
            Else
                txtnombreusuario.Clear()
                txtcontraseña.Clear()
                txtnombreusuario.Focus()
                MessageBox.Show("Nombre de usuario o contraseña incorrecta", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            txtnombreusuario.Focus()
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        End
    End Sub

End Class