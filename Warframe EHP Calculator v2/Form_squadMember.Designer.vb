<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_squadMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_squadMember))
        Me.Button_squadApply = New System.Windows.Forms.Button()
        Me.Button_squadCancel = New System.Windows.Forms.Button()
        Me.TextBox_squadInfo = New System.Windows.Forms.TextBox()
        Me.Label_squadAura = New System.Windows.Forms.Label()
        Me.ComboBox_squadAura = New System.Windows.Forms.ComboBox()
        Me.CustomTabControl_squadAbilitys = New Warframe_EHP_Calculator_v2.CustomTabControl()
        Me.TabPage_squadChroma = New System.Windows.Forms.TabPage()
        Me.Label_squadElementalWard = New System.Windows.Forms.Label()
        Me.CheckBox_squadElementalWard = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadEquinox = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadPeacefulProvocation = New System.Windows.Forms.CheckBox()
        Me.CheckBox_squadPasifyAndProvoke = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadMirage = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadTotalEclipse = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadNezha = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_squadSafeGuard = New System.Windows.Forms.NumericUpDown()
        Me.Label_squadSafeguardArmor = New System.Windows.Forms.Label()
        Me.CheckBox_squadSafeguard = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadNidus = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadParasiticLink = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadOberon = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadHallowedReckoning = New System.Windows.Forms.CheckBox()
        Me.CheckBox_squadIronRenewal = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadOctavia = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadMetronome = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadTitania = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadThorns = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadTrinity = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadBlessing = New System.Windows.Forms.CheckBox()
        Me.TabPage_squadValkyr = New System.Windows.Forms.TabPage()
        Me.CheckBox_squadWarcry = New System.Windows.Forms.CheckBox()
        Me.Label_squadWarframe = New System.Windows.Forms.Label()
        Me.ComboBox_squadWarframe = New System.Windows.Forms.ComboBox()
        Me.Label_squadPowerStrength = New System.Windows.Forms.Label()
        Me.NumericUpDown_squadPowerStrength = New System.Windows.Forms.NumericUpDown()
        Me.Label_squadPowerStrengthPercent = New System.Windows.Forms.Label()
        Me.CustomTabControl_squadAbilitys.SuspendLayout()
        Me.TabPage_squadChroma.SuspendLayout()
        Me.TabPage_squadEquinox.SuspendLayout()
        Me.TabPage_squadMirage.SuspendLayout()
        Me.TabPage_squadNezha.SuspendLayout()
        CType(Me.NumericUpDown_squadSafeGuard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_squadNidus.SuspendLayout()
        Me.TabPage_squadOberon.SuspendLayout()
        Me.TabPage_squadOctavia.SuspendLayout()
        Me.TabPage_squadTitania.SuspendLayout()
        Me.TabPage_squadTrinity.SuspendLayout()
        Me.TabPage_squadValkyr.SuspendLayout()
        CType(Me.NumericUpDown_squadPowerStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_squadApply
        '
        Me.Button_squadApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_squadApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button_squadApply.Location = New System.Drawing.Point(226, 186)
        Me.Button_squadApply.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_squadApply.Name = "Button_squadApply"
        Me.Button_squadApply.Size = New System.Drawing.Size(100, 28)
        Me.Button_squadApply.TabIndex = 1
        Me.Button_squadApply.Text = "Apply"
        Me.Button_squadApply.UseVisualStyleBackColor = True
        '
        'Button_squadCancel
        '
        Me.Button_squadCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_squadCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button_squadCancel.Location = New System.Drawing.Point(335, 186)
        Me.Button_squadCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_squadCancel.Name = "Button_squadCancel"
        Me.Button_squadCancel.Size = New System.Drawing.Size(100, 28)
        Me.Button_squadCancel.TabIndex = 2
        Me.Button_squadCancel.Text = "Cancel"
        Me.Button_squadCancel.UseVisualStyleBackColor = True
        '
        'TextBox_squadInfo
        '
        Me.TextBox_squadInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_squadInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TextBox_squadInfo.Location = New System.Drawing.Point(13, 192)
        Me.TextBox_squadInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_squadInfo.Name = "TextBox_squadInfo"
        Me.TextBox_squadInfo.ReadOnly = True
        Me.TextBox_squadInfo.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_squadInfo.TabIndex = 3
        Me.TextBox_squadInfo.Visible = False
        '
        'Label_squadAura
        '
        Me.Label_squadAura.AutoSize = True
        Me.Label_squadAura.BackColor = System.Drawing.SystemColors.Control
        Me.Label_squadAura.Location = New System.Drawing.Point(16, 48)
        Me.Label_squadAura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_squadAura.Name = "Label_squadAura"
        Me.Label_squadAura.Size = New System.Drawing.Size(42, 17)
        Me.Label_squadAura.TabIndex = 6
        Me.Label_squadAura.Text = "Aura:"
        '
        'ComboBox_squadAura
        '
        Me.ComboBox_squadAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_squadAura.FormattingEnabled = True
        Me.ComboBox_squadAura.Items.AddRange(New Object() {"None", "Growing Power", "Physique", "Stand United"})
        Me.ComboBox_squadAura.Location = New System.Drawing.Point(153, 44)
        Me.ComboBox_squadAura.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_squadAura.Name = "ComboBox_squadAura"
        Me.ComboBox_squadAura.Size = New System.Drawing.Size(282, 24)
        Me.ComboBox_squadAura.TabIndex = 5
        '
        'CustomTabControl_squadAbilitys
        '
        Me.CustomTabControl_squadAbilitys.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadChroma)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadEquinox)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadMirage)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadNezha)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadNidus)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadOberon)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadOctavia)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadTitania)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadTrinity)
        Me.CustomTabControl_squadAbilitys.Controls.Add(Me.TabPage_squadValkyr)
        Me.CustomTabControl_squadAbilitys.Location = New System.Drawing.Point(11, 104)
        Me.CustomTabControl_squadAbilitys.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomTabControl_squadAbilitys.Name = "CustomTabControl_squadAbilitys"
        Me.CustomTabControl_squadAbilitys.SelectedIndex = 0
        Me.CustomTabControl_squadAbilitys.Size = New System.Drawing.Size(435, 80)
        Me.CustomTabControl_squadAbilitys.TabIndex = 7
        '
        'TabPage_squadChroma
        '
        Me.TabPage_squadChroma.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadChroma.Controls.Add(Me.Label_squadElementalWard)
        Me.TabPage_squadChroma.Controls.Add(Me.CheckBox_squadElementalWard)
        Me.TabPage_squadChroma.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadChroma.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadChroma.Name = "TabPage_squadChroma"
        Me.TabPage_squadChroma.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadChroma.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadChroma.TabIndex = 1
        Me.TabPage_squadChroma.Text = "Chroma"
        '
        'Label_squadElementalWard
        '
        Me.Label_squadElementalWard.AutoSize = True
        Me.Label_squadElementalWard.Location = New System.Drawing.Point(127, 8)
        Me.Label_squadElementalWard.Name = "Label_squadElementalWard"
        Me.Label_squadElementalWard.Size = New System.Drawing.Size(46, 17)
        Me.Label_squadElementalWard.TabIndex = 1
        Me.Label_squadElementalWard.Text = "(Cold)"
        '
        'CheckBox_squadElementalWard
        '
        Me.CheckBox_squadElementalWard.AutoSize = True
        Me.CheckBox_squadElementalWard.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadElementalWard.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadElementalWard.Name = "CheckBox_squadElementalWard"
        Me.CheckBox_squadElementalWard.Size = New System.Drawing.Size(127, 21)
        Me.CheckBox_squadElementalWard.TabIndex = 0
        Me.CheckBox_squadElementalWard.Text = "Elemental Ward"
        Me.CheckBox_squadElementalWard.UseVisualStyleBackColor = True
        '
        'TabPage_squadEquinox
        '
        Me.TabPage_squadEquinox.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage_squadEquinox.Controls.Add(Me.CheckBox_squadPeacefulProvocation)
        Me.TabPage_squadEquinox.Controls.Add(Me.CheckBox_squadPasifyAndProvoke)
        Me.TabPage_squadEquinox.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadEquinox.Name = "TabPage_squadEquinox"
        Me.TabPage_squadEquinox.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadEquinox.TabIndex = 10
        Me.TabPage_squadEquinox.Text = "Equinox"
        '
        'CheckBox_squadPeacefulProvocation
        '
        Me.CheckBox_squadPeacefulProvocation.AutoSize = True
        Me.CheckBox_squadPeacefulProvocation.Enabled = False
        Me.CheckBox_squadPeacefulProvocation.Location = New System.Drawing.Point(25, 32)
        Me.CheckBox_squadPeacefulProvocation.Name = "CheckBox_squadPeacefulProvocation"
        Me.CheckBox_squadPeacefulProvocation.Size = New System.Drawing.Size(161, 21)
        Me.CheckBox_squadPeacefulProvocation.TabIndex = 1
        Me.CheckBox_squadPeacefulProvocation.Text = "Peaceful Provocation"
        Me.CheckBox_squadPeacefulProvocation.UseVisualStyleBackColor = True
        '
        'CheckBox_squadPasifyAndProvoke
        '
        Me.CheckBox_squadPasifyAndProvoke.AutoSize = True
        Me.CheckBox_squadPasifyAndProvoke.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox_squadPasifyAndProvoke.Name = "CheckBox_squadPasifyAndProvoke"
        Me.CheckBox_squadPasifyAndProvoke.Size = New System.Drawing.Size(134, 21)
        Me.CheckBox_squadPasifyAndProvoke.TabIndex = 0
        Me.CheckBox_squadPasifyAndProvoke.Text = "Pasify && Provoke"
        Me.CheckBox_squadPasifyAndProvoke.UseVisualStyleBackColor = True
        '
        'TabPage_squadMirage
        '
        Me.TabPage_squadMirage.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadMirage.Controls.Add(Me.CheckBox_squadTotalEclipse)
        Me.TabPage_squadMirage.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadMirage.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadMirage.Name = "TabPage_squadMirage"
        Me.TabPage_squadMirage.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadMirage.TabIndex = 2
        Me.TabPage_squadMirage.Text = "Mirage"
        '
        'CheckBox_squadTotalEclipse
        '
        Me.CheckBox_squadTotalEclipse.AutoSize = True
        Me.CheckBox_squadTotalEclipse.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadTotalEclipse.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadTotalEclipse.Name = "CheckBox_squadTotalEclipse"
        Me.CheckBox_squadTotalEclipse.Size = New System.Drawing.Size(108, 21)
        Me.CheckBox_squadTotalEclipse.TabIndex = 1
        Me.CheckBox_squadTotalEclipse.Text = "Total Eclipse"
        Me.CheckBox_squadTotalEclipse.UseVisualStyleBackColor = True
        '
        'TabPage_squadNezha
        '
        Me.TabPage_squadNezha.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadNezha.Controls.Add(Me.NumericUpDown_squadSafeGuard)
        Me.TabPage_squadNezha.Controls.Add(Me.Label_squadSafeguardArmor)
        Me.TabPage_squadNezha.Controls.Add(Me.CheckBox_squadSafeguard)
        Me.TabPage_squadNezha.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadNezha.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadNezha.Name = "TabPage_squadNezha"
        Me.TabPage_squadNezha.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadNezha.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadNezha.TabIndex = 3
        Me.TabPage_squadNezha.Text = "Nezha"
        '
        'NumericUpDown_squadSafeGuard
        '
        Me.NumericUpDown_squadSafeGuard.Location = New System.Drawing.Point(304, 31)
        Me.NumericUpDown_squadSafeGuard.Maximum = New Decimal(New Integer() {1845, 0, 0, 0})
        Me.NumericUpDown_squadSafeGuard.Minimum = New Decimal(New Integer() {175, 0, 0, 0})
        Me.NumericUpDown_squadSafeGuard.Name = "NumericUpDown_squadSafeGuard"
        Me.NumericUpDown_squadSafeGuard.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown_squadSafeGuard.TabIndex = 3
        Me.NumericUpDown_squadSafeGuard.Value = New Decimal(New Integer() {175, 0, 0, 0})
        '
        'Label_squadSafeguardArmor
        '
        Me.Label_squadSafeguardArmor.AutoSize = True
        Me.Label_squadSafeguardArmor.Location = New System.Drawing.Point(6, 33)
        Me.Label_squadSafeguardArmor.Name = "Label_squadSafeguardArmor"
        Me.Label_squadSafeguardArmor.Size = New System.Drawing.Size(105, 17)
        Me.Label_squadSafeguardArmor.TabIndex = 2
        Me.Label_squadSafeguardArmor.Text = "Nezha's Armor:"
        '
        'CheckBox_squadSafeguard
        '
        Me.CheckBox_squadSafeguard.AutoSize = True
        Me.CheckBox_squadSafeguard.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadSafeguard.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadSafeguard.Name = "CheckBox_squadSafeguard"
        Me.CheckBox_squadSafeguard.Size = New System.Drawing.Size(93, 21)
        Me.CheckBox_squadSafeguard.TabIndex = 1
        Me.CheckBox_squadSafeguard.Text = "Safeguard"
        Me.CheckBox_squadSafeguard.UseVisualStyleBackColor = True
        '
        'TabPage_squadNidus
        '
        Me.TabPage_squadNidus.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadNidus.Controls.Add(Me.CheckBox_squadParasiticLink)
        Me.TabPage_squadNidus.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadNidus.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadNidus.Name = "TabPage_squadNidus"
        Me.TabPage_squadNidus.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadNidus.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadNidus.TabIndex = 4
        Me.TabPage_squadNidus.Text = "Nidus"
        '
        'CheckBox_squadParasiticLink
        '
        Me.CheckBox_squadParasiticLink.AutoSize = True
        Me.CheckBox_squadParasiticLink.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadParasiticLink.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadParasiticLink.Name = "CheckBox_squadParasiticLink"
        Me.CheckBox_squadParasiticLink.Size = New System.Drawing.Size(111, 21)
        Me.CheckBox_squadParasiticLink.TabIndex = 0
        Me.CheckBox_squadParasiticLink.Text = "Parasitic Link"
        Me.CheckBox_squadParasiticLink.UseVisualStyleBackColor = True
        '
        'TabPage_squadOberon
        '
        Me.TabPage_squadOberon.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadOberon.Controls.Add(Me.CheckBox_squadHallowedReckoning)
        Me.TabPage_squadOberon.Controls.Add(Me.CheckBox_squadIronRenewal)
        Me.TabPage_squadOberon.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadOberon.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadOberon.Name = "TabPage_squadOberon"
        Me.TabPage_squadOberon.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadOberon.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadOberon.TabIndex = 5
        Me.TabPage_squadOberon.Text = "Oberon"
        '
        'CheckBox_squadHallowedReckoning
        '
        Me.CheckBox_squadHallowedReckoning.AutoSize = True
        Me.CheckBox_squadHallowedReckoning.Location = New System.Drawing.Point(8, 34)
        Me.CheckBox_squadHallowedReckoning.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadHallowedReckoning.Name = "CheckBox_squadHallowedReckoning"
        Me.CheckBox_squadHallowedReckoning.Size = New System.Drawing.Size(155, 21)
        Me.CheckBox_squadHallowedReckoning.TabIndex = 1
        Me.CheckBox_squadHallowedReckoning.Text = "Hallowed Reckoning"
        Me.CheckBox_squadHallowedReckoning.UseVisualStyleBackColor = True
        '
        'CheckBox_squadIronRenewal
        '
        Me.CheckBox_squadIronRenewal.AutoSize = True
        Me.CheckBox_squadIronRenewal.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadIronRenewal.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadIronRenewal.Name = "CheckBox_squadIronRenewal"
        Me.CheckBox_squadIronRenewal.Size = New System.Drawing.Size(109, 21)
        Me.CheckBox_squadIronRenewal.TabIndex = 0
        Me.CheckBox_squadIronRenewal.Text = "Iron Renewal"
        Me.CheckBox_squadIronRenewal.UseVisualStyleBackColor = True
        '
        'TabPage_squadOctavia
        '
        Me.TabPage_squadOctavia.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadOctavia.Controls.Add(Me.CheckBox_squadMetronome)
        Me.TabPage_squadOctavia.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadOctavia.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadOctavia.Name = "TabPage_squadOctavia"
        Me.TabPage_squadOctavia.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadOctavia.TabIndex = 6
        Me.TabPage_squadOctavia.Text = "Octavia"
        '
        'CheckBox_squadMetronome
        '
        Me.CheckBox_squadMetronome.AutoSize = True
        Me.CheckBox_squadMetronome.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadMetronome.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadMetronome.Name = "CheckBox_squadMetronome"
        Me.CheckBox_squadMetronome.Size = New System.Drawing.Size(98, 21)
        Me.CheckBox_squadMetronome.TabIndex = 1
        Me.CheckBox_squadMetronome.Text = "Metronome"
        Me.CheckBox_squadMetronome.UseVisualStyleBackColor = True
        '
        'TabPage_squadTitania
        '
        Me.TabPage_squadTitania.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadTitania.Controls.Add(Me.CheckBox_squadThorns)
        Me.TabPage_squadTitania.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadTitania.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadTitania.Name = "TabPage_squadTitania"
        Me.TabPage_squadTitania.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadTitania.TabIndex = 7
        Me.TabPage_squadTitania.Text = "Titania"
        '
        'CheckBox_squadThorns
        '
        Me.CheckBox_squadThorns.AutoSize = True
        Me.CheckBox_squadThorns.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadThorns.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadThorns.Name = "CheckBox_squadThorns"
        Me.CheckBox_squadThorns.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox_squadThorns.TabIndex = 1
        Me.CheckBox_squadThorns.Text = "Thorns"
        Me.CheckBox_squadThorns.UseVisualStyleBackColor = True
        '
        'TabPage_squadTrinity
        '
        Me.TabPage_squadTrinity.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadTrinity.Controls.Add(Me.CheckBox_squadBlessing)
        Me.TabPage_squadTrinity.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadTrinity.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadTrinity.Name = "TabPage_squadTrinity"
        Me.TabPage_squadTrinity.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadTrinity.TabIndex = 8
        Me.TabPage_squadTrinity.Text = "Trinity"
        '
        'CheckBox_squadBlessing
        '
        Me.CheckBox_squadBlessing.AutoSize = True
        Me.CheckBox_squadBlessing.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadBlessing.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadBlessing.Name = "CheckBox_squadBlessing"
        Me.CheckBox_squadBlessing.Size = New System.Drawing.Size(80, 21)
        Me.CheckBox_squadBlessing.TabIndex = 1
        Me.CheckBox_squadBlessing.Text = "Blessing"
        Me.CheckBox_squadBlessing.UseVisualStyleBackColor = True
        '
        'TabPage_squadValkyr
        '
        Me.TabPage_squadValkyr.BackColor = System.Drawing.Color.Transparent
        Me.TabPage_squadValkyr.Controls.Add(Me.CheckBox_squadWarcry)
        Me.TabPage_squadValkyr.Location = New System.Drawing.Point(0, 20)
        Me.TabPage_squadValkyr.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_squadValkyr.Name = "TabPage_squadValkyr"
        Me.TabPage_squadValkyr.Size = New System.Drawing.Size(435, 60)
        Me.TabPage_squadValkyr.TabIndex = 9
        Me.TabPage_squadValkyr.Text = "Valkyr"
        '
        'CheckBox_squadWarcry
        '
        Me.CheckBox_squadWarcry.AutoSize = True
        Me.CheckBox_squadWarcry.Location = New System.Drawing.Point(8, 7)
        Me.CheckBox_squadWarcry.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_squadWarcry.Name = "CheckBox_squadWarcry"
        Me.CheckBox_squadWarcry.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox_squadWarcry.TabIndex = 1
        Me.CheckBox_squadWarcry.Text = "Warcry"
        Me.CheckBox_squadWarcry.UseVisualStyleBackColor = True
        '
        'Label_squadWarframe
        '
        Me.Label_squadWarframe.AutoSize = True
        Me.Label_squadWarframe.BackColor = System.Drawing.SystemColors.Control
        Me.Label_squadWarframe.Location = New System.Drawing.Point(15, 18)
        Me.Label_squadWarframe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_squadWarframe.Name = "Label_squadWarframe"
        Me.Label_squadWarframe.Size = New System.Drawing.Size(74, 17)
        Me.Label_squadWarframe.TabIndex = 9
        Me.Label_squadWarframe.Text = "Warframe:"
        '
        'ComboBox_squadWarframe
        '
        Me.ComboBox_squadWarframe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_squadWarframe.FormattingEnabled = True
        Me.ComboBox_squadWarframe.Items.AddRange(New Object() {"Chroma", "Equinox", "Mirage", "Nezha", "Nidus", "Oberon", "Titania", "Trinity", "Valkyr"})
        Me.ComboBox_squadWarframe.Location = New System.Drawing.Point(153, 15)
        Me.ComboBox_squadWarframe.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_squadWarframe.Name = "ComboBox_squadWarframe"
        Me.ComboBox_squadWarframe.Size = New System.Drawing.Size(282, 24)
        Me.ComboBox_squadWarframe.TabIndex = 8
        '
        'Label_squadPowerStrength
        '
        Me.Label_squadPowerStrength.AutoSize = True
        Me.Label_squadPowerStrength.Location = New System.Drawing.Point(16, 76)
        Me.Label_squadPowerStrength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_squadPowerStrength.Name = "Label_squadPowerStrength"
        Me.Label_squadPowerStrength.Size = New System.Drawing.Size(109, 17)
        Me.Label_squadPowerStrength.TabIndex = 10
        Me.Label_squadPowerStrength.Text = "Power Strength:"
        '
        'NumericUpDown_squadPowerStrength
        '
        Me.NumericUpDown_squadPowerStrength.Location = New System.Drawing.Point(153, 74)
        Me.NumericUpDown_squadPowerStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown_squadPowerStrength.Maximum = New Decimal(New Integer() {15000, 0, 0, 0})
        Me.NumericUpDown_squadPowerStrength.Minimum = New Decimal(New Integer() {40, 0, 0, -2147483648})
        Me.NumericUpDown_squadPowerStrength.Name = "NumericUpDown_squadPowerStrength"
        Me.NumericUpDown_squadPowerStrength.Size = New System.Drawing.Size(254, 23)
        Me.NumericUpDown_squadPowerStrength.TabIndex = 11
        Me.NumericUpDown_squadPowerStrength.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label_squadPowerStrengthPercent
        '
        Me.Label_squadPowerStrengthPercent.AutoSize = True
        Me.Label_squadPowerStrengthPercent.Location = New System.Drawing.Point(415, 76)
        Me.Label_squadPowerStrengthPercent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_squadPowerStrengthPercent.Name = "Label_squadPowerStrengthPercent"
        Me.Label_squadPowerStrengthPercent.Size = New System.Drawing.Size(20, 17)
        Me.Label_squadPowerStrengthPercent.TabIndex = 12
        Me.Label_squadPowerStrengthPercent.Text = "%"
        '
        'Form_squadMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(451, 224)
        Me.Controls.Add(Me.Label_squadPowerStrengthPercent)
        Me.Controls.Add(Me.NumericUpDown_squadPowerStrength)
        Me.Controls.Add(Me.Label_squadPowerStrength)
        Me.Controls.Add(Me.Label_squadWarframe)
        Me.Controls.Add(Me.ComboBox_squadWarframe)
        Me.Controls.Add(Me.CustomTabControl_squadAbilitys)
        Me.Controls.Add(Me.Label_squadAura)
        Me.Controls.Add(Me.ComboBox_squadAura)
        Me.Controls.Add(Me.TextBox_squadInfo)
        Me.Controls.Add(Me.Button_squadCancel)
        Me.Controls.Add(Me.Button_squadApply)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_squadMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Squad Member | "
        Me.CustomTabControl_squadAbilitys.ResumeLayout(False)
        Me.TabPage_squadChroma.ResumeLayout(False)
        Me.TabPage_squadChroma.PerformLayout()
        Me.TabPage_squadEquinox.ResumeLayout(False)
        Me.TabPage_squadEquinox.PerformLayout()
        Me.TabPage_squadMirage.ResumeLayout(False)
        Me.TabPage_squadMirage.PerformLayout()
        Me.TabPage_squadNezha.ResumeLayout(False)
        Me.TabPage_squadNezha.PerformLayout()
        CType(Me.NumericUpDown_squadSafeGuard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_squadNidus.ResumeLayout(False)
        Me.TabPage_squadNidus.PerformLayout()
        Me.TabPage_squadOberon.ResumeLayout(False)
        Me.TabPage_squadOberon.PerformLayout()
        Me.TabPage_squadOctavia.ResumeLayout(False)
        Me.TabPage_squadOctavia.PerformLayout()
        Me.TabPage_squadTitania.ResumeLayout(False)
        Me.TabPage_squadTitania.PerformLayout()
        Me.TabPage_squadTrinity.ResumeLayout(False)
        Me.TabPage_squadTrinity.PerformLayout()
        Me.TabPage_squadValkyr.ResumeLayout(False)
        Me.TabPage_squadValkyr.PerformLayout()
        CType(Me.NumericUpDown_squadPowerStrength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_squadApply As Button
    Friend WithEvents Button_squadCancel As Button
    Friend WithEvents TextBox_squadInfo As TextBox
    Friend WithEvents Label_squadAura As Label
    Friend WithEvents ComboBox_squadAura As ComboBox
    Friend WithEvents CustomTabControl_squadAbilitys As CustomTabControl
    Friend WithEvents TabPage_squadChroma As TabPage
    Friend WithEvents Label_squadWarframe As Label
    Friend WithEvents ComboBox_squadWarframe As ComboBox
    Friend WithEvents CheckBox_squadElementalWard As CheckBox
    Friend WithEvents TabPage_squadMirage As TabPage
    Friend WithEvents CheckBox_squadTotalEclipse As CheckBox
    Friend WithEvents TabPage_squadNezha As TabPage
    Friend WithEvents CheckBox_squadSafeguard As CheckBox
    Friend WithEvents TabPage_squadNidus As TabPage
    Friend WithEvents CheckBox_squadParasiticLink As CheckBox
    Friend WithEvents TabPage_squadOberon As TabPage
    Friend WithEvents CheckBox_squadIronRenewal As CheckBox
    Friend WithEvents CheckBox_squadHallowedReckoning As CheckBox
    Friend WithEvents TabPage_squadOctavia As TabPage
    Friend WithEvents CheckBox_squadMetronome As CheckBox
    Friend WithEvents TabPage_squadTitania As TabPage
    Friend WithEvents CheckBox_squadThorns As CheckBox
    Friend WithEvents TabPage_squadTrinity As TabPage
    Friend WithEvents CheckBox_squadBlessing As CheckBox
    Friend WithEvents TabPage_squadValkyr As TabPage
    Friend WithEvents CheckBox_squadWarcry As CheckBox
    Friend WithEvents Label_squadPowerStrength As Label
    Friend WithEvents NumericUpDown_squadPowerStrength As NumericUpDown
    Friend WithEvents Label_squadPowerStrengthPercent As Label
    Friend WithEvents Label_squadSafeguardArmor As Label
    Friend WithEvents NumericUpDown_squadSafeGuard As NumericUpDown
    Friend WithEvents TabPage_squadEquinox As TabPage
    Friend WithEvents CheckBox_squadPasifyAndProvoke As CheckBox
    Friend WithEvents CheckBox_squadPeacefulProvocation As CheckBox
    Friend WithEvents Label_squadElementalWard As Label
End Class
