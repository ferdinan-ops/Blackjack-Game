Public Class Gameplay

    Sub dealer_card1()
        Dim i As Integer
        Dim IMG1() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
My.Resources._17, My.Resources._18,
 My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
My.Resources._24, My.Resources._25,
 My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
My.Resources._31, My.Resources._32,
 My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
 My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
My.Resources._43, My.Resources._44, My.Resources._45,
 My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
My.Resources._51, My.Resources._52}
        Randomize()
        i = Int(Rnd() * 51)
        Dim card1 As Integer = i
        Lbdealer1.Text = card1
        If IMG1(card1) Is My.Resources._1 And Lbdealer1.Text = 1 Then
            Lbdealer1.Text = 11
        End If
        Lbdealer1.Text += 1
        If Lbdealer1.Text > 10 And Lbdealer1.Text <= 13 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 14 Then
            Lbdealer1.Text = 11 ' AS
        End If
        If Lbdealer1.Text > 14 And Lbdealer1.Text <= 23 Then
            Lbdealer1.Text = Lbdealer1.Text - 13
        End If
        If Lbdealer1.Text > 23 And Lbdealer1.Text <= 26 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 27 Then
            Lbdealer1.Text = 11 'As
        End If
        If Lbdealer1.Text > 27 And Lbdealer1.Text <= 36 Then
            Lbdealer1.Text = Lbdealer1.Text - 26
        End If
        If Lbdealer1.Text > 36 And Lbdealer1.Text <= 39 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 40 Then
            Lbdealer1.Text = 11 'AS
        End If
        If Lbdealer1.Text > 40 And Lbdealer1.Text <= 49 Then
            Lbdealer1.Text = Lbdealer1.Text - 39
        End If
        If Lbdealer1.Text > 49 And Lbdealer1.Text <= 52 Then
            Lbdealer1.Text = 10
        End If
        Me.dealercard1.Image = IMG1(card1)
        dealercard1.Size = New Size(65, 90)
    End Sub
    Sub dealer_card2()
        Dim IMG2() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
My.Resources._5, My.Resources._6,
 My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
 My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
My.Resources._17, My.Resources._18,
 My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
My.Resources._24, My.Resources._25,
 My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
My.Resources._31, My.Resources._32,
 My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
 My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
My.Resources._43, My.Resources._44, My.Resources._45,
 My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
My.Resources._51, My.Resources._52}
        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card2 As Integer = i
        lbdealer2.Text = card2
        If IMG2(card2) Is My.Resources._1 And lbdealer2.Text = 1 Then
            lbdealer2.Text = 11
        End If
        lbdealer2.Text += 1
        If Val(lbdealer2.Text) > 10 And Val(lbdealer2.Text) <= 13 Then
            lbdealer2.Text = 10
        End If
        If lbdealer2.Text = 14 Then
            lbdealer2.Text = 11 ' AS
        End If
        If Val(lbdealer2.Text) > 14 And Val(lbdealer2.Text) <= 23 Then
            lbdealer2.Text = lbdealer2.Text - 13
        End If
        If Val(lbdealer2.Text) > 23 And Val(lbdealer2.Text) <= 26 Then
            lbdealer2.Text = 10
        End If
        If Val(lbdealer2.Text) = 27 Then
            lbdealer2.Text = 11 'As
        End If
        If Val(lbdealer2.Text) > 27 And Val(lbdealer2.Text) <= 36 Then
            lbdealer2.Text = lbdealer2.Text - 26
        End If
        If Val(lbdealer2.Text) > 36 And Val(lbdealer2.Text) <= 39 Then
            lbdealer2.Text = 10
        End If
        If Val(lbdealer2.Text) = 40 Then
            lbdealer2.Text = 11 'AS
        End If
        If Val(lbdealer2.Text) > 40 And Val(lbdealer2.Text) <= 49 Then
            lbdealer2.Text = lbdealer2.Text - 39
        End If
        If Val(lbdealer2.Text) > 49 And Val(lbdealer2.Text) <= 52 Then
            lbdealer2.Text = 10
        End If
        Me.dealercard2.Image = IMG2(card2)
        dealercard2.Size = New Size(65, 90)
    End Sub
    Sub user_card1()
        Dim i As Integer
        Dim IMG3() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
