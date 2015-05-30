using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class CharacterEditor : UserControl
    {
        Mori4Game gameData;
        Character currentCharacter;

        TextBox[] weaponForgeSlots, equipForgeSlots, armor1ForgeSlots, armor2ForgeSlots;

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

            cmbEquipWeaponItem.Text = currentCharacter.WeaponSlot.ItemID.ToString("X");
            cmbEquipEquipItem.Text = currentCharacter.EquipmentSlot.ItemID.ToString("X");
            cmbEquipArmor1Item.Text = currentCharacter.ArmorSlot1.ItemID.ToString("X");
            cmbEquipArmor2Item.Text = currentCharacter.ArmorSlot2.ItemID.ToString("X");

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
            // TODO: Assumes max possible slots on all items, which is not true!

            for (int i = slotTextBoxes.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (j < slotData.NumForgeableSlots)
                    slotTextBoxes[i].BackColor = SystemColors.Window;
                else
                    slotTextBoxes[i].BackColor = Color.LightSteelBlue;

                slotTextBoxes[j].Text = slotData.EffectSlots[j].ToString("X");
            }
        }

        private void lbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializePages((sender as ListBox).SelectedItem as Character);
        }
    }
}
