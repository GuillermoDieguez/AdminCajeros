<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdeposito
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
        Me.panellistado = New System.Windows.Forms.Panel
        Me.panelcolores = New System.Windows.Forms.Panel
        Me.lblconcorte = New System.Windows.Forms.Label
        Me.lblcondeposito = New System.Windows.Forms.Label
        Me.lblcolorcorte = New System.Windows.Forms.Label
        Me.lblcolordeposito = New System.Windows.Forms.Label
        Me.lstvcajeros = New System.Windows.Forms.ListView
        Me.paneldeposito = New System.Windows.Forms.Panel
        Me.lblnombrecajerodep = New System.Windows.Forms.Label
        Me.dgdatosdep = New System.Windows.Forms.DataGridView
        Me.cmbcajadep = New System.Windows.Forms.ComboBox
        Me.lblcajadep = New System.Windows.Forms.Label
        Me.txtmontodep = New System.Windows.Forms.TextBox
        Me.btncancelardep = New System.Windows.Forms.Button
        Me.btnguardardep = New System.Windows.Forms.Button
        Me.lblmonto = New System.Windows.Forms.Label
        Me.lblcajero = New System.Windows.Forms.Label
        Me.lbltitulodep = New System.Windows.Forms.Label
        Me.btnmodificardep = New System.Windows.Forms.Button
        Me.paneltitulo = New System.Windows.Forms.Panel
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        Me.panellistado.SuspendLayout()
        Me.panelcolores.SuspendLayout()
        Me.paneldeposito.SuspendLayout()
        CType(Me.dgdatosdep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneltitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.panellistado)
        Me.panelprincipal.Controls.Add(Me.paneldeposito)
        Me.panelprincipal.Location = New System.Drawing.Point(7, 56)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1002, 645)
        Me.panelprincipal.TabIndex = 3
        '
        'panellistado
        '
        Me.panellistado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellistado.Controls.Add(Me.panelcolores)
        Me.panellistado.Controls.Add(Me.lstvcajeros)
        Me.panellistado.Location = New System.Drawing.Point(4, 4)
        Me.panellistado.Name = "panellistado"
        Me.panellistado.Size = New System.Drawing.Size(305, 635)
        Me.panellistado.TabIndex = 1
        '
        'panelcolores
        '
        Me.panelcolores.BackColor = System.Drawing.Color.White
        Me.panelcolores.Controls.Add(Me.lblconcorte)
        Me.panelcolores.Controls.Add(Me.lblcondeposito)
        Me.panelcolores.Controls.Add(Me.lblcolorcorte)
        Me.panelcolores.Controls.Add(Me.lblcolordeposito)
        Me.panelcolores.Location = New System.Drawing.Point(0, 612)
        Me.panelcolores.Name = "panelcolores"
        Me.panelcolores.Size = New System.Drawing.Size(305, 21)
        Me.panelcolores.TabIndex = 48
        '
        'lblconcorte
        '
        Me.lblconcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconcorte.Location = New System.Drawing.Point(208, 1)
        Me.lblconcorte.Name = "lblconcorte"
        Me.lblconcorte.Size = New System.Drawing.Size(93, 19)
        Me.lblconcorte.TabIndex = 6
        Me.lblconcorte.Text = "Con Corte"
        '
        'lblcondeposito
        '
        Me.lblcondeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcondeposito.Location = New System.Drawing.Point(26, 1)
        Me.lblcondeposito.Name = "lblcondeposito"
        Me.lblcondeposito.Size = New System.Drawing.Size(120, 19)
        Me.lblcondeposito.TabIndex = 7
        Me.lblcondeposito.Text = "Con Deposito"
        '
        'lblcolorcorte
        '
        Me.lblcolorcorte.BackColor = System.Drawing.Color.Black
        Me.lblcolorcorte.Location = New System.Drawing.Point(186, 1)
        Me.lblcolorcorte.Name = "lblcolorcorte"
        Me.lblcolorcorte.Size = New System.Drawing.Size(22, 19)
        Me.lblcolorcorte.TabIndex = 4
        '
        'lblcolordeposito
        '
        Me.lblcolordeposito.BackColor = System.Drawing.Color.Black
        Me.lblcolordeposito.Location = New System.Drawing.Point(4, 1)
        Me.lblcolordeposito.Name = "lblcolordeposito"
        Me.lblcolordeposito.Size = New System.Drawing.Size(22, 19)
        Me.lblcolordeposito.TabIndex = 5
        '
        'lstvcajeros
        '
        Me.lstvcajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvcajeros.FullRowSelect = True
        Me.lstvcajeros.Location = New System.Drawing.Point(2, 5)
        Me.lstvcajeros.MultiSelect = False
        Me.lstvcajeros.Name = "lstvcajeros"
        Me.lstvcajeros.Size = New System.Drawing.Size(299, 600)
        Me.lstvcajeros.TabIndex = 0
        Me.lstvcajeros.UseCompatibleStateImageBehavior = False
        '
        'paneldeposito
        '
        Me.paneldeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldeposito.Controls.Add(Me.lblnombrecajerodep)
        Me.paneldeposito.Controls.Add(Me.dgdatosdep)
        Me.paneldeposito.Controls.Add(Me.cmbcajadep)
        Me.paneldeposito.Controls.Add(Me.lblcajadep)
        Me.paneldeposito.Controls.Add(Me.txtmontodep)
        Me.paneldeposito.Controls.Add(Me.btncancelardep)
        Me.paneldeposito.Controls.Add(Me.btnguardardep)
        Me.paneldeposito.Controls.Add(Me.lblmonto)
        Me.paneldeposito.Controls.Add(Me.lblcajero)
        Me.paneldeposito.Controls.Add(Me.lbltitulodep)
        Me.paneldeposito.Controls.Add(Me.btnmodificardep)
        Me.paneldeposito.Location = New System.Drawing.Point(315, 4)
        Me.paneldeposito.Name = "paneldeposito"
        Me.paneldeposito.Size = New System.Drawing.Size(681, 635)
        Me.paneldeposito.TabIndex = 2
        '
        'lblnombrecajerodep
        '
        Me.lblnombrecajerodep.BackColor = System.Drawing.Color.White
        Me.lblnombrecajerodep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombrecajerodep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecajerodep.Location = New System.Drawing.Point(208, 64)
        Me.lblnombrecajerodep.Name = "lblnombrecajerodep"
        Me.lblnombrecajerodep.Size = New System.Drawing.Size(367, 27)
        Me.lblnombrecajerodep.TabIndex = 41
        Me.lblnombrecajerodep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgdatosdep
        '
        Me.dgdatosdep.AllowUserToAddRows = False
        Me.dgdatosdep.AllowUserToDeleteRows = False
        Me.dgdatosdep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgdatosdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdatosdep.Location = New System.Drawing.Point(8, 343)
        Me.dgdatosdep.Name = "dgdatosdep"
        Me.dgdatosdep.ReadOnly = True
        Me.dgdatosdep.RowHeadersWidth = 15
        Me.dgdatosdep.Size = New System.Drawing.Size(662, 279)
        Me.dgdatosdep.TabIndex = 7
        '
        'cmbcajadep
        '
        Me.cmbcajadep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcajadep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcajadep.FormattingEnabled = True
        Me.cmbcajadep.Location = New System.Drawing.Point(493, 131)
        Me.cmbcajadep.Name = "cmbcajadep"
        Me.cmbcajadep.Size = New System.Drawing.Size(82, 32)
        Me.cmbcajadep.TabIndex = 0
        '
        'lblcajadep
        '
        Me.lblcajadep.AutoSize = True
        Me.lblcajadep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajadep.Location = New System.Drawing.Point(103, 134)
        Me.lblcajadep.Name = "lblcajadep"
        Me.lblcajadep.Size = New System.Drawing.Size(57, 24)
        Me.lblcajadep.TabIndex = 5
        Me.lblcajadep.Text = "Caja:"
        '
        'txtmontodep
        '
        Me.txtmontodep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmontodep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontodep.Location = New System.Drawing.Point(493, 199)
        Me.txtmontodep.Name = "txtmontodep"
        Me.txtmontodep.Size = New System.Drawing.Size(82, 29)
        Me.txtmontodep.TabIndex = 2
        Me.txtmontodep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncancelardep
        '
        Me.btncancelardep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelardep.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelardep.Location = New System.Drawing.Point(485, 269)
        Me.btncancelardep.Name = "btncancelardep"
        Me.btncancelardep.Size = New System.Drawing.Size(88, 65)
        Me.btncancelardep.TabIndex = 4
        Me.btncancelardep.Text = "&Cancelar"
        Me.btncancelardep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelardep.UseVisualStyleBackColor = True
        '
        'btnguardardep
        '
        Me.btnguardardep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardardep.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardardep.Location = New System.Drawing.Point(105, 269)
        Me.btnguardardep.Name = "btnguardardep"
        Me.btnguardardep.Size = New System.Drawing.Size(88, 65)
        Me.btnguardardep.TabIndex = 3
        Me.btnguardardep.Text = "&Grabar"
        Me.btnguardardep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardardep.UseVisualStyleBackColor = True
        '
        'lblmonto
        '
        Me.lblmonto.AutoSize = True
        Me.lblmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto.Location = New System.Drawing.Point(103, 202)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(74, 24)
        Me.lblmonto.TabIndex = 0
        Me.lblmonto.Text = "Monto:"
        '
        'lblcajero
        '
        Me.lblcajero.AutoSize = True
        Me.lblcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajero.Location = New System.Drawing.Point(103, 65)
        Me.lblcajero.Name = "lblcajero"
        Me.lblcajero.Size = New System.Drawing.Size(77, 24)
        Me.lblcajero.TabIndex = 0
        Me.lblcajero.Text = "Cajero:"
        '
        'lbltitulodep
        '
        Me.lbltitulodep.AutoSize = True
        Me.lbltitulodep.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulodep.Location = New System.Drawing.Point(157, 3)
        Me.lbltitulodep.Name = "lbltitulodep"
        Me.lbltitulodep.Size = New System.Drawing.Size(364, 31)
        Me.lbltitulodep.TabIndex = 0
        Me.lbltitulodep.Text = "DEPOSITO DE EFECTIVO"
        '
        'btnmodificardep
        '
        Me.btnmodificardep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificardep.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificardep.Location = New System.Drawing.Point(295, 269)
        Me.btnmodificardep.Name = "btnmodificardep"
        Me.btnmodificardep.Size = New System.Drawing.Size(88, 65)
        Me.btnmodificardep.TabIndex = 5
        Me.btnmodificardep.Text = "&Modificar"
        Me.btnmodificardep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificardep.UseVisualStyleBackColor = True
        Me.btnmodificardep.Visible = False
        '
        'paneltitulo
        '
        Me.paneltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltitulo.Controls.Add(Me.lblfecha)
        Me.paneltitulo.Controls.Add(Me.lbltitulo)
        Me.paneltitulo.Location = New System.Drawing.Point(7, 5)
        Me.paneltitulo.Name = "paneltitulo"
        Me.paneltitulo.Size = New System.Drawing.Size(1002, 45)
        Me.paneltitulo.TabIndex = 4
        '
        'lblfecha
        '
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(670, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(330, 43)
        Me.lblfecha.TabIndex = 0
        Me.lblfecha.Text = "FECHA: "
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltitulo
        '
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(3, 2)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(421, 41)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "OPERACIONES CAJERO"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frmdeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 706)
        Me.Controls.Add(Me.panelprincipal)
        Me.Controls.Add(Me.paneltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmdeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposito a Cajero"
        Me.panelprincipal.ResumeLayout(False)
        Me.panellistado.ResumeLayout(False)
        Me.panelcolores.ResumeLayout(False)
        Me.paneldeposito.ResumeLayout(False)
        Me.paneldeposito.PerformLayout()
        CType(Me.dgdatosdep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneltitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents panellistado As System.Windows.Forms.Panel
    Friend WithEvents lstvcajeros As System.Windows.Forms.ListView
    Friend WithEvents paneldeposito As System.Windows.Forms.Panel
    Friend WithEvents lblnombrecajerodep As System.Windows.Forms.Label
    Friend WithEvents dgdatosdep As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcajadep As System.Windows.Forms.ComboBox
    Friend WithEvents lblcajadep As System.Windows.Forms.Label
    Friend WithEvents txtmontodep As System.Windows.Forms.TextBox
    Friend WithEvents btnmodificardep As System.Windows.Forms.Button
    Friend WithEvents btncancelardep As System.Windows.Forms.Button
    Friend WithEvents btnguardardep As System.Windows.Forms.Button
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents lblcajero As System.Windows.Forms.Label
    Friend WithEvents lbltitulodep As System.Windows.Forms.Label
    Friend WithEvents paneltitulo As System.Windows.Forms.Panel
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents panelcolores As System.Windows.Forms.Panel
    Friend WithEvents lblconcorte As System.Windows.Forms.Label
    Friend WithEvents lblcondeposito As System.Windows.Forms.Label
    Friend WithEvents lblcolorcorte As System.Windows.Forms.Label
    Friend WithEvents lblcolordeposito As System.Windows.Forms.Label
End Class
