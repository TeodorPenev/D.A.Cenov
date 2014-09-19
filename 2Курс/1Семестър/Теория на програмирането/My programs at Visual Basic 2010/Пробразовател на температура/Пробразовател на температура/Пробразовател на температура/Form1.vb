Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FCТемпература, Целзий, Фаренхайт As Single
        Dim strFCТемпература As String
        Dim Prompt As String = "Моля въведете температура по Фаренхайт или по Целзий"
        Do
            strFCТемпература = InputBox(Prompt, "Фаренхайт Целзий Преобразовател")
            If strFCТемпература <> "" Then
                FCТемпература = CSng(strFCТемпература)
                Целзий = ((FCТемпература - 32) / 9) * 5
                Фаренхайт = ((FCТемпература * 9) / 5) + 32
                MsgBox(FCТемпература & "° Фаренхайт e " & Целзий & "° Целзий." & vbCrLf & FCТемпература & "° Целзий e " & Фаренхайт & "° Фаренхайт.", , "Преобразувана температура")
            End If
        Loop While strFCТемпература <> ""
        Me.Close()
    End Sub
End Class