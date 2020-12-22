<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvisorreportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelprincipal = New System.Windows.Forms.Panel
        Me.crvreportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lblidusuario = New System.Windows.Forms.Label
        Me.lblfechafinal = New System.Windows.Forms.Label
        Me.lblfechainicial = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.crvreportes)
        Me.panelprincipal.Location = New System.Drawing.Point(5, 4)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1007, 739)
        Me.panelprincipal.TabIndex = 1
        '
        'crvreportes
        '
        Me.crvreportes.ActiveViewIndex = -1
        Me.crvreportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvreportes.DisplayGroupTree = False
        Me.crvreportes.EnableDrillDown = False
        Me.crvreportes.Location = New System.Drawing.Point(6, 5)
        Me.crvreportes.Name = "crvreportes"
        Me.crvreportes.SelectionFormula = ""
        Me.crvreportes.ShowCloseButton = False
        Me.crvreportes.ShowGroupTreeButton = False
        Me.crvreportes.ShowRefreshButton = False
        Me.crvreportes.ShowTextSearchButton = False
        Me.crvreportes.ShowZoomButton = False
        Me.crvreportes.Size = New System.Drawing.Size(993, 727)
        Me.crvreportes.TabIndex = 1
        Me.crvreportes.ViewTimeSelectionFormula = ""
        '
        'lblidusuario
        '
        Me.lblidusuario.BackColor = System.Drawing.Color.White
        Me.lblidusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblidusuario.Location = New System.Drawing.Point(212, 0)
        Me.lblidusuario.Name = "lblidusuario"
        Me.lblidusuario.Size = New System.Drawing.Size(100, 24)
        Me.lblidusuario.TabIndex = 8
        Me.lblidusuario.Text = "idusuario"
        Me.lblidusuario.Visible = False
        '
        'lblfechafinal
        '
        Me.lblfechafinal.BackColor = System.Drawing.Color.White
        Me.lblfechafinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfechafinal.Location = New System.Drawing.Point(106, 0)
        Me.lblfechafinal.Name = "lblfechafinal"
        Me.lblfechafinal.Size = New System.Drawing.Size(100, 24)
        Me.lblfechafinal.TabIndex = 7
        Me.lblfechafinal.Text = "fechafinal"
        Me.lblfechafinal.Visible = False
        '
        'lblfechainicial
        '
        Me.lblfechainicial.BackColor = System.Drawing.Color.White
        Me.lblfechainicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfechainicial.Location = New System.Drawing.Point(0, 0)
        Me.lblfechainicial.Name = "lblfechainicial"
        Me.lblfechainicial.Size = New System.Drawing.Size(100, 24)
        Me.lblfechainicial.TabIndex = 6
        Me.lblfechainicial.Text = "fechainicial"
        Me.lblfechainicial.Visible = False
        '
        'frmvisorreportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 746)
        Me.Controls.Add(Me.lblidusuario)
        Me.Controls.Add(Me.lblfechafinal)
        Me.Controls.Add(Me.lblfechainicial)
        Me.Controls.Add(Me.panelprincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmvisorreportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor Reportes"
        Me.panelprincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents crvreportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblidusuario As System.Windows.Forms.Label
    Friend WithEvents lblfechafinal As System.Windows.Forms.Label
    Friend WithEvents lblfechainicial As System.Windows.Forms.Label
End Class
