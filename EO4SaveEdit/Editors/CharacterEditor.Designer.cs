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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkillEditor = new System.Windows.Forms.Button();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.lblCharaID = new System.Windows.Forms.Label();
            this.nudCharaID = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSubclass = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubclass = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.tpEquipment = new System.Windows.Forms.TabPage();
            this.gbEquipArmor1 = new System.Windows.Forms.GroupBox();
            this.btnArmor1EffectsEdit = new System.Windows.Forms.Button();
            this.cmbEquipArmor1Item = new System.Windows.Forms.ComboBox();
            this.lblEquipArmor1Item = new System.Windows.Forms.Label();
            this.gbEquipEquip = new System.Windows.Forms.GroupBox();
            this.btnEquipEffectsEdit = new System.Windows.Forms.Button();
            this.cmbEquipEquipItem = new System.Windows.Forms.ComboBox();
            this.lblEquipEquipItem = new System.Windows.Forms.Label();
            this.gbEquipWeapon = new System.Windows.Forms.GroupBox();
            this.btnWeaponEffectsEdit = new System.Windows.Forms.Button();
            this.cmbEquipWeaponItem = new System.Windows.Forms.ComboBox();
            this.lblEquipWeaponItem = new System.Windows.Forms.Label();
            this.gbEquipArmor2 = new System.Windows.Forms.GroupBox();
            this.btnArmor2EffectsEdit = new System.Windows.Forms.Button();
            this.cmbEquipArmor2Item = new System.Windows.Forms.ComboBox();
            this.lblEquipArmor2Item = new System.Windows.Forms.Label();
            this.tpSkills = new System.Windows.Forms.TabPage();
            this.tcCharaParts.SuspendLayout();
            this.tpStats.SuspendLayout();
            this.gbBasics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharaID)).BeginInit();
            this.tpEquipment.SuspendLayout();
            this.gbEquipArmor1.SuspendLayout();
            this.gbEquipEquip.SuspendLayout();
            this.gbEquipWeapon.SuspendLayout();
            this.gbEquipArmor2.SuspendLayout();
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
            this.tcCharaParts.Controls.Add(this.tpEquipment);
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
            this.tpStats.Controls.Add(this.label2);
            this.tpStats.Controls.Add(this.btnSkillEditor);
            this.tpStats.Controls.Add(this.gbBasics);
            this.tpStats.Location = new System.Drawing.Point(4, 22);
            this.tpStats.Name = "tpStats";
            this.tpStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats.Size = new System.Drawing.Size(762, 574);
            this.tpStats.TabIndex = 0;
            this.tpStats.Text = "Stats";
            this.tpStats.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TODO TODO TODO  Cleanup everything on this control!";
            // 
            // btnSkillEditor
            // 
            this.btnSkillEditor.Location = new System.Drawing.Point(15, 102);
            this.btnSkillEditor.Name = "btnSkillEditor";
            this.btnSkillEditor.Size = new System.Drawing.Size(75, 23);
            this.btnSkillEditor.TabIndex = 7;
            this.btnSkillEditor.Text = "Edit Skills";
            this.btnSkillEditor.UseVisualStyleBackColor = true;
            this.btnSkillEditor.Click += new System.EventHandler(this.btnSkillEditor_Click);
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.nudLevel);
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
            this.gbBasics.Size = new System.Drawing.Size(750, 90);
            this.gbBasics.TabIndex = 6;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Basic Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Level:";
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(178, 20);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(45, 20);
            this.nudLevel.TabIndex = 8;
            // 
            // lblCharaID
            // 
            this.lblCharaID.AutoSize = true;
            this.lblCharaID.Location = new System.Drawing.Point(6, 21);
            this.lblCharaID.Name = "lblCharaID";
            this.lblCharaID.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.lblCharaID.Size = new System.Drawing.Size(27, 13);
            this.lblCharaID.TabIndex = 7;
            this.lblCharaID.Text = "ID:";
            // 
            // nudCharaID
            // 
            this.nudCharaID.Location = new System.Drawing.Point(53, 19);
            this.nudCharaID.Name = "nudCharaID";
            this.nudCharaID.Size = new System.Drawing.Size(45, 20);
            this.nudCharaID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(303, 19);
            this.txtName.MaxLength = 9;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbSubclass
            // 
            this.cmbSubclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubclass.FormattingEnabled = true;
            this.cmbSubclass.Location = new System.Drawing.Point(303, 46);
            this.cmbSubclass.Name = "cmbSubclass";
            this.cmbSubclass.Size = new System.Drawing.Size(170, 21);
            this.cmbSubclass.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(229, 21);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(9, 0, 6, 0);
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSubclass
            // 
            this.lblSubclass.AutoSize = true;
            this.lblSubclass.Location = new System.Drawing.Point(229, 49);
            this.lblSubclass.Name = "lblSubclass";
            this.lblSubclass.Padding = new System.Windows.Forms.Padding(9, 0, 6, 0);
            this.lblSubclass.Size = new System.Drawing.Size(68, 13);
            this.lblSubclass.TabIndex = 4;
            this.lblSubclass.Text = "Subclass:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(6, 49);
            this.lblClass.Name = "lblClass";
            this.lblClass.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.lblClass.Size = new System.Drawing.Size(41, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(53, 46);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(170, 21);
            this.cmbClass.TabIndex = 3;
            // 
            // tpEquipment
            // 
            this.tpEquipment.Controls.Add(this.gbEquipArmor1);
            this.tpEquipment.Controls.Add(this.gbEquipEquip);
            this.tpEquipment.Controls.Add(this.gbEquipWeapon);
            this.tpEquipment.Controls.Add(this.gbEquipArmor2);
            this.tpEquipment.Location = new System.Drawing.Point(4, 22);
            this.tpEquipment.Name = "tpEquipment";
            this.tpEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tpEquipment.Size = new System.Drawing.Size(762, 574);
            this.tpEquipment.TabIndex = 2;
            this.tpEquipment.Text = "Equipment";
            this.tpEquipment.UseVisualStyleBackColor = true;
            // 
            // gbEquipArmor1
            // 
            this.gbEquipArmor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquipArmor1.Controls.Add(this.btnArmor1EffectsEdit);
            this.gbEquipArmor1.Controls.Add(this.cmbEquipArmor1Item);
            this.gbEquipArmor1.Controls.Add(this.lblEquipArmor1Item);
            this.gbEquipArmor1.Location = new System.Drawing.Point(6, 178);
            this.gbEquipArmor1.Name = "gbEquipArmor1";
            this.gbEquipArmor1.Size = new System.Drawing.Size(750, 80);
            this.gbEquipArmor1.TabIndex = 10;
            this.gbEquipArmor1.TabStop = false;
            this.gbEquipArmor1.Text = "Armor (1)";
            // 
            // btnArmor1EffectsEdit
            // 
            this.btnArmor1EffectsEdit.Location = new System.Drawing.Point(278, 19);
            this.btnArmor1EffectsEdit.Name = "btnArmor1EffectsEdit";
            this.btnArmor1EffectsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnArmor1EffectsEdit.TabIndex = 18;
            this.btnArmor1EffectsEdit.Text = "Edit Effects";
            this.btnArmor1EffectsEdit.UseVisualStyleBackColor = true;
            this.btnArmor1EffectsEdit.Click += new System.EventHandler(this.btnArmor1EffectsEdit_Click);
            // 
            // cmbEquipArmor1Item
            // 
            this.cmbEquipArmor1Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipArmor1Item.FormattingEnabled = true;
            this.cmbEquipArmor1Item.Location = new System.Drawing.Point(72, 19);
            this.cmbEquipArmor1Item.Name = "cmbEquipArmor1Item";
            this.cmbEquipArmor1Item.Size = new System.Drawing.Size(200, 21);
            this.cmbEquipArmor1Item.TabIndex = 17;
            // 
            // lblEquipArmor1Item
            // 
            this.lblEquipArmor1Item.AutoSize = true;
            this.lblEquipArmor1Item.Location = new System.Drawing.Point(6, 22);
            this.lblEquipArmor1Item.Name = "lblEquipArmor1Item";
            this.lblEquipArmor1Item.Size = new System.Drawing.Size(30, 13);
            this.lblEquipArmor1Item.TabIndex = 5;
            this.lblEquipArmor1Item.Text = "Item:";
            // 
            // gbEquipEquip
            // 
            this.gbEquipEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquipEquip.Controls.Add(this.btnEquipEffectsEdit);
            this.gbEquipEquip.Controls.Add(this.cmbEquipEquipItem);
            this.gbEquipEquip.Controls.Add(this.lblEquipEquipItem);
            this.gbEquipEquip.Location = new System.Drawing.Point(6, 92);
            this.gbEquipEquip.Name = "gbEquipEquip";
            this.gbEquipEquip.Size = new System.Drawing.Size(750, 80);
            this.gbEquipEquip.TabIndex = 9;
            this.gbEquipEquip.TabStop = false;
            this.gbEquipEquip.Text = "Equipment";
            // 
            // btnEquipEffectsEdit
            // 
            this.btnEquipEffectsEdit.Location = new System.Drawing.Point(278, 19);
            this.btnEquipEffectsEdit.Name = "btnEquipEffectsEdit";
            this.btnEquipEffectsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEquipEffectsEdit.TabIndex = 17;
            this.btnEquipEffectsEdit.Text = "Edit Effects";
            this.btnEquipEffectsEdit.UseVisualStyleBackColor = true;
            this.btnEquipEffectsEdit.Click += new System.EventHandler(this.btnEquipEffectsEdit_Click);
            // 
            // cmbEquipEquipItem
            // 
            this.cmbEquipEquipItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipEquipItem.FormattingEnabled = true;
            this.cmbEquipEquipItem.Location = new System.Drawing.Point(72, 19);
            this.cmbEquipEquipItem.Name = "cmbEquipEquipItem";
            this.cmbEquipEquipItem.Size = new System.Drawing.Size(200, 21);
            this.cmbEquipEquipItem.TabIndex = 16;
            // 
            // lblEquipEquipItem
            // 
            this.lblEquipEquipItem.AutoSize = true;
            this.lblEquipEquipItem.Location = new System.Drawing.Point(6, 22);
            this.lblEquipEquipItem.Name = "lblEquipEquipItem";
            this.lblEquipEquipItem.Size = new System.Drawing.Size(30, 13);
            this.lblEquipEquipItem.TabIndex = 3;
            this.lblEquipEquipItem.Text = "Item:";
            // 
            // gbEquipWeapon
            // 
            this.gbEquipWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquipWeapon.Controls.Add(this.btnWeaponEffectsEdit);
            this.gbEquipWeapon.Controls.Add(this.cmbEquipWeaponItem);
            this.gbEquipWeapon.Controls.Add(this.lblEquipWeaponItem);
            this.gbEquipWeapon.Location = new System.Drawing.Point(6, 6);
            this.gbEquipWeapon.Name = "gbEquipWeapon";
            this.gbEquipWeapon.Size = new System.Drawing.Size(750, 80);
            this.gbEquipWeapon.TabIndex = 8;
            this.gbEquipWeapon.TabStop = false;
            this.gbEquipWeapon.Text = "Weapon";
            // 
            // btnWeaponEffectsEdit
            // 
            this.btnWeaponEffectsEdit.Location = new System.Drawing.Point(278, 19);
            this.btnWeaponEffectsEdit.Name = "btnWeaponEffectsEdit";
            this.btnWeaponEffectsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnWeaponEffectsEdit.TabIndex = 15;
            this.btnWeaponEffectsEdit.Text = "Edit Effects";
            this.btnWeaponEffectsEdit.UseVisualStyleBackColor = true;
            this.btnWeaponEffectsEdit.Click += new System.EventHandler(this.btnWeaponEffectsEdit_Click);
            // 
            // cmbEquipWeaponItem
            // 
            this.cmbEquipWeaponItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipWeaponItem.FormattingEnabled = true;
            this.cmbEquipWeaponItem.Location = new System.Drawing.Point(72, 19);
            this.cmbEquipWeaponItem.Name = "cmbEquipWeaponItem";
            this.cmbEquipWeaponItem.Size = new System.Drawing.Size(200, 21);
            this.cmbEquipWeaponItem.TabIndex = 14;
            // 
            // lblEquipWeaponItem
            // 
            this.lblEquipWeaponItem.AutoSize = true;
            this.lblEquipWeaponItem.Location = new System.Drawing.Point(6, 22);
            this.lblEquipWeaponItem.Name = "lblEquipWeaponItem";
            this.lblEquipWeaponItem.Size = new System.Drawing.Size(30, 13);
            this.lblEquipWeaponItem.TabIndex = 2;
            this.lblEquipWeaponItem.Text = "Item:";
            // 
            // gbEquipArmor2
            // 
            this.gbEquipArmor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEquipArmor2.Controls.Add(this.btnArmor2EffectsEdit);
            this.gbEquipArmor2.Controls.Add(this.cmbEquipArmor2Item);
            this.gbEquipArmor2.Controls.Add(this.lblEquipArmor2Item);
            this.gbEquipArmor2.Location = new System.Drawing.Point(6, 264);
            this.gbEquipArmor2.Name = "gbEquipArmor2";
            this.gbEquipArmor2.Size = new System.Drawing.Size(750, 80);
            this.gbEquipArmor2.TabIndex = 7;
            this.gbEquipArmor2.TabStop = false;
            this.gbEquipArmor2.Text = "Armor (2)";
            // 
            // btnArmor2EffectsEdit
            // 
            this.btnArmor2EffectsEdit.Location = new System.Drawing.Point(278, 19);
            this.btnArmor2EffectsEdit.Name = "btnArmor2EffectsEdit";
            this.btnArmor2EffectsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnArmor2EffectsEdit.TabIndex = 19;
            this.btnArmor2EffectsEdit.Text = "Edit Effects";
            this.btnArmor2EffectsEdit.UseVisualStyleBackColor = true;
            this.btnArmor2EffectsEdit.Click += new System.EventHandler(this.btnArmor2EffectsEdit_Click);
            // 
            // cmbEquipArmor2Item
            // 
            this.cmbEquipArmor2Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipArmor2Item.FormattingEnabled = true;
            this.cmbEquipArmor2Item.Location = new System.Drawing.Point(72, 19);
            this.cmbEquipArmor2Item.Name = "cmbEquipArmor2Item";
            this.cmbEquipArmor2Item.Size = new System.Drawing.Size(200, 21);
            this.cmbEquipArmor2Item.TabIndex = 18;
            // 
            // lblEquipArmor2Item
            // 
            this.lblEquipArmor2Item.AutoSize = true;
            this.lblEquipArmor2Item.Location = new System.Drawing.Point(6, 22);
            this.lblEquipArmor2Item.Name = "lblEquipArmor2Item";
            this.lblEquipArmor2Item.Size = new System.Drawing.Size(30, 13);
            this.lblEquipArmor2Item.TabIndex = 7;
            this.lblEquipArmor2Item.Text = "Item:";
            // 
            // tpSkills
            // 
            this.tpSkills.Location = new System.Drawing.Point(4, 22);
            this.tpSkills.Name = "tpSkills";
            this.tpSkills.Padding = new System.Windows.Forms.Padding(6);
            this.tpSkills.Size = new System.Drawing.Size(762, 574);
            this.tpSkills.TabIndex = 1;
            this.tpSkills.Text = "Skills";
            this.tpSkills.UseVisualStyleBackColor = true;
            // 
            // CharacterEditor
            // 
            this.Controls.Add(this.tcCharaParts);
            this.Controls.Add(this.lbCharacters);
            this.Name = "CharacterEditor";
            this.Size = new System.Drawing.Size(900, 600);
            this.tcCharaParts.ResumeLayout(false);
            this.tpStats.ResumeLayout(false);
            this.tpStats.PerformLayout();
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharaID)).EndInit();
            this.tpEquipment.ResumeLayout(false);
            this.gbEquipArmor1.ResumeLayout(false);
            this.gbEquipArmor1.PerformLayout();
            this.gbEquipEquip.ResumeLayout(false);
            this.gbEquipEquip.PerformLayout();
            this.gbEquipWeapon.ResumeLayout(false);
            this.gbEquipWeapon.PerformLayout();
            this.gbEquipArmor2.ResumeLayout(false);
            this.gbEquipArmor2.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbEquipArmor2;
        private System.Windows.Forms.Label lblEquipWeaponItem;
        private System.Windows.Forms.Label lblEquipEquipItem;
        private System.Windows.Forms.Label lblEquipArmor2Item;
        private System.Windows.Forms.Label lblEquipArmor1Item;
        private System.Windows.Forms.ComboBox cmbEquipWeaponItem;
        private System.Windows.Forms.ComboBox cmbEquipArmor2Item;
        private System.Windows.Forms.ComboBox cmbEquipArmor1Item;
        private System.Windows.Forms.ComboBox cmbEquipEquipItem;
        private System.Windows.Forms.NumericUpDown nudCharaID;
        private System.Windows.Forms.Label lblCharaID;
        private System.Windows.Forms.TabPage tpEquipment;
        private System.Windows.Forms.GroupBox gbEquipWeapon;
        private System.Windows.Forms.GroupBox gbEquipEquip;
        private System.Windows.Forms.GroupBox gbEquipArmor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Button btnSkillEditor;
        private System.Windows.Forms.Button btnWeaponEffectsEdit;
        private System.Windows.Forms.Button btnArmor1EffectsEdit;
        private System.Windows.Forms.Button btnEquipEffectsEdit;
        private System.Windows.Forms.Button btnArmor2EffectsEdit;
        private System.Windows.Forms.Label label2;
    }
}
