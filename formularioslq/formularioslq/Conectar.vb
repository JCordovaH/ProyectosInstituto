Imports System.Data.SqlClient
Imports System.Data
Public Class Conectar
    Protected cnn As SqlConnection

    Public Function conectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-KOM8CB0\SQLEXPRESS;Initial Catalog=formulariosql;Integrated Security=True")
            cnn.Open()
            MsgBox("se ha conectado a la base de datoss")
        Catch ex As Exception
            MsgBox("error en la conexion" + vbCrLf + ex.Message)
        End Try
        Return True
    End Function

    Public Function desconectado()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-KOM8CB0\SQLEXPRESS;Initial Catalog=formulariosql;Integrated Security=True")
            cnn.Close()
            MsgBox("se ha desconectado a la base de datos")
        Catch ex As Exception
            MsgBox("error en la conexion" + vbCrLf + ex.Message)
        End Try
        Return True
    End Function

    Public Function insertar(r As Integer, nom As String, ape As String)
        Try
            Dim command As New SqlCommand("insert into dbo_persona(rut, Nombre, Apellido) values(@rut, @Nombre, @Apellido)", cnn)

            command.Parameters.Add("@rut", SqlDbType.Int).Value = r
            command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom
            command.Parameters.Add("@apellido", SqlDbType.VarChar).Value = ape

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("usuario insertado")
            Else
                MessageBox.Show("error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la conexion" + vbExclamation + ex.Message)
        End Try
        Return True
    End Function
    Public Function buscar(r As Integer) As String()
        Dim arreglo(2) As String
        Try
            Dim command As New SqlCommand("Select Nombre, Apellido from dbo_persona where rut=@rut", cnn)
            command.Parameters.Add("@rut", SqlDbType.Int).Value = r
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                arreglo(0) = table.Rows(0)(0).ToString()
                arreglo(1) = table.Rows(0)(1).ToString()
            Else
                MessageBox.Show("registro no encontrado")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCrLf)
        End Try
        Return arreglo
    End Function
End Class
