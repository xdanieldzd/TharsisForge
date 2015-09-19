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
            this.txtNumForgeableSlots = new System.Windows.Forms.TextBox();
            this.lblNumForgeSlots = new System.Windows.Forms.Label();
            this.cmbForgeEffect1 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect2 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect3 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect4 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect5 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect6 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect7 = new System.Windows.Forms.ComboBox();
            this.cmbForgeEffect8 = new System.Windows.Forms.ComboBox();
            this.gbItemEffects = new System.Windows.Forms.GroupBox();
            this.gbItemEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(107, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNumForgeableSlots
            // 
            this.txtNumForgeableSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumForgeableSlots.Location = new System.Drawing.Point(129, 19);
            this.txtNumForgeableSlots.MaxLength = 9;
            this.txtNumForgeableSlots.Name = "txtNumForgeableSlots";
            this.txtNumForgeableSlots.Size = new System.Drawing.Size(30, 20);
            this.txtNumForgeableSlots.TabIndex = 4;
            this.txtNumForgeableSlots.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumForgeableSlots_Validating);
            // 
            // lblNumForgeSlots
            // 
            this.lblNumForgeSlots.AutoSize = true;
            this.lblNumForgeSlots.Location = new System.Drawing.Point(6, 22);
            this.lblNumForgeSlots.Name = "lblNumForgeSlots";
            this.lblNumForgeSlots.Size = new System.Drawing.Size(83, 13);
            this.lblNumForgeSlots.TabIndex = 3;
            this.lblNumForgeSlots.Text = "Forgeable Slots:\r\n";
            // 
            // cmbForgeEffect1
            // 
            this.cmbForgeEffect1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect1.DropDownWidth = 100;
            this.cmbForgeEffect1.Location = new System.Drawing.Point(9, 45);
            this.cmbForgeEffect1.Name = "cmbForgeEffect1";
            this.cmbForgeEffect1.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect1.TabIndex = 5;
            // 
            // cmbForgeEffect2
            // 
            this.cmbForgeEffect2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect2.DropDownWidth = 100;
            this.cmbForgeEffect2.Location = new System.Drawing.Point(9, 72);
            this.cmbForgeEffect2.Name = "cmbForgeEffect2";
            this.cmbForgeEffect2.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect2.TabIndex = 6;
            // 
            // cmbForgeEffect3
            // 
            this.cmbForgeEffect3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect3.DropDownWidth = 100;
            this.cmbForgeEffect3.Location = new System.Drawing.Point(9, 99);
            this.cmbForgeEffect3.Name = "cmbForgeEffect3";
            this.cmbForgeEffect3.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect3.TabIndex = 7;
            // 
            // cmbForgeEffect4
            // 
            this.cmbForgeEffect4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect4.DropDownWidth = 100;
            this.cmbForgeEffect4.Location = new System.Drawing.Point(9, 126);
            this.cmbForgeEffect4.Name = "cmbForgeEffect4";
            this.cmbForgeEffect4.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect4.TabIndex = 8;
            // 
            // cmbForgeEffect5
            // 
            this.cmbForgeEffect5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect5.DropDownWidth = 100;
            this.cmbForgeEffect5.Location = new System.Drawing.Point(9, 153);
            this.cmbForgeEffect5.Name = "cmbForgeEffect5";
            this.cmbForgeEffect5.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect5.TabIndex = 9;
            // 
            // cmbForgeEffect6
            // 
            this.cmbForgeEffect6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect6.DropDownWidth = 100;
            this.cmbForgeEffect6.Location = new System.Drawing.Point(9, 180);
            this.cmbForgeEffect6.Name = "cmbForgeEffect6";
            this.cmbForgeEffect6.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect6.TabIndex = 10;
            // 
            // cmbForgeEffect7
            // 
            this.cmbForgeEffect7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect7.DropDownWidth = 100;
            this.cmbForgeEffect7.Location = new System.Drawing.Point(9, 207);
            this.cmbForgeEffect7.Name = "cmbForgeEffect7";
            this.cmbForgeEffect7.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect7.TabIndex = 11;
            // 
            // cmbForgeEffect8
            // 
            this.cmbForgeEffect8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbForgeEffect8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForgeEffect8.DropDownWidth = 100;
            this.cmbForgeEffect8.Location = new System.Drawing.Point(9, 234);
            this.cmbForgeEffect8.Name = "cmbForgeEffect8";
            this.cmbForgeEffect8.Size = new System.Drawing.Size(150, 21);
            this.cmbForgeEffect8.TabIndex = 12;
            // 
            // gbItemEffects
            // 
            this.gbItemEffects.Controls.Add(this.lblNumForgeSlots);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect4);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect5);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect3);
            this.gbItemEffects.Controls.Add(this.txtNumForgeableSlots);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect6);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect1);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect2);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect7);
            this.gbItemEffects.Controls.Add(this.cmbForgeEffect8);
            this.gbItemEffects.Location = new System.Drawing.Point(12, 12);
            this.gbItemEffects.Name = "gbItemEffects";
            this.gbItemEffects.Size = new System.Drawing.Size(170, 265);
            this.gbItemEffects.TabIndex = 13;
            this.gbItemEffects.TabStop = false;
            this.gbItemEffects.Text = "---";
            // 
            // EffectEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(194, 318);
            this.Controls.Add(this.gbItemEffects);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EffectEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Effect Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EffectEditorDialog_FormClosing);
            this.gbItemEffects.ResumeLayout(false);
            this.gbItemEffects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNumForgeableSlots;
        private System.Windows.Forms.Label lblNumForgeSlots;
        private System.Windows.Forms.ComboBox cmbForgeEffect1;
        private System.Windows.Forms.ComboBox cmbForgeEffect2;
        private System.Windows.Forms.ComboBox cmbForgeEffect3;
        private System.Windows.Forms.ComboBox cmbForgeEffect4;
        private System.Windows.Forms.ComboBox cmbForgeEffect5;
        private System.Windows.Forms.ComboBox cmbForgeEffect6;
        private System.Windows.Forms.ComboBox cmbForgeEffect7;
        private System.Windows.Forms.ComboBox cmbForgeEffect8;
        private System.Windows.Forms.GroupBox gbItemEffects;
    }
}