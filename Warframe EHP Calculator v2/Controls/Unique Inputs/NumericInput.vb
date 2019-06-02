Imports System.ComponentModel

Public Class NumericInput
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        Text = Name
        UIHack()
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
    Public Property Maximum As Decimal
        Get
            Return NumericUpDown1.Maximum
        End Get
        Set(ByVal Value As Decimal)
            NumericUpDown1.Maximum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Minimum As Decimal
        Get
            Return NumericUpDown1.Minimum
        End Get
        Set(ByVal Value As Decimal)
            NumericUpDown1.Minimum = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(1)>
    <Browsable(True)>
    Public Property Increment As Decimal
        Get
            Return NumericUpDown1.Increment
        End Get
        Set(ByVal Value As Decimal)
            NumericUpDown1.Increment = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property DecimalPlaces As Integer
        Get
            Return NumericUpDown1.DecimalPlaces
        End Get
        Set(ByVal Value As Integer)
            NumericUpDown1.DecimalPlaces = Value
        End Set
    End Property

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Value As Decimal
        Get
            Return NumericUpDown1.Value
        End Get
        Set(ByVal Value As Decimal)
            NumericUpDown1.Value = Value
        End Set
    End Property

#Region "Events"

    Public Event ValueChanged As EventHandler
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        UIHack()
        RaiseEvent ValueChanged(sender, e)
    End Sub

#End Region

    Private Sub UIHack()
        ' Small hack might need to rethink but it seems to work fine
        If Math.Floor(NumericUpDown1.Value) < NumericUpDown1.Value Then
            NumericUpDown1.DecimalPlaces = 1
        Else
            NumericUpDown1.DecimalPlaces = 0
        End If
    End Sub

End Class
