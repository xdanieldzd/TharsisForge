using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Controls;
using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class GuildCardEditor : UserControl, IEditorControl
    {
        // TODO: Redo layout for better resizability? FlowLayoutPanels?

        Mori4GdCard guildCardData;
        GuildCard currentGuildCard;

        TextBox[] nameTextBoxes;
        NumericUpDown[] levelNumericUpDowns;
        ComboBox[] classComboBoxes;
        ImageComboBox[] portraitComboBoxes;
        ComboBox[] regCharaEquipmentComboBoxes;

        public GuildCardEditor()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        public void Initialize(SaveDataHandler handler)
        {
            this.guildCardData = handler.GuildCardDataFile;

            if (this.Enabled = (this.guildCardData != null))
            {
                nameTextBoxes = new TextBox[] { txtCharaListName1, txtCharaListName2, txtCharaListName3, txtCharaListName4, txtCharaListName5 };
                levelNumericUpDowns = new NumericUpDown[] { nudCharaListLevel1, nudCharaListLevel2, nudCharaListLevel3, nudCharaListLevel4, nudCharaListLevel5 };
                classComboBoxes = new ComboBox[] { cmbCharaListClass1, cmbCharaListClass2, cmbCharaListClass3, cmbCharaListClass4, cmbCharaListClass5 };
                portraitComboBoxes = new ImageComboBox[] { icmbCharaListPortrait1, icmbCharaListPortrait2, icmbCharaListPortrait3, icmbCharaListPortrait4, icmbCharaListPortrait5 };
                regCharaEquipmentComboBoxes = new ComboBox[] { cmbRegCharacterWeapon, cmbRegCharacterEquipment, cmbRegCharacterArmor1, cmbRegCharacterArmor2 };

                foreach (ComboBox comboBox in classComboBoxes)
                {
                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";
                    comboBox.DataSource = new BindingSource(XmlHelper.ClassNames[SaveDataHandler.SaveLanguage], null);
                }

                cmbGuildTreasureMap.DisplayMember = "Value";
                cmbGuildTreasureMap.ValueMember = "Key";
                cmbGuildTreasureMap.DataSource = new BindingSource(XmlHelper.TreasureMapNames[SaveDataHandler.SaveLanguage], null);

                cmbRegCharacterClass.DisplayMember = "Value";
                cmbRegCharacterClass.ValueMember = "Key";
                cmbRegCharacterClass.DataSource = new BindingSource(XmlHelper.ClassNames[SaveDataHandler.SaveLanguage], null);

                cmbRegCharacterSubclass.DisplayMember = "Value";
                cmbRegCharacterSubclass.ValueMember = "Key";
                cmbRegCharacterSubclass.DataSource = new BindingSource(XmlHelper.ClassNames[SaveDataHandler.SaveLanguage], null);

                foreach (ComboBox comboBox in regCharaEquipmentComboBoxes)
                {
                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";
                    comboBox.DataSource = new BindingSource(XmlHelper.EquipmentNames[SaveDataHandler.SaveLanguage], null);
                }

                lbGuildCards.DataSource = new BindingSource(this.guildCardData.GuildCards, null);
            }
        }

        private void InitializeControls(GuildCard guildCard)
        {
            if (guildCard == null) return;

            for (int i = 0; i < currentGuildCard.CharacterListings.Length; i++)
            {
                nameTextBoxes[i].SetBinding("Text", currentGuildCard.CharacterListings[i], "Name");
                levelNumericUpDowns[i].SetBinding("Value", currentGuildCard.CharacterListings[i], "Level");
                classComboBoxes[i].SetBinding("SelectedValue", currentGuildCard.CharacterListings[i], "Class");

                ImageHelper.InitializePortraitComboBox(portraitComboBoxes[i], classComboBoxes[i], currentGuildCard.CharacterListings[i]);
            }

            txtGuildName.SetBinding("Text", currentGuildCard, "GuildName");
            txtGuildSkyship.SetBinding("Text", currentGuildCard, "SkyshipName");
            txtGuildMessage.SetBinding("Text", currentGuildCard, "Message");

            nudGuildEnemyDiscovery.SetBinding("Value", currentGuildCard, "EnemyDiscovery");
            nudGuildItemDiscovery.SetBinding("Value", currentGuildCard, "ItemDiscovery");

            txtGuildMaxLevel.SetBinding("Text", currentGuildCard, "MaxLevel");
            txtGuildVenturedDays.SetBinding("Text", currentGuildCard, "VenturedDays");
            txtGuildWalked.SetBinding("Text", currentGuildCard, "Walked");
            txtGuildEnemiesHunted.SetBinding("Text", currentGuildCard, "EnemiesHunted");
            txtGuildTotalEn.SetBinding("Text", currentGuildCard, "TotalEn");

            chkAchievementVesselAlly.SetBinding("Checked", currentGuildCard.Achievement, "HasVesselsAlly");
            chkAchievementSentinelAlly.SetBinding("Checked", currentGuildCard.Achievement, "HasSentinelsAlly");
            chkAchievementKnightAlly.SetBinding("Checked", currentGuildCard.Achievement, "HasKnightsAlly");
            chkAchievementYggdrasilHope.SetBinding("Checked", currentGuildCard.Achievement, "HasYggdrasilsHope");
            chkAchievementInsectSlayer.SetBinding("Checked", currentGuildCard.Achievement, "HasInsectSlayer");
            chkAchievementExplorerPride.SetBinding("Checked", currentGuildCard.Achievement, "HasExplorersPride");

            nudCompletionBurstSkills.SetBinding("Value", currentGuildCard.Achievement, "BurstSkillCompletion");
            nudCompletionTreasureBoxes.SetBinding("Value", currentGuildCard.Achievement, "TreasureChestCompletion");
            nudCompletionQuests.SetBinding("Value", currentGuildCard.Achievement, "QuestCompletion");
            nudCompletionRareBreeds.SetBinding("Value", currentGuildCard.Achievement, "RareBreedCompletion");
            nudCompletionFood.SetBinding("Value", currentGuildCard.Achievement, "FoodCompletion");
            nudCompletionMonsters.SetBinding("Value", currentGuildCard.Achievement, "MonsterCompletion");
            nudCompletionMaterials.SetBinding("Value", currentGuildCard.Achievement, "MaterialCompletion");
            nudCompletionHiddenTreasures.SetBinding("Value", currentGuildCard.Achievement, "HiddenTreasureCompletion");

            nudGuildCardBackground.SetBinding("Value", currentGuildCard, "Background");
            cmbGuildTreasureMap.SetBinding("SelectedValue", currentGuildCard, "TreasureMap");

            txtRegCharacterName.SetBinding("Text", currentGuildCard.GuildCardCharacter, "Name");
            nudRegCharacterLevel.SetBinding("Value", currentGuildCard.GuildCardCharacter, "Level");
            txtRegCharacterCurrentHP.SetBinding("Text", currentGuildCard.GuildCardCharacter, "CurrentHP");
            txtRegCharacterCurrentTP.SetBinding("Text", currentGuildCard.GuildCardCharacter, "CurrentTP");

            cmbRegCharacterClass.SetBinding("SelectedValue", currentGuildCard.GuildCardCharacter, "Class");
            cmbRegCharacterSubclass.SetBinding("SelectedValue", currentGuildCard.GuildCardCharacter, "Subclass");

            ImageHelper.InitializePortraitComboBox(icmbRegCharacterPortrait, cmbRegCharacterClass, currentGuildCard.GuildCardCharacter);

            cmbRegCharacterWeapon.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.WeaponSlot, "ItemID");
            cmbRegCharacterEquipment.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.EquipmentSlot, "ItemID");
            cmbRegCharacterArmor1.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.ArmorSlot1, "ItemID");
            cmbRegCharacterArmor2.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.ArmorSlot2, "ItemID");



            // TEMP
            //gbAchievements.DataBindings.Clear();
            //gbAchievements.DataBindings.Add("Text", currentGuildCard.Achievement, "RawValue", true, DataSourceUpdateMode.OnPropertyChanged, null, "X8");
        }

        private void lbGuildCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuildCard guildCard = ((sender as ListBox).SelectedItem as GuildCard);
            if (guildCard != null && currentGuildCard != guildCard)
                InitializeControls(currentGuildCard = guildCard);
        }

        private void lbGuildCards_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.DesiredType == typeof(string))
            {
                GuildCard selectedGuildCard = (e.ListItem as GuildCard);
                if (selectedGuildCard.GuildName == string.Empty)
                    e.Value = "(No name)";
                else
                    e.Value = selectedGuildCard.GuildName;
            }
        }

        private void btnRegCharacterEditWeaponEffect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.WeaponSlot);
            eed.ShowDialog();
        }

        private void btnRegCharacterEditEquipEffect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.EquipmentSlot);
            eed.ShowDialog();
        }

        private void btnRegCharacterEditArmor1Effect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.ArmorSlot1);
            eed.ShowDialog();
        }

        private void btnRegCharacterEditArmor2Effect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.ArmorSlot2);
            eed.ShowDialog();
        }

        private void btnRegCharacterSkillEditor_Click(object sender, EventArgs e)
        {
            SkillEditorDialog sed = new SkillEditorDialog(
                currentGuildCard.GuildCardCharacter.Class, currentGuildCard.GuildCardCharacter.MainSkillLevels,
                currentGuildCard.GuildCardCharacter.Subclass, currentGuildCard.GuildCardCharacter.SubSkillLevels);

            sed.ShowDialog();
        }

        private void btnRegCharacterStatsEditor_Click(object sender, EventArgs e)
        {
            StatsEditorDialog sted = new StatsEditorDialog(currentGuildCard.GuildCardCharacter.CumulativeStats);
            sted.ShowDialog();
        }
    }
}
