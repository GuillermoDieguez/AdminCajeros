Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class frmcorte

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim _dsdatos As New DataSet
    Dim _dscajas As New DataSet
    Dim thisDate As String = DateTime.Now

    Dim DIA As Integer = DateTime.Now.ToString("dd")
    Dim MES As Integer = DateTime.Now.ToString("MM")
    Dim AÑO As Integer = DateTime.Now.ToString("yyyy")

    Dim dias As String
    Dim meses As String

    Dim iidusuario As Integer
    Dim ddiferencia As Decimal

    Private Sub frmcorteFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub frmcorteLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        

        _conexionsuperpos.ConnectionString = Sconexionsuperpos
        _conexionforma24.ConnectionString = Sconexiondbforma24


        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        panelprincipal.BackColor = Color.FromArgb(Colorpanelactivo(0), Colorpanelactivo(1), Colorpanelactivo(2))
        btncorte.Image = My.Resources.corte
        btncancelar.Image = My.Resources.cancelar

        ddiferencia = DevuelveDato("SELECT diferenciamaxima FROM parametrosadmincajeros", _conexionforma24)
        iidusuario = lblcajero.Text.Substring(0, lblcajero.Text.IndexOf(" "))
        llenargrid()
    End Sub

#Region "Botones EventHandlers"

    Private Sub btncancelarClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Close()
    End Sub

    Private Sub btncorteClick(ByVal sender As Object, ByVal e As EventArgs) Handles btncorte.Click
        Dim dtotaldiferencia As Decimal
        Dim drtemp As DataRow
        Dim banautorizacion As Boolean = True
        Dim banprioridad As Integer = 0
        Dim bancaja As Integer = 0

        For Each drtmp As DataRow In _dsdatos.Tables(0).Rows
            If drtmp("Prioridad") <> 0 Then
                banprioridad = drtmp("Prioridad")
                Exit For
            End If
        Next

        If banprioridad <> 1 Then
            If banprioridad = 2 Then
                Dim frm As New frmautorizacion

                frm.txtnombreusuario.Text = Snombreusuario
                frm.ShowDialog(Me)
                banautorizacion = frm.bancontraseña
                frm.Dispose()

            End If

            'Revision si el cajero esta logueado en LAMDPOS
            bancaja = DevuelveDato("SELECT IFNULL(cajaactual,0) caja FROM totales WHERE fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionsuperpos)

            If banautorizacion = True Then
                If bancaja = 0 Then
                    If MessageBox.Show("Esta seguro de realizar el corte" & vbCrLf & "Esta accion no se puede deshacer", Smsginfo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'Verifica que no se le haya realizado el corte al cajero
                        drtemp = DevuelveFila("SELECT idusuarios,estado FROM totales WHERE fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionsuperpos)

                        If IsNothing(drtemp) OrElse drtemp("estado") = 1 Then
                            'Actualiza el montodiferencia de cada forma de pago
                            EjecutaComandosql("UPDATE detalletotales SET montodiferencia = montofisico WHERE idsucursales = " & Sucursallocal & " AND fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionsuperpos)

                            'Calcula el total de diferencia del cajero
                            dtotaldiferencia = DevuelveDato("SELECT IFNULL(SUM(montodiferencia),0) FROM detalletotales WHERE idsucursales = " & Sucursallocal & " AND fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionsuperpos)

                            'Actualiza el total de diferencia y realiza el corte al cajero (estado = 0)
                            EjecutaComandosql("UPDATE totales SET estado = 0, montodiferencias = " & dtotaldiferencia & " WHERE fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionsuperpos)

                            'Actualiza el estado de la bandera concorteprograma en la tabla ctrloperacionescajero
                            EjecutaComandosql("UPDATE ctrloperacionescajero SET concorteprograma = 1 WHERE fecha = '" & Sfecha & "' AND idusuarios = " & iidusuario, _conexionforma24)

                            MessageBox.Show("Corte realizado al cajero" & vbCrLf & lblcajero.Text, Smsginfo, MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Dim frmtemp As New frmvisorreportes("CORTE")
                            frmtemp.lblfechainicial.Text = Sfecha
                            frmtemp.lblfechafinal.Text = Sfecha
                            frmtemp.lblidusuario.Text = iidusuario

                            frmtemp.ShowDialog(Me)
                            frmtemp.Dispose()
                            Close()
                        Else
                            MessageBox.Show("Ya se le realizo el corte al cajero", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MessageBox.Show("El cajero esta logueado en LAMDPOS" & vbNewLine & "Para realizar el corte debe sacar al cajero de LAMDPOS", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Error, no se ha realizado el deposito" & vbNewLine & "Para poder realizar el corte debe hacerle el deposito al cajero", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "DataGrid EventHandlers"

    Private Sub dgdatosDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdatos.DoubleClick
        Frmmodificarretiro.lblnombrecajero.Text = lblcajero.Text
        Frmmodificarretiro.ShowDialog(Me)

        llenargrid()
    End Sub

#End Region

#Region "Funciones"

    Private Sub llenargrid()
        _dsdatos = LlenarDataset("SELECT fp.Codigopago, fp.Nombre, IFNULL(monto,0) Total, IFNULL(montodepositos,0) Deposito, IFNULL(montoparciales,0) Retiros, -IFNULL(montofisico,0) Diferencia, '' Advertencia, 0 Prioridad FROM formasdepago fp LEFT JOIN (SELECT codigopago, monto, montoparciales, montodepositos, montofisico FROM detalletotales WHERE Fecha = '" & Sfecha & "' AND IdUsuarios = " & iidusuario & " AND IdSucursales = " & Sucursallocal & ") dt ON dt.CodigoPago = fp.CodigoPago ORDER BY fp.id", _conexionsuperpos)

        dgdatos.DataSource = _dsdatos.Tables(0)
        dgdatos.ClearSelection()

        With dgdatos
            .Columns("Codigopago").Width = 100
            .Columns("Nombre").Width = 120
            .Columns("Total").DefaultCellStyle.Format = "n"
            .Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Total").Width = 85
            .Columns("Retiros").DefaultCellStyle.Format = "n"
            .Columns("Retiros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Retiros").Width = 85
            .Columns("Deposito").DefaultCellStyle.Format = "n"
            .Columns("Deposito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Deposito").Width = 85
            .Columns("Diferencia").DefaultCellStyle.Format = "n"
            .Columns("Diferencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Diferencia").Width = 85
            .Columns("Advertencia").Width = 240
            .Columns("Prioridad").Visible = False

            .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
        End With

        'Desactiva ordenamiento del datagrid
        For i = 0 To dgdatos.Columns.Count - 1
            dgdatos.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i

        'Indica el color de la fila segun el tipo sobrantes, faltantes
        For i = 0 To dgdatos.Rows.Count - 1
            If dgdatos("Diferencia", i).Value > 0 Then
                dgdatos.Rows(i).DefaultCellStyle.BackColor = Color.FromName(Scolorsobrantes)
            ElseIf dgdatos("Diferencia", i).Value < 0 Then
                dgdatos.Rows(i).DefaultCellStyle.BackColor = Color.FromName(Scolorfaltantes)
            End If
        Next

        lbltotdiferencia.Text = String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(diferencia)", "codigopago = codigopago"))
        lbltotdepositos.Text = String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(deposito)", "codigopago = codigopago"))
        lbltotretiros.Text = String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(retiros)", "codigopago = codigopago"))
        lbltotventa.Text = String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(total)", "codigopago = codigopago"))

        reglasvalidacion()
    End Sub

    Private Sub reglasvalidacion()
        For Each drtemp As DataRow In _dsdatos.Tables(0).Rows
            If drtemp("Total") = 0 And drtemp("Retiros") > 0 Then
                drtemp("Advertencia") = "Se realizo un retiro de mas"
                drtemp("Prioridad") = 2
            ElseIf drtemp("Total") > 0 And drtemp("Retiros") = 0 Then
                drtemp("Advertencia") = "No se realizo un retiro"
                drtemp("Prioridad") = 2
            ElseIf drtemp("CodigoPago") = "EF" Then
                If drtemp("Deposito") = 0 Then
                    drtemp("Advertencia") = "No se ha realizado el Deposito"
                    drtemp("Prioridad") = 1
                ElseIf Math.Abs(drtemp("Diferencia")) > ddiferencia Then
                    drtemp("Advertencia") = "Diferencia muy grande"
                    drtemp("Prioridad") = 2
                End If
            Else
                If drtemp("Diferencia") <> 0 Then
                    drtemp("Advertencia") = "Existe diferencia"
                    drtemp("Prioridad") = 2
                End If
            End If
        Next
    End Sub

#End Region

    Private Sub panelprincipal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelprincipal.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincro.Click
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        thisDate = DateString
    End Sub
End Class

