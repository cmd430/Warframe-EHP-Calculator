Public Class Form_squadMember

    Public squadName As String = ""
    Public squadFrame As String = ""
    Public squadAura As String = ""
    Public squadAbilities As String = ""
    Public squadStrength As Decimal = 0.0

    Public Sub New(squad)
        InitializeComponent()
        '
        '   squad contains info about the member in the following
        '   extreamly fucking obnoxious format
        '
        '       Name:Frame:arua:abilities:Str
        '
        '   Where the Properties are as follows
        '
        '   Name 
        '       Type  - String
        '       Desc  - The Squad Member
        '
        '   Frame
        '       Type  - String
        '       Desc  - The Selected Warframe
        '
        '   Aura
        '       Type  - String
        '       Desc  - the aura the squad member has equiped
        '
        '   Abilities
        '       Type  - String
        '       Extra - if more than 1 seperated by ~
        '       Extra - Augmented Ability comes after abilites (has seperator) (only Equinox atm)
        '       Desc  - Selected Abilities
        '
        '   Str
        '       Type  - Decimal
        '       Desc  - Power Strength of the warframe
        '
        TextBox_squadInfo.Text = squad
        updateSlug(True)
    End Sub

    Private Sub Button_squadApply_Click(sender As Object, e As EventArgs) Handles Button_squadApply.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button_squadCancel_Click(sender As Object, e As EventArgs) Handles Button_squadCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form_squadMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        '   Remove Tab Headers for Abilities
        '
        CustomTabControl_squadAbilitys.Appearance = TabAppearance.FlatButtons
        CustomTabControl_squadAbilitys.ItemSize = New Size(0, 1)
        CustomTabControl_squadAbilitys.SizeMode = TabSizeMode.Fixed
        '
        '   Setup Form
        '
        AddHandler ComboBox_squadWarframe.SelectedIndexChanged, AddressOf squadChanged
        AddHandler ComboBox_squadAura.SelectedIndexChanged, AddressOf squadChanged
        AddHandler NumericUpDown_squadPowerStrength.ValueChanged, AddressOf squadChanged

        Dim CheckBoxs As New List(Of Control)
        For Each CheckBox As CheckBox In Form_main.FindControlRecursive(CheckBoxs, CustomTabControl_squadAbilitys, GetType(CheckBox))
            AddHandler CheckBox.CheckedChanged, AddressOf squadChanged
        Next
        Dim NumericUpDowns As New List(Of Control)
        For Each NumericUpDown As NumericUpDown In Form_main.FindControlRecursive(NumericUpDowns, CustomTabControl_squadAbilitys, GetType(NumericUpDown))
            AddHandler NumericUpDown.ValueChanged, AddressOf squadChanged
        Next
    End Sub

    Private Function getAbilities()
        Dim abilities As String = "None"
        For Each item As Control In CustomTabControl_squadAbilitys.SelectedTab.Controls()
            If TypeOf item Is CheckBox Then
                If CType(item, CheckBox).Checked Then
                    If CustomTabControl_squadAbilitys.SelectedTab.Controls(item.Name.Replace("CheckBox", "NumericUpDown")) IsNot Nothing Then
                        abilities = abilities & "~" & item.Text & "(" & CType(CustomTabControl_squadAbilitys.SelectedTab.Controls(item.Name.Replace("CheckBox", "NumericUpDown")), NumericUpDown).Value & ")"
                    Else
                        If Not (CustomTabControl_squadAbilitys.SelectedTab.Text = "Equinox" And item.Name = "CheckBox_squadPeacefulProvocation" And CheckBox_squadPasifyAndProvoke.Checked = False) Then
                            abilities = abilities & "~" & item.Text
                        End If
                    End If
                End If
            End If
        Next
        If abilities.StartsWith("None~") Then
            abilities = abilities.Remove(0, 5)
        End If
        Return abilities.Replace("&&", "&")
    End Function

    Private Sub setAbilities()
        For Each ability As String In squadAbilities.Replace("&", "&&").Split("~")
            If Not ability = "None" Then
                For Each CheckBox As CheckBox In CustomTabControl_squadAbilitys.SelectedTab.Controls.OfType(Of CheckBox)
                    If ability.Contains("(") Then
                        If CheckBox.Text = ability.Split("(")(0) Then
                            CheckBox.Checked = True
                            CType(CustomTabControl_squadAbilitys.SelectedTab.Controls(CheckBox.Name.Replace("CheckBox", "NumericUpDown")), NumericUpDown).Value = ability.Split("(")(1).Replace(")", "")
                        End If
                    Else
                        If CheckBox.Text = ability Then
                            CheckBox.Checked = True
                        End If
                    End If
                Next
            End If
        Next
        '
        '   Equinox is Special
        '
        If CustomTabControl_squadAbilitys.SelectedTab.Text = "Equinox" Then
            CheckBox_squadPeacefulProvocation.Enabled = CheckBox_squadPasifyAndProvoke.Checked
        End If
    End Sub

    Private Sub updateSlug(Optional ByVal isFirst As Boolean = False)
        Dim slug = TextBox_squadInfo.Text.Split(":")
        If isFirst Then
            squadName = slug(0)
            squadFrame = slug(1)
            squadAura = slug(2)
            squadAbilities = slug(3)
            squadStrength = Convert.ToDecimal(slug(4), New Globalization.CultureInfo("en-US"))
            Me.Text = Me.Text & squadName
            ComboBox_squadWarframe.SelectedItem = squadFrame
            ComboBox_squadAura.SelectedItem = squadAura
            NumericUpDown_squadPowerStrength.Value = squadStrength
            CustomTabControl_squadAbilitys.SelectedTab = CustomTabControl_squadAbilitys.Controls("TabPage_squad" & squadFrame)
            setAbilities()
        Else
            slug(1) = ComboBox_squadWarframe.SelectedItem
            slug(2) = ComboBox_squadAura.SelectedItem
            slug(3) = getAbilities()
            slug(4) = Convert.ToDecimal(NumericUpDown_squadPowerStrength.Value, New Globalization.CultureInfo("en-US"))
            squadFrame = slug(1)
            squadAura = slug(2)
            squadAbilities = slug(3)
            squadStrength = slug(4)
            TextBox_squadInfo.Text = String.Join(":", slug)
        End If
    End Sub

    Private Sub squadChanged(sender As Object, e As EventArgs)
        '
        '   Equinox is Special
        '
        If CustomTabControl_squadAbilitys.SelectedTab.Text = "Equinox" Then
            CheckBox_squadPeacefulProvocation.Enabled = CheckBox_squadPasifyAndProvoke.Checked
        End If
        updateSlug()
        If sender.Name.ToString.Contains("Warframe") Then
            CustomTabControl_squadAbilitys.SelectedTab = CustomTabControl_squadAbilitys.Controls("TabPage_squad" & squadFrame)
        End If
    End Sub

End Class