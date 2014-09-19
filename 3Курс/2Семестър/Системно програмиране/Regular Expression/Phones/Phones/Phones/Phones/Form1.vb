Imports System.IO ' За работа с потоци
Imports System.Text.RegularExpressions 'За работа със шаблони
Public Class Form1

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        Dim fs As FileStream ' Поток
        Dim sr As StreamReader ' Четец
        Dim ofd1 As New OpenFileDialog
        Dim dr As DialogResult
        Dim red As String ' Ред от файла
        Dim lines As Long = 0 ' Прочетени редове

        ' Шаблони
        ' MTel
        Dim rmtel As New Regex("(\s|^)(\+359|0)88(\d{7})(\s|$)", RegexOptions.Multiline)

        ' Виваком
        Dim rvivacom As New Regex("(\s|^)(\+359|0)87(\d{7})(\s|$)", RegexOptions.Multiline)

        'Изрази започващо с +359 или 0, последвани от ПОНЕ 6 цифри.
        'Не трябва да съдържат в началото 88 или 87!
        Dim rPhone As New Regex("(\s|^)(\+359|0)(?!(87|88))\d{6,}(\s|$)", RegexOptions.Multiline)

        Dim m As Match ' Съвпадение в шаблона
        
        'Подготовка на списъците
        lxMtel.BeginUpdate()
        lxVivacom.BeginUpdate()
        lxPhones.BeginUpdate()


        'Подготвя диалога за избор на файл и ги показва
        ofd1.Title = "Изберете файл"
        ofd1.Filter = "Phones|*.txt;*.log|All|*.*"
        dr = ofd1.ShowDialog

        If dr = DialogResult.OK Then
            'Създава поток и свързва четец с него
            fs = New FileStream(ofd1.FileName, FileMode.Open)
            Sr = New StreamReader(fs)

            Do While Sr.Peek <> -1 ' Докато има данни в потока
                lines += 1
                red = Sr.ReadLine ' Чете цял ред
                ' Обработка на Mtel 
                m = rmtel.Match(red)
                ' Повтаря докато има съвпадения
                Do While m.Success
                    ' Запазва резултата в унифициран вид (с +35988 в началото)
                    ' За целтта се взема само третата група.
                    ' Ако трябва да се запазва оригиналния вид на номера:
                    ' lxPhones.Items.Add(m.Value)
                    lxMtel.Items.Add("+35988" & m.Groups(3).Value)
                    m = m.NextMatch()
                Loop
                ' Обработка на Vivacom
                m = rvivacom.Match(red)
                Do While m.Success
                    ' Запазва резултата в унифициран вид (с +35987 в началото)
                    ' За целтта се взема само третата група.
                    ' Ако трябва да се запазва оригиналния вид на номера:
                    ' lxPhones.Items.Add(m.Value)
                    lxVivacom.Items.Add("+35987" & m.Groups(3).Value)
                    m = m.NextMatch()
                Loop
                ' Обработка на останалите номера
                m = rPhone.Match(red)
                Do While m.Success
                    'Записва номера в оригиналния му вид
                    lxPhones.Items.Add(m.Value)
                    m = m.NextMatch()
                Loop
            Loop

            lxMtel.EndUpdate()
            lxVivacom.EndUpdate()
            lxPhones.EndUpdate()
            Sr.Close()
            fs.Close()
            MessageBox.Show("Обработени:" & lines & " реда!", "Done!")
        End If

        
    End Sub

End Class
