Imports System.ComponentModel

Public Class NumericInput
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
            Return Label1.Text.TrimEnd(":")
        End Get
        Set(ByVal Value As String)
            Label1.Text = Value & ":"
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

#Region "Events"


    Public Event ValueChanged As EventHandler
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        RaiseEvent ValueChanged(sender, e)
    End Sub

#End Region

End Class
