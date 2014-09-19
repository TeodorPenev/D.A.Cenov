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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2sum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2Quit = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Първо число"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 1
        '
        'Label2sum
        '
        Me.Label2sum.AutoSize = True
        Me.Label2sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2sum.Location = New System.Drawing.Point(30, 104)
        Me.Label2sum.Name = "Label2sum"
        Me.Label2sum.Size = New System.Drawing.Size(32, 33)
        Me.Label2sum.TabIndex = 2
        Me.Label2sum.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Второ число"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(35, 190)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Отговор"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(35, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Изчисли"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2Quit
        '
        Me.Button2Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2Quit.Location = New System.Drawing.Point(359, 329)
        Me.Button2Quit.Name = "Button2Quit"
        Me.Button2Quit.Size = New System.Drawing.Size(100, 41)
        Me.Button2Quit.TabIndex = 7
        Me.Button2Quit.Text = "&Излез"
        Me.Button2Quit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4dev)
        Me.GroupBox1.Controls.Add(Me.RadioButton3multi)
        Me.GroupBox1.Controls.Add(Me.RadioButton2substract)
        Me.GroupBox1.Controls.Add(Me.RadioButton1sum)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 102)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Опции"
        '
        'RadioButton4dev
        '
        Me.RadioButton4dev.AutoSize = True
        Me.RadioButton4dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton4dev.Location = New System.Drawing.Point(128, 54)
        Me.RadioButton4dev.Name = "RadioButton4dev"
        Me.RadioButton4dev.Size = New System.Drawing.Size(115, 29)
        Me.RadioButton4dev.TabIndex = 3
        Me.RadioButton4dev.TabStop = True
        Me.RadioButton4dev.Text = "Раздели"
        Me.RadioButton4dev.UseVisualStyleBackColor = True
        '
        'RadioButton3multi
        '
        Me.RadioButton3multi.AutoSize = True
        Me.RadioButton3multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton3multi.Location = New System.Drawing.Point(13, 55)
        Me.RadioButton3multi.Name = "RadioButton3multi"
        Me.RadioButton3multi.Size = New System.Drawing.Size(109, 29)
        Me.RadioButton3multi.TabIndex = 2
        Me.RadioButton3multi.TabStop = True
        Me.RadioButton3multi.Text = "Умножи"
        Me.RadioButton3multi.UseVisualStyleBackColor = True
        '
        'RadioButton2substract
        '
        Me.RadioButton2substract.AutoSize = True
        Me.RadioButton2substract.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2substract.Location = New System.Drawing.Point(128, 19)
        Me.RadioButton2substract.Name = "RadioButton2substract"
        Me.RadioButton2substract.Size = New System.Drawing.Size(103, 29)
        Me.RadioButton2substract.TabIndex = 1
        Me.RadioButton2substract.TabStop = True
        Me.RadioButton2substract.Text = "Извади"
        Me.RadioButton2substract.UseVisualStyleBackColor = True
        '
        'RadioButton1sum
        '
        Me.RadioButton1sum.AutoSize = True
        Me.RadioButton1sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1sum.Location = New System.Drawing.Point(13, 19)
        Me.RadioButton1sum.Name = "RadioButton1sum"
        Me.RadioButton1sum.Size = New System.Drawing.Size(106, 29)
        Me.RadioButton1sum.TabIndex = 0
        Me.RadioButton1sum.TabStop = True
        Me.RadioButton1sum.Text = "Събери"
        Me.RadioButton1sum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2Quit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label2sum)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Калкулатор"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2sum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2Quit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4dev As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3multi As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2substract As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1sum As System.Windows.Forms.RadioButton

End Class
