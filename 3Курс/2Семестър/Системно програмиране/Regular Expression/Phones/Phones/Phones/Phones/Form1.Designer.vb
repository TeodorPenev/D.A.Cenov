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
        Me.btStart = New System.Windows.Forms.Button()
        Me.lxMtel = New System.Windows.Forms.ListBox()
        Me.lxVivacom = New System.Windows.Forms.ListBox()
        Me.lxPhones = New System.Windows.Forms.ListBox()
        Me.lbMtel = New System.Windows.Forms.Label()
        Me.lbViva = New System.Windows.Forms.Label()
        Me.lbOthers = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(16, 369)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(403, 45)
        Me.btStart.TabIndex = 0
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'lxMtel
        '
        Me.lxMtel.FormattingEnabled = True
        Me.lxMtel.Location = New System.Drawing.Point(11, 21)
        Me.lxMtel.Name = "lxMtel"
        Me.lxMtel.Size = New System.Drawing.Size(118, 329)
        Me.lxMtel.TabIndex = 1
        '
        'lxVivacom
        '
        Me.lxVivacom.FormattingEnabled = True
        Me.lxVivacom.Location = New System.Drawing.Point(146, 21)
        Me.lxVivacom.Name = "lxVivacom"
        Me.lxVivacom.Size = New System.Drawing.Size(118, 329)
        Me.lxVivacom.TabIndex = 2
        '
        'lxPhones
        '
        Me.lxPhones.FormattingEnabled = True
        Me.lxPhones.Location = New System.Drawing.Point(285, 21)
        Me.lxPhones.Name = "lxPhones"
        Me.lxPhones.Size = New System.Drawing.Size(134, 329)
        Me.lxPhones.TabIndex = 3
        '
        'lbMtel
        '
        Me.lbMtel.AutoSize = True
        Me.lbMtel.Location = New System.Drawing.Point(52, 5)
        Me.lbMtel.Name = "lbMtel"
        Me.lbMtel.Size = New System.Drawing.Size(34, 13)
        Me.lbMtel.TabIndex = 4
        Me.lbMtel.Text = "M-Tel"
        '
        'lbViva
        '
        Me.lbViva.AutoSize = True
        Me.lbViva.Location = New System.Drawing.Point(175, 5)
        Me.lbViva.Name = "lbViva"
        Me.lbViva.Size = New System.Drawing.Size(48, 13)
        Me.lbViva.TabIndex = 5
        Me.lbViva.Text = "Vivacom"
        '
        'lbOthers
        '
        Me.lbOthers.AutoSize = True
        Me.lbOthers.Location = New System.Drawing.Point(324, 5)
        Me.lbOthers.Name = "lbOthers"
        Me.lbOthers.Size = New System.Drawing.Size(38, 13)
        Me.lbOthers.TabIndex = 6
        Me.lbOthers.Text = "Други"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 432)
        Me.Controls.Add(Me.lbOthers)
        Me.Controls.Add(Me.lbViva)
        Me.Controls.Add(Me.lbMtel)
        Me.Controls.Add(Me.lxPhones)
        Me.Controls.Add(Me.lxVivacom)
        Me.Controls.Add(Me.lxMtel)
        Me.Controls.Add(Me.btStart)
        Me.Name = "Form1"
        Me.Text = "Phones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents lxMtel As System.Windows.Forms.ListBox
    Friend WithEvents lxVivacom As System.Windows.Forms.ListBox
    Friend WithEvents lxPhones As System.Windows.Forms.ListBox
    Friend WithEvents lbMtel As System.Windows.Forms.Label
    Friend WithEvents lbViva As System.Windows.Forms.Label
    Friend WithEvents lbOthers As System.Windows.Forms.Label

End Class
