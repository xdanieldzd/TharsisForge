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
        Mori4Game gameData;
        Character currentCharacter;

        TextBox[] weaponForgeSlots, equipForgeSlots, armor1ForgeSlots, armor2ForgeSlots;
        List<int> numForgeSlots;

        public CharacterEditor()
        {
            InitializeComponent();

            weaponForgeSlots = new TextBox[] 
            {
                txtEquipWeaponForge1, txtEquipWeaponForge2, txtEquipWeaponForge3, txtEquipWeaponForge4, txtEquipWeaponForge5, txtEquipWeaponForge6, txtEquipWeaponForge7, txtEquipWeaponForge8
            };
            equipForgeSlots = new TextBox[]
            {
                txtEquipEquipForge1, txtEquipEquipForge2, txtEquipEquipForge3, txtEquipEquipForge4, txtEquipEquipForge5, txtEquipEquipForge6, txtEquipEquipForge7, txtEquipEquipForge8
            };
            armor1ForgeSlots = new TextBox[]
            {
                txtEquipArmor1Forge1, txtEquipArmor1Forge2, txtEquipArmor1Forge3, txtEquipArmor1Forge4, txtEquipArmor1Forge5, txtEquipArmor1Forge6, txtEquipArmor1Forge7, txtEquipArmor1Forge8
            };
            armor2ForgeSlots = new TextBox[]
            {
                txtEquipArmor2Forge1, txtEquipArmor2Forge2, txtEquipArmor2Forge3, txtEquipArmor2Forge4, txtEquipArmor2Forge5, txtEquipArmor2Forge6, txtEquipArmor2Forge7, txtEquipArmor2Forge8
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

            cmbClass.DataSource = Enum.GetValues(typeof(Class));
            cmbSubclass.DataSource = Enum.GetValues(typeof(Class));

            lbCharacters.DataSource = this.gameData.Characters;
            lbCharacters.DisplayMember = "Name";
        }

        private void InitializePages(Character character)
        {
            currentCharacter = character;

            nudCharaID.Value = currentCharacter.ID;
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
        }

        private void InitializeForgeSlots(TextBox[] slotTextBoxes, EquipmentSlot slotData)
        {
            for (int i = 0; i < slotTextBoxes.Length; i++)
            {
                slotTextBoxes[i].ReadOnly = true;
                slotTextBoxes[i].Text = string.Empty;
            }
            for (int i = numForgeSlots[slotData.ItemID] - 1, j = slotData.NumForgeableSlots - 1; i >= 0; i--, j--)
            {
                slotTextBoxes[i].Text = slotData.EffectSlots[i].ToString("X");
                if (j >= 0)
                    slotTextBoxes[i].ReadOnly = false;
            }
        }

        private void lbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializePages((sender as ListBox).SelectedItem as Character);
        }
    }
}
