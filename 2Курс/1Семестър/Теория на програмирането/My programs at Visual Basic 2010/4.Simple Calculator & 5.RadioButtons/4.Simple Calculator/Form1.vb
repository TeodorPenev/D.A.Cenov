Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim answer As Decimal
    Private Sub RadioButton1sum_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1sum.CheckedChanged
        Label2sum.Text = "+"

    End Sub

    Private Sub RadioButton2substract_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2substract.CheckedChanged
        Label2sum.Text = "-"
    End Sub

    Private Sub RadioButton3multi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3multi.CheckedChanged
        Label2sum.Text = "*"
    End Sub

    Private Sub RadioButton4dev_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4dev.CheckedChanged
        Label2sum.Text = "\"
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        If RadioButton1sum.Checked = True Then
            answer = num1 + num2
        ElseIf RadioButton2substract.Checked = True Then
            answer = num1 - num2
        ElseIf RadioButton3multi.Checked = True Then
            answer = num1 * num2
        ElseIf RadioButton4dev.Checked = True Then
            answer = num1 / num2
        End If
        Label3.Text = answer
    End Sub

    Private Sub Button2Quit_Click(sender As System.Object, e As System.EventArgs) Handles Button2Quit.Click
        Close()

    End Sub
End Class


