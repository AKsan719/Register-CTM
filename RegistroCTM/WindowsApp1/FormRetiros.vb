Imports System.Data.OleDb
Public Class FormRetiros
    Private Sub ButtonLRegistroRetiro_Click(sender As Object, e As EventArgs) Handles ButtonLRegistroRetiro.Click

        conectar()

        cadena_sql = "SELECT * FROM Retiro WHERE estado = true;"

        Dim da_Retiro As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Retiro As New DataTable

        da_Retiro.Fill(dt_Retiro)
        DataGridRegistroRetiro.DataSource = dt_Retiro

        conexion.Close()

    End Sub

    Private Sub ButtonGuardarRetiro_Click(sender As Object, e As EventArgs) Handles ButtonGuardarRetiro.Click

    End Sub

End Class