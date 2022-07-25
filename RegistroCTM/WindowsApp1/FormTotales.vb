Imports System.Data.OleDb
Public Class FormTotales
    Private Sub ButtonHistorialCorte_Click(sender As Object, e As EventArgs) Handles ButtonHistorialCorte.Click

        conectar()

        cadena_sql = "SELECT * FROM Miembros WHERE estado = true;"

        Dim da_Total As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Total As New DataTable

        da_Total.Fill(dt_Total)
        DataGridCorte.DataSource = dt_Total

        conexion.Close()

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

    End Sub

    Private Sub FormTotales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_CTMDataSet.Totales' Puede moverla o quitarla según sea necesario.
        Me.TotalesTableAdapter.Fill(Me.Registro_CTMDataSet.Totales)

    End Sub
End Class