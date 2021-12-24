Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Integer
        c = txt1.Text * 1.8 + 32
        MessageBox.Show("Son: " & c.ToString & "℉")
    End Sub
End Class
