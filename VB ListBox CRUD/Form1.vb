Public Class Form1

    'ADD
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim name As String = nameTxt.Text
        ListBox1.Items.Add(name)
        ClearTxt()
    End Sub

    'UPDATE
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim index As Integer = ListBox1.SelectedIndex
        If index > -1 Then
            ListBox1.Items.RemoveAt(index)
            ListBox1.Items.Insert(index, nameTxt.Text)
        End If
    End Sub

    'DELETE
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim index As Integer = ListBox1.SelectedIndex
        If index > -1 Then
            ListBox1.Items.RemoveAt(index)
            ClearTxt()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index As Integer = ListBox1.SelectedIndex
        If index > -1 Then
            nameTxt.Text = ListBox1.SelectedItem.ToString()
        End If
    End Sub

    'CLEAR TXT
    Private Sub ClearTxt()
        nameTxt.Text = ""
    End Sub
End Class
