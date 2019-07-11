Public Class ResetForm

    Public Shared Sub Warframe()
        Dim MaxToggle As MaxValueToggle = Form_main.TabPage_warframe.Controls.Find("MaxValueToggle_warframes", True).FirstOrDefault()
        MaxToggle.Checked = Not MaxToggle.Checked
        ResetComponent(Form_main.TabPage_warframe)
        MaxToggle.Checked = Not MaxToggle.Checked
    End Sub

    Public Shared Sub Companion()
        Dim MaxToggle As MaxValueToggle = Form_main.TabPage_warframe.Controls.Find("MaxValueToggle_companions", True).FirstOrDefault()
        MaxToggle.Checked = Not MaxToggle.Checked
        ResetComponent(Form_main.TabPage_companion)
        MaxToggle.Checked = Not MaxToggle.Checked
    End Sub

    Public Shared Sub Archwing()
        Dim MaxToggle As MaxValueToggle = Form_main.TabPage_warframe.Controls.Find("MaxValueToggle_archwings", True).FirstOrDefault()
        MaxToggle.Checked = Not MaxToggle.Checked
        ResetComponent(Form_main.TabPage_archwing)
        MaxToggle.Checked = Not MaxToggle.Checked
    End Sub

    Private Shared Sub ResetComponent(ByVal container As Control)
        For Each control As Control In container.Controls
            If TypeOf control IsNot Label AndAlso TypeOf control IsNot MaxValueToggle AndAlso
                ((TypeOf control Is CheckBox AndAlso CType(control, CheckBox).Checked) Or
                 (TypeOf control Is RadioButton AndAlso CType(control, RadioButton).Checked) Or
                 (TypeOf control Is RadioInput AndAlso CType(control, RadioInput).Checked) Or
                 (TypeOf control Is CheckedInput AndAlso CType(control, CheckedInput).Checked) Or
                 (TypeOf control Is CheckedDualInput AndAlso CType(control, CheckedDualInput).Checked) Or
                 (TypeOf control Is CheckedGroupBox AndAlso CType(control, CheckedGroupBox).Checked) Or
                 (TypeOf control Is FlowLayoutPanel AndAlso CType(control, FlowLayoutPanel).Visible) Or
                 TypeOf control Is TableLayoutPanel Or
                 TypeOf control Is ComboBox Or
                 TypeOf control Is VariantSelection) Then
                Select Case control.GetType.ToString.Split("."c).Last()
                    Case "ComboBox"
                        CType(control, ComboBox).SelectedIndex = 0
                    Case "CheckBox"
                        CType(control, CheckBox).Checked = False
                    Case "RadioButton"
                        CType(control, RadioButton).Checked = False
                    Case "RadioInput"
                        CType(control, RadioInput).Checked = False
                        CType(control, RadioInput).Value = CType(control, RadioInput).Minimum
                    Case "CheckedInput"
                        CType(control, CheckedInput).Checked = False
                        CType(control, CheckedInput).Value.ToString()
                    Case "CheckedDualInput"
                        CType(control, CheckedDualInput).Checked = False
                        CType(control, CheckedDualInput).Value = CType(control, CheckedDualInput).Minimum
                        CType(control, CheckedDualInput).Secondary_Value = CType(control, CheckedDualInput).Secondary_Minimum
                    Case "CheckedGroupBox"
                        CType(control, CheckedGroupBox).Checked = False
                    Case "VariantSelection"
                        CType(control, VariantSelection).SelectedVariant = "base"
                    Case "CompanionVariantSelection"
                        CType(control, CompanionVariantSelection).SelectedVariant = "base"
                    Case "NumericInput"
                        CType(control, NumericInput).Value = CType(control, NumericInput).Minimum
                End Select
                If container.HasChildren Then
                    If TypeOf control Is CheckedGroupBox Then
                        ResetComponent(CType(control, CheckedGroupBox).FlowLayout)
                    ElseIf TypeOf control IsNot CheckedInput AndAlso
                            TypeOf control IsNot CheckedDualInput AndAlso
                            TypeOf control IsNot RadioInput AndAlso
                            TypeOf control IsNot VariantSelection AndAlso
                            TypeOf control IsNot CompanionVariantSelection AndAlso
                            TypeOf control IsNot NumericInput Then
                        ResetComponent(control)
                    End If
                End If
            End If
        Next
    End Sub

End Class
