Public Class Main


    '
    '   TODO:\\ warframe abilities
    '   TODO:\\ hookup stats
    '   TODO:\\ hookup mods to affect stats
    '   TODO:\\ calculate EHP
    '   TODO:\\ everything in companions
    '


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        '   Hide Debug controls
        '
        TabControl_main.TabPages.Remove(TabPage_development)
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
        '
        ComboBox_warframes.SelectedIndex = 0
        ComboBox_baseArmor.SelectedIndex = 0
        ComboBox_armor.SelectedIndex = 0
        ComboBox_baseHealth.SelectedIndex = 0
        ComboBox_health.SelectedIndex = 0
        ComboBox_baseShield.SelectedIndex = 0
        ComboBox_shield.SelectedIndex = 0
        ComboBox_baseEnergy.SelectedIndex = 0
        ComboBox_energy.SelectedIndex = 0
        '   Primes
        ComboBox_primes.SelectedIndex = 0
        ComboBox_primeBaseArmor.SelectedIndex = 0
        ComboBox_primeArmor.SelectedIndex = 0
        ComboBox_primeBaseHealth.SelectedIndex = 0
        ComboBox_primeHealth.SelectedIndex = 0
        ComboBox_primeBaseShield.SelectedIndex = 0
        ComboBox_primeShield.SelectedIndex = 0
        ComboBox_primeBaseEnergy.SelectedIndex = 0
        ComboBox_primeEnergy.SelectedIndex = 0
        '   Umbra
        ComboBox_umbras.SelectedIndex = 0
        ComboBox_umbraBaseArmor.SelectedIndex = 0
        ComboBox_umbraArmor.SelectedIndex = 0
        ComboBox_umbraBaseHealth.SelectedIndex = 0
        ComboBox_umbraHealth.SelectedIndex = 0
        ComboBox_umbraBaseShield.SelectedIndex = 0
        ComboBox_umbraShield.SelectedIndex = 0
        ComboBox_umbraBaseEnergy.SelectedIndex = 0
        ComboBox_umbraEnergy.SelectedIndex = 0
        '   Pets
        ComboBox_pets.SelectedIndex = 0
        ComboBox_petArmor.SelectedIndex = 0
        ComboBox_petHealth.SelectedIndex = 0
        ComboBox_petShield.SelectedIndex = 0
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
        '   Overshields
        '
        AddHandler CheckBox_oversheilds.CheckedChanged, AddressOf Enable_Disable_Section
        '
        '   Arcane Helmets
        '
        AddHandler CheckBox_arcaneHelmets.CheckedChanged, AddressOf Enable_Disable_Section
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
        TabPage_warframe.Controls(sender.tag).Enabled = sender.Checked
    End Sub

    Private Sub ComboBox_warframes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_warframes.SelectedIndexChanged
        '
        '   Set warframe to calculate for
        '
        If ComboBox_warframes.SelectedIndex > 0 Then
            '
            '   Arcane Helmet Selection
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
                    CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsDefault
            End Select
        Else
            '
            '   No Warframe Selected
            '
            CheckBox_arcaneHelmets.Enabled = False
            CustomTabControl_arcaneHelmets.SelectedTab = TabPage_arcaneHelmetsDefault
            CheckBox_abilities.Enabled = False
            CustomTabControl_abilitys.SelectedTab = TabPage_abilitiesDefault
        End If
    End Sub

End Class
