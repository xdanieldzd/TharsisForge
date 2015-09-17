using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class ItemEditor : UserControl
    {
        Mori4Game gameData;

        public ItemEditor()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
        }

        public void Initialize(Mori4Game game)
        {
            this.gameData = game;

            if (this.gameData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            InitializeDataGrid(dgvInventory, gameData.InventoryItems, null);
            InitializeDataGrid(dgvKeyItems, gameData.KeyItems, null);
            InitializeDataGrid(dgvStorage, gameData.StorageItems, gameData.StorageItemAmounts);
        }

        private void InitializeDataGrid(DataGridView dgv, Item[] items, byte[] amounts)
        {
            dgv.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn itemColumn = (dgv.Columns[0] as DataGridViewComboBoxColumn);
            itemColumn.DataSource = new BindingSource(XmlHelper.ItemNames, null);
            itemColumn.DisplayMember = "Value";
            itemColumn.ValueMember = "Key";

            DataTable table = new DataTable("SkillTable");
            table.Columns.Add("Item", typeof(ushort));
            if (amounts != null) table.Columns.Add("Amount", typeof(byte));
            for (int i = 0; i < items.Length; i++)
            {
                DataRow row = table.NewRow();
                row["Item"] = items[i].ItemID;
                if (amounts != null) row["Amount"] = amounts[i];
                table.Rows.Add(row);
            }
            table.AcceptChanges();
            dgv.DataSource = table;
        }

        private void dgvStorage_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);

            if (e.ColumnIndex == 1)
            {
                byte newValue = (byte)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                e.Cancel = !byte.TryParse((string)e.FormattedValue, out newValue);

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()) || e.Cancel)
                {
                    dgv.Rows[e.RowIndex].ErrorText = "Invalid amount specified.";
                    e.Cancel = true;
                }
                else
                    dgv.Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }
    }
}
