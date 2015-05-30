namespace EO4SaveEdit.Editors
{
    partial class CharacterEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCharacters = new System.Windows.Forms.ListBox();
            this.tcCharaParts = new System.Windows.Forms.TabControl();
            this.tpStats = new System.Windows.Forms.TabPage();
            this.tpSkills = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbSubclass = new System.Windows.Forms.ComboBox();
            this.lblSubclass = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.txtEquipEquipNumForgeSlots = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponNumForgeSlots = new System.Windows.Forms.TextBox();
            this.lblEquipWeapon = new System.Windows.Forms.Label();
            this.lblEquipEquip = new System.Windows.Forms.Label();
            this.lblEquipArmor1 = new System.Windows.Forms.Label();
            this.txtEquipArmor1NumForgeSlots = new System.Windows.Forms.TextBox();
            this.lblEquipArmor2 = new System.Windows.Forms.Label();
            this.txtEquipArmor2NumForgeSlots = new System.Windows.Forms.TextBox();
            this.lblEquipNumForgeSlotsHeader = new System.Windows.Forms.Label();
            this.txtEquipWeaponForge1 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge2 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge3 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge4 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge5 = new System.Windows.Forms.TextBox();
            this.cmbEquipWeaponItem = new System.Windows.Forms.ComboBox();
            this.lblEquipItemHeader = new System.Windows.Forms.Label();
            this.cmbEquipEquipItem = new System.Windows.Forms.ComboBox();
            this.cmbEquipArmor1Item = new System.Windows.Forms.ComboBox();
            this.cmbEquipArmor2Item = new System.Windows.Forms.ComboBox();
            this.txtEquipEquipForge5 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge4 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge3 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge2 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge1 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge5 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge4 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge3 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge2 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge1 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge5 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge4 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge3 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge2 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge1 = new System.Windows.Forms.TextBox();
            this.lblEffects = new System.Windows.Forms.Label();
            this.nudCharaID = new System.Windows.Forms.NumericUpDown();
            this.lblCharaID = new System.Windows.Forms.Label();
            this.txtEquipWeaponForge6 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge7 = new System.Windows.Forms.TextBox();
            this.txtEquipWeaponForge8 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge8 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge7 = new System.Windows.Forms.TextBox();
            this.txtEquipEquipForge6 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge8 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge7 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor1Forge6 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge8 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge7 = new System.Windows.Forms.TextBox();
            this.txtEquipArmor2Forge6 = new System.Windows.Forms.TextBox();
            this.tcCharaParts.SuspendLayout();
            this.tpStats.SuspendLayout();
            this.gbBasics.SuspendLayout();
            this.gbEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharaID)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCharacters
            // 
            this.lbCharacters.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCharacters.FormattingEnabled = true;
            this.lbCharacters.IntegralHeight = false;
            this.lbCharacters.Location = new System.Drawing.Point(0, 0);
            this.lbCharacters.Name = "lbCharacters";
            this.lbCharacters.Size = new System.Drawing.Size(130, 600);
            this.lbCharacters.TabIndex = 0;
            this.lbCharacters.SelectedIndexChanged += new System.EventHandler(this.lbCharacters_SelectedIndexChanged);
            // 
            // tcCharaParts
            // 
            this.tcCharaParts.Controls.Add(this.tpStats);
            this.tcCharaParts.Controls.Add(this.tpSkills);
            this.tcCharaParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCharaParts.Location = new System.Drawing.Point(130, 0);
            this.tcCharaParts.Name = "tcCharaParts";
            this.tcCharaParts.SelectedIndex = 0;
            this.tcCharaParts.Size = new System.Drawing.Size(770, 600);
            this.tcCharaParts.TabIndex = 1;
            // 
            // tpStats
            // 
            this.tpStats.Controls.Add(this.gbEquipment);
            this.tpStats.Controls.Add(this.gbBasics);
            this.tpStats.Location = new System.Drawing.Point(4, 22);
            this.tpStats.Name = "tpStats";
            this.tpStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats.Size = new System.Drawing.Size(762, 574);
            this.tpStats.TabIndex = 0;
            this.tpStats.Text = "Stats";
            this.tpStats.UseVisualStyleBackColor = true;
            // 
            // tpSkills
            // 
            this.tpSkills.Location = new System.Drawing.Point(4, 22);
            this.tpSkills.Name = "tpSkills";
            this.tpSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tpSkills.Size = new System.Drawing.Size(762, 574);
            this.tpSkills.TabIndex = 1;
            this.tpSkills.Text = "Skills";
            this.tpSkills.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(79, 45);
            this.txtName.MaxLength = 9;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(6, 74);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(79, 71);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(130, 21);
            this.cmbClass.TabIndex = 3;
            // 
            // cmbSubclass
            // 
            this.cmbSubclass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubclass.FormattingEnabled = true;
            this.cmbSubclass.Location = new System.Drawing.Point(79, 98);
            this.cmbSubclass.Name = "cmbSubclass";
            this.cmbSubclass.Size = new System.Drawing.Size(130, 21);
            this.cmbSubclass.TabIndex = 5;
            // 
            // lblSubclass
            // 
            this.lblSubclass.AutoSize = true;
            this.lblSubclass.Location = new System.Drawing.Point(6, 101);
            this.lblSubclass.Name = "lblSubclass";
            this.lblSubclass.Size = new System.Drawing.Size(53, 13);
            this.lblSubclass.TabIndex = 4;
            this.lblSubclass.Text = "Subclass:";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.lblCharaID);
            this.gbBasics.Controls.Add(this.nudCharaID);
            this.gbBasics.Controls.Add(this.txtName);
            this.gbBasics.Controls.Add(this.cmbSubclass);
            this.gbBasics.Controls.Add(this.lblName);
            this.gbBasics.Controls.Add(this.lblSubclass);
            this.gbBasics.Controls.Add(this.lblClass);
            this.gbBasics.Controls.Add(this.cmbClass);
            this.gbBasics.Location = new System.Drawing.Point(6, 6);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Size = new System.Drawing.Size(220, 170);
            this.gbBasics.TabIndex = 6;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Basic Information";
            // 
            // gbEquipment
            // 
            this.gbEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge8);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge7);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge6);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge8);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge7);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge6);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge8);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge7);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge6);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge8);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge7);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge6);
            this.gbEquipment.Controls.Add(this.lblEffects);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge5);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge4);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge3);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge2);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2Forge1);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge5);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge4);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge3);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge2);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1Forge1);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge5);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge4);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge3);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge2);
            this.gbEquipment.Controls.Add(this.txtEquipEquipForge1);
            this.gbEquipment.Controls.Add(this.cmbEquipArmor2Item);
            this.gbEquipment.Controls.Add(this.cmbEquipArmor1Item);
            this.gbEquipment.Controls.Add(this.cmbEquipEquipItem);
            this.gbEquipment.Controls.Add(this.lblEquipItemHeader);
            this.gbEquipment.Controls.Add(this.cmbEquipWeaponItem);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge5);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge4);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge3);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge2);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponForge1);
            this.gbEquipment.Controls.Add(this.lblEquipNumForgeSlotsHeader);
            this.gbEquipment.Controls.Add(this.lblEquipArmor2);
            this.gbEquipment.Controls.Add(this.txtEquipArmor2NumForgeSlots);
            this.gbEquipment.Controls.Add(this.lblEquipArmor1);
            this.gbEquipment.Controls.Add(this.txtEquipArmor1NumForgeSlots);
            this.gbEquipment.Controls.Add(this.lblEquipEquip);
            this.gbEquipment.Controls.Add(this.txtEquipWeaponNumForgeSlots);
            this.gbEquipment.Controls.Add(this.lblEquipWeapon);
            this.gbEquipment.Controls.Add(this.txtEquipEquipNumForgeSlots);
            this.gbEquipment.Location = new System.Drawing.Point(232, 6);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(524, 170);
            this.gbEquipment.TabIndex = 7;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment";
            // 
            // txtEquipEquipNumForgeSlots
            // 
            this.txtEquipEquipNumForgeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipNumForgeSlots.Location = new System.Drawing.Point(233, 75);
            this.txtEquipEquipNumForgeSlots.Name = "txtEquipEquipNumForgeSlots";
            this.txtEquipEquipNumForgeSlots.Size = new System.Drawing.Size(30, 20);
            this.txtEquipEquipNumForgeSlots.TabIndex = 1;
            // 
            // txtEquipWeaponNumForgeSlots
            // 
            this.txtEquipWeaponNumForgeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponNumForgeSlots.Location = new System.Drawing.Point(233, 48);
            this.txtEquipWeaponNumForgeSlots.MaxLength = 9;
            this.txtEquipWeaponNumForgeSlots.Name = "txtEquipWeaponNumForgeSlots";
            this.txtEquipWeaponNumForgeSlots.Size = new System.Drawing.Size(30, 20);
            this.txtEquipWeaponNumForgeSlots.TabIndex = 0;
            // 
            // lblEquipWeapon
            // 
            this.lblEquipWeapon.AutoSize = true;
            this.lblEquipWeapon.Location = new System.Drawing.Point(6, 51);
            this.lblEquipWeapon.Name = "lblEquipWeapon";
            this.lblEquipWeapon.Size = new System.Drawing.Size(51, 13);
            this.lblEquipWeapon.TabIndex = 2;
            this.lblEquipWeapon.Text = "Weapon:";
            // 
            // lblEquipEquip
            // 
            this.lblEquipEquip.AutoSize = true;
            this.lblEquipEquip.Location = new System.Drawing.Point(6, 78);
            this.lblEquipEquip.Name = "lblEquipEquip";
            this.lblEquipEquip.Size = new System.Drawing.Size(60, 13);
            this.lblEquipEquip.TabIndex = 3;
            this.lblEquipEquip.Text = "Equipment:";
            // 
            // lblEquipArmor1
            // 
            this.lblEquipArmor1.AutoSize = true;
            this.lblEquipArmor1.Location = new System.Drawing.Point(6, 105);
            this.lblEquipArmor1.Name = "lblEquipArmor1";
            this.lblEquipArmor1.Size = new System.Drawing.Size(52, 13);
            this.lblEquipArmor1.TabIndex = 5;
            this.lblEquipArmor1.Text = "Armor (1):";
            // 
            // txtEquipArmor1NumForgeSlots
            // 
            this.txtEquipArmor1NumForgeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1NumForgeSlots.Location = new System.Drawing.Point(233, 102);
            this.txtEquipArmor1NumForgeSlots.Name = "txtEquipArmor1NumForgeSlots";
            this.txtEquipArmor1NumForgeSlots.Size = new System.Drawing.Size(30, 20);
            this.txtEquipArmor1NumForgeSlots.TabIndex = 4;
            // 
            // lblEquipArmor2
            // 
            this.lblEquipArmor2.AutoSize = true;
            this.lblEquipArmor2.Location = new System.Drawing.Point(6, 132);
            this.lblEquipArmor2.Name = "lblEquipArmor2";
            this.lblEquipArmor2.Size = new System.Drawing.Size(52, 13);
            this.lblEquipArmor2.TabIndex = 7;
            this.lblEquipArmor2.Text = "Armor (2):";
            // 
            // txtEquipArmor2NumForgeSlots
            // 
            this.txtEquipArmor2NumForgeSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2NumForgeSlots.Location = new System.Drawing.Point(233, 129);
            this.txtEquipArmor2NumForgeSlots.Name = "txtEquipArmor2NumForgeSlots";
            this.txtEquipArmor2NumForgeSlots.Size = new System.Drawing.Size(30, 20);
            this.txtEquipArmor2NumForgeSlots.TabIndex = 6;
            // 
            // lblEquipNumForgeSlotsHeader
            // 
            this.lblEquipNumForgeSlotsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEquipNumForgeSlotsHeader.AutoSize = true;
            this.lblEquipNumForgeSlotsHeader.Location = new System.Drawing.Point(230, 16);
            this.lblEquipNumForgeSlotsHeader.Name = "lblEquipNumForgeSlotsHeader";
            this.lblEquipNumForgeSlotsHeader.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.lblEquipNumForgeSlotsHeader.Size = new System.Drawing.Size(37, 29);
            this.lblEquipNumForgeSlotsHeader.TabIndex = 8;
            this.lblEquipNumForgeSlotsHeader.Text = "Forge\r\nSlots:\r\n";
            // 
            // txtEquipWeaponForge1
            // 
            this.txtEquipWeaponForge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge1.Location = new System.Drawing.Point(276, 48);
            this.txtEquipWeaponForge1.Name = "txtEquipWeaponForge1";
            this.txtEquipWeaponForge1.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge1.TabIndex = 9;
            // 
            // txtEquipWeaponForge2
            // 
            this.txtEquipWeaponForge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge2.Location = new System.Drawing.Point(307, 48);
            this.txtEquipWeaponForge2.Name = "txtEquipWeaponForge2";
            this.txtEquipWeaponForge2.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge2.TabIndex = 10;
            // 
            // txtEquipWeaponForge3
            // 
            this.txtEquipWeaponForge3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge3.Location = new System.Drawing.Point(338, 48);
            this.txtEquipWeaponForge3.Name = "txtEquipWeaponForge3";
            this.txtEquipWeaponForge3.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge3.TabIndex = 11;
            // 
            // txtEquipWeaponForge4
            // 
            this.txtEquipWeaponForge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge4.Location = new System.Drawing.Point(369, 48);
            this.txtEquipWeaponForge4.Name = "txtEquipWeaponForge4";
            this.txtEquipWeaponForge4.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge4.TabIndex = 12;
            // 
            // txtEquipWeaponForge5
            // 
            this.txtEquipWeaponForge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge5.Location = new System.Drawing.Point(400, 48);
            this.txtEquipWeaponForge5.Name = "txtEquipWeaponForge5";
            this.txtEquipWeaponForge5.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge5.TabIndex = 13;
            // 
            // cmbEquipWeaponItem
            // 
            this.cmbEquipWeaponItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEquipWeaponItem.FormattingEnabled = true;
            this.cmbEquipWeaponItem.Location = new System.Drawing.Point(72, 48);
            this.cmbEquipWeaponItem.Name = "cmbEquipWeaponItem";
            this.cmbEquipWeaponItem.Size = new System.Drawing.Size(155, 21);
            this.cmbEquipWeaponItem.TabIndex = 14;
            // 
            // lblEquipItemHeader
            // 
            this.lblEquipItemHeader.AutoSize = true;
            this.lblEquipItemHeader.Location = new System.Drawing.Point(69, 29);
            this.lblEquipItemHeader.Name = "lblEquipItemHeader";
            this.lblEquipItemHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblEquipItemHeader.Size = new System.Drawing.Size(30, 16);
            this.lblEquipItemHeader.TabIndex = 15;
            this.lblEquipItemHeader.Text = "Item:";
            // 
            // cmbEquipEquipItem
            // 
            this.cmbEquipEquipItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEquipEquipItem.FormattingEnabled = true;
            this.cmbEquipEquipItem.Location = new System.Drawing.Point(72, 75);
            this.cmbEquipEquipItem.Name = "cmbEquipEquipItem";
            this.cmbEquipEquipItem.Size = new System.Drawing.Size(155, 21);
            this.cmbEquipEquipItem.TabIndex = 16;
            // 
            // cmbEquipArmor1Item
            // 
            this.cmbEquipArmor1Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEquipArmor1Item.FormattingEnabled = true;
            this.cmbEquipArmor1Item.Location = new System.Drawing.Point(72, 102);
            this.cmbEquipArmor1Item.Name = "cmbEquipArmor1Item";
            this.cmbEquipArmor1Item.Size = new System.Drawing.Size(155, 21);
            this.cmbEquipArmor1Item.TabIndex = 17;
            // 
            // cmbEquipArmor2Item
            // 
            this.cmbEquipArmor2Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEquipArmor2Item.FormattingEnabled = true;
            this.cmbEquipArmor2Item.Location = new System.Drawing.Point(72, 129);
            this.cmbEquipArmor2Item.Name = "cmbEquipArmor2Item";
            this.cmbEquipArmor2Item.Size = new System.Drawing.Size(155, 21);
            this.cmbEquipArmor2Item.TabIndex = 18;
            // 
            // txtEquipEquipForge5
            // 
            this.txtEquipEquipForge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge5.Location = new System.Drawing.Point(400, 75);
            this.txtEquipEquipForge5.Name = "txtEquipEquipForge5";
            this.txtEquipEquipForge5.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge5.TabIndex = 23;
            // 
            // txtEquipEquipForge4
            // 
            this.txtEquipEquipForge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge4.Location = new System.Drawing.Point(369, 75);
            this.txtEquipEquipForge4.Name = "txtEquipEquipForge4";
            this.txtEquipEquipForge4.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge4.TabIndex = 22;
            // 
            // txtEquipEquipForge3
            // 
            this.txtEquipEquipForge3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge3.Location = new System.Drawing.Point(338, 75);
            this.txtEquipEquipForge3.Name = "txtEquipEquipForge3";
            this.txtEquipEquipForge3.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge3.TabIndex = 21;
            // 
            // txtEquipEquipForge2
            // 
            this.txtEquipEquipForge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge2.Location = new System.Drawing.Point(307, 75);
            this.txtEquipEquipForge2.Name = "txtEquipEquipForge2";
            this.txtEquipEquipForge2.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge2.TabIndex = 20;
            // 
            // txtEquipEquipForge1
            // 
            this.txtEquipEquipForge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge1.Location = new System.Drawing.Point(276, 75);
            this.txtEquipEquipForge1.Name = "txtEquipEquipForge1";
            this.txtEquipEquipForge1.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge1.TabIndex = 19;
            // 
            // txtEquipArmor1Forge5
            // 
            this.txtEquipArmor1Forge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge5.Location = new System.Drawing.Point(400, 102);
            this.txtEquipArmor1Forge5.Name = "txtEquipArmor1Forge5";
            this.txtEquipArmor1Forge5.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge5.TabIndex = 28;
            // 
            // txtEquipArmor1Forge4
            // 
            this.txtEquipArmor1Forge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge4.Location = new System.Drawing.Point(369, 102);
            this.txtEquipArmor1Forge4.Name = "txtEquipArmor1Forge4";
            this.txtEquipArmor1Forge4.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge4.TabIndex = 27;
            // 
            // txtEquipArmor1Forge3
            // 
            this.txtEquipArmor1Forge3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge3.Location = new System.Drawing.Point(338, 102);
            this.txtEquipArmor1Forge3.Name = "txtEquipArmor1Forge3";
            this.txtEquipArmor1Forge3.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge3.TabIndex = 26;
            // 
            // txtEquipArmor1Forge2
            // 
            this.txtEquipArmor1Forge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge2.Location = new System.Drawing.Point(307, 102);
            this.txtEquipArmor1Forge2.Name = "txtEquipArmor1Forge2";
            this.txtEquipArmor1Forge2.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge2.TabIndex = 25;
            // 
            // txtEquipArmor1Forge1
            // 
            this.txtEquipArmor1Forge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge1.Location = new System.Drawing.Point(276, 102);
            this.txtEquipArmor1Forge1.Name = "txtEquipArmor1Forge1";
            this.txtEquipArmor1Forge1.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge1.TabIndex = 24;
            // 
            // txtEquipArmor2Forge5
            // 
            this.txtEquipArmor2Forge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge5.Location = new System.Drawing.Point(400, 129);
            this.txtEquipArmor2Forge5.Name = "txtEquipArmor2Forge5";
            this.txtEquipArmor2Forge5.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge5.TabIndex = 33;
            // 
            // txtEquipArmor2Forge4
            // 
            this.txtEquipArmor2Forge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge4.Location = new System.Drawing.Point(369, 129);
            this.txtEquipArmor2Forge4.Name = "txtEquipArmor2Forge4";
            this.txtEquipArmor2Forge4.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge4.TabIndex = 32;
            // 
            // txtEquipArmor2Forge3
            // 
            this.txtEquipArmor2Forge3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge3.Location = new System.Drawing.Point(338, 129);
            this.txtEquipArmor2Forge3.Name = "txtEquipArmor2Forge3";
            this.txtEquipArmor2Forge3.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge3.TabIndex = 31;
            // 
            // txtEquipArmor2Forge2
            // 
            this.txtEquipArmor2Forge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge2.Location = new System.Drawing.Point(307, 129);
            this.txtEquipArmor2Forge2.Name = "txtEquipArmor2Forge2";
            this.txtEquipArmor2Forge2.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge2.TabIndex = 30;
            // 
            // txtEquipArmor2Forge1
            // 
            this.txtEquipArmor2Forge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge1.Location = new System.Drawing.Point(276, 129);
            this.txtEquipArmor2Forge1.Name = "txtEquipArmor2Forge1";
            this.txtEquipArmor2Forge1.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge1.TabIndex = 29;
            // 
            // lblEffects
            // 
            this.lblEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEffects.AutoSize = true;
            this.lblEffects.Location = new System.Drawing.Point(273, 29);
            this.lblEffects.Name = "lblEffects";
            this.lblEffects.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblEffects.Size = new System.Drawing.Size(43, 16);
            this.lblEffects.TabIndex = 34;
            this.lblEffects.Text = "Effects:";
            // 
            // nudCharaID
            // 
            this.nudCharaID.Location = new System.Drawing.Point(79, 19);
            this.nudCharaID.Name = "nudCharaID";
            this.nudCharaID.Size = new System.Drawing.Size(50, 20);
            this.nudCharaID.TabIndex = 6;
            // 
            // lblCharaID
            // 
            this.lblCharaID.AutoSize = true;
            this.lblCharaID.Location = new System.Drawing.Point(6, 21);
            this.lblCharaID.Name = "lblCharaID";
            this.lblCharaID.Size = new System.Drawing.Size(21, 13);
            this.lblCharaID.TabIndex = 7;
            this.lblCharaID.Text = "ID:";
            // 
            // txtEquipWeaponForge6
            // 
            this.txtEquipWeaponForge6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge6.Location = new System.Drawing.Point(431, 48);
            this.txtEquipWeaponForge6.Name = "txtEquipWeaponForge6";
            this.txtEquipWeaponForge6.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge6.TabIndex = 35;
            // 
            // txtEquipWeaponForge7
            // 
            this.txtEquipWeaponForge7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge7.Location = new System.Drawing.Point(462, 48);
            this.txtEquipWeaponForge7.Name = "txtEquipWeaponForge7";
            this.txtEquipWeaponForge7.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge7.TabIndex = 36;
            // 
            // txtEquipWeaponForge8
            // 
            this.txtEquipWeaponForge8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipWeaponForge8.Location = new System.Drawing.Point(493, 48);
            this.txtEquipWeaponForge8.Name = "txtEquipWeaponForge8";
            this.txtEquipWeaponForge8.Size = new System.Drawing.Size(25, 20);
            this.txtEquipWeaponForge8.TabIndex = 37;
            // 
            // txtEquipEquipForge8
            // 
            this.txtEquipEquipForge8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge8.Location = new System.Drawing.Point(493, 75);
            this.txtEquipEquipForge8.Name = "txtEquipEquipForge8";
            this.txtEquipEquipForge8.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge8.TabIndex = 40;
            // 
            // txtEquipEquipForge7
            // 
            this.txtEquipEquipForge7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge7.Location = new System.Drawing.Point(462, 75);
            this.txtEquipEquipForge7.Name = "txtEquipEquipForge7";
            this.txtEquipEquipForge7.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge7.TabIndex = 39;
            // 
            // txtEquipEquipForge6
            // 
            this.txtEquipEquipForge6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipEquipForge6.Location = new System.Drawing.Point(431, 75);
            this.txtEquipEquipForge6.Name = "txtEquipEquipForge6";
            this.txtEquipEquipForge6.Size = new System.Drawing.Size(25, 20);
            this.txtEquipEquipForge6.TabIndex = 38;
            // 
            // txtEquipArmor1Forge8
            // 
            this.txtEquipArmor1Forge8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge8.Location = new System.Drawing.Point(493, 102);
            this.txtEquipArmor1Forge8.Name = "txtEquipArmor1Forge8";
            this.txtEquipArmor1Forge8.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge8.TabIndex = 43;
            // 
            // txtEquipArmor1Forge7
            // 
            this.txtEquipArmor1Forge7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge7.Location = new System.Drawing.Point(462, 102);
            this.txtEquipArmor1Forge7.Name = "txtEquipArmor1Forge7";
            this.txtEquipArmor1Forge7.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge7.TabIndex = 42;
            // 
            // txtEquipArmor1Forge6
            // 
            this.txtEquipArmor1Forge6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor1Forge6.Location = new System.Drawing.Point(431, 102);
            this.txtEquipArmor1Forge6.Name = "txtEquipArmor1Forge6";
            this.txtEquipArmor1Forge6.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor1Forge6.TabIndex = 41;
            // 
            // txtEquipArmor2Forge8
            // 
            this.txtEquipArmor2Forge8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge8.Location = new System.Drawing.Point(493, 129);
            this.txtEquipArmor2Forge8.Name = "txtEquipArmor2Forge8";
            this.txtEquipArmor2Forge8.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge8.TabIndex = 46;
            // 
            // txtEquipArmor2Forge7
            // 
            this.txtEquipArmor2Forge7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge7.Location = new System.Drawing.Point(462, 129);
            this.txtEquipArmor2Forge7.Name = "txtEquipArmor2Forge7";
            this.txtEquipArmor2Forge7.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge7.TabIndex = 45;
            // 
            // txtEquipArmor2Forge6
            // 
            this.txtEquipArmor2Forge6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipArmor2Forge6.Location = new System.Drawing.Point(431, 129);
            this.txtEquipArmor2Forge6.Name = "txtEquipArmor2Forge6";
            this.txtEquipArmor2Forge6.Size = new System.Drawing.Size(25, 20);
            this.txtEquipArmor2Forge6.TabIndex = 44;
            // 
            // CharacterEditor
            // 
            this.Controls.Add(this.tcCharaParts);
            this.Controls.Add(this.lbCharacters);
            this.Name = "CharacterEditor";
            this.Size = new System.Drawing.Size(900, 600);
            this.tcCharaParts.ResumeLayout(false);
            this.tpStats.ResumeLayout(false);
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.gbEquipment.ResumeLayout(false);
            this.gbEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharaID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCharacters;
        private System.Windows.Forms.TabControl tcCharaParts;
        private System.Windows.Forms.TabPage tpSkills;
        private System.Windows.Forms.TabPage tpStats;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbSubclass;
        private System.Windows.Forms.Label lblSubclass;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.GroupBox gbEquipment;
        private System.Windows.Forms.TextBox txtEquipEquipNumForgeSlots;
        private System.Windows.Forms.TextBox txtEquipWeaponNumForgeSlots;
        private System.Windows.Forms.Label lblEquipWeapon;
        private System.Windows.Forms.Label lblEquipEquip;
        private System.Windows.Forms.Label lblEquipArmor2;
        private System.Windows.Forms.TextBox txtEquipArmor2NumForgeSlots;
        private System.Windows.Forms.Label lblEquipArmor1;
        private System.Windows.Forms.TextBox txtEquipArmor1NumForgeSlots;
        private System.Windows.Forms.Label lblEquipNumForgeSlotsHeader;
        private System.Windows.Forms.TextBox txtEquipWeaponForge1;
        private System.Windows.Forms.TextBox txtEquipWeaponForge4;
        private System.Windows.Forms.TextBox txtEquipWeaponForge3;
        private System.Windows.Forms.TextBox txtEquipWeaponForge2;
        private System.Windows.Forms.TextBox txtEquipWeaponForge5;
        private System.Windows.Forms.ComboBox cmbEquipWeaponItem;
        private System.Windows.Forms.Label lblEquipItemHeader;
        private System.Windows.Forms.ComboBox cmbEquipArmor2Item;
        private System.Windows.Forms.ComboBox cmbEquipArmor1Item;
        private System.Windows.Forms.ComboBox cmbEquipEquipItem;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge5;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge4;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge3;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge2;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge1;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge5;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge4;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge3;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge2;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge1;
        private System.Windows.Forms.TextBox txtEquipEquipForge5;
        private System.Windows.Forms.TextBox txtEquipEquipForge4;
        private System.Windows.Forms.TextBox txtEquipEquipForge3;
        private System.Windows.Forms.TextBox txtEquipEquipForge2;
        private System.Windows.Forms.TextBox txtEquipEquipForge1;
        private System.Windows.Forms.Label lblEffects;
        private System.Windows.Forms.NumericUpDown nudCharaID;
        private System.Windows.Forms.Label lblCharaID;
        private System.Windows.Forms.TextBox txtEquipWeaponForge7;
        private System.Windows.Forms.TextBox txtEquipWeaponForge6;
        private System.Windows.Forms.TextBox txtEquipWeaponForge8;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge8;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge7;
        private System.Windows.Forms.TextBox txtEquipArmor2Forge6;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge8;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge7;
        private System.Windows.Forms.TextBox txtEquipArmor1Forge6;
        private System.Windows.Forms.TextBox txtEquipEquipForge8;
        private System.Windows.Forms.TextBox txtEquipEquipForge7;
        private System.Windows.Forms.TextBox txtEquipEquipForge6;
    }
}
