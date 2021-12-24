Public Class Form1

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 10

        If i >= txt1.Text Then

        Else
            MessageBox.Show("El numero ingresado no esta a rango ")
        End If

    End Sub
End Class