My.Resources._17, My.Resources._18,
 My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
My.Resources._24, My.Resources._25,
 My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
My.Resources._31, My.Resources._32,
 My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
 My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
My.Resources._43, My.Resources._44, My.Resources._45,
 My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
My.Resources._51, My.Resources._52}
        Randomize()
        i = Int(Rnd() * 51)
        Dim card3 As Integer = i
        lbuser1.Text = card3
        If IMG3(card3) Is My.Resources._1 And lbuser1.Text = 1 Then
            lbuser1.Text = 11
        End If
        lbuser1.Text += 1
        If lbuser1.Text > 10 And lbuser1.Text <= 13 Then
            lbuser1.Text = 10
        End If
        If lbuser1.Text = 14 Then
            lbuser1.Text = 11 ' AS
        End If
        If lbuser1.Text > 14 And lbuser1.Text <= 23 Then
            lbuser1.Text = lbuser1.Text - 13
        End If
        If lbuser1.Text > 23 And lbuser1.Text <= 26 Then
            lbuser1.Text = 10
        End If
        If lbuser1.Text = 27 Then
            lbuser1.Text = 11 'As
        End If
        If lbuser1.Text > 27 And lbuser1.Text <= 36 Then
            lbuser1.Text = lbuser1.Text - 26
        End If
        If lbuser1.Text > 36 And lbuser1.Text <= 39 Then
            lbuser1.Text = 10
        End If
        If lbuser1.Text = 40 Then
            lbuser1.Text = 11 'AS
        End If
        If lbuser1.Text > 40 And lbuser1.Text <= 49 Then
            lbuser1.Text = lbuser1.Text - 39
        End If
        If lbuser1.Text > 49 And lbuser1.Text <= 52 Then
            lbuser1.Text = 10
        End If
        Me.usercard1.Image = IMG3(card3)
        usercard1.Size = New Size(65, 90)
    End Sub
    Sub user_card2()
        Dim i As Integer
        Dim IMG4() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
My.Resources._17, My.Resources._18,
 My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
My.Resources._24, My.Resources._25,
 My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
My.Resources._31, My.Resources._32,
 My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
 My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
My.Resources._43, My.Resources._44, My.Resources._45,
 My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
