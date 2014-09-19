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
        Me.btFreeForm = New System.Windows.Forms.Button()
        Me.btOwForm = New System.Windows.Forms.Button()
        Me.btDialogForm = New System.Windows.Forms.Button()
        Me.btDialogResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btFreeForm
        '
        Me.btFreeForm.Location = New System.Drawing.Point(72, 23)
        Me.btFreeForm.Name = "btFreeForm"
        Me.btFreeForm.Size = New System.Drawing.Size(135, 37)
        Me.btFreeForm.TabIndex = 0
        Me.btFreeForm.Text = "Свободна Форма"
        Me.btFreeForm.UseVisualStyleBackColor = True
        '
        'btOwForm
        '
        Me.btOwForm.Location = New System.Drawing.Point(72, 80)
        Me.btOwForm.Name = "btOwForm"
        Me.btOwForm.Size = New System.Drawing.Size(135, 42)
        Me.btOwForm.TabIndex = 1
        Me.btOwForm.Text = "Полусвободна Форма"
        Me.btOwForm.UseVisualStyleBackColor = True
        '
        'btDialogForm
        '
        Me.btDialogForm.Location = New System.Drawing.Point(72, 140)
        Me.btDialogForm.Name = "btDialogForm"
        Me.btDialogForm.Size = New System.Drawing.Size(135, 41)
        Me.btDialogForm.TabIndex = 2
        Me.btDialogForm.Text = "Диалогова Форма"
        Me.btDialogForm.UseVisualStyleBackColor = True
        '
        'btDialogResult
        '
        Me.btDialogResult.Location = New System.Drawing.Point(72, 204)
        Me.btDialogResult.Name = "btDialogResult"
        Me.btDialogResult.Size = New System.Drawing.Size(135, 46)
        Me.btDialogResult.TabIndex = 3
        Me.btDialogResult.Text = "Резултат от диалог"
        Me.btDialogResult.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(285, 275)
        Me.Controls.Add(Me.btDialogResult)
        Me.Controls.Add(Me.btDialogForm)
        Me.Controls.Add(Me.btOwForm)
        Me.Controls.Add(Me.btFreeForm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btFreeForm As System.Windows.Forms.Button
    Friend WithEvents btOwForm As System.Windows.Forms.Button
    Friend WithEvents btDialogForm As System.Windows.Forms.Button
    Friend WithEvents btDialogResult As System.Windows.Forms.Button

End Class
