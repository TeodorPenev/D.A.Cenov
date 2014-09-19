Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btcolor.Click
        Dim r As DialogResult
        r = cd.ShowDialog
        If r = Windows.Forms.DialogResult.OK Then
            Me.BackColor = cd.Color
        End If
    End Sub
End Class
