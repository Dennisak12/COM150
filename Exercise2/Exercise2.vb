Public Class Exercise2
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click


        'declare variables

        Dim drink As String
        Dim price As Double

        'initialize the drink variable
        drink = "Your beverage is "


        'select a size
        If (radSmall.Checked = True) Then
            drink = drink & "small "
            price = 1.29
        ElseIf (radMedium.Checked = True) Then
            drink = drink & "medium "
            price = 2.23
        ElseIf (radLarge.Checked = True) Then
            drink = drink & "large "
            price = 2.96
        End If

        'Output the Soda Size
        lstSelection.Items.Add(drink & "- $" & price)

    End Sub
End Class
