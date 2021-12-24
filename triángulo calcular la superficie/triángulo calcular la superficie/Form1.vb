Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim cadena As Double
        a = txt2.Text * txt1.Text
        cadena = 1 / 2 * a
        MessageBox.Show("La superficie del trianglo es: " & cadena.ToString & " Cuadrados")
    End Sub
End Class
