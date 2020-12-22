<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportes
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
        Me.panelacciones = New System.Windows.Forms.Panel
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnverreporte = New System.Windows.Forms.Button
        Me.panelfiltros = New System.Windows.Forms.Panel
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker
        Me.lblfechafin = New System.Windows.Forms.Label
        Me.lblfechaini = New System.Windows.Forms.Label
        Me.lblcajeros = New System.Windows.Forms.Label
        Me.cmbcajeros = New System.Windows.Forms.ComboBox
        Me.panelreportes = New System.Windows.Forms.Panel
        Me.panelRpt6 = New System.Windows.Forms.Panel
        Me.lbltitulorpt6 = New System.Windows.Forms.LinkLabel
        Me.pcbReporte6 = New System.Windows.Forms.PictureBox
        Me.lblDescripcionRpt6 = New System.Windows.Forms.Label
        Me.panelrpt5 = New System.Windows.Forms.Panel
        Me.lbltitulorpt5 = New System.Windows.Forms.LinkLabel
        Me.pbreporte5 = New System.Windows.Forms.PictureBox
        Me.lbldescripcionrpt5 = New System.Windows.Forms.Label
        Me.panelrpt4 = New System.Windows.Forms.Panel
        Me.lbltitulorpt4 = New System.Windows.Forms.LinkLabel
        Me.pbreporte4 = New System.Windows.Forms.PictureBox
        Me.lbldescripcionrpt4 = New System.Windows.Forms.Label
        Me.panelrpt3 = New System.Windows.Forms.Panel
        Me.lbltitulorpt3 = New System.Windows.Forms.LinkLabel
        Me.pbreporte3 = New System.Windows.Forms.PictureBox
        Me.lbldescripcionrpt3 = New System.Windows.Forms.Label
        Me.panelrpt2 = New System.Windows.Forms.Panel
        Me.lbltitulorpt2 = New System.Windows.Forms.LinkLabel
        Me.pbreporte2 = New System.Windows.Forms.PictureBox
        Me.lbldescripcionrpt2 = New System.Windows.Forms.Label
        Me.panelrpt1 = New System.Windows.Forms.Panel
        Me.lbltitulorpt1 = New System.Windows.Forms.LinkLabel
        Me.pbreporte1 = New System.Windows.Forms.PictureBox
        Me.lbldescripcionrpt1 = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        Me.panelacciones.SuspendLayout()
        Me.panelfiltros.SuspendLayout()
        Me.panelreportes.SuspendLayout()
        Me.panelRpt6.SuspendLayout()
        CType(Me.pcbReporte6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrpt5.SuspendLayout()
        CType(Me.pbreporte5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrpt4.SuspendLayout()
        CType(Me.pbreporte4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrpt3.SuspendLayout()
        CType(Me.pbreporte3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrpt2.SuspendLayout()
        CType(Me.pbreporte2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrpt1.SuspendLayout()
        CType(Me.pbreporte1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.panelacciones)
        Me.panelprincipal.Controls.Add(Me.panelfiltros)
        Me.panelprincipal.Controls.Add(Me.panelreportes)
        Me.panelprincipal.Location = New System.Drawing.Point(2, 6)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(900, 490)
        Me.panelprincipal.TabIndex = 0
        '
        'panelacciones
        '
        Me.panelacciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelacciones.Controls.Add(Me.btncancelar)
        Me.panelacciones.Controls.Add(Me.btnverreporte)
        Me.panelacciones.Location = New System.Drawing.Point(341, 417)
        Me.panelacciones.Name = "panelacciones"
        Me.panelacciones.Size = New System.Drawing.Size(554, 68)
        Me.panelacciones.TabIndex = 3
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(327, 1)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 65)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnverreporte
        '
        Me.btnverreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnverreporte.Location = New System.Drawing.Point(138, 1)
        Me.btnverreporte.Name = "btnverreporte"
        Me.btnverreporte.Size = New System.Drawing.Size(88, 65)
        Me.btnverreporte.TabIndex = 0
        Me.btnverreporte.Text = "Reporte"
        Me.btnverreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnverreporte.UseVisualStyleBackColor = True
        '
        'panelfiltros
        '
        Me.panelfiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelfiltros.Controls.Add(Me.dtfechafin)
        Me.panelfiltros.Controls.Add(Me.dtfechaini)
        Me.panelfiltros.Controls.Add(Me.lblfechafin)
        Me.panelfiltros.Controls.Add(Me.lblfechaini)
        Me.panelfiltros.Controls.Add(Me.lblcajeros)
        Me.panelfiltros.Controls.Add(Me.cmbcajeros)
        Me.panelfiltros.Location = New System.Drawing.Point(341, 3)
        Me.panelfiltros.Name = "panelfiltros"
        Me.panelfiltros.Size = New System.Drawing.Size(554, 408)
        Me.panelfiltros.TabIndex = 3
        '
        'dtfechafin
        '
        Me.dtfechafin.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechafin.Location = New System.Drawing.Point(404, 7)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.Size = New System.Drawing.Size(144, 26)
        Me.dtfechafin.TabIndex = 1
        '
        'dtfechaini
        '
        Me.dtfechaini.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaini.Location = New System.Drawing.Point(116, 7)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.Size = New System.Drawing.Size(144, 26)
        Me.dtfechaini.TabIndex = 1
        '
        'lblfechafin
        '
        Me.lblfechafin.AutoSize = True
        Me.lblfechafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechafin.Location = New System.Drawing.Point(300, 10)
        Me.lblfechafin.Name = "lblfechafin"
        Me.lblfechafin.Size = New System.Drawing.Size(108, 20)
        Me.lblfechafin.TabIndex = 2
        Me.lblfechafin.Text = "Fecha Final:"
        '
        'lblfechaini
        '
        Me.lblfechaini.AutoSize = True
        Me.lblfechaini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaini.Location = New System.Drawing.Point(4, 10)
        Me.lblfechaini.Name = "lblfechaini"
        Me.lblfechaini.Size = New System.Drawing.Size(116, 20)
        Me.lblfechaini.TabIndex = 2
        Me.lblfechaini.Text = "Fecha Inicial:"
        '
        'lblcajeros
        '
        Me.lblcajeros.AutoSize = True
        Me.lblcajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajeros.Location = New System.Drawing.Point(4, 50)
        Me.lblcajeros.Name = "lblcajeros"
        Me.lblcajeros.Size = New System.Drawing.Size(66, 20)
        Me.lblcajeros.TabIndex = 2
        Me.lblcajeros.Text = "Cajero:"
        '
        'cmbcajeros
        '
        Me.cmbcajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcajeros.FormattingEnabled = True
        Me.cmbcajeros.Location = New System.Drawing.Point(116, 46)
        Me.cmbcajeros.Name = "cmbcajeros"
        Me.cmbcajeros.Size = New System.Drawing.Size(432, 28)
        Me.cmbcajeros.TabIndex = 0
        '
        'panelreportes
        '
        Me.panelreportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelreportes.Controls.Add(Me.panelRpt6)
        Me.panelreportes.Controls.Add(Me.panelrpt5)
        Me.panelreportes.Controls.Add(Me.panelrpt4)
        Me.panelreportes.Controls.Add(Me.panelrpt3)
        Me.panelreportes.Controls.Add(Me.panelrpt2)
        Me.panelreportes.Controls.Add(Me.panelrpt1)
        Me.panelreportes.Location = New System.Drawing.Point(3, 3)
        Me.panelreportes.Name = "panelreportes"
        Me.panelreportes.Size = New System.Drawing.Size(332, 482)
        Me.panelreportes.TabIndex = 2
        '
        'panelRpt6
        '
        Me.panelRpt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRpt6.Controls.Add(Me.lbltitulorpt6)
        Me.panelRpt6.Controls.Add(Me.pcbReporte6)
        Me.panelRpt6.Controls.Add(Me.lblDescripcionRpt6)
        Me.panelRpt6.Location = New System.Drawing.Point(5, 322)
        Me.panelRpt6.Name = "panelRpt6"
        Me.panelRpt6.Size = New System.Drawing.Size(321, 60)
        Me.panelRpt6.TabIndex = 6
        '
        'lbltitulorpt6
        '
        Me.lbltitulorpt6.AutoSize = True
        Me.lbltitulorpt6.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt6.Location = New System.Drawing.Point(66, 1)
        Me.lbltitulorpt6.Name = "lbltitulorpt6"
        Me.lbltitulorpt6.Size = New System.Drawing.Size(141, 20)
        Me.lbltitulorpt6.TabIndex = 5
        Me.lbltitulorpt6.TabStop = True
        Me.lbltitulorpt6.Text = "Cuadre de Cajeros"
        '
        'pcbReporte6
        '
        Me.pcbReporte6.BackColor = System.Drawing.Color.Transparent
        Me.pcbReporte6.BackgroundImage = Global.admincajeros.My.Resources.Resources.fondo
        Me.pcbReporte6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbReporte6.InitialImage = Global.admincajeros.My.Resources.Resources.fondo
        Me.pcbReporte6.Location = New System.Drawing.Point(12, 3)
        Me.pcbReporte6.Name = "pcbReporte6"
        Me.pcbReporte6.Size = New System.Drawing.Size(39, 52)
        Me.pcbReporte6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbReporte6.TabIndex = 4
        Me.pcbReporte6.TabStop = False
        '
        'lblDescripcionRpt6
        '
        Me.lblDescripcionRpt6.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionRpt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionRpt6.Location = New System.Drawing.Point(66, 22)
        Me.lblDescripcionRpt6.Name = "lblDescripcionRpt6"
        Me.lblDescripcionRpt6.Size = New System.Drawing.Size(257, 45)
        Me.lblDescripcionRpt6.TabIndex = 3
        Me.lblDescripcionRpt6.Text = "Saldos de Cajero por Caja"
        '
        'panelrpt5
        '
        Me.panelrpt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrpt5.Controls.Add(Me.lbltitulorpt5)
        Me.panelrpt5.Controls.Add(Me.pbreporte5)
        Me.panelrpt5.Controls.Add(Me.lbldescripcionrpt5)
        Me.panelrpt5.Location = New System.Drawing.Point(5, 259)
        Me.panelrpt5.Name = "panelrpt5"
        Me.panelrpt5.Size = New System.Drawing.Size(321, 60)
        Me.panelrpt5.TabIndex = 4
        '
        'lbltitulorpt5
        '
        Me.lbltitulorpt5.AutoSize = True
        Me.lbltitulorpt5.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt5.Location = New System.Drawing.Point(66, 1)
        Me.lbltitulorpt5.Name = "lbltitulorpt5"
        Me.lbltitulorpt5.Size = New System.Drawing.Size(118, 20)
        Me.lbltitulorpt5.TabIndex = 5
        Me.lbltitulorpt5.TabStop = True
        Me.lbltitulorpt5.Text = "Bitacora Cajero"
        '
        'pbreporte5
        '
        Me.pbreporte5.BackColor = System.Drawing.Color.Transparent
        Me.pbreporte5.Location = New System.Drawing.Point(2, 1)
        Me.pbreporte5.Name = "pbreporte5"
        Me.pbreporte5.Size = New System.Drawing.Size(58, 55)
        Me.pbreporte5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreporte5.TabIndex = 4
        Me.pbreporte5.TabStop = False
        '
        'lbldescripcionrpt5
        '
        Me.lbldescripcionrpt5.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcionrpt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcionrpt5.Location = New System.Drawing.Point(66, 22)
        Me.lbldescripcionrpt5.Name = "lbldescripcionrpt5"
        Me.lbldescripcionrpt5.Size = New System.Drawing.Size(257, 45)
        Me.lbldescripcionrpt5.TabIndex = 3
        Me.lbldescripcionrpt5.Text = "Bitacora movimientos cajero"
        '
        'panelrpt4
        '
        Me.panelrpt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrpt4.Controls.Add(Me.lbltitulorpt4)
        Me.panelrpt4.Controls.Add(Me.pbreporte4)
        Me.panelrpt4.Controls.Add(Me.lbldescripcionrpt4)
        Me.panelrpt4.Location = New System.Drawing.Point(5, 195)
        Me.panelrpt4.Name = "panelrpt4"
        Me.panelrpt4.Size = New System.Drawing.Size(321, 60)
        Me.panelrpt4.TabIndex = 4
        '
        'lbltitulorpt4
        '
        Me.lbltitulorpt4.AutoSize = True
        Me.lbltitulorpt4.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt4.Location = New System.Drawing.Point(66, 1)
        Me.lbltitulorpt4.Name = "lbltitulorpt4"
        Me.lbltitulorpt4.Size = New System.Drawing.Size(117, 20)
        Me.lbltitulorpt4.TabIndex = 5
        Me.lbltitulorpt4.TabStop = True
        Me.lbltitulorpt4.Text = "Corte de cajero"
        '
        'pbreporte4
        '
        Me.pbreporte4.BackColor = System.Drawing.Color.Transparent
        Me.pbreporte4.Location = New System.Drawing.Point(2, 1)
        Me.pbreporte4.Name = "pbreporte4"
        Me.pbreporte4.Size = New System.Drawing.Size(58, 55)
        Me.pbreporte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreporte4.TabIndex = 4
        Me.pbreporte4.TabStop = False
        '
        'lbldescripcionrpt4
        '
        Me.lbldescripcionrpt4.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcionrpt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcionrpt4.Location = New System.Drawing.Point(66, 22)
        Me.lbldescripcionrpt4.Name = "lbldescripcionrpt4"
        Me.lbldescripcionrpt4.Size = New System.Drawing.Size(257, 45)
        Me.lbldescripcionrpt4.TabIndex = 3
        Me.lbldescripcionrpt4.Text = "Reporte de corte de cajero"
        '
        'panelrpt3
        '
        Me.panelrpt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrpt3.Controls.Add(Me.lbltitulorpt3)
        Me.panelrpt3.Controls.Add(Me.pbreporte3)
        Me.panelrpt3.Controls.Add(Me.lbldescripcionrpt3)
        Me.panelrpt3.Location = New System.Drawing.Point(5, 131)
        Me.panelrpt3.Name = "panelrpt3"
        Me.panelrpt3.Size = New System.Drawing.Size(321, 60)
        Me.panelrpt3.TabIndex = 3
        '
        'lbltitulorpt3
        '
        Me.lbltitulorpt3.AutoSize = True
        Me.lbltitulorpt3.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt3.Location = New System.Drawing.Point(66, 1)
        Me.lbltitulorpt3.Name = "lbltitulorpt3"
        Me.lbltitulorpt3.Size = New System.Drawing.Size(134, 20)
        Me.lbltitulorpt3.TabIndex = 5
        Me.lbltitulorpt3.TabStop = True
        Me.lbltitulorpt3.Text = "Retiros por cajero"
        '
        'pbreporte3
        '
        Me.pbreporte3.BackColor = System.Drawing.Color.Transparent
        Me.pbreporte3.Location = New System.Drawing.Point(2, 1)
        Me.pbreporte3.Name = "pbreporte3"
        Me.pbreporte3.Size = New System.Drawing.Size(58, 55)
        Me.pbreporte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreporte3.TabIndex = 4
        Me.pbreporte3.TabStop = False
        '
        'lbldescripcionrpt3
        '
        Me.lbldescripcionrpt3.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcionrpt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcionrpt3.Location = New System.Drawing.Point(66, 22)
        Me.lbldescripcionrpt3.Name = "lbldescripcionrpt3"
        Me.lbldescripcionrpt3.Size = New System.Drawing.Size(257, 45)
        Me.lbldescripcionrpt3.TabIndex = 3
        Me.lbldescripcionrpt3.Text = "Reporte de retiros por cajero y rango de fechas."
        '
        'panelrpt2
        '
        Me.panelrpt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrpt2.Controls.Add(Me.lbltitulorpt2)
        Me.panelrpt2.Controls.Add(Me.pbreporte2)
        Me.panelrpt2.Controls.Add(Me.lbldescripcionrpt2)
        Me.panelrpt2.Location = New System.Drawing.Point(5, 67)
        Me.panelrpt2.Name = "panelrpt2"
        Me.panelrpt2.Size = New System.Drawing.Size(321, 60)
        Me.panelrpt2.TabIndex = 3
        '
        'lbltitulorpt2
        '
        Me.lbltitulorpt2.AutoSize = True
        Me.lbltitulorpt2.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt2.Location = New System.Drawing.Point(62, 1)
        Me.lbltitulorpt2.Name = "lbltitulorpt2"
        Me.lbltitulorpt2.Size = New System.Drawing.Size(131, 20)
        Me.lbltitulorpt2.TabIndex = 5
        Me.lbltitulorpt2.TabStop = True
        Me.lbltitulorpt2.Text = "Log cambio retiro"
        '
        'pbreporte2
        '
        Me.pbreporte2.BackColor = System.Drawing.Color.Transparent
        Me.pbreporte2.Location = New System.Drawing.Point(2, 1)
        Me.pbreporte2.Name = "pbreporte2"
        Me.pbreporte2.Size = New System.Drawing.Size(58, 55)
        Me.pbreporte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreporte2.TabIndex = 4
        Me.pbreporte2.TabStop = False
        '
        'lbldescripcionrpt2
        '
        Me.lbldescripcionrpt2.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcionrpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcionrpt2.Location = New System.Drawing.Point(66, 21)
        Me.lbldescripcionrpt2.Name = "lbldescripcionrpt2"
        Me.lbldescripcionrpt2.Size = New System.Drawing.Size(257, 50)
        Me.lbldescripcionrpt2.TabIndex = 3
        Me.lbldescripcionrpt2.Text = "Log de modificaciones realizadas al monto de los retiros parciales y final."
        '
        'panelrpt1
        '
        Me.panelrpt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrpt1.Controls.Add(Me.lbltitulorpt1)
        Me.panelrpt1.Controls.Add(Me.pbreporte1)
        Me.panelrpt1.Controls.Add(Me.lbldescripcionrpt1)
        Me.panelrpt1.Location = New System.Drawing.Point(5, 3)
        Me.panelrpt1.Name = "panelrpt1"
        Me.panelrpt1.Size = New System.Drawing.Size(321, 60)
        Me.panelrpt1.TabIndex = 3
        '
        'lbltitulorpt1
        '
        Me.lbltitulorpt1.AutoSize = True
        Me.lbltitulorpt1.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulorpt1.Location = New System.Drawing.Point(61, 1)
        Me.lbltitulorpt1.Name = "lbltitulorpt1"
        Me.lbltitulorpt1.Size = New System.Drawing.Size(198, 20)
        Me.lbltitulorpt1.TabIndex = 5
        Me.lbltitulorpt1.TabStop = True
        Me.lbltitulorpt1.Text = "Log cambio forma de pago"
        '
        'pbreporte1
        '
        Me.pbreporte1.BackColor = System.Drawing.Color.Transparent
        Me.pbreporte1.Location = New System.Drawing.Point(1, 1)
        Me.pbreporte1.Name = "pbreporte1"
        Me.pbreporte1.Size = New System.Drawing.Size(58, 55)
        Me.pbreporte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbreporte1.TabIndex = 4
        Me.pbreporte1.TabStop = False
        '
        'lbldescripcionrpt1
        '
        Me.lbldescripcionrpt1.BackColor = System.Drawing.Color.Transparent
        Me.lbldescripcionrpt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcionrpt1.Location = New System.Drawing.Point(63, 22)
        Me.lbldescripcionrpt1.Name = "lbldescripcionrpt1"
        Me.lbldescripcionrpt1.Size = New System.Drawing.Size(259, 50)
        Me.lbldescripcionrpt1.TabIndex = 3
        Me.lbldescripcionrpt1.Text = "Log de modificaciones realizadas a la forma de pago de una transaccion."
        '
        'frmreportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 502)
        Me.Controls.Add(Me.panelprincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmreportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.panelprincipal.ResumeLayout(False)
        Me.panelacciones.ResumeLayout(False)
        Me.panelfiltros.ResumeLayout(False)
        Me.panelfiltros.PerformLayout()
        Me.panelreportes.ResumeLayout(False)
        Me.panelRpt6.ResumeLayout(False)
        Me.panelRpt6.PerformLayout()
        CType(Me.pcbReporte6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrpt5.ResumeLayout(False)
        Me.panelrpt5.PerformLayout()
        CType(Me.pbreporte5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrpt4.ResumeLayout(False)
        Me.panelrpt4.PerformLayout()
        CType(Me.pbreporte4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrpt3.ResumeLayout(False)
        Me.panelrpt3.PerformLayout()
        CType(Me.pbreporte3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrpt2.ResumeLayout(False)
        Me.panelrpt2.PerformLayout()
        CType(Me.pbreporte2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrpt1.ResumeLayout(False)
        Me.panelrpt1.PerformLayout()
        CType(Me.pbreporte1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents panelreportes As System.Windows.Forms.Panel
    Friend WithEvents panelacciones As System.Windows.Forms.Panel
    Friend WithEvents panelfiltros As System.Windows.Forms.Panel
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnverreporte As System.Windows.Forms.Button
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbcajeros As System.Windows.Forms.ComboBox
    Friend WithEvents lblfechafin As System.Windows.Forms.Label
    Friend WithEvents lblfechaini As System.Windows.Forms.Label
    Friend WithEvents lblcajeros As System.Windows.Forms.Label
    Friend WithEvents panelrpt1 As System.Windows.Forms.Panel
    Friend WithEvents panelrpt3 As System.Windows.Forms.Panel
    Friend WithEvents panelrpt2 As System.Windows.Forms.Panel
    Friend WithEvents lbltitulorpt1 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbreporte1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescripcionrpt1 As System.Windows.Forms.Label
    Friend WithEvents lbltitulorpt3 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbreporte3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescripcionrpt3 As System.Windows.Forms.Label
    Friend WithEvents lbltitulorpt2 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbreporte2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescripcionrpt2 As System.Windows.Forms.Label
    Friend WithEvents panelrpt4 As System.Windows.Forms.Panel
    Friend WithEvents lbltitulorpt4 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbreporte4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescripcionrpt4 As System.Windows.Forms.Label
    Friend WithEvents panelrpt5 As System.Windows.Forms.Panel
    Friend WithEvents lbltitulorpt5 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbreporte5 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescripcionrpt5 As System.Windows.Forms.Label
    Friend WithEvents panelRpt6 As System.Windows.Forms.Panel
    Friend WithEvents lbltitulorpt6 As System.Windows.Forms.LinkLabel
    Friend WithEvents pcbReporte6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescripcionRpt6 As System.Windows.Forms.Label
End Class
