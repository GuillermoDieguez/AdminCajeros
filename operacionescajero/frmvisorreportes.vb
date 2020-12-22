Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class frmvisorreportes

    ReadOnly _conexionforma24 As New MySqlConnection
    ReadOnly _conexionsuperpos As New MySqlConnection

    Dim _dsrpt As New DataSet

    ReadOnly _parametros As New ParameterFields
    ReadOnly _parametro0 As New ParameterField
    ReadOnly _parametro1 As New ParameterField
    ReadOnly _parametro2 As New ParameterField
    ReadOnly _parametro3 As New ParameterField
    ReadOnly _parametro4 As New ParameterField
    ReadOnly _valor0 As New ParameterDiscreteValue
    ReadOnly _valor1 As New ParameterDiscreteValue
    ReadOnly _valor2 As New ParameterDiscreteValue
    ReadOnly _valor3 As New ParameterDiscreteValue
    ReadOnly _valor4 As New ParameterDiscreteValue

    ReadOnly _sreporte As String

    Private Sub frmvisorreportes_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Owner.Show()
        Dispose()
    End Sub

    Public Sub New(ByVal sparam As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _sreporte = sparam
    End Sub

    Private Sub frmreportes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        _conexionforma24.ConnectionString = Sconexiondbforma24
        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        'Configura el color y el icono del formulario
        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = My.Resources.reportes
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))

        'Prepara parametros comunes del reporte
        _parametro0.ParameterFieldName = "usuarioactual"
        _valor0.Value = Snombreusuario
        _parametro0.CurrentValues.Add(_valor0)
        _parametros.Add(_parametro0)

        _parametro1.ParameterFieldName = "Tienda"
        _valor1.Value = Snombretienda
        _parametro1.CurrentValues.Add(_valor1)
        _parametros.Add(_parametro1)

        _parametro2.ParameterFieldName = "fechaini"
        _valor2.Value = String.Format("{0:dd/MM/yyyy}", CDate(lblfechainicial.Text))
        _parametro2.CurrentValues.Add(_valor2)
        _parametros.Add(_parametro2)

        _parametro3.ParameterFieldName = "fechafin"
        _valor3.Value = String.Format("{0:dd/MM/yyyy}", CDate(lblfechafinal.Text))
        _parametro3.CurrentValues.Add(_valor3)
        _parametros.Add(_parametro3)

        Select Case _sreporte
            Case "LOGCAMBIOFP"
                logcambiofp()
            Case "LOGCAMBIORETIRO"
                logcambioretiro()
            Case "RETIROS"
                retiros()
            Case "CORTE"
                corte()
            Case "BITACORA"
                bitacora()
            Case Else
                MessageBox.Show("Reporte Incorrecto", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
        End Select
    End Sub

#Region "Procedimientos Reportes"

    Private Sub logcambiofp()
        _dsrpt = LlenarDataset("SELECT idusuarios, nombre, idcajas, nodocumento, monto, codigopagoorigen, montoanteriororigen, montonuevoorigen, codigopagodestino, montoanteriordestino, montonuevodestino, observaciones, usuario, fechahoramodificado FROM logmodificacionfp WHERE fecha >= '" & lblfechainicial.Text & "' AND fecha <= '" & lblfechafinal.Text & "'", _conexionforma24)

        Dim rpttemp As New rptlogcambiofp
        rpttemp.SetDataSource(_dsrpt.Tables(0))

        crvreportes.ParameterFieldInfo = _parametros
        crvreportes.ReportSource = rpttemp
    End Sub

    Private Sub logcambioretiro()
        _dsrpt = LlenarDataset("SELECT idusuarios, nombre, codigopago, montoanterior, montonuevo, observaciones, usuario, fechahoramodificado FROM logcambiodepret WHERE tipo = 'R' AND fecha >= '" & lblfechainicial.Text & "' AND fecha <='" & lblfechafinal.Text & "'", _conexionforma24)

        Dim rpttemp As New rptlogcambioretiro
        rpttemp.SetDataSource(_dsrpt.Tables(0))

        crvreportes.ParameterFieldInfo = _parametros
        crvreportes.ReportSource = rpttemp
    End Sub

    Private Sub retiros()
        Dim snombrecajero As String = DevuelveDato("SELECT nombrecompleto FROM usuarios WHERE id = " & lblidusuario.Text, _conexionsuperpos)

        _dsrpt = LlenarDataset("SELECT dp.codigopago, fp.nombre nombrepago, monto, fechahora FROM detalleparciales dp INNER JOIN formasdepago fp ON dp.codigopago = fp.codigopago WHERE monto < 0 AND idusuarios = " & lblidusuario.Text & " AND fecha >= '" & lblfechainicial.Text & "' AND fecha <= '" & lblfechafinal.Text & "' ORDER BY fechahora ASC", _conexionsuperpos)

        'Prepara el reporte para presentarlo en pantalla
        Dim rpttemp As New rptretiros
        rpttemp.SetDataSource(_dsrpt.Tables(0))

        _parametro4.ParameterFieldName = "nombrecajero"
        _valor4.Value = snombrecajero
        _parametro4.CurrentValues.Add(_valor4)
        _parametros.Add(_parametro4)

        crvreportes.ParameterFieldInfo = _parametros
        crvreportes.ReportSource = rpttemp
    End Sub

    Private Sub corte()
        Dim snombrecajero As String = DevuelveDato("SELECT nombrecompleto FROM usuarios WHERE id = " & lblidusuario.Text, _conexionsuperpos)

        _dsrpt = LlenarDataset("SELECT DISTINCT dt.idusuarios, dt.Codigopago, fp.nombre NombrePago, Monto Venta, montodepositos Depositos, montoparciales Retiros, -montodiferencia Diferencia, t.PromoCanje, t.PromoGeneracion, t.PromoCanjeMonto FROM detalletotales dt INNER JOIN totales t ON (dt.IdUsuarios = t.idusuarios  AND dt.fecha = t.fecha) INNER JOIN formasdepago fp ON dt.codigopago = fp.codigopago WHERE t.estado = 0 AND t.fecha = '" & lblfechainicial.Text & "' AND t.idusuarios = " & lblidusuario.Text & " ORDER BY fp.id", _conexionsuperpos)

        'Prepara el reporte para presentarlo en pantalla
        Dim rpttemp As New rptcortec
        rpttemp.SetDataSource(_dsrpt.Tables(0))

        _parametro4.ParameterFieldName = "nombrecajero"
        _valor4.Value = snombrecajero
        _parametro4.CurrentValues.Add(_valor4)
        _parametros.Add(_parametro4)

        crvreportes.ParameterFieldInfo = _parametros
        crvreportes.ReportSource = rpttemp
    End Sub

    Private Sub bitacora()
        Dim dssubreporte As New DataSet
        Dim snombrecajero As String = DevuelveDato("SELECT nombrecompleto FROM usuarios WHERE id = " & lblidusuario.Text, _conexionsuperpos)

        'Datos corte
        _dsrpt = LlenarDataset("SELECT DISTINCT dt.idusuarios, dt.Codigopago, fp.nombre NombrePago, Monto Venta, montodepositos Depositos, montoparciales Retiros, -montodiferencia Diferencia FROM detalletotales dt INNER JOIN totales t ON (dt.IdUsuarios = t.idusuarios  AND dt.fecha = t.fecha) INNER JOIN formasdepago fp ON dt.codigopago = fp.codigopago WHERE t.estado = 0 AND t.fecha = '" & lblfechainicial.Text & "' AND t.idusuarios = " & lblidusuario.Text & " ORDER BY fp.id", _conexionsuperpos)

        'Datos retiros
        dssubreporte = LlenarDataset("SELECT dp.codigopago, fp.nombre nombrepago, monto, fechahora FROM detalleparciales dp INNER JOIN formasdepago fp ON dp.codigopago = fp.codigopago WHERE monto < 0 AND idusuarios = " & lblidusuario.Text & " AND fecha >= '" & lblfechainicial.Text & "' AND fecha <= '" & lblfechafinal.Text & "' ORDER BY fechahora ASC", _conexionsuperpos)

        'Prepara el reporte  y el subreprote para presentarlo en pantalla
        Dim rpttemp As New rptbitacora
        rpttemp.SetDataSource(_dsrpt.Tables(0))
        rpttemp.Subreports(0).SetDataSource(dssubreporte.Tables(0))

        _parametro4.ParameterFieldName = "nombrecajero"
        _valor4.Value = snombrecajero
        _parametro4.CurrentValues.Add(_valor4)
        _parametros.Add(_parametro4)

        crvreportes.ParameterFieldInfo = _parametros
        crvreportes.ReportSource = rpttemp
    End Sub

#End Region

End Class