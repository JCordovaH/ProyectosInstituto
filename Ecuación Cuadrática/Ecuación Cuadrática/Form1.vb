Public Class Form1

    Private Property a As Double

    Private Property b As Double

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim disc, a, b, c, X1, X2 As Double
        a = txta.Text()
        b = txtb.Text
        c = txtc.Text
        disc = Math.Pow(b, 2) - 4 * a * c
        If (a <> 0) Then
            If ((disc) < 0) Then
                txtd.Text = "Tiene raices imaginarias"
            Else
                X1 = (-b + (Math.Sqrt(disc))) / (2 * a)
                X2 = (-b - (Math.Sqrt(disc))) / (2 * a)
                txtd.Text = "La raices son X1 = " +
                    Trim(X1) + " X2 = " + Trim(X2)
            End If
        Else
            txtd.Text =
        "coeficiente cuadratico debe ser diferente de cero"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txta_TextChanged(sender As Object, e As EventArgs) Handles txta.TextChanged
    End Sub

    Private Sub txtb_TextChanged(sender As Object, e As EventArgs) Handles txtb.TextChanged
    End Sub
End Class
