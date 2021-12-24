Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ci As Integer
        Dim es As Integer
        Dim cu As Integer
        ci = txtcilindro.Text / 2
        es = 4 / 3 * 3.14 * txtesfera.Text
        cu = txtcubo.Text
        MessageBox.Show("EL volumen del cilindro es : " & ci.ToString)
        MessageBox.Show("EL volumen de la esfera es: " & es.ToString)

    End Sub
End Class
