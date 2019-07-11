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
            If TypeOf childCtrl IsNot Label AndAlso TypeOf childCtrl IsNot MaxValueToggle Then
                If (TypeOf childCtrl Is CheckBox AndAlso CType(childCtrl, CheckBox).Checked) Or
                     (TypeOf childCtrl Is RadioButton AndAlso CType(childCtrl, RadioButton).Checked) Or
                     (TypeOf childCtrl Is RadioInput AndAlso CType(childCtrl, RadioInput).Checked) Or
                     (TypeOf childCtrl Is CheckedInput AndAlso CType(childCtrl, CheckedInput).Checked) Or
                     (TypeOf childCtrl Is CheckedDualInput AndAlso CType(childCtrl, CheckedDualInput).Checked) Or
                     (TypeOf childCtrl Is CheckedGroupBox AndAlso CType(childCtrl, CheckedGroupBox).Checked) Or
                     (TypeOf childCtrl Is FlowLayoutPanel AndAlso Not CType(childCtrl, FlowLayoutPanel).Visible = False) Or
                     TypeOf childCtrl Is TableLayoutPanel Or
                     TypeOf childCtrl Is ComboBox Or
                     TypeOf childCtrl Is VariantSelection Then
                    ' serialize the control
                    If TypeOf childCtrl IsNot TableLayoutPanel AndAlso TypeOf childCtrl IsNot FlowLayoutPanel Then
                        xmlSerializedBuild.WriteStartElement("Control")
                        xmlSerializedBuild.WriteAttributeString("Type", childCtrl.GetType.ToString)
                        xmlSerializedBuild.WriteAttributeString("Name", childCtrl.Name)
                        If (TypeOf childCtrl Is ComboBox) Then
                            xmlSerializedBuild.WriteElementString("SelectedIndex", CType(childCtrl, ComboBox).SelectedIndex.ToString)
                        ElseIf (TypeOf childCtrl Is CheckBox) Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckBox).Checked.ToString)
                        ElseIf (TypeOf childCtrl Is RadioButton) Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, RadioButton).Checked.ToString)
                        ElseIf TypeOf childCtrl Is RadioInput Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, RadioInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, RadioInput).Value.ToString)
                        ElseIf TypeOf childCtrl Is CheckedInput Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, CheckedInput).Value.ToString)
                        ElseIf TypeOf childCtrl Is CheckedDualInput Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedDualInput).Checked.ToString)
                            xmlSerializedBuild.WriteElementString("Value", CType(childCtrl, CheckedDualInput).Value.ToString)
                            xmlSerializedBuild.WriteElementString("Secondary_Value", CType(childCtrl, CheckedDualInput).Secondary_Value.ToString)
                        ElseIf TypeOf childCtrl Is CheckedGroupBox Then
                            xmlSerializedBuild.WriteElementString("Checked", CType(childCtrl, CheckedGroupBox).Checked.ToString)
                        ElseIf TypeOf childCtrl Is VariantSelection Then
                            xmlSerializedBuild.WriteElementString("SelectedVariant", CType(childCtrl, VariantSelection).SelectedVariant.ToString)
                        End If
                    End If
                    ' serialize any children
                    If childCtrl.HasChildren Then
                        If TypeOf childCtrl Is CheckedGroupBox Then
                            AddChildControls(xmlSerializedBuild, CType(childCtrl, CheckedGroupBox).FlowLayout)
                        ElseIf TypeOf childCtrl IsNot CheckedInput AndAlso
                                TypeOf childCtrl IsNot CheckedDualInput AndAlso
                                TypeOf childCtrl IsNot RadioInput AndAlso
                                TypeOf childCtrl IsNot VariantSelection Then
                            AddChildControls(xmlSerializedBuild, childCtrl)
                        End If
                    End If
                    If TypeOf childCtrl IsNot TableLayoutPanel AndAlso TypeOf childCtrl IsNot FlowLayoutPanel Then
                        xmlSerializedBuild.WriteEndElement()
                    End If
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
                Case "System.Windows.Forms.ComboBox"
                    CType(ctrlToSet, ComboBox).SelectedIndex = Convert.ToInt32(n("SelectedIndex").InnerText)
                Case "System.Windows.Forms.CheckBox"
                    CType(ctrlToSet, CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "System.Windows.Forms.RadioButton"
                    CType(ctrlToSet, RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "Warframe_EHP_Calculator_v2.RadioInput"
                    CType(ctrlToSet, RadioInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, RadioInput).Value = Integer.Parse(n("Value").InnerText)
                Case "Warframe_EHP_Calculator_v2.CheckedInput"
                    CType(ctrlToSet, CheckedInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, CheckedInput).Value = Integer.Parse(n("Value").InnerText)
                Case "Warframe_EHP_Calculator_v2.CheckedDualInput"
                    CType(ctrlToSet, CheckedDualInput).Checked = Convert.ToBoolean(n("Checked").InnerText)
                    CType(ctrlToSet, CheckedDualInput).Value = Integer.Parse(n("Value").InnerText)
                    CType(ctrlToSet, CheckedDualInput).Secondary_Value = Integer.Parse(n("Secondary_Value").InnerText)
                Case "Warframe_EHP_Calculator_v2.CheckedGroupBox"
                    CType(ctrlToSet, CheckedGroupBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                Case "Warframe_EHP_Calculator_v2.VariantSelection"
                    CType(ctrlToSet, VariantSelection).SelectedVariant = n("SelectedVariant").InnerText
            End Select
            ' deserialize any children
            If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                Dim xnlControls As XmlNodeList = n.SelectNodes("Control")
                For Each n2 As XmlNode In xnlControls
                    If controlType = "Warframe_EHP_Calculator_v2.CheckedGroupBox" Then
                        SetControlProperties(CType(ctrlToSet, CheckedGroupBox).FlowLayout, n2)
                    Else
                        SetControlProperties(ctrlToSet, n2)
                    End If
                Next
            End If
        End If
    End Sub

End Class