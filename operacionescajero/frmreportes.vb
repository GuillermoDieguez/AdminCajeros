Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class frmreportes

    ReadOnly _conexionsuperpos As New MySqlConnection

    Dim _dsdatos As New DataSet

    Dim sreporte As String

    Private Sub frmreportes_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub frmreportes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        BackColor = Color.FromArgb(Colorformulario(0), Colorformulario(1), Colorformulario(2))
        Icon = My.Resources.reportes
        panelprincipal.BackColor = Color.FromArgb(Colorpanelprincipal(0), Colorpanelprincipal(1), Colorpanelprincipal(2))
        panelfiltros.BackColor = Color.FromArgb(Colorpanelactivo(0), Colorpanelactivo(1), Colorpanelactivo(2))

        btncancelar.Image = My.Resources.cancelar
        btnverreporte.Image = My.Resources.reporte
        pbreporte1.Image = My.Resources.modificarfp
        pbreporte2.Image = My.Resources.modificar
        pbreporte3.Image = My.Resources.retiro
        pbreporte4.Image = My.Resources.corte
        pbreporte5.Image = My.Resources.bitacora


        panelfiltros.Enabled = False

        'Llena el combobox de cajeros
        _dsdatos = LlenarDataset("SELECT id, nombrecompleto FROM usuarios WHERE idnivel = 1 AND activo = 1 ORDER BY nombrecompleto ASC ", _conexionsuperpos)
        For Each dr As DataRow In _dsdatos.Tables(0).Rows
            cmbcajeros.Items.Add(dr("id") & " " & dr("nombrecompleto"))
        Next
    End Sub

