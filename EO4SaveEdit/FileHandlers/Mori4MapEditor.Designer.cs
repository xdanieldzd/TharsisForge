namespace EO4SaveEdit.FileHandlers
{
    partial class Mori4MapEditor
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
            this.pnlRender = new EO4SaveEdit.Controls.PanelEx();
            this.pbRender = new System.Windows.Forms.PictureBox();
            this.pnlRender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaps
            // 
            this.cmbMaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(0, 0);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(600, 21);
            this.cmbMaps.TabIndex = 1;
            this.cmbMaps.SelectedIndexChanged += new System.EventHandler(this.cmbMaps_SelectedIndexChanged);
            // 
            // btnFileHeader
            // 
            this.btnFileHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFileHeader.Location = new System.Drawing.Point(0, 477);
            this.btnFileHeader.Name = "btnFileHeader";
            this.btnFileHeader.Size = new System.Drawing.Size(600, 23);
            this.btnFileHeader.TabIndex = 2;
            this.btnFileHeader.Text = "File Header...";
            this.btnFileHeader.UseVisualStyleBackColor = true;
            this.btnFileHeader.Click += new System.EventHandler(this.btnFileHeader_Click);
            // 
            // pnlRender
            // 
            this.pnlRender.AutoScroll = true;
            this.pnlRender.Controls.Add(this.pbRender);
            this.pnlRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRender.Location = new System.Drawing.Point(0, 21);
            this.pnlRender.Name = "pnlRender";
            this.pnlRender.Size = new System.Drawing.Size(600, 456);
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
            // Mori4MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRender);
            this.Controls.Add(this.btnFileHeader);
            this.Controls.Add(this.cmbMaps);
            this.Name = "Mori4MapEditor";
            this.Size = new System.Drawing.Size(600, 500);
            this.pnlRender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EO4SaveEdit.Controls.PanelEx pnlRender;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.Button btnFileHeader;
        private System.Windows.Forms.PictureBox pbRender;
    }
}
