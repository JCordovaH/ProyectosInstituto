Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objeto As New Operaciones
        objeto.num1 = CInt(txtnum1.Text)
        objeto.num2 = CInt(txtnum2.Text)

        txtresultado.Text = objeto.suma

        objeto.num1 = CInt(txtnumres.Text)
        objeto.num2 = CInt(txtnum2res.Text)

        txtresultado2.Text = objeto.resta
    End Sub
End Class
