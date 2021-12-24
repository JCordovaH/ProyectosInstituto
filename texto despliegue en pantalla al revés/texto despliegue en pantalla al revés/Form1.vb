Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TestString As String = txt1.Text
        Dim revpalabra As String = StrReverse(TestString)

        MessageBox.Show(revpalabra.ToString)
    End Sub

   

End Class
