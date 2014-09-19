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
        Me.lxURLS = New System.Windows.Forms.ListBox()
        Me.lxDomains = New System.Windows.Forms.ListBox()
        Me.btSTart = New System.Windows.Forms.Button()
        Me.lbURLS = New System.Windows.Forms.Label()
        Me.lbDomains = New System.Windows.Forms.Label()
        Me.lbLines = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lxURLS
        '
        Me.lxURLS.FormattingEnabled = True
        Me.lxURLS.Location = New System.Drawing.Point(12, 50)
        Me.lxURLS.Name = "lxURLS"
        Me.lxURLS.Size = New System.Drawing.Size(219, 264)
        Me.lxURLS.TabIndex = 0
        '
        'lxDomains
        '
        Me.lxDomains.FormattingEnabled = True
        Me.lxDomains.Location = New System.Drawing.Point(288, 50)
        Me.lxDomains.Name = "lxDomains"
        Me.lxDomains.Size = New System.Drawing.Size(158, 264)
        Me.lxDomains.TabIndex = 1
        '
        'btSTart
        '
        Me.btSTart.Location = New System.Drawing.Point(118, 362)
        Me.btSTart.Name = "btSTart"
        Me.btSTart.Size = New System.Drawing.Size(238, 45)
        Me.btSTart.TabIndex = 2
        Me.btSTart.Text = "Анализ"
        Me.btSTart.UseVisualStyleBackColor = True
        '
        'lbURLS
        '
        Me.lbURLS.AutoSize = True
        Me.lbURLS.Location = New System.Drawing.Point(29, 25)
        Me.lbURLS.Name = "lbURLS"
        Me.lbURLS.Size = New System.Drawing.Size(0, 13)
        Me.lbURLS.TabIndex = 3
        '
        'lbDomains
        '
        Me.lbDomains.AutoSize = True
        Me.lbDomains.Location = New System.Drawing.Point(296, 32)
        Me.lbDomains.Name = "lbDomains"
        Me.lbDomains.Size = New System.Drawing.Size(0, 13)
        Me.lbDomains.TabIndex = 4
        '
        'lbLines
        '
        Me.lbLines.AutoSize = True
        Me.lbLines.Location = New System.Drawing.Point(132, 337)
        Me.lbLines.Name = "lbLines"
        Me.lbLines.Size = New System.Drawing.Size(0, 13)
        Me.lbLines.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 413)
        Me.Controls.Add(Me.lbLines)
        Me.Controls.Add(Me.lbDomains)
        Me.Controls.Add(Me.lbURLS)
        Me.Controls.Add(Me.btSTart)
        Me.Controls.Add(Me.lxDomains)
        Me.Controls.Add(Me.lxURLS)
        Me.Name = "Form1"
        Me.Text = "Log Analys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lxURLS As System.Windows.Forms.ListBox
    Friend WithEvents lxDomains As System.Windows.Forms.ListBox
    Friend WithEvents btSTart As System.Windows.Forms.Button
    Friend WithEvents lbURLS As System.Windows.Forms.Label
    Friend WithEvents lbDomains As System.Windows.Forms.Label
    Friend WithEvents lbLines As System.Windows.Forms.Label

End Class
