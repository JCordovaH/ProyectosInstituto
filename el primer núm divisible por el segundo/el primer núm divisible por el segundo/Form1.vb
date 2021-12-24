Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As Integer
        cadena = txt2.Text / txt1.Text

        MessageBox.Show("El resultado es: " & cadena.ToString)

    End Sub
End Class
