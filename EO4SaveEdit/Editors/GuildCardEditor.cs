using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class GuildCardEditor : UserControl
    {
        Mori4GdCard guildCardData;
        GuildCard currentGuildCard;

        TextBox[] nameTextBoxes;
        NumericUpDown[] levelNumericUpDowns;
        ComboBox[] classComboBoxes;

        public GuildCardEditor()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        public void Initialize(Mori4GdCard guildCard)
        {
            this.guildCardData = guildCard;

            if (this.guildCardData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            nameTextBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            levelNumericUpDowns = new NumericUpDown[] { numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5 };
            classComboBoxes = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5 };

            foreach (ComboBox comboBox in classComboBoxes) comboBox.DataSource = Enum.GetValues(typeof(Class));

            foreach (string mapName in XmlHelper.TreasureMapNames.Where(x => x != null))
                comboBox6.Items.Add(mapName);

            comboBox7.DataSource = Enum.GetValues(typeof(Class));
            comboBox8.DataSource = Enum.GetValues(typeof(Class));

            comboBox9.DataSource = XmlHelper.ItemNames.ToList();
            comboBox10.DataSource = XmlHelper.ItemNames.ToList();
            comboBox11.DataSource = XmlHelper.ItemNames.ToList();
            comboBox12.DataSource = XmlHelper.ItemNames.ToList();

            lbGuildCards.DataSource = new BindingSource(this.guildCardData.GuildCards, null);
        }

        private void InitializeControls(GuildCard guildCard)
        {
            if (guildCard == null) return;

            for (int i = 0; i < currentGuildCard.CharacterListings.Length; i++)
            {
                nameTextBoxes[i].SetBinding("Text", currentGuildCard.CharacterListings[i], "Name");
                levelNumericUpDowns[i].SetBinding("Value", currentGuildCard.CharacterListings[i], "Level");
                classComboBoxes[i].SetBinding("SelectedItem", currentGuildCard.CharacterListings[i], "Class");
            }

            textBox6.SetBinding("Text", currentGuildCard, "GuildName");
            textBox7.SetBinding("Text", currentGuildCard, "SkyshipName");
            textBox8.SetBinding("Text", currentGuildCard, "Message");

            numericUpDown6.SetBinding("Value", currentGuildCard, "EnemyDiscovery");
            numericUpDown7.SetBinding("Value", currentGuildCard, "ItemDiscovery");

            textBox9.SetBinding("Text", currentGuildCard, "MaxLevel");
            textBox10.SetBinding("Text", currentGuildCard, "VenturedDays");
            textBox11.SetBinding("Text", currentGuildCard, "Walked");
            textBox12.SetBinding("Text", currentGuildCard, "EnemiesHunted");
            textBox13.SetBinding("Text", currentGuildCard, "TotalEn");

            checkBox1.SetBinding("Checked", currentGuildCard.Achievement, "HasVesselsAlly");
            checkBox2.SetBinding("Checked", currentGuildCard.Achievement, "HasSentinelsAlly");
            checkBox3.SetBinding("Checked", currentGuildCard.Achievement, "HasKnightsAlly");
            checkBox4.SetBinding("Checked", currentGuildCard.Achievement, "HasYggdrasilsHope");
            checkBox5.SetBinding("Checked", currentGuildCard.Achievement, "HasInsectSlayer");
            checkBox6.SetBinding("Checked", currentGuildCard.Achievement, "HasExplorersPride");

            numericUpDown8.SetBinding("Value", currentGuildCard.Achievement, "BurstSkillCompletion");
            numericUpDown9.SetBinding("Value", currentGuildCard.Achievement, "TreasureChestCompletion");
            numericUpDown10.SetBinding("Value", currentGuildCard.Achievement, "QuestCompletion");
            numericUpDown11.SetBinding("Value", currentGuildCard.Achievement, "RareBreedCompletion");
            numericUpDown12.SetBinding("Value", currentGuildCard.Achievement, "FoodCompletion");
            numericUpDown13.SetBinding("Value", currentGuildCard.Achievement, "MonsterCompletion");
            numericUpDown14.SetBinding("Value", currentGuildCard.Achievement, "MaterialCompletion");
            numericUpDown15.SetBinding("Value", currentGuildCard.Achievement, "HiddenTreasureCompletion");

            numericUpDown16.SetBinding("Value", currentGuildCard, "Background");
            comboBox6.SetBinding("SelectedIndex", currentGuildCard, "TreasureMap");

            textBox14.SetBinding("Text", currentGuildCard.GuildCardCharacter, "Name");
            numericUpDown17.SetBinding("Value", currentGuildCard.GuildCardCharacter, "Level");
            textBox15.SetBinding("Text", currentGuildCard.GuildCardCharacter, "CurrentHP");
            textBox16.SetBinding("Text", currentGuildCard.GuildCardCharacter, "CurrentTP");

            comboBox7.SetBinding("SelectedItem", currentGuildCard.GuildCardCharacter, "Class");
            comboBox8.SetBinding("SelectedItem", currentGuildCard.GuildCardCharacter, "Subclass");

            comboBox9.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.WeaponSlot, "ItemID");
            comboBox10.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.EquipmentSlot, "ItemID");
            comboBox11.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.ArmorSlot1, "ItemID");
            comboBox12.SetBinding("SelectedIndex", currentGuildCard.GuildCardCharacter.ArmorSlot2, "ItemID");



            // TEMP
            gbAchievements.DataBindings.Clear();
            gbAchievements.DataBindings.Add("Text", currentGuildCard.Achievement, "RawValue", true, DataSourceUpdateMode.OnPropertyChanged, null, "X8");
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

        private void btnSkillEditor_Click(object sender, EventArgs e)
        {
            SkillEditorDialog sed = new SkillEditorDialog(
                currentGuildCard.GuildCardCharacter.Class, currentGuildCard.GuildCardCharacter.MainSkillLevels,
                currentGuildCard.GuildCardCharacter.Subclass, currentGuildCard.GuildCardCharacter.SubSkillLevels);

            sed.ShowDialog();
        }

        private void btnEditWeaponEffect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.WeaponSlot);
            eed.ShowDialog();
        }

        private void btnEditEquipEffect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.EquipmentSlot);
            eed.ShowDialog();
        }

        private void btnEditArmor1Effect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.ArmorSlot1);
            eed.ShowDialog();
        }

        private void btnEditArmor2Effect_Click(object sender, EventArgs e)
        {
            EffectEditorDialog eed = new EffectEditorDialog(currentGuildCard.GuildCardCharacter.ArmorSlot2);
            eed.ShowDialog();
        }
    }
}
