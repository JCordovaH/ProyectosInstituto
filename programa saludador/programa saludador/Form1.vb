Public Class Form1

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim cadena As String
        cadena = txt1.Text
        MessageBox.Show("Hola " & cadena.ToString)
    End Sub
End Class
