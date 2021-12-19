Public Class Home

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Gameplay.Show()
        Gameplay.Timer1.Enabled = True
    End Sub
End Class