#Region "Botones EventHandlers"

    Private Sub btnverreporte_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnverreporte.Click
        Dim frmtemp As New frmvisorreportes(sreporte)
        frmtemp.lblfechafinal.Text = String.Format("{0:yyyy/MM/dd}", CDate(dtfechafin.Value))
        frmtemp.lblfechainicial.Text = String.Format("{0:yyyy/MM/dd}", CDate(dtfechaini.Value))

        If sreporte = "RETIROS" Or sreporte = "CORTE" Or sreporte = "BITACORA" Then
            If cmbcajeros.SelectedIndex = -1 Then
                MessageBox.Show("Indique un cajero para poder visualizar el reporte.", Smsgerror, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmtemp.lblidusuario.Text = cmbcajeros.SelectedItem.ToString.Remove(cmbcajeros.SelectedItem.ToString.IndexOf(" "))
                frmtemp.lblfechafinal = frmtemp.lblfechainicial
                frmtemp.ShowDialog(Me)
            End If
        ElseIf sreporte = "CUADRE" Then
            frmReporteCajero.ShowDialog(Me)
        Else
            frmtemp.ShowDialog(Me)
        End If

        frmtemp.Dispose()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncancelar.Click
        Close()
    End Sub

#End Region

#Region "Reportes EventHandlers"

    Private Sub reporte1Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte1.Click, lbltitulorpt1.Click, lbldescripcionrpt1.Click
        sreporte = "LOGCAMBIOFP"

        panelrpt1.BackColor = Color.White
        panelrpt2.BackColor = Color.Transparent
        panelrpt3.BackColor = Color.Transparent
        panelrpt4.BackColor = Color.Transparent
        panelRpt6.BackColor = Color.Transparent

        panelfiltros.Enabled = True
        dtfechafin.Enabled = True
        cmbcajeros.Enabled = False
    End Sub

    Private Sub reporte2Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte2.Click, lbltitulorpt2.Click, lbldescripcionrpt2.Click
        sreporte = "LOGCAMBIORETIRO"

        panelrpt1.BackColor = Color.Transparent
        panelrpt2.BackColor = Color.White
        panelrpt3.BackColor = Color.Transparent
        panelrpt4.BackColor = Color.Transparent
        panelrpt5.BackColor = Color.Transparent
        panelRpt6.BackColor = Color.Transparent

        panelfiltros.Enabled = True
        dtfechafin.Enabled = True
        cmbcajeros.Enabled = False
    End Sub

    Private Sub reporte3Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte3.Click, lbltitulorpt3.Click, lbldescripcionrpt3.Click
        sreporte = "RETIROS"

        panelrpt1.BackColor = Color.Transparent
        panelrpt2.BackColor = Color.Transparent
        panelrpt3.BackColor = Color.White
        panelrpt4.BackColor = Color.Transparent
        panelrpt5.BackColor = Color.Transparent
        panelRpt6.BackColor = Color.Transparent

        panelfiltros.Enabled = True
        dtfechafin.Enabled = False
        cmbcajeros.Enabled = True
    End Sub

    Private Sub reporte4Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte4.Click, lbltitulorpt4.Click, lbldescripcionrpt4.Click
        sreporte = "CORTE"

        panelrpt1.BackColor = Color.Transparent
        panelrpt2.BackColor = Color.Transparent
        panelrpt3.BackColor = Color.Transparent
        panelrpt4.BackColor = Color.White
        panelrpt5.BackColor = Color.Transparent
        panelRpt6.BackColor = Color.Transparent

        panelfiltros.Enabled = True
        dtfechafin.Enabled = False
        cmbcajeros.Enabled = True
    End Sub

    Private Sub reporte5Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte5.Click, lbltitulorpt5.Click, lbldescripcionrpt5.Click
        sreporte = "BITACORA"

        panelrpt1.BackColor = Color.Transparent
        panelrpt2.BackColor = Color.Transparent
        panelrpt3.BackColor = Color.Transparent
        panelrpt4.BackColor = Color.Transparent
        panelrpt5.BackColor = Color.White
        panelRpt6.BackColor = Color.Transparent

        panelfiltros.Enabled = True
        dtfechafin.Enabled = False
        cmbcajeros.Enabled = True
    End Sub

    Private Sub reporte6Click(ByVal sender As Object, ByVal e As EventArgs) Handles pcbReporte6.Click, lbltitulorpt6.Click, lblDescripcionRpt6.Click
        sreporte = "CUADRE"

        panelrpt1.BackColor = Color.Transparent
        panelrpt2.BackColor = Color.Transparent
        panelrpt3.BackColor = Color.Transparent
        panelrpt4.BackColor = Color.Transparent
        panelrpt5.BackColor = Color.Transparent
        panelRpt6.BackColor = Color.White

        panelfiltros.Enabled = False
        dtfechafin.Enabled = False
        cmbcajeros.Enabled = False
    End Sub

    Private Sub rpt1MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte1.MouseEnter, lbltitulorpt1.MouseEnter, lbldescripcionrpt1.MouseEnter
        pbreporte1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub rpt1MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte1.MouseLeave, lbltitulorpt1.MouseLeave, lbldescripcionrpt1.MouseLeave
        pbreporte1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub rpt2MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte2.MouseEnter, lbltitulorpt2.MouseEnter, lbldescripcionrpt2.MouseEnter
        pbreporte2.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub rpt2MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte2.MouseLeave, lbltitulorpt2.MouseLeave, lbldescripcionrpt2.MouseLeave
        pbreporte2.BorderStyle = BorderStyle.None
    End Sub

    Private Sub rpt3MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte3.MouseEnter, lbltitulorpt3.MouseEnter, lbldescripcionrpt3.MouseEnter
        pbreporte3.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub rpt3MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte3.MouseLeave, lbltitulorpt3.MouseLeave, lbldescripcionrpt3.MouseLeave
        pbreporte3.BorderStyle = BorderStyle.None
    End Sub

    Private Sub rpt4MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte4.MouseEnter, lbltitulorpt4.MouseEnter, lbldescripcionrpt4.MouseEnter
        pbreporte4.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub rpt4MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte4.MouseLeave, lbltitulorpt4.MouseLeave, lbldescripcionrpt4.MouseLeave
        pbreporte4.BorderStyle = BorderStyle.None
    End Sub

    Private Sub rpt5MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte5.MouseEnter, lbltitulorpt5.MouseEnter, lbldescripcionrpt5.MouseEnter
        pbreporte5.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub rpt5MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbreporte5.MouseLeave, lbltitulorpt5.MouseLeave, lbldescripcionrpt5.MouseLeave
        pbreporte5.BorderStyle = BorderStyle.None
    End Sub

#End Region

    Private Sub lbltitulorpt1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbltitulorpt1.LinkClicked

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcionRpt6.Click

    End Sub

    Private Sub panelrpt5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelrpt5.Paint

    End Sub

    Private Sub lbltitulorpt4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbltitulorpt4.LinkClicked

    End Sub
End Class