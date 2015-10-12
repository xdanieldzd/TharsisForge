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
            this.gbOnHand = new System.Windows.Forms.GroupBox();
            this.gbKeyItems = new System.Windows.Forms.GroupBox();
            this.gbStorage = new System.Windows.Forms.GroupBox();
            this.tlpItems = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInventory = new EO4SaveEdit.Controls.DataGridViewEx();
            this.dgvStorage = new EO4SaveEdit.Controls.DataGridViewEx();
            this.dgvKeyItems = new EO4SaveEdit.Controls.DataGridViewEx();
            this.gbOnHand.SuspendLayout();
            this.gbKeyItems.SuspendLayout();
            this.gbStorage.SuspendLayout();
            this.tlpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOnHand
            // 
            this.gbOnHand.Controls.Add(this.dgvInventory);
            this.gbOnHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOnHand.Location = new System.Drawing.Point(3, 3);
            this.gbOnHand.Name = "gbOnHand";
            this.gbOnHand.Size = new System.Drawing.Size(194, 294);
            this.gbOnHand.TabIndex = 4;
            this.gbOnHand.TabStop = false;
            this.gbOnHand.Text = "On Hand";
            // 
            // gbKeyItems
            // 
            this.gbKeyItems.Controls.Add(this.dgvKeyItems);
            this.gbKeyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKeyItems.Location = new System.Drawing.Point(203, 3);
            this.gbKeyItems.Name = "gbKeyItems";
            this.gbKeyItems.Size = new System.Drawing.Size(194, 294);
            this.gbKeyItems.TabIndex = 5;
            this.gbKeyItems.TabStop = false;
            this.gbKeyItems.Text = "Key Items";
            // 
            // gbStorage
            // 
            this.gbStorage.Controls.Add(this.dgvStorage);
            this.gbStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStorage.Location = new System.Drawing.Point(403, 3);
            this.gbStorage.Name = "gbStorage";
            this.gbStorage.Size = new System.Drawing.Size(194, 294);
            this.gbStorage.TabIndex = 6;
            this.gbStorage.TabStop = false;
            this.gbStorage.Text = "Storage";
            // 
            // tlpItems
            // 
            this.tlpItems.ColumnCount = 3;
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpItems.Controls.Add(this.gbOnHand, 0, 0);
            this.tlpItems.Controls.Add(this.gbStorage, 2, 0);
            this.tlpItems.Controls.Add(this.gbKeyItems, 1, 0);
            this.tlpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItems.Location = new System.Drawing.Point(0, 0);
            this.tlpItems.Name = "tlpItems";
            this.tlpItems.RowCount = 1;
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItems.Size = new System.Drawing.Size(600, 300);
            this.tlpItems.TabIndex = 7;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventory.Location = new System.Drawing.Point(6, 19);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInventory.ShowCellToolTips = false;
            this.dgvInventory.Size = new System.Drawing.Size(182, 269);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            this.dgvInventory.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvInventory_CellPainting);
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.AllowUserToResizeColumns = false;
            this.dgvStorage.AllowUserToResizeRows = false;
            this.dgvStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStorage.Location = new System.Drawing.Point(6, 19);
            this.dgvStorage.MultiSelect = false;
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStorage.ShowCellToolTips = false;
            this.dgvStorage.Size = new System.Drawing.Size(182, 269);
            this.dgvStorage.TabIndex = 3;
            this.dgvStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellClick);
            this.dgvStorage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvStorage_CellPainting);
            this.dgvStorage.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStorage_CellValidating);
            // 
            // dgvKeyItems
            // 
            this.dgvKeyItems.AllowUserToAddRows = false;
            this.dgvKeyItems.AllowUserToDeleteRows = false;
            this.dgvKeyItems.AllowUserToResizeColumns = false;
            this.dgvKeyItems.AllowUserToResizeRows = false;
            this.dgvKeyItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKeyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKeyItems.Location = new System.Drawing.Point(6, 19);
            this.dgvKeyItems.MultiSelect = false;
            this.dgvKeyItems.Name = "dgvKeyItems";
            this.dgvKeyItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKeyItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKeyItems.ShowCellToolTips = false;
            this.dgvKeyItems.Size = new System.Drawing.Size(182, 269);
            this.dgvKeyItems.TabIndex = 2;
            this.dgvKeyItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyItems_CellClick);
            this.dgvKeyItems.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvKeyItems_CellPainting);
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpItems);
            this.Name = "ItemEditor";
            this.Size = new System.Drawing.Size(600, 300);
            this.gbOnHand.ResumeLayout(false);
            this.gbKeyItems.ResumeLayout(false);
            this.gbStorage.ResumeLayout(false);
            this.tlpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EO4SaveEdit.Controls.DataGridViewEx dgvInventory;
        private EO4SaveEdit.Controls.DataGridViewEx dgvKeyItems;
        private EO4SaveEdit.Controls.DataGridViewEx dgvStorage;
        private System.Windows.Forms.GroupBox gbOnHand;
        private System.Windows.Forms.GroupBox gbKeyItems;
        private System.Windows.Forms.GroupBox gbStorage;
        private System.Windows.Forms.TableLayoutPanel tlpItems;
    }
}
