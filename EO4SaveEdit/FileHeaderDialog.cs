using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public partial class FileHeaderDialog : Form
    {
        public FileHeader Header { get; private set; }

        public FileHeaderDialog(FileHeader header)
        {
            InitializeComponent();

            this.Header = header;

            txtSignature.CustomInit(CustomTextBoxDataType.String, this.Header.Signature, ((s, e) =>
            {
                this.Header.Signature = (s as TextBox).Text;
            }));
            txtUnknown1.CustomInit(CustomTextBoxDataType.NumberHexadecimal, this.Header.Unknown1, ((s, e) =>
            {
                this.Header.Unknown1 = (s as TextBox).GetNumber(typeof(uint), CustomTextBoxDataType.NumberHexadecimal);
            }));
            txtChunkSize.CustomInit(CustomTextBoxDataType.NumberHexadecimal, this.Header.ChunkSize, ((s, e) =>
            {
                this.Header.ChunkSize = (s as TextBox).GetNumber(typeof(uint), CustomTextBoxDataType.NumberHexadecimal);
            }));
            txtUnknown2.CustomInit(CustomTextBoxDataType.NumberHexadecimal, this.Header.Unknown2, ((s, e) =>
            {
                this.Header.Unknown2 = (s as TextBox).GetNumber(typeof(ushort), CustomTextBoxDataType.NumberHexadecimal);
            }));
            txtTimeYear.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Year, ((s, e) =>
            {
                this.Header.LastSavedTime.Year = (s as TextBox).GetNumber(typeof(ushort), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeUnknown1.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Unknown1, ((s, e) =>
            {
                this.Header.LastSavedTime.Unknown1 = (s as TextBox).GetNumber(typeof(ushort), CustomTextBoxDataType.NumberDecimal);
            }));
            txtTimeMonth.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Month, ((s, e) =>
            {
                this.Header.LastSavedTime.Month = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeDay.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Day, ((s, e) =>
            {
                this.Header.LastSavedTime.Day = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeUnknown2.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Unknown2, ((s, e) =>
            {
                this.Header.LastSavedTime.Unknown2 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
            }));
            txtTimeHour.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Hour, ((s, e) =>
            {
                this.Header.LastSavedTime.Hour = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeMinute.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Minute, ((s, e) =>
            {
                this.Header.LastSavedTime.Minute = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeSecond.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Second, ((s, e) =>
            {
                this.Header.LastSavedTime.Second = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
                UpdateReadableTime();
            }));
            txtTimeUnknown3.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Unknown3, ((s, e) =>
            {
                this.Header.LastSavedTime.Unknown3 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
            }));
            txtTimeUnknown4.CustomInit(CustomTextBoxDataType.NumberDecimal, this.Header.LastSavedTime.Unknown4, ((s, e) =>
            {
                this.Header.LastSavedTime.Unknown4 = (s as TextBox).GetNumber(typeof(byte), CustomTextBoxDataType.NumberDecimal);
            }));

            UpdateReadableTime();
        }

        private void UpdateReadableTime()
        {
            txtTimeReadable.Text = string.Format("{0}", this.Header.LastSavedTime.DateTime);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
