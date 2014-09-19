Public Class Form1

    Private Sub btStart_Click(sender As System.Object, e As System.EventArgs) Handles btStart.Click
        Dim n As Short = NuN.Value
        Dim ostatyk As Byte
        Dim rezultat As String = ""

        Do While n > 0
            ostatyk = n Mod 2
            rezultat = ostatyk & rezultat
            n = n \ 2

        Loop

        MsgBox(rezultat, MsgBoxStyle.Information, "Dvoichno chislo")


    End Sub

    Private Sub NuN_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NuN.ValueChanged

    End Sub
End Class
