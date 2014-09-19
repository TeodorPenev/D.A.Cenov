Imports System.IO ' За работа с потоци
Imports System.Text.RegularExpressions 'За работа със шаблони
Public Class Form1

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        Dim fs As FileStream ' Поток
        Dim Sr As StreamReader ' Четец
        Dim ofd1 As New OpenFileDialog
        Dim dr As DialogResult
        Dim red As String ' Ред от файла
        Dim lines As Long = 0 ' Прочетени редове

        ' Шаблон
        ' Група 1 - целия адрес
        ' Група 2 - адреса до последната точка
        ' Група 3 - адреса след последната точка
        ' Група 4 - порт (след двуеточието) 
        Dim r As New Regex("\w+://((\w+\.)+(\w+))(:\d+)?/")
        '                          ------1------
        '                          ---2---=--3--=---4---

        Dim m As Match ' Съвпадение в шаблона




        lxDomains.BeginUpdate()
        lxUrls.BeginUpdate()

        'Подготвя диалога за избор на файл и ги показва
        ofd1.Title = "Изберете log файл"
        ofd1.Filter = "Logs|*.txt;*.log|All|*.*"
        dr = ofd1.ShowDialog

        If dr = DialogResult.OK Then
            'Създава поток и свързва четец с него
            fs = New FileStream(ofd1.FileName, FileMode.Open)
            Sr = New StreamReader(fs)

            Do While Sr.Peek <> -1 ' Докато има данни в потока
                lines += 1
                red = Sr.ReadLine ' Чете цял ред
                m = r.Match(red) ' Търси съвпадение в реда
                'Ако ИМА съвпадение и адреса не се състои от цифри (IP адрес)
                If m.Success AndAlso (Not IsNumeric(m.Groups(3).Value)) Then
                    ' Ако няма домейна в списъка го добавя
                    If lxDomains.Items.IndexOf(m.Groups(3).Value) = -1 Then
                        lxDomains.Items.Add(m.Groups(3).Value)
                    End If
                    ' Ако няма адреса в списъка го добавя
                    If lxUrls.Items.IndexOf(m.Groups(1).Value) = -1 Then
                        lxUrls.Items.Add(m.Groups(1).Value)
                    End If
                End If

            Loop

            lxDomains.EndUpdate()
            lxUrls.EndUpdate()
            Sr.Close()
            fs.Close()
        End If

        lbDomains.Text = "Домeйни:" & lxDomains.Items.Count.ToString
        lbUrls.Text = "Адреси:" & lxUrls.Items.Count.ToString
        lbLines.Text = "Обработени редове:" & lines.ToString
    End Sub

End Class



