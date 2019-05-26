Imports System.ComponentModel

Public Class CheckedDualInput
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        Text = Name
    End Sub

    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    <Category("!Properties")>
    Public Overrides Property Text As String
        Get
            Return CheckBox1.Text.TrimEnd(":")
        End Get
        Set(ByVal Value As String)
            CheckBox1.Text = Value & ":"
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue("")>
    <Browsable(True)>
    Public Property Secondary_Text As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal Value As String)
            Label1.Text = Value & ":"
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(False)>
    <Browsable(True)>
    Public Property Checked As Boolean
        Get
            Return CheckBox1.Checked
        End Get
        Set(ByVal Value As Boolean)
            CheckBox1.Checked = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(10)>
    <Browsable(True)>
    Public Property Maximum As Integer
        Get
            Return NumericUpDown1.Maximum
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown1.Maximum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Minimum As Integer
        Get
            Return NumericUpDown1.Minimum
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown1.Minimum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(1)>
    <Browsable(True)>
    Public Property Increment As Integer
        Get
            Return NumericUpDown1.Increment
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown1.Increment = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Value As Integer
        Get
            Return NumericUpDown1.Value
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown1.Value = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(5)>
    <Browsable(True)>
    Public Property Secondary_Maximum As Integer
        Get
            Return NumericUpDown2.Maximum
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown2.Maximum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Secondary_Minimum As Integer
        Get
            Return NumericUpDown2.Minimum
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown2.Minimum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(1)>
    <Browsable(True)>
    Public Property Secondary_Increment As Integer
        Get
            Return NumericUpDown2.Increment
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown2.Increment = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Secondary_Value As Integer
        Get
            Return NumericUpDown2.Value
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown2.Value = Value
        End Set
    End Property


#Region "Events"

    Public Event CheckedChanged As EventHandler
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Checked = sender.Checked
        RaiseEvent CheckedChanged(sender, e)
    End Sub

    Public Event ValueChanged As EventHandler
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        RaiseEvent ValueChanged(sender, e)
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs)
        RaiseEvent ValueChanged(sender, e)
    End Sub

#End Region

End Class
