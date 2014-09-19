Public Class Form1

    Private Sub btFreeForm_Click(sender As System.Object, e As System.EventArgs) Handles btFreeForm.Click
        Static br As Long = 0
        br += 1
        Dim freeform As New Form2
        freeform.Text = "No" & br
        freeform.Show()
    End Sub

    Private Sub btOwForm_Click(sender As System.Object, e As System.EventArgs) Handles btOwForm.Click
        Static br As Long = 0
        br += 1
        Dim freeform As New Form2
        freeform.Text = "No" & br
        freeform.BackColor = Color.Red
        freeform.Owner = Me
        freeform.Show()
    End Sub

    Private Sub btDialogForm_Click(sender As System.Object, e As System.EventArgs) Handles btDialogForm.Click
        Dim dialogform As New Form2
        dialogform.BackColor = Color.Blue
        dialogform.Text = "Dialog"
        dialogform.ShowDialog()
    End Sub

    Private Sub btDialogResult_Click(sender As System.Object, e As System.EventArgs) Handles btDialogResult.Click
        Dim dr As DialogResult
        Dim dialogform As New Form3
        dr = dialogform.ShowDialog
        If dr = Windows.Forms.DialogResult.OK Then
            MsgBox("OK")
        Else
            MsgBox("Cancel")
        End If
    End Sub
End Class
