Imports System.IO
Imports System.Net

Public Class Form_main

    Public squadMembers As New Dictionary(Of String, String)
    Public liveVersion As String

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

    Public Function formatNumber(ByVal Number)
        Dim formatted As Decimal = 0.0
        If TypeOf Number Is ComboBox Then
            formatted = Convert.ToDecimal(Number.SelectedItem.ToString().Split("_")(0).Replace("???", "0"), New Globalization.CultureInfo("en-US")) 'Allow placeholder frame values for dev
        ElseIf TypeOf Number Is TextBox Then
            If Number.Text = "-" Then
                formatted = Convert.ToDecimal(0, New Globalization.CultureInfo("en-US"))
            Else
                formatted = Convert.ToDecimal(Number.Text, New Globalization.CultureInfo("en-US"))
            End If
        End If
        Return formatted
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        '   Hide Debug controls
        '
        TabControl_main.TabPages.Remove(TabPage_development)
        '
        '   This should let the math not explode for non English OS's
        '   But just incase i also use the function `formatNumber` to be safe
        '
        Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        '
        '   Remove Tab Headers for Abilities
        '
        CustomTabControl_abilitys.Appearance = TabAppearance.FlatButtons
        CustomTabControl_abilitys.ItemSize = New Size(0, 1)
        CustomTabControl_abilitys.SizeMode = TabSizeMode.Fixed
        '
        '   Remove Tab Headers for Arcane Helmets
        '
        CustomTabControl_arcaneHelmets.Appearance = TabAppearance.FlatButtons
        CustomTabControl_arcaneHelmets.ItemSize = New Size(0, 1)
        CustomTabControl_arcaneHelmets.SizeMode = TabSizeMode.Fixed
        '
        '   Change Warframe select box to the default section
        '   also change all other combo boxs to index 0
        '   comboboxs that match index are auto updated by the 
        '   event handler
        '
        ComboBox_warframes.SelectedIndex = 0
        ComboBox_primes.SelectedIndex = 0
        ComboBox_umbras.SelectedIndex = 0
        ComboBox_companions.SelectedIndex = 0
        '
        '   Abilities and Focus
        '
        AddHandler CheckBox_abilities.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckBox_focus.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Frame Type
        '
        AddHandler CheckBox_isPrime.CheckedChanged, AddressOf Toggle_Warframe_Type
        AddHandler CheckBox_isUmbra.CheckedChanged, AddressOf Toggle_Warframe_Type
        '
        '   Mod Sections
        '
        AddHandler CheckBox_aura.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckBox_survivability.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckBox_power.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckBox_miscellaneous.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Arcanes and Keys
        '
        AddHandler CheckBox_arcanes.CheckedChanged, AddressOf Enable_Disable_Section
        AddHandler CheckBox_dragonKeys.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Special Effects
        '
        AddHandler CheckBox_specialEffects.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Sortie Modifiers
        '
        AddHandler CheckBox_sortieModifiers.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Arcane Helmets
        '
        AddHandler CheckBox_arcaneHelmets.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   UI Update on warframe change - ability and helmet enabling
        '   and recalc EHP on stat change (pretty much everything is linked in here)
        '   Since there are so many things to addHandler for im going to do it at runtime
        '   with loops to make my life easier
        '
        AddHandler ComboBox_warframes.SelectedIndexChanged, AddressOf Warframe_Value_Changed
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
        '   Add Squad Members
        '
        squadMembers.Add("One", "One:Chroma:None:None:100")
        squadMembers.Add("Two", "Two:Chroma:None:None:100")
        squadMembers.Add("Three", "Three:Chroma:None:None:100")
        squadMembers.Add("Four", "Four:Chroma:None:None:100")
        squadMembers.Add("Five", "Five:Chroma:None:None:100")
        squadMembers.Add("Six", "Six:Chroma:None:None:100")
        squadMembers.Add("Seven", "Seven:Chroma:None:None:100")
        AddHandler Button_squadEffectsOne.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsTwo.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsThree.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsFour.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsFive.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsSix.Click, AddressOf Add_Squad_Member
        AddHandler Button_squadEffectsSeven.Click, AddressOf Add_Squad_Member
        '
        '   Companions
        '
        AddHandler ComboBox_companions.SelectedIndexChanged, AddressOf Companion_Value_Changed
        AddHandler CheckBox_companionSurvivability.CheckedChanged, AddressOf Enable_Disable_Section
        '
        ' Check for Update
        '
        Try
            liveVersion = New StreamReader(New WebClient().OpenRead("https://raw.githubusercontent.com/cmd430/Warframe-EHP-Calculator/master/Warframe%20EHP%20Calculator%20v2/version")).ReadToEnd.Trim()
            If Not liveVersion = Label_version.Text Then
                Form_update.ShowDialog()
            End If
        Catch ex As Exception
            'Cant check for updates
        End Try
    End Sub

    Public Sub Toggle_Warframe_Type(sender As Object, e As EventArgs)
        '
        '   Enable Swapping between Normal / Prime / Umbra Frames
        '   
        '   Checks for State are inverted because .net gets the state info
        '   from after the click (makes sense)
        '
        RemoveHandler CheckBox_isPrime.CheckedChanged, AddressOf Toggle_Warframe_Type
        RemoveHandler CheckBox_isUmbra.CheckedChanged, AddressOf Toggle_Warframe_Type
        Dim Prime As CheckBox = TabPage_warframe.Controls("CheckBox_isPrime")
        Dim Umbra As CheckBox = TabPage_warframe.Controls("CheckBox_isUmbra")
        If sender.Name = Prime.Name Then
            If Not Prime.Checked Then
                Prime.Checked = False
            Else
                Prime.Checked = True
                Umbra.Checked = False
            End If
        ElseIf sender.Name = Umbra.Name Then
            If Not Umbra.Checked Then
                Umbra.Checked = False
            Else
                Umbra.Checked = True
                Prime.Checked = False
            End If
        End If
        AddHandler CheckBox_isPrime.CheckedChanged, AddressOf Toggle_Warframe_Type
        AddHandler CheckBox_isUmbra.CheckedChanged, AddressOf Toggle_Warframe_Type
    End Sub

    Public Sub Enable_Disable_Section(sender As Object, e As EventArgs)
        '
        '   Enable and disable GroupBoxes/CustomTabControls based on its checkbox
        '
        sender.Parent.Controls(sender.tag).Enabled = sender.Checked
    End Sub

    Private Sub Add_Squad_Member(sender As Object, e As EventArgs)
        Dim SquadMember As String = sender.Name.ToString.Replace("Button_squadEffects", "")
        Dim SquadDialog As New Form_squadMember(squadMembers.Item(SquadMember))
        If SquadDialog.ShowDialog() = DialogResult.OK Then
            squadMembers.Item(SquadMember) = SquadDialog.TextBox_squadInfo.Text
        End If
        SquadDialog.Dispose()

        '
        '   TODO:\\ Figure out how the fuck the data from the form is to be added to the player
        '           (some stuff needs to be added before stat calculation [i.e PowerStr additive buffs] 
        '            some stuff after some calculations for before others [i.e PowerStr multiplicitive buffs]
        '            dmg reduction, absorbtion and armor buffs should all be after other calculations
        '

        Warframe_Value_Changed(sender, e)
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
        '
        '   Does the frame have a Prime or Umbra version ?
        '   if so we can enable to checkbox
        '
        If ComboBox_primes.Items.Contains(ComboBox_warframes.SelectedItem) Then
            CheckBox_isPrime.Enabled = True
        Else
            CheckBox_isPrime.Enabled = False
        End If
        If ComboBox_umbras.Items.Contains(ComboBox_warframes.SelectedItem) Then
            CheckBox_isUmbra.Enabled = True
        Else
            CheckBox_isUmbra.Enabled = False
        End If
        '
        '   Special Modifiers
        '
        '   some frames have passives that change fixed things
        '
        If ComboBox_warframes.SelectedItem = "Khora" And Not ComboBox_companions.Items.Contains("Venari") Then
            ComboBox_companions.Items.Add("Venari")
        ElseIf Not ComboBox_warframes.SelectedItem = "Khora" And ComboBox_companions.Items.Contains("Venari") Then
            If ComboBox_companions.SelectedItem = "Venari" Then
                ComboBox_companions.SelectedIndex = 0
            End If
            ComboBox_companions.Items.RemoveAt(ComboBox_companions.Items.Count - 1)
        End If
        If ComboBox_warframes.SelectedItem = "Harrow" Then
            NumericUpDown_oversheilds.Maximum = 2400
        Else
            NumericUpDown_oversheilds.Maximum = 1200
        End If
        '
        '  Enable/Disable Arcane Helmets selection
        '
        Select Case ComboBox_warframes.SelectedItem
            Case "Ash"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsAsh
            Case "Banshee"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsBanshee
            Case "Ember"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsEmber
            Case "Excalibur"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsExcalibur
            Case "Frost"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsFrost
            Case "Loki"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsLoki
            Case "Mag"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsMag
            Case "Nova"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsNova
            Case "Nyx"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsNyx
            Case "Rhino"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsRhino
            Case "Saryn"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsSaryn
            Case "Trinity"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsTrinity
            Case "Vauban"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsVauban
            Case "Volt"
                CheckBox_arcaneHelmets.Enabled = True
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsVolt
            Case Else
                CheckBox_arcaneHelmets.Enabled = False
                CustomTabControl_arcaneHelmets.Enabled = False
                CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsDefault
        End Select
        '
        '   Enable/Disable Abilities Selection
        '
        Select Case ComboBox_warframes.SelectedItem
            Case "Atlas"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesAtlas
            Case "Chroma"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesChroma
            Case "Frost"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesFrost
            Case "Gara"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesGara
            Case "Inaros"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesInaros
            Case "Mesa"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesMesa
            Case "Mirage"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesMirage
            Case "Nekros"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesNekros
            Case "Nezha"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesNezha
            Case "Nidus"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesNidus
            Case "Oberon"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesOberon
            Case "Octavia"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesOctavia
            Case "Rhino"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesRhino
            Case "Titania"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesTrinity
            Case "Trinity"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesTrinity
            Case "Valkyr"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesValkyr
            Case "Vauban"
                CheckBox_abilities.Enabled = True
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesVauban
            Case Else
                CheckBox_abilities.Enabled = False
                CustomTabControl_abilitys.Enabled = False
                CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesDefault
        End Select
        If ComboBox_warframes.SelectedIndex > 0 Then
            '
            '   Special test for Squad Checkboxs to enable/disbale buttons
            '
            If sender.Name.ToString.Contains("CheckBox_squadEffects") Then
                sender.Parent.Controls(sender.tag).Enabled = sender.Checked
            End If
            '
            '   Enable Selections
            '
            CheckBox_aura.Enabled = True
            GroupBox_aura.Enabled = CheckBox_aura.Checked
            CheckBox_survivability.Enabled = True
            GroupBox_survivability.Enabled = CheckBox_survivability.Checked
            CheckBox_miscellaneous.Enabled = True
            GroupBox_miscellaneous.Enabled = CheckBox_miscellaneous.Checked
            CheckBox_power.Enabled = True
            GroupBox_power.Enabled = CheckBox_power.Checked
            CheckBox_arcanes.Enabled = True
            GroupBox_arcanes.Enabled = CheckBox_arcanes.Checked
            CheckBox_dragonKeys.Enabled = True
            GroupBox_dragonKeys.Enabled = CheckBox_dragonKeys.Checked
            '
            '   Focus is currently disabled
            '
            CheckBox_focus.Enabled = False
            GroupBox_focus.Enabled = CheckBox_focus.Checked
            '
            CheckBox_specialEffects.Enabled = True
            GroupBox_specialEffects.Enabled = CheckBox_specialEffects.Checked
            CheckBox_sortieModifiers.Enabled = True
            GroupBox_sortieModifiers.Enabled = CheckBox_sortieModifiers.Checked
            CustomTabControl_abilitys.Enabled = CheckBox_abilities.Checked
            CustomTabControl_arcaneHelmets.Enabled = CheckBox_arcaneHelmets.Checked
            CheckBox_squadEffects.Enabled = True
            GroupBox_squadEffects.Enabled = CheckBox_squadEffects.Checked

            If CheckBox_isPrime.Checked And CheckBox_isPrime.Enabled Then
                '
                '   Prime Warframe stats
                '
                ComboBox_primes.SelectedIndex = ComboBox_primes.Items.IndexOf(ComboBox_warframes.SelectedItem)
                ComboBox_primeBaseArmor.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeArmor.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeBaseHealth.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeHealth.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeBaseShield.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeShield.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeBaseEnergy.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeEnergy.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primeBasePower.SelectedIndex = ComboBox_primes.SelectedIndex
                ComboBox_primePower.SelectedIndex = ComboBox_primes.SelectedIndex

                baseArmor = formatNumber(ComboBox_primeBaseArmor)
                Armor = formatNumber(ComboBox_primeArmor)
                baseHealth = formatNumber(ComboBox_primeBaseHealth)
                Health = formatNumber(ComboBox_primeHealth)
                baseShield = formatNumber(ComboBox_primeBaseShield)
                Shield = formatNumber(ComboBox_primeShield)
                baseEnergy = formatNumber(ComboBox_primeBaseEnergy)
                Energy = formatNumber(ComboBox_primeEnergy)
                basePowerStrength = formatNumber(ComboBox_primeBasePower) / 100
                powerStrength = formatNumber(ComboBox_primePower) / 100
            ElseIf CheckBox_isUmbra.Checked And CheckBox_isUmbra.Enabled Then
                '
                '   Umbra Warframe stats
                '
                ComboBox_umbras.SelectedIndex = ComboBox_umbras.Items.IndexOf(ComboBox_warframes.SelectedItem)
                ComboBox_umbraBaseArmor.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraArmor.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraBaseHealth.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraHealth.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraBaseShield.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraShield.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraBaseEnergy.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraEnergy.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraBasePower.SelectedIndex = ComboBox_umbras.SelectedIndex
                ComboBox_umbraPower.SelectedIndex = ComboBox_umbras.SelectedIndex

                baseArmor = formatNumber(ComboBox_umbraBaseArmor)
                Armor = formatNumber(ComboBox_umbraArmor)
                baseHealth = formatNumber(ComboBox_umbraBaseHealth)
                Health = formatNumber(ComboBox_umbraHealth)
                baseShield = formatNumber(ComboBox_umbraBaseShield)
                Shield = formatNumber(ComboBox_umbraShield)
                baseEnergy = formatNumber(ComboBox_umbraBaseEnergy)
                Energy = formatNumber(ComboBox_umbraEnergy)
                basePowerStrength = formatNumber(ComboBox_umbraBasePower) / 100
                powerStrength = formatNumber(ComboBox_umbraPower) / 100
            Else
                '
                '   Normal Warframe stats
                '
                ComboBox_baseArmor.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_armor.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_baseHealth.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_health.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_baseShield.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_shield.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_baseEnergy.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_energy.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_basePower.SelectedIndex = ComboBox_warframes.SelectedIndex
                ComboBox_power.SelectedIndex = ComboBox_warframes.SelectedIndex

                baseArmor = formatNumber(ComboBox_baseArmor)
                Armor = formatNumber(ComboBox_armor)
                baseHealth = formatNumber(ComboBox_baseHealth)
                Health = formatNumber(ComboBox_health)
                baseShield = formatNumber(ComboBox_baseShield)
                Shield = formatNumber(ComboBox_shield)
                baseEnergy = formatNumber(ComboBox_baseEnergy)
                Energy = formatNumber(ComboBox_energy)
                basePowerStrength = formatNumber(ComboBox_basePower) / 100
                powerStrength = formatNumber(ComboBox_power) / 100
            End If
            '
            ' Overshields
            '
            If CheckBox_specialEffects.Checked And CheckBox_overshields.Checked Then
                shieldBonus = shieldBonus + NumericUpDown_oversheilds.Value
            End If
            '
            '   Arcane Helmets
            '
            If CheckBox_arcaneHelmets.Checked Then
                Select Case ComboBox_warframes.SelectedItem
                    Case "Ash"
                        If RadioButton_locustHelmet.Checked Then
                            Energy = Energy + (baseEnergy * 0.2)
                        End If
                    Case "Banshee"
                        If RadioButton_reverbHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                            Energy = Energy + (baseEnergy * 0.1)
                        End If
                    Case "Ember"
                        If RadioButton_phoenixHelmet.Checked Then
                            Shield = Shield + (baseShield * 0.05)
                            Energy = Energy + (baseEnergy * 0.25)
                        ElseIf RadioButton_backdraftHelmet.Checked Then
                            Health = Health + (baseHealth * 0.15)
                        End If
                    Case "Excalibur"
                        If RadioButton_avalonHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                            Shield = Shield + (baseShield * 0.25)
                        ElseIf RadioButton_pendragonHelmet.Checked Then
                            Armor = Armor - (baseArmor * 0.05)
                            powerStrength = powerStrength + (powerStrength * 0.15)
                        End If
                    Case "Frost"
                        If RadioButton_auroraHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                            Armor = Armor + (baseArmor * 0.25)
                        ElseIf RadioButton_squallHelmet.Checked Then
                            Shield = Shield - (baseShield * 0.05)
                            powerStrength = powerStrength + (powerStrength * 0.15)
                        End If
                    Case "Loki"
                        If RadioButton_essenceHelmet.Checked Then
                            Armor = Armor - (baseArmor * 0.05)
                        ElseIf RadioButton_swindleHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                        End If
                    Case "Mag"
                        If RadioButton_coilHelmet.Checked Then
                            Shield = Shield - (baseShield * 0.05)
                        ElseIf RadioButton_gaussHelmet.Checked Then
                            Energy = Energy + (baseEnergy * 0.25)
                        End If
                    Case "Nova"
                        If RadioButton_fluxHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                        End If
                    Case "Nyx"
                        If RadioButton_menticideHelmet.Checked Then
                            Shield = Shield - (baseShield * 0.05)
                        ElseIf RadioButton_vespaHelmet.Checked Then
                            Armor = Armor - (baseArmor * 0.05)
                        End If
                    Case "Rhino"
                        If RadioButton_thrak.Checked Then
                            Health = Health + (baseHealth * 0.25)
                        ElseIf RadioButton_vanguardHelmet.Checked Then
                            powerStrength = powerStrength - (powerStrength * 0.05)
                        End If
                    Case "Saryn"
                        If RadioButton_hemlockHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                        End If
                    Case "Trinity"
                        If RadioButton_auraHelmet.Checked Then
                            Health = Health - (baseHealth * 0.05)
                        ElseIf RadioButton_meridianHelmet.Checked Then
                            Shield = Shield + (baseShield * 0.15)
                        End If
                    Case "Vauban"
                        If RadioButton_espritHelmet.Checked Then
                            Shield = Shield - (baseShield * 0.1)
                            Energy = Energy + (baseEnergy * 0.1)
                        End If
                    Case "Volt"
                        If RadioButton_pulseHelmet.Checked Then
                            Shield = Shield - (baseShield * 0.05)
                        ElseIf RadioButton_stormHelmet.Checked Then
                            powerStrength = powerStrength + (powerStrength * 0.1)
                        End If
                End Select
            End If
            '
            '   Sortie Modifiers
            '
            If CheckBox_sortieModifiers.Checked Then
                If RadioButton_sortieCryogenicLeakage.Checked Then
                    Shield = Shield - (baseShield * 0.5)
                ElseIf RadioButton_sortieFire.Checked Then
                    Health = Health - (baseHealth * 0.5)
                End If
            End If
            '
            '   Aura Mods
            '
            If CheckBox_aura.Checked Then
                If RadioButton_physique.Checked Then
                    Dim physique As Decimal = 0.03 + (NumericUpDown_physique.Value * 0.03)
                    If CheckBox_coactionDrift.Checked And CheckBox_miscellaneous.Checked Then
                        '
                        '   Coaction Drift is Strange, it gives you a 0.15 boost to all Auras
                        '   and another 0.15 boost to your Aura ontop of the other for a total
                        '   of 0.15 * (1 + 0.15) + 0.15 = 0.3225 (values are for max rank mod)
                        '
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * NumericUpDown_coactionDrift.Value)
                        healthMultiplier = healthMultiplier + (physique + (physique * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                    Else
                        healthMultiplier = healthMultiplier + physique
                    End If
                ElseIf RadioButton_standUnited.Checked Then
                    Dim standUnited As Decimal = 0.0425 + (NumericUpDown_standUnited.Value * 0.0425)
                    If CheckBox_coactionDrift.Checked And CheckBox_miscellaneous.Checked Then
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * NumericUpDown_coactionDrift.Value)
                        armorMultiplier = armorMultiplier + (standUnited + (standUnited * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                    Else
                        armorMultiplier = armorMultiplier + standUnited
                    End If
                ElseIf RadioButton_growingPower.Checked Then
                    Dim growingPower As Decimal = basePowerStrength * (0.04166666667 + (NumericUpDown_growingPower.Value * 0.04166666667))
                    'If CheckBox_coactionDrift.Checked And CheckBox_miscellaneous.Checked Then
                    'Dim coactionDrit As Decimal = 0.025 + (0.025 * NumericUpDown_coactionDrift.Value)
                    'powerStrength = powerStrength + (growingPower + (growingPower * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                    'Else
                    powerStrength = powerStrength + growingPower
                    ' End If
                End If
            End If
            '
            '   Armor / Health / Shield Mods
            '
            If CheckBox_survivability.Checked Then
                'Armor
                If CheckBox_steelFiber.Checked Then
                    armorMultiplier = armorMultiplier + (0.1 + (NumericUpDown_steelFiber.Value * 0.1))
                End If
                If CheckBox_armoredAgility.Checked Then
                    armorMultiplier = armorMultiplier + (0.075 + (NumericUpDown_armoredAgility.Value * 0.075))
                End If
                If CheckBox_healthConversion.Checked Then
                    armorBonus = (armorBonus + ((75 + (NumericUpDown_healthConversion.Value * 75)) * NumericUpDown_healthConversionStacks.Value))
                End If
                If CheckBox_gladiatorAegis.Checked Then
                    armorMultiplier = armorMultiplier + (0.075 + (NumericUpDown_gladiatorAegis.Value * 0.075))
                End If
                'health
                If CheckBox_vitality.Checked Then
                    healthMultiplier = healthMultiplier + (0.4 + (NumericUpDown_vitality.Value * 0.4))
                End If
                If CheckBox_gladiatorResolve.Checked Then
                    healthMultiplier = healthMultiplier + (0.3 + (NumericUpDown_gladiatorResolve.Value * 0.3))
                End If
                'quickthinking moved.
                'gladiator finesse moved.
                'shields
                If CheckBox_redirection.Checked Then
                    shieldMultiplier = shieldMultiplier + (0.4 + (NumericUpDown_redirection.Value * 0.4))
                End If
                If CheckBox_augurAccord.Checked Then
                    shieldMultiplier = shieldMultiplier + (0.3 + (NumericUpDown_augurAccord.Value * 0.3))
                End If
                'dual
                If CheckBox_vigor.Checked Then
                    healthMultiplier = healthMultiplier + (0.2 + (NumericUpDown_vigor.Value * 0.2))
                    shieldMultiplier = shieldMultiplier + (0.2 + (NumericUpDown_vigor.Value * 0.2))
                End If
            End If
            '
            '   Energy Mods
            '
            If CheckBox_miscellaneous.Checked Then
                If CheckBox_enduranceDrift.Checked Then
                    energyMultiplier = energyMultiplier + (0.025 + (NumericUpDown_enduranceDrift.Value * 0.025))
                End If
                If CheckBox_flow.Checked Then
                    energyMultiplier = energyMultiplier + (0.25 + (NumericUpDown_flow.Value * 0.25))
                End If
            End If
            '
            '   Power Strength Mods
            '
            If CheckBox_power.Checked Then
                If CheckBox_overextended.Checked Then
                    powerStrength = powerStrength - (basePowerStrength * (0.1 + (NumericUpDown_overextended.Value * 0.1)))
                End If
                If CheckBox_blindRage.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.09 + (NumericUpDown_blindRage.Value * 0.09)))
                End If
                If CheckBox_energyConversion.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.08333333333 + (NumericUpDown_energyConversion.Value * 0.08333333333)))
                End If
                If CheckBox_intensify.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.05 + (NumericUpDown_intensify.Value * 0.05)))
                End If
                If CheckBox_transientFortitude.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.05 + (NumericUpDown_transientFortitude.Value * 0.05)))
                End If
                If CheckBox_powerDrift.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.025 + (NumericUpDown_powerDrift.Value * 0.025)))
                End If
                If CheckBox_augurSecrets.Checked Then
                    powerStrength = powerStrength + (basePowerStrength * (0.04 + (NumericUpDown_augurSecrets.Value * 0.04)))
                End If
            End If
            '
            '   Reactant Buff | Void Fissures
            '
            If CheckBox_specialEffects.Checked And CheckBox_corruptedBuff.Checked Then
                powerStrength = powerStrength * 2
            End If
            '
            '   Abilities
            '
            If CheckBox_abilities.Checked Then
                Select Case ComboBox_warframes.SelectedItem
                    Case "Atlas"
                        If CheckBox_rubble.Checked Then
                            Dim rubble As Decimal = NumericUpDown_rubble.Value
                            armorBonus = armorBonus + rubble
                        End If
                    Case "Chroma"
                        If CheckBox_elementalWard.Checked Then
                            Dim elementalWard As Decimal = 0.0
                            If RadioButton_iceChroma.Checked Then
                                elementalWard = 1.5 * powerStrength
                                armorMultiplier = armorMultiplier + elementalWard
                            ElseIf RadioButton_fireChroma.Checked Then
                                elementalWard = 2.0 * powerStrength
                                healthMultiplier = healthMultiplier + elementalWard
                            ElseIf RadioButton_electricChroma.Checked Then
                                elementalWard = 1.0 * powerStrength
                                shieldMultiplier = shieldMultiplier + elementalWard
                            End If
                        End If
                       '
                       '   Vex armor is down with the final health calulations because of how it works
                       '   it'd be a pain to do without writing extra crap...
                       '
                    Case "Frost"
                        If CheckBox_icyAvalanche.Checked Then
                            Dim icyAvalance As Decimal = (0.6 * powerStrength) * NumericUpDown_icyAvalanche.Value
                            damageAbsorbstion = icyAvalance
                        End If
                    Case "Gara"
                        If CheckBox_splinterStorm.Checked Then
                            Dim splinterStorm As Decimal = 0.7 * powerStrength
                            If splinterStorm > 0.9 Then
                                splinterStorm = 0.9
                            End If
                            damageReduction = splinterStorm
                        End If
                    Case "Inaros"
                        If CheckBox_scarabSwarm.Checked Then
                            Dim scarabSwarm As Decimal = 2 * NumericUpDown_scarabSwarm.Value
                            armorBonus = armorBonus + scarabSwarm
                        End If
                    Case "Mesa"
                        If CheckBox_shatterShield.Checked Then
                            Dim shatterShield As Decimal = 0.8 * powerStrength
                            If shatterShield > 0.95 Then
                                shatterShield = 0.95
                            End If
                            damageReduction = damageReduction + shatterShield
                        End If
                        If CheckBox_marksmansDexterity.Checked Then
                            healthBonus = healthBonus + 50
                        End If
                    Case "Mirage"
                        If CheckBox_eclipse.Checked Then
                            Dim eclipse As Decimal = 0.75 * powerStrength
                            If eclipse > 0.95 Then
                                eclipse = 0.95
                            End If
                            damageReduction = damageReduction + eclipse
                        End If
                    Case "Nekros"
                        If CheckBox_shieldOfShadows.Checked Then
                            Dim shieldOfShadows As Decimal = (0.06 * powerStrength) * NumericUpDown_shieldOfShadows.Value
                            If shieldOfShadows > 0.9 Then
                                shieldOfShadows = 0.9
                            End If
                            damageReduction = shieldOfShadows
                        End If
                    Case "Nezha"
                        If CheckBox_wardingHalo.Checked Then
                            Dim wardingHaloArmor As Decimal = 2.5 * Armor * (1 + armorMultiplier)
                            Dim wardingHaloHealth As Decimal = 900
                            Dim wardingHalo As Decimal = ((wardingHaloHealth + wardingHaloArmor) * powerStrength) + NumericUpDown_wardingHalo.Value
                            damageAbsorbstion = wardingHalo
                        End If
                    Case "Nidus"
                        If CheckBox_mutationStacks.Checked Then
                            Dim validStacks As Decimal = Math.Floor(NumericUpDown_mutationStacks.Value / 5)
                            armorBonus = armorBonus + (20 * validStacks)
                        End If
                        If CheckBox_parasiticLink.Checked Then
                            Dim parasiticLink As Decimal = 0.5 * powerStrength
                            If parasiticLink > 0.9 Then
                                parasiticLink = 0.9
                            End If
                            damageReduction = parasiticLink
                        End If
                    Case "Oberon"
                        If CheckBox_ironRenewal.Checked Then
                            Dim ironRenewal As Decimal = 200 * powerStrength
                            armorBonus = armorBonus + ironRenewal
                        End If
                        If CheckBox_hallowedReckoning.Checked Then
                            Dim hallowedReckoning As Decimal = 250
                            armorBonus = armorBonus + hallowedReckoning
                        End If
                    Case "Octavia"
                        If CheckBox_metronome.Checked Then
                            Dim metronome As Decimal = 0.35 * powerStrength
                            armorMultiplier = armorMultiplier + metronome
                        End If
                    Case "Rhino"
                        If CheckBox_ironcladCharge.Checked Then
                            Dim ironcladCharge As Decimal = (0.5 * powerStrength) * NumericUpDown_ironcladCharge.Value
                            armorMultiplier = armorMultiplier + ironcladCharge
                        End If
                        If CheckBox_ironSkin.Checked Then
                            Dim ironSkinArmor As Decimal = 2.5 * Armor * (1 + armorMultiplier)
                            Dim ironSkinHealth As Decimal = 1200
                            Dim ironSkin As Decimal = ((ironSkinHealth + ironSkinArmor) * powerStrength) + NumericUpDown_ironSkin.Value
                            damageAbsorbstion = ironSkin
                        End If
                    Case "Titania"
                        If CheckBox_thorns.Checked Then
                            Dim thorns As Decimal = Math.Floor(NumericUpDown_thorns.Value / 5) * 0.05
                            damageReduction = thorns
                        End If
                    Case "Trinity"
                        Dim link As Decimal = 0.75
                        Dim blessing As Decimal = 0.5 * powerStrength
                        If CheckBox_link.Checked And Not CheckBox_blessing.Checked Then
                            damageReduction = link
                        ElseIf CheckBox_blessing.Checked And Not CheckBox_link.Checked Then
                            If blessing > 0.75 Then
                                blessing = 0.75
                            End If
                            damageReduction = blessing
                        ElseIf CheckBox_link.Checked And CheckBox_blessing.Checked Then
                            If blessing > 0.75 Then
                                blessing = 0.75
                            End If
                            damageReduction = blessing + ((1 - blessing) * link)
                        End If
                    Case "Valkyr"
                        If CheckBox_warcry.Checked Then
                            Dim warcryMultiplier As Decimal = 0.5 * powerStrength
                            armorMultiplier = armorMultiplier + warcryMultiplier
                        End If
                    Case "Vauban"
                        If CheckBox_reinforce.Checked Then
                            Dim reinforceMultiplier As Decimal = 0.25 * NumericUpDown_reinforce.Value
                            armorMultiplier = armorMultiplier + reinforceMultiplier
                        End If
                End Select
            End If
            '
            '   Calculate Values (with special support for Vex armor, Quickthinking and Gladiator Finesse)
            '
            If CheckBox_vexArmor.Checked And ComboBox_warframes.SelectedItem = "Chroma" And CheckBox_abilities.Checked Then
                Dim vexArmor As Decimal = 3.5
                '
                ' Old Chroma Buff  :'(
                '
                'Armor = ((baseArmor * (((1 + armorMultiplier) * vexArmor) * powerStrength)) + (Armor - baseArmor)) + armorBonus
                Armor = baseArmor * (1 + (armorMultiplier + (vexArmor * powerStrength))) + armorBonus
            Else
                Armor = ((baseArmor * (1 + armorMultiplier)) + (Armor - baseArmor)) + armorBonus
            End If
            Energy = Math.Ceiling(Energy) + Math.Floor((baseEnergy * energyMultiplier) + energyBonus)
            If CheckBox_survivability.Checked Then
                If CheckBox_quickThinking.Checked Then
                    healthBonus = healthBonus + ((0.4 * (1 + NumericUpDown_quickThinking.Value)) * Energy)
                End If
                If CheckBox_gladiatorFinesse.Checked Then
                    healthBonus = healthBonus + ((0.1 * (1 + NumericUpDown_gladiatorFinesse.Value)) * Energy)
                End If
            End If
            Health = ((baseHealth * (1 + healthMultiplier)) + (Health - baseHealth)) + healthBonus
            Shield = ((baseShield * (1 + shieldMultiplier)) + (Shield - baseShield)) + shieldBonus
            '
            '   Arcanes
            '
            If CheckBox_arcanes.Checked Then
                '
                '   Only allow 2 Arcanes max
                '
                Dim arcanes As New List(Of Control)
                Dim activeArcanes As Int16 = 0
                For Each arcane As CheckBox In FindControlRecursive(arcanes, GroupBox_arcanes, GetType(CheckBox))
                    If arcane.Checked Then
                        activeArcanes += 1
                    End If
                Next
                If activeArcanes = 2 Then
                    For Each arcane As CheckBox In FindControlRecursive(arcanes, GroupBox_arcanes, GetType(CheckBox))
                        If Not arcane.Checked Then
                            arcane.Enabled = False
                        End If
                    Next
                Else
                    For Each arcane As CheckBox In FindControlRecursive(arcanes, GroupBox_arcanes, GetType(CheckBox))
                        arcane.Enabled = True
                    Next
                End If
                '
                '   Arcane Effects
                '
                If CheckBox_arcaneGuardian.Checked Then
                    Armor = Armor + (150 + (150 * NumericUpDown_arcaneGuardian.Value))
                End If
                If CheckBox_arcaneGuardian2.Checked Then
                    Armor = Armor + (150 + (150 * NumericUpDown_arcaneGuardian2.Value))
                End If
                If CheckBox_arcaneUltimatum.Checked Then
                    Armor = Armor + (150 + (150 * NumericUpDown_arcaneUltimatum.Value))
                End If
                If CheckBox_arcaneUltimatum2.Checked Then
                    Armor = Armor + (150 + (150 * NumericUpDown_arcaneUltimatum2.Value))
                End If
                '
                '   Old Arcane Effects
                '
                'If CheckBox_arcaneGuardian.Checked And CheckBox_arcaneUltimatum.Checked Then
                '    Armor = Armor * (1 + ((0.15 * NumericUpDown_arcaneGuardian.Value) + (0.15 * NumericUpDown_arcaneUltimatum.Value)))
                'Else
                '    If CheckBox_arcaneGuardian.Checked Then
                '        Armor = Armor * (1 + (0.15 * NumericUpDown_arcaneGuardian.Value))
                '    End If
                '    If CheckBox_arcaneUltimatum.Checked Then
                '        Armor = Armor * (1 + (0.15 * NumericUpDown_arcaneUltimatum.Value))
                '    End If
                'End If
            End If
            '
            '   Dragon Keys
            '
            If CheckBox_dragonKeys.Checked Then
                If RadioButton_bleedingKey.Checked Then
                    Health = Health * 0.25
                ElseIf RadioButton_decayingKey.Checked Then
                    Shield = Shield * 0.25
                End If
            End If
            TextBox_warframeArmor.Text = Math.Floor(Armor)
            TextBox_warframeHealth.Text = Math.Floor(Health)
            TextBox_warframeShield.Text = Math.Floor(Shield)
            TextBox_warframeEnergy.Text = Math.Floor(Energy)
            TextBox_warframePowerStrength.Text = Math.Floor(powerStrength * 100)
            '
            '   Calculate EHP
            '
            Dim damageReductionArmor As Decimal = Armor / (300 + Armor)
            Dim totalDamageReduction As Decimal = damageReductionArmor + ((1 - damageReductionArmor) * damageReduction)
            Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield + damageAbsorbstion))
            TextBox_warframeEHP.Text = effectiveHealth
        Else
            '
            '   Disable Selections
            '
            CheckBox_aura.Enabled = False
            GroupBox_aura.Enabled = False
            CheckBox_survivability.Enabled = False
            GroupBox_survivability.Enabled = False
            CheckBox_miscellaneous.Enabled = False
            GroupBox_miscellaneous.Enabled = False
            CheckBox_power.Enabled = False
            GroupBox_power.Enabled = False
            CheckBox_arcanes.Enabled = False
            GroupBox_arcanes.Enabled = False
            CheckBox_dragonKeys.Enabled = False
            GroupBox_dragonKeys.Enabled = False
            CheckBox_focus.Enabled = False
            GroupBox_focus.Enabled = False
            CheckBox_specialEffects.Enabled = False
            GroupBox_specialEffects.Enabled = False
            CheckBox_sortieModifiers.Enabled = False
            GroupBox_sortieModifiers.Enabled = False
            CheckBox_abilities.Enabled = False
            CustomTabControl_abilitys.Enabled = False
            CheckBox_arcaneHelmets.Enabled = False
            CustomTabControl_arcaneHelmets.Enabled = False
            CheckBox_squadEffects.Enabled = False
            GroupBox_squadEffects.Enabled = False
            '
            '   No Warframe selected, display values should be set to default
            '
            TextBox_warframeArmor.Text = "-"
            TextBox_warframeHealth.Text = "-"
            TextBox_warframeShield.Text = "-"
            TextBox_warframeEnergy.Text = "-"
            TextBox_warframePowerStrength.Text = "-"
            TextBox_warframeEHP.Text = "-"
        End If
        Companion_Value_Changed(sender, e)
    End Sub

    Private Sub Companion_Value_Changed(sender As Object, e As EventArgs)
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
            Armor = formatNumber(ComboBox_petArmor)
            Health = formatNumber(ComboBox_petHealth)
            Shield = formatNumber(ComboBox_petShield)
            If NumericUpDown_companionStability.Enabled = True Then
                'genetic stability
                Health = Health * (1 + (NumericUpDown_companionStability.Value / 100))
            End If
            If ComboBox_warframes.SelectedItem = "Oberon" Then
                'Oberon Passive
                Armor = Armor + 75
                Health = Math.Floor(Health + (Health * 0.25))
                Shield = Math.Floor(Shield + (Shield * 0.25))
            End If
            If CheckBox_companionPrimeCollar.Enabled And CheckBox_companionPrimeCollar.Checked Then
                Armor = Armor + 100
                Health = Health + 10
                Shield = Shield + 10
            End If
            If CheckBox_companionSurvivability.Checked Then
                If CheckBox_companionLinkArmor.Checked = True Then
                    Armor = Math.Floor(Armor + (formatNumber(TextBox_warframeArmor) * ((NumericUpDown_companionLinkArmor.Value + 1) * 0.1)))
                End If
                If CheckBox_companionLinkHealth.Checked = True Then
                    Health = Math.Floor(Health + (formatNumber(TextBox_warframeHealth) * ((NumericUpDown_companionLinkHealth.Value + 1) * 0.15)))
                End If
                If CheckBox_companionLinkShield.Checked = True Then
                    Shield = Math.Floor(Shield + (formatNumber(TextBox_warframeShield) * ((NumericUpDown_companionLinkShield.Value + 1) * 0.1)))
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
