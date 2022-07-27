Imports System.Data.OleDb
Public Class FormTotales
    Private Sub ButtonHistorialCorte_Click(sender As Object, e As EventArgs) Handles ButtonHistorialCorte.Click
        Try
            conectar()

            cadena_sql = "SELECT * FROM Totales WHERE estado = true;"

            Dim da_Total As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_Total As New DataTable

            da_Total.Fill(dt_Total)
            DataGridCorte.DataSource = dt_Total

            conexion.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")

        End Try

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            conectar()

            cadena_sql = "INSERT  INTO Totales (Total_Ahorro, Total_Cuota, Total_Caja, Corte, Estado)" _
                    & "VALUES (@p_Total_Ahorro, @p_Total_Cuota, @p_Total_Caja, @p_Corte, true)"

            Dim comando As New OleDbCommand(cadena_sql, conexion)

            comando.Parameters.AddWithValue("@p_Total_Ahorro", BuscaTotalGeneralAhorro.Text)
            comando.Parameters.AddWithValue("@p_Total_Cuota", BuscaTotalGeneralCuota.Text)
            comando.Parameters.AddWithValue("@p_Total_Caja", BuscaTotal.Text)
            comando.Parameters.AddWithValue("@p_Corte", DateTimeTotal.Value.ToString)


            comando.ExecuteNonQuery()

            conexion.Close()


            MsgBox("Datos almacenados con exito")

        Catch ex As Exception

            MsgBox("Error: " & ex.Message.ToString & "Verifique los datos y vuelva a ingresarlos")

        End Try


    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try

            conectar()

            cadena_sql = "SELECT SUM(Ahorro) AS SumaAhorro FROM Pagos WHERE estado = true;"

            Dim da_sum As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_sum As New DataTable

            da_sum.Fill(dt_sum)

            If dt_sum.Rows.Count() > 0 Then
                BuscaTotalGeneralAhorro.Text = dt_sum.Rows(0)("SumaAhorro").ToString()
            End If

            cadena_sql = "SELECT SUM(Cuota) AS SumaCuota FROM Pagos WHERE estado = true;"

            Dim da_suma As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_suma As New DataTable

            da_suma.Fill(dt_suma)

            If dt_suma.Rows.Count() > 0 Then
                BuscaTotalGeneralCuota.Text = dt_suma.Rows(0)("SumaCuota").ToString()
            End If

            cadena_sql = "SELECT SUM(Total) AS SumaTotal FROM Pagos WHERE estado = true;"

            Dim da_sumas As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_sumas As New DataTable

            da_sumas.Fill(dt_sumas)

            If dt_sumas.Rows.Count() > 0 Then
                BuscaTotal.Text = dt_sumas.Rows(0)("SumaTotal").ToString()
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try
    End Sub
End Class