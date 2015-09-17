namespace EO4SaveEdit.Editors
{
    partial class ItemEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStorage = new EO4SaveEdit.DataGridViewEx();
            this.Item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKeyItems = new EO4SaveEdit.DataGridViewEx();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvInventory = new EO4SaveEdit.DataGridViewEx();
            this.ItemColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.AllowUserToResizeColumns = false;
            this.dgvStorage.AllowUserToResizeRows = false;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Amount});
            this.dgvStorage.Location = new System.Drawing.Point(495, 3);
            this.dgvStorage.MultiSelect = false;
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStorage.ShowCellToolTips = false;
            this.dgvStorage.Size = new System.Drawing.Size(240, 394);
            this.dgvStorage.TabIndex = 3;
            this.dgvStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellClick);
            this.dgvStorage.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStorage_CellValidating);
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 50;
            // 
            // dgvKeyItems
            // 
            this.dgvKeyItems.AllowUserToAddRows = false;
            this.dgvKeyItems.AllowUserToDeleteRows = false;
            this.dgvKeyItems.AllowUserToResizeColumns = false;
            this.dgvKeyItems.AllowUserToResizeRows = false;
            this.dgvKeyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKeyItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1});
            this.dgvKeyItems.Location = new System.Drawing.Point(249, 3);
            this.dgvKeyItems.MultiSelect = false;
            this.dgvKeyItems.Name = "dgvKeyItems";
            this.dgvKeyItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKeyItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKeyItems.ShowCellToolTips = false;
            this.dgvKeyItems.Size = new System.Drawing.Size(240, 394);
            this.dgvKeyItems.TabIndex = 2;
            this.dgvKeyItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyItems_CellClick);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewComboBoxColumn1.HeaderText = "Item";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemColumn});
            this.dgvInventory.Location = new System.Drawing.Point(3, 3);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInventory.ShowCellToolTips = false;
            this.dgvInventory.Size = new System.Drawing.Size(240, 394);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // ItemColumn
            // 
            this.ItemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemColumn.DataPropertyName = "Item";
            this.ItemColumn.HeaderText = "Item";
            this.ItemColumn.Name = "ItemColumn";
            this.ItemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvStorage);
            this.Controls.Add(this.dgvKeyItems);
            this.Controls.Add(this.dgvInventory);
            this.Name = "ItemEditor";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewEx dgvInventory;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemColumn;
        private DataGridViewEx dgvKeyItems;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewEx dgvStorage;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
