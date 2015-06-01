namespace EO4SaveEdit.Editors
{
    partial class SkillEditorDialog
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSkillsMainClass = new System.Windows.Forms.GroupBox();
            this.dgvSkillsMainClass = new System.Windows.Forms.DataGridView();
            this.SkillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSkillsSubclass = new System.Windows.Forms.GroupBox();
            this.dgvSkillsSubclass = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSkillsMainClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillsMainClass)).BeginInit();
            this.gbSkillsSubclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillsSubclass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(507, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbSkillsMainClass
            // 
            this.gbSkillsMainClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSkillsMainClass.Controls.Add(this.dgvSkillsMainClass);
            this.gbSkillsMainClass.Location = new System.Drawing.Point(12, 12);
            this.gbSkillsMainClass.Name = "gbSkillsMainClass";
            this.gbSkillsMainClass.Padding = new System.Windows.Forms.Padding(6);
            this.gbSkillsMainClass.Size = new System.Drawing.Size(280, 419);
            this.gbSkillsMainClass.TabIndex = 0;
            this.gbSkillsMainClass.TabStop = false;
            this.gbSkillsMainClass.Text = "Main Class";
            // 
            // dgvSkillsMainClass
            // 
            this.dgvSkillsMainClass.AllowUserToAddRows = false;
            this.dgvSkillsMainClass.AllowUserToDeleteRows = false;
            this.dgvSkillsMainClass.AllowUserToResizeColumns = false;
            this.dgvSkillsMainClass.AllowUserToResizeRows = false;
            this.dgvSkillsMainClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSkillsMainClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkillsMainClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillColumn,
            this.LevelColumn,
            this.MaxLevelColumn});
            this.dgvSkillsMainClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkillsMainClass.Location = new System.Drawing.Point(6, 19);
            this.dgvSkillsMainClass.MultiSelect = false;
            this.dgvSkillsMainClass.Name = "dgvSkillsMainClass";
            this.dgvSkillsMainClass.RowHeadersVisible = false;
            this.dgvSkillsMainClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkillsMainClass.Size = new System.Drawing.Size(268, 394);
            this.dgvSkillsMainClass.TabIndex = 0;
            this.dgvSkillsMainClass.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSkillsMainClass_CellValidating);
            this.dgvSkillsMainClass.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkillsMainClass_CellValueChanged);
            // 
            // SkillColumn
            // 
            this.SkillColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SkillColumn.DataPropertyName = "Skill";
            this.SkillColumn.HeaderText = "Skill";
            this.SkillColumn.Name = "SkillColumn";
            this.SkillColumn.ReadOnly = true;
            this.SkillColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LevelColumn
            // 
            this.LevelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LevelColumn.DataPropertyName = "Level";
            this.LevelColumn.HeaderText = "Level";
            this.LevelColumn.Name = "LevelColumn";
            this.LevelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LevelColumn.Width = 40;
            // 
            // MaxLevelColumn
            // 
            this.MaxLevelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaxLevelColumn.DataPropertyName = "MaxLevel";
            this.MaxLevelColumn.HeaderText = "Max";
            this.MaxLevelColumn.Name = "MaxLevelColumn";
            this.MaxLevelColumn.ReadOnly = true;
            this.MaxLevelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaxLevelColumn.Width = 40;
            // 
            // gbSkillsSubclass
            // 
            this.gbSkillsSubclass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSkillsSubclass.Controls.Add(this.dgvSkillsSubclass);
            this.gbSkillsSubclass.Location = new System.Drawing.Point(302, 12);
            this.gbSkillsSubclass.Name = "gbSkillsSubclass";
            this.gbSkillsSubclass.Padding = new System.Windows.Forms.Padding(6);
            this.gbSkillsSubclass.Size = new System.Drawing.Size(280, 419);
            this.gbSkillsSubclass.TabIndex = 1;
            this.gbSkillsSubclass.TabStop = false;
            this.gbSkillsSubclass.Text = "Subclass";
            // 
            // dgvSkillsSubclass
            // 
            this.dgvSkillsSubclass.AllowUserToAddRows = false;
            this.dgvSkillsSubclass.AllowUserToDeleteRows = false;
            this.dgvSkillsSubclass.AllowUserToResizeColumns = false;
            this.dgvSkillsSubclass.AllowUserToResizeRows = false;
            this.dgvSkillsSubclass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSkillsSubclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkillsSubclass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSkillsSubclass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkillsSubclass.Location = new System.Drawing.Point(6, 19);
            this.dgvSkillsSubclass.MultiSelect = false;
            this.dgvSkillsSubclass.Name = "dgvSkillsSubclass";
            this.dgvSkillsSubclass.RowHeadersVisible = false;
            this.dgvSkillsSubclass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkillsSubclass.Size = new System.Drawing.Size(268, 394);
            this.dgvSkillsSubclass.TabIndex = 0;
            this.dgvSkillsSubclass.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSkillsSubclass_CellValidating);
            this.dgvSkillsSubclass.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkillsSubclass_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Skill";
            this.dataGridViewTextBoxColumn1.HeaderText = "Skill";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn2.HeaderText = "Level";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaxLevel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Max";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // SkillEditorDialog
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.gbSkillsSubclass);
            this.Controls.Add(this.gbSkillsMainClass);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkillEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skill Editor";
            this.gbSkillsMainClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillsMainClass)).EndInit();
            this.gbSkillsSubclass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillsSubclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbSkillsMainClass;
        private System.Windows.Forms.DataGridView dgvSkillsMainClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxLevelColumn;
        private System.Windows.Forms.GroupBox gbSkillsSubclass;
        private System.Windows.Forms.DataGridView dgvSkillsSubclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}