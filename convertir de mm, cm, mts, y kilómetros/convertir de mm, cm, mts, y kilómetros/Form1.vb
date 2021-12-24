Public Class Form1
    Dim mm As Double
    Dim cm As Double
    Dim mt As Double
    Dim km As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mm = TextBox1.Text / 10000
        mm = TextBox1.Text / 1000.0
        mm = TextBox1.Text / 1000000

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cm = TextBox2.Text / 0.10000
        cm = TextBox2.Text / 100.0
        cm = TextBox2.Text / 100000
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mt = TextBox3.Text / 0.001
        mt = TextBox3.Text / 0.01
        mt = TextBox3.Text / 1000.0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        km = TextBox4.Text / 0.000001
        km = TextBox4.Text / 0.00001
        km = TextBox4.Text / 0.001
    End Sub
End Class
