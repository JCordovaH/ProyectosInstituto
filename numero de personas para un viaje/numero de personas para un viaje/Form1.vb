Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim r As Integer
        Dim cadena As Integer
        Dim cadena2 As Integer
        r = 0
        a = 45
        b = txt1.Text
        cadena = txt1.Text / 45
        cadena2 = txt1.Text / 45 * cadena + r
        MessageBox.Show("Numero de personas que iran al viaje: " & b.ToString)
        MessageBox.Show("Numero de buses: " & cadena.ToString)
        MessageBox.Show("Numero de personas en furgonetas : " & cadena2.ToString)
    End Sub
End Class
