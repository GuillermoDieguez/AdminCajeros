<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgiftcard
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.calfecha = New System.Windows.Forms.DateTimePicker
        Me.pencabezado = New System.Windows.Forms.Panel
        Me.lbgiftvendidos = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbtipotransaccion = New System.Windows.Forms.ComboBox
        Me.cmdimprimir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbcajero = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgdetalle = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pencabezado.SuspendLayout()
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de Gift Card"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'calfecha
        '
        Me.calfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calfecha.Location = New System.Drawing.Point(88, 29)
        Me.calfecha.Name = "calfecha"
        Me.calfecha.Size = New System.Drawing.Size(187, 24)
        Me.calfecha.TabIndex = 2
        '
        'pencabezado
        '
        Me.pencabezado.BackColor = System.Drawing.Color.White
        Me.pencabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pencabezado.Controls.Add(Me.lbgiftvendidos)
        Me.pencabezado.Controls.Add(Me.Label5)
        Me.pencabezado.Controls.Add(Me.Button1)
        Me.pencabezado.Controls.Add(Me.cmbtipotransaccion)
        Me.pencabezado.Controls.Add(Me.cmdimprimir)
        Me.pencabezado.Controls.Add(Me.Label4)
        Me.pencabezado.Controls.Add(Me.cmbcajero)
        Me.pencabezado.Controls.Add(Me.Label3)
        Me.pencabezado.Controls.Add(Me.Label2)
        Me.pencabezado.Controls.Add(Me.calfecha)
        Me.pencabezado.Location = New System.Drawing.Point(16, 51)
        Me.pencabezado.Name = "pencabezado"
        Me.pencabezado.Size = New System.Drawing.Size(795, 97)
        Me.pencabezado.TabIndex = 3
        '
        'lbgiftvendidos
        '
        Me.lbgiftvendidos.AutoSize = True
        Me.lbgiftvendidos.Location = New System.Drawing.Point(196, 71)
        Me.lbgiftvendidos.Name = "lbgiftvendidos"
        Me.lbgiftvendidos.Size = New System.Drawing.Size(13, 13)
        Me.lbgiftvendidos.TabIndex = 10
        Me.lbgiftvendidos.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Gifcard Nuevos Vendidos"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.admincajeros.My.Resources.Resources.search_8_24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(601, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbtipotransaccion
        '
        Me.cmbtipotransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipotransaccion.FormattingEnabled = True
        Me.cmbtipotransaccion.Location = New System.Drawing.Point(427, 60)
        Me.cmbtipotransaccion.Name = "cmbtipotransaccion"
        Me.cmbtipotransaccion.Size = New System.Drawing.Size(151, 24)
        Me.cmbtipotransaccion.TabIndex = 7
        '
        'cmdimprimir
        '
        Me.cmdimprimir.BackColor = System.Drawing.Color.White
        Me.cmdimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdimprimir.Image = Global.admincajeros.My.Resources.Resources.printer_24
        Me.cmdimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdimprimir.Location = New System.Drawing.Point(688, 20)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(85, 64)
        Me.cmdimprimir.TabIndex = 5
        Me.cmdimprimir.Text = "Imprimir"
        Me.cmdimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdimprimir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Operacion"
        '
        'cmbcajero
        '
        Me.cmbcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcajero.FormattingEnabled = True
        Me.cmbcajero.Location = New System.Drawing.Point(370, 29)
        Me.cmbcajero.Name = "cmbcajero"
        Me.cmbcajero.Size = New System.Drawing.Size(208, 24)
        Me.cmbcajero.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cajero"
        '
        'dgdetalle
        '
        Me.dgdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdetalle.Location = New System.Drawing.Point(16, 164)
        Me.dgdetalle.Name = "dgdetalle"
        Me.dgdetalle.Size = New System.Drawing.Size(795, 405)
        Me.dgdetalle.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.admincajeros.My.Resources.Resources.gift
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmgiftcard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(823, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgdetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pencabezado)
        Me.Name = "frmgiftcard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GiftCard"
        Me.pencabezado.ResumeLayout(False)
        Me.pencabezado.PerformLayout()
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents pencabezado As System.Windows.Forms.Panel
    Friend WithEvents cmbcajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdimprimir As System.Windows.Forms.Button
    Friend WithEvents dgdetalle As System.Windows.Forms.DataGridView
    Friend WithEvents cmbtipotransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbgiftvendidos As System.Windows.Forms.Label
End Class
