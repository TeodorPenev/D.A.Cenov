Public Class Form1start

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2stop_Click(sender As System.Object, e As System.EventArgs) Handles Button2stop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
            AxWindowsMediaPlayer1.URL = "Movies\1.mp4"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
            AxWindowsMediaPlayer1.URL = "Movies\2.mp4"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        AxWindowsMediaPlayer1.URL = "Movies\3.mp4"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        AxWindowsMediaPlayer1.URL = "Movies\4.mp4"
    End Sub
End Class
