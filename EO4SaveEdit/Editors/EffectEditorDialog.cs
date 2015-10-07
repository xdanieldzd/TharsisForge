using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class EffectEditorDialog : Form
    {
        // TODO: Verify effect names, maybe add icons?

        static Dictionary<ForgeEffect, string> effectNames = new Dictionary<ForgeEffect, string>()
        {
            { ForgeEffect.None, "None" },
            { ForgeEffect.HP, "HP Up" },
            { ForgeEffect.TP, "TP Up" },
            { ForgeEffect.STR, "STR Up" },
            { ForgeEffect.TEC, "TEC Up" },
            { ForgeEffect.VIT, "VIT Up" },
            { ForgeEffect.AGI, "AGI Up" },
            { ForgeEffect.LUC, "LUC Up" },
            { ForgeEffect.SPD, "SPD Up" },
            { ForgeEffect.BRS, "BRS Up" },
            { ForgeEffect.ATK, "ATK Up" },
            { ForgeEffect.ELM, "ELM Up" },
            { ForgeEffect.HIT, "HIT Up" },
            { ForgeEffect.CRI, "CRI Up" },
            { ForgeEffect.Fire, "Fire Effect/Resist" },
            { ForgeEffect.Ice, "Ice Effect/Resist" },
            { ForgeEffect.Volt, "Volt Effect/Resist" },
            { ForgeEffect.Piercing, "Piercing Effect" },
            { ForgeEffect.Splashing, "Splashing Effect" },
            { ForgeEffect.Blind, "Blind Effect/Resist" },
            { ForgeEffect.Sleep, "Sleep Effect/Resist" },
            { ForgeEffect.Poison, "Poison Effect/Resist" },
            { ForgeEffect.Panic, "Panic Effect/Resist" },
            { ForgeEffect.Paralyze, "Paralyze Effect/Resist" },
            { ForgeEffect.Stun, "Stun Effect/Resist" },
            { ForgeEffect.Petrify, "Petrify Effect/Resist" },
            { ForgeEffect.Death, "Death Effect/Resist" },
            { ForgeEffect.Curse, "Curse Effect/Resist" },
            { ForgeEffect.HeadBind, "Head Bind Effect/Resist" },
            { ForgeEffect.ArmBind, "Arm Bind Effect/Resist" },
            { ForgeEffect.LegBind, "Leg Bind Effect/Resist" },
            { ForgeEffect.SlashResist, "Slash Resist" },
            { ForgeEffect.BashResist, "Bash Resist" },
            { ForgeEffect.PierceResist, "Pierce Resist" },
        };

        Item equipmentData;

        ComboBox[] effectComboBoxes;
        ErrorProvider numForgeableSlotsErrorProvider;

        public EffectEditorDialog(Item equipment)
        {
            InitializeComponent();

            this.equipmentData = equipment;

            gbItemEffects.Text = XmlHelper.ItemNames[equipmentData.ItemID];
            txtNumForgeableSlots.SetBinding("Text", equipmentData, "NumForgeableSlots");

            effectComboBoxes = new ComboBox[] { cmbForgeEffect1, cmbForgeEffect2, cmbForgeEffect3, cmbForgeEffect4, cmbForgeEffect5, cmbForgeEffect6, cmbForgeEffect7, cmbForgeEffect8 };
            foreach (ComboBox ctrl in effectComboBoxes)
            {
                ctrl.DataSource = null;
                ctrl.Enabled = ctrl.Visible = false;
            }

            numForgeableSlotsErrorProvider = new ErrorProvider();
            numForgeableSlotsErrorProvider.SetIconAlignment(this.txtNumForgeableSlots, ErrorIconAlignment.MiddleLeft);
            numForgeableSlotsErrorProvider.SetIconPadding(this.txtNumForgeableSlots, 2);
            numForgeableSlotsErrorProvider.BlinkRate = 500;
            numForgeableSlotsErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            UpdateForgeableSlots();
        }

        private void UpdateForgeableSlots()
        {
            for (int i = XmlHelper.NumForgeSlots[equipmentData.ItemID] - 1, j = equipmentData.NumForgeableSlots - 1; i >= 0; i--, j--)
            {
                effectComboBoxes[i].Enabled = (j >= 0);

                effectComboBoxes[i].Visible = true;
                effectComboBoxes[i].ValueMember = "Key";
                effectComboBoxes[i].DisplayMember = "Value";
                effectComboBoxes[i].DataSource = new BindingSource(effectNames, null);
                effectComboBoxes[i].SelectedValue = equipmentData.EffectSlots[i];
            }
        }

        private void EffectEditorDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ValidateChildren();
        }

        private void txtNumForgeableSlots_Validating(object sender, CancelEventArgs e)
        {
            byte numSlots = equipmentData.NumForgeableSlots;
            e.Cancel = !byte.TryParse((sender as TextBox).Text, out numSlots);

            if (numSlots < 0 || numSlots > XmlHelper.NumForgeSlots[equipmentData.ItemID])
            {
                e.Cancel = true;
                numForgeableSlotsErrorProvider.SetError((sender as TextBox), "Invalid number of slots.");
            }
            else if (!e.Cancel)
            {
                numForgeableSlotsErrorProvider.SetError((sender as TextBox), string.Empty);
                UpdateForgeableSlots();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