My.Resources._51, My.Resources._52}
        Randomize()
        i = Int(Rnd() * 51)
        Dim card4 As Integer = i
        lbuser2.Text = card4
        If IMG4(card4) Is My.Resources._1 And lbuser2.Text = 1 Then
            lbuser2.Text = 11
        End If
        lbuser2.Text += 1
        If lbuser2.Text > 10 And lbuser2.Text <= 13 Then
            lbuser2.Text = 10
        End If
        If lbuser2.Text = 14 Then
            lbuser2.Text = 11 ' AS
        End If
        If Val(lbuser2.Text) > 14 And Val(lbuser2.Text) <= 23 Then
            lbuser2.Text = lbuser2.Text - 13
        End If
        If Val(lbuser2.Text) > 23 And Val(lbuser2.Text) <= 26 Then
            lbuser2.Text = 10
        End If
        If Val(lbuser2.Text) = 27 Then
            lbuser2.Text = 11 'As
        End If
        If Val(lbuser2.Text) > 27 And Val(lbuser2.Text) <= 36 Then
            lbuser2.Text = lbuser2.Text - 26
        End If
        If Val(lbuser2.Text) > 36 And Val(lbuser2.Text) <= 39 Then
            lbuser2.Text = 10
        End If
        If Val(lbuser2.Text) = 40 Then
            lbuser2.Text = 11 'AS
        End If
        If Val(lbuser2.Text) > 40 And Val(lbuser2.Text) <= 49 Then
            lbuser2.Text = lbuser2.Text - 39
        End If
        If Val(lbuser2.Text) > 49 And Val(lbuser2.Text) <= 52 Then
            lbuser2.Text = 10
        End If
        Me.usercard2.Image = IMG4(card4)
        usercard2.Size = New Size(65, 90)
    End Sub
    Sub dealer_card_end()
        If Val(jlh_dealer.Text) <= 21 And ket_dealer.Text = 0 Then
            Dim IMG9() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
                                    My.Resources._5, My.Resources._6,
                                    My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
                                    My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
                                    My.Resources._17, My.Resources._18,
                                    My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
                                    My.Resources._24, My.Resources._25,
                                    My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
                                    My.Resources._31, My.Resources._32,
                                    My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
                                    My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
                                    My.Resources._43, My.Resources._44, My.Resources._45,
                                    My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
                                    My.Resources._51, My.Resources._52}
            Dim i As Integer
            Randomize()
            i = Int(Rnd() * 52)
            Dim card9 As Integer = i
            lbdealer3.Text = card9
            If IMG9(card9) Is My.Resources._1 And lbdealer3.Text = 1 Then
                lbdealer3.Text = 11
            End If
            lbdealer3.Text += 1
            If Val(lbdealer3.Text) > 10 And Val(lbdealer3.Text) <= 13 Then
                lbdealer3.Text = 10
            End If
            If lbdealer3.Text = 14 Then
                lbdealer3.Text = 11 ' AS
            End If
            If Val(lbdealer3.Text) > 14 And Val(lbdealer3.Text) <= 23 Then
                lbdealer3.Text = lbdealer3.Text - 13
            End If
            If Val(lbdealer3.Text) > 23 And Val(lbdealer3.Text) <= 26 Then
                lbdealer3.Text = 10
            End If
            If Val(lbdealer3.Text) = 27 Then
                lbdealer3.Text = 11 'As
            End If
            If Val(lbdealer3.Text) > 27 And Val(lbdealer3.Text) <= 36 Then
                lbdealer3.Text = lbdealer3.Text - 26
            End If
            If Val(lbdealer3.Text) > 36 And Val(lbdealer3.Text) <= 39 Then
                lbdealer3.Text = 10
            End If
            If Val(lbdealer3.Text) = 40 Then
                lbdealer3.Text = 11 'AS
            End If
            If Val(lbdealer3.Text) > 40 And Val(lbdealer3.Text) <= 49 Then
                lbdealer3.Text = lbdealer3.Text - 39
            End If
            If Val(lbdealer3.Text) > 49 And Val(lbdealer3.Text) <= 52 Then
                lbdealer3.Text = 10
            End If
            Me.dealercard3.Image = IMG9(card9)
            dealercard3.Visible = True
            dealercard3.Size = New Size(65, 90)
            ket_dealer.Text = Val(ket_dealer.Text) + 1
            'kartu 4 dealer
        ElseIf Val(jlh_dealer.Text) <= 21 And ket_dealer.Text = 1 Then
            Dim IMG10() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
                                    My.Resources._5, My.Resources._6,
                                    My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
                                    My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
                                    My.Resources._17, My.Resources._18,
                                    My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
                                    My.Resources._24, My.Resources._25,
                                    My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
                                    My.Resources._31, My.Resources._32,
                                    My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
                                    My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
                                    My.Resources._43, My.Resources._44, My.Resources._45,
                                    My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
                                    My.Resources._51, My.Resources._52}
            Dim i As Integer
            Randomize()
            i = Int(Rnd() * 52)
            Dim card10 As Integer = i
            lbdealer4.Text = card10
            If IMG10(card10) Is My.Resources._1 And lbdealer4.Text = 1 Then
                lbdealer4.Text = 11
            End If
            lbdealer4.Text += 1
            If Val(lbdealer4.Text) > 10 And Val(lbdealer4.Text) <= 13 Then
                lbdealer4.Text = 10
            End If
            If lbdealer4.Text = 14 Then
                lbdealer4.Text = 11 ' AS
            End If
            If Val(lbdealer4.Text) > 14 And Val(lbdealer4.Text) <= 23 Then
                lbdealer4.Text = lbdealer4.Text - 13
            End If
            If Val(lbdealer4.Text) > 23 And Val(lbdealer4.Text) <= 26 Then
                lbdealer4.Text = 10
            End If
            If Val(lbdealer4.Text) = 27 Then
                lbdealer4.Text = 11 'As
            End If
            If Val(lbdealer4.Text) > 27 And Val(lbdealer4.Text) <= 36 Then
                lbdealer4.Text = lbdealer4.Text - 26
            End If
            If Val(lbdealer4.Text) > 36 And Val(lbdealer4.Text) <= 39 Then
                lbdealer4.Text = 10
            End If
            If Val(lbdealer4.Text) = 40 Then
                lbdealer4.Text = 11 'AS
            End If
            If Val(lbdealer4.Text) > 40 And Val(lbdealer4.Text) <= 49 Then
                lbdealer4.Text = lbdealer4.Text - 39
            End If
            If Val(lbdealer4.Text) > 49 And Val(lbdealer4.Text) <= 52 Then
                lbdealer4.Text = 10
            End If
            Me.dealercard4.Image = IMG10(card10)
            dealercard4.Visible = True
            dealercard4.Size = New Size(65, 90)
            ket_dealer.Text = Val(ket_dealer.Text) + 1
            'kartu dealer ke 5
        ElseIf Val(jlh_dealer.Text) <= 21 And ket_dealer.Text = 2 Then
            Dim IMG11() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
                                    My.Resources._5, My.Resources._6,
                                    My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
                                    My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
                                    My.Resources._17, My.Resources._18,
                                    My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
                                    My.Resources._24, My.Resources._25,
                                    My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
                                    My.Resources._31, My.Resources._32,
                                    My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
                                    My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
                                    My.Resources._43, My.Resources._44, My.Resources._45,
                                    My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
                                    My.Resources._51, My.Resources._52}
            Dim i As Integer
            Randomize()
            i = Int(Rnd() * 52)
            Dim card11 As Integer = i
            lbdealer5.Text = card11
            If IMG11(card11) Is My.Resources._1 And lbdealer5.Text = 1 Then
                lbdealer5.Text = 11
            End If
            lbdealer5.Text += 1
            If Val(lbdealer5.Text) > 10 And Val(lbdealer5.Text) <= 13 Then
                lbdealer5.Text = 10
            End If
            If lbdealer5.Text = 14 Then
                lbdealer5.Text = 11 ' AS
            End If
            If Val(lbdealer5.Text) > 14 And Val(lbdealer5.Text) <= 23 Then
                lbdealer5.Text = lbdealer5.Text - 13
            End If
            If Val(lbdealer5.Text) > 23 And Val(lbdealer5.Text) <= 26 Then
                lbdealer5.Text = 10
            End If
            If Val(lbdealer5.Text) = 27 Then
                lbdealer5.Text = 11 'As
            End If
            If Val(lbdealer5.Text) > 27 And Val(lbdealer5.Text) <= 36 Then
                lbdealer5.Text = lbdealer5.Text - 26
            End If
            If Val(lbdealer5.Text) > 36 And Val(lbdealer5.Text) <= 39 Then
                lbdealer5.Text = 10
            End If
            If Val(lbdealer5.Text) = 40 Then
                lbdealer5.Text = 11 'AS
            End If
            If Val(lbdealer5.Text) > 40 And Val(lbdealer5.Text) <= 49 Then
                lbdealer5.Text = lbdealer5.Text - 39
            End If
            If Val(lbdealer5.Text) > 49 And Val(lbdealer5.Text) <= 52 Then
                lbdealer5.Text = 10
            End If
            Me.dealercard5.Image = IMG11(card11)
            dealercard5.Visible = True
            dealercard5.Size = New Size(65, 90)
            ket_dealer.Text = Val(ket_dealer.Text) + 1
            'kartu dealer ke 6
        ElseIf Val(jlh_dealer.Text) <= 21 And ket_dealer.Text = 3 Then
            Dim IMG12() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4,
                                    My.Resources._5, My.Resources._6,
                                    My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
                                    My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
                                    My.Resources._17, My.Resources._18,
                                    My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
                                    My.Resources._24, My.Resources._25,
                                    My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
                                    My.Resources._31, My.Resources._32,
                                    My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
                                    My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
                                    My.Resources._43, My.Resources._44, My.Resources._45,
                                    My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
                                    My.Resources._51, My.Resources._52}
            Dim i As Integer
            Randomize()
            i = Int(Rnd() * 52)
            Dim card12 As Integer = i
            lbdealer6.Text = card12
            If IMG12(card12) Is My.Resources._1 And lbdealer6.Text = 1 Then
                lbdealer6.Text = 11
            End If
            lbdealer6.Text += 1
            If Val(lbdealer6.Text) > 10 And Val(lbdealer6.Text) <= 13 Then
                lbdealer6.Text = 10
            End If
            If lbdealer6.Text = 14 Then
                lbdealer6.Text = 11 ' AS
            End If
            If Val(lbdealer6.Text) > 14 And Val(lbdealer6.Text) <= 23 Then
                lbdealer6.Text = lbdealer6.Text - 13
            End If
            If Val(lbdealer6.Text) > 23 And Val(lbdealer6.Text) <= 26 Then
                lbdealer6.Text = 10
            End If
            If Val(lbdealer6.Text) = 27 Then
                lbdealer6.Text = 11 'As
            End If
            If Val(lbdealer6.Text) > 27 And Val(lbdealer6.Text) <= 36 Then
                lbdealer6.Text = lbdealer6.Text - 26
            End If
            If Val(lbdealer6.Text) > 36 And Val(lbdealer6.Text) <= 39 Then
                lbdealer6.Text = 10
            End If
            If Val(lbdealer6.Text) = 40 Then
                lbdealer6.Text = 11 'AS
            End If
            If Val(lbdealer6.Text) > 40 And Val(lbdealer6.Text) <= 49 Then
                lbdealer6.Text = lbdealer6.Text - 39
            End If
            If Val(lbdealer6.Text) > 49 And Val(lbdealer6.Text) <= 52 Then
                lbdealer6.Text = 10
            End If
            Me.dealercard6.Image = IMG12(card12)
            dealercard6.Visible = True
            dealercard6.Size = New Size(65, 90)
            ket_dealer.Text = Val(ket_dealer.Text) + 1
        End If
    End Sub
    

    Private Sub bt_hit_user_Click(sender As Object, e As EventArgs) Handles bt_hit_user.Click
        ket_user.Text = Val(ket_user.Text) + 1
        If ket_user.Text = 1 Then
            Dim i As Integer
            Dim IMG8() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
    My.Resources._17, My.Resources._18,
     My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
    My.Resources._24, My.Resources._25,
     My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
    My.Resources._31, My.Resources._32,
     My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
     My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
    My.Resources._43, My.Resources._44, My.Resources._45,
     My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
    My.Resources._51, My.Resources._52}
            Randomize()
            i = Int(Rnd() * 51)
            Dim card8 As Integer = i
            lbuser3.Text = card8
            If IMG8(card8) Is My.Resources._1 And lbuser3.Text = 1 Then
                lbuser3.Text = 11
            End If
            lbuser3.Text += 1
            If Val(lbuser3.Text) > 10 And Val(lbuser3.Text) <= 13 Then
                lbuser3.Text = 10
            End If
            If lbuser3.Text = 14 Then
                lbuser3.Text = 11 ' AS
            End If
            If Val(lbuser3.Text) > 14 And Val(lbuser3.Text) <= 23 Then
                lbuser3.Text = lbuser3.Text - 13
            End If
            If Val(lbuser3.Text) > 23 And Val(lbuser3.Text) <= 26 Then
                lbuser3.Text = 10
            End If
            If Val(lbuser3.Text) = 27 Then
                lbuser3.Text = 11 'As
            End If
            If Val(lbuser3.Text) > 27 And Val(lbuser3.Text) <= 36 Then
                lbuser3.Text = lbuser3.Text - 26
            End If
            If Val(lbuser3.Text) > 36 And Val(lbuser3.Text) <= 39 Then
                lbuser3.Text = 10
            End If
            If Val(lbuser3.Text) = 40 Then
                lbuser3.Text = 11 'AS
            End If
            If Val(lbuser3.Text) > 40 And Val(lbuser3.Text) <= 49 Then
                lbuser3.Text = lbuser3.Text - 39
            End If
            If Val(lbuser3.Text) > 49 And Val(lbuser3.Text) <= 52 Then
                lbuser3.Text = 10
            End If

            usercard3.Visible = True
            Me.usercard3.Image = IMG8(card8)
            usercard3.Size = New Size(65, 90)
        ElseIf ket_user.Text = 2 Then
            Dim i As Integer
            Dim IMG5() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
    My.Resources._17, My.Resources._18,
     My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
    My.Resources._24, My.Resources._25,
     My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
    My.Resources._31, My.Resources._32,
     My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
     My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
    My.Resources._43, My.Resources._44, My.Resources._45,
     My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
    My.Resources._51, My.Resources._52}
            Randomize()
            i = Int(Rnd() * 51)
            Dim card5 As Integer = i
            lbuser4.Text = card5
            If IMG5(card5) Is My.Resources._1 And lbuser4.Text = 1 Then
                lbuser4.Text = 11
            End If
            lbuser4.Text += 1
            If Val(lbuser4.Text) > 10 And Val(lbuser4.Text) <= 13 Then
                lbuser4.Text = 10
            End If
            If lbuser4.Text = 14 Then
                lbuser4.Text = 11
            End If
            If Val(lbuser4.Text) > 14 And Val(lbuser4.Text) <= 23 Then
                lbuser4.Text = lbuser4.Text - 13
            End If
            If Val(lbuser4.Text) > 23 And Val(lbuser4.Text) <= 26 Then
                lbuser4.Text = 10
            End If
            If Val(lbuser4.Text) = 27 Then
                lbuser4.Text = 11
            End If
            If Val(lbuser4.Text) > 27 And Val(lbuser4.Text) <= 36 Then
                lbuser4.Text = lbuser4.Text - 26
            End If
            If Val(lbuser4.Text) > 36 And Val(lbuser4.Text) <= 39 Then
                lbuser4.Text = 10
            End If
            If Val(lbuser4.Text) = 40 Then
                lbuser4.Text = 11
            End If
            If Val(lbuser4.Text) > 40 And Val(lbuser4.Text) <= 49 Then
                lbuser4.Text = lbuser4.Text - 39
            End If
            If Val(lbuser4.Text) > 49 And Val(lbuser4.Text) <= 52 Then
                lbuser4.Text = 10
            End If

            usercard4.Visible = True
            Me.usercard4.Image = IMG5(card5)
            usercard4.Size = New Size(65, 90)
        ElseIf ket_user.Text = 3 Then
            Dim i As Integer
            Dim IMG6() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
    My.Resources._17, My.Resources._18,
     My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
    My.Resources._24, My.Resources._25,
     My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
    My.Resources._31, My.Resources._32,
     My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
     My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
    My.Resources._43, My.Resources._44, My.Resources._45,
     My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
    My.Resources._51, My.Resources._52}
            Randomize()
            i = Int(Rnd() * 51)
            Dim card6 As Integer = i
            lbuser5.Text = card6
            If IMG6(card6) Is My.Resources._1 And lbuser5.Text = 1 Then
                lbuser5.Text = 11
            End If
            lbuser5.Text += 1
            If Val(lbuser5.Text) > 10 And Val(lbuser5.Text) <= 13 Then
                lbuser5.Text = 10
            End If
            If lbuser5.Text = 14 Then
                lbuser5.Text = 11
            End If
            If Val(lbuser5.Text) > 14 And Val(lbuser5.Text) <= 23 Then
                lbuser5.Text = lbuser5.Text - 13
            End If
            If Val(lbuser5.Text) > 23 And Val(lbuser5.Text) <= 26 Then
                lbuser5.Text = 10
            End If
            If Val(lbuser5.Text) = 27 Then
                lbuser5.Text = 11
            End If
            If Val(lbuser5.Text) > 27 And Val(lbuser5.Text) <= 36 Then
                lbuser5.Text = lbuser5.Text - 26
            End If
            If Val(lbuser5.Text) > 36 And Val(lbuser5.Text) <= 39 Then
                lbuser5.Text = 10
            End If
            If Val(lbuser5.Text) = 40 Then
                lbuser5.Text = 11
            End If
            If Val(lbuser5.Text) > 40 And Val(lbuser5.Text) <= 49 Then
                lbuser5.Text = lbuser5.Text - 39
            End If
            If Val(lbuser5.Text) > 49 And Val(lbuser5.Text) <= 52 Then
                lbuser5.Text = 10
            End If

            usercard5.Visible = True
            Me.usercard5.Image = IMG6(card6)
            usercard5.Size = New Size(65, 90)
        ElseIf ket_user.Text = 4 Then
            Dim i As Integer
            Dim IMG7() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16,
    My.Resources._17, My.Resources._18,
     My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23,
    My.Resources._24, My.Resources._25,
     My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30,
    My.Resources._31, My.Resources._32,
     My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
     My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42,
    My.Resources._43, My.Resources._44, My.Resources._45,
     My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50,
    My.Resources._51, My.Resources._52}
            Randomize()
            i = Int(Rnd() * 51)
            Dim card7 As Integer = i
            lbuser6.Text = card7
            If IMG7(card7) Is My.Resources._1 And lbuser6.Text = 1 Then
                lbuser6.Text = 11
            End If
            lbuser6.Text += 1
            If Val(lbuser6.Text) > 10 And Val(lbuser6.Text) <= 13 Then
                lbuser6.Text = 10
            End If
            If lbuser6.Text = 14 Then
                lbuser6.Text = 11 ' AS
            End If
            If Val(lbuser6.Text) > 14 And Val(lbuser6.Text) <= 23 Then
                lbuser6.Text = lbuser6.Text - 13
            End If
            If Val(lbuser6.Text) > 23 And Val(lbuser6.Text) <= 26 Then
                lbuser6.Text = 10
            End If
            If Val(lbuser6.Text) = 27 Then
                lbuser6.Text = 11 'As
            End If
            If Val(lbuser6.Text) > 27 And Val(lbuser6.Text) <= 36 Then
                lbuser6.Text = lbuser6.Text - 26
            End If
            If Val(lbuser6.Text) > 36 And Val(lbuser6.Text) <= 39 Then
                lbuser6.Text = 10
            End If
            If Val(lbuser6.Text) = 40 Then
                lbuser6.Text = 11 'AS
            End If
            If Val(lbuser6.Text) > 40 And Val(lbuser6.Text) <= 49 Then
                lbuser6.Text = lbuser6.Text - 39
            End If
            If Val(lbuser6.Text) > 49 And Val(lbuser6.Text) <= 52 Then
                lbuser6.Text = 10
            End If
            usercard6.Visible = True
            Me.usercard6.Image = IMG7(card7)
            usercard6.Size = New Size(65, 90)
        End If
        jlh_user.Text = Val(lbuser1.Text) + Val(lbuser2.Text) + Val(lbuser3.Text) + Val(lbuser4.Text) + Val(lbuser5.Text) + Val(lbuser6.Text)
        Timer5.Enabled = False
        Timer4.Enabled = False
        If Val(jlh_user.Text) > 21 Then
            MessageBox.Show("Sorry, You Lose :(")
            btRestart.Show()
        ElseIf Val(jlh_user.Text) = 21 Then
            MessageBox.Show("Congratulation!!!, You Win :)")
            btRestart.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = 6 Then
            loading.Visible = False
            Timer2.Enabled = True
        End If
        If Label1.Text = 8 Then
            Call dealer_card1()
            Call user_card1()
            Call user_card2()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        dealercard1.Visible = True
        dealercard2.Visible = True
        usercard1.Visible = True
        usercard2.Visible = True

        jlh_dealer.Visible = True
        jlh_user.Visible = True
        jlh_user.Text = Val(lbuser1.Text) + Val(lbuser2.Text) + Val(lbuser3.Text) + Val(lbuser4.Text) + Val(lbuser5.Text) + Val(lbuser6.Text)
        jlh_dealer.Text = Val(Lbdealer1.Text) + Val(lbdealer2.Text) + Val(lbdealer3.Text) + Val(lbdealer4.Text) + Val(lbdealer5.Text) + Val(lbdealer6.Text)
    End Sub
    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Call dealer_card2()
        Timer4.Enabled = True
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Val(jlh_dealer.Text) = 21 Then
            Timer5.Enabled = True
            MessageBox.Show("Sorry, You Losee :(")
            btRestart.Show()
        ElseIf Val(jlh_dealer.Text) > 21 Then
            Timer5.Enabled = True
            MessageBox.Show("Congratulation!!! , You Win :)")
            btRestart.Show()
        ElseIf Val(jlh_dealer.Text) <= 21 Then
            If Val(jlh_dealer.Text) < Val(jlh_user.Text) Then
                Call dealer_card_end()
            ElseIf Val(jlh_dealer.Text) >= 21 Then
                Timer5.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Enabled = False
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If Val(jlh_dealer.Text) = Val(jlh_user.Text) Then
            MessageBox.Show("Same Score")
            btRestart.Show()
        End If
    End Sub

    Private Sub Gameplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btRestart.Hide()
    End Sub

    Private Sub btRestart_Click_1(sender As Object, e As EventArgs) Handles btRestart.Click
        Lbdealer1.Text = 0
        lbdealer2.Text = 0
        lbdealer3.Text = 0
        lbdealer4.Text = 0
        lbdealer5.Text = 0
        lbdealer6.Text = 0
        lbuser1.Text = 0
        lbuser2.Text = 0
        lbuser3.Text = 0
        lbuser4.Text = 0
        lbuser5.Text = 0
        lbuser6.Text = 0
        jlh_dealer.Text = 0
        jlh_user.Text = 0
        ket_dealer.Text = 0
        ket_user.Text = 0
        Label1.Text = 0
        Timer5.Enabled = False
        Timer2.Enabled = False
        Timer1.Enabled = True
        loading.Visible = True
        dealercard1.Visible = False
        dealercard2.Visible = False
        dealercard1.Image = Blackjack_Project.My.Resources.Resources.back_card()
        dealercard2.Image = Blackjack_Project.My.Resources.Resources.back_card()
        dealercard1.Size = New Size(65, 90)
        dealercard2.Size = New Size(65, 90)
        dealercard3.Visible = False
        dealercard4.Visible = False
        dealercard5.Visible = False
        dealercard6.Visible = False
        usercard1.Visible = False
        usercard2.Visible = False
        usercard1.Image = Blackjack_Project.My.Resources.Resources.back_card()
        usercard2.Image = Blackjack_Project.My.Resources.Resources.back_card()
        usercard1.Size = New Size(65, 90)
        usercard2.Size = New Size(65, 90)
        usercard3.Visible = False
        usercard4.Visible = False
        usercard5.Visible = False
        usercard6.Visible = False
        jlh_dealer.Visible = False
        jlh_user.Visible = False
        btRestart.Hide()
    End Sub
End Class