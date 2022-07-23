Imports System.Data.OleDb
Public Class FormRegistro
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        Dim v_id_Registro As String

        v_id_Registro = DataGridRegistro.CurrentRow.Cells("Nombre").Value

        conectar()

        cadena_sql = "UPDATE Miembros SET estado = false WHERE Nombre = @p_Nombre;"

        Dim comando As New OleDbCommand(cadena_sql, conexion)

        comando.Parameters.AddWithValue("@p_Nombre", v_id_Registro)

        comando.ExecuteNonQuery()

        conexion.Close()

        MsgBox("Registro eliminado con exito")

    End Sub


    Private Sub ButtonVisualizar_Click(sender As Object, e As EventArgs) Handles ButtonVisualizar.Click

        conectar()

        cadena_sql = "SELECT * FROM Miembros WHERE estado = true;"

        Dim da_Registro As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Registro As New DataTable

        da_Registro.Fill(dt_Registro)
        DataGridRegistro.DataSource = dt_Registro

        conexion.Close()
    End Sub
End Class