Public Class Form1
    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\formulario ingresado.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "RUT: " & txtrut.Text & " Nombre: " & txtnombre.Text & " Apellido Paterno: " & txtappat.Text &
                                            " Apellido Materno: " & txtapmat.Text & " Fono " & txtfono.Text & " Dirección: " & txtdirec.Text & " Fecha de Nacimiento: " & txtfn.Text & vbCrLf, True)
        MessageBox.Show("Informacion del formulario ha sido Guardado")
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim texto As String
        texto = My.Computer.FileSystem.ReadAllText("C:\Users\JonAlex\Desktop\formulario ingresado.txt")
        Form2.TextBox1.Text = texto

        Dim obj As Object
        Dim archivo As Object
        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile("C:\Users\JonAlex\Desktop\formulario ingresado.txt")
        archivo.close()

    End Sub
End Class
