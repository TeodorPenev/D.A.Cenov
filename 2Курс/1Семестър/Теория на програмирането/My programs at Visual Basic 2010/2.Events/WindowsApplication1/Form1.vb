Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Hello World"
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter
        Label1.Text = "The mouse over me!"
    End Sub

    Private Sub Label1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label1.MouseLeave
        Label1.Text = "The mouse leave me!"
    End Sub

    Private Sub Form1_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Label1.Text = "The form is resized"
    End Sub
End Class
