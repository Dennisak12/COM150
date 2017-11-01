Public Class Exercise1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'declare and assign an array
        Dim n As Integer
        Dim ages(3) As Integer

        'assign values
        ages(0) = 5
        ages(1) = 3
        ages(2) = 12
        ages(3) = 10

        'loop
        For n = 0 To 3
            lstOut.Items.Add(ages(n))
        Next

    End Sub
End Class
