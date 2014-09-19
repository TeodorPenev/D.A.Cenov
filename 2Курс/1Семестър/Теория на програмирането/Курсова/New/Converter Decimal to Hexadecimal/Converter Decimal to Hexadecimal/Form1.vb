Public Class Form

    Private Sub btStart_Click(sender As System.Object, e As System.EventArgs) Handles btStart.Click
        Dim num As Integer
        Integer.TryParse(NuN.Text, num)
        TbRezultat.Text = Convert.ToString(num, 16).ToUpper
    End Sub
End Class
