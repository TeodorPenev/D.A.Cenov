Public Class Form3

    Private Sub btExitOK_Click(sender As System.Object, e As System.EventArgs) Handles btExitOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class