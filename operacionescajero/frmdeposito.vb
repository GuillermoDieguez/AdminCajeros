Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class Frmdeposito

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim _dsdatos As New DataSet
    Dim _dscajeros As New DataSet

    Dim _idusuarios As Integer
    Dim _inautoincrement As Integer
    Dim _iiddeposito As Integer
    Dim _bandeposito As Integer

    Dim _dcantidadanterior As Decimal

    Dim _snombrecajero As String

    Dim bancierre As Boolean

    Private Sub FrmdepositoFormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub FrmdepositoLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim drtemp As DataRow

        _conexionforma24.ConnectionString = Sconexiondbforma24
        _conexionsuperpos.ConnectionString = Sconexionsuperpos
        paneltitulo.BackColor = Color.FromArgb(Colortitulo(0), Colortitulo(1), Colortitulo(2))
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))
        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.deposito.GetHicon())

        lblfecha.Text = lblfecha.Text & Sfechaserver
        lblcolorcorte.BackColor = Color.FromName(Scolorcorte)
        lblcolordeposito.BackColor = Color.FromName(Scolordeposito)
        btncancelardep.Image = My.Resources.cancelar
        btnmodificardep.Image = My.Resources.modificar
        btnguardardep.Image = My.Resources.grabar

        Actualizardatoscajero()

        'Llena el listbox de cajeros
        _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, condeposito, concorte FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY nombre ASC", _conexionforma24)
        Llenarlstcajeros(_dscajeros.Tables(0).Select("idusuarios = idusuarios", "nombre ASC"))

        'Llena comboboxcajas
        _dsdatos = LlenarDataset("SELECT numero FROM cajas WHERE idresoluciones <> 0 ORDER BY id ASC ", _conexionsuperpos)
        cmbcajadep.Items.Clear()
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            cmbcajadep.Items.Add(dr("numero"))
        Next

        drtemp = DevuelveFila("SELECT bandeposito, depositomaximo, depositopred FROM parametrosadmincajeros", _conexionforma24)
        If drtemp("bandeposito") <> 0 Then
            'Obtiene de la tabla parametros el valor maximo para el deposito
            Ddepositomaximo = drtemp("depositomaximo")
            _bandeposito = 1
        Else
            txtmontodep.Text = drtemp("depositopred")

            'Asigna valor alto a depositomaximo para que permita el ingreso del deposito predeterminado
            Ddepositomaximo = 100000000
            txtmontodep.ReadOnly = True
        End If

        btnmodificardep.Enabled = True
        Revisarcierredia()

        AddHandler txtmontodep.KeyDown, AddressOf LibForms.LibwineventsH.TxtmontoKeyDown
        AddHandler txtmontodep.KeyPress, AddressOf LibForms.LibwineventsH.TxtmontoKeyPress
        AddHandler txtmontodep.LostFocus, AddressOf LibForms.LibwineventsH.TxtmontoLostFocus
    End Sub

    Private Sub LstvcajerosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstvcajeros.SelectedIndexChanged
        Dim dr As DataRow
        'Indica el nombre del cajero en el textbox del panel
        If lstvcajeros.SelectedItems.Count > 0 Then
            lblnombrecajerodep.Text = lstvcajeros.SelectedItems(0).SubItems(0).Text
            _idusuarios = lblnombrecajerodep.Text.Remove(lblnombrecajerodep.Text.IndexOf(" "))
            _snombrecajero = lblnombrecajerodep.Text.Remove(0, lblnombrecajerodep.Text.IndexOf(" ") + 1)

            'Llena el dataset con los datos de depositos
            _dsdatos = LlenarDataset("SELECT dp.id did, idcajas Caja, fecha Fecha, u.id ID, u.nombrecompleto Nombre, monto Monto, fechahora FechaHora FROM detalleparciales dp INNER JOIN usuarios u ON dp.idusuarios  = u.id WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios & "  AND codigopago = 'EF' AND monto > 0", _conexionsuperpos)
            dgdatosdep.DataSource = _dsdatos.Tables(0)

            'Formatea el grid 
            With dgdatosdep
                .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)

                .Columns("did").Visible = False
                .Columns("Monto").DefaultCellStyle.Format = "n"
                .Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            dr = _dscajeros.Tables(0).Select("idusuarios = " & _idusuarios)(0)
            If dr("concorte") <> True And dr("condeposito") <> True Then
                paneldeposito.BackColor = Color.FromArgb(Colorpanelactivo(0), Colorpanelactivo(1), Colorpanelactivo(2))
                btnmodificardep.Enabled = False

                If _bandeposito <> 0 Then
                    txtmontodep.Clear()
                End If

                cmbcajadep.SelectedIndex = -1
                cmbcajadep.Enabled = True

                If bancierre = False Then
                    btnguardardep.Enabled = True
                End If
            ElseIf dr("concorte") = True Then
                MessageBox.Show("Ya se le realizo el corte al cajero " & vbCrLf & lblnombrecajerodep.Text & vbCrLf & "No se puede realizar el deposito", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnguardardep.Enabled = False
            ElseIf dr("condeposito") = True Then
                MessageBox.Show("Ya se le realizo el deposito al cajero " & vbCrLf & lblnombrecajerodep.Text & vbCrLf & "No se pueden realizar mas depositos", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnguardardep.Enabled = False
            End If
        End If
    End Sub

    Private Sub DgdatosdepDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles dgdatosdep.DoubleClick
        If dgdatosdep.Rows.Count > 0 Then
            'Obtiene el Currency Manager con el BindingContext del DataGrid 
            Dim cm As CurrencyManager = CType(BindingContext(dgdatosdep.DataSource, dgdatosdep.DataMember), CurrencyManager)
            'Recupera el DataView predeterminado del DataGrid 
            Dim dv As DataView = CType(cm.List, DataView)
            'Usa el  Currency Manager y DataView para recuperar la fila actual 
            Dim dr As DataRow

            dr = dv.Item(cm.Position).Row

            'Obtiene datos para la modificacion del deposito
            txtmontodep.Text = dr("Monto")
            _dcantidadanterior = dr("Monto")
            _iiddeposito = dr("did")
            cmbcajadep.SelectedIndex = cmbcajadep.FindString(dr("Caja"))

            btnguardardep.Enabled = False
            btnmodificardep.Enabled = True
            cmbcajadep.Enabled = False
            cmbcajadep.BackColor = Color.White

            txtmontodep.Focus()
        End If
    End Sub

    Private Sub CmbcajadepSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbcajadep.SelectedIndexChanged
        txtmontodep.Focus()
    End Sub

#Region "Button EventHandlers"

    Private Sub BtnguardardepClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardardep.Click
        Dim dmonto As Decimal

        'Valida datos correctos a ingresar
        If cmbcajadep.SelectedIndex > -1 And txtmontodep.Text.Length > 0 And lblnombrecajerodep.Text.Length > 0 AndAlso Convert.ToDecimal(txtmontodep.Text) > 0 Then
            If MessageBox.Show("Esta seguro de que desea hacer el deposito?", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Valida que el cajero no tenga corte
                Dim drtemp As DataRow = DevuelveFila("SELECT idusuarios,estado FROM totales WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios, _conexionsuperpos)

                'Verifica monto en el rango de parametros
                If txtmontodep.Text <= Ddepositomaximo OrElse MessageBox.Show("Monto fuera de rango" & vbCrLf & "Esta seguro de hacer el deposito?", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If IsNothing(drtemp) OrElse drtemp("estado") = 1 Then
                        dmonto = Convert.ToDecimal(txtmontodep.Text)

                        EjecutaComandosql("INSERT INTO detalletotales (fecha, idusuarios, idsucursales, codigopago, montofisico, montodepositos) VALUES ('" & Sfecha & "', " & _idusuarios & ", " & Sucursallocal & ", 'EF', " & dmonto & ", " & dmonto & ") ON DUPLICATE KEY UPDATE montofisico = montofisico + " & dmonto & " , montodepositos = montodepositos + " & dmonto, _conexionsuperpos)
                        _inautoincrement = DevuelveDato("SELECT id FROM detalletotales WHERE fecha = '" & Sfecha & "' AND idusuarios  =  " & _idusuarios & " AND codigopago = 'EF'", _conexionsuperpos)
                        EjecutaComandosql("INSERT INTO detalleparciales (fecha, idusuarios, idsucursales, codigopago, monto, iddetalletotales, fechahora, idcajas, onserver) VALUES ('" & Sfecha & "', " & _idusuarios & ", " & Sucursallocal & ", 'EF', " & dmonto & ", " & _inautoincrement & ", NOW(), " & cmbcajadep.SelectedItem & ", '1')", _conexionsuperpos)
                        MessageBox.Show("Deposito realizado correctamente", Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Ya se le realizo el deposito al cajero " & vbCrLf & lblnombrecajerodep.Text & vbCrLf & "No se pueden realizar mas deposito", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    'Actualiza listbox de cajeros
                    Actualizardatoscajero()

                    'Llena el listbox de cajeros
                    _dscajeros = LlenarDataset("SELECT Idusuarios ,Nombre, condeposito, concorte FROM ctrloperacionescajero WHERE fecha = '" & Sfecha & "' ORDER BY nombre ASC", _conexionforma24)
                    Llenarlstcajeros(_dscajeros.Tables(0).Select("idusuarios = idusuarios", "nombre ASC"))

                    BtncancelardepClick(Nothing, Nothing)
                End If
            End If
        Else
            MessageBox.Show("Error en datos a ingresar, por favor revise", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtncancelardepClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelardep.Click
        lblnombrecajerodep.Text = ""

        If _bandeposito <> 0 Then
            txtmontodep.Clear()
        End If

        dgdatosdep.DataSource = Nothing

        btnguardardep.Enabled = True
        btnmodificardep.Enabled = False
        cmbcajadep.Enabled = True
        cmbcajadep.SelectedIndex = -1

        paneldeposito.BackColor = BackColor
    End Sub

    Private Sub BtnmodificardepClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnmodificardep.Click
        Dim dmonto As Decimal

        'Valida datos correctos a ingresar
        If txtmontodep.Text.Length > 0 AndAlso Convert.ToDecimal(txtmontodep.Text) > 0 Then
            'Confirma que se desea hacer el deposito
            If MessageBox.Show("Esta seguro de que desea modificar el deposito", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dmonto = Convert.ToDecimal(txtmontodep.Text)
                'Verifica monto en el rango de parametros
                If txtmontodep.Text <= Ddepositomaximo OrElse MessageBox.Show("Monto fuera de rango" & vbCrLf & "Esta seguro de modificar el deposito", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    EjecutaComandosql("UPDATE detalleparciales SET monto = " & dmonto & " WHERE id = " & _iiddeposito, _conexionsuperpos)
                    EjecutaComandosql("UPDATE detalletotales SET montofisico = montofisico - " & _dcantidadanterior & " + " & dmonto & " , montodepositos = montodepositos - " & _dcantidadanterior & " + " & dmonto & " WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuarios & "  AND codigopago = 'EF'", _conexionsuperpos)

                    'Registra la modificacion en la tabla de historialcambiodepositos
                    EjecutaComandosql("INSERT INTO logcambiodepret(tipo, idusuarios, nombre, idsucursales, iddetalledepret, fecha, montoanterior, montonuevo, usuario) VALUES('D', " & _idusuarios & ", '" & _snombrecajero & "', " & Sucursallocal & ", " & _iiddeposito & ", '" & Sfecha & "', " & _dcantidadanterior & ", " & dmonto & ", '" & Snombreusuario & "')", _conexionforma24)
                    MessageBox.Show("Deposito modificado exitosamente", Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtncancelardepClick(Nothing, Nothing)
                End If
            End If
        Else
            MessageBox.Show("Error en datos a ingresar, por favor revise", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Funciones"

    Private Sub Llenarlstcajeros(ByVal stable As DataRow())
        'Prepara el listview
        lstvcajeros.View = View.Details
        lstvcajeros.Clear()

        'Crea las columnas del listview
        lstvcajeros.Columns.Add("Nombre", 290, HorizontalAlignment.Left)

        'Ingresa los datos de cada cajero en el listview
        For Each dr As DataRow In stable
            Dim ilstcajero As New ListViewItem
            ilstcajero.Text = dr("idusuarios") & " " & dr("Nombre")

            If dr("condeposito") <> 0 Then
                ilstcajero.BackColor = Color.FromName(Scolordeposito)
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

    Private Sub Revisarcierredia()
        Bancierre = DevuelveDato("SELECT COUNT(*) tot FROM cierres WHERE fecha = '" & Sfecha & "'", _conexionsuperpos)

        If Bancierre = True Then
            btncancelardep.Enabled = False
            btnguardardep.Enabled = False
            btnmodificardep.Enabled = False

            RemoveHandler dgdatosdep.DoubleClick, AddressOf DgdatosdepDoubleClick

            lblfecha.BackColor = Color.FromName(Scolorcierredia)

            MessageBox.Show("Ya se aplico el cierre de dia a la fecha " & Sfechaserver & vbCrLf & "No se puede modificar ningun dato.", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

End Class