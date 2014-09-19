VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   2160
   ClientLeft      =   60
   ClientTop       =   420
   ClientWidth     =   6180
   LinkTopic       =   "Form1"
   ScaleHeight     =   2160
   ScaleWidth      =   6180
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "CONVERT"
      Height          =   375
      Left            =   960
      TabIndex        =   2
      Top             =   960
      Width           =   1815
   End
   Begin VB.TextBox Text2 
      Height          =   285
      Left            =   840
      TabIndex        =   1
      Text            =   "RESULT HERE AS HEXADECIMAL FROM 00 TO FF"
      Top             =   480
      Width           =   4335
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   840
      TabIndex        =   0
      Text            =   "INPUT HERE AS INTEGER FROM 0 TO 256"
      Top             =   120
      Width           =   5055
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Function converttoHEX(ByVal decimalnumber As Integer) As String
Dim firstbyte As String 'FIRST DIGIT HEX
Dim secondbyte As String 'SECOND DIGIT HEX
Dim tempval As String
Dim result As String
Dim remainder As Integer
remainder = decimalnumber Mod 16
If remainder = 0 Then
    firstbyte = "0"
ElseIf remainder = 1 Then
    firstbyte = "1"
ElseIf remainder = 2 Then
    firstbyte = "2"
ElseIf remainder = 3 Then
    firstbyte = "3"
ElseIf remainder = 4 Then
    firstbyte = "4"
ElseIf remainder = 5 Then
    firstbyte = "5"
ElseIf remainder = 6 Then
    firstbyte = "6"
ElseIf remainder = 7 Then
    firstbyte = "7"
ElseIf remainder = 8 Then
    firstbyte = "8"
ElseIf remainder = 9 Then
    firstbyte = "9"
ElseIf remainder = 10 Then
    firstbyte = "A"
ElseIf remainder = 11 Then
    firstbyte = "B"
ElseIf remainder = 12 Then
    firstbyte = "C"
ElseIf remainder = 13 Then
    firstbyte = "D"
ElseIf remainder = 14 Then
    firstbyte = "E"
ElseIf remainder = 15 Then
    firstbyte = "F"
End If

If decimalnumber >= 16 Then
    If decimalnumber >= 16 And decimalnumber <= 31 Then
        secondbyte = "1"
    ElseIf decimalnumber >= 32 And decimalnumber <= 47 Then
        secondbyte = "2"
    ElseIf decimalnumber >= 48 And decimalnumber <= 63 Then
        secondbyte = "3"
    ElseIf decimalnumber >= 64 And decimalnumber <= 79 Then
        secondbyte = "4"
    ElseIf decimalnumber >= 80 And decimalnumber <= 95 Then
        secondbyte = "5"
    ElseIf decimalnumber >= 96 And decimalnumber <= 111 Then
        secondbyte = "6"
    ElseIf decimalnumber >= 112 And decimalnumber <= 127 Then
        secondbyte = "7"
    ElseIf decimalnumber >= 128 And decimalnumber <= 143 Then
        secondbyte = "8"
    ElseIf decimalnumber >= 144 And decimalnumber <= 159 Then
        secondbyte = "9"
    ElseIf decimalnumber >= 160 And decimalnumber <= 175 Then
        secondbyte = "A"
    ElseIf decimalnumber >= 176 And decimalnumber <= 191 Then
        secondbyte = "B"
    ElseIf decimalnumber >= 192 And decimalnumber <= 207 Then
        secondbyte = "C"
    ElseIf decimalnumber >= 208 And decimalnumber <= 223 Then
        secondbyte = "D"
    ElseIf decimalnumber >= 224 And decimalnumber <= 239 Then
        secondbyte = "E"
    ElseIf decimalnumber >= 240 And decimalnumber <= 255 Then
        secondbyte = "F"
    End If
End If

    If decimalnumber <= 15 Then
        result = firstbyte
    Else
        result = secondbyte + firstbyte
    End If
    converttoHEX = result
    

End Function


Private Sub Command1_Click()
Dim K As Integer
K = Val(Text1.Text)
Text2.Text = converttoHEX(K)
End Sub

'REPORT FOR BUGz (ZINCKINGEYE@YAHOO.COM.PH)ALL SMALL CAPS
Private Sub Form_Load()

End Sub
