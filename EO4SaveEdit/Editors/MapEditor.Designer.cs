namespace EO4SaveEdit.Editors
{
    partial class MapEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.chkZoomedMap = new System.Windows.Forms.CheckBox();
            this.pgMapPlaceable = new System.Windows.Forms.PropertyGrid();
            this.tsPropertyGridExtension = new System.Windows.Forms.ToolStrip();
            this.tsbResetProperty = new System.Windows.Forms.ToolStripButton();
            this.lbMapPlaceables = new EO4SaveEdit.Controls.ListBoxEx();
            this.pnlRender = new EO4SaveEdit.Controls.PanelEx();
            this.pbRender = new System.Windows.Forms.PictureBox();
            this.tsPropertyGridExtension.SuspendLayout();
            this.pnlRender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaps
            // 
            this.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(4, 5);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(160, 21);
            this.cmbMaps.TabIndex = 0;
            this.cmbMaps.SelectedIndexChanged += new System.EventHandler(this.cmbMaps_SelectedIndexChanged);
            // 
            // chkZoomedMap
            // 
            this.chkZoomedMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkZoomedMap.AutoSize = true;
            this.chkZoomedMap.Location = new System.Drawing.Point(802, 7);
            this.chkZoomedMap.Name = "chkZoomedMap";
            this.chkZoomedMap.Size = new System.Drawing.Size(95, 17);
            this.chkZoomedMap.TabIndex = 1;
            this.chkZoomedMap.Text = "Show Zoomed";
            this.chkZoomedMap.UseVisualStyleBackColor = true;
            this.chkZoomedMap.CheckedChanged += new System.EventHandler(this.chkZoomedMap_CheckedChanged);
            // 
            // pgMapPlaceable
            // 
            this.pgMapPlaceable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgMapPlaceable.Location = new System.Drawing.Point(677, 32);
            this.pgMapPlaceable.Name = "pgMapPlaceable";
            this.pgMapPlaceable.Size = new System.Drawing.Size(220, 465);
            this.pgMapPlaceable.TabIndex = 4;
            this.pgMapPlaceable.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgMapPlaceable_PropertyValueChanged);
            this.pgMapPlaceable.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.pgMapPlaceable_SelectedGridItemChanged);
            // 
            // tsPropertyGridExtension
            // 
            this.tsPropertyGridExtension.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPropertyGridExtension.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbResetProperty});
            this.tsPropertyGridExtension.Location = new System.Drawing.Point(677, 3);
            this.tsPropertyGridExtension.Name = "tsPropertyGridExtension";
            this.tsPropertyGridExtension.Size = new System.Drawing.Size(35, 25);
            this.tsPropertyGridExtension.TabIndex = 1;
            this.tsPropertyGridExtension.Visible = false;
            // 
            // tsbResetProperty
            // 
            this.tsbResetProperty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetProperty.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetProperty.Image")));
            this.tsbResetProperty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetProperty.Name = "tsbResetProperty";
            this.tsbResetProperty.Size = new System.Drawing.Size(23, 22);
            this.tsbResetProperty.Text = "Reset Property";
            this.tsbResetProperty.Click += new System.EventHandler(this.tsbResetProperty_Click);
            // 
            // lbMapPlaceables
            // 
            this.lbMapPlaceables.AlternateBackColorOnDraw = true;
            this.lbMapPlaceables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMapPlaceables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMapPlaceables.FormattingEnabled = true;
            this.lbMapPlaceables.IntegralHeight = false;
            this.lbMapPlaceables.Location = new System.Drawing.Point(4, 32);
            this.lbMapPlaceables.Name = "lbMapPlaceables";
            this.lbMapPlaceables.Size = new System.Drawing.Size(160, 465);
            this.lbMapPlaceables.TabIndex = 2;
            this.lbMapPlaceables.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbMapPlaceables_Format);
            this.lbMapPlaceables.SelectedValueChanged += new System.EventHandler(this.lbMapPlaceables_SelectedValueChanged);
            // 
            // pnlRender
            // 
            this.pnlRender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRender.AutoScroll = true;
            this.pnlRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRender.Controls.Add(this.pbRender);
            this.pnlRender.Location = new System.Drawing.Point(170, 32);
            this.pnlRender.Name = "pnlRender";
            this.pnlRender.Size = new System.Drawing.Size(501, 465);
            this.pnlRender.TabIndex = 3;
            // 
            // pbRender
            // 
            this.pbRender.Location = new System.Drawing.Point(0, 0);
            this.pbRender.Name = "pbRender";
            this.pbRender.Size = new System.Drawing.Size(100, 100);
            this.pbRender.TabIndex = 0;
            this.pbRender.TabStop = false;
            this.pbRender.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRender_Paint);
            this.pbRender.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRender_MouseDown);
            this.pbRender.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRender_MouseMove);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsPropertyGridExtension);
            this.Controls.Add(this.pgMapPlaceable);
            this.Controls.Add(this.chkZoomedMap);
            this.Controls.Add(this.lbMapPlaceables);
            this.Controls.Add(this.pnlRender);
            this.Controls.Add(this.cmbMaps);
            this.Name = "MapEditor";
            this.Size = new System.Drawing.Size(900, 500);
            this.tsPropertyGridExtension.ResumeLayout(false);
            this.tsPropertyGridExtension.PerformLayout();
            this.pnlRender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EO4SaveEdit.Controls.PanelEx pnlRender;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.PictureBox pbRender;
        private Controls.ListBoxEx lbMapPlaceables;
        private System.Windows.Forms.CheckBox chkZoomedMap;
        private System.Windows.Forms.PropertyGrid pgMapPlaceable;
        private System.Windows.Forms.ToolStrip tsPropertyGridExtension;
        private System.Windows.Forms.ToolStripButton tsbResetProperty;
    }
}
