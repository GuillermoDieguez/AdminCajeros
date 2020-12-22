Imports MySql.Data.MySqlClient
Imports LibForms.FuncionesForms

Public Class frmReporteCajero

    ReadOnly _conexionsuperpos As New MySqlConnection
    ReadOnly _conexionforma24 As New MySqlConnection

    Dim comando As New MySqlCommand


    Dim tabla As String
    Dim _dscajas As New DataSet
    Dim _dsdatosCajero As New DataSet


    Private Sub frmReporteCajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _conexionsuperpos.ConnectionString = Sconexionsuperpos

        _dsdatosCajero = LlenarDataset("SELECT u.id, CONCAT(u.id, ' ', u.Nombres, ' ', Apellidos) AS Nombre FROM totales AS t INNER JOIN usuarios AS u ON t.`IdUsuarios` = u.`Id` WHERE Fecha = CURDATE() GROUP BY u.id", _conexionsuperpos)
        _dscajas = LlenarDataset("SELECT no_caja as caja, ip, puerto FROM cajas_ip", _conexionsuperpos)

        'cmbCajero.Items.Add("--Seleccionar Todos--")
        cmbCajero.ValueMember = "id"
        cmbCajero.DisplayMember = "Nombre"
        cmbCajero.DataSource = _dsdatosCajero.Tables(0)


        Dim contador As Integer
        contador = 0
        tabla = "tabla"
        
        llenargrid()

    End Sub



    Private Sub cmbCajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCajero.SelectedIndexChanged
        Dim _dsdatos As New DataSet
        For Each fila As DataRow In _dscajas.Tables(0).Rows()

            Dim conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & fila("ip").ToString & "; DataBase =  superpos; UID =  superpos; PWD =  97crela2t3; port = " & fila("puerto").ToString & ";"
            conexion.Open()

            Dim _dsdatosTemp As New MySqlDataAdapter("SELECT t.idUsuarios Id, ROUND((SUM(t.MontoTotal)),2) Monto, u.usuario Usuario, CONCAT(u.Nombres, ' ', Apellidos) AS Nombre, t.CajaActual as Caja FROM totales AS t INNER JOIN usuarios AS u ON t.`IdUsuarios` = u.`Id` WHERE u.`Id` = " & cmbCajero.SelectedValue.ToString & " AND fecha= CURDATE() GROUP BY idUsuarios", conexion)
            _dsdatosTemp.Fill(_dsdatos, "tabla")

        Next
        dgCuadre.DataSource = _dsdatos.Tables(0)

        Dim _dsdatosa As New DataSet
        For Each fila As DataRow In _dscajas.Tables(0).Rows()

            Dim conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & fila("ip").ToString & "; DataBase =  superpos; UID =  superpos; PWD =  97crela2t3; port = " & fila("puerto").ToString & ";"
            conexion.Open()

            Dim _dsdatosTemp As New MySqlDataAdapter("SELECT t.idUsuarios Id, ROUND((SUM(t.MontoTotal)),2) Monto, u.usuario Usuario, CONCAT(u.Nombres, ' ', Apellidos) AS Nombre, t.CajaActual as Caja FROM totales AS t INNER JOIN usuarios AS u ON t.`IdUsuarios` = u.`Id` WHERE u.`Id` = " & cmbCajero.SelectedValue.ToString & " AND fecha= CURDATE() GROUP BY idUsuarios", conexion)
            _dsdatosTemp.Fill(_dsdatosa, "tabla")

            For indexA = 1 To _dsdatosa.Tables(0).Rows.Count
                dgCuadre.Rows(indexA - 1).Cells("Caja").Value = fila("caja").ToString
            Next
        Next
        lbltotventa.Text = "Q." & String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(Monto)", "Id = Id"))
    End Sub

    Private Sub dgCuadre_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuadre.SelectionChanged

    End Sub


    Private Sub llenargrid()
        Dim _dsdatos As New DataSet
        For Each fila As DataRow In _dscajas.Tables(0).Rows()
            For Each cajero As DataRow In _dsdatosCajero.Tables(0).Rows()
                Dim conexion = New MySqlConnection()
                conexion.ConnectionString = "server=" & fila("ip").ToString & "; DataBase =  superpos; UID =  superpos; PWD =  97crela2t3; port = " & fila("puerto").ToString & ";"
                conexion.Open()

                Dim _dsdatosTemp As New MySqlDataAdapter("SELECT t.idUsuarios Id, ROUND((SUM(t.MontoTotal)),2) Monto, u.usuario Usuario, CONCAT(u.Nombres, ' ', Apellidos) AS Nombre, t.CajaActual as Caja FROM totales AS t INNER JOIN usuarios AS u ON t.`IdUsuarios` = u.`Id` WHERE u.`Id` = " & cajero("id").ToString & " AND fecha= CURDATE() GROUP BY idUsuarios", conexion)
                _dsdatosTemp.Fill(_dsdatos, "tabla")
            Next
        Next
        dgCuadre.DataSource = _dsdatos.Tables(0)

        Dim _dsdatosa As New DataSet
        For Each fila As DataRow In _dscajas.Tables(0).Rows()
            For Each cajero As DataRow In _dsdatosCajero.Tables(0).Rows()
                Dim conexion = New MySqlConnection()
                conexion.ConnectionString = "server=" & fila("ip").ToString & "; DataBase =  superpos; UID =  superpos; PWD =  97crela2t3; port = " & fila("puerto").ToString & ";"
                conexion.Open()

                Dim _dsdatosTemp As New MySqlDataAdapter("SELECT t.idUsuarios Id, ROUND((SUM(t.MontoTotal)),2) Monto, u.usuario Usuario, CONCAT(u.Nombres, ' ', Apellidos) AS Nombre, t.CajaActual as Caja FROM totales AS t INNER JOIN usuarios AS u ON t.`IdUsuarios` = u.`Id` WHERE u.`Id` = " & cajero("id").ToString & " AND fecha= CURDATE() GROUP BY idUsuarios", conexion)
                _dsdatosTemp.Fill(_dsdatosa, "tabla")
                For indexA = 1 To _dsdatosa.Tables(0).Rows.Count
                    dgCuadre.Rows(indexA - 1).Cells("Caja").Value = fila("caja").ToString
                Next
            Next
        Next
        lbltotventa.Text = "Q." & String.Format("{0:n}", _dsdatos.Tables(0).Compute("SUM(Monto)", "Id = Id"))

        dgCuadre.Columns("Id").Width = 50
        dgCuadre.Columns("Nombre").Width = 235
        dgCuadre.Columns("Caja").Width = 75

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llenargrid()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dispose()
    End Sub

    Private Sub lbltotventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotventa.Click

    End Sub

    Private Sub lbltxtventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltxtventa.Click

    End Sub
End Class