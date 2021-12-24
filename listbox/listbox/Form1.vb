Public Class listbox

    
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        list1.Items.Add(txt1.Text)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        list1.Items.Remove(list1.SelectedItem)
        list2.Items.Remove(list2.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For x = 0 To list1.SelectedItems.Count - 1
            list2.Items.Add(list1.SelectedItems(x))

        Next
        For x = list1.SelectedItems.Count - 1 To 0 Step -1

            list1.Items.Remove(list1.SelectedItems(x))
        Next
        list2.Refresh()
        list1.Refresh()


    End Sub
End Class
