Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

<System.Serializable()> Public Class Frmretiro

    Const Alturatxt As Integer = 25
    Const Ipuntox As Integer = 4
    Const Ipuntoy As Integer = 45

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim thisDate As String = DateTime.Now

    Dim DIA As Integer = DateTime.Now.ToString("dd")
    Dim MES As Integer = DateTime.Now.ToString("MM")
    Dim AÑO As Integer = DateTime.Now.ToString("yyyy")

    Dim dias As String
    Dim meses As String

    Dim _dsdatos As New DataSet
    Dim _dscajeros As New DataSet

    Dim _idusuarios As Integer

    ReadOnly _lsttxt As New List(Of TextBox)
    ReadOnly _lstlbl As New List(Of Label)
    ReadOnly _lstcodigopago As New List(Of String)

    Dim bancierre As Boolean
    Dim banretirofinalcorte As Boolean

    Private Sub FrmretiroLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _conexionforma24.ConnectionString = Sconexiondbforma24
        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.retiro.GetHicon())

        paneltitulo.BackColor = Color.FromArgb(Colortitulo(0), Colortitulo(1), Colortitulo(2))
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))

        lblfecha.Text = lblfecha.Text & Sfechaserver
        lblcolorcorte.BackColor = Color.FromName(Scolorcorte)
        lblcolorretiro.BackColor = Color.FromName(Scolorretiro)
        btncancelarret.Image = My.Resources.cancelar
        btnmodificarret.Image = My.Resources.modificar
        btnguardarret.Image = My.Resources.grabar
        btncorte.Image = My.Resources.corte

        Actualizardatoscajero()

        'Llena el listbox de cajeros
        _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, validado, conventa, conretiro, conretirofinal, concorte, Condeposito FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY idusuarios ASC", _conexionforma24)
        Llenarlstcajeros(_dscajeros.Tables(0).Select("Condeposito = 1", "nombre ASC"))

        'Llena comboboxcajas
        _dsdatos = LlenarDataset("SELECT numero FROM cajas WHERE idresoluciones <> 0 ORDER BY id ASC ", _conexionsuperpos)
        cmbcajaret.Items.Clear()
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            cmbcajaret.Items.Add(dr("numero"))
        Next

        banretirofinalcorte = DevuelveDato("SELECT banretirofinalcorte FROM parametrosadmincajeros", _conexionforma24)

        Prepararpanelretiro()

        paneldetalleEF.Enabled = False
        panelformaspago.Enabled = False
        cmbcajaret.Enabled = False

        Revisarcierredia()
    End Sub

    Private Sub FrmretiroFormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

