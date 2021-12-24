Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Conectar
        con.conectado()
        con.insertar(CInt(txtrut.Text), txtnombre.Text, txtapellido.Text)
        con.desconectado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New Conectar
        Dim datos(2) As String
        Try
            con.conectado()
            datos = con.buscar(CInt(txtrut.Text))

            txtnombre.Text = datos(0).ToString
            txtapellido.Text = datos(1).ToString

            con.desconectado()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
