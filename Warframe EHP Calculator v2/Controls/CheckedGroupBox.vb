Imports System.ComponentModel

Public Class CheckedGroupBox
    Inherits GroupBox

    Private WithEvents HeaderCheckBox As CheckBox
    Public WithEvents FlowLayout As FlowLayoutPanel

    ' Add the CheckBox to the control.
    Public Sub New()
        MyBase.New()
        HeaderCheckBox = New CheckBox With {
            .Location = New Point(6, -1),
            .AutoSize = True
        }
        Text = Name
        AutoSize = True
        Controls.Add(HeaderCheckBox)
        FlowLayout = New FlowLayoutPanel With {
            .Name = "FlowLayoutPanel1",
            .Dock = DockStyle.Fill,
            .AutoSize = True,
            .FlowDirection = FlowDirection.TopDown
        }
        Controls.Add(FlowLayout)
        AddHandler HeaderCheckBox.CheckedChanged, AddressOf EnableDisableControls
        AddHandler HeaderCheckBox.Layout, AddressOf EnableDisableControls
        AddHandler Layout, AddressOf DoLayout
    End Sub

#Region "Internal Functions / Events"

    Private Sub DoLayout()
        For Each control As Control In Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex)
            ' loop though in the tab order so we can keep our authored order when added to the flowlayout
            If Not control.Equals(HeaderCheckBox) And Not control.Equals(FlowLayout) Then
                If Not DesignMode Then            'prevent vs crash in designer
                    control.Parent = FlowLayout   'set the control parent to the flowlayout
                Else
                    FlowLayout.Hide()
                End If
                TryAddCheckEventListener(control) 'for limits
            End If
        Next control
    End Sub

    Private Sub EnableDisableControls(ByVal sender As Object, ByVal e As EventArgs)
        FlowLayout.Enabled = HeaderCheckBox.Checked
    End Sub

    Public Sub TryAddCheckEventListener(ByVal control As Control)
        Dim checkedInput As CheckedInput = TryCast(control, CheckedInput)
        If checkedInput IsNot Nothing Then
            AddHandler checkedInput.CheckedChanged, AddressOf ChildControlCheckChanged
        End If
    End Sub
    Private Sub ChildControlCheckChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim _Controls As ControlCollection = FlowLayout.Controls
        If Limited Then
            Dim checkedControls As Integer = 0
            For Each control In _Controls.OfType(Of CheckedInput)
                If control.Checked Then
                    checkedControls += 1
                End If
            Next
            If checkedControls = Limit Then
                For Each control In _Controls.OfType(Of CheckedInput)
                    If Not control.Checked Then
                        control.Enabled = False
                    End If
                Next
            Else
                For Each control In _Controls.OfType(Of CheckedInput)
                    control.Enabled = True
                Next
            End If
        End If
    End Sub

    Private Sub FlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayout.Paint
        If DesignMode Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed)
        End If
    End Sub

#End Region

#Region "Events"

    Public Event CheckedChanged As EventHandler
    Private Sub HeaderCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HeaderCheckBox.CheckedChanged
        RaiseEvent CheckedChanged(sender, e)
    End Sub

#End Region

    <Category("!Properties")>
    <DefaultValue("")>
    <Browsable(True)>
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal Value As String)
            MyBase.Text = Value
            HeaderCheckBox.Text = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(False)>
    <Browsable(True)>
    Public Property Checked() As Boolean
        Get
            Return HeaderCheckBox.Checked
        End Get
        Set(ByVal Value As Boolean)
            HeaderCheckBox.Checked = Value
        End Set
    End Property

    <Category("!Properties")>
    <Description("Only allow 'Limit' Items Checked")>
    <DefaultValue(False)>
    <Browsable(True)>
    Public Property Limited As Boolean = False
    <Category("!Properties")>
    <Description("Used when Limited is 'True'")>
    <DefaultValue(2)>
    <Browsable(True)>
    Public Property Limit As Integer = 2

End Class