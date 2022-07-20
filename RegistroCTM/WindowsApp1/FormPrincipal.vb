Public Class FormPrincipal
    Private Sub ButtonRegistro_Click(sender As Object, e As EventArgs) Handles ButtonRegistro.Click
        Dim regitro = New FormRegistro()
        regitro.Show()
    End Sub

    Private Sub ButtonConsulta_Click(sender As Object, e As EventArgs) Handles ButtonConsulta.Click
        Dim consulta = New FormConsulta()
        consulta.Show()
    End Sub

    Private Sub ButtonPagos_Click(sender As Object, e As EventArgs) Handles ButtonPagos.Click
        Dim pagos = New FormPago()
        pagos.Show()
    End Sub

    Private Sub ButtonRetiro_Click(sender As Object, e As EventArgs) Handles ButtonRetiro.Click
        Dim retiro = New FormRetiros()
        retiro.Show()
    End Sub

    Private Sub ButtonTotales_Click(sender As Object, e As EventArgs) Handles ButtonTotales.Click
        Dim total = New FormTotales()
        total.Show()
    End Sub
End Class
