Public Class Form1

    Dim mm1 As Double
    Dim mm2 As Double
    Dim mm3 As Double

    Dim cm1 As Double
    Dim cm2 As Double
    Dim cm3 As Double

    Dim mt1 As Double
    Dim mt2 As Double
    Dim mt3 As Double

    Dim km1 As Double
    Dim km2 As Double
    Dim km3 As Double

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        mm1 = TextBox1.Text / 10
        mm2 = TextBox1.Text / 10000
        mm3 = TextBox1.Text / 1000000
        MessageBox.Show("mm a cm " & mm1.ToString)
        MessageBox.Show("mm a mt " & mm2.ToString)
        MessageBox.Show("mm a km " & mm3.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cm1 = TextBox2.Text * 10
        cm2 = TextBox2.Text / 100
        cm3 = TextBox2.Text / 100000
        MessageBox.Show("cm a mm " & cm1.ToString)
        MessageBox.Show("cm a mt " & cm2.ToString)
        MessageBox.Show("cm a km " & cm3.ToString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mt1 = TextBox3.Text * 100
        mt2 = TextBox3.Text * 100
        mt3 = TextBox3.Text / 1000

        MessageBox.Show("mt a mm " & mt1.ToString)
        MessageBox.Show("mt a cm " & mt2.ToString)
        MessageBox.Show("mt a km " & mt3.ToString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        km1 = TextBox4.Text * 1000000
        km2 = TextBox4.Text * 100000
        km3 = TextBox4.Text * 1000

        MessageBox.Show("km a mm " & km1.ToString)
        MessageBox.Show("km a cm " & km2.ToString)
        MessageBox.Show("km a mt " & km3.ToString)
    End Sub


    
End Class
