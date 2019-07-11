Imports System.IO
Imports System.Xml
Imports System.Text

'
' Code Based on
' https://www.codeproject.com/Articles/86503/Saving-the-state-serializing-a-Windows-Form
'

Public Class BuildSerializor

    Public Shared Sub Serialize(ByVal c As Control, ByVal XmlFileName As String, ByVal Root As String)
        Dim xmlSerializedBuild As XmlTextWriter = New XmlTextWriter(XmlFileName, Encoding.UTF8) With {
            .Formatting = Formatting.Indented,
            .IndentChar = Space(1)
        }
        xmlSerializedBuild.WriteStartDocument()
        xmlSerializedBuild.WriteStartElement(Root)
        AddChildControls(xmlSerializedBuild, c)
        xmlSerializedBuild.WriteEndElement()
        xmlSerializedBuild.WriteEndDocument()
        xmlSerializedBuild.Flush()
        xmlSerializedBuild.Close()
    End Sub

    Private Shared Sub AddChildControls(ByVal xmlSerializedBuild As XmlTextWriter, ByVal c As Control)
        For Each childCtrl As Control In c.Controls
            If TypeOf childCtrl IsNot Label AndAlso TypeOf childCtrl IsNot MaxValueToggle AndAlso
                ((TypeOf childCtrl Is CheckBox AndAlso CType(childCtrl, CheckBox).Checked) Or
                 (TypeOf childCtrl Is RadioButton AndAlso CType(childCtrl, RadioButton).Checked) Or
                 (TypeOf childCtrl Is RadioInput AndAlso CType(childCtrl, RadioInput).Checked) Or
                 (TypeOf childCtrl Is CheckedInput AndAlso CType(childCtrl, CheckedInput).Checked) Or
                 (TypeOf childCtrl Is CheckedDualInput AndAlso CType(childCtrl, CheckedDualInput).Checked) Or
                 (TypeOf childCtrl Is CheckedGroupBox AndAlso CType(childCtrl, CheckedGroupBox).Checked) Or
                 (TypeOf childCtrl Is FlowLayoutPanel AndAlso CType(childCtrl, FlowLayoutPanel).Visible) Or
                 TypeOf childCtrl Is TableLayoutPanel Or
                 TypeOf childCtrl Is ComboBox Or
                 TypeOf childCtrl Is VariantSelection) Then
                ' serialize the control
                If TypeOf childCtrl IsNot TableLayoutPanel AndAlso TypeOf childCtrl IsNot FlowLayoutPanel Then
                    Dim controlType As String = childCtrl.GetType.ToString.Split("."c).Last()
                    xmlSerializedBuild.WriteStartElement("Control")
                    xmlSerializedBuild.WriteAttributeString("Type", controlType)
                    xmlSerializedBuild.WriteAttributeString("Name", childCtrl.Name)
                    Select Case controlType
                        Case "ComboBox"
                            xmlSerializedBuild.WriteElementString("SelectedItem", CType(childCtrl, ComboBox).SelectedItem.ToString)
                        Case "CheckBox"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckBox).Checked.ToString)
                        Case "RadioButton"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, RadioButton).Checked.ToString)
                        Case "RadioInput"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, RadioInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, RadioInput).Value.ToString)
                        Case "CheckedInput"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, CheckedInput).Value.ToString)
                        Case "CheckedDualInput"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedDualInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, CheckedDualInput).Value.ToString)
                            xmlSerializedBuild.WriteElementString("Secondary_Value", CType(childCtrl, CheckedDualInput).Secondary_Value.ToString)
                        Case "CheckedGroupBox"
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedGroupBox).Checked.ToString)
                        Case "VariantSelection"
                            xmlSerializedBuild.WriteElementString("SelectedVariant", CType(childCtrl, VariantSelection).SelectedVariant.ToString)
                        Case "CompanionVariantSelection"
                            xmlSerializedBuild.WriteElementString("SelectedVariant", CType(childCtrl, CompanionVariantSelection).SelectedVariant.ToString)
                        Case "NumericInput"
                            xmlSerializedBuild.WriteElementString("SelectedVariant", CType(childCtrl, NumericInput).Value.ToString)
                    End Select
                End If
                ' serialize any children
                If childCtrl.HasChildren Then
                    If TypeOf childCtrl Is CheckedGroupBox Then
                        AddChildControls(xmlSerializedBuild, CType(childCtrl, CheckedGroupBox).FlowLayout)
                    ElseIf TypeOf childCtrl IsNot CheckedInput AndAlso
                            TypeOf childCtrl IsNot CheckedDualInput AndAlso
                            TypeOf childCtrl IsNot RadioInput AndAlso
                            TypeOf childCtrl IsNot VariantSelection AndAlso
                            TypeOf childCtrl IsNot CompanionVariantSelection AndAlso
                            TypeOf childCtrl IsNot NumericInput Then
                        AddChildControls(xmlSerializedBuild, childCtrl)
                    End If
                End If
                If TypeOf childCtrl IsNot TableLayoutPanel AndAlso TypeOf childCtrl IsNot FlowLayoutPanel Then
                    xmlSerializedBuild.WriteEndElement()
                End If
            End If
        Next
    End Sub

    Public Shared Sub Deserialize(ByVal c As Control, ByVal XmlFileName As String)
        If File.Exists(XmlFileName) Then
            Dim xmlSerializedBuild As XmlDocument = New XmlDocument
            xmlSerializedBuild.Load(XmlFileName)
            Dim topLevel As XmlNode = xmlSerializedBuild.ChildNodes(1)
            For Each n As XmlNode In topLevel.ChildNodes
                SetControlProperties(c, n)
            Next
        End If
    End Sub

    Private Shared Sub SetControlProperties(ByVal currentCtrl As Control, ByVal n As XmlNode)
        Dim controlName As String = n.Attributes("Name").Value
        Dim controlType As String = n.Attributes("Type").Value
        Dim ctrl() As Control = currentCtrl.Controls.Find(controlName, True)
        If ctrl.Length > 0 Then
            Dim ctrlToSet As Control = ctrl.FirstOrDefault()
            Select Case controlType
                Case "ComboBox"
                    CType(ctrlToSet, ComboBox).SelectedItem = n("SelectedItem").InnerText
                Case "CheckBox"
                    CType(ctrlToSet, CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "RadioButton"
                    CType(ctrlToSet, RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "RadioInput"
                    CType(ctrlToSet, RadioInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, RadioInput).Value = Integer.Parse(n("Value").InnerText)
                Case "CheckedInput"
                    CType(ctrlToSet, CheckedInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, CheckedInput).Value = Integer.Parse(n("Value").InnerText)
                Case "CheckedDualInput"
                    CType(ctrlToSet, CheckedDualInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, CheckedDualInput).Value = Integer.Parse(n("Value").InnerText)
                    CType(ctrlToSet, CheckedDualInput).Secondary_Value = Integer.Parse(n("Secondary_Value").InnerText)
                Case "CheckedGroupBox"
                    CType(ctrlToSet, CheckedGroupBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "VariantSelection"
                    CType(ctrlToSet, VariantSelection).SelectedVariant = n("SelectedVariant").InnerText
                Case "CompanionVariantSelection"
                    CType(ctrlToSet, CompanionVariantSelection).SelectedVariant = n("SelectedVariant").InnerText
                Case "NumericInput"
                    CType(ctrlToSet, NumericInput).Value = Integer.Parse(n("Value").InnerText)
            End Select
            ' deserialize any children
            If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                Dim xnlControls As XmlNodeList = n.SelectNodes("Control")
                For Each n2 As XmlNode In xnlControls
                    If controlType = "CheckedGroupBox" Then
                        SetControlProperties(CType(ctrlToSet, CheckedGroupBox).FlowLayout, n2)
                    Else
                        SetControlProperties(ctrlToSet, n2)
                    End If
                Next
            End If
        End If
    End Sub

End Class