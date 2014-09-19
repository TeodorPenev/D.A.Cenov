Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        If Button1.Top > 300 Then
            Button1.Top = 150
        ElseIf Button1.Top < 151 Then
            Button1.Top = 301
        End If
    End Sub
End Class
