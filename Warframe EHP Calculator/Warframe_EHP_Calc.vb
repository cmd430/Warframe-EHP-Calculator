Public Class Warframe_EHP_Calc

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

    Private Sub Warframe_EHP_Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide Dev stuff
        Size = New Point(797, 652)
        'ComboBoxs
        Dim ComboBoxs As New List(Of Control)
        For Each combo_box As ComboBox In FindControlRecursive(ComboBoxs, Me, GetType(ComboBox))
            combo_box.SelectedIndex = 0
        Next
        AddHandler cb_frame.SelectedIndexChanged, AddressOf Values_Changed
        AddHandler cb_pet.SelectedIndexChanged, AddressOf Values_Changed
        'CheckBoxs
        Dim CheckBoxs As New List(Of Control)
        For Each check_box As CheckBox In FindControlRecursive(CheckBoxs, Me, GetType(CheckBox))
            If check_box.Name = "wf_hpconvert" Then
                check_box.Tag = check_box.Name & "_val|" & check_box.Name & "_stacks"
            Else
                check_box.Tag = check_box.Name & "_val"
            End If
            AddHandler check_box.CheckedChanged, AddressOf Selected_Mods
        Next
        'NumericUpDowns
        Dim NumericUpDowns As New List(Of Control)
        For Each numeric_up_down As NumericUpDown In FindControlRecursive(NumericUpDowns, Me, GetType(NumericUpDown))
            AddHandler numeric_up_down.ValueChanged, AddressOf Values_Changed
        Next
        'RadioButtons
        Dim RadioButtons As New List(Of Control)
        For Each radio_button As RadioButton In FindControlRecursive(RadioButtons, Me, GetType(RadioButton))
            AddHandler radio_button.CheckedChanged, AddressOf Values_Changed
        Next
    End Sub

    Private Sub Values_Changed(sender As Object, e As EventArgs)
        If cb_primes.Items.Contains(cb_frame.SelectedItem) Then
            wf_prime.Enabled = True
        Else
            wf_prime.Enabled = False
        End If
        If cb_pet.SelectedIndex > 2 Then
            prime_collar.Enabled = True
        Else
            prime_collar.Enabled = False
        End If
        Dim ComboBoxs As New List(Of Control)
        If wf_prime.Enabled And wf_prime.Checked Then
            cb_primes.SelectedItem = cb_frame.SelectedItem
            For Each combo_box As ComboBox In FindControlRecursive(ComboBoxs, Me, GetType(ComboBox))
                If combo_box.Name IsNot "cb_frame" And combo_box.Name IsNot "cb_pet" And combo_box.Name IsNot "cb_primes" And Not combo_box.Name.Contains("_pet") And combo_box.Name.Contains("prime_") Then
                    combo_box.SelectedIndex = cb_primes.SelectedIndex
                End If
            Next
        Else
            For Each combo_box As ComboBox In FindControlRecursive(ComboBoxs, Me, GetType(ComboBox))
                If combo_box.Name IsNot "cb_frame" And combo_box.Name IsNot "cb_pet" And combo_box.Name IsNot "cb_primes" And Not combo_box.Name.Contains("_pet") And Not combo_box.Name.Contains("prime") Then
                    combo_box.SelectedIndex = cb_frame.SelectedIndex
                End If
            Next
        End If
        For Each combo_box As ComboBox In FindControlRecursive(ComboBoxs, Me, GetType(ComboBox))
            If combo_box.Name IsNot "cb_pet" And combo_box.Name.Contains("_pet") Then
                combo_box.SelectedIndex = cb_pet.SelectedIndex
            End If
        Next
        Dim wf_armor_base As Decimal = 0
        Dim wf_health_base As Decimal = 0
        Dim wf_sheild_base As Decimal = 0
        Dim wf_power_base As Decimal = 0
        Dim wf_armor As Decimal = 0
        Dim wf_health As Decimal = 0
        Dim wf_sheild As Decimal = 0
        Dim wf_power As Decimal = 0
        Dim ArmorMulti As Decimal = 0
        Dim HealthMulti As Decimal = 0
        Dim SheildMulti As Decimal = 0
        Dim PowerMulti As Decimal = 0
        Dim DamageRedux As Decimal = 0
        Dim EHP As Decimal = 0
        Dim Armor_DamageRedux_Pet As Decimal = 0
        If cb_frame.SelectedIndex > 0 Then
            If wf_prime.Enabled And wf_prime.Checked Then
                wf_armor_base = Convert.ToDecimal(prime_base_armor.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_health_base = Convert.ToDecimal(prime_base_health.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_sheild_base = Convert.ToDecimal(prime_base_shield.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_power_base = Convert.ToDecimal(prime_base_power.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_armor = Convert.ToDecimal(prime_armor.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_health = Convert.ToDecimal(prime_health.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_sheild = Convert.ToDecimal(prime_shield.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_power = Convert.ToDecimal(prime_power.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
            Else
                wf_armor_base = Convert.ToDecimal(cb_base_armor.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_health_base = Convert.ToDecimal(cb_base_health.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_sheild_base = Convert.ToDecimal(cb_base_shield.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_power_base = Convert.ToDecimal(cb_base_power.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_armor = Convert.ToDecimal(cb_armor.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_health = Convert.ToDecimal(cb_health.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_sheild = Convert.ToDecimal(cb_shield.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
                wf_power = Convert.ToDecimal(cb_power.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
            End If
        End If
        'arcane helmets
        If cb_frame.SelectedItem = "Ash" Then
            If ash_panel.Visible = False Then
                ash_panel.BringToFront()
                ash_panel.Visible = True
                ash_None.Checked = True
            End If
            If ash_Locust.Checked Then
                wf_power = wf_power + (wf_power_base * 0.2)
            End If
        Else
            ash_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Banshee" Then
            If banshee_panel.Visible = False Then
                banshee_panel.BringToFront()
                banshee_panel.Visible = True
                banshee_None.Checked = True
            End If
            If banshee_Reverb.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
                wf_power = wf_power + (wf_power_base * 0.1)
            End If
        Else
            banshee_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Ember" Then
            If ember_panel.Visible = False Then
                ember_panel.BringToFront()
                ember_panel.Visible = True
                ember_None.Checked = True
            End If
            If ember_Phoenix.Checked Then
                wf_sheild = wf_sheild + (wf_sheild_base * 0.05)
                wf_power = wf_power + (wf_power_base * 0.25)
            ElseIf ember_Backdraft.Checked Then
                wf_health = wf_health + (wf_health_base * 0.15)
            End If
        Else
            ember_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Excalibur" Then
            If excalibur_panel.Visible = False Then
                excalibur_panel.BringToFront()
                excalibur_panel.Visible = True
                excalibur_None.Checked = True
            End If
            If excalibur_Avalon.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
                wf_sheild = wf_sheild + (wf_sheild_base * 0.25)
            ElseIf excalibur_Pendragon.Checked Then
                wf_armor = wf_armor - (wf_armor_base * 0.05)
            End If
        Else
            excalibur_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Frost" Then
            If frost_panel.Visible = False Then
                frost_panel.BringToFront()
                frost_panel.Visible = True
                frost_None.Checked = True
            End If
            If frost_Aurora.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
                wf_armor = wf_armor + (wf_armor_base * 0.25)
            ElseIf frost_Squall.Checked Then
                wf_sheild = wf_sheild - (wf_sheild_base * 0.05)
            End If
        Else
            frost_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Loki" Then
            If loki_panel.Visible = False Then
                loki_panel.BringToFront()
                loki_panel.Visible = True
                loki_None.Checked = True
            End If
            If loki_Essence.Checked Then
                wf_armor = wf_armor - (wf_armor_base * 0.05)
            ElseIf loki_Swindle.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
            End If
        Else
            loki_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Mag" Then
            If mag_panel.Visible = False Then
                mag_panel.BringToFront()
                mag_panel.Visible = True
                mag_None.Checked = True
            End If
            If mag_Coil.Checked Then
                wf_sheild = wf_sheild - (wf_sheild_base * 0.05)
            ElseIf mag_Gauss.Checked Then
                wf_power = wf_power + (wf_power_base * 0.25)
            End If
        Else
            mag_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Nova" Then
            If nova_panel.Visible = False Then
                nova_panel.BringToFront()
                nova_panel.Visible = True
                nova_None.Checked = True
            End If
            If nova_Flux.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
            End If
        Else
            nova_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Nyx" Then
            If nyx_panel.Visible = False Then
                nyx_panel.BringToFront()
                nyx_panel.Visible = True
                nyx_None.Checked = True
            End If
            If nyx_Menticide.Checked Then
                wf_sheild = wf_sheild - (wf_sheild_base * 0.05)
            ElseIf nyx_Vespa.Checked Then
                wf_armor = wf_armor - (wf_armor_base * 0.05)
            End If
        Else
            nyx_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Rhino" Then
            If rhino_panel.Visible = False Then
                rhino_panel.BringToFront()
                rhino_panel.Visible = True
                rhino_None.Checked = True
            End If
            If rhino_Thrak.Checked Then
                wf_health = wf_health + (wf_health_base * 0.25)
            End If
        Else
            rhino_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Saryn" Then
            If saryn_panel.Visible = False Then
                saryn_panel.BringToFront()
                saryn_panel.Visible = True
                saryn_None.Checked = True
            End If
            If saryn_Hemlock.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
            End If
        Else
            saryn_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Trinity" Then
            If trinity_panel.Visible = False Then
                trinity_panel.BringToFront()
                trinity_panel.Visible = True
                trinity_None.Checked = True
            End If
            If trinity_Aura.Checked Then
                wf_health = wf_health - (wf_health_base * 0.05)
            ElseIf trinity_Meridian.Checked Then
                wf_sheild = wf_sheild + (wf_sheild_base * 0.15)
            End If
        Else
            trinity_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Vauban" Then
            If vauban_panel.Visible = False Then
                vauban_panel.BringToFront()
                vauban_panel.Visible = True
                vauban_None.Checked = True
            End If
            If vauban_Esprit.Checked Then
                wf_sheild = wf_sheild - (wf_sheild_base * 0.1)
                wf_power = wf_power + (wf_power_base * 0.1)
            End If
        Else
            vauban_panel.Visible = False
        End If
        If cb_frame.SelectedItem = "Volt" Then
            If volt_panel.Visible = False Then
                volt_panel.BringToFront()
                volt_panel.Visible = True
                volt_None.Checked = True
            End If
            If volt_Pulse.Checked Then
                wf_sheild = wf_sheild - (wf_sheild_base * 0.05)
            End If
        Else
            volt_panel.Visible = False
        End If
        'Mods
        If wf_physique.Checked Then
            HealthMulti = HealthMulti + (0.03 + (wf_physique_val.Value * 0.03))
            If wf_coaction.Checked Then
                HealthMulti = HealthMulti + (HealthMulti * (0.025 + (0.025 * wf_coaction_val.Value))) '15% Str
                HealthMulti = HealthMulti + (HealthMulti * (0.025 + (0.025 * wf_coaction_val.Value))) '15% Eff
            End If
        End If
        If wf_standunited.Checked Then
            ArmorMulti = ArmorMulti + (0.0425 + (wf_standunited_val.Value * 0.0425))
            If wf_coaction.Checked Then
                ArmorMulti = ArmorMulti + (ArmorMulti * (0.025 + (0.025 * wf_coaction_val.Value))) '15% Str
                ArmorMulti = ArmorMulti + (ArmorMulti * (0.025 + (0.025 * wf_coaction_val.Value))) '15% Eff
            End If
        End If
        If wf_vitality.Checked Then
            HealthMulti = HealthMulti + (0.4 + (wf_vitality_val.Value * 0.4))
        End If
        If wf_vigor.Checked Then
            HealthMulti = HealthMulti + (0.2 + (wf_vigor_val.Value * 0.2))
            SheildMulti = SheildMulti + (0.2 + (wf_vigor_val.Value * 0.2))
        End If
        If wf_redirection.Checked Then
            SheildMulti = SheildMulti + (0.4 + (wf_redirection_val.Value * 0.4))
        End If
        If wf_steelfiber.Checked Then
            ArmorMulti = ArmorMulti + (0.1 + (wf_steelfiber_val.Value * 0.1))
        End If
        If wf_armoredagility.Checked Then
            ArmorMulti = ArmorMulti + (0.075 + (wf_armoredagility_val.Value * 0.075))
        End If
        If wf_flow.Checked Then
            PowerMulti = PowerMulti + (0.25 + wf_flow_val.Value * 0.25)
        End If
        If wf_endurance.Checked Then
            PowerMulti = PowerMulti + (0.025 + (wf_endurance_val.Value * 0.025))
        End If
        wf_armor = (wf_armor - wf_armor_base) + Math.Floor(wf_armor_base * (1 + ArmorMulti))
        wf_health = Math.Floor((wf_health_base * (1 + HealthMulti)) + (wf_health - wf_health_base))
        wf_sheild = Math.Floor((wf_sheild_base * (1 + SheildMulti)) + (wf_sheild - wf_sheild_base))
        wf_power = Math.Ceiling(wf_power) + Math.Floor(wf_power_base * PowerMulti)
        If wf_hpconvert.Checked Then
            wf_armor = (wf_armor + ((75 + (wf_hpconvert_val.Value * 75)) * wf_hpconvert_stacks.Value))
        End If
        If x_armor.Checked Then
            wf_armor = wf_armor + x_armor_val.Value
        End If
        If x_health.Checked Then
            wf_health = wf_health + x_health_val.Value
        End If
        If x_shield.Checked Then
            wf_sheild = wf_sheild + x_shield_val.Value
        End If
        'arcanes
        If arcane_guardian.Checked And arcane_ultimatum.Checked Then
            wf_armor = wf_armor * (1 + ((0.15 * arcane_guardian_val.Value) + (0.15 * arcane_ultimatum_val.Value)))
        Else
            If arcane_guardian.Checked Then
                wf_armor = wf_armor * (1 + (0.15 * arcane_guardian_val.Value))
            End If
            If arcane_ultimatum.Checked Then
                wf_armor = wf_armor * (1 + (0.15 * arcane_ultimatum_val.Value))
            End If
        End If
        'keys
        If key_bleeding.Checked Then
            wf_health = wf_health * 0.25
        End If
        If key_decaying.Checked Then
            wf_sheild = wf_sheild * 0.25
        End If
        If wf_quickthinking.Checked = True Then
            'DMG Reduc.
            '   Armor / 300 + Armor = Reduc%
            'EHP 
            '   HP / 1 - DMG Redux = EHP
            Dim qtHealth As Decimal = (wf_health + ((0.4 * (wf_quickthinking_val.Value + 1)) * wf_power))
            Dim Armor_DamageRedux As Decimal = wf_armor / (300 + wf_armor)
            If wf_dmgreduc.Checked Then
                DamageRedux = Convert.ToDecimal(wf_dmgreduc_val.Value, New Globalization.CultureInfo("en-US"))
            End If
            EHP = ((qtHealth / (1 - Armor_DamageRedux)) / (1 - (DamageRedux / 100)))
            wf_ehp.Text = Math.Ceiling(EHP + wf_sheild)
        Else
            'DMG Reduc.
            '   Armor / 300 + Armor = Reduc%
            'EHP 
            '   HP / 1 - DMG Redux = EHP
            Dim Armor_DamageRedux As Decimal = wf_armor / (300 + wf_armor)
            If wf_dmgreduc.Checked Then
                DamageRedux = Convert.ToDecimal(wf_dmgreduc_val.Value, New Globalization.CultureInfo("en-US"))
            End If
            EHP = ((wf_health / (1 - Armor_DamageRedux)) / (1 - (DamageRedux / 100)))
            wf_ehp.Text = Math.Ceiling(EHP + wf_sheild)
        End If
        frame_armor.Text = Math.Floor(wf_armor)
        frame_health.Text = Math.Floor(wf_health)
        frame_sheild.Text = Math.Floor(wf_sheild)
        frame_power.Text = Math.Floor(wf_power)
        'PETS
        Dim p_armor As Decimal = 0
        Dim p_health As Decimal = 0
        Dim p_sheild As Decimal = 0
        Dim p_ehp As Decimal = 0
        If cb_pet.SelectedIndex > 0 Then
            p_armor = Convert.ToDecimal(cb_armor_pet.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
            p_health = Convert.ToDecimal(cb_health_pet.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
            p_sheild = Convert.ToDecimal(cb_shield_pet.SelectedItem.ToString.Split("_")(0), New Globalization.CultureInfo("en-US"))
            If cb_frame.SelectedItem = "Oberon" Then
                'Oberon Passive
                p_armor = p_armor + 75
                p_health = Math.Floor(p_health + (p_health * 0.25))
                p_sheild = Math.Floor(p_sheild + (p_sheild * 0.25))
            End If
            If link_armor.Checked = True Then
                p_armor = Math.Floor(p_armor + (wf_armor * ((link_armor_val.Value + 1) * 0.1)))
            End If
            If link_health.Checked = True Then
                p_health = Math.Floor(p_health + (wf_health * ((link_health_val.Value + 1) * 0.15)))
            End If
            If link_sheild.Checked = True Then
                p_sheild = Math.Floor(p_sheild + (wf_sheild * ((link_sheild_val.Value + 1) * 0.1)))
            End If
        End If
        If prime_collar.Enabled And prime_collar.Checked Then
            p_armor = p_armor + 100
            p_health = p_health + 10
            p_sheild = p_sheild + 10
        End If
        'DMG Reduc.
        '   Armor / 300 + Armor = Reduc%
        'EHP 
        '   HP / 1 - DMG Redux = EHP
        Armor_DamageRedux_Pet = p_armor / (300 + p_armor)
        p_ehp = (p_health / (1 - Armor_DamageRedux_Pet)) + p_sheild
        pet_ehp.Text = Math.Ceiling(p_ehp)
        pet_armor.Text = Math.Floor(p_armor)
        pet_health.Text = Math.Floor(p_health)
        pet_sheild.Text = Math.Floor(p_sheild)
    End Sub

    Private Sub Selected_Mods(sender As Object, e As EventArgs)
        Dim matches() As Control
        If sender.Tag.ToString().Contains("|") Then
            matches = Controls.Find(sender.Tag.ToString().Split("|")(0), True)
            If matches.Length > 0 AndAlso TypeOf matches(0) Is NumericUpDown Then
                Dim value As NumericUpDown = DirectCast(matches(0), NumericUpDown)
                value.Enabled = sender.Checked
            End If
            matches = Controls.Find(sender.Tag.ToString().Split("|")(1), True)
            If matches.Length > 0 AndAlso TypeOf matches(0) Is NumericUpDown Then
                Dim stack As NumericUpDown = DirectCast(matches(0), NumericUpDown)
                stack.Enabled = sender.Checked
            End If
        Else
            matches = Controls.Find(sender.Tag.ToString(), True)
            If matches.Length > 0 AndAlso TypeOf matches(0) Is NumericUpDown Then
                Dim value As NumericUpDown = DirectCast(matches(0), NumericUpDown)
                value.Enabled = sender.Checked
            End If
        End If
        Values_Changed(sender, e)
    End Sub

End Class
