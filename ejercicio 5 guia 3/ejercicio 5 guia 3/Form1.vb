Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ci As Double
        Dim es As Double
        Dim cu As Integer
        Dim vcu As Integer
        ci = 0
        es = 0
        cu = 0

        ci = txtcilindro.Text / 2
        es = 4 / 3 * 3.14 * txtesfera.Text
        cu = txtcubo.Text * txtcubo.Text * txtcubo.Text
        MessageBox.Show("EL volumen del cilindro es : " & ci.ToString)
        MessageBox.Show("EL volumen de la esfera es: " & es.ToString)
        MessageBox.Show("EL volumen del cubo es: " & vcu.ToString)

    End Sub
End Class
