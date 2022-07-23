Imports System.Data.OleDb
Module Conexion_general

    Public conexion As OleDbConnection
    Public cadena_sql As String

    Public Sub conectar()
        conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\123\Desktop\CTM\RegistroCTM\WindowsApp1\bin\Debug\Registro CTM.accdb;Persist Security Info = False")
        conexion.Open()
    End Sub
End Module
