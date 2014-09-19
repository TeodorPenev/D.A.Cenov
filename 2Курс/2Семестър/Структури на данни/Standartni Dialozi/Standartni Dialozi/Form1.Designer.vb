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
        Me.cd = New System.Windows.Forms.ColorDialog()
        Me.btcolor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cd
        '
        Me.cd.Color = System.Drawing.Color.Maroon
        Me.cd.FullOpen = True
        '
        'btcolor
        '
        Me.btcolor.Location = New System.Drawing.Point(101, 137)
        Me.btcolor.Name = "btcolor"
        Me.btcolor.Size = New System.Drawing.Size(155, 48)
        Me.btcolor.TabIndex = 0
        Me.btcolor.Text = "Цвят на формата"
        Me.btcolor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 353)
        Me.Controls.Add(Me.btcolor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cd As System.Windows.Forms.ColorDialog
    Friend WithEvents btcolor As System.Windows.Forms.Button

End Class
