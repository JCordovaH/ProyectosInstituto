Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As Integer
        Dim a As Integer
        Dim b As Integer
        a = txt1.Text
        b = 3.14
        cadena = a / b

        MessageBox.Show("Su radio es: " & cadena.ToString)
    End Sub
End Class
