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
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbnExercise3 = New System.Windows.Forms.RadioButton()
        Me.rbnExercise4 = New System.Windows.Forms.RadioButton()
        Me.rbnExercise5 = New System.Windows.Forms.RadioButton()
        Me.rbnExercise6 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout
        '
        'flpMain
        '
        Me.flpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.flpMain.AutoScroll = true
        Me.flpMain.Location = New System.Drawing.Point(13, 42)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Size = New System.Drawing.Size(709, 357)
        Me.flpMain.TabIndex = 0
        '
        'rbnExercise3
        '
        Me.rbnExercise3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise3.AutoSize = true
        Me.rbnExercise3.Checked = true
        Me.rbnExercise3.Location = New System.Drawing.Point(13, 13)
        Me.rbnExercise3.Name = "rbnExercise3"
        Me.rbnExercise3.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise3.TabIndex = 1
        Me.rbnExercise3.TabStop = true
        Me.rbnExercise3.Text = "Exercise 3"
        Me.rbnExercise3.UseVisualStyleBackColor = true
        '
        'rbnExercise4
        '
        Me.rbnExercise4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise4.AutoSize = true
        Me.rbnExercise4.Location = New System.Drawing.Point(85, 13)
        Me.rbnExercise4.Name = "rbnExercise4"
        Me.rbnExercise4.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise4.TabIndex = 1
        Me.rbnExercise4.Text = "Exercise 4"
        Me.rbnExercise4.UseVisualStyleBackColor = true
        '
        'rbnExercise5
        '
        Me.rbnExercise5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise5.AutoSize = true
        Me.rbnExercise5.Location = New System.Drawing.Point(157, 13)
        Me.rbnExercise5.Name = "rbnExercise5"
        Me.rbnExercise5.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise5.TabIndex = 1
        Me.rbnExercise5.Text = "Exercise 5"
        Me.rbnExercise5.UseVisualStyleBackColor = true
        '
        'rbnExercise6
        '
        Me.rbnExercise6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise6.AutoSize = true
        Me.rbnExercise6.Location = New System.Drawing.Point(229, 13)
        Me.rbnExercise6.Name = "rbnExercise6"
        Me.rbnExercise6.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise6.TabIndex = 1
        Me.rbnExercise6.Text = "Exercise 6"
        Me.rbnExercise6.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.rbnExercise6)
        Me.Controls.Add(Me.rbnExercise5)
        Me.Controls.Add(Me.rbnExercise4)
        Me.Controls.Add(Me.rbnExercise3)
        Me.Name = "Form1"
        Me.Text = "Exercises 3, 4, 5 & 6"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents rbnExercise3 As RadioButton
    Friend WithEvents rbnExercise4 As RadioButton
    Friend WithEvents rbnExercise5 As RadioButton
    Friend WithEvents rbnExercise6 As RadioButton
End Class
