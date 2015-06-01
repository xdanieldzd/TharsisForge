namespace EO4SaveEdit.Editors
{
    partial class EffectEditorDialog
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
            this.gbEffects = new System.Windows.Forms.GroupBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtNumForgeSlots = new System.Windows.Forms.TextBox();
            this.lblNumForgeSlots = new System.Windows.Forms.Label();
            this.cmbForgeEffect1 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect2 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect3 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect4 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect5 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect6 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect7 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect8 = new System.Windows.Forms.ComboBox();
            this.gbEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(677, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbEffects
            // 
            this.gbEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEffects.Controls.Add(this.lblItemName);
            this.gbEffects.Controls.Add(this.lblItem);
            this.gbEffects.Controls.Add(this.txtNumForgeSlots);
            this.gbEffects.Controls.Add(this.lblNumForgeSlots);
            this.gbEffects.Controls.Add(this.cmbForgeEffect1);
            this.gbEffects.Controls.Add(this.cmbForgeEffect2);
            this.gbEffects.Controls.Add(this.cmbForgeEffect3);
            this.gbEffects.Controls.Add(this.cmbForgeEffect4);
            this.gbEffects.Controls.Add(this.cmbForgeEffect5);
            this.gbEffects.Controls.Add(this.cmbForgeEffect6);
            this.gbEffects.Controls.Add(this.cmbForgeEffect7);
            this.gbEffects.Controls.Add(this.cmbForgeEffect8);
            this.gbEffects.Location = new System.Drawing.Point(12, 12);
            this.gbEffects.Name = "gbEffects";
            this.gbEffects.Size = new System.Drawing.Size(740, 80);
            this.gbEffects.TabIndex = 9;
            this.gbEffects.TabStop = false;
            this.gbEffects.Text = "Effects";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(64, 22);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(16, 13);
            this.lblItemName.TabIndex = 39;
            this.lblItemName.Text = "---";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(6, 22);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 38;
            this.lblItem.Text = "Item:";
            // 
            // txtNumForgeSlots
            // 
            this.txtNumForgeSlots.Location = new System.Drawing.Point(699, 19);
            this.txtNumForgeSlots.MaxLength = 9;
            this.txtNumForgeSlots.Name = "txtNumForgeSlots";
            this.txtNumForgeSlots.ReadOnly = true;
            this.txtNumForgeSlots.Size = new System.Drawing.Size(30, 20);
            this.txtNumForgeSlots.TabIndex = 0;
            // 
            // lblNumForgeSlots
            // 
            this.lblNumForgeSlots.AutoSize = true;
            this.lblNumForgeSlots.Location = new System.Drawing.Point(610, 22);
            this.lblNumForgeSlots.Name = "lblNumForgeSlots";
            this.lblNumForgeSlots.Size = new System.Drawing.Size(83, 13);
            this.lblNumForgeSlots.TabIndex = 8;
            this.lblNumForgeSlots.Text = "Forgeable Slots:\r\n";
            // 
            // cmbForgeEffect1
            // 
            this.cmbForgeEffect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect1.DropDownWidth = 100;
            this.cmbForgeEffect1.Location = new System.Drawing.Point(9, 46);
            this.cmbForgeEffect1.Name = "cmbForgeEffect1";
            this.cmbForgeEffect1.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect1.TabIndex = 9;
            // 
            // cmbForgeEffect2
            // 
            this.cmbForgeEffect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect2.DropDownWidth = 100;
            this.cmbForgeEffect2.Location = new System.Drawing.Point(100, 46);
            this.cmbForgeEffect2.Name = "cmbForgeEffect2";
            this.cmbForgeEffect2.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect2.TabIndex = 10;
            // 
            // cmbForgeEffect3
            // 
            this.cmbForgeEffect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect3.DropDownWidth = 100;
            this.cmbForgeEffect3.Location = new System.Drawing.Point(189, 46);
            this.cmbForgeEffect3.Name = "cmbForgeEffect3";
            this.cmbForgeEffect3.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect3.TabIndex = 11;
            // 
            // cmbForgeEffect4
            // 
            this.cmbForgeEffect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect4.DropDownWidth = 100;
            this.cmbForgeEffect4.Location = new System.Drawing.Point(280, 46);
            this.cmbForgeEffect4.Name = "cmbForgeEffect4";
            this.cmbForgeEffect4.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect4.TabIndex = 12;
            // 
            // cmbForgeEffect5
            // 
            this.cmbForgeEffect5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect5.DropDownWidth = 100;
            this.cmbForgeEffect5.Location = new System.Drawing.Point(371, 46);
            this.cmbForgeEffect5.Name = "cmbForgeEffect5";
            this.cmbForgeEffect5.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect5.TabIndex = 13;
            // 
            // cmbForgeEffect6
            // 
            this.cmbForgeEffect6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect6.DropDownWidth = 100;
            this.cmbForgeEffect6.Location = new System.Drawing.Point(462, 46);
            this.cmbForgeEffect6.Name = "cmbForgeEffect6";
            this.cmbForgeEffect6.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect6.TabIndex = 35;
            // 
            // cmbForgeEffect7
            // 
            this.cmbForgeEffect7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect7.DropDownWidth = 100;
            this.cmbForgeEffect7.Location = new System.Drawing.Point(553, 46);
            this.cmbForgeEffect7.Name = "cmbForgeEffect7";
            this.cmbForgeEffect7.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect7.TabIndex = 36;
            // 
            // cmbForgeEffect8
            // 
            this.cmbForgeEffect8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect8.DropDownWidth = 100;
            this.cmbForgeEffect8.Location = new System.Drawing.Point(644, 46);
            this.cmbForgeEffect8.Name = "cmbForgeEffect8";
            this.cmbForgeEffect8.Size = new System.Drawing.Size(85, 21);
            this.cmbForgeEffect8.TabIndex = 37;
            // 
            // EffectEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(764, 142);
            this.Controls.Add(this.gbEffects);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EffectEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Effect Editor";
            this.gbEffects.ResumeLayout(false);
            this.gbEffects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbEffects;
        private System.Windows.Forms.TextBox txtNumForgeSlots;
        private System.Windows.Forms.Label lblNumForgeSlots;
        private System.Windows.Forms.ComboBox cmbForgeEffect1;
        private System.Windows.Forms.ComboBox cmbForgeEffect2;
        private System.Windows.Forms.ComboBox cmbForgeEffect3;
        private System.Windows.Forms.ComboBox cmbForgeEffect4;
        private System.Windows.Forms.ComboBox cmbForgeEffect5;
        private System.Windows.Forms.ComboBox cmbForgeEffect6;
        private System.Windows.Forms.ComboBox cmbForgeEffect7;
        private System.Windows.Forms.ComboBox cmbForgeEffect8;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItem;
    }
}