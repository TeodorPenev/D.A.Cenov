<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.btStart = New System.Windows.Forms.Button()
        Me.NuN = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbRezultat = New System.Windows.Forms.TextBox()
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btStart
        '
        Me.btStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btStart.Location = New System.Drawing.Point(85, 49)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(97, 23)
        Me.btStart.TabIndex = 0
        Me.btStart.Text = "Преобразувай"
        Me.btStart.UseVisualStyleBackColor = False
        '
        'NuN
        '
        Me.NuN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.NuN.Location = New System.Drawing.Point(162, 23)
        Me.NuN.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NuN.Name = "NuN"
        Me.NuN.Size = New System.Drawing.Size(100, 20)
        Me.NuN.TabIndex = 1
        Me.NuN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Десетично число :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Шестнадесетично число :"
        '
        'TbRezultat
        '
        Me.TbRezultat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TbRezultat.Location = New System.Drawing.Point(162, 78)
        Me.TbRezultat.Name = "TbRezultat"
        Me.TbRezultat.ReadOnly = True
        Me.TbRezultat.Size = New System.Drawing.Size(100, 20)
        Me.TbRezultat.TabIndex = 4
        Me.TbRezultat.Text = "?"
        Me.TbRezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(279, 126)
        Me.Controls.Add(Me.TbRezultat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NuN)
        Me.Controls.Add(Me.btStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Преобразувател"
        CType(Me.NuN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents NuN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbRezultat As System.Windows.Forms.TextBox

End Class
