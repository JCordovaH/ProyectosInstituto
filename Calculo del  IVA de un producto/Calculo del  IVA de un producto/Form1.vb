Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As Integer
        Dim sum As Integer

        cadena = txt2.Text / 100 * txt1.Text
        sum = Val(txt1.Text) + Val(cadena)

        MessageBox.Show("El 19% de iva del producto es: " & cadena.ToString)
        MessageBox.Show("El valor final del producto es: " & sum.ToString)
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class
