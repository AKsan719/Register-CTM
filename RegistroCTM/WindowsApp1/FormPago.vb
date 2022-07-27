Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Data.OleDb

Public Class FormPago
    Private Sub ButtonGuardarPago_Click(sender As Object, e As EventArgs) Handles ButtonGuardarPago.Click
        Try
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
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Verifique los datos y vuelva a ingresarlos")
        End Try

    End Sub

    Private Sub FormPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()

            cadena_sql = "SELECT Miembro,Nombre FROM Miembros WHERE Estado = true;"

            Dim da_Nombre As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_Nombre As New Data.DataTable

            da_Nombre.Fill(dt_Nombre)
            ComboNombreCliente.DataSource = dt_Nombre
            ComboNombreCliente.ValueMember = "Miembro"
            ComboNombreCliente.DisplayMember = "Nombre"

            cadena_sql = "SELECT Id,Tipo FROM Tipo WHERE Estado = true;"

            Dim da_tipo As New OleDbDataAdapter(cadena_sql, conexion)
            Dim dt_tipo As New Data.DataTable

            da_tipo.Fill(dt_tipo)
            ComboBoxTipoMoto.DataSource = dt_tipo
            ComboBoxTipoMoto.ValueMember = "Id"
            ComboBoxTipoMoto.DisplayMember = "Tipo"

            conexion.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try


    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Try
            Dim v_numero1 As Double = PagoAhorro.Text
            Dim v_numero2 As Double = CuotaPago.Text
            Dim v_resultado As Double = v_numero1 + v_numero2
            TotalPago.Text = v_resultado
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try

    End Sub

    Private Sub ButtonLimpiarPagos_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarPagos.Click
        Try
            Dim limpiar As Limpiar = New Limpiar()
            limpiar.LimpiarCasillas(Me, GroupBoxpagps)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")
        End Try

    End Sub

    Private Sub ButtonImprimirPagos_Click(sender As Object, e As EventArgs) Handles ButtonImprimirPagos.Click
        Try
            conectar()

            Dim consulta As String
            Dim lista As Byte

            If ComboNombreCliente.SelectedValue <> 0 Then
                consulta = "SELECT * FROM Miembros WHERE Miembro= " & ComboNombreCliente.SelectedValue & ""
                Dim adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                Dim registro = New DataSet
                adaptador.Fill(registro, "Miembros")
                lista = registro.Tables("Miembros").Rows.Count
                If lista <> 0 Then
                    TextGuardaCliente.Text = registro.Tables("Miembros").Rows(0).Item("Nombre")
                    TextGuardaTipo.Text = registro.Tables("Miembros").Rows(0).Item("Moto")
                End If
            End If

            If ComboNombreCliente.SelectedValue <> 0 Then
                consulta = "SELECT * FROM Tipo WHERE Id= " & TextGuardaTipo.Text & ""
                Dim adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                Dim registro = New DataSet
                adaptador.Fill(registro, "Tipo")
                lista = registro.Tables("Tipo").Rows.Count
                If lista <> 0 Then
                    TextGuardaTipo.Text = registro.Tables("Tipo").Rows(0).Item("Tipo")
                End If
            End If

            Dim html As String

            html = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocCliente.txt")

            html &= TextGuardaCliente.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocTipoMoto.txt")

            html &= TextGuardaTipo.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocConcepto.txt")

            html &= DateTimeConcepto.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocAhorro.txt")

            html &= PagoAhorro.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocCouta.txt")

            html &= CuotaPago.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocTotal.txt")

            html &= TotalPago.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocObservacion.txt")

            html &= TextObservacion.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocRecibido.txt")

            html &= TextObservacion.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocFecha.txt")

            html &= DateTimeFechaActual.Text

            html &= My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\DocFinal.txt")

            Dim htmlFilePath As String = My.Computer.FileSystem.CurrentDirectory & "\Comprobante.htm"
            File.WriteAllText(htmlFilePath, html)

            Dim word As _Application = New Microsoft.Office.Interop.Word.Application
            Dim wordDoc As _Document = word.Documents.Open(FileName:=htmlFilePath, ReadOnly:=False)
            wordDoc.SaveAs(FileName:=My.Computer.FileSystem.CurrentDirectory & "\Comprobante.doc", FileFormat:=WdSaveFormat.wdFormatRTF)
            CType(wordDoc, _Document).Close()
            CType(word, _Application).Quit()

            File.Delete(htmlFilePath)

            Dim oWord As Word.Application
            Dim oDoc As Word.Document
            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oDoc = oWord.Documents.Add(My.Computer.FileSystem.CurrentDirectory & "\Comprobante.doc")

            conexion.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message.ToString & "Llamar a soporte")

        End Try

    End Sub

End Class