namespace EO4SaveEdit
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGameData = new System.Windows.Forms.TabPage();
            this.tpCharas = new System.Windows.Forms.TabPage();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.tpGuildCards = new System.Windows.Forms.TabPage();
            this.tpMaps = new System.Windows.Forms.TabPage();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.characterEditor1 = new EO4SaveEdit.Editors.CharacterEditor();
            this.gameDataEditor1 = new EO4SaveEdit.Editors.GameDataEditor();
            this.itemEditor1 = new EO4SaveEdit.Editors.ItemEditor();
            this.guildCardEditor1 = new EO4SaveEdit.Editors.GuildCardEditor();
            this.mapEditor1 = new EO4SaveEdit.Editors.MapEditor();
            this.optionEditor1 = new EO4SaveEdit.Editors.OptionEditor();
            this.tabControl1.SuspendLayout();
            this.tpGameData.SuspendLayout();
            this.tpCharas.SuspendLayout();
            this.tpItems.SuspendLayout();
            this.tpGuildCards.SuspendLayout();
            this.tpMaps.SuspendLayout();
            this.tpOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGameData);
            this.tabControl1.Controls.Add(this.tpCharas);
            this.tabControl1.Controls.Add(this.tpItems);
            this.tabControl1.Controls.Add(this.tpGuildCards);
            this.tabControl1.Controls.Add(this.tpMaps);
            this.tabControl1.Controls.Add(this.tpOptions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGameData
            // 
            this.tpGameData.Controls.Add(this.gameDataEditor1);
            this.tpGameData.Location = new System.Drawing.Point(4, 22);
            this.tpGameData.Name = "tpGameData";
            this.tpGameData.Padding = new System.Windows.Forms.Padding(3);
            this.tpGameData.Size = new System.Drawing.Size(856, 510);
            this.tpGameData.TabIndex = 5;
            this.tpGameData.Text = "Game Data";
            this.tpGameData.UseVisualStyleBackColor = true;
            // 
            // tpCharas
            // 
            this.tpCharas.Controls.Add(this.characterEditor1);
            this.tpCharas.Location = new System.Drawing.Point(4, 22);
            this.tpCharas.Name = "tpCharas";
            this.tpCharas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCharas.Size = new System.Drawing.Size(856, 510);
            this.tpCharas.TabIndex = 2;
            this.tpCharas.Text = "Characters";
            this.tpCharas.UseVisualStyleBackColor = true;
            // 
            // tpItems
            // 
            this.tpItems.Controls.Add(this.itemEditor1);
            this.tpItems.Location = new System.Drawing.Point(4, 22);
            this.tpItems.Name = "tpItems";
            this.tpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpItems.Size = new System.Drawing.Size(856, 510);
            this.tpItems.TabIndex = 4;
            this.tpItems.Text = "Items";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // tpGuildCards
            // 
            this.tpGuildCards.Controls.Add(this.guildCardEditor1);
            this.tpGuildCards.Location = new System.Drawing.Point(4, 22);
            this.tpGuildCards.Name = "tpGuildCards";
            this.tpGuildCards.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuildCards.Size = new System.Drawing.Size(856, 510);
            this.tpGuildCards.TabIndex = 3;
            this.tpGuildCards.Text = "Guild Cards";
            this.tpGuildCards.UseVisualStyleBackColor = true;
            // 
            // tpMaps
            // 
            this.tpMaps.Controls.Add(this.mapEditor1);
            this.tpMaps.Location = new System.Drawing.Point(4, 22);
            this.tpMaps.Name = "tpMaps";
            this.tpMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaps.Size = new System.Drawing.Size(856, 510);
            this.tpMaps.TabIndex = 1;
            this.tpMaps.Text = "Maps";
            this.tpMaps.UseVisualStyleBackColor = true;
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.tableLayoutPanel1);
            this.tpOptions.Location = new System.Drawing.Point(4, 22);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(856, 510);
            this.tpOptions.TabIndex = 0;
            this.tpOptions.Text = "Options";
            this.tpOptions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.optionEditor1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 504);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openFolderToolStripMenuItem.Text = "&Open Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(22, 17);
            this.tsslStatus.Text = "---";
            // 
            // characterEditor1
            // 
            this.characterEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterEditor1.Enabled = false;
            this.characterEditor1.Location = new System.Drawing.Point(3, 3);
            this.characterEditor1.Name = "characterEditor1";
            this.characterEditor1.Size = new System.Drawing.Size(850, 504);
            this.characterEditor1.TabIndex = 0;
            // 
            // gameDataEditor1
            // 
            this.gameDataEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameDataEditor1.Enabled = false;
            this.gameDataEditor1.Location = new System.Drawing.Point(3, 3);
            this.gameDataEditor1.Name = "gameDataEditor1";
            this.gameDataEditor1.Size = new System.Drawing.Size(850, 504);
            this.gameDataEditor1.TabIndex = 0;
            // 
            // itemEditor1
            // 
            this.itemEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemEditor1.Enabled = false;
            this.itemEditor1.Location = new System.Drawing.Point(3, 3);
            this.itemEditor1.Name = "itemEditor1";
            this.itemEditor1.Size = new System.Drawing.Size(850, 504);
            this.itemEditor1.TabIndex = 0;
            // 
            // guildCardEditor1
            // 
            this.guildCardEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guildCardEditor1.Enabled = false;
            this.guildCardEditor1.Location = new System.Drawing.Point(3, 3);
            this.guildCardEditor1.MinimumSize = new System.Drawing.Size(800, 500);
            this.guildCardEditor1.Name = "guildCardEditor1";
            this.guildCardEditor1.Size = new System.Drawing.Size(850, 504);
            this.guildCardEditor1.TabIndex = 0;
            // 
            // mapEditor1
            // 
            this.mapEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapEditor1.Enabled = false;
            this.mapEditor1.Location = new System.Drawing.Point(3, 3);
            this.mapEditor1.Name = "mapEditor1";
            this.mapEditor1.Size = new System.Drawing.Size(850, 504);
            this.mapEditor1.TabIndex = 0;
            // 
            // optionEditor1
            // 
            this.optionEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionEditor1.Enabled = false;
            this.optionEditor1.Location = new System.Drawing.Point(3, 3);
            this.optionEditor1.Name = "optionEditor1";
            this.optionEditor1.Size = new System.Drawing.Size(844, 498);
            this.optionEditor1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(880, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tpGameData.ResumeLayout(false);
            this.tpCharas.ResumeLayout(false);
            this.tpItems.ResumeLayout(false);
            this.tpGuildCards.ResumeLayout(false);
            this.tpMaps.ResumeLayout(false);
            this.tpOptions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tpMaps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Editors.MapEditor mapEditor1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tpCharas;
        private Editors.CharacterEditor characterEditor1;
        private System.Windows.Forms.TabPage tpGuildCards;
        private Editors.GuildCardEditor guildCardEditor1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.TabPage tpItems;
        private Editors.ItemEditor itemEditor1;
        private System.Windows.Forms.TabPage tpGameData;
        private Editors.GameDataEditor gameDataEditor1;
        private Editors.OptionEditor optionEditor1;

    }
}

