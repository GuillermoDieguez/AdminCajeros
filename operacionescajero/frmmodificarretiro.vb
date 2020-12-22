Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class Frmmodificarretiro

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim _dsdatos As New DataSet

    Dim _dcantidadanterior As Decimal

    Dim _iddetalle As Integer
    Dim _idparcial As Integer
    Dim _idusuario As Integer

    Dim _snombrecajero As String
    Dim _sfecharet As String

    Private Sub FrmmodificarretiroFormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub FrmmodificarretiroLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _conexionsuperpos.ConnectionString = Sconexionsuperpos
        _conexionforma24.ConnectionString = Sconexiondbforma24

        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = Icon.FromHandle(My.Resources.modificar.GetHicon())
        btncancelar.Image = My.Resources.cancelar
        btnmodificar.Image = My.Resources.modificar

        _idusuario = lblnombrecajero.Text.Remove(lblnombrecajero.Text.IndexOf(" "))
        _snombrecajero = lblnombrecajero.Text.Remove(0, lblnombrecajero.Text.IndexOf(" ") + 1)

        AddHandler txtmonto.KeyDown, AddressOf LibForms.LibwineventsH.TxtmontoKeyDown
        AddHandler txtmonto.KeyPress, AddressOf LibForms.LibwineventsH.TxtmontoKeyPress
        AddHandler txtmonto.LostFocus, AddressOf LibForms.LibwineventsH.TxtmontoLostFocus

        llenargrid()
    End Sub

    Private Sub DgdatosDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles dgdatos.DoubleClick
        If dgdatos.Rows.Count > 0 Then
            'Obtiene el Currency Manager con el BindingContext del DataGrid 
            Dim cm As CurrencyManager = CType(BindingContext(dgdatos.DataSource, dgdatos.DataMember), CurrencyManager)
            'Recupera el DataView predeterminado del DataGrid 
            Dim dv As DataView = CType(cm.List, DataView)
            'Usa Currency Manager y DataView para recuperar la fila actual 
            Dim dr As DataRow

            dr = dv.Item(cm.Position).Row

            'Muestra los datos en el formulario
            _idparcial = dr("id")
            _iddetalle = dr("iddetalletotales")
            lblcodigopago.Text = dr("CodigoPago")
            txtmonto.Text = String.Format("{0:n}", dr("Monto"))
            lblcaja.Text = dr("Caja")
            _sfecharet = String.Format("{0:yyyy-MM-dd}", CDate(dr("Fecha")))

            'Almacena la cantidad anterior en una variable
            _dcantidadanterior = dr("Monto")

            txtmonto.Focus()
        End If
    End Sub

#Region "Botones EventHandlers"

    Private Sub BtnmodificarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnmodificar.Click
        Dim dmonto As Decimal
        Dim drdetalletotal As DataRow

        Dim drtemp As DataRow

        'Valida datos correctos
        If txtobservaciones.Text.Length > 0 Then
            If lblcaja.Text.Length > 0 And lblcodigopago.Text.Length > 0 And txtmonto.Text.Length >= 0 AndAlso Convert.ToDecimal(txtmonto.Text.Replace(",", "")) >= 0 Then
                'Confirma que se desea hacer la modificacion
                If MessageBox.Show("Esta seguro que desea modificar el retiro seleccionado?", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    drtemp = DevuelveFila("SELECT idusuarios,estado FROM totales WHERE fecha = '" & Sfecha & "' AND idusuarios = " & _idusuario, _conexionsuperpos)

                    'Valida que el cajero no tenga corte
                    If IsNothing(drtemp) OrElse drtemp("estado") = 1 Then
                        dmonto = Convert.ToDecimal(txtmonto.Text.Replace(",", ""))
                        drdetalletotal = DevuelveFila("SELECT monto, montofisico, montoparciales, montodepositos, montodiferencia, numeropagos FROM detalletotales WHERE Id = " & _iddetalle & " AND fecha = '" & _sfecharet & "' AND idusuarios = " & _idusuario & " AND codigopago = '" & lblcodigopago.Text & "'", _conexionsuperpos)

                        '--- modificacion por monto 0 en la modificacion
                        If drdetalletotal("monto") = 0 And drdetalletotal("montodepositos") = 0 And drdetalletotal("numeropagos") = 0 And drdetalletotal("montofisico") + _dcantidadanterior - dmonto = 0 And drdetalletotal("montoparciales") - _dcantidadanterior + dmonto = 0 Then
                            EjecutaComandosql("DELETE FROM detalletotales WHERE Id = " & _iddetalle & " AND fecha = '" & _sfecharet & "' AND idusuarios = " & _idusuario & " AND codigopago = '" & lblcodigopago.Text & "'", _conexionsuperpos)
                        Else
                            EjecutaComandosql("UPDATE detalletotales SET montoparciales = montoparciales - " & _dcantidadanterior & " + " & dmonto & ", montofisico = montofisico + " & _dcantidadanterior & " -  " & dmonto & " WHERE Id = " & _iddetalle & " AND fecha = '" & _sfecharet & "' AND idusuarios = " & _idusuario & " AND codigopago = '" & lblcodigopago.Text & "'", _conexionsuperpos)
                        End If

                        If dmonto = 0 Then
                            EjecutaComandosql("DELETE FROM detalleparciales WHERE id = " & _idparcial, _conexionsuperpos)
                        Else
                            EjecutaComandosql("UPDATE detalleparciales SET monto = -" & dmonto & " WHERE id = " & _idparcial, _conexionsuperpos)
                        End If

                        'Registra modificacion del retiro en una tabla de la dbforma24
                        EjecutaComandosql("INSERT INTO logcambiodepret(tipo, idusuarios, nombre, idsucursales, iddetalledepret, fecha, codigopago, montoanterior, montonuevo, observaciones, usuario) VALUES('R', " & _idusuario & ", '" & _snombrecajero & "'," & Sucursallocal & ", " & _idparcial & ", '" & Sfecha & "', '" & lblcodigopago.Text & "', " & _dcantidadanterior & ", " & dmonto & ", '" & txtobservaciones.Text & "', '" & Snombreusuario & "')", _conexionforma24)

                        txtobservaciones.Clear()
                        MessageBox.Show("Retiro modificado correctamente", Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Close()
                    Else
                        MessageBox.Show("Ya se le realizo el corte al cajero, no se puede modificar el retiro indicado", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Error en datos a modificar, por favor revise", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Indique la observacion para la modificacion", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtncancelarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Close()
    End Sub

#End Region

#Region "Funciones"

    Sub llenargrid()
        'Obtiene los datos de los retiros realizados al cajero en la caja indicada
        _dsdatos = LlenarDataset("SELECT id, fecha Fecha, idcajas Caja, codigopago CodigoPago, -1*monto Monto, iddetalletotales, fechahora FechaHora FROM detalleparciales  WHERE idusuarios = " & _idusuario & " AND fecha = '" & Sfecha & "' AND monto < 0", _conexionsuperpos)
        dgdatos.DataSource = _dsdatos.Tables(0)
        dgdatos.ClearSelection()

        'Formatea el grid y oculto las columnas de id(parcial) y iddetalletotales
        With dgdatos
            .Columns("id").Visible = False
            .Columns("iddetalletotales").Visible = False
            .Columns("Monto").DefaultCellStyle.Format = "n"
            .Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
        End With

        'Desactiva ordenamiento del datagrid
        For i = 0 To dgdatos.Columns.Count - 1
            dgdatos.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
    End Sub

#End Region

End Class