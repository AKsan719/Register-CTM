Imports System.Data.OleDb
Public Class FormPago
    Private Sub ButtonGuardarPago_Click(sender As Object, e As EventArgs) Handles ButtonGuardarPago.Click

        conectar()

        cadena_sql = "INSERT  INTO Pagos (Nombre,Moto,concepto,Ahorro,Cuota,Total,[Fecha De Emision],Recibido,Observacion,Estado)" _
                & "VALUES (@p_Nombre, @p_Moto,@p_concepto, @p_Ahorro, @p_Cuota, @p_Total, @p_Fecha_De_Emision, @p_Recibido, @p_Observacion, true)"

        Dim comando As New OleDbCommand(cadena_sql, conexion)


        comando.Parameters.AddWithValue("@p_Nombre", ComboNombreCliente.SelectedValue)
        comando.Parameters.AddWithValue("@p_Moto", ComboBoxTipoMoto.SelectedValue)
        comando.Parameters.AddWithValue("@p_concepto", DateTimeConcepto.Value.ToString)
        comando.Parameters.AddWithValue("@p_Ahorro", PagoAhorro.Text)
        comando.Parameters.AddWithValue("@p_Cuota", CuotaPago.Text)
        comando.Parameters.AddWithValue("@p_Total", TotalPago.Text)
        comando.Parameters.AddWithValue("@p_Fecha_De_Emision", DateTimeFechaActual.Value.ToString)
        comando.Parameters.AddWithValue("@p_Recibido", TextRecibido.Text)
        comando.Parameters.AddWithValue("@p_Observacion", TextObservacion.Text)


        comando.ExecuteNonQuery()

        conexion.Close()

        MsgBox("Datos almacenados con exito")

    End Sub

    Private Sub FormPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()

        cadena_sql = "SELECT Miembro,Nombre FROM Miembros WHERE Estado = true;"

        Dim da_Nombre As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Nombre As New DataTable

        da_Nombre.Fill(dt_Nombre)
        ComboNombreCliente.DataSource = dt_Nombre
        ComboNombreCliente.ValueMember = "Miembro"
        ComboNombreCliente.DisplayMember = "Nombre"

        cadena_sql = "SELECT Id,Tipo FROM Tipo WHERE Estado = true;"

        Dim da_tipo As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_tipo As New DataTable

        da_tipo.Fill(dt_tipo)
        ComboBoxTipoMoto.DataSource = dt_tipo
        ComboBoxTipoMoto.ValueMember = "Id"
        ComboBoxTipoMoto.DisplayMember = "Tipo"

        conexion.Close()


    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim v_numero1 As Double = PagoAhorro.Text
        Dim v_numero2 As Double = CuotaPago.Text
        Dim v_resultado As Double = v_numero1 + v_numero2
        TotalPago.Text = v_resultado
    End Sub

    Private Sub ButtonLimpiarPagos_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarPagos.Click
        Dim limpiar As Limpiar = New Limpiar()
        limpiar.LimpiarCasillas(Me, GroupBoxpagps)
    End Sub
End Class