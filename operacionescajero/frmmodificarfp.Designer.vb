<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmodificarfp
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
        Me.txtnumdocumento = New System.Windows.Forms.TextBox
        Me.cmbcajas = New System.Windows.Forms.ComboBox
        Me.lblnumdocumento = New System.Windows.Forms.Label
        Me.lblcaja = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.dgdatos = New System.Windows.Forms.DataGridView
        Me.lblresultado = New System.Windows.Forms.Label
        Me.lblcajero = New System.Windows.Forms.Label
        Me.dgresultado = New System.Windows.Forms.DataGridView
        Me.paneldatos = New System.Windows.Forms.Panel
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.lblobservaciones = New System.Windows.Forms.Label
        Me.cmbtipopagodes = New System.Windows.Forms.ComboBox
        Me.lbltipopagodes = New System.Windows.Forms.Label
        Me.lbltipopagoori = New System.Windows.Forms.Label
        Me.lblnombreori = New System.Windows.Forms.Label
        Me.lblnumautorizacionori = New System.Windows.Forms.Label
        Me.lblreferenciaori = New System.Windows.Forms.Label
        Me.lbldestino = New System.Windows.Forms.Label
        Me.lblnumeroautorizacion = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.lblreferencia = New System.Windows.Forms.Label
        Me.lbltipopago = New System.Windows.Forms.Label
        Me.lblmonto = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblorigen = New System.Windows.Forms.Label
        Me.lblnumautorizaciondes = New System.Windows.Forms.Label
        Me.txtnumautorizaciondes = New System.Windows.Forms.TextBox
        Me.lblnombredes = New System.Windows.Forms.Label
        Me.txtnombredes = New System.Windows.Forms.TextBox
        Me.lblreferenciades = New System.Windows.Forms.Label
        Me.txtreferenciades = New System.Windows.Forms.TextBox
        Me.lbltxtnombrecajero = New System.Windows.Forms.Label
        Me.paneltitulo = New System.Windows.Forms.Panel
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.panelprincipal.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldatos.SuspendLayout()
        Me.paneltitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelprincipal
        '
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.txtnumdocumento)
        Me.panelprincipal.Controls.Add(Me.cmbcajas)
        Me.panelprincipal.Controls.Add(Me.lblnumdocumento)
        Me.panelprincipal.Controls.Add(Me.lblcaja)
        Me.panelprincipal.Controls.Add(Me.btncancelar)
        Me.panelprincipal.Controls.Add(Me.btnmodificar)
        Me.panelprincipal.Controls.Add(Me.dgdatos)
        Me.panelprincipal.Controls.Add(Me.lblresultado)
        Me.panelprincipal.Controls.Add(Me.lblcajero)
        Me.panelprincipal.Controls.Add(Me.dgresultado)
        Me.panelprincipal.Controls.Add(Me.paneldatos)
        Me.panelprincipal.Controls.Add(Me.lbltxtnombrecajero)
        Me.panelprincipal.Location = New System.Drawing.Point(7, 51)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1002, 651)
        Me.panelprincipal.TabIndex = 27
        '
        'txtnumdocumento
        '
        Me.txtnumdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumdocumento.Location = New System.Drawing.Point(295, 4)
        Me.txtnumdocumento.Name = "txtnumdocumento"
        Me.txtnumdocumento.Size = New System.Drawing.Size(100, 26)
        Me.txtnumdocumento.TabIndex = 1
        Me.txtnumdocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbcajas
        '
        Me.cmbcajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcajas.FormattingEnabled = True
        Me.cmbcajas.Location = New System.Drawing.Point(44, 2)
        Me.cmbcajas.Name = "cmbcajas"
        Me.cmbcajas.Size = New System.Drawing.Size(82, 28)
        Me.cmbcajas.TabIndex = 0
        '
        'lblnumdocumento
        '
        Me.lblnumdocumento.AutoSize = True
        Me.lblnumdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumdocumento.Location = New System.Drawing.Point(157, 7)
        Me.lblnumdocumento.Name = "lblnumdocumento"
        Me.lblnumdocumento.Size = New System.Drawing.Size(143, 20)
        Me.lblnumdocumento.TabIndex = 41
        Me.lblnumdocumento.Text = "Numero Factura:"
        '
        'lblcaja
        '
        Me.lblcaja.AutoSize = True
        Me.lblcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaja.Location = New System.Drawing.Point(-1, 4)
        Me.lblcaja.Name = "lblcaja"
        Me.lblcaja.Size = New System.Drawing.Size(50, 20)
        Me.lblcaja.TabIndex = 43
        Me.lblcaja.Text = "Caja:"
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(632, 582)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 65)
        Me.btncancelar.TabIndex = 6
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificar.Location = New System.Drawing.Point(281, 582)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 65)
        Me.btnmodificar.TabIndex = 5
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdatos.Location = New System.Drawing.Point(3, 31)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.ReadOnly = True
        Me.dgdatos.RowHeadersWidth = 4
        Me.dgdatos.Size = New System.Drawing.Size(994, 175)
        Me.dgdatos.TabIndex = 35
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.Location = New System.Drawing.Point(-1, 381)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(96, 20)
        Me.lblresultado.TabIndex = 47
        Me.lblresultado.Text = "Resultado:"
        '
        'lblcajero
        '
        Me.lblcajero.BackColor = System.Drawing.Color.White
        Me.lblcajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcajero.Location = New System.Drawing.Point(493, 3)
        Me.lblcajero.Name = "lblcajero"
        Me.lblcajero.Size = New System.Drawing.Size(503, 26)
        Me.lblcajero.TabIndex = 67
        '
        'dgresultado
        '
        Me.dgresultado.AllowUserToAddRows = False
        Me.dgresultado.AllowUserToDeleteRows = False
        Me.dgresultado.AllowUserToResizeColumns = False
        Me.dgresultado.AllowUserToResizeRows = False
        Me.dgresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgresultado.Location = New System.Drawing.Point(3, 401)
        Me.dgresultado.Name = "dgresultado"
        Me.dgresultado.ReadOnly = True
        Me.dgresultado.RowHeadersWidth = 4
        Me.dgresultado.Size = New System.Drawing.Size(993, 175)
        Me.dgresultado.TabIndex = 34
        '
        'paneldatos
        '
        Me.paneldatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldatos.Controls.Add(Me.txtobservaciones)
        Me.paneldatos.Controls.Add(Me.lblobservaciones)
        Me.paneldatos.Controls.Add(Me.cmbtipopagodes)
        Me.paneldatos.Controls.Add(Me.lbltipopagodes)
        Me.paneldatos.Controls.Add(Me.lbltipopagoori)
        Me.paneldatos.Controls.Add(Me.lblnombreori)
        Me.paneldatos.Controls.Add(Me.lblnumautorizacionori)
        Me.paneldatos.Controls.Add(Me.lblreferenciaori)
        Me.paneldatos.Controls.Add(Me.lbldestino)
        Me.paneldatos.Controls.Add(Me.lblnumeroautorizacion)
        Me.paneldatos.Controls.Add(Me.txtmonto)
        Me.paneldatos.Controls.Add(Me.lblreferencia)
        Me.paneldatos.Controls.Add(Me.lbltipopago)
        Me.paneldatos.Controls.Add(Me.lblmonto)
        Me.paneldatos.Controls.Add(Me.lblnombre)
        Me.paneldatos.Controls.Add(Me.lblorigen)
        Me.paneldatos.Controls.Add(Me.lblnumautorizaciondes)
        Me.paneldatos.Controls.Add(Me.txtnumautorizaciondes)
        Me.paneldatos.Controls.Add(Me.lblnombredes)
        Me.paneldatos.Controls.Add(Me.txtnombredes)
        Me.paneldatos.Controls.Add(Me.lblreferenciades)
        Me.paneldatos.Controls.Add(Me.txtreferenciades)
        Me.paneldatos.Location = New System.Drawing.Point(4, 212)
        Me.paneldatos.Name = "paneldatos"
        Me.paneldatos.Size = New System.Drawing.Size(992, 166)
        Me.paneldatos.TabIndex = 46
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(136, 84)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(849, 77)
        Me.txtobservaciones.TabIndex = 71
        '
        'lblobservaciones
        '
        Me.lblobservaciones.AutoSize = True
        Me.lblobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobservaciones.Location = New System.Drawing.Point(-2, 84)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(132, 20)
        Me.lblobservaciones.TabIndex = 72
        Me.lblobservaciones.Text = "Observaciones:"
        '
        'cmbtipopagodes
        '
        Me.cmbtipopagodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipopagodes.Enabled = False
        Me.cmbtipopagodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipopagodes.FormattingEnabled = True
        Me.cmbtipopagodes.Location = New System.Drawing.Point(73, 51)
        Me.cmbtipopagodes.Name = "cmbtipopagodes"
        Me.cmbtipopagodes.Size = New System.Drawing.Size(189, 28)
        Me.cmbtipopagodes.TabIndex = 48
        '
        'lbltipopagodes
        '
        Me.lbltipopagodes.BackColor = System.Drawing.Color.White
        Me.lbltipopagodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipopagodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipopagodes.Location = New System.Drawing.Point(73, 52)
        Me.lbltipopagodes.Name = "lbltipopagodes"
        Me.lbltipopagodes.Size = New System.Drawing.Size(189, 26)
        Me.lbltipopagodes.TabIndex = 65
        '
        'lbltipopagoori
        '
        Me.lbltipopagoori.BackColor = System.Drawing.Color.White
        Me.lbltipopagoori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltipopagoori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipopagoori.Location = New System.Drawing.Point(73, 23)
        Me.lbltipopagoori.Name = "lbltipopagoori"
        Me.lbltipopagoori.Size = New System.Drawing.Size(189, 26)
        Me.lbltipopagoori.TabIndex = 65
        '
        'lblnombreori
        '
        Me.lblnombreori.BackColor = System.Drawing.Color.White
        Me.lblnombreori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombreori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreori.Location = New System.Drawing.Point(265, 23)
        Me.lblnombreori.Name = "lblnombreori"
        Me.lblnombreori.Size = New System.Drawing.Size(296, 26)
        Me.lblnombreori.TabIndex = 65
        '
        'lblnumautorizacionori
        '
        Me.lblnumautorizacionori.BackColor = System.Drawing.Color.White
        Me.lblnumautorizacionori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnumautorizacionori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumautorizacionori.Location = New System.Drawing.Point(734, 23)
        Me.lblnumautorizacionori.Name = "lblnumautorizacionori"
        Me.lblnumautorizacionori.Size = New System.Drawing.Size(142, 26)
        Me.lblnumautorizacionori.TabIndex = 66
        '
        'lblreferenciaori
        '
        Me.lblreferenciaori.BackColor = System.Drawing.Color.White
        Me.lblreferenciaori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblreferenciaori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreferenciaori.Location = New System.Drawing.Point(564, 23)
        Me.lblreferenciaori.Name = "lblreferenciaori"
        Me.lblreferenciaori.Size = New System.Drawing.Size(167, 26)
        Me.lblreferenciaori.TabIndex = 67
        '
        'lbldestino
        '
        Me.lbldestino.AutoSize = True
        Me.lbldestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldestino.Location = New System.Drawing.Point(-3, 55)
        Me.lbldestino.Name = "lbldestino"
        Me.lbldestino.Size = New System.Drawing.Size(76, 20)
        Me.lbldestino.TabIndex = 55
        Me.lbldestino.Text = "Destino:"
        '
        'lblnumeroautorizacion
        '
        Me.lblnumeroautorizacion.AutoSize = True
        Me.lblnumeroautorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumeroautorizacion.Location = New System.Drawing.Point(730, 2)
        Me.lblnumeroautorizacion.Name = "lblnumeroautorizacion"
        Me.lblnumeroautorizacion.Size = New System.Drawing.Size(124, 20)
        Me.lblnumeroautorizacion.TabIndex = 57
        Me.lblnumeroautorizacion.Text = "# Autorizacion"
        '
        'txtmonto
        '
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(882, 39)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(101, 26)
        Me.txtmonto.TabIndex = 2
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblreferencia
        '
        Me.lblreferencia.AutoSize = True
        Me.lblreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreferencia.Location = New System.Drawing.Point(560, 2)
        Me.lblreferencia.Name = "lblreferencia"
        Me.lblreferencia.Size = New System.Drawing.Size(97, 20)
        Me.lblreferencia.TabIndex = 56
        Me.lblreferencia.Text = "Referencia"
        '
        'lbltipopago
        '
        Me.lbltipopago.AutoSize = True
        Me.lbltipopago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipopago.Location = New System.Drawing.Point(70, 2)
        Me.lbltipopago.Name = "lbltipopago"
        Me.lbltipopago.Size = New System.Drawing.Size(89, 20)
        Me.lbltipopago.TabIndex = 61
        Me.lbltipopago.Text = "Tipo Pago"
        '
        'lblmonto
        '
        Me.lblmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto.Location = New System.Drawing.Point(880, -2)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(103, 42)
        Me.lblmonto.TabIndex = 39
        Me.lblmonto.Text = "Monto a modificar"
        Me.lblmonto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(262, 2)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(71, 20)
        Me.lblnombre.TabIndex = 61
        Me.lblnombre.Text = "Nombre"
        '
        'lblorigen
        '
        Me.lblorigen.AutoSize = True
        Me.lblorigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorigen.Location = New System.Drawing.Point(-2, 24)
        Me.lblorigen.Name = "lblorigen"
        Me.lblorigen.Size = New System.Drawing.Size(67, 20)
        Me.lblorigen.TabIndex = 60
        Me.lblorigen.Text = "Origen:"
        '
        'lblnumautorizaciondes
        '
        Me.lblnumautorizaciondes.BackColor = System.Drawing.Color.White
        Me.lblnumautorizaciondes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnumautorizaciondes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumautorizaciondes.Location = New System.Drawing.Point(734, 52)
        Me.lblnumautorizaciondes.Name = "lblnumautorizaciondes"
        Me.lblnumautorizaciondes.Size = New System.Drawing.Size(142, 26)
        Me.lblnumautorizaciondes.TabIndex = 70
        '
        'txtnumautorizaciondes
        '
        Me.txtnumautorizaciondes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumautorizaciondes.Location = New System.Drawing.Point(734, 52)
        Me.txtnumautorizaciondes.Name = "txtnumautorizaciondes"
        Me.txtnumautorizaciondes.Size = New System.Drawing.Size(142, 26)
        Me.txtnumautorizaciondes.TabIndex = 4
        Me.txtnumautorizaciondes.Visible = False
        '
        'lblnombredes
        '
        Me.lblnombredes.BackColor = System.Drawing.Color.White
        Me.lblnombredes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombredes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombredes.Location = New System.Drawing.Point(265, 52)
        Me.lblnombredes.Name = "lblnombredes"
        Me.lblnombredes.Size = New System.Drawing.Size(296, 26)
        Me.lblnombredes.TabIndex = 68
        '
        'txtnombredes
        '
        Me.txtnombredes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombredes.Location = New System.Drawing.Point(265, 52)
        Me.txtnombredes.Name = "txtnombredes"
        Me.txtnombredes.Size = New System.Drawing.Size(296, 26)
        Me.txtnombredes.TabIndex = 2
        Me.txtnombredes.Visible = False
        '
        'lblreferenciades
        '
        Me.lblreferenciades.BackColor = System.Drawing.Color.White
        Me.lblreferenciades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblreferenciades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreferenciades.Location = New System.Drawing.Point(564, 52)
        Me.lblreferenciades.Name = "lblreferenciades"
        Me.lblreferenciades.Size = New System.Drawing.Size(167, 26)
        Me.lblreferenciades.TabIndex = 69
        '
        'txtreferenciades
        '
        Me.txtreferenciades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferenciades.Location = New System.Drawing.Point(564, 52)
        Me.txtreferenciades.Name = "txtreferenciades"
        Me.txtreferenciades.Size = New System.Drawing.Size(167, 26)
        Me.txtreferenciades.TabIndex = 3
        Me.txtreferenciades.Visible = False
        '
        'lbltxtnombrecajero
        '
        Me.lbltxtnombrecajero.AutoSize = True
        Me.lbltxtnombrecajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtnombrecajero.Location = New System.Drawing.Point(428, 6)
        Me.lbltxtnombrecajero.Name = "lbltxtnombrecajero"
        Me.lbltxtnombrecajero.Size = New System.Drawing.Size(66, 20)
        Me.lbltxtnombrecajero.TabIndex = 41
        Me.lbltxtnombrecajero.Text = "Cajero:"
        '
        'paneltitulo
        '
        Me.paneltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltitulo.Controls.Add(Me.lblfecha)
        Me.paneltitulo.Controls.Add(Me.lbltitulo)
        Me.paneltitulo.Location = New System.Drawing.Point(7, 3)
        Me.paneltitulo.Name = "paneltitulo"
        Me.paneltitulo.Size = New System.Drawing.Size(1002, 45)
        Me.paneltitulo.TabIndex = 28
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
        Me.lbltitulo.Location = New System.Drawing.Point(-4, 2)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(505, 41)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "MODIFICAR FORMA DE PAGO"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frmmodificarfp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 706)
        Me.Controls.Add(Me.paneltitulo)
        Me.Controls.Add(Me.panelprincipal)
        Me.MaximizeBox = False
        Me.Name = "Frmmodificarfp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Forma de Pago"
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgresultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldatos.ResumeLayout(False)
        Me.paneldatos.PerformLayout()
        Me.paneltitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents lblnumdocumento As System.Windows.Forms.Label
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents lblcaja As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents dgresultado As System.Windows.Forms.DataGridView
    Friend WithEvents dgdatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents txtnumdocumento As System.Windows.Forms.TextBox
    Friend WithEvents cmbcajas As System.Windows.Forms.ComboBox
    Friend WithEvents paneldatos As System.Windows.Forms.Panel
    Friend WithEvents lbldestino As System.Windows.Forms.Label
    Friend WithEvents lblnumeroautorizacion As System.Windows.Forms.Label
    Friend WithEvents lblreferencia As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblorigen As System.Windows.Forms.Label
    Friend WithEvents txtnumautorizaciondes As System.Windows.Forms.TextBox
    Friend WithEvents txtreferenciades As System.Windows.Forms.TextBox
    Friend WithEvents txtnombredes As System.Windows.Forms.TextBox
    Friend WithEvents lblnombreori As System.Windows.Forms.Label
    Friend WithEvents lblnumautorizacionori As System.Windows.Forms.Label
    Friend WithEvents lblreferenciaori As System.Windows.Forms.Label
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents lblnumautorizaciondes As System.Windows.Forms.Label
    Friend WithEvents lblnombredes As System.Windows.Forms.Label
    Friend WithEvents lblreferenciades As System.Windows.Forms.Label
    Friend WithEvents lbltipopago As System.Windows.Forms.Label
    Friend WithEvents lbltipopagoori As System.Windows.Forms.Label
    Friend WithEvents cmbtipopagodes As System.Windows.Forms.ComboBox
    Friend WithEvents lbltipopagodes As System.Windows.Forms.Label
    Friend WithEvents paneltitulo As System.Windows.Forms.Panel
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblobservaciones As System.Windows.Forms.Label
    Friend WithEvents lblcajero As System.Windows.Forms.Label
    Friend WithEvents lbltxtnombrecajero As System.Windows.Forms.Label
End Class
