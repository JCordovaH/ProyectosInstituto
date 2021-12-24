Public Class Form1
    Dim cb As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vector As Integer
        
        list1.MultiColumn = True
        list1.SelectionMode = SelectionMode.MultiExtended
        list1.BeginUpdate()
        list1.EndUpdate()
        sexo.Text = cb
        For vector = 0 To 10
            list1.Items.Add(maskrut.Text)
            list1.Items.Add(txtnombre.Text)
            list1.Items.Add(txtapaterno.Text)
            list1.Items.Add(txtamaterno.Text)
            list1.Items.Add(txtdireccion.Text)
            list1.Items.Add(masktf.Text)
            list1.Items.Add(sexo.Text)
            list1.Items.Add(maskfdn.Text)

        Next

    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        cb = "Femenino"
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        cb = "Masculino"
    End Sub

End Class
