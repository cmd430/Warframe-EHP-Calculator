Imports System.IO
Imports System.Reflection
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Xml.Serialization
Imports System.ComponentModel

Module NativeMethods
    <DllImport("WinInet.dll", PreserveSig:=True, SetLastError:=True)>
    Sub DeleteUrlCacheEntry(ByVal url As String)
    End Sub
End Module

Public Class Form_main

    Public assembly As Assembly
    Public localVersion As String
    Public liveVersion As String
    Public Warframes As List(Of Warframe)
    Public RankMultipliers As List(Of Rank_Multiplier)

    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

    Public Function FormatNumber(ByVal Number)
        Dim formatted As Decimal = 0.0
        If TypeOf Number Is TextBox Then
            If Number.Text = "-" Then
                formatted = Convert.ToDecimal(0, New Globalization.CultureInfo("en-US"))
            Else
                formatted = Convert.ToDecimal(Number.Text, New Globalization.CultureInfo("en-US"))
            End If
        End If
        Return formatted
    End Function

    Public Shared Function GetResponseNoCache(ByVal url As String) As String
        DeleteUrlCacheEntry(url)
        Dim request As WebRequest = WebRequest.Create(New Uri(url))
        request.CachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
        Dim response As WebResponse = request.GetResponse()
        Using reader = New StreamReader(response.GetResponseStream())
            Dim responseText As String = reader.ReadToEnd().Trim()
            Return responseText
        End Using
    End Function

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.DefaultToMax = MaxValueToggle1.Checked
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assembly = Assembly.GetExecutingAssembly()
        '
        ' Version Info
        '
        localVersion = New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.version")).ReadToEnd()
        Me.Text = Me.Text & " (v" & localVersion & ")"
        '
        ' Load Warframe and Rank Data
        '
        Dim serializer As XmlSerializer
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.Warframes.xml"))
            serializer = New XmlSerializer(GetType(List(Of Warframe)), New XmlRootAttribute("warframes"))
            Warframes = DirectCast(serializer.Deserialize(stream), List(Of Warframe)).OrderBy(Function(x) x.Name).ToList()
        End Using
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.WarframeRankMultipliers.xml"))
            serializer = New XmlSerializer(GetType(List(Of Rank_Multiplier)), New XmlRootAttribute("rank_multipliers"))
            RankMultipliers = DirectCast(serializer.Deserialize(stream), List(Of Rank_Multiplier))
        End Using
        For Each warframe As Warframe In Warframes
            ComboBox_warframes.Items.Add(warframe.Name)
        Next
        '
        '   Hide Debug controls
        '
        TabControl_main.TabPages.Remove(TabPage_development)
        '
        '   Hide Tab Headers for Abilities and Arcane Helmets
        '
        Panel_abilitiesTabHider.Size = New Size(181, 109)
        TabControl_abilities.Location = New Point(-4, -22)
        TabControl_abilities.Size = New Size(189, 134)
        Panel_arcaneHelmetsTabHider.Size = New Size(181, 109)
        TabControl_arcaneHelmets.Location = New Point(-4, -22)
        TabControl_arcaneHelmets.Size = New Size(189, 134)

        '
        '   This should let the math not explode for non English OS's
        '   But just incase i also use the function `formatNumber` to be safe
        '
        Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        '
        '   Change Warframe select box to the default section
        '   also change all other combo boxs to index 0
        '   comboboxs that match index are auto updated by the
        '   event handler
        '
        ComboBox_warframes.SelectedIndex = 0
        ComboBox_companions.SelectedIndex = 0
        ComboBox_blocking.SelectedIndex = 0
        '
        '   Abilities and Focus
        '
        AddHandler CheckedGroupBox_abilities.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckedGroupBox_focus.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Mod Sections
        '
        AddHandler CheckedGroupBox_aura.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckedGroupBox_survivability.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckedGroupBox_powerStrength.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckedGroupBox_miscellaneous.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Arcanes and Keys
        '
        AddHandler CheckedGroupBox_arcanes.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckedGroupBox_dragonKeys.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Special Effects
        '
        AddHandler CheckedGroupBox_specialEffects.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Sortie Modifiers
        '
        AddHandler CheckedGroupBox_missionModifiers.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Arcane Helmets
        '
        AddHandler CheckedGroupBox_arcaneHelmets.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Frame Type
        '
        AddHandler VariantSelection1.SelectedVariantChanged, AddressOf Warframe_Value_Changed
        '
        '   UI Update on warframe change - ability and helmet enabling
        '   and recalc EHP on stat change (pretty much everything is linked in here)
        '   Since there are so many things to addHandler for im going to do it at runtime
        '   with loops to make my life easier
        '
        AddHandler ComboBox_warframes.SelectedIndexChanged, AddressOf Warframe_Value_Changed
        AddHandler ComboBox_blocking.SelectedIndexChanged, AddressOf Warframe_Value_Changed
        Dim CheckBoxs As New List(Of Control)
        For Each CheckBox As CheckBox In FindControlRecursive(CheckBoxs, TabControl_main, GetType(CheckBox))
            If Not CheckBox.Name.Contains("companion") Then
                AddHandler CheckBox.CheckedChanged, AddressOf Warframe_Value_Changed
            Else
                AddHandler CheckBox.CheckedChanged, AddressOf Companion_Value_Changed
            End If
        Next
        Dim RadioButtons As New List(Of Control)
        For Each RadioButton As RadioButton In FindControlRecursive(RadioButtons, TabControl_main, GetType(RadioButton))
            AddHandler RadioButton.CheckedChanged, AddressOf Warframe_Value_Changed
        Next
        Dim NumericUpDowns As New List(Of Control)
        For Each NumericUpDown As NumericUpDown In FindControlRecursive(NumericUpDowns, TabControl_main, GetType(NumericUpDown))
            If Not NumericUpDown.Name.Contains("companion") Then
                AddHandler NumericUpDown.ValueChanged, AddressOf Warframe_Value_Changed
            Else
                AddHandler NumericUpDown.ValueChanged, AddressOf Companion_Value_Changed
            End If
        Next
        '
        '   Companions
        '
        AddHandler ComboBox_companions.SelectedIndexChanged, AddressOf Companion_Value_Changed
        AddHandler CheckBox_companionSurvivability.CheckedChanged, AddressOf Enable_Disable_Section
        '
        ' Set Deafult Values to Max
        '
        MaxValueToggle1.Checked = My.Settings.DefaultToMax
        '
        ' Check for Update
        '
        Try
            liveVersion = GetResponseNoCache("https://raw.githubusercontent.com/cmd430/Warframe-EHP-Calculator/master/Warframe%20EHP%20Calculator%20v2/version")
            If Not liveVersion = localVersion Then
                Form_update.ShowDialog()
            End If
        Catch ex As Exception
            'Cant check for updates
        End Try
        Me.Size = New Size(FlowLayoutPanel1.Size.Width + 32, FlowLayoutPanel1.Size.Height + TableLayoutPanel1.Size.Height + 82)
    End Sub

    Public Sub Enable_Disable_Section(sender As Object, e As EventArgs)
        '
        '   Enable and disable GroupBoxes/TabControls based on its checkbox
        '
        Try
            sender.Parent.Controls(sender.tag).Enabled = sender.Checked
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Warframe_Value_Changed(sender As Object, e As EventArgs)
        '
        '   Default Stats
        '
        Dim baseArmor As Decimal = 0.0
        Dim Armor As Decimal = 0.0
        Dim baseHealth As Decimal = 0.0
        Dim Health As Decimal = 0.0
        Dim baseShield As Decimal = 0.0
        Dim Shield As Decimal = 0.0
        Dim baseEnergy As Decimal = 0.0
        Dim Energy As Decimal = 0.0
        Dim basePowerStrength As Decimal = 0.0
        Dim powerStrength As Decimal = 0.0
        '
        '   Default Multipliers (From Mods)
        '   and bonus added armor
        '
        Dim armorMultiplier As Decimal = 0.0
        Dim healthMultiplier As Decimal = 0.0
        Dim shieldMultiplier As Decimal = 0.0
        Dim energyMultiplier As Decimal = 0.0
        Dim armorBonus As Decimal = 0.0
        Dim healthBonus As Decimal = 0.0
        Dim shieldBonus As Decimal = 0.0 'unused
        Dim energyBonus As Decimal = 0.0 'unused
        Dim damageReduction As Decimal = 0.0
        '
        '   Sepical Hidden stat for abilities that
        '   100% absorb x amount dmg
        '
        Dim damageAbsorbstion As Decimal = 0.0
        If ComboBox_warframes.SelectedIndex > 0 Then
            Dim currentWarframe As Warframe = Warframes.Find(Function(wf) wf.Name = ComboBox_warframes.SelectedItem)
            Dim hasPrime As Boolean = Not currentWarframe.Variants.Find(Function(var) var.Name = "prime") Is Nothing
            Dim hasUmbra As Boolean = Not currentWarframe.Variants.Find(Function(var) var.Name = "umbra") Is Nothing
            '
            '   Does the frame have a Prime or Umbra version ?
            '   if so we can enable to checkbox
            '
            If hasPrime And hasUmbra Then
                VariantSelection1.AvailableVariants = "prime_umbra"
            ElseIf hasPrime Then
                VariantSelection1.AvailableVariants = "prime"
            ElseIf hasUmbra Then
                VariantSelection1.AvailableVariants = "umbra"
            Else
                VariantSelection1.AvailableVariants = "base"
            End If
            '
            '   Special Modifiers
            '
            '   some frames have passives that change fixed things
            '
            If currentWarframe.Name = "Khora" And Not ComboBox_companions.Items.Contains("Venari") Then
                ComboBox_companions.Items.Add("Venari")
            ElseIf Not currentWarframe.Name = "Khora" And ComboBox_companions.Items.Contains("Venari") Then
                If ComboBox_companions.SelectedItem = "Venari" Then
                    ComboBox_companions.SelectedIndex = 0
                End If
                ComboBox_companions.Items.RemoveAt(ComboBox_companions.Items.Count - 1)
            End If
            If currentWarframe.Name = "Harrow" Then
                CheckedInput_overshields.Maximum = 2400
                If MaxValueToggle1.Checked Then
                    CheckedInput_overshields.Value = CheckedInput_overshields.Maximum
                End If
            Else
                CheckedInput_overshields.Maximum = 1200
                If MaxValueToggle1.Checked Then
                    CheckedInput_overshields.Value = CheckedInput_overshields.Maximum
                End If
            End If
            '
            '  Enable/Disable Arcane Helmets selection
            '
            Select Case currentWarframe.Name
                Case "Ash"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsAsh
                Case "Banshee"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsBanshee
                Case "Ember"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsEmber
                Case "Excalibur"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsExcalibur
                Case "Frost"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsFrost
                Case "Loki"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsLoki
                Case "Mag"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsMag
                Case "Nova"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsNova
                Case "Nyx"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsNyx
                Case "Rhino"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsRhino
                Case "Saryn"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsSaryn
                Case "Trinity"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsTrinity
                Case "Vauban"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsVauban
                Case "Volt"
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsVolt
                Case Else
                    TabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsDefault
            End Select
            '
            '   Enable/Disable Abilities Selection
            '
            Select Case currentWarframe.Name
                Case "Atlas"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesAtlas
                Case "Baruuk"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesBaruuk
                Case "Chroma"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesChroma
                Case "Excalibur"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesExcalibur
                Case "Frost"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesFrost
                Case "Gara"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesGara
                Case "Harrow"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesHarrow
                Case "Inaros"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesInaros
                Case "Mesa"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesMesa
                Case "Mirage"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesMirage
                Case "Nekros"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesNekros
                Case "Nezha"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesNezha
                Case "Nidus"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesNidus
                Case "Nova"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesNova
                Case "Oberon"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesOberon
                Case "Octavia"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesOctavia
                Case "Rhino"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesRhino
                Case "Titania"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesTrinity
                Case "Trinity"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesTrinity
                Case "Valkyr"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesValkyr
                Case "Wisp"
                    TabControl_abilities.SelectedTab = TabPage_abilitiesWisp
                Case Else
                    TabControl_abilities.SelectedTab = TabPage_abilitiesDefault
            End Select
            '
            ' Stats
            '
            Dim currentVariant As [Variant] = currentWarframe.Variants.Find(Function(var) var.Name = VariantSelection1.SelectedVariant)
            baseArmor = currentVariant.Armor
            baseHealth = currentVariant.Health
            baseShield = currentVariant.Shield
            baseEnergy = currentVariant.Energy
            basePowerStrength = currentVariant.strength / 100
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "armor") Is Nothing Then
                Armor = baseArmor * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "armor").Multiplier
            Else
                Armor = baseArmor * RankMultipliers.Find(Function(m) m.Name = "armor").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "health") Is Nothing Then
                Health = baseHealth * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "health").Multiplier
            Else
                Health = baseHealth * RankMultipliers.Find(Function(m) m.Name = "health").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "shield") Is Nothing Then
                Shield = baseShield * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "shield").Multiplier
            Else
                Shield = baseShield * RankMultipliers.Find(Function(m) m.Name = "shield").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "energy") Is Nothing Then
                Energy = baseEnergy * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "energy").Multiplier
            Else
                Energy = baseEnergy * RankMultipliers.Find(Function(m) m.Name = "energy").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "strength") Is Nothing Then
                powerStrength = basePowerStrength * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "strength").Multiplier
            Else
                powerStrength = basePowerStrength * RankMultipliers.Find(Function(m) m.Name = "strength").Multiplier
            End If
            '
            ' Overshields
            '
            If CheckedGroupBox_specialEffects.Checked And CheckedInput_overshields.Checked Then
                shieldBonus += CheckedInput_overshields.Value
            End If
            '
            '   Arcane Helmets
            '
            If CheckedGroupBox_arcaneHelmets.Checked Then
                Select Case currentWarframe.Name
                    Case "Ash"
                        If RadioButton_locustHelmet.Checked Then
                            Energy += baseEnergy * 0.2
                        End If
                    Case "Banshee"
                        If RadioButton_reverbHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Energy += baseEnergy * 0.1
                        End If
                    Case "Ember"
                        If RadioButton_phoenixHelmet.Checked Then
                            Shield += baseShield * 0.05
                            Energy += baseEnergy * 0.25
                        ElseIf RadioButton_backdraftHelmet.Checked Then
                            Health += baseHealth * 0.15
                        End If
                    Case "Excalibur"
                        If RadioButton_avalonHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Shield += baseShield * 0.25
                        ElseIf RadioButton_pendragonHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                            powerStrength += powerStrength * 0.15
                        End If
                    Case "Frost"
                        If RadioButton_auroraHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Armor += baseArmor * 0.25
                        ElseIf RadioButton_squallHelmet.Checked Then
                            Shield -= baseShield * 0.05
                            powerStrength += powerStrength * 0.15
                        End If
                    Case "Loki"
                        If RadioButton_essenceHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                        ElseIf RadioButton_swindleHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Mag"
                        If RadioButton_coilHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_gaussHelmet.Checked Then
                            Energy += baseEnergy * 0.25
                        End If
                    Case "Nova"
                        If RadioButton_fluxHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Nyx"
                        If RadioButton_menticideHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_vespaHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                        End If
                    Case "Rhino"
                        If RadioButton_thrak.Checked Then
                            Health += baseHealth * 0.25
                        ElseIf RadioButton_vanguardHelmet.Checked Then
                            powerStrength -= powerStrength * 0.05
                        End If
                    Case "Saryn"
                        If RadioButton_hemlockHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Trinity"
                        If RadioButton_auraHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        ElseIf RadioButton_meridianHelmet.Checked Then
                            Shield += baseShield * 0.15
                        End If
                    Case "Vauban"
                        If RadioButton_espritHelmet.Checked Then
                            Shield -= baseShield * 0.1
                            Energy += baseEnergy * 0.1
                        End If
                    Case "Volt"
                        If RadioButton_pulseHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_stormHelmet.Checked Then
                            powerStrength += powerStrength * 0.1
                        End If
                End Select
            End If
            '
            '   Mission Modifiers
            '
            If CheckedGroupBox_missionModifiers.Checked Then
                If RadioButton_missionCryogenicLeakage.Checked Then
                    Shield -= baseShield * 0.5
                ElseIf RadioButton_missionFire.Checked Then
                    Health -= baseHealth * 0.5
                End If
            End If
            '
            '   Aura Mods
            '
            If CheckedGroupBox_aura.Checked Then
                If RadioInput_physique.Checked Then
                    Dim physique As Decimal = 0.15 + (RadioInput_physique.Value * 0.15)
                    If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                        '
                        '   Coaction Drift is Strange, it gives you a 0.15 boost to all Auras
                        '   and another 0.15 boost to your Aura ontop of the other for a total
                        '   of 0.15 * (1 + 0.15) + 0.15 = 0.3225 (values are for max rank mod)
                        '
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                        healthMultiplier += physique + (physique * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        healthMultiplier += physique
                    End If
                ElseIf RadioInput_standUnited.Checked Then
                    Dim standUnited As Decimal = 0.0425 + (RadioInput_standUnited.Value * 0.0425)
                    If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                        armorMultiplier += standUnited + (standUnited * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        armorMultiplier += standUnited
                    End If
                ElseIf RadioInput_growingPower.Checked Then
                    Dim growingPower As Decimal = basePowerStrength * (0.04166666667 + (RadioInput_growingPower.Value * 0.04166666667))
                    'If CheckBox_coactionDrift.Checked And CheckBox_miscellaneous.Checked Then
                    'Dim coactionDrit As Decimal = 0.025 + (0.025 * NumericUpDown_coactionDrift.Value)
                    'powerStrength = powerStrength + (growingPower + (growingPower * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                    'Else
                    powerStrength += growingPower
                    ' End If
                ElseIf RadioInput_powerDonation.Checked Then
                    'Note: Power Donation does not seem to be affected by co-action drift at this time.
                    Dim powerDonation As Decimal = basePowerStrength * (0.05 + (RadioInput_powerDonation.Value * 0.05))
                    powerStrength -= powerDonation
                End If
            End If
            '
            '   RadioButton Function for Umbral Mods
            '
            If sender.Name = "CheckBox_umbraFiber" Then
                If sender.Checked Then
                    CheckedInput_steelFiber.Checked = False
                End If
            End If
            If sender.Name = "CheckBox_umbraVitality" Then
                If sender.Checked Then
                    CheckedInput_vitality.Checked = False
                End If
            End If
            If sender.Name = "CheckBox_umbraIntensify" Then
                If sender.Checked Then
                    CheckedInput_intensify.Checked = False
                End If
            End If
            If sender.Name = "CheckBox_steelFiber" Then
                If sender.Checked Then
                    CheckedInput_umbralFiber.Checked = False
                End If
            End If
            If sender.Name = "CheckBox_vitality" Then
                If sender.Checked Then
                    CheckedInput_umbralVitality.Checked = False
                End If
            End If
            If sender.Name = "CheckBox_intensify" Then
                If sender.Checked Then
                    CheckedInput_umbralIntensify.Checked = False
                End If
            End If
            '
            '   Armor / Health / Shield Mods
            '
            If CheckedGroupBox_survivability.Checked Then
                'Armor
                If CheckedInput_steelFiber.Checked Then
                    armorMultiplier += 0.1 + (CheckedInput_steelFiber.Value * 0.1)
                End If
                If CheckedInput_armoredAgility.Checked Then
                    armorMultiplier += 0.075 + (CheckedInput_armoredAgility.Value * 0.075)
                End If
                If CheckedDualInput_healthConversion.Checked Then
                    armorBonus = armorBonus + ((75 + (CheckedDualInput_healthConversion.Value * 75)) * CheckedDualInput_healthConversion.Secondary_Value)
                End If
                If CheckedInput_gladiatorAegis.Checked Then
                    armorMultiplier += 0.075 + (CheckedInput_gladiatorAegis.Value * 0.075)
                End If
                'health
                If CheckedInput_vitality.Checked Then
                    healthMultiplier += 0.4 + (CheckedInput_vitality.Value * 0.4)
                End If
                If CheckedInput_gladiatorResolve.Checked Then
                    healthMultiplier += 0.3 + (CheckedInput_gladiatorResolve.Value * 0.3)
                End If
                'quickthinking moved.
                'gladiator finesse moved.
                'shields
                If CheckedInput_redirection.Checked Then
                    shieldMultiplier += 0.4 + (CheckedInput_redirection.Value * 0.4)
                End If
                If CheckedInput_augurAccord.Checked Then
                    shieldMultiplier += 0.3 + (CheckedInput_augurAccord.Value * 0.3)
                End If
                'dual
                If CheckedInput_vigor.Checked Then
                    healthMultiplier += 0.2 + (CheckedInput_vigor.Value * 0.2)
                    shieldMultiplier += 0.2 + (CheckedInput_vigor.Value * 0.2)
                End If
            End If
            '
            '   Energy Mods
            '
            If CheckedGroupBox_miscellaneous.Checked Then
                If CheckedInput_enduranceDrift.Checked Then
                    energyMultiplier += 0.025 + (CheckedInput_enduranceDrift.Value * 0.025)
                End If
                If CheckedInput_flow.Checked Then
                    energyMultiplier += 0.25 + (CheckedInput_flow.Value * 0.25)
                End If
            End If
            '
            '   Power Strength Mods
            '
            If CheckedGroupBox_powerStrength.Checked Then
                If CheckedInput_overextended.Checked Then
                    powerStrength -= basePowerStrength * (0.1 + (CheckedInput_overextended.Value * 0.1))
                End If
                If CheckedInput_blindRage.Checked Then
                    powerStrength += basePowerStrength * (0.09 + (CheckedInput_blindRage.Value * 0.09))
                End If
                If CheckedInput_energyConversion.Checked Then
                    powerStrength += basePowerStrength * (0.08333333333 + (CheckedInput_energyConversion.Value * 0.08333333333))
                End If
                If CheckedInput_intensify.Checked Then
                    powerStrength += basePowerStrength * (0.05 + (CheckedInput_intensify.Value * 0.05))
                End If
                If CheckedInput_transientFortitude.Checked Then
                    powerStrength += basePowerStrength * (0.05 + (CheckedInput_transientFortitude.Value * 0.05))
                End If
                If CheckedInput_powerDrift.Checked Then
                    powerStrength += basePowerStrength * (0.025 + (CheckedInput_powerDrift.Value * 0.025))
                End If
                If CheckedInput_augurSecrets.Checked Then
                    powerStrength += basePowerStrength * (0.04 + (CheckedInput_augurSecrets.Value * 0.04))
                End If
            End If
            '
            '   Umbral Mods
            '
            Dim UmbralModifiy As Integer = 0
            If CheckedGroupBox_survivability.Checked Then
                If CheckedInput_umbralFiber.Checked Then
                    UmbralModifiy += 1
                End If
                If CheckedInput_umbralVitality.Checked Then
                    UmbralModifiy += 1
                End If
            End If
            If CheckedGroupBox_powerStrength.Checked And CheckedInput_umbralIntensify.Checked Then
                UmbralModifiy += 1
            End If
            If CheckedGroupBox_survivability.Checked Then
                'Armor
                If CheckedInput_umbralFiber.Checked Then
                    If UmbralModifiy = 1 Then
                        armorMultiplier += 0.1 + (CheckedInput_umbralFiber.Value * 0.1)
                    ElseIf UmbralModifiy = 2 Then
                        armorMultiplier += 0.125 + (CheckedInput_umbralFiber.Value * 0.125)
                    ElseIf UmbralModifiy = 3 Then
                        armorMultiplier += 0.175 + (CheckedInput_umbralFiber.Value * 0.175)
                    End If
                End If
                'Health
                If CheckedInput_umbralVitality.Checked Then
                    If UmbralModifiy = 1 Then
                        healthMultiplier += 0.4 + (CheckedInput_umbralVitality.Value * 0.4)
                    ElseIf UmbralModifiy = 2 Then
                        healthMultiplier += 0.5 + (CheckedInput_umbralVitality.Value * 0.5)
                    ElseIf UmbralModifiy = 3 Then
                        healthMultiplier += 0.7 + (CheckedInput_umbralVitality.Value * 0.7)
                    End If
                End If
            End If
            If CheckedGroupBox_powerStrength.Checked Then
                'Power
                If CheckedInput_umbralIntensify.Checked Then
                    If UmbralModifiy = 1 Then
                        powerStrength += basePowerStrength * (0.04 + (CheckedInput_umbralIntensify.Value * 0.04))
                    ElseIf UmbralModifiy = 2 Then
                        powerStrength += basePowerStrength * (0.05 + (CheckedInput_umbralIntensify.Value * 0.05))
                    ElseIf UmbralModifiy = 3 Then
                        powerStrength += basePowerStrength * (0.06 + (CheckedInput_umbralIntensify.Value * 0.06))
                    End If

                End If
            End If
            '
            '   Reactant Buff | Void Fissures
            '
            If CheckedGroupBox_specialEffects.Checked And CheckBox_corruptedBuff.Checked Then
                powerStrength *= 2
            End If
            '
            '   Abilities
            '
            If CheckedGroupBox_abilities.Checked Then
                Select Case currentWarframe.Name
                    Case "Atlas"
                        If CheckBox_rubble.Checked Then
                            Dim rubble As Decimal = NumericUpDown_rubble.Value
                            armorBonus += rubble
                        End If
                    Case "Baruuk"
                        Dim restraint As Decimal = 0.5 * (1 - (NumericUpDown_restraint.Value / 100))
                        Dim desolateHands As Decimal = 0.8 * powerStrength
                        If desolateHands > 0.9 Then
                            desolateHands = 0.9
                        End If
                        Dim sereneStorm As Decimal = 0.25 * powerStrength
                        If sereneStorm > 0.4 Then
                            sereneStorm = 0.4
                        End If
                        If CheckBox_restraint.Checked Then
                            damageReduction += (1 - damageReduction) * restraint
                        End If
                        If CheckBox_desolateHands.Checked Then
                            damageReduction += (1 - damageReduction) * desolateHands
                        End If
                        If CheckBox_sereneStorm.Checked Then
                            damageReduction += (1 - damageReduction) * sereneStorm
                        End If
                    Case "Chroma"
                        If CheckBox_elementalWard.Checked Then
                            Dim elementalWard As Decimal = 0.0
                            If RadioButton_iceChroma.Checked Then
                                elementalWard = 1.5 * powerStrength
                                armorMultiplier += elementalWard
                            ElseIf RadioButton_fireChroma.Checked Then
                                elementalWard = 2.0 * powerStrength
                                healthMultiplier += elementalWard
                            ElseIf RadioButton_electricChroma.Checked Then
                                elementalWard = 1.0 * powerStrength
                                shieldMultiplier += elementalWard
                            End If
                        End If
                        If CheckBox_vexArmor.Checked And currentWarframe.Name = "Chroma" And CheckedGroupBox_abilities.Checked Then
                            Dim vexArmor As Decimal = 3.5 * powerStrength
                            armorMultiplier += vexArmor
                        End If
                    Case "Excalibur"
                        If CheckBox_exaltedBlade.Checked Then
                            Dim exaltedBlade As Decimal = 0.6
                            damageReduction += exaltedBlade
                        End If
                    Case "Frost"
                        If CheckBox_icyAvalanche.Checked Then
                            Dim icyAvalance As Decimal = 0.6 * powerStrength * NumericUpDown_icyAvalanche.Value
                            damageAbsorbstion += icyAvalance
                        End If
                    Case "Gara"
                        If CheckBox_splinterStorm.Checked Then
                            Dim splinterStorm As Decimal = 0.7 * powerStrength
                            If splinterStorm > 0.9 Then
                                splinterStorm = 0.9
                            End If
                            damageReduction += splinterStorm
                        End If
                    Case "Harrow"
                        If CheckBox_wardingThurible.Checked Then
                            Dim wardingThurible As Decimal = 0.4 * powerStrength
                            If wardingThurible > 0.9 Then
                                wardingThurible = 0.9
                            End If
                            damageReduction += wardingThurible
                        End If
                    Case "Inaros"
                        If CheckBox_scarabSwarm.Checked Then
                            Dim scarabSwarm As Decimal = 2 * NumericUpDown_scarabSwarm.Value
                            armorBonus += scarabSwarm
                        End If
                    Case "Mesa"
                        If CheckBox_shatterShield.Checked Then
                            Dim shatterShield As Decimal = 0.8 * powerStrength
                            If shatterShield > 0.95 Then
                                shatterShield = 0.95
                            End If
                            damageReduction += shatterShield
                        End If
                        If CheckBox_marksmansDexterity.Checked Then
                            healthBonus += 50
                        End If
                    Case "Mirage"
                        If CheckBox_eclipse.Checked Then
                            Dim eclipse As Decimal = 0.75 * powerStrength
                            If eclipse > 0.95 Then
                                eclipse = 0.95
                            End If
                            damageReduction += eclipse
                        End If
                    Case "Nekros"
                        If CheckBox_shieldOfShadows.Checked Then
                            Dim shieldOfShadows As Decimal = 0.06 * powerStrength * NumericUpDown_shieldOfShadows.Value
                            If shieldOfShadows > 0.9 Then
                                shieldOfShadows = 0.9
                            End If
                            damageReduction += shieldOfShadows
                        End If
                    Case "Nezha"
                        If CheckBox_wardingHalo.Checked Then
                            Dim wardingHalo As Decimal = 0.9
                            damageReduction += wardingHalo
                        End If
                    Case "Nidus"
                        If CheckBox_mutationStacks.Checked Then
                            Dim validStacks As Decimal = Math.Floor(NumericUpDown_mutationStacks.Value / 5)
                            armorBonus += 20 * validStacks
                        End If
                        If CheckBox_parasiticLink.Checked Then
                            Dim parasiticLink As Decimal = 0.5 * powerStrength
                            If parasiticLink > 0.9 Then
                                parasiticLink = 0.9
                            End If
                            damageReduction += parasiticLink
                        End If
                    Case "Nova"
                        If CheckBox_nullStar.Checked Then
                            Dim particles As Decimal = NumericUpDown_nullStar.Value
                            Dim nullStar As Decimal = 0.05 * particles
                            If nullStar > 0.9 Then
                                nullStar = 0.9
                            End If
                            damageReduction += nullStar
                        End If
                    Case "Oberon"
                        If CheckBox_ironRenewal.Checked Then
                            Dim ironRenewal As Decimal = 200 * powerStrength
                            armorBonus += ironRenewal
                        End If
                        If CheckBox_hallowedReckoning.Checked Then
                            Dim hallowedReckoning As Decimal = 250
                            armorBonus += hallowedReckoning
                        End If
                    Case "Octavia"
                        If CheckBox_metronome.Checked Then
                            Dim metronome As Decimal = 0.35 * powerStrength
                            armorMultiplier += metronome
                        End If
                    Case "Rhino"
                        If CheckBox_ironcladCharge.Checked Then
                            Dim ironcladCharge As Decimal = 0.5 * powerStrength * NumericUpDown_ironcladCharge.Value
                            armorMultiplier += ironcladCharge
                        End If
                        If CheckBox_ironSkin.Checked Then
                            Dim ironSkinArmor As Decimal = 2.5 * Armor * (1 + armorMultiplier)
                            Dim ironSkinHealth As Decimal = 1200
                            Dim ironSkin As Decimal = ((ironSkinHealth + ironSkinArmor) * powerStrength) + NumericUpDown_ironSkin.Value
                            damageAbsorbstion += ironSkin
                        End If
                    Case "Titania"
                        If CheckBox_thorns.Checked Then
                            Dim thorns As Decimal = Math.Floor(NumericUpDown_thorns.Value / 5) * 0.05
                            damageReduction += thorns
                        End If
                    Case "Trinity"
                        Dim link As Decimal = 0.75
                        Dim blessing As Decimal = 0.5 * powerStrength
                        If CheckBox_link.Checked And Not CheckBox_blessing.Checked Then
                            damageReduction += link
                        ElseIf CheckBox_blessing.Checked And Not CheckBox_link.Checked Then
                            If blessing > 0.75 Then
                                blessing = 0.75
                            End If
                            damageReduction += blessing
                        ElseIf CheckBox_link.Checked And CheckBox_blessing.Checked Then
                            If blessing > 0.75 Then
                                blessing = 0.75
                            End If
                            damageReduction += blessing + ((1 - blessing) * link)
                        End If
                    Case "Valkyr"
                        If CheckBox_warcry.Checked Then
                            Dim warcryMultiplier As Decimal = 0.5 * powerStrength
                            armorMultiplier += warcryMultiplier
                        End If
                    Case "Wisp"
                        If CheckBox_vitalityMoteReservoirs.Checked Then
                            Dim vitalityMoteBonus As Decimal = 300 * powerStrength
                            healthBonus += vitalityMoteBonus
                        End If
                End Select
            End If
            '
            '   Blocking
            '
            If CheckedGroupBox_blocking.Checked Then
                If ComboBox_blocking.SelectedIndex > 0 Then
                    Dim BlockSTR As String = "0." & ComboBox_blocking.SelectedItem.ToString.Replace("%", "")
                    damageReduction += (1 - damageReduction) * Convert.ToDecimal(BlockSTR, New Globalization.CultureInfo("en-US"))
                End If
            End If
            '
            '   Calculate Values (with special support for Quickthinking and Gladiator Finesse)
            '
            Armor = (baseArmor * (1 + armorMultiplier)) + (Armor - baseArmor) + armorBonus
            Energy = Math.Ceiling(Energy) + Math.Floor((baseEnergy * energyMultiplier) + energyBonus)
            If CheckedGroupBox_survivability.Checked Then
                If CheckedInput_quickThinking.Checked Then
                    healthBonus += 0.4 * (1 + CheckedInput_quickThinking.Value) * Energy
                End If
                If CheckedInput_gladiatorFinesse.Checked Then
                    healthBonus += 0.1 * (1 + CheckedInput_gladiatorFinesse.Value) * Energy
                End If
            End If
            Health = (baseHealth * (1 + healthMultiplier)) + (Health - baseHealth) + healthBonus
            Shield = (baseShield * (1 + shieldMultiplier)) + (Shield - baseShield) + shieldBonus
            '
            '   Arcanes
            '
            If CheckedGroupBox_arcanes.Checked Then
                '
                '   Arcane Effects
                '
                If CheckedInput_arcaneGuardian.Checked Then
                    Armor += 150 + (150 * CheckedInput_arcaneGuardian.Value)
                End If
                If CheckedInput_arcaneGuardian2.Checked Then
                    Armor += 150 + (150 * CheckedInput_arcaneGuardian2.Value)
                End If
                If CheckedInput_arcaneUltimatum.Checked Then
                    Armor += 150 + (150 * CheckedInput_arcaneUltimatum.Value)
                End If
                If CheckedInput_arcaneUltimatum2.Checked Then
                    Armor += 150 + (150 * CheckedInput_arcaneUltimatum2.Value)
                End If
            End If
            '
            '   Focus
            '
            If CheckedGroupBox_focus.Checked And CheckedInput_stoneSkin.Checked Then
                ' Memes (Fibonacci Squence - first 2 numbers)
                Armor = Armor + 10 + 1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, CheckedInput_stoneSkin.Value + 2) - Math.Pow((1 - Math.Sqrt(5)) / 2, CheckedInput_stoneSkin.Value + 2)) * 10
            End If
            '
            '   Dragon Keys
            '
            If CheckedGroupBox_dragonKeys.Checked Then
                If CheckBox_bleedingKey.Checked Then
                    Health *= 0.25
                End If
                If CheckBox_decayingKey.Checked Then
                    Shield *= 0.25
                End If
            End If
            StatBox_warframeArmor.Value = Math.Floor(Armor)
            StatBox_warframeHealth.Value = Math.Floor(Health)
            StatBox_warframeShield.Value = Math.Floor(Shield)
            StatBox_warframeEnergy.Value = Math.Floor(Energy)
            StatBox_warframePowerStrength.Value = Math.Floor(powerStrength * 100)
            '
            '   Calculate EHP
            '
            Dim damageReductionArmor As Decimal = Armor / (300 + Armor)
            Dim totalDamageReduction As Decimal = damageReductionArmor + ((1 - damageReductionArmor) * damageReduction)
            'Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield + damageAbsorbstion))
            Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield / (1 - damageReduction)) + damageAbsorbstion)
            StatBox_warframeEHP.Value = effectiveHealth
        Else
            '
            '   No Warframe selected, display values should be set to default
            '
            StatBox_warframeArmor.Value = Nothing
            StatBox_warframeHealth.Value = Nothing
            StatBox_warframeShield.Value = Nothing
            StatBox_warframeEnergy.Value = Nothing
            StatBox_warframePowerStrength.Value = Nothing
            StatBox_warframeEHP.Value = Nothing
        End If
        Companion_Value_Changed(sender, e)
    End Sub

    Private Sub Companion_Value_Changed(sender As Object, e As EventArgs)
        Dim currentWarframe As Warframe = Warframes.Find(Function(wf) wf.Name = ComboBox_warframes.SelectedItem)
        '   Pet Stats
        Dim Armor As Decimal = 0.0
        Dim Health As Decimal = 0.0
        Dim Shield As Decimal = 0.0
        ComboBox_petArmor.SelectedIndex = ComboBox_companions.SelectedIndex
        ComboBox_petHealth.SelectedIndex = ComboBox_companions.SelectedIndex
        ComboBox_petShield.SelectedIndex = ComboBox_companions.SelectedIndex
        If ComboBox_companions.SelectedIndex > 2 And Not ComboBox_companions.SelectedItem = "Venari" Then
            CheckBox_companionPrimeCollar.Enabled = True
            NumericUpDown_companionStability.Enabled = True
            Label_companionStability.Enabled = True
        Else
            CheckBox_companionPrimeCollar.Enabled = False
            NumericUpDown_companionStability.Enabled = False
            Label_companionStability.Enabled = False
        End If
        If ComboBox_companions.SelectedIndex > 0 Then
            CheckBox_companionSurvivability.Enabled = True
            GroupBox_companionSurvivability.Enabled = CheckBox_companionSurvivability.Checked
            Armor = FormatNumber(ComboBox_petArmor)
            Health = FormatNumber(ComboBox_petHealth)
            Shield = FormatNumber(ComboBox_petShield)
            If NumericUpDown_companionStability.Enabled = True Then
                'genetic stability
                Health *= 1 + (NumericUpDown_companionStability.Value / 100)
            End If
            If currentWarframe.Name = "Oberon" Then
                'Oberon Passive
                Armor += 75
                Health = Math.Floor(Health + (Health * 0.25))
                Shield = Math.Floor(Shield + (Shield * 0.25))
            End If
            If CheckBox_companionPrimeCollar.Enabled And CheckBox_companionPrimeCollar.Checked Then
                Armor += 100
                Health += 10
                Shield += 10
            End If
            If CheckBox_companionSurvivability.Checked Then
                If CheckBox_companionLinkArmor.Checked = True Then
                    Armor = Math.Floor(Armor + (StatBox_warframeArmor.Value * ((NumericUpDown_companionLinkArmor.Value + 1) * 0.1)))
                End If
                If CheckBox_companionLinkHealth.Checked = True Then
                    Health = Math.Floor(Health + (StatBox_warframeHealth.Value * ((NumericUpDown_companionLinkHealth.Value + 1) * 0.15)))
                End If
                If CheckBox_companionLinkShield.Checked = True Then
                    Shield = Math.Floor(Shield + (StatBox_warframeShield.Value * ((NumericUpDown_companionLinkShield.Value + 1) * 0.1)))
                End If
            End If
            Dim damageReductionArmor = Armor / (300 + Armor)
            Dim effectiveHealth = (Health / (1 - damageReductionArmor)) + Shield
            TextBox_companionEHP.Text = Math.Ceiling(effectiveHealth)
            TextBox_companionArmor.Text = Math.Floor(Armor)
            TextBox_companionHealth.Text = Math.Floor(Health)
            TextBox_companionShield.Text = Math.Floor(Shield)
        Else
            CheckBox_companionSurvivability.Enabled = False
            GroupBox_companionSurvivability.Enabled = False
            TextBox_companionArmor.Text = "-"
            TextBox_companionHealth.Text = "-"
            TextBox_companionShield.Text = "-"
            TextBox_companionEHP.Text = "-"
        End If
    End Sub

End Class
