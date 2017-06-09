<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Warframe_EHP_Calc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Warframe_EHP_Calc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EHP_container = New System.Windows.Forms.Panel()
        Me.wf_ehp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.wf_umbra = New System.Windows.Forms.CheckBox()
        Me.wf_hpconvert_stacks = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.wf_hpconvert_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_hpconvert = New System.Windows.Forms.CheckBox()
        Me.wf_endurance_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_endurance = New System.Windows.Forms.CheckBox()
        Me.wf_coaction_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_coaction = New System.Windows.Forms.CheckBox()
        Me.wf_standunited_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_standunited = New System.Windows.Forms.CheckBox()
        Me.frame_power = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.frame_sheild = New System.Windows.Forms.TextBox()
        Me.wf_flow_val = New System.Windows.Forms.NumericUpDown()
        Me.frame_health = New System.Windows.Forms.TextBox()
        Me.wf_flow = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wf_physique_val = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wf_physique = New System.Windows.Forms.CheckBox()
        Me.frame_armor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.wf_armoredagility_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_armoredagility = New System.Windows.Forms.CheckBox()
        Me.wf_prime = New System.Windows.Forms.CheckBox()
        Me.wf_steelfiber = New System.Windows.Forms.CheckBox()
        Me.wf_vitality = New System.Windows.Forms.CheckBox()
        Me.wf_redirection = New System.Windows.Forms.CheckBox()
        Me.wf_vigor = New System.Windows.Forms.CheckBox()
        Me.cb_frame = New System.Windows.Forms.ComboBox()
        Me.wf_quickthinking = New System.Windows.Forms.CheckBox()
        Me.wf_quickthinking_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_vigor_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_redirection_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_vitality_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_steelfiber_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_dmgreduc_val = New System.Windows.Forms.NumericUpDown()
        Me.wf_dmgreduc = New System.Windows.Forms.CheckBox()
        Me.x_armor_val = New System.Windows.Forms.NumericUpDown()
        Me.x_health_val = New System.Windows.Forms.NumericUpDown()
        Me.x_shield = New System.Windows.Forms.CheckBox()
        Me.x_health = New System.Windows.Forms.CheckBox()
        Me.x_shield_val = New System.Windows.Forms.NumericUpDown()
        Me.x_armor = New System.Windows.Forms.CheckBox()
        Me.cb_pet = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.prime_collar = New System.Windows.Forms.CheckBox()
        Me.link_sheild = New System.Windows.Forms.CheckBox()
        Me.link_sheild_val = New System.Windows.Forms.NumericUpDown()
        Me.link_health = New System.Windows.Forms.CheckBox()
        Me.link_health_val = New System.Windows.Forms.NumericUpDown()
        Me.pet_ehp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.link_armor = New System.Windows.Forms.CheckBox()
        Me.link_armor_val = New System.Windows.Forms.NumericUpDown()
        Me.pet_sheild = New System.Windows.Forms.TextBox()
        Me.pet_health = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pet_armor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.prime_power = New System.Windows.Forms.ComboBox()
        Me.prime_shield = New System.Windows.Forms.ComboBox()
        Me.prime_health = New System.Windows.Forms.ComboBox()
        Me.prime_armor = New System.Windows.Forms.ComboBox()
        Me.prime_base_power = New System.Windows.Forms.ComboBox()
        Me.prime_base_shield = New System.Windows.Forms.ComboBox()
        Me.prime_base_health = New System.Windows.Forms.ComboBox()
        Me.prime_base_armor = New System.Windows.Forms.ComboBox()
        Me.cb_primes = New System.Windows.Forms.ComboBox()
        Me.cb_shield_pet = New System.Windows.Forms.ComboBox()
        Me.cb_health_pet = New System.Windows.Forms.ComboBox()
        Me.cb_armor_pet = New System.Windows.Forms.ComboBox()
        Me.cb_power = New System.Windows.Forms.ComboBox()
        Me.cb_shield = New System.Windows.Forms.ComboBox()
        Me.cb_health = New System.Windows.Forms.ComboBox()
        Me.cb_armor = New System.Windows.Forms.ComboBox()
        Me.cb_base_power = New System.Windows.Forms.ComboBox()
        Me.cb_base_shield = New System.Windows.Forms.ComboBox()
        Me.cb_base_health = New System.Windows.Forms.ComboBox()
        Me.cb_base_armor = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.volt_panel = New System.Windows.Forms.Panel()
        Me.volt_None = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.volt_Pulse = New System.Windows.Forms.RadioButton()
        Me.vauban_panel = New System.Windows.Forms.Panel()
        Me.vauban_None = New System.Windows.Forms.RadioButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.vauban_Esprit = New System.Windows.Forms.RadioButton()
        Me.trinity_panel = New System.Windows.Forms.Panel()
        Me.trinity_None = New System.Windows.Forms.RadioButton()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.trinity_Meridian = New System.Windows.Forms.RadioButton()
        Me.trinity_Aura = New System.Windows.Forms.RadioButton()
        Me.saryn_panel = New System.Windows.Forms.Panel()
        Me.saryn_None = New System.Windows.Forms.RadioButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.saryn_Hemlock = New System.Windows.Forms.RadioButton()
        Me.rhino_panel = New System.Windows.Forms.Panel()
        Me.rhino_None = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.rhino_Thrak = New System.Windows.Forms.RadioButton()
        Me.nyx_panel = New System.Windows.Forms.Panel()
        Me.nyx_None = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.nyx_Vespa = New System.Windows.Forms.RadioButton()
        Me.nyx_Menticide = New System.Windows.Forms.RadioButton()
        Me.nova_panel = New System.Windows.Forms.Panel()
        Me.nova_None = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.nova_Flux = New System.Windows.Forms.RadioButton()
        Me.mag_panel = New System.Windows.Forms.Panel()
        Me.mag_None = New System.Windows.Forms.RadioButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.mag_Gauss = New System.Windows.Forms.RadioButton()
        Me.mag_Coil = New System.Windows.Forms.RadioButton()
        Me.loki_panel = New System.Windows.Forms.Panel()
        Me.loki_None = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.loki_Swindle = New System.Windows.Forms.RadioButton()
        Me.loki_Essence = New System.Windows.Forms.RadioButton()
        Me.key_decaying = New System.Windows.Forms.CheckBox()
        Me.key_bleeding = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.arcane_ultimatum_val = New System.Windows.Forms.NumericUpDown()
        Me.arcane_ultimatum = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.arcane_guardian_val = New System.Windows.Forms.NumericUpDown()
        Me.arcane_guardian = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.frost_panel = New System.Windows.Forms.Panel()
        Me.frost_None = New System.Windows.Forms.RadioButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.frost_Squall = New System.Windows.Forms.RadioButton()
        Me.frost_Aurora = New System.Windows.Forms.RadioButton()
        Me.ember_panel = New System.Windows.Forms.Panel()
        Me.ember_None = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ember_Backdraft = New System.Windows.Forms.RadioButton()
        Me.ember_Phoenix = New System.Windows.Forms.RadioButton()
        Me.banshee_panel = New System.Windows.Forms.Panel()
        Me.banshee_None = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.banshee_Reverb = New System.Windows.Forms.RadioButton()
        Me.excalibur_panel = New System.Windows.Forms.Panel()
        Me.excalibur_None = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.excalibur_Pendragon = New System.Windows.Forms.RadioButton()
        Me.excalibur_Avalon = New System.Windows.Forms.RadioButton()
        Me.ash_panel = New System.Windows.Forms.Panel()
        Me.ash_None = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ash_Locust = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.EHP_container.SuspendLayout()
        CType(Me.wf_hpconvert_stacks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_hpconvert_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_endurance_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_coaction_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_standunited_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_flow_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_physique_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_armoredagility_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_quickthinking_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_vigor_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_redirection_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_vitality_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_steelfiber_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wf_dmgreduc_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_armor_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_health_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_shield_val, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.link_sheild_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.link_health_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.link_armor_val, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.volt_panel.SuspendLayout()
        Me.vauban_panel.SuspendLayout()
        Me.trinity_panel.SuspendLayout()
        Me.saryn_panel.SuspendLayout()
        Me.rhino_panel.SuspendLayout()
        Me.nyx_panel.SuspendLayout()
        Me.nova_panel.SuspendLayout()
        Me.mag_panel.SuspendLayout()
        Me.loki_panel.SuspendLayout()
        CType(Me.arcane_ultimatum_val, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcane_guardian_val, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frost_panel.SuspendLayout()
        Me.ember_panel.SuspendLayout()
        Me.banshee_panel.SuspendLayout()
        Me.excalibur_panel.SuspendLayout()
        Me.ash_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EHP_container)
        Me.GroupBox1.Controls.Add(Me.wf_umbra)
        Me.GroupBox1.Controls.Add(Me.wf_hpconvert_stacks)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.wf_hpconvert_val)
        Me.GroupBox1.Controls.Add(Me.wf_hpconvert)
        Me.GroupBox1.Controls.Add(Me.wf_endurance_val)
        Me.GroupBox1.Controls.Add(Me.wf_endurance)
        Me.GroupBox1.Controls.Add(Me.wf_coaction_val)
        Me.GroupBox1.Controls.Add(Me.wf_coaction)
        Me.GroupBox1.Controls.Add(Me.wf_standunited_val)
        Me.GroupBox1.Controls.Add(Me.wf_standunited)
        Me.GroupBox1.Controls.Add(Me.frame_power)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.frame_sheild)
        Me.GroupBox1.Controls.Add(Me.wf_flow_val)
        Me.GroupBox1.Controls.Add(Me.frame_health)
        Me.GroupBox1.Controls.Add(Me.wf_flow)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.wf_physique_val)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.wf_physique)
        Me.GroupBox1.Controls.Add(Me.frame_armor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.wf_armoredagility_val)
        Me.GroupBox1.Controls.Add(Me.wf_armoredagility)
        Me.GroupBox1.Controls.Add(Me.wf_prime)
        Me.GroupBox1.Controls.Add(Me.wf_steelfiber)
        Me.GroupBox1.Controls.Add(Me.wf_vitality)
        Me.GroupBox1.Controls.Add(Me.wf_redirection)
        Me.GroupBox1.Controls.Add(Me.wf_vigor)
        Me.GroupBox1.Controls.Add(Me.cb_frame)
        Me.GroupBox1.Controls.Add(Me.wf_quickthinking)
        Me.GroupBox1.Controls.Add(Me.wf_quickthinking_val)
        Me.GroupBox1.Controls.Add(Me.wf_vigor_val)
        Me.GroupBox1.Controls.Add(Me.wf_redirection_val)
        Me.GroupBox1.Controls.Add(Me.wf_vitality_val)
        Me.GroupBox1.Controls.Add(Me.wf_steelfiber_val)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Warframe"
        '
        'EHP_container
        '
        Me.EHP_container.Controls.Add(Me.wf_ehp)
        Me.EHP_container.Controls.Add(Me.Label5)
        Me.EHP_container.Location = New System.Drawing.Point(331, 357)
        Me.EHP_container.Name = "EHP_container"
        Me.EHP_container.Size = New System.Drawing.Size(154, 48)
        Me.EHP_container.TabIndex = 50
        '
        'wf_ehp
        '
        Me.wf_ehp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.wf_ehp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_ehp.Location = New System.Drawing.Point(2, 24)
        Me.wf_ehp.Name = "wf_ehp"
        Me.wf_ehp.Size = New System.Drawing.Size(150, 22)
        Me.wf_ehp.TabIndex = 12
        Me.wf_ehp.Text = "0"
        Me.wf_ehp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Effective Health: "
        '
        'wf_umbra
        '
        Me.wf_umbra.AutoSize = True
        Me.wf_umbra.Enabled = False
        Me.wf_umbra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_umbra.Location = New System.Drawing.Point(391, 35)
        Me.wf_umbra.Name = "wf_umbra"
        Me.wf_umbra.Size = New System.Drawing.Size(81, 24)
        Me.wf_umbra.TabIndex = 49
        Me.wf_umbra.Text = "Umbra"
        Me.wf_umbra.UseVisualStyleBackColor = True
        Me.wf_umbra.Visible = False
        '
        'wf_hpconvert_stacks
        '
        Me.wf_hpconvert_stacks.Enabled = False
        Me.wf_hpconvert_stacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_hpconvert_stacks.Location = New System.Drawing.Point(196, 385)
        Me.wf_hpconvert_stacks.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.wf_hpconvert_stacks.Name = "wf_hpconvert_stacks"
        Me.wf_hpconvert_stacks.Size = New System.Drawing.Size(94, 21)
        Me.wf_hpconvert_stacks.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Stacks:"
        '
        'wf_hpconvert_val
        '
        Me.wf_hpconvert_val.Enabled = False
        Me.wf_hpconvert_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_hpconvert_val.Location = New System.Drawing.Point(196, 365)
        Me.wf_hpconvert_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_hpconvert_val.Name = "wf_hpconvert_val"
        Me.wf_hpconvert_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_hpconvert_val.TabIndex = 45
        '
        'wf_hpconvert
        '
        Me.wf_hpconvert.AutoSize = True
        Me.wf_hpconvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_hpconvert.Location = New System.Drawing.Point(18, 363)
        Me.wf_hpconvert.Name = "wf_hpconvert"
        Me.wf_hpconvert.Size = New System.Drawing.Size(180, 24)
        Me.wf_hpconvert.TabIndex = 46
        Me.wf_hpconvert.Text = "Health Conversion:"
        Me.wf_hpconvert.UseVisualStyleBackColor = True
        '
        'wf_endurance_val
        '
        Me.wf_endurance_val.Enabled = False
        Me.wf_endurance_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_endurance_val.Location = New System.Drawing.Point(196, 284)
        Me.wf_endurance_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_endurance_val.Name = "wf_endurance_val"
        Me.wf_endurance_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_endurance_val.TabIndex = 36
        '
        'wf_endurance
        '
        Me.wf_endurance.AutoSize = True
        Me.wf_endurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_endurance.Location = New System.Drawing.Point(18, 282)
        Me.wf_endurance.Name = "wf_endurance"
        Me.wf_endurance.Size = New System.Drawing.Size(160, 24)
        Me.wf_endurance.TabIndex = 37
        Me.wf_endurance.Text = "Endurance Drift:"
        Me.wf_endurance.UseVisualStyleBackColor = True
        '
        'wf_coaction_val
        '
        Me.wf_coaction_val.Enabled = False
        Me.wf_coaction_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_coaction_val.Location = New System.Drawing.Point(196, 257)
        Me.wf_coaction_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_coaction_val.Name = "wf_coaction_val"
        Me.wf_coaction_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_coaction_val.TabIndex = 34
        '
        'wf_coaction
        '
        Me.wf_coaction.AutoSize = True
        Me.wf_coaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_coaction.Location = New System.Drawing.Point(18, 255)
        Me.wf_coaction.Name = "wf_coaction"
        Me.wf_coaction.Size = New System.Drawing.Size(144, 24)
        Me.wf_coaction.TabIndex = 35
        Me.wf_coaction.Text = "Coaction Drift:"
        Me.wf_coaction.UseVisualStyleBackColor = True
        '
        'wf_standunited_val
        '
        Me.wf_standunited_val.Enabled = False
        Me.wf_standunited_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_standunited_val.Location = New System.Drawing.Point(196, 230)
        Me.wf_standunited_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_standunited_val.Name = "wf_standunited_val"
        Me.wf_standunited_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_standunited_val.TabIndex = 32
        '
        'wf_standunited
        '
        Me.wf_standunited.AutoSize = True
        Me.wf_standunited.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_standunited.Location = New System.Drawing.Point(18, 228)
        Me.wf_standunited.Name = "wf_standunited"
        Me.wf_standunited.Size = New System.Drawing.Size(139, 24)
        Me.wf_standunited.TabIndex = 33
        Me.wf_standunited.Text = "Stand United:"
        Me.wf_standunited.UseVisualStyleBackColor = True
        '
        'frame_power
        '
        Me.frame_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_power.Location = New System.Drawing.Point(392, 149)
        Me.frame_power.Name = "frame_power"
        Me.frame_power.ReadOnly = True
        Me.frame_power.Size = New System.Drawing.Size(120, 21)
        Me.frame_power.TabIndex = 31
        Me.frame_power.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Power:"
        '
        'frame_sheild
        '
        Me.frame_sheild.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_sheild.Location = New System.Drawing.Point(392, 124)
        Me.frame_sheild.Name = "frame_sheild"
        Me.frame_sheild.ReadOnly = True
        Me.frame_sheild.Size = New System.Drawing.Size(120, 21)
        Me.frame_sheild.TabIndex = 22
        Me.frame_sheild.Text = "0"
        '
        'wf_flow_val
        '
        Me.wf_flow_val.Enabled = False
        Me.wf_flow_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_flow_val.Location = New System.Drawing.Point(196, 311)
        Me.wf_flow_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.wf_flow_val.Name = "wf_flow_val"
        Me.wf_flow_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_flow_val.TabIndex = 28
        '
        'frame_health
        '
        Me.frame_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_health.Location = New System.Drawing.Point(392, 97)
        Me.frame_health.Name = "frame_health"
        Me.frame_health.ReadOnly = True
        Me.frame_health.Size = New System.Drawing.Size(120, 21)
        Me.frame_health.TabIndex = 21
        Me.frame_health.Text = "0"
        '
        'wf_flow
        '
        Me.wf_flow.AutoSize = True
        Me.wf_flow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_flow.Location = New System.Drawing.Point(18, 309)
        Me.wf_flow.Name = "wf_flow"
        Me.wf_flow.Size = New System.Drawing.Size(70, 24)
        Me.wf_flow.TabIndex = 29
        Me.wf_flow.Text = "Flow:"
        Me.wf_flow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Shield:"
        '
        'wf_physique_val
        '
        Me.wf_physique_val.Enabled = False
        Me.wf_physique_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_physique_val.Location = New System.Drawing.Point(196, 203)
        Me.wf_physique_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_physique_val.Name = "wf_physique_val"
        Me.wf_physique_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_physique_val.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Health:"
        '
        'wf_physique
        '
        Me.wf_physique.AutoSize = True
        Me.wf_physique.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_physique.Location = New System.Drawing.Point(18, 201)
        Me.wf_physique.Name = "wf_physique"
        Me.wf_physique.Size = New System.Drawing.Size(105, 24)
        Me.wf_physique.TabIndex = 27
        Me.wf_physique.Text = "Physique:"
        Me.wf_physique.UseVisualStyleBackColor = True
        '
        'frame_armor
        '
        Me.frame_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame_armor.Location = New System.Drawing.Point(392, 72)
        Me.frame_armor.Name = "frame_armor"
        Me.frame_armor.ReadOnly = True
        Me.frame_armor.Size = New System.Drawing.Size(120, 21)
        Me.frame_armor.TabIndex = 18
        Me.frame_armor.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Armor:"
        '
        'wf_armoredagility_val
        '
        Me.wf_armoredagility_val.Enabled = False
        Me.wf_armoredagility_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_armoredagility_val.Location = New System.Drawing.Point(196, 176)
        Me.wf_armoredagility_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_armoredagility_val.Name = "wf_armoredagility_val"
        Me.wf_armoredagility_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_armoredagility_val.TabIndex = 24
        '
        'wf_armoredagility
        '
        Me.wf_armoredagility.AutoSize = True
        Me.wf_armoredagility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_armoredagility.Location = New System.Drawing.Point(18, 174)
        Me.wf_armoredagility.Name = "wf_armoredagility"
        Me.wf_armoredagility.Size = New System.Drawing.Size(154, 24)
        Me.wf_armoredagility.TabIndex = 25
        Me.wf_armoredagility.Text = "Armored Agility:"
        Me.wf_armoredagility.UseVisualStyleBackColor = True
        '
        'wf_prime
        '
        Me.wf_prime.AutoSize = True
        Me.wf_prime.Enabled = False
        Me.wf_prime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_prime.Location = New System.Drawing.Point(306, 35)
        Me.wf_prime.Name = "wf_prime"
        Me.wf_prime.Size = New System.Drawing.Size(73, 24)
        Me.wf_prime.TabIndex = 23
        Me.wf_prime.Text = "Prime"
        Me.wf_prime.UseVisualStyleBackColor = True
        '
        'wf_steelfiber
        '
        Me.wf_steelfiber.AutoSize = True
        Me.wf_steelfiber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_steelfiber.Location = New System.Drawing.Point(18, 70)
        Me.wf_steelfiber.Name = "wf_steelfiber"
        Me.wf_steelfiber.Size = New System.Drawing.Size(121, 24)
        Me.wf_steelfiber.TabIndex = 22
        Me.wf_steelfiber.Text = "Steel Fiber:"
        Me.wf_steelfiber.UseVisualStyleBackColor = True
        '
        'wf_vitality
        '
        Me.wf_vitality.AutoSize = True
        Me.wf_vitality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_vitality.Location = New System.Drawing.Point(18, 95)
        Me.wf_vitality.Name = "wf_vitality"
        Me.wf_vitality.Size = New System.Drawing.Size(87, 24)
        Me.wf_vitality.TabIndex = 21
        Me.wf_vitality.Text = "Vitality:"
        Me.wf_vitality.UseVisualStyleBackColor = True
        '
        'wf_redirection
        '
        Me.wf_redirection.AutoSize = True
        Me.wf_redirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_redirection.Location = New System.Drawing.Point(18, 121)
        Me.wf_redirection.Name = "wf_redirection"
        Me.wf_redirection.Size = New System.Drawing.Size(125, 24)
        Me.wf_redirection.TabIndex = 20
        Me.wf_redirection.Text = "Redirection:"
        Me.wf_redirection.UseVisualStyleBackColor = True
        '
        'wf_vigor
        '
        Me.wf_vigor.AutoSize = True
        Me.wf_vigor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_vigor.Location = New System.Drawing.Point(18, 147)
        Me.wf_vigor.Name = "wf_vigor"
        Me.wf_vigor.Size = New System.Drawing.Size(75, 24)
        Me.wf_vigor.TabIndex = 19
        Me.wf_vigor.Text = "Vigor:"
        Me.wf_vigor.UseVisualStyleBackColor = True
        '
        'cb_frame
        '
        Me.cb_frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_frame.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_frame.FormattingEnabled = True
        Me.cb_frame.Items.AddRange(New Object() {"Select a Warframe", "Ash", "Atlas", "Banshee", "Chroma", "Ember", "Equinox", "Excalibur", "Frost", "Hydroid", "Inaros", "Ivara", "Limbo", "Loki", "Mag", "Mesa", "Mirage", "Nekros", "Nezha", "Nidus", "Nova", "Nyx", "Oberon", "Octavia", "Rhino", "Saryn", "Titania", "Trinity", "Valkyr", "Vauban", "Volt", "Wukong", "Zephyr"})
        Me.cb_frame.Location = New System.Drawing.Point(18, 35)
        Me.cb_frame.Name = "cb_frame"
        Me.cb_frame.Size = New System.Drawing.Size(272, 24)
        Me.cb_frame.TabIndex = 18
        '
        'wf_quickthinking
        '
        Me.wf_quickthinking.AutoSize = True
        Me.wf_quickthinking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_quickthinking.Location = New System.Drawing.Point(18, 336)
        Me.wf_quickthinking.Name = "wf_quickthinking"
        Me.wf_quickthinking.Size = New System.Drawing.Size(150, 24)
        Me.wf_quickthinking.TabIndex = 10
        Me.wf_quickthinking.Text = "Quick Thinking:"
        Me.wf_quickthinking.UseVisualStyleBackColor = True
        '
        'wf_quickthinking_val
        '
        Me.wf_quickthinking_val.Enabled = False
        Me.wf_quickthinking_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_quickthinking_val.Location = New System.Drawing.Point(196, 338)
        Me.wf_quickthinking_val.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.wf_quickthinking_val.Name = "wf_quickthinking_val"
        Me.wf_quickthinking_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_quickthinking_val.TabIndex = 9
        '
        'wf_vigor_val
        '
        Me.wf_vigor_val.Enabled = False
        Me.wf_vigor_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_vigor_val.Location = New System.Drawing.Point(196, 149)
        Me.wf_vigor_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.wf_vigor_val.Name = "wf_vigor_val"
        Me.wf_vigor_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_vigor_val.TabIndex = 7
        '
        'wf_redirection_val
        '
        Me.wf_redirection_val.Enabled = False
        Me.wf_redirection_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_redirection_val.Location = New System.Drawing.Point(196, 123)
        Me.wf_redirection_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.wf_redirection_val.Name = "wf_redirection_val"
        Me.wf_redirection_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_redirection_val.TabIndex = 6
        '
        'wf_vitality_val
        '
        Me.wf_vitality_val.Enabled = False
        Me.wf_vitality_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_vitality_val.Location = New System.Drawing.Point(196, 97)
        Me.wf_vitality_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.wf_vitality_val.Name = "wf_vitality_val"
        Me.wf_vitality_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_vitality_val.TabIndex = 5
        '
        'wf_steelfiber_val
        '
        Me.wf_steelfiber_val.Enabled = False
        Me.wf_steelfiber_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_steelfiber_val.Location = New System.Drawing.Point(196, 72)
        Me.wf_steelfiber_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.wf_steelfiber_val.Name = "wf_steelfiber_val"
        Me.wf_steelfiber_val.Size = New System.Drawing.Size(94, 21)
        Me.wf_steelfiber_val.TabIndex = 1
        '
        'wf_dmgreduc_val
        '
        Me.wf_dmgreduc_val.DecimalPlaces = 1
        Me.wf_dmgreduc_val.Enabled = False
        Me.wf_dmgreduc_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_dmgreduc_val.Location = New System.Drawing.Point(159, 143)
        Me.wf_dmgreduc_val.Maximum = New Decimal(New Integer() {95, 0, 0, 0})
        Me.wf_dmgreduc_val.Name = "wf_dmgreduc_val"
        Me.wf_dmgreduc_val.Size = New System.Drawing.Size(58, 21)
        Me.wf_dmgreduc_val.TabIndex = 44
        '
        'wf_dmgreduc
        '
        Me.wf_dmgreduc.AutoSize = True
        Me.wf_dmgreduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wf_dmgreduc.Location = New System.Drawing.Point(11, 141)
        Me.wf_dmgreduc.Name = "wf_dmgreduc"
        Me.wf_dmgreduc.Size = New System.Drawing.Size(152, 24)
        Me.wf_dmgreduc.TabIndex = 45
        Me.wf_dmgreduc.Text = "Dmg Reduc. %:"
        Me.wf_dmgreduc.UseVisualStyleBackColor = True
        '
        'x_armor_val
        '
        Me.x_armor_val.Enabled = False
        Me.x_armor_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_armor_val.Location = New System.Drawing.Point(97, 62)
        Me.x_armor_val.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.x_armor_val.Minimum = New Decimal(New Integer() {50000, 0, 0, -2147483648})
        Me.x_armor_val.Name = "x_armor_val"
        Me.x_armor_val.Size = New System.Drawing.Size(120, 21)
        Me.x_armor_val.TabIndex = 40
        '
        'x_health_val
        '
        Me.x_health_val.Enabled = False
        Me.x_health_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_health_val.Location = New System.Drawing.Point(97, 89)
        Me.x_health_val.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.x_health_val.Minimum = New Decimal(New Integer() {50000, 0, 0, -2147483648})
        Me.x_health_val.Name = "x_health_val"
        Me.x_health_val.Size = New System.Drawing.Size(120, 21)
        Me.x_health_val.TabIndex = 42
        '
        'x_shield
        '
        Me.x_shield.AutoSize = True
        Me.x_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_shield.Location = New System.Drawing.Point(11, 114)
        Me.x_shield.Name = "x_shield"
        Me.x_shield.Size = New System.Drawing.Size(83, 24)
        Me.x_shield.TabIndex = 39
        Me.x_shield.Text = "Shield:"
        Me.x_shield.UseVisualStyleBackColor = True
        '
        'x_health
        '
        Me.x_health.AutoSize = True
        Me.x_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_health.Location = New System.Drawing.Point(11, 87)
        Me.x_health.Name = "x_health"
        Me.x_health.Size = New System.Drawing.Size(86, 24)
        Me.x_health.TabIndex = 43
        Me.x_health.Text = "Health:"
        Me.x_health.UseVisualStyleBackColor = True
        '
        'x_shield_val
        '
        Me.x_shield_val.Enabled = False
        Me.x_shield_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_shield_val.Location = New System.Drawing.Point(97, 116)
        Me.x_shield_val.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.x_shield_val.Minimum = New Decimal(New Integer() {50000, 0, 0, -2147483648})
        Me.x_shield_val.Name = "x_shield_val"
        Me.x_shield_val.Size = New System.Drawing.Size(120, 21)
        Me.x_shield_val.TabIndex = 38
        '
        'x_armor
        '
        Me.x_armor.AutoSize = True
        Me.x_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x_armor.Location = New System.Drawing.Point(11, 60)
        Me.x_armor.Name = "x_armor"
        Me.x_armor.Size = New System.Drawing.Size(81, 24)
        Me.x_armor.TabIndex = 41
        Me.x_armor.Text = "Armor:"
        Me.x_armor.UseVisualStyleBackColor = True
        '
        'cb_pet
        '
        Me.cb_pet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_pet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pet.FormattingEnabled = True
        Me.cb_pet.Items.AddRange(New Object() {"Select a Pet", "Adarza", "Smeeta", "Chesa", "Huras", "Raksa", "Sahasa", "Sunika", "Helminth Charger"})
        Me.cb_pet.Location = New System.Drawing.Point(18, 35)
        Me.cb_pet.Name = "cb_pet"
        Me.cb_pet.Size = New System.Drawing.Size(272, 24)
        Me.cb_pet.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.prime_collar)
        Me.GroupBox3.Controls.Add(Me.cb_pet)
        Me.GroupBox3.Controls.Add(Me.link_sheild)
        Me.GroupBox3.Controls.Add(Me.link_sheild_val)
        Me.GroupBox3.Controls.Add(Me.link_health)
        Me.GroupBox3.Controls.Add(Me.link_health_val)
        Me.GroupBox3.Controls.Add(Me.pet_ehp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.link_armor)
        Me.GroupBox3.Controls.Add(Me.link_armor_val)
        Me.GroupBox3.Controls.Add(Me.pet_sheild)
        Me.GroupBox3.Controls.Add(Me.pet_health)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.pet_armor)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 449)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(758, 158)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kavat / Kubrow / Helminth Charger"
        '
        'prime_collar
        '
        Me.prime_collar.AutoSize = True
        Me.prime_collar.Enabled = False
        Me.prime_collar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_collar.Location = New System.Drawing.Point(306, 35)
        Me.prime_collar.Name = "prime_collar"
        Me.prime_collar.Size = New System.Drawing.Size(187, 24)
        Me.prime_collar.TabIndex = 51
        Me.prime_collar.Text = "Kavasa Prime Collar"
        Me.prime_collar.UseVisualStyleBackColor = True
        '
        'link_sheild
        '
        Me.link_sheild.AutoSize = True
        Me.link_sheild.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_sheild.Location = New System.Drawing.Point(18, 123)
        Me.link_sheild.Name = "link_sheild"
        Me.link_sheild.Size = New System.Drawing.Size(121, 24)
        Me.link_sheild.TabIndex = 16
        Me.link_sheild.Text = "Shield Link:"
        Me.link_sheild.UseVisualStyleBackColor = True
        '
        'link_sheild_val
        '
        Me.link_sheild_val.Enabled = False
        Me.link_sheild_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_sheild_val.Location = New System.Drawing.Point(170, 125)
        Me.link_sheild_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.link_sheild_val.Name = "link_sheild_val"
        Me.link_sheild_val.Size = New System.Drawing.Size(120, 21)
        Me.link_sheild_val.TabIndex = 15
        '
        'link_health
        '
        Me.link_health.AutoSize = True
        Me.link_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_health.Location = New System.Drawing.Point(18, 96)
        Me.link_health.Name = "link_health"
        Me.link_health.Size = New System.Drawing.Size(124, 24)
        Me.link_health.TabIndex = 14
        Me.link_health.Text = "Health Link:"
        Me.link_health.UseVisualStyleBackColor = True
        '
        'link_health_val
        '
        Me.link_health_val.Enabled = False
        Me.link_health_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_health_val.Location = New System.Drawing.Point(170, 98)
        Me.link_health_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.link_health_val.Name = "link_health_val"
        Me.link_health_val.Size = New System.Drawing.Size(120, 21)
        Me.link_health_val.TabIndex = 13
        '
        'pet_ehp
        '
        Me.pet_ehp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pet_ehp.Location = New System.Drawing.Point(561, 110)
        Me.pet_ehp.Name = "pet_ehp"
        Me.pet_ehp.Size = New System.Drawing.Size(148, 15)
        Me.pet_ehp.TabIndex = 12
        Me.pet_ehp.Text = "0"
        Me.pet_ehp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(561, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Effective Health: "
        '
        'link_armor
        '
        Me.link_armor.AutoSize = True
        Me.link_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_armor.Location = New System.Drawing.Point(18, 69)
        Me.link_armor.Name = "link_armor"
        Me.link_armor.Size = New System.Drawing.Size(119, 24)
        Me.link_armor.TabIndex = 10
        Me.link_armor.Text = "Armor Link:"
        Me.link_armor.UseVisualStyleBackColor = True
        '
        'link_armor_val
        '
        Me.link_armor_val.Enabled = False
        Me.link_armor_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_armor_val.Location = New System.Drawing.Point(170, 71)
        Me.link_armor_val.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.link_armor_val.Name = "link_armor_val"
        Me.link_armor_val.Size = New System.Drawing.Size(120, 21)
        Me.link_armor_val.TabIndex = 9
        '
        'pet_sheild
        '
        Me.pet_sheild.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pet_sheild.Location = New System.Drawing.Point(392, 122)
        Me.pet_sheild.Name = "pet_sheild"
        Me.pet_sheild.ReadOnly = True
        Me.pet_sheild.Size = New System.Drawing.Size(120, 21)
        Me.pet_sheild.TabIndex = 7
        Me.pet_sheild.Text = "0"
        '
        'pet_health
        '
        Me.pet_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pet_health.Location = New System.Drawing.Point(392, 95)
        Me.pet_health.Name = "pet_health"
        Me.pet_health.ReadOnly = True
        Me.pet_health.Size = New System.Drawing.Size(120, 21)
        Me.pet_health.TabIndex = 5
        Me.pet_health.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Shield:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(302, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Health:"
        '
        'pet_armor
        '
        Me.pet_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pet_armor.Location = New System.Drawing.Point(392, 70)
        Me.pet_armor.Name = "pet_armor"
        Me.pet_armor.ReadOnly = True
        Me.pet_armor.Size = New System.Drawing.Size(120, 21)
        Me.pet_armor.TabIndex = 1
        Me.pet_armor.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(302, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Armor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(673, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Created by cmd430"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.prime_power)
        Me.Panel1.Controls.Add(Me.prime_shield)
        Me.Panel1.Controls.Add(Me.prime_health)
        Me.Panel1.Controls.Add(Me.prime_armor)
        Me.Panel1.Controls.Add(Me.prime_base_power)
        Me.Panel1.Controls.Add(Me.prime_base_shield)
        Me.Panel1.Controls.Add(Me.prime_base_health)
        Me.Panel1.Controls.Add(Me.prime_base_armor)
        Me.Panel1.Controls.Add(Me.cb_primes)
        Me.Panel1.Controls.Add(Me.cb_shield_pet)
        Me.Panel1.Controls.Add(Me.cb_health_pet)
        Me.Panel1.Controls.Add(Me.cb_armor_pet)
        Me.Panel1.Controls.Add(Me.cb_power)
        Me.Panel1.Controls.Add(Me.cb_shield)
        Me.Panel1.Controls.Add(Me.cb_health)
        Me.Panel1.Controls.Add(Me.cb_armor)
        Me.Panel1.Controls.Add(Me.cb_base_power)
        Me.Panel1.Controls.Add(Me.cb_base_shield)
        Me.Panel1.Controls.Add(Me.cb_base_health)
        Me.Panel1.Controls.Add(Me.cb_base_armor)
        Me.Panel1.Location = New System.Drawing.Point(981, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 586)
        Me.Panel1.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 483)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "pet stats"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "prime warframe stats"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "warframe stats"
        '
        'prime_power
        '
        Me.prime_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_power.FormattingEnabled = True
        Me.prime_power.Items.AddRange(New Object() {"PRIME POWER", "150_Ash", "262.5_Banshee", "225_Ember", "150_Excalibur", "150_Frost", "262.5_Loki", "150_Mag", "187.5_Nekros", "262.5_Nova", "225_Nyx", "263_Oberon", "150_Rhino", "300_Saryn", "225_Trinity", "225_Valkyr", "225_Vauban", "300_Volt"})
        Me.prime_power.Location = New System.Drawing.Point(129, 269)
        Me.prime_power.Name = "prime_power"
        Me.prime_power.Size = New System.Drawing.Size(120, 24)
        Me.prime_power.TabIndex = 71
        '
        'prime_shield
        '
        Me.prime_shield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_shield.FormattingEnabled = True
        Me.prime_shield.Items.AddRange(New Object() {"PRIME SHIELD", "375_Ash", "300_Banshee", "375_Ember", "300_Excalibur", "525_Frost", "225_Loki", "450_Mag", "450_Nekros", "300_Nova", "375_Nyx", "300_Oberon", "450_Rhino", "300_Saryn", "450_Trinity", "150_Valkyr", "300_Vauban", "450_Volt"})
        Me.prime_shield.Location = New System.Drawing.Point(129, 239)
        Me.prime_shield.Name = "prime_shield"
        Me.prime_shield.Size = New System.Drawing.Size(120, 24)
        Me.prime_shield.TabIndex = 70
        '
        'prime_health
        '
        Me.prime_health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_health.FormattingEnabled = True
        Me.prime_health.Items.AddRange(New Object() {"PRIME HEALTH", "450_Ash", "300_Banshee", "300_Ember", "300_Excalibur", "300_Frost", "225_Loki", "300_Mag", "300_Nekros", "300_Nova", "300_Nyx", "375_Oberon", "300_Rhino", "375_Saryn", "300_Trinity", "300_Valkyr", "300_Vauban", "300_Volt"})
        Me.prime_health.Location = New System.Drawing.Point(129, 209)
        Me.prime_health.Name = "prime_health"
        Me.prime_health.Size = New System.Drawing.Size(120, 24)
        Me.prime_health.TabIndex = 69
        '
        'prime_armor
        '
        Me.prime_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_armor.FormattingEnabled = True
        Me.prime_armor.Items.AddRange(New Object() {"PRIME ARMOR", "150_Ash", "65_Banshee", "125_Ember", "250_Excalibur", "300_Frost", "65_Loki", "65_Mag", "65_Nekros", "65_Nova", "50_Nyx", "225_Oberon", "275_Rhino", "225_Saryn", "15_Trinity", "700_Valkyr", "100_Vauban", "100_Volt"})
        Me.prime_armor.Location = New System.Drawing.Point(129, 179)
        Me.prime_armor.Name = "prime_armor"
        Me.prime_armor.Size = New System.Drawing.Size(120, 24)
        Me.prime_armor.TabIndex = 68
        '
        'prime_base_power
        '
        Me.prime_base_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_base_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_base_power.FormattingEnabled = True
        Me.prime_base_power.Items.AddRange(New Object() {"PRIME BASE POWER", "100_Ash", "175_Banshee", "150_Ember", "100_Excalibur", "100_Frost", "175_Loki", "100_Mag", "125_Nekros", "175_Nova", "150_Nyx", "175_Oberon", "100_Rhino", "200_Saryn", "150_Trinity", "150_Valkyr", "150_Vauban", "200_Volt"})
        Me.prime_base_power.Location = New System.Drawing.Point(3, 269)
        Me.prime_base_power.Name = "prime_base_power"
        Me.prime_base_power.Size = New System.Drawing.Size(120, 24)
        Me.prime_base_power.TabIndex = 67
        '
        'prime_base_shield
        '
        Me.prime_base_shield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_base_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_base_shield.FormattingEnabled = True
        Me.prime_base_shield.Items.AddRange(New Object() {"PRIME BASE SHIELD", "125_Ash", "100_Banshee", "125_Ember", "100_Excalibur", "175_Frost", "75_Loki", "150_Mag", "150_Nekros", "100_Nova", "125_Nyx", "100_Oberon", "150_Rhino", "100_Saryn", "150_Trinity", "50_Valkyr", "100_Vauban", "150_Volt"})
        Me.prime_base_shield.Location = New System.Drawing.Point(3, 239)
        Me.prime_base_shield.Name = "prime_base_shield"
        Me.prime_base_shield.Size = New System.Drawing.Size(120, 24)
        Me.prime_base_shield.TabIndex = 66
        '
        'prime_base_health
        '
        Me.prime_base_health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_base_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_base_health.FormattingEnabled = True
        Me.prime_base_health.Items.AddRange(New Object() {"PRIME BASE HEALTH", "150_Ash", "100_Banshee", "100_Ember", "100_Excalibur", "100_Frost", "75_Loki", "100_Mag", "100_Nekros", "100_Nova", "100_Nyx", "125_Oberon", "100_Rhino", "125_Saryn", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt"})
        Me.prime_base_health.Location = New System.Drawing.Point(3, 209)
        Me.prime_base_health.Name = "prime_base_health"
        Me.prime_base_health.Size = New System.Drawing.Size(120, 24)
        Me.prime_base_health.TabIndex = 65
        '
        'prime_base_armor
        '
        Me.prime_base_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prime_base_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prime_base_armor.FormattingEnabled = True
        Me.prime_base_armor.Items.AddRange(New Object() {"PRIME BASE ARMOR", "150_Ash", "65_Banshee", "125_Ember", "250_Excalibur", "300_Frost", "65_Loki", "65_Mag", "65_Nekros", "65_Nova", "50_Nyx", "225_Oberon", "275_Rhino", "225_Saryn", "15_Trinity", "700_Valkyr", "100_Vauban", "100_Volt"})
        Me.prime_base_armor.Location = New System.Drawing.Point(3, 179)
        Me.prime_base_armor.Name = "prime_base_armor"
        Me.prime_base_armor.Size = New System.Drawing.Size(120, 24)
        Me.prime_base_armor.TabIndex = 64
        '
        'cb_primes
        '
        Me.cb_primes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_primes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_primes.FormattingEnabled = True
        Me.cb_primes.Items.AddRange(New Object() {"PRIMES", "Ash", "Banshee", "Ember", "Excalibur", "Frost", "Loki", "Mag", "Nekros", "Nova", "Nyx", "Oberon", "Rhino", "Saryn", "Trinity", "Valkyr", "Vauban", "Volt"})
        Me.cb_primes.Location = New System.Drawing.Point(3, 149)
        Me.cb_primes.Name = "cb_primes"
        Me.cb_primes.Size = New System.Drawing.Size(246, 24)
        Me.cb_primes.TabIndex = 49
        '
        'cb_shield_pet
        '
        Me.cb_shield_pet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_shield_pet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_shield_pet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_shield_pet.FormattingEnabled = True
        Me.cb_shield_pet.Items.AddRange(New Object() {"PET SHIELD", "210_Adarza", "180_Smeeta", "225_Chesa", "375_Huras", "300_Raksa", "225_Sahasa", "270_Sunika", "225_HelminthCharger"})
        Me.cb_shield_pet.Location = New System.Drawing.Point(3, 559)
        Me.cb_shield_pet.Name = "cb_shield_pet"
        Me.cb_shield_pet.Size = New System.Drawing.Size(248, 24)
        Me.cb_shield_pet.TabIndex = 63
        '
        'cb_health_pet
        '
        Me.cb_health_pet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_health_pet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_health_pet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_health_pet.FormattingEnabled = True
        Me.cb_health_pet.Items.AddRange(New Object() {"PET HEALTH", "240_Adarza", "300_Smeeta", "375_Chesa", "75_Huras", "300_Raksa", "375_Sahasa", "330_Sunika", "285_HelminthCharger"})
        Me.cb_health_pet.Location = New System.Drawing.Point(3, 529)
        Me.cb_health_pet.Name = "cb_health_pet"
        Me.cb_health_pet.Size = New System.Drawing.Size(248, 24)
        Me.cb_health_pet.TabIndex = 62
        '
        'cb_armor_pet
        '
        Me.cb_armor_pet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_armor_pet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_armor_pet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_armor_pet.FormattingEnabled = True
        Me.cb_armor_pet.Items.AddRange(New Object() {"PET ARMOR", "40_Adarza", "50_Smeeta", "50_Chesa", "50_Huras", "50_Raksa", "50_Sahasa", "50_Sunika", "50_HelminthCharger"})
        Me.cb_armor_pet.Location = New System.Drawing.Point(3, 499)
        Me.cb_armor_pet.Name = "cb_armor_pet"
        Me.cb_armor_pet.Size = New System.Drawing.Size(248, 24)
        Me.cb_armor_pet.TabIndex = 61
        '
        'cb_power
        '
        Me.cb_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_power.FormattingEnabled = True
        Me.cb_power.Items.AddRange(New Object() {"POWER", "150_Ash", "225_Atlas", "225_Banshee", "225_Chroma", "225_Ember", "225_Equinox", "150_Excalibur", "150_Frost", "150_Hydroid", "150_Inaros", "262.5_Ivara", "225_Limbo", "225_Loki", "150_Mag", "150_Mesa", "225_Mirage", "150_Nekros", "225_Nezha", "150_Nidus", "225_Nova", "225_Nyx", "225_Oberon", "225_Octavia", "150_Rhino", "225_Saryn", "150_Titania", "225_Trinity", "150_Valkyr", "225_Vauban", "150_Volt", "150_Wukong", "150_Zephyr"})
        Me.cb_power.Location = New System.Drawing.Point(130, 106)
        Me.cb_power.Name = "cb_power"
        Me.cb_power.Size = New System.Drawing.Size(120, 24)
        Me.cb_power.TabIndex = 57
        '
        'cb_shield
        '
        Me.cb_shield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_shield.FormattingEnabled = True
        Me.cb_shield.Items.AddRange(New Object() {"SHIELD", "300_Ash", "300_Atlas", "300_Banshee", "300_Chroma", "300_Ember", "300_Equinox", "300_Excalibur", "450_Frost", "345_Hydroid", "0_Inaros", "300_Ivara", "225_Limbo", "225_Loki", "450_Mag", "225_Mesa", "240_Mirage", "270_Nekros", "225_Nezha", "0_Nidus", "225_Nova", "300_Nyx", "300_Oberon", "225_Octavia", "450_Rhino", "300_Saryn", "300_Titania", "300_Trinity", "150_Valkyr", "225_Vauban", "450_Volt", "375_Wukong", "450_Zephyr"})
        Me.cb_shield.Location = New System.Drawing.Point(130, 76)
        Me.cb_shield.Name = "cb_shield"
        Me.cb_shield.Size = New System.Drawing.Size(120, 24)
        Me.cb_shield.TabIndex = 56
        '
        'cb_health
        '
        Me.cb_health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_health.FormattingEnabled = True
        Me.cb_health.Items.AddRange(New Object() {"HEALTH", "450_Ash", "300_Atlas", "300_Banshee", "300_Chroma", "300_Ember", "300_Equinox", "300_Excalibur", "300_Frost", "300_Hydroid", "2200_Inaros", "225_Ivara", "300_Limbo", "225_Loki", "255_Mag", "375_Mesa", "240_Mirage", "300_Nekros", "225_Nezha", "450_Nidus", "300_Nova", "300_Nyx", "375_Oberon", "300_Octavia", "300_Rhino", "375_Saryn", "300_Titania", "300_Trinity", "300_Valkyr", "300_Vauban", "300_Volt", "300_Wukong", "450_Zephyr"})
        Me.cb_health.Location = New System.Drawing.Point(130, 46)
        Me.cb_health.Name = "cb_health"
        Me.cb_health.Size = New System.Drawing.Size(120, 24)
        Me.cb_health.TabIndex = 55
        '
        'cb_armor
        '
        Me.cb_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_armor.FormattingEnabled = True
        Me.cb_armor.Items.AddRange(New Object() {"ARMOR", "65_Ash", "450_Atlas", "15_Banshee", "350_Chroma", "100_Ember", "100_Equinox", "225_Excalibur", "300_Frost", "65_Hydroid", "200_Inaros", "65_Ivara", "65_Limbo", "65_Loki", "65_Mag", "65_Mesa", "65_Mirage", "65_Nekros", "175_Nezha", "450_Nidus", "65_Nova", "15_Nyx", "150_Oberon", "125_Octavia", "190_Rhino", "175_Saryn", "65_Titania", "15_Trinity", "600_Valkyr", "50_Vauban", "15_Volt", "225_Wukong", "15_Zephyr"})
        Me.cb_armor.Location = New System.Drawing.Point(130, 16)
        Me.cb_armor.Name = "cb_armor"
        Me.cb_armor.Size = New System.Drawing.Size(120, 24)
        Me.cb_armor.TabIndex = 54
        '
        'cb_base_power
        '
        Me.cb_base_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_base_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_base_power.FormattingEnabled = True
        Me.cb_base_power.Items.AddRange(New Object() {"BASE POWER", "100_Ash", "150_Atlas", "150_Banshee", "150_Chroma", "150_Ember", "150_Equinox", "100_Excalibur", "100_Frost", "100_Hydroid", "100_Inaros", "175_Ivara", "150_Limbo", "150_Loki", "100_Mag", "100_Mesa", "150_Mirage", "100_Nekros", "150_Nezha", "100_Nidus", "150_Nova", "150_Nyx", "150_Oberon", "150_Octavia", "100_Rhino", "150_Saryn", "100_Titania", "150_Trinity", "100_Valkyr", "150_Vauban", "100_Volt", "100_Wukong", "100_Zephyr"})
        Me.cb_base_power.Location = New System.Drawing.Point(4, 106)
        Me.cb_base_power.Name = "cb_base_power"
        Me.cb_base_power.Size = New System.Drawing.Size(120, 24)
        Me.cb_base_power.TabIndex = 53
        '
        'cb_base_shield
        '
        Me.cb_base_shield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_base_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_base_shield.FormattingEnabled = True
        Me.cb_base_shield.Items.AddRange(New Object() {"BASE SHIELD", "100_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "150_Frost", "115_Hydroid", "0_Inaros", "100_Ivara", "75_Limbo", "75_Loki", "150_Mag", "75_Mesa", "80_Mirage", "90_Nekros", "75_Nezha", "0_Nidus", "75_Nova", "100_Nyx", "100_Oberon", "75_Octavia", "150_Rhino", "100_Saryn", "100_Titania", "100_Trinity", "50_Valkyr", "75_Vauban", "150_Volt", "125_Wukong", "150_Zephyr"})
        Me.cb_base_shield.Location = New System.Drawing.Point(4, 76)
        Me.cb_base_shield.Name = "cb_base_shield"
        Me.cb_base_shield.Size = New System.Drawing.Size(120, 24)
        Me.cb_base_shield.TabIndex = 52
        '
        'cb_base_health
        '
        Me.cb_base_health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_base_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_base_health.FormattingEnabled = True
        Me.cb_base_health.Items.AddRange(New Object() {"BASE HEALTH", "150_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "100_Frost", "100_Hydroid", "550_Inaros", "75_Ivara", "100_Limbo", "75_Loki", "75_Mag", "125_Mesa", "80_Mirage", "100_Nekros", "75_Nezha", "150_Nidus", "100_Nova", "100_Nyx", "125_Oberon", "100_Octavia", "100_Rhino", "125_Saryn", "100_Titania", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt", "100_Wukong", "150_Zephyr"})
        Me.cb_base_health.Location = New System.Drawing.Point(4, 46)
        Me.cb_base_health.Name = "cb_base_health"
        Me.cb_base_health.Size = New System.Drawing.Size(120, 24)
        Me.cb_base_health.TabIndex = 51
        '
        'cb_base_armor
        '
        Me.cb_base_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_base_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_base_armor.FormattingEnabled = True
        Me.cb_base_armor.Items.AddRange(New Object() {"BASE ARMOR", "65_Ash", "450_Atlas", "15_Banshee", "350_Chroma", "100_Ember", "100_Equinox", "225_Excalibur", "300_Frost", "65_Hydroid", "200_Inaros", "65_Ivara", "65_Limbo", "65_Loki", "65_Mag", "65_Mesa", "65_Mirage", "65_Nekros", "175_Nezha", "300_Nidus", "65_Nova", "15_Nyx", "150_Oberon", "125_Octavia", "190_Rhino", "175_Saryn", "65_Titania", "15_Trinity", "600_Valkyr", "50_Vauban", "15_Volt", "225_Wukong", "15_Zephyr"})
        Me.cb_base_armor.Location = New System.Drawing.Point(4, 16)
        Me.cb_base_armor.Name = "cb_base_armor"
        Me.cb_base_armor.Size = New System.Drawing.Size(120, 24)
        Me.cb_base_armor.TabIndex = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.volt_panel)
        Me.GroupBox4.Controls.Add(Me.vauban_panel)
        Me.GroupBox4.Controls.Add(Me.trinity_panel)
        Me.GroupBox4.Controls.Add(Me.saryn_panel)
        Me.GroupBox4.Controls.Add(Me.rhino_panel)
        Me.GroupBox4.Controls.Add(Me.nyx_panel)
        Me.GroupBox4.Controls.Add(Me.nova_panel)
        Me.GroupBox4.Controls.Add(Me.mag_panel)
        Me.GroupBox4.Controls.Add(Me.loki_panel)
        Me.GroupBox4.Controls.Add(Me.key_decaying)
        Me.GroupBox4.Controls.Add(Me.key_bleeding)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.arcane_ultimatum_val)
        Me.GroupBox4.Controls.Add(Me.arcane_ultimatum)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.arcane_guardian_val)
        Me.GroupBox4.Controls.Add(Me.arcane_guardian)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.wf_dmgreduc_val)
        Me.GroupBox4.Controls.Add(Me.x_armor)
        Me.GroupBox4.Controls.Add(Me.wf_dmgreduc)
        Me.GroupBox4.Controls.Add(Me.x_shield_val)
        Me.GroupBox4.Controls.Add(Me.x_armor_val)
        Me.GroupBox4.Controls.Add(Me.x_health)
        Me.GroupBox4.Controls.Add(Me.x_health_val)
        Me.GroupBox4.Controls.Add(Me.x_shield)
        Me.GroupBox4.Controls.Add(Me.frost_panel)
        Me.GroupBox4.Controls.Add(Me.ember_panel)
        Me.GroupBox4.Controls.Add(Me.banshee_panel)
        Me.GroupBox4.Controls.Add(Me.excalibur_panel)
        Me.GroupBox4.Controls.Add(Me.ash_panel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(542, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 422)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extra"
        '
        'volt_panel
        '
        Me.volt_panel.Controls.Add(Me.volt_None)
        Me.volt_panel.Controls.Add(Me.Label21)
        Me.volt_panel.Controls.Add(Me.volt_Pulse)
        Me.volt_panel.Location = New System.Drawing.Point(1, 320)
        Me.volt_panel.Name = "volt_panel"
        Me.volt_panel.Size = New System.Drawing.Size(230, 100)
        Me.volt_panel.TabIndex = 59
        Me.volt_panel.Visible = False
        '
        'volt_None
        '
        Me.volt_None.AutoSize = True
        Me.volt_None.Checked = True
        Me.volt_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.volt_None.Location = New System.Drawing.Point(10, 50)
        Me.volt_None.Name = "volt_None"
        Me.volt_None.Size = New System.Drawing.Size(69, 24)
        Me.volt_None.TabIndex = 57
        Me.volt_None.TabStop = True
        Me.volt_None.Text = "None"
        Me.volt_None.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(151, 22)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Arcane Helmets"
        '
        'volt_Pulse
        '
        Me.volt_Pulse.AutoSize = True
        Me.volt_Pulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.volt_Pulse.Location = New System.Drawing.Point(10, 25)
        Me.volt_Pulse.Name = "volt_Pulse"
        Me.volt_Pulse.Size = New System.Drawing.Size(133, 24)
        Me.volt_Pulse.TabIndex = 0
        Me.volt_Pulse.Text = "Pulse Helmet"
        Me.volt_Pulse.UseVisualStyleBackColor = True
        '
        'vauban_panel
        '
        Me.vauban_panel.Controls.Add(Me.vauban_None)
        Me.vauban_panel.Controls.Add(Me.Label32)
        Me.vauban_panel.Controls.Add(Me.vauban_Esprit)
        Me.vauban_panel.Location = New System.Drawing.Point(1, 320)
        Me.vauban_panel.Name = "vauban_panel"
        Me.vauban_panel.Size = New System.Drawing.Size(230, 100)
        Me.vauban_panel.TabIndex = 60
        Me.vauban_panel.Visible = False
        '
        'vauban_None
        '
        Me.vauban_None.AutoSize = True
        Me.vauban_None.Checked = True
        Me.vauban_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vauban_None.Location = New System.Drawing.Point(10, 50)
        Me.vauban_None.Name = "vauban_None"
        Me.vauban_None.Size = New System.Drawing.Size(69, 24)
        Me.vauban_None.TabIndex = 57
        Me.vauban_None.TabStop = True
        Me.vauban_None.Text = "None"
        Me.vauban_None.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 2)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(151, 22)
        Me.Label32.TabIndex = 56
        Me.Label32.Text = "Arcane Helmets"
        '
        'vauban_Esprit
        '
        Me.vauban_Esprit.AutoSize = True
        Me.vauban_Esprit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vauban_Esprit.Location = New System.Drawing.Point(10, 25)
        Me.vauban_Esprit.Name = "vauban_Esprit"
        Me.vauban_Esprit.Size = New System.Drawing.Size(136, 24)
        Me.vauban_Esprit.TabIndex = 0
        Me.vauban_Esprit.Text = "Esprit Helmet"
        Me.vauban_Esprit.UseVisualStyleBackColor = True
        '
        'trinity_panel
        '
        Me.trinity_panel.Controls.Add(Me.trinity_None)
        Me.trinity_panel.Controls.Add(Me.Label31)
        Me.trinity_panel.Controls.Add(Me.trinity_Meridian)
        Me.trinity_panel.Controls.Add(Me.trinity_Aura)
        Me.trinity_panel.Location = New System.Drawing.Point(1, 320)
        Me.trinity_panel.Name = "trinity_panel"
        Me.trinity_panel.Size = New System.Drawing.Size(230, 100)
        Me.trinity_panel.TabIndex = 59
        Me.trinity_panel.Visible = False
        '
        'trinity_None
        '
        Me.trinity_None.AutoSize = True
        Me.trinity_None.Checked = True
        Me.trinity_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.trinity_None.Location = New System.Drawing.Point(10, 76)
        Me.trinity_None.Name = "trinity_None"
        Me.trinity_None.Size = New System.Drawing.Size(69, 24)
        Me.trinity_None.TabIndex = 57
        Me.trinity_None.TabStop = True
        Me.trinity_None.Text = "None"
        Me.trinity_None.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 2)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(151, 22)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "Arcane Helmets"
        '
        'trinity_Meridian
        '
        Me.trinity_Meridian.AutoSize = True
        Me.trinity_Meridian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.trinity_Meridian.Location = New System.Drawing.Point(10, 50)
        Me.trinity_Meridian.Name = "trinity_Meridian"
        Me.trinity_Meridian.Size = New System.Drawing.Size(157, 24)
        Me.trinity_Meridian.TabIndex = 1
        Me.trinity_Meridian.Text = "Meridian Helmet"
        Me.trinity_Meridian.UseVisualStyleBackColor = True
        '
        'trinity_Aura
        '
        Me.trinity_Aura.AutoSize = True
        Me.trinity_Aura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.trinity_Aura.Location = New System.Drawing.Point(10, 25)
        Me.trinity_Aura.Name = "trinity_Aura"
        Me.trinity_Aura.Size = New System.Drawing.Size(127, 24)
        Me.trinity_Aura.TabIndex = 0
        Me.trinity_Aura.Text = "Aura Helmet"
        Me.trinity_Aura.UseVisualStyleBackColor = True
        '
        'saryn_panel
        '
        Me.saryn_panel.Controls.Add(Me.saryn_None)
        Me.saryn_panel.Controls.Add(Me.Label30)
        Me.saryn_panel.Controls.Add(Me.saryn_Hemlock)
        Me.saryn_panel.Location = New System.Drawing.Point(1, 320)
        Me.saryn_panel.Name = "saryn_panel"
        Me.saryn_panel.Size = New System.Drawing.Size(230, 100)
        Me.saryn_panel.TabIndex = 60
        Me.saryn_panel.Visible = False
        '
        'saryn_None
        '
        Me.saryn_None.AutoSize = True
        Me.saryn_None.Checked = True
        Me.saryn_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.saryn_None.Location = New System.Drawing.Point(10, 50)
        Me.saryn_None.Name = "saryn_None"
        Me.saryn_None.Size = New System.Drawing.Size(69, 24)
        Me.saryn_None.TabIndex = 57
        Me.saryn_None.TabStop = True
        Me.saryn_None.Text = "None"
        Me.saryn_None.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 2)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(151, 22)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Arcane Helmets"
        '
        'saryn_Hemlock
        '
        Me.saryn_Hemlock.AutoSize = True
        Me.saryn_Hemlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.saryn_Hemlock.Location = New System.Drawing.Point(10, 25)
        Me.saryn_Hemlock.Name = "saryn_Hemlock"
        Me.saryn_Hemlock.Size = New System.Drawing.Size(158, 24)
        Me.saryn_Hemlock.TabIndex = 0
        Me.saryn_Hemlock.Text = "Hemlock Helmet"
        Me.saryn_Hemlock.UseVisualStyleBackColor = True
        '
        'rhino_panel
        '
        Me.rhino_panel.Controls.Add(Me.rhino_None)
        Me.rhino_panel.Controls.Add(Me.Label29)
        Me.rhino_panel.Controls.Add(Me.rhino_Thrak)
        Me.rhino_panel.Location = New System.Drawing.Point(1, 320)
        Me.rhino_panel.Name = "rhino_panel"
        Me.rhino_panel.Size = New System.Drawing.Size(230, 100)
        Me.rhino_panel.TabIndex = 60
        Me.rhino_panel.Visible = False
        '
        'rhino_None
        '
        Me.rhino_None.AutoSize = True
        Me.rhino_None.Checked = True
        Me.rhino_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rhino_None.Location = New System.Drawing.Point(10, 50)
        Me.rhino_None.Name = "rhino_None"
        Me.rhino_None.Size = New System.Drawing.Size(69, 24)
        Me.rhino_None.TabIndex = 57
        Me.rhino_None.TabStop = True
        Me.rhino_None.Text = "None"
        Me.rhino_None.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 2)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(151, 22)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "Arcane Helmets"
        '
        'rhino_Thrak
        '
        Me.rhino_Thrak.AutoSize = True
        Me.rhino_Thrak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rhino_Thrak.Location = New System.Drawing.Point(10, 25)
        Me.rhino_Thrak.Name = "rhino_Thrak"
        Me.rhino_Thrak.Size = New System.Drawing.Size(134, 24)
        Me.rhino_Thrak.TabIndex = 0
        Me.rhino_Thrak.Text = "Thrak Helmet"
        Me.rhino_Thrak.UseVisualStyleBackColor = True
        '
        'nyx_panel
        '
        Me.nyx_panel.Controls.Add(Me.nyx_None)
        Me.nyx_panel.Controls.Add(Me.Label28)
        Me.nyx_panel.Controls.Add(Me.nyx_Vespa)
        Me.nyx_panel.Controls.Add(Me.nyx_Menticide)
        Me.nyx_panel.Location = New System.Drawing.Point(1, 320)
        Me.nyx_panel.Name = "nyx_panel"
        Me.nyx_panel.Size = New System.Drawing.Size(230, 100)
        Me.nyx_panel.TabIndex = 59
        Me.nyx_panel.Visible = False
        '
        'nyx_None
        '
        Me.nyx_None.AutoSize = True
        Me.nyx_None.Checked = True
        Me.nyx_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nyx_None.Location = New System.Drawing.Point(10, 76)
        Me.nyx_None.Name = "nyx_None"
        Me.nyx_None.Size = New System.Drawing.Size(69, 24)
        Me.nyx_None.TabIndex = 57
        Me.nyx_None.TabStop = True
        Me.nyx_None.Text = "None"
        Me.nyx_None.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 2)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(151, 22)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "Arcane Helmets"
        '
        'nyx_Vespa
        '
        Me.nyx_Vespa.AutoSize = True
        Me.nyx_Vespa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nyx_Vespa.Location = New System.Drawing.Point(10, 50)
        Me.nyx_Vespa.Name = "nyx_Vespa"
        Me.nyx_Vespa.Size = New System.Drawing.Size(140, 24)
        Me.nyx_Vespa.TabIndex = 1
        Me.nyx_Vespa.Text = "Vespa Helmet"
        Me.nyx_Vespa.UseVisualStyleBackColor = True
        '
        'nyx_Menticide
        '
        Me.nyx_Menticide.AutoSize = True
        Me.nyx_Menticide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nyx_Menticide.Location = New System.Drawing.Point(10, 25)
        Me.nyx_Menticide.Name = "nyx_Menticide"
        Me.nyx_Menticide.Size = New System.Drawing.Size(166, 24)
        Me.nyx_Menticide.TabIndex = 0
        Me.nyx_Menticide.Text = "Menticide Helmet"
        Me.nyx_Menticide.UseVisualStyleBackColor = True
        '
        'nova_panel
        '
        Me.nova_panel.Controls.Add(Me.nova_None)
        Me.nova_panel.Controls.Add(Me.Label27)
        Me.nova_panel.Controls.Add(Me.nova_Flux)
        Me.nova_panel.Location = New System.Drawing.Point(1, 320)
        Me.nova_panel.Name = "nova_panel"
        Me.nova_panel.Size = New System.Drawing.Size(230, 100)
        Me.nova_panel.TabIndex = 60
        Me.nova_panel.Visible = False
        '
        'nova_None
        '
        Me.nova_None.AutoSize = True
        Me.nova_None.Checked = True
        Me.nova_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nova_None.Location = New System.Drawing.Point(10, 50)
        Me.nova_None.Name = "nova_None"
        Me.nova_None.Size = New System.Drawing.Size(69, 24)
        Me.nova_None.TabIndex = 57
        Me.nova_None.TabStop = True
        Me.nova_None.Text = "None"
        Me.nova_None.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 2)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(151, 22)
        Me.Label27.TabIndex = 56
        Me.Label27.Text = "Arcane Helmets"
        '
        'nova_Flux
        '
        Me.nova_Flux.AutoSize = True
        Me.nova_Flux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nova_Flux.Location = New System.Drawing.Point(10, 25)
        Me.nova_Flux.Name = "nova_Flux"
        Me.nova_Flux.Size = New System.Drawing.Size(122, 24)
        Me.nova_Flux.TabIndex = 0
        Me.nova_Flux.Text = "Flux Helmet"
        Me.nova_Flux.UseVisualStyleBackColor = True
        '
        'mag_panel
        '
        Me.mag_panel.Controls.Add(Me.mag_None)
        Me.mag_panel.Controls.Add(Me.Label26)
        Me.mag_panel.Controls.Add(Me.mag_Gauss)
        Me.mag_panel.Controls.Add(Me.mag_Coil)
        Me.mag_panel.Location = New System.Drawing.Point(1, 320)
        Me.mag_panel.Name = "mag_panel"
        Me.mag_panel.Size = New System.Drawing.Size(230, 100)
        Me.mag_panel.TabIndex = 59
        Me.mag_panel.Visible = False
        '
        'mag_None
        '
        Me.mag_None.AutoSize = True
        Me.mag_None.Checked = True
        Me.mag_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mag_None.Location = New System.Drawing.Point(10, 76)
        Me.mag_None.Name = "mag_None"
        Me.mag_None.Size = New System.Drawing.Size(69, 24)
        Me.mag_None.TabIndex = 57
        Me.mag_None.TabStop = True
        Me.mag_None.Text = "None"
        Me.mag_None.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(151, 22)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Arcane Helmets"
        '
        'mag_Gauss
        '
        Me.mag_Gauss.AutoSize = True
        Me.mag_Gauss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mag_Gauss.Location = New System.Drawing.Point(10, 50)
        Me.mag_Gauss.Name = "mag_Gauss"
        Me.mag_Gauss.Size = New System.Drawing.Size(141, 24)
        Me.mag_Gauss.TabIndex = 1
        Me.mag_Gauss.Text = "Gauss Helmet"
        Me.mag_Gauss.UseVisualStyleBackColor = True
        '
        'mag_Coil
        '
        Me.mag_Coil.AutoSize = True
        Me.mag_Coil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mag_Coil.Location = New System.Drawing.Point(10, 25)
        Me.mag_Coil.Name = "mag_Coil"
        Me.mag_Coil.Size = New System.Drawing.Size(119, 24)
        Me.mag_Coil.TabIndex = 0
        Me.mag_Coil.Text = "Coil Helmet"
        Me.mag_Coil.UseVisualStyleBackColor = True
        '
        'loki_panel
        '
        Me.loki_panel.Controls.Add(Me.loki_None)
        Me.loki_panel.Controls.Add(Me.Label25)
        Me.loki_panel.Controls.Add(Me.loki_Swindle)
        Me.loki_panel.Controls.Add(Me.loki_Essence)
        Me.loki_panel.Location = New System.Drawing.Point(1, 320)
        Me.loki_panel.Name = "loki_panel"
        Me.loki_panel.Size = New System.Drawing.Size(230, 100)
        Me.loki_panel.TabIndex = 59
        Me.loki_panel.Visible = False
        '
        'loki_None
        '
        Me.loki_None.AutoSize = True
        Me.loki_None.Checked = True
        Me.loki_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loki_None.Location = New System.Drawing.Point(10, 76)
        Me.loki_None.Name = "loki_None"
        Me.loki_None.Size = New System.Drawing.Size(69, 24)
        Me.loki_None.TabIndex = 57
        Me.loki_None.TabStop = True
        Me.loki_None.Text = "None"
        Me.loki_None.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 2)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(151, 22)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Arcane Helmets"
        '
        'loki_Swindle
        '
        Me.loki_Swindle.AutoSize = True
        Me.loki_Swindle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loki_Swindle.Location = New System.Drawing.Point(10, 50)
        Me.loki_Swindle.Name = "loki_Swindle"
        Me.loki_Swindle.Size = New System.Drawing.Size(151, 24)
        Me.loki_Swindle.TabIndex = 1
        Me.loki_Swindle.Text = "Swindle Helmet"
        Me.loki_Swindle.UseVisualStyleBackColor = True
        '
        'loki_Essence
        '
        Me.loki_Essence.AutoSize = True
        Me.loki_Essence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loki_Essence.Location = New System.Drawing.Point(10, 25)
        Me.loki_Essence.Name = "loki_Essence"
        Me.loki_Essence.Size = New System.Drawing.Size(158, 24)
        Me.loki_Essence.TabIndex = 0
        Me.loki_Essence.Text = "Essence Helmet"
        Me.loki_Essence.UseVisualStyleBackColor = True
        '
        'key_decaying
        '
        Me.key_decaying.AutoSize = True
        Me.key_decaying.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key_decaying.Location = New System.Drawing.Point(11, 299)
        Me.key_decaying.Name = "key_decaying"
        Me.key_decaying.Size = New System.Drawing.Size(136, 24)
        Me.key_decaying.TabIndex = 57
        Me.key_decaying.Text = "Decaying Key"
        Me.key_decaying.UseVisualStyleBackColor = True
        '
        'key_bleeding
        '
        Me.key_bleeding.AutoSize = True
        Me.key_bleeding.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key_bleeding.Location = New System.Drawing.Point(11, 272)
        Me.key_bleeding.Name = "key_bleeding"
        Me.key_bleeding.Size = New System.Drawing.Size(132, 24)
        Me.key_bleeding.TabIndex = 56
        Me.key_bleeding.Text = "Bleeding Key"
        Me.key_bleeding.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 22)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Dragon Keys"
        '
        'arcane_ultimatum_val
        '
        Me.arcane_ultimatum_val.Enabled = False
        Me.arcane_ultimatum_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcane_ultimatum_val.Location = New System.Drawing.Point(181, 222)
        Me.arcane_ultimatum_val.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.arcane_ultimatum_val.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.arcane_ultimatum_val.Name = "arcane_ultimatum_val"
        Me.arcane_ultimatum_val.Size = New System.Drawing.Size(36, 21)
        Me.arcane_ultimatum_val.TabIndex = 54
        Me.arcane_ultimatum_val.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'arcane_ultimatum
        '
        Me.arcane_ultimatum.AutoSize = True
        Me.arcane_ultimatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcane_ultimatum.Location = New System.Drawing.Point(11, 220)
        Me.arcane_ultimatum.Name = "arcane_ultimatum"
        Me.arcane_ultimatum.Size = New System.Drawing.Size(176, 24)
        Me.arcane_ultimatum.TabIndex = 53
        Me.arcane_ultimatum.Text = "Arcane Ultimatum:"
        Me.arcane_ultimatum.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 22)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Arcanes"
        '
        'arcane_guardian_val
        '
        Me.arcane_guardian_val.Enabled = False
        Me.arcane_guardian_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcane_guardian_val.Location = New System.Drawing.Point(181, 195)
        Me.arcane_guardian_val.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.arcane_guardian_val.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.arcane_guardian_val.Name = "arcane_guardian_val"
        Me.arcane_guardian_val.Size = New System.Drawing.Size(36, 21)
        Me.arcane_guardian_val.TabIndex = 51
        Me.arcane_guardian_val.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'arcane_guardian
        '
        Me.arcane_guardian.AutoSize = True
        Me.arcane_guardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arcane_guardian.Location = New System.Drawing.Point(11, 193)
        Me.arcane_guardian.Name = "arcane_guardian"
        Me.arcane_guardian.Size = New System.Drawing.Size(169, 24)
        Me.arcane_guardian.TabIndex = 47
        Me.arcane_guardian.Text = "Arcane Guardian:"
        Me.arcane_guardian.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 22)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Added by Abilities"
        '
        'frost_panel
        '
        Me.frost_panel.Controls.Add(Me.frost_None)
        Me.frost_panel.Controls.Add(Me.Label24)
        Me.frost_panel.Controls.Add(Me.frost_Squall)
        Me.frost_panel.Controls.Add(Me.frost_Aurora)
        Me.frost_panel.Location = New System.Drawing.Point(1, 320)
        Me.frost_panel.Name = "frost_panel"
        Me.frost_panel.Size = New System.Drawing.Size(230, 100)
        Me.frost_panel.TabIndex = 59
        Me.frost_panel.Visible = False
        '
        'frost_None
        '
        Me.frost_None.AutoSize = True
        Me.frost_None.Checked = True
        Me.frost_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.frost_None.Location = New System.Drawing.Point(10, 76)
        Me.frost_None.Name = "frost_None"
        Me.frost_None.Size = New System.Drawing.Size(69, 24)
        Me.frost_None.TabIndex = 57
        Me.frost_None.TabStop = True
        Me.frost_None.Text = "None"
        Me.frost_None.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 2)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(151, 22)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "Arcane Helmets"
        '
        'frost_Squall
        '
        Me.frost_Squall.AutoSize = True
        Me.frost_Squall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.frost_Squall.Location = New System.Drawing.Point(10, 50)
        Me.frost_Squall.Name = "frost_Squall"
        Me.frost_Squall.Size = New System.Drawing.Size(139, 24)
        Me.frost_Squall.TabIndex = 1
        Me.frost_Squall.Text = "Squall Helmet"
        Me.frost_Squall.UseVisualStyleBackColor = True
        '
        'frost_Aurora
        '
        Me.frost_Aurora.AutoSize = True
        Me.frost_Aurora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.frost_Aurora.Location = New System.Drawing.Point(10, 25)
        Me.frost_Aurora.Name = "frost_Aurora"
        Me.frost_Aurora.Size = New System.Drawing.Size(143, 24)
        Me.frost_Aurora.TabIndex = 0
        Me.frost_Aurora.Text = "Aurora Helmet"
        Me.frost_Aurora.UseVisualStyleBackColor = True
        '
        'ember_panel
        '
        Me.ember_panel.Controls.Add(Me.ember_None)
        Me.ember_panel.Controls.Add(Me.Label18)
        Me.ember_panel.Controls.Add(Me.ember_Backdraft)
        Me.ember_panel.Controls.Add(Me.ember_Phoenix)
        Me.ember_panel.Location = New System.Drawing.Point(1, 320)
        Me.ember_panel.Name = "ember_panel"
        Me.ember_panel.Size = New System.Drawing.Size(230, 100)
        Me.ember_panel.TabIndex = 52
        Me.ember_panel.Visible = False
        '
        'ember_None
        '
        Me.ember_None.AutoSize = True
        Me.ember_None.Checked = True
        Me.ember_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ember_None.Location = New System.Drawing.Point(10, 76)
        Me.ember_None.Name = "ember_None"
        Me.ember_None.Size = New System.Drawing.Size(69, 24)
        Me.ember_None.TabIndex = 57
        Me.ember_None.TabStop = True
        Me.ember_None.Text = "None"
        Me.ember_None.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 22)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Arcane Helmets"
        '
        'ember_Backdraft
        '
        Me.ember_Backdraft.AutoSize = True
        Me.ember_Backdraft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ember_Backdraft.Location = New System.Drawing.Point(10, 50)
        Me.ember_Backdraft.Name = "ember_Backdraft"
        Me.ember_Backdraft.Size = New System.Drawing.Size(167, 24)
        Me.ember_Backdraft.TabIndex = 1
        Me.ember_Backdraft.Text = "Backdraft Helmet"
        Me.ember_Backdraft.UseVisualStyleBackColor = True
        '
        'ember_Phoenix
        '
        Me.ember_Phoenix.AutoSize = True
        Me.ember_Phoenix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ember_Phoenix.Location = New System.Drawing.Point(10, 25)
        Me.ember_Phoenix.Name = "ember_Phoenix"
        Me.ember_Phoenix.Size = New System.Drawing.Size(152, 24)
        Me.ember_Phoenix.TabIndex = 0
        Me.ember_Phoenix.Text = "Phoenix Helmet"
        Me.ember_Phoenix.UseVisualStyleBackColor = True
        '
        'banshee_panel
        '
        Me.banshee_panel.Controls.Add(Me.banshee_None)
        Me.banshee_panel.Controls.Add(Me.Label19)
        Me.banshee_panel.Controls.Add(Me.banshee_Reverb)
        Me.banshee_panel.Location = New System.Drawing.Point(1, 320)
        Me.banshee_panel.Name = "banshee_panel"
        Me.banshee_panel.Size = New System.Drawing.Size(230, 100)
        Me.banshee_panel.TabIndex = 58
        Me.banshee_panel.Visible = False
        '
        'banshee_None
        '
        Me.banshee_None.AutoSize = True
        Me.banshee_None.Checked = True
        Me.banshee_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.banshee_None.Location = New System.Drawing.Point(10, 50)
        Me.banshee_None.Name = "banshee_None"
        Me.banshee_None.Size = New System.Drawing.Size(69, 24)
        Me.banshee_None.TabIndex = 57
        Me.banshee_None.TabStop = True
        Me.banshee_None.Text = "None"
        Me.banshee_None.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(151, 22)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Arcane Helmets"
        '
        'banshee_Reverb
        '
        Me.banshee_Reverb.AutoSize = True
        Me.banshee_Reverb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.banshee_Reverb.Location = New System.Drawing.Point(10, 25)
        Me.banshee_Reverb.Name = "banshee_Reverb"
        Me.banshee_Reverb.Size = New System.Drawing.Size(146, 24)
        Me.banshee_Reverb.TabIndex = 0
        Me.banshee_Reverb.Text = "Reverb Helmet"
        Me.banshee_Reverb.UseVisualStyleBackColor = True
        '
        'excalibur_panel
        '
        Me.excalibur_panel.Controls.Add(Me.excalibur_None)
        Me.excalibur_panel.Controls.Add(Me.Label23)
        Me.excalibur_panel.Controls.Add(Me.excalibur_Pendragon)
        Me.excalibur_panel.Controls.Add(Me.excalibur_Avalon)
        Me.excalibur_panel.Location = New System.Drawing.Point(1, 320)
        Me.excalibur_panel.Name = "excalibur_panel"
        Me.excalibur_panel.Size = New System.Drawing.Size(230, 100)
        Me.excalibur_panel.TabIndex = 59
        Me.excalibur_panel.Visible = False
        '
        'excalibur_None
        '
        Me.excalibur_None.AutoSize = True
        Me.excalibur_None.Checked = True
        Me.excalibur_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.excalibur_None.Location = New System.Drawing.Point(10, 76)
        Me.excalibur_None.Name = "excalibur_None"
        Me.excalibur_None.Size = New System.Drawing.Size(69, 24)
        Me.excalibur_None.TabIndex = 57
        Me.excalibur_None.TabStop = True
        Me.excalibur_None.Text = "None"
        Me.excalibur_None.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 2)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(151, 22)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Arcane Helmets"
        '
        'excalibur_Pendragon
        '
        Me.excalibur_Pendragon.AutoSize = True
        Me.excalibur_Pendragon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.excalibur_Pendragon.Location = New System.Drawing.Point(10, 50)
        Me.excalibur_Pendragon.Name = "excalibur_Pendragon"
        Me.excalibur_Pendragon.Size = New System.Drawing.Size(176, 24)
        Me.excalibur_Pendragon.TabIndex = 1
        Me.excalibur_Pendragon.Text = "Pendragon Helmet"
        Me.excalibur_Pendragon.UseVisualStyleBackColor = True
        '
        'excalibur_Avalon
        '
        Me.excalibur_Avalon.AutoSize = True
        Me.excalibur_Avalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.excalibur_Avalon.Location = New System.Drawing.Point(10, 25)
        Me.excalibur_Avalon.Name = "excalibur_Avalon"
        Me.excalibur_Avalon.Size = New System.Drawing.Size(143, 24)
        Me.excalibur_Avalon.TabIndex = 0
        Me.excalibur_Avalon.Text = "Avalon Helmet"
        Me.excalibur_Avalon.UseVisualStyleBackColor = True
        '
        'ash_panel
        '
        Me.ash_panel.Controls.Add(Me.ash_None)
        Me.ash_panel.Controls.Add(Me.Label22)
        Me.ash_panel.Controls.Add(Me.ash_Locust)
        Me.ash_panel.Location = New System.Drawing.Point(1, 320)
        Me.ash_panel.Name = "ash_panel"
        Me.ash_panel.Size = New System.Drawing.Size(230, 100)
        Me.ash_panel.TabIndex = 60
        Me.ash_panel.Visible = False
        '
        'ash_None
        '
        Me.ash_None.AutoSize = True
        Me.ash_None.Checked = True
        Me.ash_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ash_None.Location = New System.Drawing.Point(10, 50)
        Me.ash_None.Name = "ash_None"
        Me.ash_None.Size = New System.Drawing.Size(69, 24)
        Me.ash_None.TabIndex = 57
        Me.ash_None.TabStop = True
        Me.ash_None.Text = "None"
        Me.ash_None.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 2)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 22)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Arcane Helmets"
        '
        'ash_Locust
        '
        Me.ash_Locust.AutoSize = True
        Me.ash_Locust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ash_Locust.Location = New System.Drawing.Point(10, 25)
        Me.ash_Locust.Name = "ash_Locust"
        Me.ash_Locust.Size = New System.Drawing.Size(143, 24)
        Me.ash_Locust.TabIndex = 0
        Me.ash_Locust.Text = "Locust Helmet"
        Me.ash_Locust.UseVisualStyleBackColor = True
        '
        'Warframe_EHP_Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 623)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Warframe_EHP_Calc"
        Me.Text = "Warframe Effective Health Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.EHP_container.ResumeLayout(False)
        Me.EHP_container.PerformLayout()
        CType(Me.wf_hpconvert_stacks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_hpconvert_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_endurance_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_coaction_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_standunited_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_flow_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_physique_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_armoredagility_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_quickthinking_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_vigor_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_redirection_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_vitality_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_steelfiber_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wf_dmgreduc_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_armor_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_health_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_shield_val, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.link_sheild_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.link_health_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.link_armor_val, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.volt_panel.ResumeLayout(False)
        Me.volt_panel.PerformLayout()
        Me.vauban_panel.ResumeLayout(False)
        Me.vauban_panel.PerformLayout()
        Me.trinity_panel.ResumeLayout(False)
        Me.trinity_panel.PerformLayout()
        Me.saryn_panel.ResumeLayout(False)
        Me.saryn_panel.PerformLayout()
        Me.rhino_panel.ResumeLayout(False)
        Me.rhino_panel.PerformLayout()
        Me.nyx_panel.ResumeLayout(False)
        Me.nyx_panel.PerformLayout()
        Me.nova_panel.ResumeLayout(False)
        Me.nova_panel.PerformLayout()
        Me.mag_panel.ResumeLayout(False)
        Me.mag_panel.PerformLayout()
        Me.loki_panel.ResumeLayout(False)
        Me.loki_panel.PerformLayout()
        CType(Me.arcane_ultimatum_val, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcane_guardian_val, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frost_panel.ResumeLayout(False)
        Me.frost_panel.PerformLayout()
        Me.ember_panel.ResumeLayout(False)
        Me.ember_panel.PerformLayout()
        Me.banshee_panel.ResumeLayout(False)
        Me.banshee_panel.PerformLayout()
        Me.excalibur_panel.ResumeLayout(False)
        Me.excalibur_panel.PerformLayout()
        Me.ash_panel.ResumeLayout(False)
        Me.ash_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_pet As System.Windows.Forms.ComboBox
    Friend WithEvents wf_steelfiber_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents wf_vigor_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents wf_redirection_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents wf_vitality_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents wf_quickthinking_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents wf_quickthinking As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents wf_ehp As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pet_ehp As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents link_armor As System.Windows.Forms.CheckBox
    Friend WithEvents link_armor_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents pet_sheild As System.Windows.Forms.TextBox
    Friend WithEvents pet_health As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pet_armor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents link_sheild As System.Windows.Forms.CheckBox
    Friend WithEvents link_sheild_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents link_health As System.Windows.Forms.CheckBox
    Friend WithEvents link_health_val As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_frame As ComboBox
    Friend WithEvents wf_steelfiber As CheckBox
    Friend WithEvents wf_vitality As CheckBox
    Friend WithEvents wf_redirection As CheckBox
    Friend WithEvents wf_vigor As CheckBox
    Friend WithEvents wf_prime As CheckBox
    Friend WithEvents wf_armoredagility As CheckBox
    Friend WithEvents wf_armoredagility_val As NumericUpDown
    Friend WithEvents wf_physique_val As NumericUpDown
    Friend WithEvents wf_physique As CheckBox
    Friend WithEvents wf_flow_val As NumericUpDown
    Friend WithEvents wf_flow As CheckBox
    Friend WithEvents frame_sheild As TextBox
    Friend WithEvents frame_health As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents frame_armor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents frame_power As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents wf_standunited_val As NumericUpDown
    Friend WithEvents wf_standunited As CheckBox
    Friend WithEvents wf_endurance_val As NumericUpDown
    Friend WithEvents wf_endurance As CheckBox
    Friend WithEvents wf_coaction_val As NumericUpDown
    Friend WithEvents wf_coaction As CheckBox
    Friend WithEvents x_health_val As NumericUpDown
    Friend WithEvents x_health As CheckBox
    Friend WithEvents x_armor_val As NumericUpDown
    Friend WithEvents x_armor As CheckBox
    Friend WithEvents x_shield_val As NumericUpDown
    Friend WithEvents x_shield As CheckBox
    Friend WithEvents wf_dmgreduc As CheckBox
    Friend WithEvents wf_dmgreduc_val As NumericUpDown
    Friend WithEvents wf_hpconvert As CheckBox
    Friend WithEvents wf_hpconvert_val As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents wf_hpconvert_stacks As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cb_base_armor As ComboBox
    Friend WithEvents cb_base_health As ComboBox
    Friend WithEvents cb_base_shield As ComboBox
    Friend WithEvents cb_base_power As ComboBox
    Friend WithEvents cb_power As ComboBox
    Friend WithEvents cb_shield As ComboBox
    Friend WithEvents cb_health As ComboBox
    Friend WithEvents cb_armor As ComboBox
    Friend WithEvents cb_shield_pet As ComboBox
    Friend WithEvents cb_health_pet As ComboBox
    Friend WithEvents cb_armor_pet As ComboBox
    Friend WithEvents cb_primes As ComboBox
    Friend WithEvents prime_power As ComboBox
    Friend WithEvents prime_shield As ComboBox
    Friend WithEvents prime_health As ComboBox
    Friend WithEvents prime_armor As ComboBox
    Friend WithEvents prime_base_power As ComboBox
    Friend WithEvents prime_base_shield As ComboBox
    Friend WithEvents prime_base_health As ComboBox
    Friend WithEvents prime_base_armor As ComboBox
    Friend WithEvents wf_umbra As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EHP_container As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents arcane_guardian_val As NumericUpDown
    Friend WithEvents arcane_guardian As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents arcane_ultimatum_val As NumericUpDown
    Friend WithEvents arcane_ultimatum As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents key_decaying As CheckBox
    Friend WithEvents key_bleeding As CheckBox
    Friend WithEvents ember_panel As Panel
    Friend WithEvents ember_Phoenix As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents ember_Backdraft As RadioButton
    Friend WithEvents ember_None As RadioButton
    Friend WithEvents banshee_panel As Panel
    Friend WithEvents banshee_None As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents banshee_Reverb As RadioButton
    Friend WithEvents ash_panel As Panel
    Friend WithEvents ash_None As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents ash_Locust As RadioButton
    Friend WithEvents volt_panel As Panel
    Friend WithEvents volt_None As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents volt_Pulse As RadioButton
    Friend WithEvents excalibur_panel As Panel
    Friend WithEvents excalibur_None As RadioButton
    Friend WithEvents Label23 As Label
    Friend WithEvents excalibur_Pendragon As RadioButton
    Friend WithEvents excalibur_Avalon As RadioButton
    Friend WithEvents frost_panel As Panel
    Friend WithEvents frost_None As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents frost_Squall As RadioButton
    Friend WithEvents frost_Aurora As RadioButton
    Friend WithEvents loki_panel As Panel
    Friend WithEvents loki_None As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents loki_Swindle As RadioButton
    Friend WithEvents loki_Essence As RadioButton
    Friend WithEvents mag_panel As Panel
    Friend WithEvents mag_None As RadioButton
    Friend WithEvents Label26 As Label
    Friend WithEvents mag_Gauss As RadioButton
    Friend WithEvents mag_Coil As RadioButton
    Friend WithEvents nova_panel As Panel
    Friend WithEvents nova_None As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents nova_Flux As RadioButton
    Friend WithEvents nyx_panel As Panel
    Friend WithEvents nyx_None As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents nyx_Vespa As RadioButton
    Friend WithEvents nyx_Menticide As RadioButton
    Friend WithEvents rhino_panel As Panel
    Friend WithEvents rhino_None As RadioButton
    Friend WithEvents Label29 As Label
    Friend WithEvents rhino_Thrak As RadioButton
    Friend WithEvents saryn_panel As Panel
    Friend WithEvents saryn_None As RadioButton
    Friend WithEvents Label30 As Label
    Friend WithEvents saryn_Hemlock As RadioButton
    Friend WithEvents trinity_panel As Panel
    Friend WithEvents trinity_None As RadioButton
    Friend WithEvents Label31 As Label
    Friend WithEvents trinity_Meridian As RadioButton
    Friend WithEvents trinity_Aura As RadioButton
    Friend WithEvents vauban_panel As Panel
    Friend WithEvents vauban_None As RadioButton
    Friend WithEvents Label32 As Label
    Friend WithEvents vauban_Esprit As RadioButton
    Friend WithEvents prime_collar As CheckBox
End Class
