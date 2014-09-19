<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btExitOK = New System.Windows.Forms.Button()
        Me.btExitCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btExitOK
        '
        Me.btExitOK.Location = New System.Drawing.Point(96, 55)
        Me.btExitOK.Name = "btExitOK"
        Me.btExitOK.Size = New System.Drawing.Size(75, 23)
        Me.btExitOK.TabIndex = 0
        Me.btExitOK.Text = "OK"
        Me.btExitOK.UseVisualStyleBackColor = True
        '
        'btExitCancel
        '
        Me.btExitCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btExitCancel.Location = New System.Drawing.Point(96, 100)
        Me.btExitCancel.Name = "btExitCancel"
        Me.btExitCancel.Size = New System.Drawing.Size(75, 23)
        Me.btExitCancel.TabIndex = 1
        Me.btExitCancel.Text = "Cancel"
        Me.btExitCancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(275, 260)
        Me.Controls.Add(Me.btExitCancel)
        Me.Controls.Add(Me.btExitOK)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btExitOK As System.Windows.Forms.Button
    Friend WithEvents btExitCancel As System.Windows.Forms.Button
End Class
