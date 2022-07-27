Imports System.Data.OleDb
Public Class FormRegistro
    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()

            cadena_sql = "SELECT Id,Tipo FROM Tipo WHERE Estado = true;"

            Dim da_tipo As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_tipo As New DataTable

            da_tipo.Fill(dt_tipo)
            ComboTipoMoto.DataSource = dt_tipo
            ComboTipoMoto.ValueMember = "Id"
            ComboTipoMoto.DisplayMember = "Tipo"

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try


    End Sub


    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            conectar()

            cadena_sql = "INSERT  INTO Miembros (Nombre,Moto,estado)" _
                    & "VALUES (@p_Nombre, @p_Moto, true)"

            Dim comando As New OleDbCommand(cadena_sql, conexion)


            comando.Parameters.AddWithValue("@p_Nombre", TextNombreMiembro.Text)
            comando.Parameters.AddWithValue("@p_id_tipo_sensor", ComboTipoMoto.SelectedValue)


            comando.ExecuteNonQuery()

            conexion.Close()

            MsgBox("Datos almacenados con exito")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Verifique los datos y vuelva a ingresarlos")
        End Try

    End Sub

    Private Sub ButtonVisualizar_Click(sender As Object, e As EventArgs) Handles ButtonVisualizar.Click
        Try
            conectar()

            cadena_sql = "SELECT Miembros.Miembro, Miembros.Nombre, Tipo.Tipo, Miembros.Estado 
                        FROM Tipo INNER JOIN Miembros ON Tipo.Id = Miembros.Moto 
                            WHERE (((Miembros.Estado)=True));"

            Dim da_Registro As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_Registro As New DataTable

            da_Registro.Fill(dt_Registro)
            DataGridRegistro.DataSource = dt_Registro

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            conectar()

            Dim v_id_Registro As String

            v_id_Registro = DataGridRegistro.CurrentRow.Cells("Miembro").Value


            cadena_sql = "UPDATE Miembros SET estado = false WHERE Miembro = @p_Miembro;"

            Dim comando As New OleDbCommand(cadena_sql, conexion)

            comando.Parameters.AddWithValue("@p_Miembro", v_id_Registro)

            comando.ExecuteNonQuery()

            conexion.Close()

            MsgBox("Registro eliminado con exito")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Volver a seleccionar el registro")
        End Try

    End Sub
End Class