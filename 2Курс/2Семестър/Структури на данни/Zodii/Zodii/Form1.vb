Public Class Form1

    Private Sub btStart_Click(sender As System.Object, e As System.EventArgs) Handles btStart.Click
        Dim egn As String = tbEGN.Text
        Dim m, d As Byte
        Dim data As Short
        Dim z As String

        m = Mid(egn, 3, 2))
        d = Mid(egn, 5, 2))

        If m > 40 Then
            m -= 40
        ElseIf m > 20 Then
            m -= 20
        End If

        data = m * 100 + d

        Select Case data
            Case 321 To 420
                z = "Oven"
            Case 421 To 521
                z = "Telec"
            Case 522 To 521
                z = "Bliznaci"
            Case 622 To 723
                z = "Rak"
            Case 724 To 823
                z = "Luv"
            Case 824 To 923
                z = "Deva"
            Case 924 To 1023
                z = "Vezni"
            Case 1024 To 1122
                z = "Skorpion"
            Case 1123 To 1222
                z = "Strelec"
            Case 1223 To 1231, 101 To 120
                z = "Kozirog"
        End Select
        MsgBox(z, MsgBoxStyle.OkOnly, "Zodiq")
    End Sub
End Class
