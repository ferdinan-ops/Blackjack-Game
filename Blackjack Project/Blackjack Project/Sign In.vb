Public Class Sign_In


    Private Sub avatar1_Click(sender As Object, e As EventArgs) Handles avatar1.Click
        check1.Visible = True
        check2.Visible = False
        check3.Visible = False
        check4.Visible = False
        check5.Visible = False
        check6.Visible = False
    End Sub

    Private Sub avatar2_Click(sender As Object, e As EventArgs) Handles avatar2.Click
        check1.Visible = False
        check2.Visible = True
        check3.Visible = False
        check4.Visible = False
        check5.Visible = False
        check6.Visible = False
    End Sub

    Private Sub avatar3_Click(sender As Object, e As EventArgs) Handles avatar3.Click
        check1.Visible = False
        check2.Visible = False
        check3.Visible = True
        check4.Visible = False
        check5.Visible = False
        check6.Visible = False
    End Sub

    Private Sub avatar4_Click(sender As Object, e As EventArgs) Handles avatar4.Click
        check1.Visible = False
        check2.Visible = False
        check3.Visible = False
        check4.Visible = True
        check5.Visible = False
        check6.Visible = False
    End Sub

    Private Sub avatar5_Click(sender As Object, e As EventArgs) Handles avatar5.Click
        check1.Visible = False
        check2.Visible = False
        check3.Visible = False
        check4.Visible = False
        check5.Visible = True
        check6.Visible = False
    End Sub

    Private Sub avatar6_Click(sender As Object, e As EventArgs) Handles avatar6.Click
        check1.Visible = False
        check2.Visible = False
        check3.Visible = False
        check4.Visible = False
        check5.Visible = False
        check6.Visible = True
    End Sub

    Private Sub btSignIn_Click(sender As Object, e As EventArgs) Handles btSignIn.Click
        If check1.Visible = True Then
            Gameplay.user1.Visible = True
        ElseIf check2.Visible = True Then
            Gameplay.user2.Visible = True
        ElseIf check3.Visible = True Then
            Gameplay.user3.Visible = True
        ElseIf check4.Visible = True Then
            Gameplay.user4.Visible = True
        ElseIf check5.Visible = True Then
            Gameplay.user5.Visible = True
        ElseIf check6.Visible = True Then
            Gameplay.user6.Visible = True
        Else
            Gameplay.user1.Visible = True
        End If
        Gameplay.Username.Text = Username.Text
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Username_MouseClick(sender As Object, e As MouseEventArgs) Handles Username.MouseClick
        Username.Clear()
        Username.ForeColor = Color.Black
    End Sub
End Class