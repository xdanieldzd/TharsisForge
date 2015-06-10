namespace EO4SaveEdit.Editors
{
    partial class HeaderEditorDialog
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
            this.lblLastSaved = new System.Windows.Forms.Label();
            this.dtpLastSavedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLastSavedTime = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSignature = new System.Windows.Forms.Label();
            this.cmbSignature = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLastSaved
            // 
            this.lblLastSaved.AutoSize = true;
            this.lblLastSaved.Location = new System.Drawing.Point(12, 42);
            this.lblLastSaved.Name = "lblLastSaved";
            this.lblLastSaved.Size = new System.Drawing.Size(64, 13);
            this.lblLastSaved.TabIndex = 2;
            this.lblLastSaved.Text = "Last Saved:";
            // 
            // dtpLastSavedDate
            // 
            this.dtpLastSavedDate.Checked = false;
            this.dtpLastSavedDate.CustomFormat = "";
            this.dtpLastSavedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastSavedDate.Location = new System.Drawing.Point(82, 39);
            this.dtpLastSavedDate.Name = "dtpLastSavedDate";
            this.dtpLastSavedDate.Size = new System.Drawing.Size(100, 20);
            this.dtpLastSavedDate.TabIndex = 3;
            // 
            // dtpLastSavedTime
            // 
            this.dtpLastSavedTime.CustomFormat = "";
            this.dtpLastSavedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLastSavedTime.Location = new System.Drawing.Point(192, 39);
            this.dtpLastSavedTime.Name = "dtpLastSavedTime";
            this.dtpLastSavedTime.ShowUpDown = true;
            this.dtpLastSavedTime.Size = new System.Drawing.Size(90, 20);
            this.dtpLastSavedTime.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(207, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(12, 15);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(55, 13);
            this.lblSignature.TabIndex = 0;
            this.lblSignature.Text = "Signature:";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSignature
            // 
            this.cmbSignature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignature.FormattingEnabled = true;
            this.cmbSignature.Location = new System.Drawing.Point(82, 12);
            this.cmbSignature.Name = "cmbSignature";
            this.cmbSignature.Size = new System.Drawing.Size(200, 21);
            this.cmbSignature.TabIndex = 1;
            // 
            // HeaderEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(294, 102);
            this.Controls.Add(this.cmbSignature);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpLastSavedTime);
            this.Controls.Add(this.dtpLastSavedDate);
            this.Controls.Add(this.lblLastSaved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeaderEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Header Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastSaved;
        private System.Windows.Forms.DateTimePicker dtpLastSavedDate;
        private System.Windows.Forms.DateTimePicker dtpLastSavedTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.ComboBox cmbSignature;
    }
}