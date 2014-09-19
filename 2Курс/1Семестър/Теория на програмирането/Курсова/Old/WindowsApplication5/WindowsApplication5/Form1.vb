Public Class Form1

    Private Sub btStart_Click(sender As System.Object, e As System.EventArgs) Handles btStart.Click
        Dim n As Short = NuN.Value
        Dim ostatyk As String
        Dim rezultat As String = ""
        Do While n > 0
            ostatyk = n Mod 16
            If ostatyk > 9 Then ostatyk = Chr(Asc("A") + ostatyk - 10)
            rezultat = ostatyk & rezultat
            n = n \ 16
        Loop
        MsgBox(rezultat, MsgBoxStyle.Information, "Шестнадесетично число")
    End Sub
End Class