#Region "ListView EventHandlers"

    Private Sub LstvcajerosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstvcajeros.SelectedIndexChanged
        Dim icaja As Integer
        Dim dr As DataRow
        Dim dsCajero As DataSet
        Dim recajero As Integer

        'Indica el nombre del cajero en el textbox del panel
        If lstvcajeros.SelectedItems.Count > 0 Then
            BtncancelarretClick(Nothing, Nothing)
            lblnombrecajeroret.Text = lstvcajeros.SelectedItems(0).SubItems(1).Text
            _idusuarios = lblnombrecajeroret.Text.Remove(lblnombrecajeroret.Text.IndexOf(" "))
            dsCajero = LlenarDataset("select Conretirofinal from ctrloperacionescajero WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios, _conexionforma24)
            recajero = Convert.ToInt32(dsCajero.Tables(0).Rows(0).Item(0))


            If (recajero > 0) Then
                btnguardarret.Enabled = False
            Else
                btnguardarret.Enabled = True
            End If


            dr = _dscajeros.Tables(0).Select("idusuarios = " & _idusuarios)(0)
            If dr("concorte") <> True Then
                panelretiro.BackColor = Color.FromArgb(Colorpanelactivo(0), Colorpanelactivo(1), Colorpanelactivo(2))
                paneldetalleEF.BackColor = Color.FromArgb(Colordetalleef(0), Colordetalleef(1), Colordetalleef(2))
                paneldetalleEF.Enabled = True
                panelformaspago.Enabled = False
                cmbcajaret.Enabled = True

                'Obtiene el numero de caja segun el deposito realizado al cajero
                icaja = DevuelveDato("SELECT idcajas FROM detalleparciales WHERE monto > 0 AND codigopago = 'EF' AND idusuarios = " & _idusuarios & " AND fecha = '" & Sfecha & "' LIMIT 1", _conexionsuperpos)
                cmbcajaret.SelectedIndex = cmbcajaret.FindString(icaja)

                If banretirofinalcorte = True Then
                    btncorte.Enabled = dr("conretirofinal")
                End If
            Else
                MessageBox.Show("Ya se le realizo el corte al cajero " & vbCrLf & lblnombrecajeroret.Text & vbCrLf & "No se puede realizar el retiro al cajero", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblnombrecajeroret.Text = ""
            End If
        End If
    End Sub

#End Region

#Region "ComboBox EventHandlers"

    Private Sub CmbcajaretSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbcajaret.SelectedIndexChanged
        paneldetalleEF.Enabled = True
        SendKeys.Send(vbTab)
    End Sub

#End Region

#Region "Botones EventHandlers"

    Private Sub BtnguardarretClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardarret.Click
        If (DIA < 10) Then
            dias = "0" & DIA
        Else
            dias = DIA
        End If

        If (MES < 10) Then
            meses = "0" & MES
        Else
            meses = MES
        End If

        Dim fecha As String = AÑO.ToString & meses & dias

        'Try
        'Dim invocarSincronizadorContingencias As Process = New Process()
        'Dim envioParametros() As String = {fecha, "AdminCajeros"}
        'invocarSincronizadorContingencias.StartInfo.FileName = "C:\UNISUPER\admincajeros\sincronizador\SincroVTS.exe"
        'invocarSincronizadorContingencias.StartInfo.Arguments = envioParametros(0) + " " + envioParametros(1)
        'invocarSincronizadorContingencias.StartInfo.UseShellExecute = False
        'invocarSincronizadorContingencias.StartInfo.CreateNoWindow = True
        'invocarSincronizadorContingencias.Start()
        '
        '
        '       Catch ex As Exception
        'MessageBox.Show("No se encuentra el archivo SincroVTS.exe!")
        'End Try

        Dim banvalor As Integer
        Dim inautoincrement As Integer

        Dim drtemp As DataRow

        If lblnombrecajeroret.Text.Length > 0 Then
            If cmbcajaret.SelectedIndex <> -1 Then
                For Each t As TextBox In _lsttxt
                    If t.Text <> "0.00" And t.Text.Length > 0 Then
                        banvalor = 1
                    End If
                Next

                If banvalor = 1 Then
                    'Confirma que se desea hacer el retiro
                    If MessageBox.Show("Esta seguro que desea hacer el retiro?", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'Valida que no el cajero no tenga corte
                        drtemp = DevuelveFila("SELECT idusuarios,estado FROM totales WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios, _conexionsuperpos)

                        If IsNothing(drtemp) OrElse drtemp("estado") = 1 Then
                            'Segun el numero de texbox contenidos en el list realiza el INSERT en la base de datos
                            For i = 0 To _lsttxt.Count - 1
                                If Val(_lsttxt(i).Text) > 0 Then
                                    'Realiza un insert on duplicate key sobre la tabla detalletotales por cada forma de pago
                                    EjecutaComandosql("INSERT INTO detalletotales (fecha, idusuarios, idsucursales, codigopago, montofisico, montoparciales) VALUES('" & Sfecha & "', " & _idusuarios & ", " & Sucursallocal & ", '" & _lstcodigopago(i) & "', " & -Convert.ToDecimal(_lsttxt(i).Text) & ", " & Convert.ToDecimal(_lsttxt(i).Text) & ") ON DUPLICATE KEY UPDATE montofisico = montofisico - " & Convert.ToDecimal(_lsttxt(i).Text) & ", montoparciales = montoparciales + " & Convert.ToDecimal(_lsttxt(i).Text), _conexionsuperpos)

                                    inautoincrement = DevuelveDato("SELECT id FROM detalletotales WHERE fecha = '" & Sfecha & "' AND idusuarios  =  " & _idusuarios & " AND codigopago = '" & _lstcodigopago(i) & "'", _conexionsuperpos)

                                    'Agrega linea a detalleparciales con el monto de retiro negativo por cada forma de pago
                                    EjecutaComandosql("INSERT INTO detalleparciales (fecha, idusuarios, idsucursales, codigopago, monto, iddetalletotales, fechahora, idcajas, onserver) VALUES ('" & Sfecha & "', " & _idusuarios & ", " & Sucursallocal & ", '" & _lstcodigopago(i) & "', " & -Convert.ToDecimal(_lsttxt(i).Text) & ", " & inautoincrement & ", NOW(), " & cmbcajaret.SelectedItem & ", '1')", _conexionsuperpos)
                                End If
                            Next

                            EjecutaComandosql("UPDATE ctrloperacionescajero SET conretirofinal = 1 WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios, _conexionforma24)
                            btncorte.Enabled = True
                            btnguardarret.Enabled = False
                            MessageBox.Show("Retiro realizado exitosamente", Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Ya se le realizo el corte al cajero, no se puede realizar mas retiros al cajero", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'Actualiza el listview de cajeros
                        Actualizardatoscajero()
                        _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, validado, conventa, conretiro, conretirofinal, concorte, Condeposito FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY idusuarios ASC", _conexionforma24)
                        Llenarlstcajeros(_dscajeros.Tables(0).Select("Condeposito = 1", "nombre ASC"))
                        BtncancelarretClick(Nothing, Nothing)
                    End If
                End If
            Else
                MessageBox.Show("Indique una caja para hacer el Retiro Final", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione un cajero para hacer el Retiro Final", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtncancelarretClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelarret.Click
        'Limpia textbox fp
        For Each temptext In _lsttxt
            temptext.Clear()
        Next

        'Limpia textbox detalle de efectivo
        For Each tempctrl In paneldetalleEF.Controls
            If tempctrl.GetType.ToString = "System.Windows.Forms.TextBox" Then
                tempctrl.Clear()
            End If
            If tempctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                If tempctrl.name.indexof("lbltot") <> -1 Then
                    tempctrl.text = ""
                End If
            End If
        Next

        cmbcajaret.SelectedIndex = -1
        lblnombrecajeroret.Text = ""
        lbltotalmb.Text = ""
        lblcanttotal.Text = ""

        paneldetalleEF.Enabled = False
        panelformaspago.Enabled = False
        cmbcajaret.Enabled = False

        panelretiro.BackColor = BackColor
        paneldetalleEF.BackColor = BackColor
    End Sub

    Private Sub BtnmodificarretClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnmodificarret.Click
        If lblnombrecajeroret.Text.Length > 0 Then
            Frmmodificarretiro.lblnombrecajero.Text = lblnombrecajeroret.Text
            Frmmodificarretiro.ShowDialog(Me)

            'Actualiza el listview de cajeros
            Actualizardatoscajero()
            _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, validado, conventa, conretiro, conretirofinal, concorte FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY idusuarios ASC", _conexionforma24)
            Llenarlstcajeros(_dscajeros.Tables(0).Select("conventa = 1", "nombre ASC"))
            BtncancelarretClick(Nothing, Nothing)
        Else
            MessageBox.Show("Seleccione un cajero", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btncorte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncorte.Click
        If lblnombrecajeroret.Text.Length > 0 Then
            frmcorte.lblcajero.Text = lblnombrecajeroret.Text
            frmcorte.ShowDialog(Me)

            'Actualiza el listview de cajeros 
            Actualizardatoscajero()
            _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, validado, conventa, conretiro, conretirofinal, concorte FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY idusuarios ASC", _conexionforma24)
            Llenarlstcajeros(_dscajeros.Tables(0).Select("conventa = 1", "nombre ASC"))
            BtncancelarretClick(Nothing, Nothing)
        Else
            MessageBox.Show("Seleccione un cajero para hacer el Corte", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "TextBox EventHandlers"

    Private Sub TxtfpKeyDown(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            SendKeys.Send(vbTab)
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Private Sub TxtfpLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim dtotal As Double

        'Convierte al sender en un control para poder saber que txtbox levanto el evento
        Dim ctrltemp As Control = DirectCast(sender, Control)

        'Convierte a decimal la cantidad indicada en el textbox
        'si el texto del textbox solo contiene un punto lo convierto a 0 para evitar errores de conversion
        If ctrltemp.Text.Length > 0 Then
            If ctrltemp.Text <> "." Then
                ctrltemp.Text = Convert.ToDecimal(ctrltemp.Text.Replace(",", ""))
            Else
                ctrltemp.Text = "0"
            End If
        End If

        'Actualiza el label total
        For Each t In _lsttxt
            If t.Text.Length > 0 And t.Text <> "." Then
                dtotal += Convert.ToDecimal(t.Text.Replace(",", ""))
            End If
        Next
        lblcanttotal.Text = String.Format("{0:n}", dtotal)

        'Formatea el texto del textbox actual
        ctrltemp.Text = String.Format("{0:n}", Val(ctrltemp.Text))
    End Sub

    Private Sub TxtbmKeyDown(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtcb200.KeyDown, txtcb100.KeyDown, txtcb50.KeyDown, txtcb20.KeyDown, txtcb10.KeyDown, txtcb5.KeyDown, txtcm1.KeyDown, txtcm50.KeyDown, txtcm25.KeyDown, txtcm10.KeyDown, txtcm5.KeyDown, txtcm001.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Escape Then
            'Envia el foco al siguiente textbox
            If e.KeyCode = Keys.Escape Then
                'Si llega al final del detalle de efectivo regresa el foco al detalle de formas de pago
                panelformaspago.Enabled = True
                _lsttxt.Item(1).Focus()
                _lsttxt.Item(0).Text = lbltotalmb.Text
            Else
                SendKeys.Send(vbTab)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Private Sub TxtbmKeyPress(ByVal sender As Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtcb200.KeyPress, txtcb100.KeyPress, txtcb50.KeyPress, txtcb20.KeyPress, txtcb10.KeyPress, txtcb5.KeyPress, txtcm1.KeyPress, txtcm50.KeyPress, txtcm25.KeyPress, txtcm10.KeyPress, txtcm5.KeyPress, txtcm001.KeyPress
        'Limito el ingreso solo a numeros 
        If (Not Caracteresvalidos.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back)) Or e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtbmLostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtcb200.LostFocus, txtcb100.LostFocus, txtcb50.LostFocus, txtcb20.LostFocus, txtcb10.LostFocus, txtcb5.LostFocus, txtcm1.LostFocus, txtcm50.LostFocus, txtcm25.LostFocus, txtcm10.LostFocus, txtcm5.LostFocus, txtcm001.LostFocus
        Dim dtotal As Double

        'Convierte al sender en un control para poder saber que textbox levanto el evento
        Dim ctrltemp As Control = DirectCast(sender, Control)

        If ctrltemp.Text.Length = 0 Then
            ctrltemp.Text = "0"
        End If

        'Calcula el total segun el control que levanto el evento
        Select Case ctrltemp.Name
            Case "txtcb200"
                lbltotb200.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 200)
            Case "txtcb100"
                lbltotb100.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 100)
            Case "txtcb50"
                lbltotb50.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 50)
            Case "txtcb20"
                lbltotb20.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 20)
            Case "txtcb10"
                lbltotb10.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 10)
            Case "txtcb5"
                lbltotb5.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 5)
            Case "txtcm1"
                lbltotm1.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 1)
            Case "txtcm50"
                lbltotm50.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 0.5)
            Case "txtcm25"
                lbltotm25.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 0.25)
            Case "txtcm10"
                lbltotm10.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 0.1)
            Case "txtcm5"
                lbltotm5.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 0.05)
            Case "txtcm001"
                lbltotm001.Text = String.Format("{0:n}", Val(ctrltemp.Text) * 0.01)
        End Select

        'Actualiza el label total general
        dtotal = (Val(txtcb200.Text) * 200) + (Val(txtcb100.Text) * 100) + (Val(txtcb50.Text) * 50) + (Val(txtcb20.Text) * 20) + (Val(txtcb10.Text) * 10) + (Val(txtcb5.Text) * 5) + (Val(txtcm1.Text) * 1) + (Val(txtcm50.Text) * 0.5) + (Val(txtcm25.Text) * 0.25) + (Val(txtcm10.Text) * 0.1) + (Val(txtcm5.Text) * 0.05) + (Val(txtcm001.Text) * 0.01)
        lbltotalmb.Visible = True
        lbltotalmb.Text = String.Format("{0:n}", dtotal)

        If ctrltemp.Name = "txtcm001" Then
            'Si llega al final del detalle de efectivo envia el foco al detalle de formas de pago
            panelformaspago.Enabled = True

            _lsttxt.Item(1).Focus()
            _lsttxt.Item(0).Text = lbltotalmb.Text
        End If

        If _lsttxt.Item(0).Text.Length > 0 Then
            _lsttxt.Item(0).Text = lbltotalmb.Text
        End If
    End Sub

