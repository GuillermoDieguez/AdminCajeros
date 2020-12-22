Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class Frmmodificarfp

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim _dsdatos As New DataSet
    Dim _dsresultado As New DataSet
    Dim _dstipostarjetas As New DataSet

    Dim _idtransaccion As Integer
    Dim _idusuarios As Integer
    Dim _iidbacoori As Integer
    Dim _iidbancodes As Integer

    Dim _sfpori As String = ""
    Dim _sfpdes As String = ""
    Dim _sfechaproblema As String

    ReadOnly _lidpagosdetalle As New List(Of Integer)
    ReadOnly _lmonto As New List(Of Decimal)

    Dim _bancierredia As Boolean

    Private Sub FrmmodificarfpFormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Frmmenu.Show()
        Dispose()
    End Sub

    Private Sub FrmmodificarfpLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _conexionforma24.ConnectionString = Sconexiondbforma24
        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        lblfecha.Text = lblfecha.Text & Sfechaserver

        'Configura el color y el icono del formulario, el color de los paneles y la imagen de los botones
        paneltitulo.BackColor = Color.FromArgb(Colortitulo(0), Colortitulo(1), Colortitulo(2))
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))
        btncancelar.Image = My.Resources.cancelar
        btnmodificar.Image = My.Resources.modificar
        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.modificarfp.GetHicon())

        'Agrega los handlers para validar el ingreso de solo numeros en los textbox de monto, numdocumento, referencia, numautorizacion
        AddHandler txtmonto.KeyDown, AddressOf LibForms.LibwineventsH.TxtmontoKeyDown
        AddHandler txtmonto.KeyPress, AddressOf LibForms.LibwineventsH.TxtmontoKeyPress
        AddHandler txtmonto.LostFocus, AddressOf LibForms.LibwineventsH.TxtmontoLostFocus
        AddHandler txtnumdocumento.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
        AddHandler txtnumdocumento.KeyPress, AddressOf LibForms.LibwineventsH.TxtnumeroKeyPress
        AddHandler txtreferenciades.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
        AddHandler txtreferenciades.KeyPress, AddressOf LibForms.LibwineventsH.TxtnumeroKeyPress
        AddHandler txtnumautorizaciondes.KeyDown, AddressOf LibForms.LibwineventsH.TxtKeyDown
        AddHandler txtnumautorizaciondes.KeyPress, AddressOf LibForms.LibwineventsH.TxtnumeroKeyPress

        'Llena el combobox cajas
        _dsdatos = LlenarDataset("SELECT numero FROM cajas WHERE idresoluciones <> 0 ORDER BY id ASC ", _conexionsuperpos)
        cmbcajas.Items.Clear()
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            cmbcajas.Items.Add(dr("numero"))
        Next

        'Llena el combobox tipopago
        _dsdatos = LlenarDataset("SELECT nombre FROM tipostarjetacredito WHERE codigopago IN (" & Fpvalidas & ") AND idbancoemisor IN (" & Idbancoemisorvalidos & ") ORDER BY nombre ASC", _conexionforma24)
        cmbtipopagodes.Items.Clear()
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            cmbtipopagodes.Items.Add(dr("nombre"))
        Next
        cmbtipopagodes.Items.Add("EF")
        _dsdatos.Clear()

        'Obtiene el parametro para verificar el cierre de dia
        _bancierredia = DevuelveDato("SELECT Bancierremodificarfp FROM parametrosadmincajeros ", _conexionforma24)
    End Sub

    Private Sub DgdatosDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles dgdatos.DoubleClick
        If _dsdatos.Tables(0).Rows.Count > 0 And _dsresultado.Tables(0).Rows.Count < 2 Then
            Dim cm As CurrencyManager = CType(BindingContext(dgdatos.DataSource, dgdatos.DataMember), CurrencyManager)
            'Recupera el DataView predeterminado del DataGrid 
            Dim dv As DataView = CType(cm.List, DataView)
            'Usa el Currency Manager y DataView para recuperar la fila actual 
            Dim dr As DataRow

            dr = dv.Item(cm.Position).Row
            'Revisa que la forma de pago se pueda modificar
            If Fpvalidas.IndexOf(dr("FormaPago")) > -1 And Idbancoemisorvalidos.IndexOf(dr("BancoEmisor")) > -1 Then
                'Verifica si se esta seleccionando la forma de pago origen o destino 
                If _lidpagosdetalle.Count = 0 Then
                    _sfpori = dr("FormaPago")
                    _iidbacoori = dr("BancoEmisor")
                    _lidpagosdetalle.Add(dr("id"))
                    _lmonto.Add(dr("monto"))

                    lbltipopagoori.Text = dr("TipoPago")
                    lblnombreori.Text = dr("Nombre").ToString
                    lblreferenciaori.Text = dr("Referencia").ToString
                    lblnumautorizacionori.Text = dr("NoAutorizacion").ToString

                    cmbtipopagodes.Enabled = True
                    _dsresultado.Tables(0).ImportRow(dr)
                Else
                    'Verifica que no se le de click a una forma de pago ya ingresada 
                    If _lidpagosdetalle.IndexOf(dr("id")) = -1 Then
                        _sfpdes = dr("FormaPago")
                        _iidbancodes = dr("BancoEmisor")
                        _lidpagosdetalle.Add(dr("id"))
                        _lmonto.Add(dr("monto"))

                        Activardatosdestino(False)

                        lbltipopagodes.Text = dr("TipoPago")
                        lblnombredes.Text = dr("Nombre").ToString
                        lblreferenciades.Text = dr("Referencia").ToString
                        lblnumautorizaciondes.Text = dr("NoAutorizacion").ToString

                        cmbtipopagodes.Visible = False
                        lbltipopagodes.Visible = True
                        _dsresultado.Tables(0).ImportRow(dr)

                        txtmonto.Enabled = True
                        txtmonto.Focus()
                    End If
                End If
            Else
                MessageBox.Show("La forma de pago seleccionada no se puede modificar", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CmbtipopagodesSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbtipopagodes.SelectedIndexChanged
        If cmbtipopagodes.SelectedIndex <> -1 Then
            Dim drtemp As DataRow
            Dim drdatostemp As DataRow

            drdatostemp = _dsresultado.Tables(0).NewRow
            If cmbtipopagodes.SelectedItem = "EF" Then
                _sfpdes = "EF"
                _iidbancodes = 0
                drdatostemp("Formapago") = "EF"
                drdatostemp("BancoEmisor") = 0
                drdatostemp("TipoPago") = "EF"

                Activardatosdestino(False)
            Else
                'Obtiene el codipago y el idbancoemisor correspondiente al elemento seleccionado en el combobox
                drtemp = DevuelveFila("SELECT codigopago, idbancoemisor FROM tipostarjetacredito WHERE nombre = '" & cmbtipopagodes.SelectedItem & "'", _conexionforma24)

                _sfpdes = drtemp("codigopago")
                _iidbancodes = drtemp("idbancoemisor")
                drdatostemp("Formapago") = drtemp("codigopago")
                drdatostemp("BancoEmisor") = drtemp("idbancoemisor")
                drdatostemp("TipoPago") = cmbtipopagodes.SelectedItem

                Activardatosdestino(True)
            End If

            drdatostemp("id") = 0
            drdatostemp("Nombre") = ""
            drdatostemp("Referencia") = ""
            drdatostemp("Noautorizacion") = ""
            drdatostemp("Monto") = 0
            _dsresultado.Tables(0).Rows.Add(drdatostemp)

            cmbtipopagodes.Visible = False
            lbltipopagodes.Visible = True
            lbltipopagodes.Text = cmbtipopagodes.SelectedItem
            txtmonto.Enabled = True
            txtmonto.Focus()

            _lmonto.Add(0)
        End If
    End Sub

#Region "TextBox EventHandlers"

    Private Sub TxtmontoKeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtmonto.KeyUp
        Dim dmonto As Decimal
        'Actualiza el grid de resultado para la previsualizacion de los cambios
        'Actualiza el label de diferencia para la previsualizacion de los cambios
        If txtmonto.Text.Length > 0 Then

            If txtmonto.Text <> "." Then
                dmonto = Convert.ToDecimal(txtmonto.Text.Replace(",", ""))
            Else
                dmonto = 0
            End If

            If _lmonto(0) - dmonto >= 0 Then
                'RESTA ORIGEN
                _dsresultado.Tables(0).Rows(0)("monto") = _lmonto(0) - dmonto

                'SUMA DESTINO
                _dsresultado.Tables(0).Rows(1)("monto") = _lmonto(1) + dmonto
            Else
                _dsresultado.Tables(0).Rows(0)("monto") = _lmonto(0)
                _dsresultado.Tables(0).Rows(1)("monto") = _lmonto(1)
                txtmonto.Clear()

                MessageBox.Show("Monto incorrecto", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            _dsresultado.Tables(0).Rows(0)("monto") = _lmonto(0)
            _dsresultado.Tables(0).Rows(1)("monto") = _lmonto(1)
        End If
    End Sub

#End Region

#Region "Botones EventHandlers"

    Private Sub BtnmodificarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnmodificar.Click
        Dim dmontoorigen As Decimal
        Dim dmontoanteriororigen As Decimal
        Dim dmontoanteriordestino As Decimal
        Dim dtmpmontoorigen As Decimal
        Dim dtmpmontoparcial As Decimal
        Dim dtmpmontodeposito As Decimal
        Dim dmonto As Decimal

        Dim itmpnumpagos As Integer
        Dim itotfilas As Integer
        Dim banborradoorigen As Integer = 0
        Dim baninsertadodestino As Integer = 0
        Dim bancierre As Integer = -1

        Dim drtemp As DataRow

        Dim snombrecajero As String

        If _sfpori.Length > 0 And _sfpdes.Length > 0 And txtmonto.Text.Length > 0 AndAlso txtmonto.Text <> "0.00" Then
            If Trim(txtobservaciones.Text).Length > 0 Then
                bancierre = DevuelveDato("SELECT estado FROM totales WHERE fecha = '" & _sfechaproblema & "' AND idusuarios = " & _idusuarios, _conexionsuperpos)
                If bancierre = 0 Then
                    If MessageBox.Show("Esta seguro de modificar los datos", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        dmonto = Convert.ToDecimal(txtmonto.Text)
                        'PAGOSDETALLES
                        'UPDATE a la forma de pago que se le resta y a la forma de pago que se le suma
                        'Suma forma de pago destino
                        _conexionsuperpos.Open()
                        If _lidpagosdetalle.Count > 1 Then
                            itotfilas = DevuelveDato("SELECT COUNT(*) t FROM pagosdetalles WHERE id = " & _lidpagosdetalle(1), _conexionsuperpos)
                        End If

                        If itotfilas > 0 Or _lidpagosdetalle.Count > 1 Then
                            dmontoanteriordestino = DevuelveDato("SELECT monto FROM pagosdetalles WHERE id = " & _lidpagosdetalle(1), _conexionsuperpos)
                            EjecutaComandosql("UPDATE pagosdetalles SET monto = monto + " & dmonto & " WHERE Id = " & _lidpagosdetalle(1), _conexionsuperpos)
                        Else
                            If _sfpdes = "EF" Then
                                EjecutaComandosql("INSERT INTO pagosdetalles(Idtransacciones, IdUsuarios, IdCajas ,IdSucursales, Fecha, CodigoPago, Idbancosemisores, Numeroautorizacion, Monto, NumeroDoc) VALUES(" & _idtransaccion & ", " & _idusuarios & ", " & cmbcajas.SelectedItem & ", " & Sucursallocal & ", '" & _sfechaproblema & "', '" & _sfpdes & "', '0', '', " & dmonto & ", '" & txtnumdocumento.Text & "')", _conexionsuperpos)
                                baninsertadodestino = 1
                            Else
                                'If _idbancodes.Length > 0 And txtreferenciades.Text.Length > 0 And txtnumautorizaciondes.Text.Length > 0 Then
                                If txtreferenciades.Text.Length > 0 And txtnumautorizaciondes.Text.Length > 0 And txtnombredes.Text.Length > 0 Then
                                    EjecutaComandosql("INSERT INTO pagosdetalles(Idtransacciones, IdUsuarios, IdCajas ,IdSucursales, Fecha, CodigoPago, Idbancosemisores, Nombre, Referencia, NumeroAutorizacion, Monto, NumeroDoc) VALUES(" & _idtransaccion & ", " & _idusuarios & ", " & cmbcajas.SelectedItem & ", " & Sucursallocal & ", '" & _sfechaproblema & "', '" & _sfpdes & "', " & _iidbancodes & ", '" & txtnombredes.Text.ToUpper & "', '" & txtreferenciades.Text & "', '" & txtnumautorizaciondes.Text & "', " & dmonto & ", '" & txtnumdocumento.Text & "')", _conexionsuperpos)
                                    baninsertadodestino = 1
                                Else
                                    _conexionsuperpos.Close()
                                    MessageBox.Show("Datos de forma de pago incorrectos por favor revise", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            End If
                        End If

                        'Resta forma de pago origen
                        dmontoorigen = DevuelveDato("SELECT monto FROM pagosdetalles WHERE id = " & _lidpagosdetalle(0), _conexionsuperpos)
                        dmontoanteriororigen = dmontoorigen
                        If dmontoorigen - dmonto = 0 Then
                            EjecutaComandosql("DELETE FROM pagosdetalles WHERE id = " & _lidpagosdetalle(0), _conexionsuperpos)
                            banborradoorigen = 1
                        Else
                            EjecutaComandosql("UPDATE pagosdetalles SET monto = monto - " & dmonto & " WHERE id = " & _lidpagosdetalle(0), _conexionsuperpos)
                        End If

                        'DETALLETOTALES
                        'UPDATE a la forma de pago que se le resta y a la forma de pago que se le suma
                        'Suma forma de pago destino
                        EjecutaComandosql("INSERT INTO detalletotales(fecha, idusuarios, idsucursales, codigopago, monto, montofisico, montoparciales, MontoDepositos, montodiferencia, numeropagos) VALUES('" & _sfechaproblema & "', " & _idusuarios & ", " & Sucursallocal & ", '" & _sfpdes & "', " & dmonto & ", 0, 0, 0, 0, 1) ON DUPLICATE KEY UPDATE monto = monto + " & dmonto & ", montofisico = monto + montodepositos - montoparciales, montodiferencia = monto + montodepositos - montoparciales, numeropagos = numeropagos + " & baninsertadodestino, _conexionsuperpos)

                        'Resta forma de de pago origen
                        drtemp = DevuelveFila("SELECT Monto,MontoParciales,MontoDepositos,Numeropagos FROM detalletotales WHERE fecha = '" & _sfechaproblema & "' AND idusuarios = " & _idusuarios & " AND codigopago = '" & _sfpori & "'", _conexionsuperpos)

                        dtmpmontoorigen = drtemp("Monto")
                        dtmpmontoparcial = drtemp("MontoParciales")
                        dtmpmontodeposito = drtemp("MontoDepositos")
                        itmpnumpagos = drtemp("Numeropagos")
                        If dtmpmontoorigen - dmonto = 0 And dtmpmontoparcial = 0 And dtmpmontodeposito = 0 And itmpnumpagos = 1 Then
                            EjecutaComandosql("DELETE FROM detalletotales WHERE fecha = '" & _sfechaproblema & "' AND idusuarios = " & _idusuarios & " AND codigopago = '" & _sfpori & "'", _conexionsuperpos)
                        Else
                            EjecutaComandosql("UPDATE detalletotales SET monto = monto - " & dmonto & ", montofisico = monto + montodepositos - montoparciales, montodiferencia = monto + montodepositos - montoparciales, numeropagos = numeropagos - " & banborradoorigen & " WHERE fecha = '" & _sfechaproblema & "' AND idusuarios = " & _idusuarios & " AND codigopago = '" & _sfpori & "'", _conexionsuperpos)
                        End If

                        'DETALLEMOVIMIENTOSCAJAS
                        'UPDATE  a la forma de pago que se le resta y a la forma de pago que se le suma
                        'Suma forma de pago destino
                        EjecutaComandosql("INSERT INTO detallemovimientoscajas(fecha, idcajas, codigopago, monto, numeropagos, idsucursales) VALUES ('" & _sfechaproblema & "', " & cmbcajas.SelectedItem & ", '" & _sfpdes & "', " & dmonto & ", 1, " & Sucursallocal & ") ON DUPLICATE KEY UPDATE monto = monto + " & dmonto & ", numeropagos = numeropagos + " & baninsertadodestino, _conexionsuperpos)

                        'Resta forma de pago origen
                        drtemp = DevuelveFila("SELECT monto,numeropagos FROM detallemovimientoscajas WHERE fecha = '" & _sfechaproblema & "' AND idcajas = " & cmbcajas.SelectedItem & " AND codigopago = '" & _sfpori & "'", _conexionsuperpos)
                        dtmpmontoorigen = drtemp("Monto")
                        itmpnumpagos = drtemp("NumeroPagos")
                        If dtmpmontoorigen - dmonto = 0 And itmpnumpagos = 1 Then
                            EjecutaComandosql("DELETE FROM detallemovimientoscajas WHERE fecha = '" & _sfechaproblema & "' AND idcajas = " & cmbcajas.SelectedItem & " AND codigopago = '" & _sfpori & "'", _conexionsuperpos)
                        Else
                            EjecutaComandosql("UPDATE detallemovimientoscajas SET monto = monto - " & dmonto & ", numeropagos = numeropagos - " & banborradoorigen & " WHERE fecha = '" & _sfechaproblema & "' AND idcajas = " & cmbcajas.SelectedItem & "  AND codigopago = '" & _sfpori & "'", _conexionsuperpos)
                        End If

                        snombrecajero = DevuelveDato("SELECT nombrecompleto FROM usuarios WHERE id = " & _idusuarios, _conexionsuperpos)
                        _conexionsuperpos.Close()

                        'Guarda la linea de log en el log de modificacion de forma de pago
                        EjecutaComandosql("INSERT INTO logmodificacionfp (idusuarios, nombre, idsucursales, fecha, idcajas, nodocumento, monto, codigopagoorigen, idbancoemisororigen, montoanteriororigen, montonuevoorigen, codigopagodestino, idbancoemisordestino, montoanteriordestino, montonuevodestino, observaciones, usuario) VALUES(" & _idusuarios & ",'" & snombrecajero & "', " & Sucursallocal & ", '" & _sfechaproblema & "'," & cmbcajas.SelectedItem & ", " & txtnumdocumento.Text & ", " & dmonto & ", '" & _sfpori & "', " & _iidbacoori & ", " & dmontoanteriororigen & ", " & dmontoanteriororigen - dmonto & ", '" & _sfpdes & "', " & _iidbancodes & ", " & dmontoanteriordestino & ", " & dmontoanteriordestino + dmonto & ", '" & txtobservaciones.Text & "', '" & Snombreusuario & "')", _conexionforma24)

                        BtncancelarClick(Nothing, Nothing)
                        MessageBox.Show("Datos modificados exitosamente", Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Debe aplicarle el corte al cajero antes de realizar la modificacionn", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                MessageBox.Show("Indique la observacion para la modificacion", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Indique los datos a modificar", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtncancelarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        _lidpagosdetalle.Clear()
        _lmonto.Clear()

        lblcajero.Text = ""
        lbltipopagoori.Text = ""
        lblnombreori.Text = ""
        lblreferenciaori.Text = ""
        lblnumautorizacionori.Text = ""
        lbltipopagodes.Text = ""

        txtmonto.Clear()
        txtnumdocumento.Clear()
        txtobservaciones.Clear()
        cmbcajas.SelectedIndex = -1
        cmbtipopagodes.SelectedIndex = -1

        cmbtipopagodes.Enabled = False
        cmbtipopagodes.Visible = True
        lbltipopagodes.Visible = False

        _dsdatos.Clear()
        _dsresultado.Clear()

        Activardatosdestino(False)

        txtmonto.Enabled = False
        cmbcajas.Enabled = True
        txtnumdocumento.Enabled = True
        btnmodificar.Enabled = True
    End Sub

#End Region

#Region "Funciones"

    Private Sub Buscar(ByVal sender As Object, ByVal e As EventArgs) Handles cmbcajas.SelectedIndexChanged, txtnumdocumento.LostFocus
        Dim dr As DataRow
        Dim icierre As Integer

        If txtnumdocumento.Text.Length > 0 And cmbcajas.SelectedIndex > -1 Then
            'Obtiene los datos de la transaccion 
            dr = DevuelveFila("SELECT id, fecha, idusuarios,idcajas FROM transacciones WHERE NoDocumento=" & txtnumdocumento.Text & " AND idcajas = " & cmbcajas.SelectedItem, _conexionsuperpos)
            If dr Is Nothing = False Then
                _sfechaproblema = String.Format("{0:yyyy-MM-dd}", dr("fecha"))

                'Verifica que no este cerrado el dia de la fecha de la transaccion
                icierre = DevuelveDato("SELECT COUNT(*) tot FROM cierres WHERE fecha = '" & _sfechaproblema & "'", _conexionsuperpos)
                If _bancierredia = 0 OrElse icierre = 0 Then
                    lblcajero.Text = DevuelveDato("SELECT nombrecompleto FROM usuarios WHERE id = " & dr("idusuarios"), _conexionsuperpos).ToString

                    _idtransaccion = dr("id")
                    _idusuarios = dr("idusuarios")

                    _dstipostarjetas = LlenarDataset("SELECT nombre, codigopago, idbancoemisor FROM tipostarjetacredito", _conexionforma24)
                    _dsdatos = LlenarDataset("SELECT id, codigopago FormaPago, idbancosemisores BancoEmisor,'S' TipoPago, Nombre, Referencia, numeroautorizacion NoAutorizacion, Monto  FROM pagosdetalles WHERE idtransacciones = " & _idtransaccion, _conexionsuperpos)

                    'Convierte el codigopago y el idbancoemisores a tipo de tarjeta
                    For Each drtmp As DataRow In _dsdatos.Tables(0).Rows
                        Dim ban As Integer = 0

                        For Each drtmptarjetas As DataRow In _dstipostarjetas.Tables(0).Select("codigopago = '" & drtmp("Formapago") & "' AND idbancoemisor = " & drtmp("bancoemisor"))
                            drtmp("TipoPago") = drtmptarjetas("Nombre")
                            ban += 1
                        Next

                        'Indica la forma de pago de EF(si el ciclo anterior no modifica nada se entra a esta condicion)
                        If ban = 0 Then
                            drtmp("TipoPago") = drtmp("Formapago")
                        End If
                    Next

                    cmbcajas.Enabled = False
                    txtnumdocumento.Enabled = False

                    dgdatos.DataSource = _dsdatos.Tables(0).DefaultView
                    formatogrid(dgdatos)

                    'Copia la estructura del dataset al dataset resultado para poder previsualizar las modificaciones
                    _dsresultado = _dsdatos.Clone
                    dgresultado.DataSource = _dsresultado.Tables(0).DefaultView
                    formatogrid(dgresultado)

                    'Desactiva ordenamiento del datagrid resultado
                    For i = 0 To dgresultado.Columns.Count - 1
                        dgresultado.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
                    Next i
                Else
                    MessageBox.Show("Ya se aplico el cierre de dia a la fecha de la transaccion (" & dr("fecha") & ")" & vbCrLf & "No se puede realizar ninguna modificacion.", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No existen datos a modificar", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Activardatosdestino(ByVal estado As Boolean)
        txtnombredes.Visible = estado
        txtnumautorizaciondes.Visible = estado
        txtreferenciades.Visible = estado
        lblnombredes.Visible = Not estado
        lblnumautorizaciondes.Visible = Not estado
        lblreferenciades.Visible = Not estado

        txtnombredes.Clear()
        lblnombredes.Text = ""
        txtreferenciades.Clear()
        lblreferenciades.Text = ""
        txtnumautorizaciondes.Clear()
        lblnumautorizaciondes.Text = ""
    End Sub

    Private Shared Sub formatogrid(ByVal dg As DataGridView)
        'Aplica el formato al grid enviado como parametro
        With dg
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)

            .Columns("id").Visible = False
            .Columns("FormaPago").Visible = False
            .Columns("BancoEmisor").Visible = False
            .Columns("Tipopago").Width = 205
            .Columns("Nombre").Width = 225
            .Columns("Referencia").Width = 225
            .Columns("NoAutorizacion").Width = 225
            .Columns("Monto").Width = 75
            .Columns("Monto").DefaultCellStyle.Format = "n"
            .Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

#End Region

End Class