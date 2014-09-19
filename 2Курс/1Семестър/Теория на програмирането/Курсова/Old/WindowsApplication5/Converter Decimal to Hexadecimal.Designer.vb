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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btStart = New System.Windows.Forms.Button()
        Me.Lbn = New System.Windows.Forms.Label()
        Me.NuN = New System.Windows.Forms.NumericUpDown()
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(206, 48)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(121, 19)
        Me.btStart.TabIndex = 5
        Me.btStart.Text = "В шестнадесетично"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'Lbn
        '
        Me.Lbn.AutoSize = True
        Me.Lbn.BackColor = System.Drawing.Color.Transparent
        Me.Lbn.ForeColor = System.Drawing.Color.Transparent
        Me.Lbn.Location = New System.Drawing.Point(3, 51)
        Me.Lbn.Name = "Lbn"
        Me.Lbn.Size = New System.Drawing.Size(97, 13)
        Me.Lbn.TabIndex = 4
        Me.Lbn.Text = "Десетично число:"
        '
        'NuN
        '
        Me.NuN.Location = New System.Drawing.Point(106, 47)
        Me.NuN.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuN.Name = "NuN"
        Me.NuN.Size = New System.Drawing.Size(84, 20)
        Me.NuN.TabIndex = 3
        Me.NuN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(336, 110)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.Lbn)
        Me.Controls.Add(Me.NuN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Преобразовател"
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents Lbn As System.Windows.Forms.Label
    Friend WithEvents NuN As System.Windows.Forms.NumericUpDown

End Class
