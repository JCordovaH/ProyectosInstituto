Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim r As Integer
        a = txt1.Text * txt1.Text
        b = txt2.Text * txt2.Text
        c = a + b
        r = c * c
        MessageBox.Show("El resultado es: " & r.ToString)
    End Sub
End Class
