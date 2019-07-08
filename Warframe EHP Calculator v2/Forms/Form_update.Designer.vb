<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_update))
        Me.Button_ignore = New System.Windows.Forms.Button()
        Me.Button_download = New System.Windows.Forms.Button()
        Me.Label_changes = New System.Windows.Forms.Label()
        Me.Label_updateAvailable = New System.Windows.Forms.Label()
        Me.TextBox_downloadLink = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_changes = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_ignore
        '
        Me.Button_ignore.Location = New System.Drawing.Point(327, 201)
        Me.Button_ignore.Name = "Button_ignore"
        Me.Button_ignore.Size = New System.Drawing.Size(75, 23)
        Me.Button_ignore.TabIndex = 0
        Me.Button_ignore.Text = "Ignore"
        Me.Button_ignore.UseVisualStyleBackColor = True
        '
        'Button_download
        '
        Me.Button_download.Location = New System.Drawing.Point(327, 28)
        Me.Button_download.Name = "Button_download"
        Me.Button_download.Size = New System.Drawing.Size(75, 23)
        Me.Button_download.TabIndex = 1
        Me.Button_download.Text = "Download"
        Me.Button_download.UseVisualStyleBackColor = True
        '
        'Label_changes
        '
        Me.Label_changes.AutoSize = True
        Me.Label_changes.Location = New System.Drawing.Point(12, 57)
        Me.Label_changes.Name = "Label_changes"
        Me.Label_changes.Size = New System.Drawing.Size(49, 13)
        Me.Label_changes.TabIndex = 3
        Me.Label_changes.Text = "Changes"
        '
        'Label_updateAvailable
        '
        Me.Label_updateAvailable.AutoSize = True
        Me.Label_updateAvailable.Location = New System.Drawing.Point(12, 9)
        Me.Label_updateAvailable.Name = "Label_updateAvailable"
        Me.Label_updateAvailable.Size = New System.Drawing.Size(248, 13)
        Me.Label_updateAvailable.TabIndex = 4
        Me.Label_updateAvailable.Text = "Update <Update version> is available for download"
        '
        'TextBox_downloadLink
        '
        Me.TextBox_downloadLink.Location = New System.Drawing.Point(12, 29)
        Me.TextBox_downloadLink.Name = "TextBox_downloadLink"
        Me.TextBox_downloadLink.ReadOnly = True
        Me.TextBox_downloadLink.Size = New System.Drawing.Size(309, 20)
        Me.TextBox_downloadLink.TabIndex = 5
        Me.TextBox_downloadLink.Text = "https://github.com/cmd430/Warframe-EHP-Calculator/raw/master/Warframe%20EHP%20Cal" &
    "culator%20v2/bin/Debug/Warframe%20EHP%20Calculator%20v2.exe"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox_changes)
        Me.Panel1.Location = New System.Drawing.Point(12, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 122)
        Me.Panel1.TabIndex = 6
        '
        'TextBox_changes
        '
        Me.TextBox_changes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_changes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_changes.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_changes.Name = "TextBox_changes"
        Me.TextBox_changes.ReadOnly = True
        Me.TextBox_changes.Size = New System.Drawing.Size(388, 120)
        Me.TextBox_changes.TabIndex = 0
        Me.TextBox_changes.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Update is downloaded via your broswer"
        '
        'Form_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 232)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox_downloadLink)
        Me.Controls.Add(Me.Label_updateAvailable)
        Me.Controls.Add(Me.Label_changes)
        Me.Controls.Add(Me.Button_download)
        Me.Controls.Add(Me.Button_ignore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_update"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "An Update is Available"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_ignore As Button
    Friend WithEvents Button_download As Button
    Friend WithEvents Label_changes As Label
    Friend WithEvents Label_updateAvailable As Label
    Friend WithEvents TextBox_downloadLink As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_changes As RichTextBox
    Friend WithEvents Label1 As Label
End Class
