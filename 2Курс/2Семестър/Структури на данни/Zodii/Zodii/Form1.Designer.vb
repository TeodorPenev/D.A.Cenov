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
        Me.tbEGN = New System.Windows.Forms.TextBox()
        Me.btStart = New System.Windows.Forms.Button()
        Me.LbEGN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbEGN
        '
        Me.tbEGN.Location = New System.Drawing.Point(49, 33)
        Me.tbEGN.Name = "tbEGN"
        Me.tbEGN.Size = New System.Drawing.Size(100, 20)
        Me.tbEGN.TabIndex = 0
        Me.tbEGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(155, 31)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 1
        Me.btStart.Text = "Zodiq"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'LbEGN
        '
        Me.LbEGN.AutoSize = True
        Me.LbEGN.Location = New System.Drawing.Point(7, 36)
        Me.LbEGN.Name = "LbEGN"
        Me.LbEGN.Size = New System.Drawing.Size(36, 13)
        Me.LbEGN.TabIndex = 2
        Me.LbEGN.Text = "EGN :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 89)
        Me.Controls.Add(Me.LbEGN)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.tbEGN)
        Me.Name = "Form1"
        Me.Text = "Zodii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEGN As System.Windows.Forms.TextBox
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents LbEGN As System.Windows.Forms.Label

End Class
