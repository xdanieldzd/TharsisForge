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
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.btnFileHeader = new System.Windows.Forms.Button();
            this.lbMapPlaceables = new EO4SaveEdit.Controls.ListBoxEx();
            this.pnlRender = new EO4SaveEdit.Controls.PanelEx();
            this.pbRender = new System.Windows.Forms.PictureBox();
            this.pnlRender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaps
            // 
            this.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(3, 5);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(250, 21);
            this.cmbMaps.TabIndex = 1;
            this.cmbMaps.SelectedIndexChanged += new System.EventHandler(this.cmbMaps_SelectedIndexChanged);
            // 
            // btnFileHeader
            // 
            this.btnFileHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileHeader.Location = new System.Drawing.Point(697, 3);
            this.btnFileHeader.Name = "btnFileHeader";
            this.btnFileHeader.Size = new System.Drawing.Size(100, 23);
            this.btnFileHeader.TabIndex = 2;
            this.btnFileHeader.Text = "File Header...";
            this.btnFileHeader.UseVisualStyleBackColor = true;
            this.btnFileHeader.Click += new System.EventHandler(this.btnFileHeader_Click);
            // 
            // lbMapPlaceables
            // 
            this.lbMapPlaceables.AlternateBackColorOnDraw = true;
            this.lbMapPlaceables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMapPlaceables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbMapPlaceables.FormattingEnabled = true;
            this.lbMapPlaceables.IntegralHeight = false;
            this.lbMapPlaceables.Location = new System.Drawing.Point(3, 32);
            this.lbMapPlaceables.Name = "lbMapPlaceables";
            this.lbMapPlaceables.Size = new System.Drawing.Size(250, 365);
            this.lbMapPlaceables.TabIndex = 3;
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
            this.pnlRender.Location = new System.Drawing.Point(259, 32);
            this.pnlRender.Name = "pnlRender";
            this.pnlRender.Size = new System.Drawing.Size(538, 365);
            this.pnlRender.TabIndex = 0;
            // 
            // pbRender
            // 
            this.pbRender.Location = new System.Drawing.Point(0, 0);
            this.pbRender.Name = "pbRender";
            this.pbRender.Size = new System.Drawing.Size(100, 100);
            this.pbRender.TabIndex = 0;
            this.pbRender.TabStop = false;
            this.pbRender.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRender_Paint);
            this.pbRender.MouseLeave += new System.EventHandler(this.pbRender_MouseLeave);
            this.pbRender.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRender_MouseMove);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMapPlaceables);
            this.Controls.Add(this.pnlRender);
            this.Controls.Add(this.btnFileHeader);
            this.Controls.Add(this.cmbMaps);
            this.Name = "MapEditor";
            this.Size = new System.Drawing.Size(800, 400);
            this.pnlRender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EO4SaveEdit.Controls.PanelEx pnlRender;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.Button btnFileHeader;
        private System.Windows.Forms.PictureBox pbRender;
        private Controls.ListBoxEx lbMapPlaceables;
    }
}
