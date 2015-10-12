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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblCharacterOriginGuildName = new System.Windows.Forms.Label();
            this.txtCharacterOriginGuildName = new System.Windows.Forms.TextBox();
            this.chkCharacterIsGuildCardChara = new System.Windows.Forms.CheckBox();
            this.txtCharacterAvailSkillPoints = new System.Windows.Forms.TextBox();
            this.lblCharacterAvailSkillPoints = new System.Windows.Forms.Label();
            this.lblCharacterEXP = new System.Windows.Forms.Label();
            this.txtCharacterEXP = new System.Windows.Forms.TextBox();
            this.lblCharacterPortrait = new System.Windows.Forms.Label();
            this.lblCharacterCurrentTP = new System.Windows.Forms.Label();
            this.txtCharacterCurrentTP = new System.Windows.Forms.TextBox();
            this.lblCharacterCurrentHP = new System.Windows.Forms.Label();
            this.txtCharacterCurrentHP = new System.Windows.Forms.TextBox();
            this.btnCharacterStatsEditor = new System.Windows.Forms.Button();
            this.btnCharacterEditArmor2Effect = new System.Windows.Forms.Button();
            this.btnCharacterEditArmor1Effect = new System.Windows.Forms.Button();
            this.btnCharacterEditEquipEffect = new System.Windows.Forms.Button();
            this.cmbCharacterArmor2 = new System.Windows.Forms.ComboBox();
            this.cmbCharacterArmor1 = new System.Windows.Forms.ComboBox();
            this.cmbCharacterEquipment = new System.Windows.Forms.ComboBox();
            this.cmbCharacterWeapon = new System.Windows.Forms.ComboBox();
            this.btnCharacterEditWeaponEffect = new System.Windows.Forms.Button();
            this.btnCharacterSkillEditor = new System.Windows.Forms.Button();
            this.lblCharacterArmor2 = new System.Windows.Forms.Label();
            this.lblCharacterArmor1 = new System.Windows.Forms.Label();
            this.lblCharacterEquipment = new System.Windows.Forms.Label();
            this.lblCharacterWeapon = new System.Windows.Forms.Label();
            this.lblCharacterSubclass = new System.Windows.Forms.Label();
            this.lblCharacterClass = new System.Windows.Forms.Label();
            this.lblCharacterLevel = new System.Windows.Forms.Label();
            this.cmbCharacterSubclass = new System.Windows.Forms.ComboBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.cmbCharacterClass = new System.Windows.Forms.ComboBox();
            this.nudCharacterLevel = new System.Windows.Forms.NumericUpDown();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.gbEquipment = new System.Windows.Forms.GroupBox();
            this.icmbCharacterPortrait = new EO4SaveEdit.Controls.ImageComboBox();
            this.lbCharacters = new EO4SaveEdit.Controls.ListBoxEx();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterLevel)).BeginInit();
            this.gbEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbBasicInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCharacters, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbEquipment, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.lblCharacterOriginGuildName);
            this.gbBasicInfo.Controls.Add(this.txtCharacterOriginGuildName);
            this.gbBasicInfo.Controls.Add(this.chkCharacterIsGuildCardChara);
            this.gbBasicInfo.Controls.Add(this.txtCharacterAvailSkillPoints);
            this.gbBasicInfo.Controls.Add(this.lblCharacterEXP);
            this.gbBasicInfo.Controls.Add(this.lblCharacterAvailSkillPoints);
            this.gbBasicInfo.Controls.Add(this.txtCharacterEXP);
            this.gbBasicInfo.Controls.Add(this.lblCharacterPortrait);
            this.gbBasicInfo.Controls.Add(this.btnCharacterSkillEditor);
            this.gbBasicInfo.Controls.Add(this.icmbCharacterPortrait);
            this.gbBasicInfo.Controls.Add(this.lblCharacterCurrentTP);
            this.gbBasicInfo.Controls.Add(this.txtCharacterCurrentTP);
            this.gbBasicInfo.Controls.Add(this.lblCharacterCurrentHP);
            this.gbBasicInfo.Controls.Add(this.txtCharacterCurrentHP);
            this.gbBasicInfo.Controls.Add(this.lblCharacterSubclass);
            this.gbBasicInfo.Controls.Add(this.lblCharacterClass);
            this.gbBasicInfo.Controls.Add(this.lblCharacterLevel);
            this.gbBasicInfo.Controls.Add(this.btnCharacterStatsEditor);
            this.gbBasicInfo.Controls.Add(this.cmbCharacterSubclass);
            this.gbBasicInfo.Controls.Add(this.lblCharacterName);
            this.gbBasicInfo.Controls.Add(this.cmbCharacterClass);
            this.gbBasicInfo.Controls.Add(this.nudCharacterLevel);
            this.gbBasicInfo.Controls.Add(this.txtCharacterName);
            this.gbBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasicInfo.Location = new System.Drawing.Point(123, 3);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(384, 244);
            this.gbBasicInfo.TabIndex = 1;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "Basic Information";
            // 
            // lblCharacterOriginGuildName
            // 
            this.lblCharacterOriginGuildName.AutoSize = true;
            this.lblCharacterOriginGuildName.Location = new System.Drawing.Point(180, 154);
            this.lblCharacterOriginGuildName.Name = "lblCharacterOriginGuildName";
            this.lblCharacterOriginGuildName.Size = new System.Drawing.Size(64, 13);
            this.lblCharacterOriginGuildName.TabIndex = 33;
            this.lblCharacterOriginGuildName.Text = "Origin Guild:";
            // 
            // txtCharacterOriginGuildName
            // 
            this.txtCharacterOriginGuildName.Location = new System.Drawing.Point(250, 151);
            this.txtCharacterOriginGuildName.MaxLength = 9;
            this.txtCharacterOriginGuildName.Name = "txtCharacterOriginGuildName";
            this.txtCharacterOriginGuildName.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterOriginGuildName.TabIndex = 34;
            // 
            // chkCharacterIsGuildCardChara
            // 
            this.chkCharacterIsGuildCardChara.AutoSize = true;
            this.chkCharacterIsGuildCardChara.Location = new System.Drawing.Point(9, 153);
            this.chkCharacterIsGuildCardChara.Name = "chkCharacterIsGuildCardChara";
            this.chkCharacterIsGuildCardChara.Size = new System.Drawing.Size(141, 17);
            this.chkCharacterIsGuildCardChara.TabIndex = 32;
            this.chkCharacterIsGuildCardChara.Text = "Is Guild Card Character?";
            this.chkCharacterIsGuildCardChara.UseVisualStyleBackColor = true;
            // 
            // txtCharacterAvailSkillPoints
            // 
            this.txtCharacterAvailSkillPoints.Location = new System.Drawing.Point(74, 176);
            this.txtCharacterAvailSkillPoints.Name = "txtCharacterAvailSkillPoints";
            this.txtCharacterAvailSkillPoints.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterAvailSkillPoints.TabIndex = 31;
            // 
            // lblCharacterAvailSkillPoints
            // 
            this.lblCharacterAvailSkillPoints.AutoSize = true;
            this.lblCharacterAvailSkillPoints.Location = new System.Drawing.Point(6, 179);
            this.lblCharacterAvailSkillPoints.Name = "lblCharacterAvailSkillPoints";
            this.lblCharacterAvailSkillPoints.Size = new System.Drawing.Size(61, 13);
            this.lblCharacterAvailSkillPoints.TabIndex = 30;
            this.lblCharacterAvailSkillPoints.Text = "Skill Points:";
            // 
            // lblCharacterEXP
            // 
            this.lblCharacterEXP.AutoSize = true;
            this.lblCharacterEXP.Location = new System.Drawing.Point(6, 74);
            this.lblCharacterEXP.Name = "lblCharacterEXP";
            this.lblCharacterEXP.Size = new System.Drawing.Size(31, 13);
            this.lblCharacterEXP.TabIndex = 28;
            this.lblCharacterEXP.Text = "EXP:";
            // 
            // txtCharacterEXP
            // 
            this.txtCharacterEXP.Location = new System.Drawing.Point(74, 71);
            this.txtCharacterEXP.Name = "txtCharacterEXP";
            this.txtCharacterEXP.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterEXP.TabIndex = 29;
            // 
            // lblCharacterPortrait
            // 
            this.lblCharacterPortrait.AutoSize = true;
            this.lblCharacterPortrait.Location = new System.Drawing.Point(6, 127);
            this.lblCharacterPortrait.Name = "lblCharacterPortrait";
            this.lblCharacterPortrait.Size = new System.Drawing.Size(43, 13);
            this.lblCharacterPortrait.TabIndex = 12;
            this.lblCharacterPortrait.Text = "Portrait:";
            // 
            // lblCharacterCurrentTP
            // 
            this.lblCharacterCurrentTP.AutoSize = true;
            this.lblCharacterCurrentTP.Location = new System.Drawing.Point(180, 48);
            this.lblCharacterCurrentTP.Name = "lblCharacterCurrentTP";
            this.lblCharacterCurrentTP.Size = new System.Drawing.Size(61, 13);
            this.lblCharacterCurrentTP.TabIndex = 6;
            this.lblCharacterCurrentTP.Text = "Current TP:";
            // 
            // txtCharacterCurrentTP
            // 
            this.txtCharacterCurrentTP.Location = new System.Drawing.Point(250, 45);
            this.txtCharacterCurrentTP.Name = "txtCharacterCurrentTP";
            this.txtCharacterCurrentTP.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterCurrentTP.TabIndex = 7;
            // 
            // lblCharacterCurrentHP
            // 
            this.lblCharacterCurrentHP.AutoSize = true;
            this.lblCharacterCurrentHP.Location = new System.Drawing.Point(6, 48);
            this.lblCharacterCurrentHP.Name = "lblCharacterCurrentHP";
            this.lblCharacterCurrentHP.Size = new System.Drawing.Size(62, 13);
            this.lblCharacterCurrentHP.TabIndex = 4;
            this.lblCharacterCurrentHP.Text = "Current HP:";
            // 
            // txtCharacterCurrentHP
            // 
            this.txtCharacterCurrentHP.Location = new System.Drawing.Point(74, 45);
            this.txtCharacterCurrentHP.Name = "txtCharacterCurrentHP";
            this.txtCharacterCurrentHP.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterCurrentHP.TabIndex = 5;
            // 
            // btnCharacterStatsEditor
            // 
            this.btnCharacterStatsEditor.Location = new System.Drawing.Point(6, 203);
            this.btnCharacterStatsEditor.Name = "btnCharacterStatsEditor";
            this.btnCharacterStatsEditor.Size = new System.Drawing.Size(344, 23);
            this.btnCharacterStatsEditor.TabIndex = 27;
            this.btnCharacterStatsEditor.Text = "Edit Stats";
            this.btnCharacterStatsEditor.UseVisualStyleBackColor = true;
            this.btnCharacterStatsEditor.Click += new System.EventHandler(this.btnCharacterStatsEditor_Click);
            // 
            // btnCharacterEditArmor2Effect
            // 
            this.btnCharacterEditArmor2Effect.Location = new System.Drawing.Point(230, 105);
            this.btnCharacterEditArmor2Effect.Name = "btnCharacterEditArmor2Effect";
            this.btnCharacterEditArmor2Effect.Size = new System.Drawing.Size(120, 23);
            this.btnCharacterEditArmor2Effect.TabIndex = 25;
            this.btnCharacterEditArmor2Effect.Text = "Edit Effects";
            this.btnCharacterEditArmor2Effect.UseVisualStyleBackColor = true;
            this.btnCharacterEditArmor2Effect.Click += new System.EventHandler(this.btnCharacterEditArmor2Effect_Click);
            // 
            // btnCharacterEditArmor1Effect
            // 
            this.btnCharacterEditArmor1Effect.Location = new System.Drawing.Point(230, 76);
            this.btnCharacterEditArmor1Effect.Name = "btnCharacterEditArmor1Effect";
            this.btnCharacterEditArmor1Effect.Size = new System.Drawing.Size(120, 23);
            this.btnCharacterEditArmor1Effect.TabIndex = 22;
            this.btnCharacterEditArmor1Effect.Text = "Edit Effects";
            this.btnCharacterEditArmor1Effect.UseVisualStyleBackColor = true;
            this.btnCharacterEditArmor1Effect.Click += new System.EventHandler(this.btnCharacterEditArmor1Effect_Click);
            // 
            // btnCharacterEditEquipEffect
            // 
            this.btnCharacterEditEquipEffect.Location = new System.Drawing.Point(230, 47);
            this.btnCharacterEditEquipEffect.Name = "btnCharacterEditEquipEffect";
            this.btnCharacterEditEquipEffect.Size = new System.Drawing.Size(120, 23);
            this.btnCharacterEditEquipEffect.TabIndex = 19;
            this.btnCharacterEditEquipEffect.Text = "Edit Effects";
            this.btnCharacterEditEquipEffect.UseVisualStyleBackColor = true;
            this.btnCharacterEditEquipEffect.Click += new System.EventHandler(this.btnCharacterEditEquipEffect_Click);
            // 
            // cmbCharacterArmor2
            // 
            this.cmbCharacterArmor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterArmor2.FormattingEnabled = true;
            this.cmbCharacterArmor2.Location = new System.Drawing.Point(74, 106);
            this.cmbCharacterArmor2.Name = "cmbCharacterArmor2";
            this.cmbCharacterArmor2.Size = new System.Drawing.Size(150, 21);
            this.cmbCharacterArmor2.TabIndex = 24;
            // 
            // cmbCharacterArmor1
            // 
            this.cmbCharacterArmor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterArmor1.FormattingEnabled = true;
            this.cmbCharacterArmor1.Location = new System.Drawing.Point(74, 77);
            this.cmbCharacterArmor1.Name = "cmbCharacterArmor1";
            this.cmbCharacterArmor1.Size = new System.Drawing.Size(150, 21);
            this.cmbCharacterArmor1.TabIndex = 21;
            // 
            // cmbCharacterEquipment
            // 
            this.cmbCharacterEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterEquipment.FormattingEnabled = true;
            this.cmbCharacterEquipment.Location = new System.Drawing.Point(74, 48);
            this.cmbCharacterEquipment.Name = "cmbCharacterEquipment";
            this.cmbCharacterEquipment.Size = new System.Drawing.Size(150, 21);
            this.cmbCharacterEquipment.TabIndex = 18;
            // 
            // cmbCharacterWeapon
            // 
            this.cmbCharacterWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterWeapon.FormattingEnabled = true;
            this.cmbCharacterWeapon.Location = new System.Drawing.Point(74, 19);
            this.cmbCharacterWeapon.Name = "cmbCharacterWeapon";
            this.cmbCharacterWeapon.Size = new System.Drawing.Size(150, 21);
            this.cmbCharacterWeapon.TabIndex = 15;
            // 
            // btnCharacterEditWeaponEffect
            // 
            this.btnCharacterEditWeaponEffect.Location = new System.Drawing.Point(230, 18);
            this.btnCharacterEditWeaponEffect.Name = "btnCharacterEditWeaponEffect";
            this.btnCharacterEditWeaponEffect.Size = new System.Drawing.Size(120, 23);
            this.btnCharacterEditWeaponEffect.TabIndex = 16;
            this.btnCharacterEditWeaponEffect.Text = "Edit Effects";
            this.btnCharacterEditWeaponEffect.UseVisualStyleBackColor = true;
            this.btnCharacterEditWeaponEffect.Click += new System.EventHandler(this.btnCharacterEditWeaponEffect_Click);
            // 
            // btnCharacterSkillEditor
            // 
            this.btnCharacterSkillEditor.Location = new System.Drawing.Point(230, 174);
            this.btnCharacterSkillEditor.Name = "btnCharacterSkillEditor";
            this.btnCharacterSkillEditor.Size = new System.Drawing.Size(120, 23);
            this.btnCharacterSkillEditor.TabIndex = 26;
            this.btnCharacterSkillEditor.Text = "Edit Skills";
            this.btnCharacterSkillEditor.UseVisualStyleBackColor = true;
            this.btnCharacterSkillEditor.Click += new System.EventHandler(this.btnCharacterSkillEditor_Click);
            // 
            // lblCharacterArmor2
            // 
            this.lblCharacterArmor2.AutoSize = true;
            this.lblCharacterArmor2.Location = new System.Drawing.Point(6, 109);
            this.lblCharacterArmor2.Name = "lblCharacterArmor2";
            this.lblCharacterArmor2.Size = new System.Drawing.Size(46, 13);
            this.lblCharacterArmor2.TabIndex = 23;
            this.lblCharacterArmor2.Text = "Armor 2:";
            // 
            // lblCharacterArmor1
            // 
            this.lblCharacterArmor1.AutoSize = true;
            this.lblCharacterArmor1.Location = new System.Drawing.Point(6, 80);
            this.lblCharacterArmor1.Name = "lblCharacterArmor1";
            this.lblCharacterArmor1.Size = new System.Drawing.Size(46, 13);
            this.lblCharacterArmor1.TabIndex = 20;
            this.lblCharacterArmor1.Text = "Armor 1:";
            // 
            // lblCharacterEquipment
            // 
            this.lblCharacterEquipment.AutoSize = true;
            this.lblCharacterEquipment.Location = new System.Drawing.Point(6, 51);
            this.lblCharacterEquipment.Name = "lblCharacterEquipment";
            this.lblCharacterEquipment.Size = new System.Drawing.Size(60, 13);
            this.lblCharacterEquipment.TabIndex = 17;
            this.lblCharacterEquipment.Text = "Equipment:";
            // 
            // lblCharacterWeapon
            // 
            this.lblCharacterWeapon.AutoSize = true;
            this.lblCharacterWeapon.Location = new System.Drawing.Point(6, 22);
            this.lblCharacterWeapon.Name = "lblCharacterWeapon";
            this.lblCharacterWeapon.Size = new System.Drawing.Size(51, 13);
            this.lblCharacterWeapon.TabIndex = 14;
            this.lblCharacterWeapon.Text = "Weapon:";
            // 
            // lblCharacterSubclass
            // 
            this.lblCharacterSubclass.AutoSize = true;
            this.lblCharacterSubclass.Location = new System.Drawing.Point(180, 100);
            this.lblCharacterSubclass.Name = "lblCharacterSubclass";
            this.lblCharacterSubclass.Size = new System.Drawing.Size(53, 13);
            this.lblCharacterSubclass.TabIndex = 10;
            this.lblCharacterSubclass.Text = "Subclass:";
            // 
            // lblCharacterClass
            // 
            this.lblCharacterClass.AutoSize = true;
            this.lblCharacterClass.Location = new System.Drawing.Point(6, 100);
            this.lblCharacterClass.Name = "lblCharacterClass";
            this.lblCharacterClass.Size = new System.Drawing.Size(35, 13);
            this.lblCharacterClass.TabIndex = 8;
            this.lblCharacterClass.Text = "Class:";
            // 
            // lblCharacterLevel
            // 
            this.lblCharacterLevel.AutoSize = true;
            this.lblCharacterLevel.Location = new System.Drawing.Point(180, 22);
            this.lblCharacterLevel.Name = "lblCharacterLevel";
            this.lblCharacterLevel.Size = new System.Drawing.Size(36, 13);
            this.lblCharacterLevel.TabIndex = 2;
            this.lblCharacterLevel.Text = "Level:";
            // 
            // cmbCharacterSubclass
            // 
            this.cmbCharacterSubclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterSubclass.FormattingEnabled = true;
            this.cmbCharacterSubclass.Location = new System.Drawing.Point(250, 97);
            this.cmbCharacterSubclass.Name = "cmbCharacterSubclass";
            this.cmbCharacterSubclass.Size = new System.Drawing.Size(100, 21);
            this.cmbCharacterSubclass.TabIndex = 11;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(6, 22);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(38, 13);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Name:";
            // 
            // cmbCharacterClass
            // 
            this.cmbCharacterClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterClass.FormattingEnabled = true;
            this.cmbCharacterClass.Location = new System.Drawing.Point(74, 97);
            this.cmbCharacterClass.Name = "cmbCharacterClass";
            this.cmbCharacterClass.Size = new System.Drawing.Size(100, 21);
            this.cmbCharacterClass.TabIndex = 9;
            // 
            // nudCharacterLevel
            // 
            this.nudCharacterLevel.Location = new System.Drawing.Point(249, 19);
            this.nudCharacterLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudCharacterLevel.Name = "nudCharacterLevel";
            this.nudCharacterLevel.Size = new System.Drawing.Size(50, 20);
            this.nudCharacterLevel.TabIndex = 3;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(74, 19);
            this.txtCharacterName.MaxLength = 9;
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterName.TabIndex = 1;
            // 
            // gbEquipment
            // 
            this.gbEquipment.Controls.Add(this.cmbCharacterWeapon);
            this.gbEquipment.Controls.Add(this.lblCharacterWeapon);
            this.gbEquipment.Controls.Add(this.lblCharacterEquipment);
            this.gbEquipment.Controls.Add(this.lblCharacterArmor1);
            this.gbEquipment.Controls.Add(this.lblCharacterArmor2);
            this.gbEquipment.Controls.Add(this.btnCharacterEditWeaponEffect);
            this.gbEquipment.Controls.Add(this.cmbCharacterEquipment);
            this.gbEquipment.Controls.Add(this.cmbCharacterArmor1);
            this.gbEquipment.Controls.Add(this.cmbCharacterArmor2);
            this.gbEquipment.Controls.Add(this.btnCharacterEditEquipEffect);
            this.gbEquipment.Controls.Add(this.btnCharacterEditArmor1Effect);
            this.gbEquipment.Controls.Add(this.btnCharacterEditArmor2Effect);
            this.gbEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEquipment.Location = new System.Drawing.Point(513, 3);
            this.gbEquipment.Name = "gbEquipment";
            this.gbEquipment.Size = new System.Drawing.Size(384, 244);
            this.gbEquipment.TabIndex = 2;
            this.gbEquipment.TabStop = false;
            this.gbEquipment.Text = "Equipment";
            // 
            // icmbCharacterPortrait
            // 
            this.icmbCharacterPortrait.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.icmbCharacterPortrait.DropDownItemHeight = 18;
            this.icmbCharacterPortrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icmbCharacterPortrait.Location = new System.Drawing.Point(74, 124);
            this.icmbCharacterPortrait.Name = "icmbCharacterPortrait";
            this.icmbCharacterPortrait.Size = new System.Drawing.Size(100, 21);
            this.icmbCharacterPortrait.TabIndex = 13;
            // 
            // lbCharacters
            // 
            this.lbCharacters.AlternateBackColorOnDraw = true;
            this.lbCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCharacters.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCharacters.FormattingEnabled = true;
            this.lbCharacters.IntegralHeight = false;
            this.lbCharacters.Location = new System.Drawing.Point(3, 3);
            this.lbCharacters.Name = "lbCharacters";
            this.tableLayoutPanel1.SetRowSpan(this.lbCharacters, 2);
            this.lbCharacters.Size = new System.Drawing.Size(114, 494);
            this.lbCharacters.TabIndex = 0;
            this.lbCharacters.SelectedIndexChanged += new System.EventHandler(this.lbCharacters_SelectedIndexChanged);
            this.lbCharacters.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbCharacters_Format);
            // 
            // CharacterEditor
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CharacterEditor";
            this.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacterLevel)).EndInit();
            this.gbEquipment.ResumeLayout(false);
            this.gbEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ListBoxEx lbCharacters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.Label lblCharacterPortrait;
        private Controls.ImageComboBox icmbCharacterPortrait;
        private System.Windows.Forms.Label lblCharacterCurrentTP;
        private System.Windows.Forms.TextBox txtCharacterCurrentTP;
        private System.Windows.Forms.Label lblCharacterCurrentHP;
        private System.Windows.Forms.TextBox txtCharacterCurrentHP;
        private System.Windows.Forms.Button btnCharacterStatsEditor;
        private System.Windows.Forms.Button btnCharacterEditArmor2Effect;
        private System.Windows.Forms.Button btnCharacterEditArmor1Effect;
        private System.Windows.Forms.Button btnCharacterEditEquipEffect;
        private System.Windows.Forms.ComboBox cmbCharacterArmor2;
        private System.Windows.Forms.ComboBox cmbCharacterArmor1;
        private System.Windows.Forms.ComboBox cmbCharacterEquipment;
        private System.Windows.Forms.ComboBox cmbCharacterWeapon;
        private System.Windows.Forms.Button btnCharacterEditWeaponEffect;
        private System.Windows.Forms.Button btnCharacterSkillEditor;
        private System.Windows.Forms.Label lblCharacterArmor2;
        private System.Windows.Forms.Label lblCharacterArmor1;
        private System.Windows.Forms.Label lblCharacterEquipment;
        private System.Windows.Forms.Label lblCharacterWeapon;
        private System.Windows.Forms.Label lblCharacterSubclass;
        private System.Windows.Forms.Label lblCharacterClass;
        private System.Windows.Forms.Label lblCharacterLevel;
        private System.Windows.Forms.ComboBox cmbCharacterSubclass;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.ComboBox cmbCharacterClass;
        private System.Windows.Forms.NumericUpDown nudCharacterLevel;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblCharacterEXP;
        private System.Windows.Forms.TextBox txtCharacterEXP;
        private System.Windows.Forms.Label lblCharacterAvailSkillPoints;
        private System.Windows.Forms.TextBox txtCharacterAvailSkillPoints;
        private System.Windows.Forms.CheckBox chkCharacterIsGuildCardChara;
        private System.Windows.Forms.Label lblCharacterOriginGuildName;
        private System.Windows.Forms.TextBox txtCharacterOriginGuildName;
        private System.Windows.Forms.GroupBox gbEquipment;
    }
}
