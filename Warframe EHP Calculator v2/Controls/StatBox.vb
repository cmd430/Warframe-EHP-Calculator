Imports System.ComponentModel

Public Class StatBox
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
            Return StatLabel.Text.TrimEnd(":")
        End Get
        Set(ByVal Value As String)
            StatLabel.Text = Value & ":"
        End Set
    End Property

    <TypeConverter(GetType(EnumConverter))>
    Public Enum RoundingValues
        None
        Floor
        Ceiling
    End Enum
    <Category("!Properties")>
    <DefaultValue(RoundingValues.None)>
    Public Property Rounding As New RoundingValues

    <Category("!Properties")>
    <DefaultValue(0)>
    <Browsable(True)>
    Public Property Value As String
        Get
            If StatValue.Text = "-" Then
                Return 0
            Else
                Return StatValue.Text
            End If
        End Get
        Set(ByVal Value As String)
            If Value = "0" Or Value = "" Then
                StatValue.Text = "-"
            Else
                If Rounding = RoundingValues.None Then
                    StatValue.Text = Value
                ElseIf Rounding = RoundingValues.Floor Then
                    StatValue.Text = Math.Floor(CType(Value, Decimal))
                ElseIf Rounding = RoundingValues.Ceiling Then
                    StatValue.Text = Math.Ceiling(CType(Value, Decimal))
                End If
            End If
        End Set
    End Property

End Class
