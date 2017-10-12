Public Class Exercise1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click

        'Check to see if label is visible
        If (lblHello.Visible = False) Then
            lblHello.Visible = True
        Else
            lblHello.Visible = False
        End If

    End Sub

    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub
End Class
