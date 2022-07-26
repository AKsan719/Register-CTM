Imports System.Data.OleDb
Public Class FormConsulta
    Private Sub ButtonHistorial_Click(sender As Object, e As EventArgs) Handles ButtonHistorial.Click

        conectar()

        cadena_sql = "SELECT Pagos.Id, Miembros.Nombre, Tipo.Tipo, Pagos.concepto, Pagos.Ahorro, Pagos.Cuota, Pagos.Total, Pagos.[Fecha De Emision], Pagos.Observacion, Pagos.Estado
                        FROM (Tipo INNER JOIN Pagos ON Tipo.Id = Pagos.Moto) INNER JOIN Miembros ON Pagos.Nombre = Miembros.Miembro
                            WHERE (((Miembros.Miembro)= " & ComboBuscaCliente.SelectedValue & ") AND ((Pagos.Estado)=True))
                                ORDER BY Pagos.[Fecha De Emision] DESC;"

        Dim da_Histopagos As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Histopagos As New DataTable

        da_Histopagos.Fill(dt_Histopagos)
        DataGridBusqueda.DataSource = dt_Histopagos

        Dim consulta As String
        Dim lista As Byte
        If ComboBuscaCliente.SelectedValue <> 0 Then
            consulta = "SELECT * FROM Miembros WHERE Miembro= " & ComboBuscaCliente.SelectedValue & ""
            Dim adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
            Dim registro = New DataSet
            adaptador.Fill(registro, "Miembros")
            lista = registro.Tables("Miembros").Rows.Count
            If lista <> 0 Then
                TextBuscaNombreMiembro.Text = registro.Tables("Miembros").Rows(0).Item("Nombre")
                TextBuscaTipoMoto.Text = registro.Tables("Miembros").Rows(0).Item("Moto")
            End If
        End If

        If ComboBuscaCliente.SelectedValue <> 0 Then
            consulta = "SELECT * FROM Tipo WHERE Id= " & TextBuscaTipoMoto.Text & ""
            Dim adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
            Dim registro = New DataSet
            adaptador.Fill(registro, "Tipo")
            lista = registro.Tables("Tipo").Rows.Count
            If lista <> 0 Then
                TextBuscaTipoMoto.Text = registro.Tables("Tipo").Rows(0).Item("Tipo")
            End If
        End If

        Dim TotalAhorro As Double = 0
        Dim TotalCouta As Double = 0
        Dim TotalTotal As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridBusqueda.Rows
            TotalAhorro += Convert.ToDouble(fila.Cells("Ahorro").Value)
            TotalCouta += Convert.ToDouble(fila.Cells("Cuota").Value)
            TotalTotal += Convert.ToDouble(fila.Cells("Total").Value)
        Next

        BuscaTotalAhorro.Text = Convert.ToString(TotalAhorro)
        BuscaTotalCuota.Text = Convert.ToString(TotalCouta)
        BuscaTotalAporte.Text = Convert.ToString(TotalTotal)

        conexion.Close()

    End Sub

    Private Sub FormConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()

        cadena_sql = "SELECT Miembro,Nombre FROM Miembros WHERE Estado = true;"

        Dim da_Nombre As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Nombre As New DataTable

        da_Nombre.Fill(dt_Nombre)
        ComboBuscaCliente.DataSource = dt_Nombre
        ComboBuscaCliente.ValueMember = "Miembro"
        ComboBuscaCliente.DisplayMember = "Nombre"

        conexion.Close()

    End Sub

    Private Sub ButtonBuscaFecha_Click(sender As Object, e As EventArgs) Handles ButtonBuscaFecha.Click

        conectar()

        cadena_sql = "SELECT Pagos.Id,Miembros.Nombre, Tipo.Tipo, Pagos.concepto, Pagos.Ahorro, Pagos.Cuota, Pagos.Total, Pagos.[Fecha De Emision], Pagos.Observacion, Pagos.Estado
                         FROM (Tipo INNER JOIN Pagos ON Tipo.Id = Pagos.Moto) INNER JOIN Miembros ON Pagos.Nombre = Miembros.Miembro
                           WHERE (((Pagos.concepto)=#" & TimeBuscaFecha.Text & "#) AND ((Pagos.Estado)=True))
                               ORDER BY Miembros.Nombre DESC;"

        Dim da_Histopagos As New OleDbDataAdapter(cadena_sql, conexion)
        Dim dt_Histopagos As New DataTable

        da_Histopagos.Fill(dt_Histopagos)
        DataGridBusqueda.DataSource = dt_Histopagos

        Dim TotalAhorro As Double = 0
        Dim TotalCouta As Double = 0
        Dim TotalTotal As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridBusqueda.Rows
            TotalAhorro += Convert.ToDouble(fila.Cells("Ahorro").Value)
            TotalCouta += Convert.ToDouble(fila.Cells("Cuota").Value)
            TotalTotal += Convert.ToDouble(fila.Cells("Total").Value)
        Next

        BuscaTotalAhorro.Text = Convert.ToString(TotalAhorro)
        BuscaTotalCuota.Text = Convert.ToString(TotalCouta)
        BuscaTotalAporte.Text = Convert.ToString(TotalTotal)

        conexion.Close()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        Dim v_id_Registro As String

        conectar()

        v_id_Registro = DataGridBusqueda.CurrentRow.Cells("Id").Value


        cadena_sql = "UPDATE Pagos SET Estado = false WHERE Id = @p_Id;"

        Dim comando As New OleDbCommand(cadena_sql, conexion)

        comando.Parameters.AddWithValue("@p_Id", v_id_Registro)

        comando.ExecuteNonQuery()

        conexion.Close()

        MsgBox("Registro eliminado con exito")

    End Sub
End Class