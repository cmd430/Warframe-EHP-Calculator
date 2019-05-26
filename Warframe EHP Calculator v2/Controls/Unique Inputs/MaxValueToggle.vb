Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MaxValueToggle
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
            Return CheckBox1.Text
        End Get
        Set(ByVal Value As String)
            CheckBox1.Text = Value
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

#Region "Events"

    Public Event CheckedChanged As EventHandler
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim parentControl As Control = Parent
        If parentControl Is Nothing Then Return
        If Checked Then
            For Each _control As Control In Parent.GetAll(GetType(RadioInput)).ToList
                Dim control = DirectCast(_control, RadioInput)
                control.Value = control.Maximum
            Next
            For Each _control As Control In Parent.GetAll(GetType(CheckedInput)).ToList
                Dim control = DirectCast(_control, CheckedInput)
                control.Value = control.Maximum
            Next
            For Each _control As Control In Parent.GetAll(GetType(CheckedDualInput)).ToList
                Dim control = DirectCast(_control, CheckedDualInput)
                control.Value = control.Maximum
                control.Secondary_Value = control.Secondary_Maximum
            Next
        Else
            For Each _control As Control In Parent.GetAll(GetType(RadioInput)).ToList
                Dim control = DirectCast(_control, RadioInput)
                control.Value = control.Minimum
            Next
            For Each _control As Control In Parent.GetAll(GetType(CheckedInput)).ToList
                Dim control = DirectCast(_control, CheckedInput)
                control.Value = control.Minimum
            Next
            For Each _control As Control In Parent.GetAll(GetType(CheckedDualInput)).ToList
                Dim control = DirectCast(_control, CheckedDualInput)
                control.Value = control.Minimum
                control.Secondary_Value = control.Secondary_Minimum
            Next
        End If
        RaiseEvent CheckedChanged(sender, e)
    End Sub

#End Region

End Class

Public Module Extentions

    <DebuggerStepThrough()>
    <Extension()>
    Public Function GetAll(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAll(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

End Module
