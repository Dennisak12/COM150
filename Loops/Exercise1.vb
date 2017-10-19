Public Class Exercise1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click



        'declare variable
        Dim n As Integer

        'start for loop
        For n = 5 To 1 Step -1
            lstOut.Items.Add(n)
        Next


    End Sub
End Class
