using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class SkillEditorDialog : Form
    {
        public byte[] MainSkillLevels { get; private set; }
        public byte[] SubSkillLevels { get; private set; }

        Class mainClass, subClass;

        public SkillEditorDialog(Class mainClass, byte[] mainSkillLevels, Class subClass, byte[] subSkillLevels)
        {
            InitializeComponent();

            this.MainSkillLevels = mainSkillLevels;
            this.SubSkillLevels = subSkillLevels;
            this.mainClass = mainClass;
            this.subClass = subClass;

            gbSkillsMainClass.Text = string.Format("Main Class ({0})", mainClass);
            InitializeSkillDataGrid(dgvSkillsMainClass, mainClass, MainSkillLevels);

            if (subClass != Class.None)
            {
                gbSkillsSubclass.Text = string.Format("Subclass ({0})", subClass);
                InitializeSkillDataGrid(dgvSkillsSubclass, subClass, SubSkillLevels);
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
                for (int i = 0; i < XmlHelper.SkillData[charaClass].Length; i++)
                {
                    DataRow row = table.NewRow();
                    row["Skill"] = XmlHelper.SkillData[charaClass][i].Item2;
                    row["Level"] = skillLevels[i];
                    row["MaxLevel"] = XmlHelper.SkillData[charaClass][i].Item1;
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
            DataGridView dgv = (sender as DataGridView);
            if (e.RowIndex >= 0 && e.RowIndex < MainSkillLevels.Length && e.ColumnIndex == 1)
                e.Cancel = ((string)e.FormattedValue == string.Empty || IsSkillLevelInvalid(e.RowIndex, mainClass, byte.Parse((string)e.FormattedValue)));
        }

        private void dgvSkillsMainClass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MainSkillLevels.Length && e.ColumnIndex == 1)
                MainSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvSkillsSubclass_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);
            if (e.RowIndex >= 0 && e.RowIndex < SubSkillLevels.Length && e.ColumnIndex == 1)
                e.Cancel = ((string)e.FormattedValue == string.Empty || IsSkillLevelInvalid(e.RowIndex, subClass, byte.Parse((string)e.FormattedValue)));
        }

        private void dgvSkillsSubclass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SubSkillLevels.Length && e.ColumnIndex == 1)
                SubSkillLevels[e.RowIndex] = (byte)(sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private bool IsSkillLevelInvalid(int skillIdx, Class charaClass, byte newLevel)
        {
            if (newLevel > XmlHelper.SkillData[charaClass][skillIdx].Item1)
            {
                MessageBox.Show(
                    string.Format("Invalid skill level specified. The maximum level for {0} is {1}.", XmlHelper.SkillData[charaClass][skillIdx].Item2, XmlHelper.SkillData[charaClass][skillIdx].Item1), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
