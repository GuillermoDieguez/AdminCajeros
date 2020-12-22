<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcorte
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
        Me.lbltotdiferencia = New System.Windows.Forms.Label
        Me.lbltotdepositos = New System.Windows.Forms.Label
        Me.lbltotretiros = New System.Windows.Forms.Label
        Me.lbltotventa = New System.Windows.Forms.Label
        Me.lbltxtdiferencia = New System.Windows.Forms.Label
        Me.lbltxtdeposito = New System.Windows.Forms.Label
        Me.lbltxtretiros = New System.Windows.Forms.Label
        Me.lbltxtventa = New System.Windows.Forms.Label
        Me.lblcajero = New System.Windows.Forms.Label
        Me.lbltxtusuario = New System.Windows.Forms.Label
        Me.dgdatos = New System.Windows.Forms.DataGridView
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btncorte = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btnSincro = New System.Windows.Forms.Button
        Me.panelprincipal.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.btnSincro)
        Me.panelprincipal.Controls.Add(Me.lbltotdiferencia)
        Me.panelprincipal.Controls.Add(Me.lbltotdepositos)
        Me.panelprincipal.Controls.Add(Me.lbltotretiros)
        Me.panelprincipal.Controls.Add(Me.lbltotventa)
        Me.panelprincipal.Controls.Add(Me.lbltxtdiferencia)
        Me.panelprincipal.Controls.Add(Me.lbltxtdeposito)
        Me.panelprincipal.Controls.Add(Me.lbltxtretiros)
        Me.panelprincipal.Controls.Add(Me.lbltxtventa)
        Me.panelprincipal.Controls.Add(Me.lblcajero)
        Me.panelprincipal.Controls.Add(Me.lbltxtusuario)
        Me.panelprincipal.Controls.Add(Me.dgdatos)
        Me.panelprincipal.Controls.Add(Me.btncancelar)
        Me.panelprincipal.Controls.Add(Me.btncorte)
        Me.panelprincipal.Controls.Add(Me.lbltitulo)
        Me.panelprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelprincipal.Location = New System.Drawing.Point(4, 4)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(812, 560)
        Me.panelprincipal.TabIndex = 0
        '
        'lbltotdiferencia
        '
        Me.lbltotdiferencia.BackColor = System.Drawing.Color.White
        Me.lbltotdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotdiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotdiferencia.Location = New System.Drawing.Point(688, 444)
        Me.lbltotdiferencia.Name = "lbltotdiferencia"
        Me.lbltotdiferencia.Size = New System.Drawing.Size(116, 28)
        Me.lbltotdiferencia.TabIndex = 9
        Me.lbltotdiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotdepositos
        '
        Me.lbltotdepositos.BackColor = System.Drawing.Color.White
        Me.lbltotdepositos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotdepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotdepositos.Location = New System.Drawing.Point(284, 444)
        Me.lbltotdepositos.Name = "lbltotdepositos"
        Me.lbltotdepositos.Size = New System.Drawing.Size(116, 28)
        Me.lbltotdepositos.TabIndex = 9
        Me.lbltotdepositos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotretiros
        '
        Me.lbltotretiros.BackColor = System.Drawing.Color.White
        Me.lbltotretiros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotretiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotretiros.Location = New System.Drawing.Point(474, 444)
        Me.lbltotretiros.Name = "lbltotretiros"
        Me.lbltotretiros.Size = New System.Drawing.Size(116, 28)
        Me.lbltotretiros.TabIndex = 9
        Me.lbltotretiros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotventa
        '
        Me.lbltotventa.BackColor = System.Drawing.Color.White
        Me.lbltotventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotventa.Location = New System.Drawing.Point(67, 444)
        Me.lbltotventa.Name = "lbltotventa"
        Me.lbltotventa.Size = New System.Drawing.Size(116, 28)
        Me.lbltotventa.TabIndex = 9
        Me.lbltotventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltxtdiferencia
        '
        Me.lbltxtdiferencia.AutoSize = True
        Me.lbltxtdiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtdiferencia.Location = New System.Drawing.Point(591, 448)
        Me.lbltxtdiferencia.Name = "lbltxtdiferencia"
        Me.lbltxtdiferencia.Size = New System.Drawing.Size(96, 20)
        Me.lbltxtdiferencia.TabIndex = 8
        Me.lbltxtdiferencia.Text = "Diferencia:"
        '
        'lbltxtdeposito
        '
        Me.lbltxtdeposito.AutoSize = True
        Me.lbltxtdeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtdeposito.Location = New System.Drawing.Point(194, 448)
        Me.lbltxtdeposito.Name = "lbltxtdeposito"
        Me.lbltxtdeposito.Size = New System.Drawing.Size(95, 20)
        Me.lbltxtdeposito.TabIndex = 8
        Me.lbltxtdeposito.Text = "Depositos:"
        '
        'lbltxtretiros
        '
        Me.lbltxtretiros.AutoSize = True
        Me.lbltxtretiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtretiros.Location = New System.Drawing.Point(406, 448)
        Me.lbltxtretiros.Name = "lbltxtretiros"
        Me.lbltxtretiros.Size = New System.Drawing.Size(72, 20)
        Me.lbltxtretiros.TabIndex = 8
        Me.lbltxtretiros.Text = "Retiros:"
        '
        'lbltxtventa
        '
        Me.lbltxtventa.AutoSize = True
        Me.lbltxtventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtventa.Location = New System.Drawing.Point(8, 448)
        Me.lbltxtventa.Name = "lbltxtventa"
        Me.lbltxtventa.Size = New System.Drawing.Size(62, 20)
        Me.lbltxtventa.TabIndex = 8
        Me.lbltxtventa.Text = "Venta:"
        '
        'lblcajero
        '
        Me.lblcajero.BackColor = System.Drawing.Color.White
        Me.lblcajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcajero.Location = New System.Drawing.Point(78, 49)
        Me.lblcajero.Name = "lblcajero"
        Me.lblcajero.Size = New System.Drawing.Size(727, 25)
        Me.lblcajero.TabIndex = 7
        Me.lblcajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltxtusuario
        '
        Me.lbltxtusuario.AutoSize = True
        Me.lbltxtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtusuario.Location = New System.Drawing.Point(6, 52)
        Me.lbltxtusuario.Name = "lbltxtusuario"
        Me.lbltxtusuario.Size = New System.Drawing.Size(66, 20)
        Me.lbltxtusuario.TabIndex = 7
        Me.lbltxtusuario.Text = "Cajero:"
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToOrderColumns = True
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        Me.dgdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdatos.Location = New System.Drawing.Point(8, 85)
        Me.dgdatos.MultiSelect = False
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.RowHeadersWidth = 4
        Me.dgdatos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(795, 356)
        Me.dgdatos.TabIndex = 6
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(485, 490)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(127, 65)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btncorte
        '
        Me.btncorte.Enabled = False
        Me.btncorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncorte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncorte.Location = New System.Drawing.Point(324, 490)
        Me.btncorte.Name = "btncorte"
        Me.btncorte.Size = New System.Drawing.Size(127, 65)
        Me.btncorte.TabIndex = 3
        Me.btncorte.Text = "Corte Cajero"
        Me.btncorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncorte.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(278, 8)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(254, 29)
        Me.lbltitulo.TabIndex = 1
        Me.lbltitulo.Text = "CORTE DE CAJERO"
        '
        'btnSincro
        '
        Me.btnSincro.Enabled = False
        Me.btnSincro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSincro.Location = New System.Drawing.Point(162, 490)
        Me.btnSincro.Name = "btnSincro"
        Me.btnSincro.Size = New System.Drawing.Size(127, 65)
        Me.btnSincro.TabIndex = 10
        Me.btnSincro.Text = "Sinconización de Data"
        Me.btnSincro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSincro.UseVisualStyleBackColor = True
        '
        'frmcorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 568)
        Me.Controls.Add(Me.panelprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcorte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arqueo Cajero"
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btncorte As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents dgdatos As System.Windows.Forms.DataGridView
    Friend WithEvents lblcajero As System.Windows.Forms.Label
    Friend WithEvents lbltxtusuario As System.Windows.Forms.Label
    Friend WithEvents lbltotdiferencia As System.Windows.Forms.Label
    Friend WithEvents lbltotretiros As System.Windows.Forms.Label
    Friend WithEvents lbltotventa As System.Windows.Forms.Label
    Friend WithEvents lbltxtdiferencia As System.Windows.Forms.Label
    Friend WithEvents lbltxtretiros As System.Windows.Forms.Label
    Friend WithEvents lbltxtventa As System.Windows.Forms.Label
    Friend WithEvents lbltotdepositos As System.Windows.Forms.Label
    Friend WithEvents lbltxtdeposito As System.Windows.Forms.Label
    Friend WithEvents btnSincro As System.Windows.Forms.Button
End Class
