<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmodificarretiro
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
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.panelprincipal = New System.Windows.Forms.Panel
        Me.dgdatos = New System.Windows.Forms.DataGridView
        Me.lblcodigopago = New System.Windows.Forms.Label
        Me.lblcaja = New System.Windows.Forms.Label
        Me.lblnombrecajero = New System.Windows.Forms.Label
        Me.lbltcaja = New System.Windows.Forms.Label
        Me.lblmonto = New System.Windows.Forms.Label
        Me.lbltcodigopago = New System.Windows.Forms.Label
        Me.lblcajero = New System.Windows.Forms.Label
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.lblobservaciones = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmodificar
        '
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificar.Location = New System.Drawing.Point(143, 554)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 65)
        Me.btnmodificar.TabIndex = 3
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.dgdatos)
        Me.panelprincipal.Controls.Add(Me.lblcodigopago)
        Me.panelprincipal.Controls.Add(Me.lblcaja)
        Me.panelprincipal.Controls.Add(Me.lblnombrecajero)
        Me.panelprincipal.Controls.Add(Me.lbltcaja)
        Me.panelprincipal.Controls.Add(Me.lblmonto)
        Me.panelprincipal.Controls.Add(Me.lbltcodigopago)
        Me.panelprincipal.Controls.Add(Me.lblcajero)
        Me.panelprincipal.Controls.Add(Me.txtobservaciones)
        Me.panelprincipal.Controls.Add(Me.lbltitulo)
        Me.panelprincipal.Controls.Add(Me.txtmonto)
        Me.panelprincipal.Controls.Add(Me.btncancelar)
        Me.panelprincipal.Controls.Add(Me.btnmodificar)
        Me.panelprincipal.Controls.Add(Me.lblobservaciones)
        Me.panelprincipal.Location = New System.Drawing.Point(0, 1)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(573, 625)
        Me.panelprincipal.TabIndex = 5
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToOrderColumns = True
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdatos.Location = New System.Drawing.Point(13, 100)
        Me.dgdatos.MultiSelect = False
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.RowHeadersWidth = 4
        Me.dgdatos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(544, 324)
        Me.dgdatos.TabIndex = 43
        '
        'lblcodigopago
        '
        Me.lblcodigopago.BackColor = System.Drawing.Color.White
        Me.lblcodigopago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigopago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigopago.Location = New System.Drawing.Point(328, 433)
        Me.lblcodigopago.Name = "lblcodigopago"
        Me.lblcodigopago.Size = New System.Drawing.Size(37, 27)
        Me.lblcodigopago.TabIndex = 42
        Me.lblcodigopago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcaja
        '
        Me.lblcaja.BackColor = System.Drawing.Color.White
        Me.lblcaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaja.Location = New System.Drawing.Point(59, 433)
        Me.lblcaja.Name = "lblcaja"
        Me.lblcaja.Size = New System.Drawing.Size(82, 27)
        Me.lblcaja.TabIndex = 42
        Me.lblcaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblnombrecajero
        '
        Me.lblnombrecajero.BackColor = System.Drawing.Color.White
        Me.lblnombrecajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombrecajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecajero.Location = New System.Drawing.Point(143, 58)
        Me.lblnombrecajero.Name = "lblnombrecajero"
        Me.lblnombrecajero.Size = New System.Drawing.Size(367, 27)
        Me.lblnombrecajero.TabIndex = 42
        Me.lblnombrecajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltcaja
        '
        Me.lbltcaja.AutoSize = True
        Me.lbltcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltcaja.Location = New System.Drawing.Point(11, 436)
        Me.lbltcaja.Name = "lbltcaja"
        Me.lbltcaja.Size = New System.Drawing.Size(45, 20)
        Me.lbltcaja.TabIndex = 13
        Me.lbltcaja.Text = "Caja:"
        '
        'lblmonto
        '
        Me.lblmonto.AutoSize = True
        Me.lblmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto.Location = New System.Drawing.Point(416, 436)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(58, 20)
        Me.lblmonto.TabIndex = 13
        Me.lblmonto.Text = "Monto:"
        '
        'lbltcodigopago
        '
        Me.lbltcodigopago.AutoSize = True
        Me.lbltcodigopago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltcodigopago.Location = New System.Drawing.Point(221, 436)
        Me.lbltcodigopago.Name = "lbltcodigopago"
        Me.lbltcodigopago.Size = New System.Drawing.Size(104, 20)
        Me.lbltcodigopago.TabIndex = 13
        Me.lbltcodigopago.Text = "Codigo Pago:"
        '
        'lblcajero
        '
        Me.lblcajero.AutoSize = True
        Me.lblcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajero.Location = New System.Drawing.Point(60, 58)
        Me.lblcajero.Name = "lblcajero"
        Me.lblcajero.Size = New System.Drawing.Size(77, 24)
        Me.lblcajero.TabIndex = 12
        Me.lblcajero.Text = "Cajero:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(127, 472)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(433, 73)
        Me.txtobservaciones.TabIndex = 2
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(138, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(295, 31)
        Me.lbltitulo.TabIndex = 11
        Me.lbltitulo.Text = "MODIFICAR RETIRO"
        '
        'txtmonto
        '
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(477, 433)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(82, 26)
        Me.txtmonto.TabIndex = 1
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(345, 554)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 65)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'lblobservaciones
        '
        Me.lblobservaciones.AutoSize = True
        Me.lblobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobservaciones.Location = New System.Drawing.Point(11, 474)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(118, 20)
        Me.lblobservaciones.TabIndex = 13
        Me.lblobservaciones.Text = "Observaciones:"
        '
        'Frmmodificarretiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 626)
        Me.Controls.Add(Me.panelprincipal)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Frmmodificarretiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Retiro"
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents lbltcodigopago As System.Windows.Forms.Label
    Friend WithEvents lblcajero As System.Windows.Forms.Label
    Friend WithEvents lblnombrecajero As System.Windows.Forms.Label
    Friend WithEvents lbltcaja As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents lblcodigopago As System.Windows.Forms.Label
    Friend WithEvents lblcaja As System.Windows.Forms.Label
    Friend WithEvents lblobservaciones As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dgdatos As System.Windows.Forms.DataGridView
End Class
