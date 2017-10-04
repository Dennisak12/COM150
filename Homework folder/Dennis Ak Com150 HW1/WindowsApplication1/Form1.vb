Public Class Form1
    Private Sub beforeSwapTxt_TextChanged(sender As Object, e As EventArgs) Handles beforeSwapTxt.TextChanged

    End Sub

    Private Sub swapBtn_Click(sender As Object, e As EventArgs) Handles swapBtn.Click
        afterSwapTxt.Text = beforeSwapTxt.Text
        beforeSwapTxt.Text = ""
    End Sub
End Class
