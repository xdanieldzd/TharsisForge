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
    public partial class GuildCardEditor : UserControl
    {
        Mori4GdCard guildCardData;
        GuildCard currentGuildCard;

        TextBox[] nameTextBoxes;
        NumericUpDown[] levelNumericUpDowns;
        ComboBox[] classComboBoxes;

        bool changingGuildCards;

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

            lbGuildCards.DataSource = this.guildCardData.GuildCards;
            lbGuildCards.DisplayMember = "GuildName";
        }

        private void InitializeControls(GuildCard guildCard)
        {
            currentGuildCard = guildCard;
            changingGuildCards = true;

            for (int i = 0; i < currentGuildCard.CharacterListings.Length; i++)
            {
                nameTextBoxes[i].Text = currentGuildCard.CharacterListings[i].Name;
                levelNumericUpDowns[i].Value = currentGuildCard.CharacterListings[i].Level;
                classComboBoxes[i].SelectedItem = currentGuildCard.CharacterListings[i].Class;
            }

            textBox6.Text = currentGuildCard.GuildName;
            textBox7.Text = currentGuildCard.SkyshipName;
            textBox8.Text = currentGuildCard.Message;

            numericUpDown6.Value = currentGuildCard.EnemyDiscovery;
            numericUpDown7.Value = currentGuildCard.ItemDiscovery;

            textBox9.Text = currentGuildCard.MaxLevel.ToString();
            textBox10.Text = currentGuildCard.VenturedDays.ToString();
            textBox11.Text = currentGuildCard.Walked.ToString();
            textBox12.Text = currentGuildCard.EnemiesHunted.ToString();
            textBox13.Text = currentGuildCard.TotalEn.ToString();

            checkBox1.Checked = currentGuildCard.Achievement.HasVesselsAlly;
            checkBox2.Checked = currentGuildCard.Achievement.HasSentinelsAlly;
            checkBox3.Checked = currentGuildCard.Achievement.HasKnightsAlly;
            checkBox4.Checked = currentGuildCard.Achievement.HasYggdrasilsHope;
            checkBox5.Checked = currentGuildCard.Achievement.HasInsectSlayer;
            checkBox6.Checked = currentGuildCard.Achievement.HasExplorersPride;

            numericUpDown8.Value = currentGuildCard.Achievement.BurstSkillCompletion;
            numericUpDown9.Value = currentGuildCard.Achievement.TreasureChestCompletion;
            numericUpDown10.Value = currentGuildCard.Achievement.QuestCompletion;
            numericUpDown11.Value = currentGuildCard.Achievement.RareBreedCompletion;
            numericUpDown12.Value = currentGuildCard.Achievement.FoodCompletion;
            numericUpDown13.Value = currentGuildCard.Achievement.MonsterCompletion;
            numericUpDown14.Value = currentGuildCard.Achievement.MaterialCompletion;
            numericUpDown15.Value = currentGuildCard.Achievement.HiddenTreasureCompletion;

            numericUpDown16.Value = currentGuildCard.Background;
            comboBox6.SelectedIndex = currentGuildCard.TreasureMap;

            chkIsCharaRegistered.Checked = (currentGuildCard.GuildCardCharacter.Level != 0);
            InitializeRegisteredCharaControls();

            changingGuildCards = false;
        }

        private void InitializeRegisteredCharaControls()
        {
            gbRegCharacter.SuspendLayout();

            if (!chkIsCharaRegistered.Checked)
            {
                textBox14.Enabled = false;
                textBox14.Text = string.Empty;
                numericUpDown17.Enabled = false;
                numericUpDown17.Minimum = 0;
                numericUpDown17.Value = 0;

                textBox15.Enabled = textBox16.Enabled = false;
                textBox15.Text = textBox16.Text = string.Empty;

                comboBox7.Enabled = comboBox8.Enabled = false;
                comboBox7.SelectedIndex = comboBox8.SelectedIndex = -1;

                comboBox9.Enabled = comboBox10.Enabled = comboBox11.Enabled = comboBox12.Enabled = false;
                comboBox9.SelectedIndex = comboBox10.SelectedIndex = comboBox11.SelectedIndex = comboBox12.SelectedIndex = -1;
                btnEditWeaponEffect.Enabled = btnEditEquipEffect.Enabled = btnEditArmor1Effect.Enabled = btnEditArmor2Effect.Enabled = false;

                btnSkillEditor.Enabled = btnStatsEditor.Enabled = false;
            }
            else
            {
                textBox14.Enabled = true;
                textBox14.Text = currentGuildCard.GuildCardCharacter.Name;
                numericUpDown17.Enabled = true;
                numericUpDown17.Minimum = 1;
                numericUpDown17.Value = currentGuildCard.GuildCardCharacter.Level;

                textBox15.Enabled = textBox16.Enabled = true;
                textBox15.Text = currentGuildCard.GuildCardCharacter.CurrentHP.ToString();
                textBox16.Text = currentGuildCard.GuildCardCharacter.CurrentTP.ToString();

                comboBox7.Enabled = true;
                comboBox7.SelectedItem = currentGuildCard.GuildCardCharacter.Class;
                comboBox8.Enabled = true;
                comboBox8.SelectedItem = currentGuildCard.GuildCardCharacter.Subclass;

                comboBox9.Enabled = true;
                comboBox9.SelectedIndex = currentGuildCard.GuildCardCharacter.WeaponSlot.ItemID;
                comboBox10.Enabled = true;
                comboBox10.SelectedIndex = currentGuildCard.GuildCardCharacter.EquipmentSlot.ItemID;
                comboBox11.Enabled = true;
                comboBox11.SelectedIndex = currentGuildCard.GuildCardCharacter.ArmorSlot1.ItemID;
                comboBox12.Enabled = true;
                comboBox12.SelectedIndex = currentGuildCard.GuildCardCharacter.ArmorSlot2.ItemID;

                btnEditWeaponEffect.Enabled = btnEditEquipEffect.Enabled = btnEditArmor1Effect.Enabled = btnEditArmor2Effect.Enabled = true;

                btnSkillEditor.Enabled = btnStatsEditor.Enabled = true;
            }

            gbRegCharacter.ResumeLayout();
        }

        private void lbGuildCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeControls((sender as ListBox).SelectedItem as GuildCard);
        }

        private void chkIsCharaRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (changingGuildCards) return;

            CheckBox checkBox = (sender as CheckBox);
            if (!checkBox.Checked && currentGuildCard.GuildCardCharacter.IsValid)
            {
                if (MessageBox.Show("Warning: This will delete the existing Guild Card character. Really continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    currentGuildCard.GuildCardCharacter.IsValid = false;
                    InitializeRegisteredCharaControls();
                }
                else
                    checkBox.Checked = true;
            }
            else
            {
                if (!currentGuildCard.GuildCardCharacter.IsValid) currentGuildCard.GuildCardCharacter = new GuildCardCharacter();
                InitializeRegisteredCharaControls();
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
