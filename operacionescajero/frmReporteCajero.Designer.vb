<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteCajero))
        Me.dgCuadre = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCajero = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.lbltotventa = New System.Windows.Forms.Label
        Me.lbltxtventa = New System.Windows.Forms.Label
        CType(Me.dgCuadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCuadre
        '
        Me.dgCuadre.AllowUserToAddRows = False
        Me.dgCuadre.AllowUserToDeleteRows = False
        Me.dgCuadre.AllowUserToOrderColumns = True
        Me.dgCuadre.AllowUserToResizeColumns = False
        Me.dgCuadre.AllowUserToResizeRows = False
        Me.dgCuadre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCuadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgCuadre, "dgCuadre")
        Me.dgCuadre.MultiSelect = False
        Me.dgCuadre.Name = "dgCuadre"
        Me.dgCuadre.ReadOnly = True
        Me.dgCuadre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCuadre.RowHeadersVisible = False
        Me.dgCuadre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmbCajero
        '
        Me.cmbCajero.FormattingEnabled = True
        resources.ApplyResources(Me.cmbCajero, "cmbCajero")
        Me.cmbCajero.Name = "cmbCajero"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        resources.ApplyResources(Me.btncancelar, "btncancelar")
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'lbltotventa
        '
        Me.lbltotventa.BackColor = System.Drawing.Color.White
        Me.lbltotventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lbltotventa, "lbltotventa")
        Me.lbltotventa.Name = "lbltotventa"
        '
        'lbltxtventa
        '
        resources.ApplyResources(Me.lbltxtventa, "lbltxtventa")
        Me.lbltxtventa.Name = "lbltxtventa"
        '
        'frmReporteCajero
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lbltotventa)
        Me.Controls.Add(Me.lbltxtventa)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCajero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgCuadre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReporteCajero"
        CType(Me.dgCuadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCuadre As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents lbltotventa As System.Windows.Forms.Label
    Friend WithEvents lbltxtventa As System.Windows.Forms.Label
End Class
