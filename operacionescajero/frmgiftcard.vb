Imports MySql.Data.MySqlClient
Public Class frmgiftcard

    ReadOnly _conexionsuperpos As New MySqlConnection

    Dim dscajerosgift As New DataSet
    Dim comandogift As New MySqlCommand
    Dim dagift As New MySqlDataAdapter

    Dim dstipostransaccion As New DataSet

    Dim dsdetalle As New DataSet



    Private Sub frmgiftcard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        comandogift.Connection = _conexionsuperpos

        llenarcajeros()

        recargasenlamdpos()
        consumoslampos()

        llenartransacciones()

        cuadrarrecargas()
        cuadrarconsumos()


    End Sub

    Private Sub llenarcajeros()

        cmbcajero.Items.Clear()

        comandogift.CommandText = "SELECT DISTINCT(giftcard.`codigocajero`),usuarios.`Nombres` FROM giftcard INNER JOIN usuarios ON giftcard.`codigocajero` = usuarios.`Id` WHERE DATE(giftcard.`fechatransaccion`) = '" & Format(CDate(calfecha.Value), "yyy-MM-dd") & "'"

        dagift.SelectCommand = comandogift

        dscajerosgift.Clear()

        dagift.Fill(dscajerosgift)

        If dscajerosgift.Tables(0).Rows.Count > 0 Then
            cmbcajero.Items.Add("TODOS")
            For Each fila As DataRow In dscajerosgift.Tables(0).Rows
                cmbcajero.Items.Add(fila(1))


            Next




        Else
            MessageBox.Show("No existen cajeros con operaciones de GiftCard", "Gift Card", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If







    End Sub

    Private Sub llenartransacciones()
        cmbtipotransaccion.Items.Clear()

        comandogift.CommandText = "SELECT idtransaccion,tipotransaccion FROM        giftcard_tipostransacciones"

        dagift.SelectCommand = comandogift

        dstipostransaccion.Clear()
        dagift.Fill(dstipostransaccion)


        If dstipostransaccion.Tables(0).Rows.Count > 0 Then
            cmbtipotransaccion.Items.Add("TODAS")
            For Each fila As DataRow In dstipostransaccion.Tables(0).Rows
                cmbtipotransaccion.Items.Add(fila(1))

            Next


        Else
            MessageBox.Show("No existen listado de transacciones" & vbCrLf & "Por favor comuniquese a sistemas", "Gift Card", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub calfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calfecha.ValueChanged
        dsdetalle.Clear()
        cmbcajero.Text = ""
        llenarcajeros()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscardatosgif()
    End Sub

    Public Function buscardatosgif() As Boolean



        Dim sseleccion As String = ""

        If Trim(cmbcajero.Text) = "" Then
            cmbcajero.Text = "TODOS"
        End If

        If cmbcajero.Text <> "TODOS" Then
            Dim codigocajero As Integer = 0
            'buscar el codigo del cajero
            Dim filac As DataRow()

            filac = dscajerosgift.Tables(0).Select("nombres='" & cmbcajero.Text & "'")
            codigocajero = filac(0)(0)

            sseleccion = " AND giftcard.codigocajero = '" & codigocajero & "'"

            If codigocajero = 0 Then
                MessageBox.Show("Error al buscar el codigo del cajero", "Gift Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function

            End If


        End If

        'buscar si solo es de una opcion especifica
        If Trim(cmbtipotransaccion.Text) = "" Then
            cmbtipotransaccion.Text = "TODAS"
        End If

        If cmbtipotransaccion.Text <> "TODAS" Then
            Dim icodigotransaccion As String = 0

            Dim filat As DataRow()

            filat = dstipostransaccion.Tables(0).Select("tipotransaccion= '" & cmbtipotransaccion.Text & "'")

            icodigotransaccion = filat(0)(0)

            sseleccion = sseleccion & " AND giftcard.`tipotransaccion` = " & icodigotransaccion & ""

            If icodigotransaccion = 0 Then
                MessageBox.Show("Error al buscar los tipos de transacciones", "Gift Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function

            End If

        End If


        comandogift.CommandText = "SELECT giftcard.notransaccionlocal,giftcard.nocaja,giftcard.codigocajero,usuarios.nombres,giftcard.fechatransaccion,SUBSTRING(giftcard.notarjeta,12,2) AS notarjeta,giftcard.tipotransaccion,giftcard_tipostransacciones.`tipotransaccion`,giftcard.monto,giftcard.montolamdpos,giftcard.`diferenciaoperacion`,giftcard.mensajerespuesta,giftcard.autorizacionrespuesta,giftcard.seriefactura,giftcard.nofactura FROM giftcard LEFT JOIN usuarios ON (giftcard.`codigocajero` = usuarios.id)INNER JOIN giftcard_tipostransacciones ON (giftcard.`tipotransaccion` = giftcard_tipostransacciones.`idtransaccion`) WHERE DATE(giftcard.fechatransaccion) = '" & Format(CDate(calfecha.Text), "yyyy-MM-dd") & "'" & sseleccion

        dagift.SelectCommand = comandogift

        dsdetalle.Clear()


        dagift.Fill(dsdetalle)






        If dsdetalle.Tables(0).Rows.Count > 0 Then







            dgdetalle.DataSource = dsdetalle.Tables(0)

            aplicarestilo()

            'buscar los giftcarvendidos
            comandogift.CommandText = "SELECT count(*) FROM giftcard WHERE finalizacion = 1 AND tarjetanueva = 1 AND DATE(fechatransaccion)= '" & Format(CDate(calfecha.Text), "yyyy-MM-dd") & "'" & sseleccion


            _conexionsuperpos.Open()

            lbgiftvendidos.Text = comandogift.ExecuteScalar

            _conexionsuperpos.Close()






        Else
            MessageBox.Show("No se encontro informacion", "Gift Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Function

    Private Sub aplicarestilo()
        dgdetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow


        dgdetalle.Columns("notransaccionlocal").HeaderText = "NoTlocal"
        dgdetalle.Columns("notransaccionlocal").Width = 1

        dgdetalle.Columns("nocaja").HeaderText = "NoCaja"
        dgdetalle.Columns("nocaja").Width = 50

        dgdetalle.Columns("codigocajero").HeaderText = "Cod Cajero"
        dgdetalle.Columns("codigocajero").Width = 60

        dgdetalle.Columns("nombres").HeaderText = "Cajero"
        dgdetalle.Columns("nombres").Width = 75

        dgdetalle.Columns("fechatransaccion").HeaderText = "Fecha Transaccion"
        dgdetalle.Columns("fechatransaccion").Width = 90

        dgdetalle.Columns("notarjeta").HeaderText = "Tarjeta"
        dgdetalle.Columns("notarjeta").Width = 50

        dgdetalle.Columns(6).HeaderText = "Cod Trans"
        dgdetalle.Columns(6).Width = 1

        dgdetalle.Columns(7).HeaderText = "Transaccion"
        dgdetalle.Columns(7).Width = 70

        dgdetalle.Columns("monto").HeaderText = "Monto"
        dgdetalle.Columns("monto").Width = 60

        dgdetalle.Columns("montolamdpos").HeaderText = "Monto Lamdpos"
        dgdetalle.Columns("montolamdpos").Width = 60

        dgdetalle.Columns("diferenciaoperacion").HeaderText = "Diferencia"
        dgdetalle.Columns("diferenciaoperacion").Width = 60

        dgdetalle.Columns("mensajerespuesta").HeaderText = "Respuesta"
        dgdetalle.Columns("mensajerespuesta").Width = 125

        dgdetalle.Columns("autorizacionrespuesta").HeaderText = "No Autorizacion"
        dgdetalle.Columns("autorizacionrespuesta").Width = 60

        dgdetalle.Columns("nofactura").HeaderText = "No Factura"
        dgdetalle.Columns("nofactura").Width = 60









    End Sub

    Private Sub cuadrarrecargas()
        Dim dstransaccionesfaltantes As New DataSet

        '1 buscar las transaccion que faltan
        comandogift.CommandText = "SELECT notransaccionlamdpos FROM giftcard WHERE montolamdpos = 0.00 AND tipotransaccion IN(6,12)"

        dagift.SelectCommand = comandogift

        dstransaccionesfaltantes.Clear()

        dagift.Fill(dstransaccionesfaltantes)

        If dstransaccionesfaltantes.Tables(0).Rows.Count > 0 Then
            'existen transacciones pendientes de cuadrar
            _conexionsuperpos.Open()
            For Each fila As DataRow In dstransaccionesfaltantes.Tables(0).Rows

                'actualiza las transacciones y las busca en lamdpos
                comandogift.CommandText = "UPDATE giftcard SET  montolamdpos =(SELECT SUM(total) FROM detalletransacciones WHERE idtransacciones = '" & fila(0) & "' AND upc = '7406282000012' GROUP BY upc)WHERE notransaccionlamdpos = '" & fila(0) & "'"
                comandogift.ExecuteNonQuery()

                'actualizar el monto
                comandogift.CommandText = "UPDATE giftcard SET diferenciaoperacion = (montolamdpos - montorespuesta) WHERE notransaccionlamdpos = '" & fila(0) & "'"
                comandogift.ExecuteNonQuery()


            Next


            _conexionsuperpos.Close()

        End If


    End Sub

    Private Sub cuadrarconsumos()
        Dim dscudrarconsumos As New DataSet

        '1 buscar las transacciones
        comandogift.CommandText = "SELECT notransaccionlamdpos FROM giftcard WHERE montolamdpos = 0.00 AND tipotransaccion IN(7,13) AND codigorespuesta = 0"

        dagift.SelectCommand = comandogift

        dscudrarconsumos.Clear()

        dagift.Fill(dscudrarconsumos)

        If dscudrarconsumos.Tables(0).Rows.Count > 0 Then
            _conexionsuperpos.Open()

            For Each fila1 As DataRow In dscudrarconsumos.Tables(0).Rows

                comandogift.CommandText = "UPDATE giftcard SET montolamdpos = (SELECT (SUM(detalletransacciones.total)* -1) AS totalrf FROM detalletransacciones INNER JOIN transacciones ON detalletransacciones.`Idtransacciones` = transacciones.`Id` WHERE transacciones.`Id` = '" & fila1(0) & "' AND detalletransacciones.`UPC` = '0000000001114' GROUP BY transacciones.`Id`)   WHERE(notransaccionlamdpos = '" & fila1(0) & "')"
                comandogift.ExecuteNonQuery()

                comandogift.CommandText = "UPDATE giftcard SET diferenciaoperacion = (montolamdpos - montorespuesta) WHERE(notransaccionlamdpos = '" & fila1(0) & "')"
                comandogift.ExecuteNonQuery()



            Next




            _conexionsuperpos.Close()


        End If


    End Sub

    Private Sub recargasenlamdpos()

        Dim sfechaactualizacion As String
        Dim dsrecargasenladmpos As New DataSet

        Dim snuevafecha As String


        'buscar la ultima fecha de actualizacion
        comandogift.CommandText = "SELECT svalor FROM unisuper_parametros WHERE correlativoparametro = 12 AND idprograma = 3"

        _conexionsuperpos.Open()
        sfechaactualizacion = comandogift.ExecuteScalar
        snuevafecha = DateAdd(DateInterval.Hour, -2, CDate(sfechaactualizacion))

        _conexionsuperpos.Close()


        comandogift.CommandText = "SELECT transacciones.id,transacciones.`IdCajas`,transacciones.`IdUsuarios`,transacciones.`Fin`,transacciones.`Serie`,transacciones.`NoDocumento`,SUM(detalletransacciones.`Total`) AS total FROM transacciones INNER JOIN detalletransacciones ON transacciones.`Id` = detalletransacciones.`Idtransacciones`  WHERE transacciones.fin > '" & Format(CDate(snuevafecha), "yyyy-MM-dd HH:mm:ss") & "' AND detalletransacciones.`UPC` = '7406282000012' GROUP BY transacciones.`Id`"

        dagift.SelectCommand = comandogift

        dsrecargasenladmpos.Clear()

        dagift.Fill(dsrecargasenladmpos)


        If dsrecargasenladmpos.Tables(0).Rows.Count > 0 Then
            _conexionsuperpos.Open()

            For Each fila2 As DataRow In dsrecargasenladmpos.Tables(0).Rows
                'recorre buscando las transacciones en la tabla de giftcard
                comandogift.CommandText = "SELECT notransaccionlocal FROM giftcard WHERE notransaccionlamdpos = '" & fila2(0) & "' AND date(fechatransaccion) >= '" & Format(CDate(snuevafecha), "yyyy-MM-dd") & "'"

                If comandogift.ExecuteScalar > 0 Then
                    'la transaccion existe
                Else
                    'la transaccion no existe
                    'la inserta el tabla de gifcard

                    comandogift.CommandText = "INSERT INTO giftcard(nocaja,codigocajero,fechatransaccion,notarjeta,tipotransaccion,monto,seriefactura,nofactura,notransaccionlamdpos,codigorespuesta,mensajerespuesta,mensajeoprespuesta,montolamdpos,montorespuesta,saldorespuesta)VALUES('" & fila2(1) & "','" & fila2(2) & "','" & Format(CDate(fila2(3)), "yyyy-MM-dd HH:mm:ss") & "',0,6,0.00,'" & fila2(4) & "','" & fila2(5) & "','" & fila2(0) & "',0,'RECARGA NO SOLICITADA','NO SOLICITO AUTORIZACION','" & fila2(6) & "',0.00,0.00)"
                    comandogift.ExecuteNonQuery()


                    comandogift.CommandText = "UPDATE giftcard SET diferenciaoperacion = (montolamdpos - montorespuesta) WHERE(notransaccionlamdpos = '" & fila2(0) & "')"
                    comandogift.ExecuteNonQuery()


                End If

            Next
            _conexionsuperpos.Close()
        End If

        sfechaactualizacion = Format(Now(), "yyyy-MM-dd HH:mm:ss")

        '_conexionsuperpos.Open()
        'comandogift.CommandText = "UPDATE unisuper_parametros SET svalor = '" & sfechaactualizacion & "' WHERE correlativoparametro = 12"
        'comandogift.ExecuteNonQuery()
        '_conexionsuperpos.Close()
    End Sub


    Private Sub consumoslampos()


        Dim sfechaactualizacion As String
        Dim snuevafecha As String
        Dim dsconsumosladmpos As New DataSet




        'buscar la ultima fecha de actualizacion
        comandogift.CommandText = "SELECT svalor FROM unisuper_parametros WHERE correlativoparametro = 12 AND idprograma = 3"

        _conexionsuperpos.Open()
        sfechaactualizacion = comandogift.ExecuteScalar

        snuevafecha = DateAdd(DateInterval.Hour, -2, CDate(sfechaactualizacion))
        _conexionsuperpos.Close()


        comandogift.CommandText = "SELECT transacciones.id,transacciones.`IdCajas`,transacciones.`IdUsuarios`,transacciones.`Fin`,transacciones.`Serie`,transacciones.`NoDocumento`,SUM(detalletransacciones.`Total`) AS total FROM transacciones INNER JOIN detalletransacciones ON transacciones.`Id` = detalletransacciones.`Idtransacciones`  WHERE transacciones.fin > '" & Format(CDate(snuevafecha), "yyyy-MM-dd HH:mm:ss") & "' AND detalletransacciones.`UPC` = '0000000001114' GROUP BY transacciones.`Id`"

        dagift.SelectCommand = comandogift

        dsconsumosladmpos.Clear()

        dagift.Fill(dsconsumosladmpos)


        If dsconsumosladmpos.Tables(0).Rows.Count > 0 Then
            _conexionsuperpos.Open()

            For Each fila3 As DataRow In dsconsumosladmpos.Tables(0).Rows
                'recorre buscando las transacciones en la tabla de giftcard
                comandogift.CommandText = "SELECT notransaccionlocal FROM giftcard WHERE notransaccionlamdpos = '" & fila3(0) & "' AND date(fechatransaccion) >= '" & Format(CDate(snuevafecha), "yyyy-MM-dd") & "'"

                If comandogift.ExecuteScalar > 0 Then
                    'la transaccion existe
                Else
                    'la transaccion no existe
                    'la inserta el tabla de gifcard

                    comandogift.CommandText = "INSERT INTO giftcard(nocaja,codigocajero,fechatransaccion,notarjeta,tipotransaccion,monto,seriefactura,nofactura,notransaccionlamdpos,codigorespuesta,mensajerespuesta,mensajeoprespuesta,montolamdpos,montorespuesta,saldorespuesta)VALUES('" & fila3(1) & "','" & fila3(2) & "','" & Format(CDate(fila3(3)), "yyyy-MM-dd HH:mm:ss") & "',0,7,0.00,'" & fila3(4) & "','" & fila3(5) & "','" & fila3(0) & "',0,'CONSUMO NO SOLICITADO','NO SOLICITO AUTORIZACION','" & fila3(6) & "',0.00,0.00)"

                    comandogift.ExecuteNonQuery()


                    comandogift.CommandText = "UPDATE giftcard SET diferenciaoperacion = (montolamdpos - montorespuesta) WHERE(notransaccionlamdpos = '" & fila3(0) & "')"
                    comandogift.ExecuteNonQuery()


                End If

            Next
            _conexionsuperpos.Close()
        End If

        sfechaactualizacion = Format(Now(), "yyyy-MM-dd HH:mm:ss")

        _conexionsuperpos.Open()
        comandogift.CommandText = "UPDATE unisuper_parametros SET svalor = '" & sfechaactualizacion & "' WHERE correlativoparametro = 12 AND idprograma = 3"
        comandogift.ExecuteNonQuery()
        _conexionsuperpos.Close()



    End Sub

    Private Sub cmdimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimir.Click

        If dsdetalle.Tables(0).Rows.Count > 0 Then
            dsdetalle.Tables(0).WriteXml("C:\BuzonF24\reporte1.xml", XmlWriteMode.WriteSchema)
            frmreportegift.Show()



        Else
            MessageBox.Show("No existen datos para imprimir", "GiftCard", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If




    End Sub

    Private Sub cmbcajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcajero.SelectedIndexChanged

    End Sub
End Class