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

            public bool IsEquipment { get { return (item.ItemID != 0 && XmlHelper.EquipmentNames.ContainsKey(item.ItemID)); } }
            public Item ItemInstance { get { return item; } }

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

            if (this.Enabled = (this.gameData != null))
            {
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
        }

        private void InitializeDataGrid(DataGridView dgv, ItemAdapter[] itemAdapters)
        {
            dgv.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn itemColumn = new DataGridViewComboBoxColumn();
            itemColumn.Name = "Item";
            itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            itemColumn.HeaderText = "Item";
            itemColumn.DisplayMember = "Value";
            itemColumn.ValueMember = "Key";
            itemColumn.DataPropertyName = "ItemID";
            itemColumn.DataSource = new BindingSource(XmlHelper.AllItemNames, null);

            DataGridViewButtonColumn effectColumn = new DataGridViewButtonColumn();
            effectColumn.Name = "Effect";
            effectColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            effectColumn.HeaderText = string.Empty;
            effectColumn.Width = 30;
            effectColumn.Text = "...";
            effectColumn.UseColumnTextForButtonValue = true;

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountColumn.HeaderText = "Amount";
            amountColumn.Width = 50;
            amountColumn.DataPropertyName = "Amount";

            if (dgv != dgvStorage) amountColumn.Visible = false;
            if (dgv == dgvKeyItems) effectColumn.Visible = false;

            dgv.Columns.Clear();
            dgv.Columns.Add(itemColumn);
            dgv.Columns.Add(effectColumn);
            dgv.Columns.Add(amountColumn);

            BindingSource bindingSource = new BindingSource(itemAdapters, null);
            dgv.DataSource = bindingSource;
        }

        private void dgvStorage_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);

            if (e.ColumnIndex == dgv.Columns["Amount"].Index)
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

        private void HandleCellClick(DataGridView dgv, int column, int row)
        {
            if (column == -1 || row == -1) return;

            if (column == dgv.Columns["Item"].Index)
            {
                dgv.BeginEdit(true);
                ((ComboBox)dgv.EditingControl).DroppedDown = true;
            }
            else if (column == dgv.Columns["Effect"].Index)
            {
                ItemAdapter itemAdapter = ((dgv.DataSource as BindingSource).DataSource as ItemAdapter[])[row];
                if (itemAdapter.IsEquipment)
                {
                    EffectEditorDialog eed = new EffectEditorDialog(itemAdapter.ItemInstance);
                    eed.ShowDialog();
                }
            }
        }

        private void HandleCellPainting(DataGridView dgv, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == dgv.Columns["Effect"].Index)
            {
                ItemAdapter itemAdapter = ((dgv.DataSource as BindingSource).DataSource as ItemAdapter[])[e.RowIndex];
                if (!itemAdapter.IsEquipment)
                {
                    // Text maybe 1px off, but I don't care
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("...", dgv.Font, SystemBrushes.GrayText, e.CellBounds, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    e.Handled = true;
                }
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }

        private void dgvKeyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }

        private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick((sender as DataGridView), e.ColumnIndex, e.RowIndex);
        }

        private void dgvInventory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            HandleCellPainting((sender as DataGridView), e);
        }

        private void dgvKeyItems_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            HandleCellPainting((sender as DataGridView), e);
        }

        private void dgvStorage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            HandleCellPainting((sender as DataGridView), e);
        }
    }
}
