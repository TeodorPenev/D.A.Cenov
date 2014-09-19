Public Class Form1

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim x As Integer
        Randomize()

        For x = 1 To 6
            TextBox1.AppendText(Str(Int(Rnd() * 49)))


        Next
    End Sub
End Class