#End Region

#Region "Funciones"

    Private Sub Llenarlstcajeros(ByVal stable As DataRow())
        'Prepara el listview
        lstvcajeros.View = View.Details
        lstvcajeros.Clear()

        'Crea las columnas del listview
        lstvcajeros.Columns.Add("idusuarios", 0, HorizontalAlignment.Left)
        lstvcajeros.Columns.Add("Nombre", 295, HorizontalAlignment.Left)

        'Ingresa los datos de cada cajero
        For Each dr As DataRow In stable
            Dim ilstcajero As New ListViewItem
            ilstcajero.SubItems.Add(dr("Idusuarios") & " " & dr("Nombre"))

            If dr("conretiro") <> 0 Then
                ilstcajero.BackColor = Color.FromName(Scolorretiro)
            End If
            If dr("concorte") <> 0 Then
                ilstcajero.BackColor = Color.FromName(Scolorcorte)
            End If

            lstvcajeros.Items.Add(ilstcajero)
        Next
    End Sub

    Private Sub Actualizardatoscajero()
        'Obtiene datos de las operaciones realizadas al cajero (venta, deposito, retiro) y los ingreso
        'en la tabla de control 
        _dsdatos = LlenarDataset("SELECT u.id, nombrecompleto, IF(tot.Idusuarios IS NULL,0,1) cv, IF(IFNULL(tot2.montoparciales,0) > 0 , 1, 0) cr, IF(IFNULL(tot2.montodepositos,0) > 0 , 1, 0) cd, IF(IFNULL(tot.estado,1) = 1, 0 ,1) cp FROM usuarios u LEFT JOIN (SELECT idusuarios,estado FROM totales WHERE montototal > 0 AND fecha = '" & Sfecha & "') AS tot ON u.id = tot.IdUsuarios LEFT JOIN (SELECT idusuarios, SUM(montoparciales) montoparciales, SUM(montodepositos) MontoDepositos FROM detalletotales WHERE fecha = '" & Sfecha & "' GROUP BY idusuarios) AS tot2 ON u.id = tot2.idusuarios  WHERE activo = 1 And idnivel = 1 ORDER BY nombrecompleto ASC", _conexionsuperpos)

        _conexionforma24.Open()
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            If Not IsDBNull(dr("id")) Then
                EjecutaComandosql("INSERT INTO ctrloperacionescajero (fecha, idusuarios, nombre, conventa, conretiro, condeposito, concorte) VALUES ('" & Sfecha & "', " & dr("id") & ", '" & dr("nombrecompleto") & "', " & dr("cv") & ", " & dr("cr") & ", " & dr("cd") & ", " & dr("cp") & ") ON DUPLICATE KEY UPDATE conventa = " & dr("cv") & ", conretiro = " & dr("cr") & ", condeposito = " & dr("cd") & ", concorte = " & dr("cp"), _conexionforma24)
            End If
        Next
        _conexionforma24.Close()
    End Sub

    Private Sub Prepararpanelretiro()
        Dim itotformaspago As Integer

        'Obtiene los datos de la forma de pagos para crear el numero de label y textbox correspondientes
        _dsdatos = LlenarDataset("SELECT codigopago,nombre FROM formasdepago ORDER BY orden", _conexionsuperpos)
        _conexionsuperpos.Close()

        lblcanttotal.Text = ""
        _lsttxt.Clear()
        _lstcodigopago.Clear()
        _lstlbl.Clear()

        'Genera dinamicamente los texbox y los label segun la forma de pago, se agregan 
        'al panel formaspago, se calcula dinamicamente la altura del panel formaspago.
        itotformaspago = _dsdatos.Tables(0).Rows.Count
        For i = 0 To itotformaspago - 1
            'Configura el textbox en la posicion, tamaño, alineacion, fuente y nombre correspondiente
            Dim txttemp As TextBox
            txttemp = New TextBox
            With txttemp
                .Name = "txtfp" & i
                .Top = Ipuntoy + (i * Alturatxt)
                .Left = Ipuntox + 205 '185
                .Font = New Font("Microsoft Sans Serif", 13, FontStyle.Regular, GraphicsUnit.Point)
                .Width = 100
                .Height = Alturatxt
                .TextAlign = HorizontalAlignment.Right
                .TabIndex = i
                .BackColor = Color.White
                .BorderStyle = BorderStyle.FixedSingle
            End With

            'Agrega los manejadores de evento para el keypress,keydown y gotfocus del textbox
            'no se agregan los eventos al tipo de pago efectivo (EF) por ser este ingresado desde el detalle de efectivo
            If _dsdatos.Tables(0).Rows(i)("codigopago") <> "EF" Then
                AddHandler txttemp.KeyDown, AddressOf TxtfpKeyDown
                AddHandler txttemp.KeyPress, AddressOf LibForms.LibwineventsH.TxtmontoKeyPress
                AddHandler txttemp.LostFocus, AddressOf TxtfpLostFocus
            Else
                txttemp.ReadOnly = True
            End If

            'Configura el label en la posicion, texto a desplegar, tamaño, fuente y nombre correspondiente
            Dim lbltemp As Label
            lbltemp = New Label
            With lbltemp
                .Name = "lblfp" & i
                .Top = Ipuntoy + 3 + (i * Alturatxt)
                .Left = Ipuntox
                .Font = New Font("Microsoft Sans Serif", 13, FontStyle.Bold, GraphicsUnit.Point)
                .Width = 170
                .Height = Alturatxt - 3
                .Text = _dsdatos.Tables(0).Rows(i)("nombre")
            End With

            'Agrega los controles a los list de textbox, label y el list de codigopago
            _lsttxt.Add(txttemp)
            _lstlbl.Add(lbltemp)
            _lstcodigopago.Add(_dsdatos.Tables(0).Rows(i)("codigopago"))

            'Agrega los controles al panelformaspago del formulario
            panelformaspago.Controls.Add(txttemp)
            panelformaspago.Controls.Add(lbltemp)
        Next

        panelacciones.TabIndex = itotformaspago
        paneldetalleEF.TabIndex = 0
    End Sub

    Private Sub Revisarcierredia()
        bancierre = DevuelveDato("SELECT COUNT(*) tot FROM cierres WHERE fecha = '" & Sfecha & "'", _conexionsuperpos)

        If bancierre = True Then
            btncancelarret.Enabled = False
            btnguardarret.Enabled = False
            btnmodificarret.Enabled = False
            btncorte.Enabled = False

            RemoveHandler lstvcajeros.SelectedIndexChanged, AddressOf LstvcajerosSelectedIndexChanged

            lblfecha.BackColor = Color.FromName(Scolorcierredia)

            MessageBox.Show("Ya se aplico el cierre de dia a la fecha " & Sfechaserver & vbCrLf & "No se puede modificar ningun dato.", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

    Private Sub paneltitulo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles paneltitulo.Paint

    End Sub
End Class