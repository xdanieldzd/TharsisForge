using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class CharacterEditor : UserControl
    {
        // TODO: rewrite eventually

        Mori4Game gameData;
        Character currentCharacter;

        ComboBox[] equipmentComboBoxes;

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

            equipmentComboBoxes = new ComboBox[] { cmbEquipWeaponItem, cmbEquipEquipItem, cmbEquipArmor1Item, cmbEquipArmor2Item };

            foreach (ComboBox comboBox in equipmentComboBoxes)
            {
                comboBox.DisplayMember = "Value";
                comboBox.ValueMember = "Key";
                comboBox.DataSource = new BindingSource(XmlHelper.ItemNames, null);
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

            cmbEquipWeaponItem.SetBinding("SelectedValue", currentCharacter.WeaponSlot, "ItemID");
            cmbEquipEquipItem.SetBinding("SelectedValue", currentCharacter.EquipmentSlot, "ItemID");
            cmbEquipArmor1Item.SetBinding("SelectedValue", currentCharacter.ArmorSlot1, "ItemID");
            cmbEquipArmor2Item.SetBinding("SelectedValue", currentCharacter.ArmorSlot2, "ItemID");
        }

        private void lbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializePages((sender as ListBox).SelectedItem as Character);
        }

        private void btnSkillEditor_Click(object sender, EventArgs e)
        {
            SkillEditorDialog sed = new SkillEditorDialog(currentCharacter.Class, currentCharacter.MainSkillLevels, currentCharacter.Subclass, currentCharacter.SubSkillLevels);
            sed.ShowDialog();
        }

        private void btnWeaponEffectsEdit_Click(object sender, EventArgs e)
        {
            ShowEffectEditor(currentCharacter.WeaponSlot);
        }

        private void btnEquipEffectsEdit_Click(object sender, EventArgs e)
        {
            ShowEffectEditor(currentCharacter.EquipmentSlot);
        }

        private void btnArmor1EffectsEdit_Click(object sender, EventArgs e)
        {
            ShowEffectEditor(currentCharacter.ArmorSlot1);
        }

        private void btnArmor2EffectsEdit_Click(object sender, EventArgs e)
        {
            ShowEffectEditor(currentCharacter.ArmorSlot2);
        }

        private void ShowEffectEditor(Item slot)
        {
            EffectEditorDialog eed = new EffectEditorDialog(slot);
            eed.ShowDialog();
        }
    }
}
