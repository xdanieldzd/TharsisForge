using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class EffectEditorDialog : Form
    {
        static Dictionary<byte, string> effectNames = new Dictionary<byte, string>()
        {
            // TODO: complete the list!
            { 0x00, "None" },
            { 0x01, "HP Up" },
            { 0x02, "TP Up" },
            { 0x03, "STR Up" },
            { 0x04, "TEC Up" },
            { 0x05, "VIT Up" },
            { 0x06, "AGI Up" },
            { 0x07, "LUC Up" },
            { 0x08, "BRS Up" },
            { 0x09, "SPD Up" },
            { 0x0A, "ATK Up" },
            { 0x0B, "ELM Up" },
            { 0x0C, "HIT Up" },
            { 0x0D, "CRI Up" },
            { 0x0E, "Fire Effect" },
            { 0x0F, "Ice Effect" },
            { 0x10, "Volt Effect" },
            { 0x11, "Fire Resist" },
            { 0x12, "Ice Resist" },
            { 0x13, "Volt Resist" },
            { 0x14, "0x14" },
            { 0x15, "0x15" },
            { 0x16, "0x16" },
            { 0x17, "Paralyze" },   //?
            { 0x18, "0x18" },
            { 0x19, "0x19" },
            { 0x1A, "Death Resist" },
            { 0x1B, "Death" },
            { 0x1C, "0x1C" },
            { 0x1D, "0x1D" },
            { 0x1E, "0x1E" },
            { 0x1F, "0x1F" },
            { 0x20, "Cut Resist" },    //?
            { 0x21, "0x21" },
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
