Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Byte
        Dim b As Byte
        a = 5
        b = 5
        test(a, b)
        MsgBox(a)
        MsgBox(b)
    End Sub
    Sub test(ByVal p1 As Byte, ByRef p2 As Byte)
        p1 += 1
        p2 += 1
        MsgBox(p1)
        MsgBox(p2)
    End Sub
End Class
