<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2sum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4dev = New System.Windows.Forms.RadioButton()
        Me.RadioButton3multi = New System.Windows.Forms.RadioButton()
        Me.RadioButton2substract = New System.Windows.Forms.RadioButton()
        Me.RadioButton1sum = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Първо число"
        '
        'Label2sum
        '
        Me.Label2sum.AutoSize = True
        Me.Label2sum.Location = New System.Drawing.Point(84, 124)
        Me.Label2sum.Name = "Label2sum"
        Me.Label2sum.Size = New System.Drawing.Size(32, 13)
        Me.Label2sum.TabIndex = 1
        Me.Label2sum.Text = "Знак"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Отговор"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 178)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Второ число"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Изчисли"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(383, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Изход"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4dev)
        Me.GroupBox1.Controls.Add(Me.RadioButton3multi)
        Me.GroupBox1.Controls.Add(Me.RadioButton2substract)
        Me.GroupBox1.Controls.Add(Me.RadioButton1sum)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton4dev
        '
        Me.RadioButton4dev.AutoSize = True
        Me.RadioButton4dev.Location = New System.Drawing.Point(126, 44)
        Me.RadioButton4dev.Name = "RadioButton4dev"
        Me.RadioButton4dev.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton4dev.TabIndex = 3
        Me.RadioButton4dev.TabStop = True
        Me.RadioButton4dev.Text = "Деление"
        Me.RadioButton4dev.UseVisualStyleBackColor = True
        '
        'RadioButton3multi
        '
        Me.RadioButton3multi.AutoSize = True
        Me.RadioButton3multi.Location = New System.Drawing.Point(126, 21)
        Me.RadioButton3multi.Name = "RadioButton3multi"
        Me.RadioButton3multi.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton3multi.TabIndex = 2
        Me.RadioButton3multi.TabStop = True
        Me.RadioButton3multi.Text = "Умножение"
        Me.RadioButton3multi.UseVisualStyleBackColor = True
        '
        'RadioButton2substract
        '
        Me.RadioButton2substract.AutoSize = True
        Me.RadioButton2substract.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton2substract.Name = "RadioButton2substract"
        Me.RadioButton2substract.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton2substract.TabIndex = 1
        Me.RadioButton2substract.TabStop = True
        Me.RadioButton2substract.Text = "Изваждане"
        Me.RadioButton2substract.UseVisualStyleBackColor = True
        '
        'RadioButton1sum
        '
        Me.RadioButton1sum.AutoSize = True
        Me.RadioButton1sum.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1sum.Name = "RadioButton1sum"
        Me.RadioButton1sum.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1sum.TabIndex = 0
        Me.RadioButton1sum.TabStop = True
        Me.RadioButton1sum.Text = "Събиране"
        Me.RadioButton1sum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2sum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2sum As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4dev As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3multi As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2substract As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1sum As System.Windows.Forms.RadioButton

End Class
