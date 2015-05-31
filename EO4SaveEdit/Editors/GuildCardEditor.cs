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

            XmlDocument xmlItemData = new XmlDocument();
            xmlItemData.Load("Data\\TreasureMapData.xml");
            for (int i = 1; i < xmlItemData.DocumentElement.ChildNodes.Count; i++)
                comboBox6.Items.Add(xmlItemData.DocumentElement.ChildNodes[i].InnerText);

            lbGuildCards.DataSource = this.guildCardData.GuildCards;
            lbGuildCards.DisplayMember = "GuildName";
        }

        private void InitializeControls(GuildCard guildCard)
        {
            currentGuildCard = guildCard;

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
        }

        private void lbGuildCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeControls((sender as ListBox).SelectedItem as GuildCard);
        }
    }
}
