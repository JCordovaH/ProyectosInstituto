Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num As Integer
        Dim Rdo As Integer
        Dim i As Integer

        Num = Integer.Parse(txt1.Text)
        txt2.Text = ""
        For i = 1 To 10
            Rdo = i * Num

            txt2.Text = txt2.Text + Num.ToString + " x " + i.ToString + " = " +
            Rdo.ToString + vbCrLf
        Next
    End Sub
End Class
