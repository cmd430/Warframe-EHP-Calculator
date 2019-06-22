Imports System.ComponentModel

Public Class CompanionVariantSelection
    Inherits UserControl

    ' made this seperate from the warframe one
    ' so if we get vandel/wraith sentinels we can just add
    ' 2 more check boxes to this control

    Public Sub New()
        InitializeComponent()
        AddHandler CheckBox_Prime.CheckedChanged, AddressOf CheckedChanged
        AddHandler CheckBox_Prisma.CheckedChanged, AddressOf CheckedChanged
    End Sub

    Private __SelectedVariant As String = "base"
    Private __AvailableVariants As String = "base"

    <Browsable(False)>
    Public Property SelectedVariant As String
        Get
            If (__SelectedVariant = "prime" And Not CheckBox_Prime.Enabled) Or (__SelectedVariant = "prisma" And Not CheckBox_Prisma.Enabled) Then
                Return "base"
            Else
                Return __SelectedVariant
            End If
        End Get
        Set(value As String)
            If value = "base" Then
                CheckBox_Prime.Checked = False
                CheckBox_Prisma.Checked = False
            ElseIf value = "prime" Then
                CheckBox_Prime.Checked = True
                CheckBox_Prisma.Checked = False
            ElseIf value = "prisma" Then
                CheckBox_Prime.Checked = False
                CheckBox_Prisma.Checked = True
            End If
            __SelectedVariant = value
        End Set
    End Property

    <Browsable(False)>
    Public Property AvailableVariants As String
        Get
            Return __AvailableVariants
        End Get
        Set(value As String)
            If value = "base" Then
                CheckBox_Prime.Enabled = False
                CheckBox_Prisma.Enabled = False
            ElseIf value = "prime" Then
                CheckBox_Prime.Enabled = True
                CheckBox_Prisma.Enabled = False
            ElseIf value = "prisma" Then
                CheckBox_Prime.Enabled = False
                CheckBox_Prisma.Enabled = True
            ElseIf value = "prime_prisma" Then
                CheckBox_Prime.Enabled = True
                CheckBox_Prisma.Enabled = True
            End If
            __AvailableVariants = value
        End Set
    End Property

#Region "Events"
    Public Event SelectedVariantChanged(sender As Object, e As EventArgs)
    Private Shadows Sub CheckedChanged(sender As Object, e As EventArgs)
        RemoveHandler CheckBox_Prime.CheckedChanged, AddressOf CheckedChanged
        RemoveHandler CheckBox_Prisma.CheckedChanged, AddressOf CheckedChanged
        If (__SelectedVariant = "prime" And sender.Name.contains("Prime")) Or (__SelectedVariant = "prisma" And sender.Name.contains("Prisma")) Then
            SelectedVariant = "base"
        Else
            SelectedVariant = sender.Text.ToString().ToLower()
        End If
        RaiseEvent SelectedVariantChanged(Me, New EventArgs())
        AddHandler CheckBox_Prime.CheckedChanged, AddressOf CheckedChanged
        AddHandler CheckBox_Prisma.CheckedChanged, AddressOf CheckedChanged
    End Sub
#End Region

End Class
