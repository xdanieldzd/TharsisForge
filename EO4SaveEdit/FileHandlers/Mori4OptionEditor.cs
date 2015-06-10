using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;

namespace EO4SaveEdit.FileHandlers
{
    public partial class Mori4OptionEditor : UserControl
    {
        Mori4Option optionData;

        public Mori4OptionEditor()
        {
            InitializeComponent();
        }

        public void Initialize(Mori4Option option)
        {
            this.optionData = option;

            if (this.optionData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            txtOption1.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option1, ((s, e) => { optionData.Option1 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption2.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option2, ((s, e) => { optionData.Option2 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption3.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option3, ((s, e) => { optionData.Option3 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption4.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option4, ((s, e) => { optionData.Option4 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption5.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option5, ((s, e) => { optionData.Option5 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption6.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option6, ((s, e) => { optionData.Option6 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption7.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option7, ((s, e) => { optionData.Option7 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtOption8.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Option8, ((s, e) => { optionData.Option8 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtUnknown1.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Unknown1, ((s, e) => { optionData.Unknown1 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
            txtUnknown2.CustomInit(CustomTextBoxDataType.NumberHexadecimal, optionData.Unknown2, ((s, e) => { optionData.Unknown2 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberHexadecimal); }));
        }

        private void btnFileHeader_Click(object sender, EventArgs e)
        {
            if (optionData == null) return;

            Editors.HeaderEditorDialog hed = new Editors.HeaderEditorDialog(optionData.FileHeader);
            hed.ShowDialog();
        }
    }
}
