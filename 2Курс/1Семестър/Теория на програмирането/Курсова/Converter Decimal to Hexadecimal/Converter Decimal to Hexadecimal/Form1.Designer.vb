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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuN = New System.Windows.Forms.NumericUpDown()
        Me.btStart = New System.Windows.Forms.Button()
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Десетично число:"
        '
        'NuN
        '
        Me.NuN.Location = New System.Drawing.Point(112, 29)
        Me.NuN.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuN.Name = "NuN"
        Me.NuN.Size = New System.Drawing.Size(120, 20)
        Me.NuN.TabIndex = 1
        Me.NuN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(54, 57)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(148, 23)
        Me.btStart.TabIndex = 2
        Me.btStart.Text = "В шестнадесетично"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(252, 95)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.NuN)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Преобразовател"
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NuN As System.Windows.Forms.NumericUpDown
    Friend WithEvents btStart As System.Windows.Forms.Button

End Class
