<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmautorizacion
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
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.txtcontraseña = New System.Windows.Forms.TextBox
        Me.txtnombreusuario = New System.Windows.Forms.TextBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblmensaje = New System.Windows.Forms.Label
        Me.lblcontraseña = New System.Windows.Forms.Label
        Me.lblnombreusuario = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.btncancelar)
        Me.panelprincipal.Controls.Add(Me.btnaceptar)
        Me.panelprincipal.Controls.Add(Me.txtcontraseña)
        Me.panelprincipal.Controls.Add(Me.txtnombreusuario)
        Me.panelprincipal.Controls.Add(Me.lbltitulo)
        Me.panelprincipal.Controls.Add(Me.lblmensaje)
        Me.panelprincipal.Controls.Add(Me.lblcontraseña)
        Me.panelprincipal.Controls.Add(Me.lblnombreusuario)
        Me.panelprincipal.Location = New System.Drawing.Point(5, 3)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(395, 207)
        Me.panelprincipal.TabIndex = 1
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(254, 141)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 30)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(135, 141)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(103, 30)
        Me.btnaceptar.TabIndex = 2
        Me.btnaceptar.Text = "&Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(211, 109)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(146, 26)
        Me.txtcontraseña.TabIndex = 1
        '
        'txtnombreusuario
        '
        Me.txtnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreusuario.Location = New System.Drawing.Point(211, 76)
        Me.txtnombreusuario.Name = "txtnombreusuario"
        Me.txtnombreusuario.Size = New System.Drawing.Size(146, 26)
        Me.txtnombreusuario.TabIndex = 0
        '
        'lbltitulo
        '
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(3, 5)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(386, 64)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "Para poder realizar el corte con las advertencias encontradas debe indicar su usu" & _
            "ario y contraseña de supervisor de cajas"
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.Location = New System.Drawing.Point(63, 178)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(266, 20)
        Me.lblmensaje.TabIndex = 0
        Me.lblmensaje.Text = "Usuario o contraseña incorrecta"
        Me.lblmensaje.Visible = False
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(36, 112)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(107, 20)
        Me.lblcontraseña.TabIndex = 0
        Me.lblcontraseña.Text = "Contraseña:"
        '
        'lblnombreusuario
        '
        Me.lblnombreusuario.AutoSize = True
        Me.lblnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreusuario.Location = New System.Drawing.Point(36, 79)
        Me.lblnombreusuario.Name = "lblnombreusuario"
        Me.lblnombreusuario.Size = New System.Drawing.Size(168, 20)
        Me.lblnombreusuario.TabIndex = 0
        Me.lblnombreusuario.Text = "Nombre de Usuario:"
        '
        'frmautorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 213)
        Me.Controls.Add(Me.panelprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmautorizacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmautorizacion"
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblnombreusuario As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
End Class
