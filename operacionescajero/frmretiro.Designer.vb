<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmretiro
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
        Me.lblconretiro = New System.Windows.Forms.Label
        Me.lblcolorcorte = New System.Windows.Forms.Label
        Me.lblcolorretiro = New System.Windows.Forms.Label
        Me.lstvcajeros = New System.Windows.Forms.ListView
        Me.panelretiro = New System.Windows.Forms.Panel
        Me.panelformaspago = New System.Windows.Forms.Panel
        Me.txttemporal = New System.Windows.Forms.TextBox
        Me.lbltemporal = New System.Windows.Forms.Label
        Me.lblformaspago = New System.Windows.Forms.Label
        Me.lblretiro = New System.Windows.Forms.Label
        Me.panelcajero = New System.Windows.Forms.Panel
        Me.cmbcajaret = New System.Windows.Forms.ComboBox
        Me.lblcajaret = New System.Windows.Forms.Label
        Me.lblnombrecajeroret = New System.Windows.Forms.Label
        Me.lbltitcajero = New System.Windows.Forms.Label
        Me.paneltotal = New System.Windows.Forms.Panel
        Me.lblcanttotal = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.panelacciones = New System.Windows.Forms.Panel
        Me.btncorte = New System.Windows.Forms.Button
        Me.btncancelarret = New System.Windows.Forms.Button
        Me.btnguardarret = New System.Windows.Forms.Button
        Me.btnmodificarret = New System.Windows.Forms.Button
        Me.lbltituloret = New System.Windows.Forms.Label
        Me.paneldetalleEF = New System.Windows.Forms.Panel
        Me.lbltotm001 = New System.Windows.Forms.Label
        Me.lbltotalmb = New System.Windows.Forms.Label
        Me.txtcm001 = New System.Windows.Forms.TextBox
        Me.lbldetalleefectivo = New System.Windows.Forms.Label
        Me.lbltotm50 = New System.Windows.Forms.Label
        Me.lbltotm10 = New System.Windows.Forms.Label
        Me.lbltxttotal = New System.Windows.Forms.Label
        Me.lbltotm25 = New System.Windows.Forms.Label
        Me.lbltotm5 = New System.Windows.Forms.Label
        Me.txtcm25 = New System.Windows.Forms.TextBox
        Me.lbltotb10 = New System.Windows.Forms.Label
        Me.lbltotb20 = New System.Windows.Forms.Label
        Me.lbltotm1 = New System.Windows.Forms.Label
        Me.lbltotb5 = New System.Windows.Forms.Label
        Me.lbltotb200 = New System.Windows.Forms.Label
        Me.txtcb5 = New System.Windows.Forms.TextBox
        Me.lbltotb50 = New System.Windows.Forms.Label
        Me.txtcb50 = New System.Windows.Forms.TextBox
        Me.txtcm5 = New System.Windows.Forms.TextBox
        Me.lbltotb100 = New System.Windows.Forms.Label
        Me.txtcm50 = New System.Windows.Forms.TextBox
        Me.txtcb10 = New System.Windows.Forms.TextBox
        Me.txtcb100 = New System.Windows.Forms.TextBox
        Me.txtcm10 = New System.Windows.Forms.TextBox
        Me.txtcm1 = New System.Windows.Forms.TextBox
        Me.txtcb20 = New System.Windows.Forms.TextBox
        Me.txtcb200 = New System.Windows.Forms.TextBox
        Me.lblm001 = New System.Windows.Forms.Label
        Me.lblm25 = New System.Windows.Forms.Label
        Me.lblb5 = New System.Windows.Forms.Label
        Me.lblb50 = New System.Windows.Forms.Label
        Me.lblm5 = New System.Windows.Forms.Label
        Me.lblm50 = New System.Windows.Forms.Label
        Me.lblb10 = New System.Windows.Forms.Label
        Me.lblb100 = New System.Windows.Forms.Label
        Me.lblm10 = New System.Windows.Forms.Label
        Me.lblm1 = New System.Windows.Forms.Label
        Me.lblb20 = New System.Windows.Forms.Label
        Me.lblb200 = New System.Windows.Forms.Label
        Me.paneltitulo = New System.Windows.Forms.Panel
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        Me.panellistado.SuspendLayout()
        Me.panelcolores.SuspendLayout()
        Me.panelretiro.SuspendLayout()
        Me.panelformaspago.SuspendLayout()
        Me.panelcajero.SuspendLayout()
        Me.paneltotal.SuspendLayout()
        Me.panelacciones.SuspendLayout()
        Me.paneldetalleEF.SuspendLayout()
        Me.paneltitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.panellistado)
        Me.panelprincipal.Controls.Add(Me.panelretiro)
        Me.panelprincipal.Location = New System.Drawing.Point(7, 56)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1002, 645)
        Me.panelprincipal.TabIndex = 1
        '
        'panellistado
        '
        Me.panellistado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellistado.Controls.Add(Me.panelcolores)
        Me.panellistado.Controls.Add(Me.lstvcajeros)
        Me.panellistado.Location = New System.Drawing.Point(4, 4)
        Me.panellistado.Name = "panellistado"
        Me.panellistado.Size = New System.Drawing.Size(280, 635)
        Me.panellistado.TabIndex = 1
        '
        'panelcolores
        '
        Me.panelcolores.BackColor = System.Drawing.Color.White
        Me.panelcolores.Controls.Add(Me.lblconcorte)
        Me.panelcolores.Controls.Add(Me.lblconretiro)
        Me.panelcolores.Controls.Add(Me.lblcolorcorte)
        Me.panelcolores.Controls.Add(Me.lblcolorretiro)
        Me.panelcolores.Location = New System.Drawing.Point(0, 612)
        Me.panelcolores.Name = "panelcolores"
        Me.panelcolores.Size = New System.Drawing.Size(305, 21)
        Me.panelcolores.TabIndex = 47
        '
        'lblconcorte
        '
        Me.lblconcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconcorte.Location = New System.Drawing.Point(182, 1)
        Me.lblconcorte.Name = "lblconcorte"
        Me.lblconcorte.Size = New System.Drawing.Size(93, 19)
        Me.lblconcorte.TabIndex = 6
        Me.lblconcorte.Text = "Con Corte"
        '
        'lblconretiro
        '
        Me.lblconretiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconretiro.Location = New System.Drawing.Point(26, 1)
        Me.lblconretiro.Name = "lblconretiro"
        Me.lblconretiro.Size = New System.Drawing.Size(95, 19)
        Me.lblconretiro.TabIndex = 7
        Me.lblconretiro.Text = "Con Retiro"
        '
        'lblcolorcorte
        '
        Me.lblcolorcorte.BackColor = System.Drawing.Color.Black
        Me.lblcolorcorte.Location = New System.Drawing.Point(162, 1)
        Me.lblcolorcorte.Name = "lblcolorcorte"
        Me.lblcolorcorte.Size = New System.Drawing.Size(22, 19)
        Me.lblcolorcorte.TabIndex = 4
        '
        'lblcolorretiro
        '
        Me.lblcolorretiro.BackColor = System.Drawing.Color.Black
        Me.lblcolorretiro.Location = New System.Drawing.Point(4, 1)
        Me.lblcolorretiro.Name = "lblcolorretiro"
        Me.lblcolorretiro.Size = New System.Drawing.Size(22, 19)
        Me.lblcolorretiro.TabIndex = 5
        '
        'lstvcajeros
        '
        Me.lstvcajeros.FullRowSelect = True
        Me.lstvcajeros.Location = New System.Drawing.Point(2, 5)
        Me.lstvcajeros.MultiSelect = False
        Me.lstvcajeros.Name = "lstvcajeros"
        Me.lstvcajeros.Size = New System.Drawing.Size(269, 601)
        Me.lstvcajeros.TabIndex = 1
        Me.lstvcajeros.UseCompatibleStateImageBehavior = False
        '
        'panelretiro
        '
        Me.panelretiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelretiro.Controls.Add(Me.panelformaspago)
        Me.panelretiro.Controls.Add(Me.panelcajero)
        Me.panelretiro.Controls.Add(Me.paneltotal)
        Me.panelretiro.Controls.Add(Me.panelacciones)
        Me.panelretiro.Controls.Add(Me.lbltituloret)
        Me.panelretiro.Controls.Add(Me.paneldetalleEF)
        Me.panelretiro.Location = New System.Drawing.Point(290, 5)
        Me.panelretiro.Name = "panelretiro"
        Me.panelretiro.Size = New System.Drawing.Size(706, 635)
        Me.panelretiro.TabIndex = 10
        '
        'panelformaspago
        '
        Me.panelformaspago.AutoScroll = True
        Me.panelformaspago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelformaspago.Controls.Add(Me.txttemporal)
        Me.panelformaspago.Controls.Add(Me.lbltemporal)
        Me.panelformaspago.Controls.Add(Me.lblformaspago)
        Me.panelformaspago.Controls.Add(Me.lblretiro)
        Me.panelformaspago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelformaspago.Location = New System.Drawing.Point(361, 124)
        Me.panelformaspago.Name = "panelformaspago"
        Me.panelformaspago.Size = New System.Drawing.Size(340, 381)
        Me.panelformaspago.TabIndex = 2
        '
        'txttemporal
        '
        Me.txttemporal.BackColor = System.Drawing.Color.White
        Me.txttemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttemporal.Location = New System.Drawing.Point(215, 44)
        Me.txttemporal.Name = "txttemporal"
        Me.txttemporal.ReadOnly = True
        Me.txttemporal.Size = New System.Drawing.Size(100, 27)
        Me.txttemporal.TabIndex = 25
        Me.txttemporal.Text = "txttemporal"
        Me.txttemporal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttemporal.Visible = False
        '
        'lbltemporal
        '
        Me.lbltemporal.AutoSize = True
        Me.lbltemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltemporal.Location = New System.Drawing.Point(6, 47)
        Me.lbltemporal.Name = "lbltemporal"
        Me.lbltemporal.Size = New System.Drawing.Size(102, 20)
        Me.lbltemporal.TabIndex = 24
        Me.lbltemporal.Text = "lbltemporal"
        Me.lbltemporal.Visible = False
        '
        'lblformaspago
        '
        Me.lblformaspago.AutoSize = True
        Me.lblformaspago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformaspago.Location = New System.Drawing.Point(4, 7)
        Me.lblformaspago.Name = "lblformaspago"
        Me.lblformaspago.Size = New System.Drawing.Size(154, 24)
        Me.lblformaspago.TabIndex = 27
        Me.lblformaspago.Text = "Forma de Pago"
        '
        'lblretiro
        '
        Me.lblretiro.AutoSize = True
        Me.lblretiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblretiro.Location = New System.Drawing.Point(250, 7)
        Me.lblretiro.Name = "lblretiro"
        Me.lblretiro.Size = New System.Drawing.Size(65, 24)
        Me.lblretiro.TabIndex = 26
        Me.lblretiro.Text = "Retiro"
        Me.lblretiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelcajero
        '
        Me.panelcajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcajero.Controls.Add(Me.cmbcajaret)
        Me.panelcajero.Controls.Add(Me.lblcajaret)
        Me.panelcajero.Controls.Add(Me.lblnombrecajeroret)
        Me.panelcajero.Controls.Add(Me.lbltitcajero)
        Me.panelcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelcajero.Location = New System.Drawing.Point(3, 40)
        Me.panelcajero.Name = "panelcajero"
        Me.panelcajero.Size = New System.Drawing.Size(698, 85)
        Me.panelcajero.TabIndex = 0
        '
        'cmbcajaret
        '
        Me.cmbcajaret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcajaret.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcajaret.FormattingEnabled = True
        Me.cmbcajaret.Location = New System.Drawing.Point(554, 44)
        Me.cmbcajaret.Name = "cmbcajaret"
        Me.cmbcajaret.Size = New System.Drawing.Size(82, 32)
        Me.cmbcajaret.TabIndex = 41
        '
        'lblcajaret
        '
        Me.lblcajaret.AutoSize = True
        Me.lblcajaret.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajaret.Location = New System.Drawing.Point(98, 47)
        Me.lblcajaret.Name = "lblcajaret"
        Me.lblcajaret.Size = New System.Drawing.Size(57, 24)
        Me.lblcajaret.TabIndex = 42
        Me.lblcajaret.Text = "Caja:"
        '
        'lblnombrecajeroret
        '
        Me.lblnombrecajeroret.BackColor = System.Drawing.Color.White
        Me.lblnombrecajeroret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombrecajeroret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecajeroret.Location = New System.Drawing.Point(181, 7)
        Me.lblnombrecajeroret.Name = "lblnombrecajeroret"
        Me.lblnombrecajeroret.Size = New System.Drawing.Size(455, 27)
        Me.lblnombrecajeroret.TabIndex = 40
        Me.lblnombrecajeroret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltitcajero
        '
        Me.lbltitcajero.AutoSize = True
        Me.lbltitcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitcajero.Location = New System.Drawing.Point(98, 8)
        Me.lbltitcajero.Name = "lbltitcajero"
        Me.lbltitcajero.Size = New System.Drawing.Size(77, 24)
        Me.lbltitcajero.TabIndex = 10
        Me.lbltitcajero.Text = "Cajero:"
        '
        'paneltotal
        '
        Me.paneltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltotal.Controls.Add(Me.lblcanttotal)
        Me.paneltotal.Controls.Add(Me.lbltotal)
        Me.paneltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneltotal.Location = New System.Drawing.Point(361, 504)
        Me.paneltotal.Name = "paneltotal"
        Me.paneltotal.Size = New System.Drawing.Size(340, 45)
        Me.paneltotal.TabIndex = 43
        '
        'lblcanttotal
        '
        Me.lblcanttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcanttotal.Location = New System.Drawing.Point(89, 8)
        Me.lblcanttotal.Name = "lblcanttotal"
        Me.lblcanttotal.Size = New System.Drawing.Size(243, 27)
        Me.lblcanttotal.TabIndex = 2
        Me.lblcanttotal.Text = "Label1"
        Me.lblcanttotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(1, 9)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(62, 24)
        Me.lbltotal.TabIndex = 1
        Me.lbltotal.Text = "Total:"
        '
        'panelacciones
        '
        Me.panelacciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelacciones.Controls.Add(Me.btncorte)
        Me.panelacciones.Controls.Add(Me.btncancelarret)
        Me.panelacciones.Controls.Add(Me.btnguardarret)
        Me.panelacciones.Controls.Add(Me.btnmodificarret)
        Me.panelacciones.Location = New System.Drawing.Point(3, 548)
        Me.panelacciones.Name = "panelacciones"
        Me.panelacciones.Size = New System.Drawing.Size(698, 72)
        Me.panelacciones.TabIndex = 3
        '
        'btncorte
        '
        Me.btncorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncorte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncorte.Location = New System.Drawing.Point(359, 3)
        Me.btncorte.Name = "btncorte"
        Me.btncorte.Size = New System.Drawing.Size(88, 65)
        Me.btncorte.TabIndex = 2
        Me.btncorte.Text = "C&orte"
        Me.btncorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncorte.UseVisualStyleBackColor = True
        '
        'btncancelarret
        '
        Me.btncancelarret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarret.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelarret.Location = New System.Drawing.Point(519, 3)
        Me.btncancelarret.Name = "btncancelarret"
        Me.btncancelarret.Size = New System.Drawing.Size(88, 65)
        Me.btncancelarret.TabIndex = 2
        Me.btncancelarret.Text = "&Cancelar"
        Me.btncancelarret.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelarret.UseVisualStyleBackColor = True
        '
        'btnguardarret
        '
        Me.btnguardarret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarret.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardarret.Location = New System.Drawing.Point(39, 3)
        Me.btnguardarret.Name = "btnguardarret"
        Me.btnguardarret.Size = New System.Drawing.Size(88, 65)
        Me.btnguardarret.TabIndex = 0
        Me.btnguardarret.Text = "&Grabar"
        Me.btnguardarret.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardarret.UseVisualStyleBackColor = True
        '
        'btnmodificarret
        '
        Me.btnmodificarret.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificarret.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificarret.Location = New System.Drawing.Point(199, 3)
        Me.btnmodificarret.Name = "btnmodificarret"
        Me.btnmodificarret.Size = New System.Drawing.Size(88, 65)
        Me.btnmodificarret.TabIndex = 1
        Me.btnmodificarret.Text = "&Modificar"
        Me.btnmodificarret.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificarret.UseVisualStyleBackColor = True
        '
        'lbltituloret
        '
        Me.lbltituloret.AutoSize = True
        Me.lbltituloret.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloret.Location = New System.Drawing.Point(232, 4)
        Me.lbltituloret.Name = "lbltituloret"
        Me.lbltituloret.Size = New System.Drawing.Size(215, 31)
        Me.lbltituloret.TabIndex = 41
        Me.lbltituloret.Text = "RETIRO FINAL"
        '
        'paneldetalleEF
        '
        Me.paneldetalleEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldetalleEF.Controls.Add(Me.lbltotm001)
        Me.paneldetalleEF.Controls.Add(Me.lbltotalmb)
        Me.paneldetalleEF.Controls.Add(Me.txtcm001)
        Me.paneldetalleEF.Controls.Add(Me.lbldetalleefectivo)
        Me.paneldetalleEF.Controls.Add(Me.lbltotm50)
        Me.paneldetalleEF.Controls.Add(Me.lbltotm10)
        Me.paneldetalleEF.Controls.Add(Me.lbltxttotal)
        Me.paneldetalleEF.Controls.Add(Me.lbltotm25)
        Me.paneldetalleEF.Controls.Add(Me.lbltotm5)
        Me.paneldetalleEF.Controls.Add(Me.txtcm25)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb10)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb20)
        Me.paneldetalleEF.Controls.Add(Me.lbltotm1)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb5)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb200)
        Me.paneldetalleEF.Controls.Add(Me.txtcb5)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb50)
        Me.paneldetalleEF.Controls.Add(Me.txtcb50)
        Me.paneldetalleEF.Controls.Add(Me.txtcm5)
        Me.paneldetalleEF.Controls.Add(Me.lbltotb100)
        Me.paneldetalleEF.Controls.Add(Me.txtcm50)
        Me.paneldetalleEF.Controls.Add(Me.txtcb10)
        Me.paneldetalleEF.Controls.Add(Me.txtcb100)
        Me.paneldetalleEF.Controls.Add(Me.txtcm10)
        Me.paneldetalleEF.Controls.Add(Me.txtcm1)
        Me.paneldetalleEF.Controls.Add(Me.txtcb20)
        Me.paneldetalleEF.Controls.Add(Me.txtcb200)
        Me.paneldetalleEF.Controls.Add(Me.lblm001)
        Me.paneldetalleEF.Controls.Add(Me.lblm25)
        Me.paneldetalleEF.Controls.Add(Me.lblb5)
        Me.paneldetalleEF.Controls.Add(Me.lblb50)
        Me.paneldetalleEF.Controls.Add(Me.lblm5)
        Me.paneldetalleEF.Controls.Add(Me.lblm50)
        Me.paneldetalleEF.Controls.Add(Me.lblb10)
        Me.paneldetalleEF.Controls.Add(Me.lblb100)
        Me.paneldetalleEF.Controls.Add(Me.lblm10)
        Me.paneldetalleEF.Controls.Add(Me.lblm1)
        Me.paneldetalleEF.Controls.Add(Me.lblb20)
        Me.paneldetalleEF.Controls.Add(Me.lblb200)
        Me.paneldetalleEF.Enabled = False
        Me.paneldetalleEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneldetalleEF.Location = New System.Drawing.Point(3, 124)
        Me.paneldetalleEF.Name = "paneldetalleEF"
        Me.paneldetalleEF.Size = New System.Drawing.Size(352, 425)
        Me.paneldetalleEF.TabIndex = 1
        '
        'lbltotm001
        '
        Me.lbltotm001.BackColor = System.Drawing.Color.White
        Me.lbltotm001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm001.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm001.Location = New System.Drawing.Point(237, 341)
        Me.lbltotm001.Name = "lbltotm001"
        Me.lbltotm001.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm001.TabIndex = 28
        Me.lbltotm001.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotalmb
        '
        Me.lbltotalmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalmb.Location = New System.Drawing.Point(175, 386)
        Me.lbltotalmb.Name = "lbltotalmb"
        Me.lbltotalmb.Size = New System.Drawing.Size(167, 27)
        Me.lbltotalmb.TabIndex = 2
        Me.lbltotalmb.Text = "Label1"
        Me.lbltotalmb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbltotalmb.Visible = False
        '
        'txtcm001
        '
        Me.txtcm001.BackColor = System.Drawing.Color.White
        Me.txtcm001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm001.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm001.Location = New System.Drawing.Point(9, 342)
        Me.txtcm001.Name = "txtcm001"
        Me.txtcm001.Size = New System.Drawing.Size(51, 29)
        Me.txtcm001.TabIndex = 11
        Me.txtcm001.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldetalleefectivo
        '
        Me.lbldetalleefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldetalleefectivo.Location = New System.Drawing.Point(5, 7)
        Me.lbldetalleefectivo.Name = "lbldetalleefectivo"
        Me.lbldetalleefectivo.Size = New System.Drawing.Size(190, 24)
        Me.lbldetalleefectivo.TabIndex = 27
        Me.lbldetalleefectivo.Text = "Detalle de Efectivo:"
        '
        'lbltotm50
        '
        Me.lbltotm50.BackColor = System.Drawing.Color.White
        Me.lbltotm50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm50.Location = New System.Drawing.Point(237, 233)
        Me.lbltotm50.Name = "lbltotm50"
        Me.lbltotm50.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm50.TabIndex = 28
        Me.lbltotm50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotm10
        '
        Me.lbltotm10.BackColor = System.Drawing.Color.White
        Me.lbltotm10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm10.Location = New System.Drawing.Point(237, 287)
        Me.lbltotm10.Name = "lbltotm10"
        Me.lbltotm10.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm10.TabIndex = 28
        Me.lbltotm10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltxttotal
        '
        Me.lbltxttotal.AutoSize = True
        Me.lbltxttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxttotal.Location = New System.Drawing.Point(5, 386)
        Me.lbltxttotal.Name = "lbltxttotal"
        Me.lbltxttotal.Size = New System.Drawing.Size(164, 24)
        Me.lbltxttotal.TabIndex = 1
        Me.lbltxttotal.Text = "Total Efectivo Q:"
        '
        'lbltotm25
        '
        Me.lbltotm25.BackColor = System.Drawing.Color.White
        Me.lbltotm25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm25.Location = New System.Drawing.Point(237, 260)
        Me.lbltotm25.Name = "lbltotm25"
        Me.lbltotm25.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm25.TabIndex = 28
        Me.lbltotm25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotm5
        '
        Me.lbltotm5.BackColor = System.Drawing.Color.White
        Me.lbltotm5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm5.Location = New System.Drawing.Point(237, 314)
        Me.lbltotm5.Name = "lbltotm5"
        Me.lbltotm5.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm5.TabIndex = 28
        Me.lbltotm5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcm25
        '
        Me.txtcm25.BackColor = System.Drawing.Color.White
        Me.txtcm25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm25.Location = New System.Drawing.Point(9, 261)
        Me.txtcm25.Name = "txtcm25"
        Me.txtcm25.Size = New System.Drawing.Size(51, 29)
        Me.txtcm25.TabIndex = 8
        Me.txtcm25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotb10
        '
        Me.lbltotb10.BackColor = System.Drawing.Color.White
        Me.lbltotb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb10.Location = New System.Drawing.Point(237, 152)
        Me.lbltotb10.Name = "lbltotb10"
        Me.lbltotb10.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb10.TabIndex = 28
        Me.lbltotb10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotb20
        '
        Me.lbltotb20.BackColor = System.Drawing.Color.White
        Me.lbltotb20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb20.Location = New System.Drawing.Point(237, 125)
        Me.lbltotb20.Name = "lbltotb20"
        Me.lbltotb20.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb20.TabIndex = 28
        Me.lbltotb20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotm1
        '
        Me.lbltotm1.BackColor = System.Drawing.Color.White
        Me.lbltotm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotm1.Location = New System.Drawing.Point(237, 206)
        Me.lbltotm1.Name = "lbltotm1"
        Me.lbltotm1.Size = New System.Drawing.Size(105, 28)
        Me.lbltotm1.TabIndex = 28
        Me.lbltotm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotb5
        '
        Me.lbltotb5.BackColor = System.Drawing.Color.White
        Me.lbltotb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb5.Location = New System.Drawing.Point(237, 179)
        Me.lbltotb5.Name = "lbltotb5"
        Me.lbltotb5.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb5.TabIndex = 28
        Me.lbltotb5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotb200
        '
        Me.lbltotb200.BackColor = System.Drawing.Color.White
        Me.lbltotb200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb200.Location = New System.Drawing.Point(237, 46)
        Me.lbltotb200.Name = "lbltotb200"
        Me.lbltotb200.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb200.TabIndex = 28
        Me.lbltotb200.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcb5
        '
        Me.txtcb5.BackColor = System.Drawing.Color.White
        Me.txtcb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb5.Location = New System.Drawing.Point(9, 180)
        Me.txtcb5.Name = "txtcb5"
        Me.txtcb5.Size = New System.Drawing.Size(51, 29)
        Me.txtcb5.TabIndex = 5
        Me.txtcb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotb50
        '
        Me.lbltotb50.BackColor = System.Drawing.Color.White
        Me.lbltotb50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb50.Location = New System.Drawing.Point(237, 99)
        Me.lbltotb50.Name = "lbltotb50"
        Me.lbltotb50.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb50.TabIndex = 28
        Me.lbltotb50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcb50
        '
        Me.txtcb50.BackColor = System.Drawing.Color.White
        Me.txtcb50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb50.Location = New System.Drawing.Point(9, 99)
        Me.txtcb50.Name = "txtcb50"
        Me.txtcb50.Size = New System.Drawing.Size(51, 29)
        Me.txtcb50.TabIndex = 2
        Me.txtcb50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcm5
        '
        Me.txtcm5.BackColor = System.Drawing.Color.White
        Me.txtcm5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm5.Location = New System.Drawing.Point(9, 315)
        Me.txtcm5.Name = "txtcm5"
        Me.txtcm5.Size = New System.Drawing.Size(51, 29)
        Me.txtcm5.TabIndex = 10
        Me.txtcm5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotb100
        '
        Me.lbltotb100.BackColor = System.Drawing.Color.White
        Me.lbltotb100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotb100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotb100.Location = New System.Drawing.Point(237, 72)
        Me.lbltotb100.Name = "lbltotb100"
        Me.lbltotb100.Size = New System.Drawing.Size(105, 28)
        Me.lbltotb100.TabIndex = 28
        Me.lbltotb100.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcm50
        '
        Me.txtcm50.BackColor = System.Drawing.Color.White
        Me.txtcm50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm50.Location = New System.Drawing.Point(9, 234)
        Me.txtcm50.Name = "txtcm50"
        Me.txtcm50.Size = New System.Drawing.Size(51, 29)
        Me.txtcm50.TabIndex = 7
        Me.txtcm50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcb10
        '
        Me.txtcb10.BackColor = System.Drawing.Color.White
        Me.txtcb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb10.Location = New System.Drawing.Point(9, 153)
        Me.txtcb10.Name = "txtcb10"
        Me.txtcb10.Size = New System.Drawing.Size(51, 29)
        Me.txtcb10.TabIndex = 4
        Me.txtcb10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcb100
        '
        Me.txtcb100.BackColor = System.Drawing.Color.White
        Me.txtcb100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb100.Location = New System.Drawing.Point(9, 72)
        Me.txtcb100.Name = "txtcb100"
        Me.txtcb100.Size = New System.Drawing.Size(51, 29)
        Me.txtcb100.TabIndex = 1
        Me.txtcb100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcm10
        '
        Me.txtcm10.BackColor = System.Drawing.Color.White
        Me.txtcm10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm10.Location = New System.Drawing.Point(9, 288)
        Me.txtcm10.Name = "txtcm10"
        Me.txtcm10.Size = New System.Drawing.Size(51, 29)
        Me.txtcm10.TabIndex = 9
        Me.txtcm10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcm1
        '
        Me.txtcm1.BackColor = System.Drawing.Color.White
        Me.txtcm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcm1.Location = New System.Drawing.Point(9, 207)
        Me.txtcm1.Name = "txtcm1"
        Me.txtcm1.Size = New System.Drawing.Size(51, 29)
        Me.txtcm1.TabIndex = 6
        Me.txtcm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcb20
        '
        Me.txtcb20.BackColor = System.Drawing.Color.White
        Me.txtcb20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb20.Location = New System.Drawing.Point(9, 126)
        Me.txtcb20.Name = "txtcb20"
        Me.txtcb20.Size = New System.Drawing.Size(51, 29)
        Me.txtcb20.TabIndex = 3
        Me.txtcb20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcb200
        '
        Me.txtcb200.BackColor = System.Drawing.Color.White
        Me.txtcb200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcb200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcb200.Location = New System.Drawing.Point(9, 45)
        Me.txtcb200.Name = "txtcb200"
        Me.txtcb200.Size = New System.Drawing.Size(51, 29)
        Me.txtcb200.TabIndex = 0
        Me.txtcb200.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblm001
        '
        Me.lblm001.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm001.Location = New System.Drawing.Point(60, 345)
        Me.lblm001.Name = "lblm001"
        Me.lblm001.Size = New System.Drawing.Size(174, 24)
        Me.lblm001.TabIndex = 24
        Me.lblm001.Text = "Monedas de 0.01"
        '
        'lblm25
        '
        Me.lblm25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm25.Location = New System.Drawing.Point(60, 264)
        Me.lblm25.Name = "lblm25"
        Me.lblm25.Size = New System.Drawing.Size(174, 24)
        Me.lblm25.TabIndex = 24
        Me.lblm25.Text = "Monedas de 0.25"
        '
        'lblb5
        '
        Me.lblb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb5.Location = New System.Drawing.Point(60, 183)
        Me.lblb5.Name = "lblb5"
        Me.lblb5.Size = New System.Drawing.Size(174, 24)
        Me.lblb5.TabIndex = 24
        Me.lblb5.Text = "Billetes de 5.00"
        '
        'lblb50
        '
        Me.lblb50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb50.Location = New System.Drawing.Point(60, 102)
        Me.lblb50.Name = "lblb50"
        Me.lblb50.Size = New System.Drawing.Size(174, 24)
        Me.lblb50.TabIndex = 24
        Me.lblb50.Text = "Billetes de 50.00"
        '
        'lblm5
        '
        Me.lblm5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm5.Location = New System.Drawing.Point(60, 318)
        Me.lblm5.Name = "lblm5"
        Me.lblm5.Size = New System.Drawing.Size(174, 24)
        Me.lblm5.TabIndex = 24
        Me.lblm5.Text = "Monedas de 0.05"
        '
        'lblm50
        '
        Me.lblm50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm50.Location = New System.Drawing.Point(60, 237)
        Me.lblm50.Name = "lblm50"
        Me.lblm50.Size = New System.Drawing.Size(174, 24)
        Me.lblm50.TabIndex = 24
        Me.lblm50.Text = "Monedas de 0.50"
        '
        'lblb10
        '
        Me.lblb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb10.Location = New System.Drawing.Point(60, 156)
        Me.lblb10.Name = "lblb10"
        Me.lblb10.Size = New System.Drawing.Size(174, 24)
        Me.lblb10.TabIndex = 24
        Me.lblb10.Text = "Billetes de 10.00"
        '
        'lblb100
        '
        Me.lblb100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb100.Location = New System.Drawing.Point(60, 75)
        Me.lblb100.Name = "lblb100"
        Me.lblb100.Size = New System.Drawing.Size(174, 24)
        Me.lblb100.TabIndex = 24
        Me.lblb100.Text = "Billetes de 100.00"
        '
        'lblm10
        '
        Me.lblm10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm10.Location = New System.Drawing.Point(60, 291)
        Me.lblm10.Name = "lblm10"
        Me.lblm10.Size = New System.Drawing.Size(174, 24)
        Me.lblm10.TabIndex = 24
        Me.lblm10.Text = "Monedas de 0.10"
        '
        'lblm1
        '
        Me.lblm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm1.Location = New System.Drawing.Point(60, 210)
        Me.lblm1.Name = "lblm1"
        Me.lblm1.Size = New System.Drawing.Size(174, 24)
        Me.lblm1.TabIndex = 24
        Me.lblm1.Text = "Monedas de 1.00"
        '
        'lblb20
        '
        Me.lblb20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb20.Location = New System.Drawing.Point(60, 129)
        Me.lblb20.Name = "lblb20"
        Me.lblb20.Size = New System.Drawing.Size(174, 24)
        Me.lblb20.TabIndex = 24
        Me.lblb20.Text = "Billetes de 20.00"
        '
        'lblb200
        '
        Me.lblb200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb200.Location = New System.Drawing.Point(60, 48)
        Me.lblb200.Name = "lblb200"
        Me.lblb200.Size = New System.Drawing.Size(174, 24)
        Me.lblb200.TabIndex = 24
        Me.lblb200.Text = "Billetes de 200.00"
        '
        'paneltitulo
        '
        Me.paneltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltitulo.Controls.Add(Me.lblfecha)
        Me.paneltitulo.Controls.Add(Me.lbltitulo)
        Me.paneltitulo.Location = New System.Drawing.Point(7, 5)
        Me.paneltitulo.Name = "paneltitulo"
        Me.paneltitulo.Size = New System.Drawing.Size(1002, 45)
        Me.paneltitulo.TabIndex = 2
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
        'Frmretiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 706)
        Me.Controls.Add(Me.paneltitulo)
        Me.Controls.Add(Me.panelprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmretiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro Final"
        Me.panelprincipal.ResumeLayout(False)
        Me.panellistado.ResumeLayout(False)
        Me.panelcolores.ResumeLayout(False)
        Me.panelretiro.ResumeLayout(False)
        Me.panelretiro.PerformLayout()
        Me.panelformaspago.ResumeLayout(False)
        Me.panelformaspago.PerformLayout()
        Me.panelcajero.ResumeLayout(False)
        Me.panelcajero.PerformLayout()
        Me.paneltotal.ResumeLayout(False)
        Me.paneltotal.PerformLayout()
        Me.panelacciones.ResumeLayout(False)
        Me.paneldetalleEF.ResumeLayout(False)
        Me.paneldetalleEF.PerformLayout()
        Me.paneltitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents panellistado As System.Windows.Forms.Panel
    Friend WithEvents lstvcajeros As System.Windows.Forms.ListView
    Friend WithEvents paneltitulo As System.Windows.Forms.Panel
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents panelretiro As System.Windows.Forms.Panel
    Friend WithEvents paneldetalleEF As System.Windows.Forms.Panel
    Friend WithEvents lbltotalmb As System.Windows.Forms.Label
    Friend WithEvents txtcm001 As System.Windows.Forms.TextBox
    Friend WithEvents lbltxttotal As System.Windows.Forms.Label
    Friend WithEvents txtcm25 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb5 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb50 As System.Windows.Forms.TextBox
    Friend WithEvents txtcm5 As System.Windows.Forms.TextBox
    Friend WithEvents txtcm50 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb10 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb100 As System.Windows.Forms.TextBox
    Friend WithEvents txtcm10 As System.Windows.Forms.TextBox
    Friend WithEvents txtcm1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb20 As System.Windows.Forms.TextBox
    Friend WithEvents txtcb200 As System.Windows.Forms.TextBox
    Friend WithEvents lblm001 As System.Windows.Forms.Label
    Friend WithEvents lblm25 As System.Windows.Forms.Label
    Friend WithEvents lblb5 As System.Windows.Forms.Label
    Friend WithEvents lblb50 As System.Windows.Forms.Label
    Friend WithEvents lblm5 As System.Windows.Forms.Label
    Friend WithEvents lblm50 As System.Windows.Forms.Label
    Friend WithEvents lblb10 As System.Windows.Forms.Label
    Friend WithEvents lblb100 As System.Windows.Forms.Label
    Friend WithEvents lblm10 As System.Windows.Forms.Label
    Friend WithEvents lblm1 As System.Windows.Forms.Label
    Friend WithEvents lblb20 As System.Windows.Forms.Label
    Friend WithEvents lblb200 As System.Windows.Forms.Label
    Friend WithEvents panelformaspago As System.Windows.Forms.Panel
    Friend WithEvents txttemporal As System.Windows.Forms.TextBox
    Friend WithEvents lbltemporal As System.Windows.Forms.Label
    Friend WithEvents lblformaspago As System.Windows.Forms.Label
    Friend WithEvents lblretiro As System.Windows.Forms.Label
    Friend WithEvents panelcajero As System.Windows.Forms.Panel
    Friend WithEvents lblnombrecajeroret As System.Windows.Forms.Label
    Friend WithEvents lbltitcajero As System.Windows.Forms.Label
    Friend WithEvents paneltotal As System.Windows.Forms.Panel
    Friend WithEvents lblcanttotal As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents panelacciones As System.Windows.Forms.Panel
    Friend WithEvents btncancelarret As System.Windows.Forms.Button
    Friend WithEvents btnguardarret As System.Windows.Forms.Button
    Friend WithEvents lbltituloret As System.Windows.Forms.Label
    Friend WithEvents cmbcajaret As System.Windows.Forms.ComboBox
    Friend WithEvents lblcajaret As System.Windows.Forms.Label
    Friend WithEvents btnmodificarret As System.Windows.Forms.Button
    Friend WithEvents panelcolores As System.Windows.Forms.Panel
    Friend WithEvents lblconcorte As System.Windows.Forms.Label
    Friend WithEvents lblconretiro As System.Windows.Forms.Label
    Friend WithEvents lblcolorcorte As System.Windows.Forms.Label
    Friend WithEvents lblcolorretiro As System.Windows.Forms.Label
    Friend WithEvents lbldetalleefectivo As System.Windows.Forms.Label
    Friend WithEvents lbltotb20 As System.Windows.Forms.Label
    Friend WithEvents lbltotb100 As System.Windows.Forms.Label
    Friend WithEvents lbltotb50 As System.Windows.Forms.Label
    Friend WithEvents lbltotb200 As System.Windows.Forms.Label
    Friend WithEvents lbltotm001 As System.Windows.Forms.Label
    Friend WithEvents lbltotm50 As System.Windows.Forms.Label
    Friend WithEvents lbltotm10 As System.Windows.Forms.Label
    Friend WithEvents lbltotb5 As System.Windows.Forms.Label
    Friend WithEvents lbltotm5 As System.Windows.Forms.Label
    Friend WithEvents lbltotm1 As System.Windows.Forms.Label
    Friend WithEvents lbltotm25 As System.Windows.Forms.Label
    Friend WithEvents lbltotb10 As System.Windows.Forms.Label
    Friend WithEvents btncorte As System.Windows.Forms.Button
End Class
