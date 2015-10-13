namespace EO4SaveEdit.Editors
{
    partial class StatsEditorDialog
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
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.txtLUC = new System.Windows.Forms.TextBox();
            this.txtAGI = new System.Windows.Forms.TextBox();
            this.txtVIT = new System.Windows.Forms.TextBox();
            this.txtTEC = new System.Windows.Forms.TextBox();
            this.txtSTR = new System.Windows.Forms.TextBox();
            this.txtMaxTP = new System.Windows.Forms.TextBox();
            this.txtMaxHP = new System.Windows.Forms.TextBox();
            this.lblMaxTP = new System.Windows.Forms.Label();
            this.lblMaxHP = new System.Windows.Forms.Label();
            this.lblLUC = new System.Windows.Forms.Label();
            this.lblAGI = new System.Windows.Forms.Label();
            this.lblVIT = new System.Windows.Forms.Label();
            this.lblTEC = new System.Windows.Forms.Label();
            this.lblSTR = new System.Windows.Forms.Label();
            this.gbStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(257, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbStats
            // 
            this.gbStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStats.Controls.Add(this.txtLUC);
            this.gbStats.Controls.Add(this.txtAGI);
            this.gbStats.Controls.Add(this.txtVIT);
            this.gbStats.Controls.Add(this.txtTEC);
            this.gbStats.Controls.Add(this.txtSTR);
            this.gbStats.Controls.Add(this.txtMaxTP);
            this.gbStats.Controls.Add(this.txtMaxHP);
            this.gbStats.Controls.Add(this.lblMaxTP);
            this.gbStats.Controls.Add(this.lblMaxHP);
            this.gbStats.Controls.Add(this.lblLUC);
            this.gbStats.Controls.Add(this.lblAGI);
            this.gbStats.Controls.Add(this.lblVIT);
            this.gbStats.Controls.Add(this.lblTEC);
            this.gbStats.Controls.Add(this.lblSTR);
            this.gbStats.Location = new System.Drawing.Point(12, 12);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(320, 129);
            this.gbStats.TabIndex = 1;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Stats";
            // 
            // txtLUC
            // 
            this.txtLUC.Location = new System.Drawing.Point(60, 97);
            this.txtLUC.Name = "txtLUC";
            this.txtLUC.Size = new System.Drawing.Size(80, 20);
            this.txtLUC.TabIndex = 13;
            // 
            // txtAGI
            // 
            this.txtAGI.Location = new System.Drawing.Point(234, 71);
            this.txtAGI.Name = "txtAGI";
            this.txtAGI.Size = new System.Drawing.Size(80, 20);
            this.txtAGI.TabIndex = 11;
            // 
            // txtVIT
            // 
            this.txtVIT.Location = new System.Drawing.Point(60, 71);
            this.txtVIT.Name = "txtVIT";
            this.txtVIT.Size = new System.Drawing.Size(80, 20);
            this.txtVIT.TabIndex = 9;
            // 
            // txtTEC
            // 
            this.txtTEC.Location = new System.Drawing.Point(234, 45);
            this.txtTEC.Name = "txtTEC";
            this.txtTEC.Size = new System.Drawing.Size(80, 20);
            this.txtTEC.TabIndex = 7;
            // 
            // txtSTR
            // 
            this.txtSTR.Location = new System.Drawing.Point(60, 45);
            this.txtSTR.Name = "txtSTR";
            this.txtSTR.Size = new System.Drawing.Size(80, 20);
            this.txtSTR.TabIndex = 5;
            // 
            // txtMaxTP
            // 
            this.txtMaxTP.Location = new System.Drawing.Point(234, 19);
            this.txtMaxTP.Name = "txtMaxTP";
            this.txtMaxTP.Size = new System.Drawing.Size(80, 20);
            this.txtMaxTP.TabIndex = 3;
            // 
            // txtMaxHP
            // 
            this.txtMaxHP.Location = new System.Drawing.Point(60, 19);
            this.txtMaxHP.Name = "txtMaxHP";
            this.txtMaxHP.Size = new System.Drawing.Size(80, 20);
            this.txtMaxHP.TabIndex = 1;
            // 
            // lblMaxTP
            // 
            this.lblMaxTP.AutoSize = true;
            this.lblMaxTP.Location = new System.Drawing.Point(181, 22);
            this.lblMaxTP.Name = "lblMaxTP";
            this.lblMaxTP.Size = new System.Drawing.Size(47, 13);
            this.lblMaxTP.TabIndex = 2;
            this.lblMaxTP.Text = "Max TP:";
            // 
            // lblMaxHP
            // 
            this.lblMaxHP.AutoSize = true;
            this.lblMaxHP.Location = new System.Drawing.Point(6, 22);
            this.lblMaxHP.Name = "lblMaxHP";
            this.lblMaxHP.Size = new System.Drawing.Size(48, 13);
            this.lblMaxHP.TabIndex = 0;
            this.lblMaxHP.Text = "Max HP:";
            // 
            // lblLUC
            // 
            this.lblLUC.AutoSize = true;
            this.lblLUC.Location = new System.Drawing.Point(6, 100);
            this.lblLUC.Name = "lblLUC";
            this.lblLUC.Size = new System.Drawing.Size(31, 13);
            this.lblLUC.TabIndex = 12;
            this.lblLUC.Text = "LUC:";
            // 
            // lblAGI
            // 
            this.lblAGI.AutoSize = true;
            this.lblAGI.Location = new System.Drawing.Point(181, 74);
            this.lblAGI.Name = "lblAGI";
            this.lblAGI.Size = new System.Drawing.Size(28, 13);
            this.lblAGI.TabIndex = 10;
            this.lblAGI.Text = "AGI:";
            // 
            // lblVIT
            // 
            this.lblVIT.AutoSize = true;
            this.lblVIT.Location = new System.Drawing.Point(6, 74);
            this.lblVIT.Name = "lblVIT";
            this.lblVIT.Size = new System.Drawing.Size(27, 13);
            this.lblVIT.TabIndex = 8;
            this.lblVIT.Text = "VIT:";
            // 
            // lblTEC
            // 
            this.lblTEC.AutoSize = true;
            this.lblTEC.Location = new System.Drawing.Point(181, 48);
            this.lblTEC.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.lblTEC.Name = "lblTEC";
            this.lblTEC.Size = new System.Drawing.Size(31, 13);
            this.lblTEC.TabIndex = 6;
            this.lblTEC.Text = "TEC:";
            // 
            // lblSTR
            // 
            this.lblSTR.AutoSize = true;
            this.lblSTR.Location = new System.Drawing.Point(6, 48);
            this.lblSTR.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(32, 13);
            this.lblSTR.TabIndex = 4;
            this.lblSTR.Text = "STR:";
            // 
            // StatsEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(344, 182);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatsEditorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character Stats Editor";
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.Label lblSTR;
        private System.Windows.Forms.Label lblMaxTP;
        private System.Windows.Forms.Label lblMaxHP;
        private System.Windows.Forms.Label lblLUC;
        private System.Windows.Forms.Label lblAGI;
        private System.Windows.Forms.Label lblVIT;
        private System.Windows.Forms.Label lblTEC;
        private System.Windows.Forms.TextBox txtMaxHP;
        private System.Windows.Forms.TextBox txtMaxTP;
        private System.Windows.Forms.TextBox txtLUC;
        private System.Windows.Forms.TextBox txtAGI;
        private System.Windows.Forms.TextBox txtVIT;
        private System.Windows.Forms.TextBox txtTEC;
        private System.Windows.Forms.TextBox txtSTR;
    }
}