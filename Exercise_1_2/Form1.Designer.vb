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
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.rbnExercise1 = New System.Windows.Forms.RadioButton()
        Me.rbnExercise2 = New System.Windows.Forms.RadioButton()
        CType(Me.dgvMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvMain
        '
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(12, 42)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(710, 357)
        Me.dgvMain.TabIndex = 1
        '
        'rbnExercise1
        '
        Me.rbnExercise1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise1.AutoSize = true
        Me.rbnExercise1.Checked = true
        Me.rbnExercise1.Location = New System.Drawing.Point(12, 13)
        Me.rbnExercise1.Name = "rbnExercise1"
        Me.rbnExercise1.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise1.TabIndex = 2
        Me.rbnExercise1.TabStop = true
        Me.rbnExercise1.Text = "Exercise 1"
        Me.rbnExercise1.UseVisualStyleBackColor = true
        '
        'rbnExercise2
        '
        Me.rbnExercise2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbnExercise2.AutoSize = true
        Me.rbnExercise2.Location = New System.Drawing.Point(84, 13)
        Me.rbnExercise2.Name = "rbnExercise2"
        Me.rbnExercise2.Size = New System.Drawing.Size(66, 23)
        Me.rbnExercise2.TabIndex = 2
        Me.rbnExercise2.Text = "Exercise 2"
        Me.rbnExercise2.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.rbnExercise2)
        Me.Controls.Add(Me.rbnExercise1)
        Me.Controls.Add(Me.dgvMain)
        Me.Name = "Form1"
        Me.Text = "Exercises 1 & 2"
        CType(Me.dgvMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents rbnExercise1 As RadioButton
    Friend WithEvents rbnExercise2 As RadioButton
End Class
