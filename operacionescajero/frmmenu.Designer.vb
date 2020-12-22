<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmenu
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
        Me.pbdeposito = New System.Windows.Forms.PictureBox
        Me.pbretiro = New System.Windows.Forms.PictureBox
        Me.pbmodificarfp = New System.Windows.Forms.PictureBox
        Me.lbldeposito = New System.Windows.Forms.Label
        Me.lblretiro = New System.Windows.Forms.Label
        Me.lblmodificarfp = New System.Windows.Forms.Label
        Me.panelprincipal = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblreportes = New System.Windows.Forms.Label
        Me.lblsalir = New System.Windows.Forms.Label
        Me.pbreportes = New System.Windows.Forms.PictureBox
        Me.pbsalir = New System.Windows.Forms.PictureBox
        CType(Me.pbdeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbretiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmodificarfp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelprincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbreportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbdeposito
        '
        Me.pbdeposito.BackColor = System.Drawing.Color.White
        Me.pbdeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbdeposito.Location = New System.Drawing.Point(3, 5)
        Me.pbdeposito.Name = "pbdeposito"
        Me.pbdeposito.Size = New System.Drawing.Size(48, 58)
        Me.pbdeposito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbdeposito.TabIndex = 1
        Me.pbdeposito.TabStop = False
        '
        'pbretiro
        '
        Me.pbretiro.BackColor = System.Drawing.Color.White
        Me.pbretiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbretiro.Location = New System.Drawing.Point(188, 5)
        Me.pbretiro.Name = "pbretiro"
        Me.pbretiro.Size = New System.Drawing.Size(48, 58)
        Me.pbretiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbretiro.TabIndex = 1
        Me.pbretiro.TabStop = False
        '
        'pbmodificarfp
        '
        Me.pbmodificarfp.BackColor = System.Drawing.Color.White
        Me.pbmodificarfp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbmodificarfp.Location = New System.Drawing.Point(3, 69)
        Me.pbmodificarfp.Name = "pbmodificarfp"
        Me.pbmodificarfp.Size = New System.Drawing.Size(48, 58)
        Me.pbmodificarfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbmodificarfp.TabIndex = 1
        Me.pbmodificarfp.TabStop = False
        '
        'lbldeposito
        '
        Me.lbldeposito.BackColor = System.Drawing.Color.White
        Me.lbldeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbldeposito.Location = New System.Drawing.Point(50, 5)
        Me.lbldeposito.Name = "lbldeposito"
        Me.lbldeposito.Size = New System.Drawing.Size(132, 58)
        Me.lbldeposito.TabIndex = 2
        Me.lbldeposito.Text = "Deposito de Efectivo"
        Me.lbldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblretiro
        '
        Me.lblretiro.BackColor = System.Drawing.Color.White
        Me.lblretiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblretiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblretiro.Location = New System.Drawing.Point(235, 5)
        Me.lblretiro.Name = "lblretiro"
        Me.lblretiro.Size = New System.Drawing.Size(132, 58)
        Me.lblretiro.TabIndex = 2
        Me.lblretiro.Text = "Retiro Final"
        Me.lblretiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmodificarfp
        '
        Me.lblmodificarfp.BackColor = System.Drawing.Color.White
        Me.lblmodificarfp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodificarfp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblmodificarfp.Location = New System.Drawing.Point(50, 69)
        Me.lblmodificarfp.Name = "lblmodificarfp"
        Me.lblmodificarfp.Size = New System.Drawing.Size(132, 58)
        Me.lblmodificarfp.TabIndex = 2
        Me.lblmodificarfp.Text = "Modificar Forma de Pago"
        Me.lblmodificarfp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.Label2)
        Me.panelprincipal.Controls.Add(Me.Label1)
        Me.panelprincipal.Controls.Add(Me.PictureBox1)
        Me.panelprincipal.Controls.Add(Me.pbdeposito)
        Me.panelprincipal.Controls.Add(Me.lblreportes)
        Me.panelprincipal.Controls.Add(Me.lblsalir)
        Me.panelprincipal.Controls.Add(Me.pbreportes)
        Me.panelprincipal.Controls.Add(Me.pbretiro)
        Me.panelprincipal.Controls.Add(Me.lblmodificarfp)
        Me.panelprincipal.Controls.Add(Me.pbmodificarfp)
        Me.panelprincipal.Controls.Add(Me.lblretiro)
        Me.panelprincipal.Controls.Add(Me.pbsalir)
        Me.panelprincipal.Controls.Add(Me.lbldeposito)
        Me.panelprincipal.Location = New System.Drawing.Point(4, 3)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(373, 294)
        Me.panelprincipal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Versión: 1.6.10.2020"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(235, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 58)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gift Card"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.admincajeros.My.Resources.Resources.gift
        Me.PictureBox1.Location = New System.Drawing.Point(188, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblreportes
        '
        Me.lblreportes.BackColor = System.Drawing.Color.White
        Me.lblreportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblreportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblreportes.Location = New System.Drawing.Point(235, 69)
        Me.lblreportes.Name = "lblreportes"
        Me.lblreportes.Size = New System.Drawing.Size(132, 58)
        Me.lblreportes.TabIndex = 2
        Me.lblreportes.Text = "Reportes"
        Me.lblreportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsalir
        '
        Me.lblsalir.BackColor = System.Drawing.Color.White
        Me.lblsalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblsalir.Location = New System.Drawing.Point(153, 203)
        Me.lblsalir.Name = "lblsalir"
        Me.lblsalir.Size = New System.Drawing.Size(132, 58)
        Me.lblsalir.TabIndex = 2
        Me.lblsalir.Text = "Salir"
        Me.lblsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbreportes
        '
        Me.pbreportes.BackColor = System.Drawing.Color.White
        Me.pbreportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbreportes.Location = New System.Drawing.Point(188, 69)
        Me.pbreportes.Name = "pbreportes"
        Me.pbreportes.Size = New System.Drawing.Size(48, 58)
        Me.pbreportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreportes.TabIndex = 1
        Me.pbreportes.TabStop = False
        '
        'pbsalir
        '
        Me.pbsalir.BackColor = System.Drawing.Color.White
        Me.pbsalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbsalir.Location = New System.Drawing.Point(106, 203)
        Me.pbsalir.Name = "pbsalir"
        Me.pbsalir.Size = New System.Drawing.Size(48, 58)
        Me.pbsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbsalir.TabIndex = 1
        Me.pbsalir.TabStop = False
        '
        'Frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 307)
        Me.Controls.Add(Me.panelprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.pbdeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbretiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmodificarfp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbreportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbdeposito As System.Windows.Forms.PictureBox
    Friend WithEvents pbretiro As System.Windows.Forms.PictureBox
    Friend WithEvents pbmodificarfp As System.Windows.Forms.PictureBox
    Friend WithEvents lbldeposito As System.Windows.Forms.Label
    Friend WithEvents lblretiro As System.Windows.Forms.Label
    Friend WithEvents lblmodificarfp As System.Windows.Forms.Label
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents lblsalir As System.Windows.Forms.Label
    Friend WithEvents pbsalir As System.Windows.Forms.PictureBox
    Friend WithEvents lblreportes As System.Windows.Forms.Label
    Friend WithEvents pbreportes As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
