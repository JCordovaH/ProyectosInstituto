Public Class Form1

    

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        ' Arreglo de ejemplo con 10 valores
        Dim Valores() As Integer = New Integer(9) {10, 5, 35, 11, 3, 9, 15, 2, 12, 1}
        Dim Auxiliar As Integer = 0
        Dim Longitud As Integer = Valores.Length - 1

        ' Se hace un recorrido desde el segundo elemento hasta el ultimo
        For i As Integer = 1 To Longitud
            For j As Integer = 0 To Longitud - i
                If Valores(j) > Valores(j + 1) Then
                    Auxiliar = Valores(j)
                    Valores(j) = Valores(j + 1)
                    Valores(j + 1) = Auxiliar
                End If
            Next
        Next

        For i As Integer = 0 To Longitud
            Console.WriteLine(Valores(i))
        Next

        Console.ReadLine()

    End Sub

End Class
