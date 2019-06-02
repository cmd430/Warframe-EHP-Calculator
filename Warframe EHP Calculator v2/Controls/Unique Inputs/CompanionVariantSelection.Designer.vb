<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompanionVariantSelection
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.CheckBox_Prime = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Prisma = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckBox_Prime
        '
        Me.CheckBox_Prime.AutoSize = True
        Me.CheckBox_Prime.Enabled = False
        Me.CheckBox_Prime.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox_Prime.Name = "CheckBox_Prime"
        Me.CheckBox_Prime.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox_Prime.TabIndex = 0
        Me.CheckBox_Prime.Text = "Prime"
        Me.CheckBox_Prime.UseVisualStyleBackColor = True
        '
        'CheckBox_Prisma
        '
        Me.CheckBox_Prisma.AutoSize = True
        Me.CheckBox_Prisma.Enabled = False
        Me.CheckBox_Prisma.Location = New System.Drawing.Point(61, 3)
        Me.CheckBox_Prisma.Name = "CheckBox_Prisma"
        Me.CheckBox_Prisma.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox_Prisma.TabIndex = 1
        Me.CheckBox_Prisma.Text = "Prisma"
        Me.CheckBox_Prisma.UseVisualStyleBackColor = True
        '
        'CompanionVariantSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckBox_Prisma)
        Me.Controls.Add(Me.CheckBox_Prime)
        Me.MaximumSize = New System.Drawing.Size(121, 21)
        Me.MinimumSize = New System.Drawing.Size(121, 21)
        Me.Name = "CompanionVariantSelection"
        Me.Size = New System.Drawing.Size(121, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox_Prime As CheckBox
    Friend WithEvents CheckBox_Prisma As CheckBox
End Class
