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
    public partial class ItemEditor : UserControl, IEditorControl
    {
        public class ItemAdapter
        {
            Item item;
            ItemAmount amount;

            public ushort ItemID
            {
                get { return item.ItemID; }
                set { item.ItemID = value; }
            }

            public byte Amount
            {
                get { return (amount != null ? amount.Amount : (byte)0); }
                set { if (amount != null) amount.Amount = value; }
            }

            public bool HasAmount { get { return (amount != null); } }

            public ItemAdapter(Item item, ItemAmount amount)
            {
                this.item = item;
                this.amount = amount;
            }
        }

        Mori4Game gameData;
        ItemAdapter[] inventoryItemAdapters, keyItemsItemAdapters, storageItemAdapters;

        public ItemEditor()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
        }

        public void Initialize(SaveDataHandler handler)
        {
            this.gameData = handler.GameDataFile;

            inventoryItemAdapters = new ItemAdapter[gameData.InventoryItems.Length];
            for (int i = 0; i < inventoryItemAdapters.Length; i++) inventoryItemAdapters[i] = new ItemAdapter(gameData.InventoryItems[i], null);

            keyItemsItemAdapters = new ItemAdapter[gameData.KeyItems.Length];
            for (int i = 0; i < keyItemsItemAdapters.Length; i++) keyItemsItemAdapters[i] = new ItemAdapter(gameData.KeyItems[i], null);

            storageItemAdapters = new ItemAdapter[gameData.StorageItems.Length];
            for (int i = 0; i < storageItemAdapters.Length; i++) storageItemAdapters[i] = new ItemAdapter(gameData.StorageItems[i], gameData.StorageItemAmounts[i]);

            InitializeDataGrid(dgvInventory, inventoryItemAdapters);
            InitializeDataGrid(dgvKeyItems, keyItemsItemAdapters);
            InitializeDataGrid(dgvStorage, storageItemAdapters);
        }

        private void InitializeDataGrid(DataGridView dgv, ItemAdapter[] itemAdapters)
        {
            dgv.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn itemColumn = new DataGridViewComboBoxColumn();
            itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            itemColumn.HeaderText = "Item";
            itemColumn.DisplayMember = "Value";
            itemColumn.ValueMember = "Key";
            itemColumn.DataPropertyName = "ItemID";
            itemColumn.DataSource = new BindingSource(XmlHelper.ItemNames, null);

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountColumn.HeaderText = "Amount";
            amountColumn.Width = 50;
            amountColumn.DataPropertyName = "Amount";

            if (!itemAdapters[0].HasAmount) amountColumn.Visible = false;

            dgv.Columns.Clear();
            dgv.Columns.Add(itemColumn);
            dgv.Columns.Add(amountColumn);

            BindingSource bindingSource = new BindingSource(itemAdapters, null);
            dgv.DataSource = bindingSource;
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

        private void OpenItemDropDown(DataGridView dgv, int column, int row)
        {
            if (column != -1 && (dgv.Columns[column] is DataGridViewComboBoxColumn) && (row != -1))
            {
                dgv.BeginEdit(true);
                ((ComboBox)dgv.EditingControl).DroppedDown = true;
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenItemDropDown((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }

        private void dgvKeyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenItemDropDown((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }

        private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenItemDropDown((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }
    }
}
