using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class SkillEditorDialog : Form
    {
        Class mainClass, subClass;
        byte[] mainSkillLevels, subSkillLevels;

        public SkillEditorDialog(Class mainClass, byte[] mainSkillLevels, Class subClass, byte[] subSkillLevels)
        {
            InitializeComponent();

            this.mainSkillLevels = mainSkillLevels;
            this.subSkillLevels = subSkillLevels;
            this.mainClass = mainClass;
            this.subClass = subClass;

            gbSkillsMainClass.Text = string.Format("Main Class ({0})", mainClass);
            InitializeSkillDataGrid(dgvSkillsMainClass, mainClass, mainSkillLevels);

            dgvSkillsMainClass.Columns[0].DefaultCellStyle.ForeColor = SystemColors.ControlDark;
            dgvSkillsMainClass.Columns[2].DefaultCellStyle.ForeColor = SystemColors.ControlDark;

            if (subClass != Class.None)
            {
                gbSkillsSubclass.Text = string.Format("Subclass ({0})", subClass);
                InitializeSkillDataGrid(dgvSkillsSubclass, subClass, subSkillLevels);

                dgvSkillsSubclass.Columns[0].DefaultCellStyle.ForeColor = SystemColors.ControlDark;
                dgvSkillsSubclass.Columns[2].DefaultCellStyle.ForeColor = SystemColors.ControlDark;
            }
        }

        private void InitializeSkillDataGrid(DataGridView dgv, Class charaClass, byte[] skillLevels)
        {
            dgv.AutoGenerateColumns = false;

            if (charaClass != Class.None)
            {
                DataTable table = new DataTable("SkillTable");
                table.Columns.Add("Skill", typeof(string));
                table.Columns.Add("Level", typeof(byte));
                table.Columns.Add("MaxLevel", typeof(byte));
                for (int i = 0; i < XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass].Length; i++)
                {
                    DataRow row = table.NewRow();
                    row["Skill"] = XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass][i].Item2;
                    row["Level"] = skillLevels[i];
                    row["MaxLevel"] = XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass][i].Item1;
                    table.Rows.Add(row);
                }
                table.AcceptChanges();
                dgv.DataSource = table;
            }
            else
                dgv.DataSource = null;
        }

        private void dgvSkillsMainClass_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
                ValidateSkillLevel((sender as DataGridView), e, mainClass);
        }

        private void dgvSkillsMainClass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < mainSkillLevels.Length && e.ColumnIndex == 1)
                mainSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvSkillsMainClass_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgvSkillsSubclass_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < subSkillLevels.Length && e.ColumnIndex == 1)
                ValidateSkillLevel((sender as DataGridView), e, subClass);
        }

        private void dgvSkillsSubclass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < subSkillLevels.Length && e.ColumnIndex == 1)
                subSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvSkillsSubclass_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void ValidateSkillLevel(DataGridView dataGridView, DataGridViewCellValidatingEventArgs e, Class charaClass)
        {
            bool cancel = false;
            string errorText = string.Empty;

            if (e.RowIndex < 0 || e.RowIndex >= mainSkillLevels.Length)
            {
                cancel = true;
                errorText = "Invalid skill selected.";
            }

            byte newLevel;
            if ((string)e.FormattedValue == string.Empty || !byte.TryParse((string)e.FormattedValue, out newLevel) || newLevel > XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass][e.RowIndex].Item1)
            {
                cancel = true;
                errorText = string.Format("Invalid skill level specified. The maximum level for {0} is {1}.",
                    XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass][e.RowIndex].Item2, XmlHelper.SkillData[SaveDataHandler.SaveLanguage][charaClass][e.RowIndex].Item1);
            }

            e.Cancel = cancel;
            dataGridView.Rows[e.RowIndex].ErrorText = errorText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
