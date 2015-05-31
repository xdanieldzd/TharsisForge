using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class CharacterEditor : UserControl
    {
        static Dictionary<byte, string> effectNames = new Dictionary<byte, string>()
        {
            // TODO: complete the list!
            { 0x00, "None" },
            { 0x01, "HP" },
            { 0x02, "TP" },
            { 0x03, "STR" },
            { 0x04, "TEC" },
            { 0x05, "VIT" },
            { 0x06, "AGI" },
            { 0x07, "LUC" },
            { 0x08, "BRS" },
            { 0x09, "SPD" },
            { 0x0A, "ATK" },
            { 0x0B, "ELM" },
            { 0x0C, "HIT" },
            { 0x0D, "CRI" },
            { 0x0E, "Fire" },
            { 0x0F, "Ice" },
            { 0x10, "Volt" },
            { 0x11, "Rst Fire" },
            { 0x12, "Rst Ice" },
            { 0x13, "Rst Volt" },
            { 0x14, "0x14" },
            { 0x15, "0x15" },
            { 0x16, "0x16" },
            { 0x17, "Paralyze" },   //?
            { 0x18, "0x18" },
            { 0x19, "0x19" },
            { 0x1A, "Rst Death" },
            { 0x1B, "Death" },
            { 0x1C, "0x1C" },
            { 0x1D, "0x1D" },
            { 0x1E, "0x1E" },
            { 0x1F, "0x1F" },
            { 0x20, "Rst Cut" },    //?
            { 0x21, "0x21" },
        };

        Mori4Game gameData;
        Character currentCharacter;

        ComboBox[] weaponForgeSlots, equipForgeSlots, armor1ForgeSlots, armor2ForgeSlots;
        List<int> numForgeSlots;

        Dictionary<Class, List<Tuple<byte, string>>> skillData;

        public CharacterEditor()
        {
            InitializeComponent();
        }

        public void Initialize(Mori4Game game)
        {
            this.gameData = game;

            if (this.gameData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            weaponForgeSlots = new ComboBox[] 
            {
                cmbEquipWeaponForge1, cmbEquipWeaponForge2, cmbEquipWeaponForge3, cmbEquipWeaponForge4, cmbEquipWeaponForge5, cmbEquipWeaponForge6, cmbEquipWeaponForge7, cmbEquipWeaponForge8
            };
            equipForgeSlots = new ComboBox[]
            {
                cmbEquipEquipForge1, cmbEquipEquipForge2, cmbEquipEquipForge3, cmbEquipEquipForge4, cmbEquipEquipForge5, cmbEquipEquipForge6, cmbEquipEquipForge7, cmbEquipEquipForge8
            };
            armor1ForgeSlots = new ComboBox[]
            {
                cmbEquipArmor1Forge1, cmbEquipArmor1Forge2, cmbEquipArmor1Forge3, cmbEquipArmor1Forge4, cmbEquipArmor1Forge5, cmbEquipArmor1Forge6, cmbEquipArmor1Forge7, cmbEquipArmor1Forge8
            };
            armor2ForgeSlots = new ComboBox[]
            {
                cmbEquipArmor2Forge1, cmbEquipArmor2Forge2, cmbEquipArmor2Forge3, cmbEquipArmor2Forge4, cmbEquipArmor2Forge5, cmbEquipArmor2Forge6, cmbEquipArmor2Forge7, cmbEquipArmor2Forge8
            };

            numForgeSlots = new List<int>();

            XmlDocument xmlItemData = new XmlDocument();
            xmlItemData.Load("Data\\ItemData.xml");
            foreach (XmlNode node in xmlItemData.DocumentElement.ChildNodes)
            {
                numForgeSlots.Add(int.Parse(node.Attributes["NumSlots"].InnerText));
                cmbEquipWeaponItem.Items.Add(node.InnerText);
                cmbEquipEquipItem.Items.Add(node.InnerText);
                cmbEquipArmor1Item.Items.Add(node.InnerText);
                cmbEquipArmor2Item.Items.Add(node.InnerText);
            }

            skillData = new Dictionary<Class, List<Tuple<byte, string>>>();
            XmlDocument xmlSkillData = new XmlDocument();
            xmlSkillData.Load("Data\\SkillData.xml");
            foreach (XmlNode classNode in xmlSkillData.DocumentElement.ChildNodes)
            {
                List<Tuple<byte, string>> classSkills = new List<Tuple<byte, string>>();
                foreach (XmlNode skillNode in classNode.ChildNodes)
                {
                    classSkills.Add(new Tuple<byte, string>(byte.Parse(skillNode.Attributes["MaxLevel"].InnerText), skillNode.InnerText));
                }
                skillData[(Class)Enum.Parse(typeof(Class), classNode.Attributes["Name"].InnerText)] = classSkills;
            }

            cmbClass.DataSource = Enum.GetValues(typeof(Class));
            cmbSubclass.DataSource = Enum.GetValues(typeof(Class));

            lbCharacters.DataSource = this.gameData.Characters;
            lbCharacters.DisplayMember = "Name";
        }

        private void InitializePages(Character character)
        {
            currentCharacter = character;

            nudCharaID.Value = currentCharacter.ID;
            nudLevel.Value = currentCharacter.Level;
            txtName.Text = currentCharacter.Name;
            cmbClass.SelectedItem = currentCharacter.Class;
            cmbSubclass.SelectedItem = currentCharacter.Subclass;

            cmbEquipWeaponItem.SelectedIndex = currentCharacter.WeaponSlot.ItemID;
            cmbEquipEquipItem.SelectedIndex = currentCharacter.EquipmentSlot.ItemID;
            cmbEquipArmor1Item.SelectedIndex = currentCharacter.ArmorSlot1.ItemID;
            cmbEquipArmor2Item.SelectedIndex = currentCharacter.ArmorSlot2.ItemID;

            txtEquipWeaponNumForgeSlots.Text = currentCharacter.WeaponSlot.NumForgeableSlots.ToString();
            txtEquipEquipNumForgeSlots.Text = currentCharacter.EquipmentSlot.NumForgeableSlots.ToString();
            txtEquipArmor1NumForgeSlots.Text = currentCharacter.ArmorSlot1.NumForgeableSlots.ToString();
            txtEquipArmor2NumForgeSlots.Text = currentCharacter.ArmorSlot2.NumForgeableSlots.ToString();

            InitializeForgeSlots(weaponForgeSlots, currentCharacter.WeaponSlot);
            InitializeForgeSlots(equipForgeSlots, currentCharacter.EquipmentSlot);
            InitializeForgeSlots(armor1ForgeSlots, currentCharacter.ArmorSlot1);
            InitializeForgeSlots(armor2ForgeSlots, currentCharacter.ArmorSlot2);

            // TODO: Reinitialize when class/subclass changes!
            gbSkillsMainClass.Text = string.Format("Main Skills ({0})", currentCharacter.Class);
            gbSkillsSubclass.Text = string.Format("Sub Skills ({0})", currentCharacter.Subclass);
            InitializeSkillDataGrid(dgvSkillsMainClass, currentCharacter.Class, currentCharacter.MainSkillLevels);
            InitializeSkillDataGrid(dgvSkillsSubclass, currentCharacter.Subclass, currentCharacter.SubSkillLevels);
        }

        private void InitializeForgeSlots(ComboBox[] slotControls, EquipmentSlot slotData)
        {
            foreach (ComboBox ctrl in slotControls)
            {
                ctrl.DataSource = null;
                ctrl.Enabled = false;
            }

            for (int i = numForgeSlots[slotData.ItemID] - 1, j = slotData.NumForgeableSlots - 1; i >= 0; i--, j--)
            {
                slotControls[i].ValueMember = "Key";
                slotControls[i].DisplayMember = "Value";
                slotControls[i].DataSource = effectNames.ToList();
                slotControls[i].SelectedValue = slotData.EffectSlots[i];
                if (j >= 0)
                    slotControls[i].Enabled = true;
            }
        }

        private void InitializeSkillDataGrid(DataGridView dgv, Class charaClass, byte[] skillLevels)
        {
            dgv.AutoGenerateColumns = false;

            if (charaClass != Class.None)
            {
                DataTable table = new DataTable("SkillTable");
                table.Columns.Add("Skill", typeof(string));
                table.Columns.Add("Level", typeof(byte));
                table.Columns.Add("MaxLevel", typeof(byte));
                for (int i = 0; i < skillData[charaClass].Count; i++)
                {
                    DataRow row = table.NewRow();
                    row["Skill"] = skillData[charaClass][i].Item2;
                    row["Level"] = skillLevels[i];
                    row["MaxLevel"] = skillData[charaClass][i].Item1;
                    table.Rows.Add(row);
                }
                table.AcceptChanges();
                dgv.DataSource = table;
            }
            else
                dgv.DataSource = null;
        }

        private void lbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializePages((sender as ListBox).SelectedItem as Character);
        }

        private void dgvSkillsMainClass_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);
            if (e.RowIndex >= 0 && e.RowIndex < currentCharacter.MainSkillLevels.Length && e.ColumnIndex == 1)
                e.Cancel = ((string)e.FormattedValue == string.Empty || IsSkillLevelInvalid(e.RowIndex, currentCharacter.Class, byte.Parse((string)e.FormattedValue)));
        }

        private void dgvSkillsMainClass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentCharacter.MainSkillLevels.Length && e.ColumnIndex == 1)
                currentCharacter.MainSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvSkillsSubclass_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);
            if (e.RowIndex >= 0 && e.RowIndex < currentCharacter.SubSkillLevels.Length && e.ColumnIndex == 1)
                e.Cancel = ((string)e.FormattedValue == string.Empty || IsSkillLevelInvalid(e.RowIndex, currentCharacter.Class, byte.Parse((string)e.FormattedValue)));
        }

        private void dgvSkillsSubclass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentCharacter.SubSkillLevels.Length && e.ColumnIndex == 1)
                currentCharacter.SubSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private bool IsSkillLevelInvalid(int skillIdx, Class charaClass, byte newLevel)
        {
            if (newLevel > skillData[charaClass][skillIdx].Item1)
            {
                MessageBox.Show(
                    string.Format("Invalid skill level specified. The maximum level for this skill is {0}.", skillData[currentCharacter.Class][skillIdx].Item1), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
