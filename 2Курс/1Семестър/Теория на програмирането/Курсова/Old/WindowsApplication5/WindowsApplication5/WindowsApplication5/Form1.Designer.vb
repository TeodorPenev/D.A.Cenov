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
        Me.NuN = New System.Windows.Forms.NumericUpDown()
        Me.Lbn = New System.Windows.Forms.Label()
        Me.btStart = New System.Windows.Forms.Button()
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuN
        '
        Me.NuN.Location = New System.Drawing.Point(132, 20)
        Me.NuN.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NuN.Name = "NuN"
        Me.NuN.Size = New System.Drawing.Size(84, 20)
        Me.NuN.TabIndex = 0
        Me.NuN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbn
        '
        Me.Lbn.AutoSize = True
        Me.Lbn.Location = New System.Drawing.Point(12, 27)
        Me.Lbn.Name = "Lbn"
        Me.Lbn.Size = New System.Drawing.Size(91, 13)
        Me.Lbn.TabIndex = 1
        Me.Lbn.Text = "десетично число"
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(241, 21)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(121, 19)
        Me.btStart.TabIndex = 2
        Me.btStart.Text = "В  двоично"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 92)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.Lbn)
        Me.Controls.Add(Me.NuN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NuN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbn As System.Windows.Forms.Label
    Friend WithEvents btStart As System.Windows.Forms.Button

End Class
