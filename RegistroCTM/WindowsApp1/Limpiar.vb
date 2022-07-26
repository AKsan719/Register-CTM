Public Class Limpiar

    Sub LimpiarCasillas(ByVal control As Form, ByVal gb As GroupBox)
        Dim txt As Object
        Dim txtTemporal As TextBox
        Dim cmbTemporal As ComboBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            ElseIf TypeOf txt Is ComboBox Then
                cmbTemporal = CType(txt, ComboBox)
                cmbTemporal.SelectedIndex = 0
            End If
        Next

        For Each txt In gb.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            ElseIf TypeOf txt Is ComboBox Then
                cmbTemporal = CType(txt, ComboBox)
                cmbTemporal.SelectedIndex = 0
            End If
        Next

    End Sub

End Class
