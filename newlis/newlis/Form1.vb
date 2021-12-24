Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add items to the ListBox.
        ListBox1.Items.Add("A")
        ListBox1.Items.Add("C")
        ListBox1.Items.Add("E")
        ListBox1.Items.Add("F")
        ListBox1.Items.Add("G")
        ListBox1.Items.Add("D")
        ListBox1.Items.Add("B")

        ' Sort all items added previously.
        ListBox1.Sorted = True

        ' Set the SelectionMode to select multiple items.
        ListBox1.SelectionMode = SelectionMode.MultiExtended

        ' Select three initial items from the list.
        ListBox1.SetSelected(0, True)
        ListBox1.SetSelected(2, True)
        ListBox1.SetSelected(4, True)

        ' Force the ListBox to scroll back to the top of the list.
        ListBox1.TopIndex = 0
    End Sub

    Private Sub InvertMySelection()

        Dim x As Integer
        ' Loop through all items the ListBox.
        For x = 0 To listBox1.Items.Count - 1

            ' Determine if the item is selected.
            If listBox1.GetSelected(x) = True Then
                ' Deselect all items that are selected.
                listBox1.SetSelected(x, False)
            Else
                ' Select all items that are not selected.
                listBox1.SetSelected(x, True)
            End If
        Next x
        ' Force the ListBox to scroll back to the top of the list.
        listBox1.TopIndex = 0
    End Sub
End Class
