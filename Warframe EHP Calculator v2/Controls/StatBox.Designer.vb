<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.StatLabel = New System.Windows.Forms.Label()
        Me.StatValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StatLabel
        '
        Me.StatLabel.Location = New System.Drawing.Point(0, 0)
        Me.StatLabel.Name = "StatLabel"
        Me.StatLabel.Size = New System.Drawing.Size(90, 20)
        Me.StatLabel.TabIndex = 0
        Me.StatLabel.Text = "StatLabel:"
        Me.StatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatValue
        '
        Me.StatValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.StatValue.Location = New System.Drawing.Point(90, 0)
        Me.StatValue.Name = "StatValue"
        Me.StatValue.ReadOnly = True
        Me.StatValue.Size = New System.Drawing.Size(85, 20)
        Me.StatValue.TabIndex = 1
        Me.StatValue.Text = "-"
        Me.StatValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatValue)
        Me.Controls.Add(Me.StatLabel)
        Me.MaximumSize = New System.Drawing.Size(175, 20)
        Me.MinimumSize = New System.Drawing.Size(175, 20)
        Me.Name = "StatBox"
        Me.Size = New System.Drawing.Size(175, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatLabel As Label
    Friend WithEvents StatValue As TextBox
End Class
