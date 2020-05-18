Public Class GameBoard

    Private Sub BottomRight_Click(sender As Object, e As EventArgs) Handles BottomRight.Click
        If BottomRight.Text = " " Then
            BottomRight.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub BottomMid_Click(sender As Object, e As EventArgs) Handles BottomMid.Click
        If BottomMid.Text = " " Then
            BottomMid.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub BottomLeft_Click(sender As Object, e As EventArgs) Handles BottomLeft.Click
        If BottomLeft.Text = " " Then
            BottomLeft.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub MidRight_Click(sender As Object, e As EventArgs) Handles MidRight.Click
        If MidRight.Text = " " Then
            MidRight.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub MidMid_Click(sender As Object, e As EventArgs) Handles MidMid.Click
        If MidMid.Text = " " Then
            MidMid.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub MidLeft_Click(sender As Object, e As EventArgs) Handles MidLeft.Click
        If MidLeft.Text = " " Then
            MidLeft.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub TopRight_Click(sender As Object, e As EventArgs) Handles TopRight.Click
        If TopRight.Text = " " Then
            TopRight.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub TopMid_Click(sender As Object, e As EventArgs) Handles TopMid.Click
        If TopMid.Text = " " Then
            TopMid.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Private Sub TopLeft_Click(sender As Object, e As EventArgs) Handles TopLeft.Click
        If TopLeft.Text = " " Then
            TopLeft.Text = PrintMove()
            If Not (CheckWinner()) Then
                ChangeTurn()
            End If
        End If
    End Sub

    Function PrintMove() As Char
        If ShowTurn.Text = "Noughts" Then
            Return "O"
        Else
            Return "X"
        End If
    End Function

    Sub ChangeTurn()
        If ShowTurn.Text = "Noughts" Then
            ShowTurn.Text = "Cross"
        Else
            ShowTurn.Text = "Noughts"
        End If
    End Sub

    Function CheckWinner() As Boolean
        ' check if user has won or game is tied
        Dim TopRow(2) As Char
        Dim MidRow(2) As Char
        Dim BottomRow(2) As Char
        TopRow(0) = TopLeft.Text
        TopRow(1) = TopMid.Text
        TopRow(2) = TopRight.Text
        MidRow(0) = MidLeft.Text
        MidRow(1) = MidMid.Text
        MidRow(2) = MidRight.Text
        BottomRow(0) = BottomLeft.Text
        BottomRow(1) = BottomMid.Text
        BottomRow(2) = BottomRight.Text
        If (TopRow(0) = TopRow(1)) And (TopRow(1) = TopRow(2)) And (TopRow(0) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (MidRow(0) = MidRow(1)) And (MidRow(1) = MidRow(2)) And (MidRow(0) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (BottomRow(0) = BottomRow(1)) And (BottomRow(1) = BottomRow(2)) And (BottomRow(0) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (TopRow(0) = MidRow(0)) And (MidRow(0) = BottomRow(0)) And (TopRow(0) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (TopRow(1) = MidRow(1)) And (MidRow(1) = BottomRow(1)) And (TopRow(1) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (TopRow(2) = MidRow(2)) And (MidRow(2) = BottomRow(2)) And (TopRow(2) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (TopRow(0) = MidRow(1)) And (MidRow(1) = BottomRow(2)) And (TopRow(0) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        ElseIf (BottomRow(0) = MidRow(1)) And (MidRow(1) = TopRow(2)) And (TopRow(2) <> " ") Then
            ShowTurn.ForeColor = Color.Green
            Return True
        Else
            Return False
        End If
    End Function

End Class
