namespace EO4SaveEdit.Editors
{
    partial class GameDataEditor
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
            this.nudTimeYear = new System.Windows.Forms.NumericUpDown();
            this.lblTimeYear = new System.Windows.Forms.Label();
            this.cmbTimeMonth = new System.Windows.Forms.ComboBox();
            this.lblTimeMonth = new System.Windows.Forms.Label();
            this.nudTimeDay = new System.Windows.Forms.NumericUpDown();
            this.lblTimeDay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBurstBurst = new System.Windows.Forms.Label();
            this.nudBurstValue = new System.Windows.Forms.NumericUpDown();
            this.lblBurstPointDisplay = new System.Windows.Forms.Label();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.gbBurst = new System.Windows.Forms.GroupBox();
            this.spbBurstGauge = new EO4SaveEdit.Controls.SimpleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstValue)).BeginInit();
            this.gbTime.SuspendLayout();
            this.gbBurst.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTimeYear
            // 
            this.nudTimeYear.Location = new System.Drawing.Point(56, 19);
            this.nudTimeYear.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.nudTimeYear.Name = "nudTimeYear";
            this.nudTimeYear.Size = new System.Drawing.Size(60, 20);
            this.nudTimeYear.TabIndex = 1;
            // 
            // lblTimeYear
            // 
            this.lblTimeYear.AutoSize = true;
            this.lblTimeYear.Location = new System.Drawing.Point(6, 21);
            this.lblTimeYear.Name = "lblTimeYear";
            this.lblTimeYear.Size = new System.Drawing.Size(32, 13);
            this.lblTimeYear.TabIndex = 2;
            this.lblTimeYear.Text = "Year:";
            this.lblTimeYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTimeMonth
            // 
            this.cmbTimeMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeMonth.FormattingEnabled = true;
            this.cmbTimeMonth.Location = new System.Drawing.Point(182, 19);
            this.cmbTimeMonth.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cmbTimeMonth.Name = "cmbTimeMonth";
            this.cmbTimeMonth.Size = new System.Drawing.Size(74, 21);
            this.cmbTimeMonth.TabIndex = 3;
            // 
            // lblTimeMonth
            // 
            this.lblTimeMonth.AutoSize = true;
            this.lblTimeMonth.Location = new System.Drawing.Point(136, 22);
            this.lblTimeMonth.Name = "lblTimeMonth";
            this.lblTimeMonth.Size = new System.Drawing.Size(40, 13);
            this.lblTimeMonth.TabIndex = 4;
            this.lblTimeMonth.Text = "Month:";
            this.lblTimeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTimeDay
            // 
            this.nudTimeDay.Location = new System.Drawing.Point(309, 19);
            this.nudTimeDay.Name = "nudTimeDay";
            this.nudTimeDay.Size = new System.Drawing.Size(60, 20);
            this.nudTimeDay.TabIndex = 5;
            // 
            // lblTimeDay
            // 
            this.lblTimeDay.AutoSize = true;
            this.lblTimeDay.Location = new System.Drawing.Point(274, 21);
            this.lblTimeDay.Name = "lblTimeDay";
            this.lblTimeDay.Size = new System.Drawing.Size(29, 13);
            this.lblTimeDay.TabIndex = 6;
            this.lblTimeDay.Text = "Day:";
            this.lblTimeDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(384, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 184);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblBurstBurst
            // 
            this.lblBurstBurst.AutoSize = true;
            this.lblBurstBurst.Location = new System.Drawing.Point(6, 21);
            this.lblBurstBurst.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblBurstBurst.Name = "lblBurstBurst";
            this.lblBurstBurst.Size = new System.Drawing.Size(37, 13);
            this.lblBurstBurst.TabIndex = 8;
            this.lblBurstBurst.Text = "Value:";
            // 
            // nudBurstValue
            // 
            this.nudBurstValue.Location = new System.Drawing.Point(56, 19);
            this.nudBurstValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBurstValue.Name = "nudBurstValue";
            this.nudBurstValue.Size = new System.Drawing.Size(80, 20);
            this.nudBurstValue.TabIndex = 9;
            // 
            // lblBurstPointDisplay
            // 
            this.lblBurstPointDisplay.AutoSize = true;
            this.lblBurstPointDisplay.Location = new System.Drawing.Point(197, 21);
            this.lblBurstPointDisplay.Name = "lblBurstPointDisplay";
            this.lblBurstPointDisplay.Size = new System.Drawing.Size(16, 13);
            this.lblBurstPointDisplay.TabIndex = 10;
            this.lblBurstPointDisplay.Text = "---";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.nudTimeYear);
            this.gbTime.Controls.Add(this.nudTimeDay);
            this.gbTime.Controls.Add(this.cmbTimeMonth);
            this.gbTime.Controls.Add(this.lblTimeYear);
            this.gbTime.Controls.Add(this.lblTimeDay);
            this.gbTime.Controls.Add(this.lblTimeMonth);
            this.gbTime.Location = new System.Drawing.Point(3, 3);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(375, 50);
            this.gbTime.TabIndex = 12;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // gbBurst
            // 
            this.gbBurst.Controls.Add(this.nudBurstValue);
            this.gbBurst.Controls.Add(this.lblBurstBurst);
            this.gbBurst.Controls.Add(this.spbBurstGauge);
            this.gbBurst.Controls.Add(this.lblBurstPointDisplay);
            this.gbBurst.Location = new System.Drawing.Point(3, 59);
            this.gbBurst.Name = "gbBurst";
            this.gbBurst.Size = new System.Drawing.Size(375, 50);
            this.gbBurst.TabIndex = 13;
            this.gbBurst.TabStop = false;
            this.gbBurst.Text = "Burst Gauge";
            // 
            // spbBurstGauge
            // 
            this.spbBurstGauge.ForeColor = System.Drawing.Color.Red;
            this.spbBurstGauge.Location = new System.Drawing.Point(219, 19);
            this.spbBurstGauge.Maximum = 99;
            this.spbBurstGauge.Name = "spbBurstGauge";
            this.spbBurstGauge.Size = new System.Drawing.Size(150, 20);
            this.spbBurstGauge.TabIndex = 11;
            // 
            // GameDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBurst);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameDataEditor";
            this.Size = new System.Drawing.Size(750, 450);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstValue)).EndInit();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.gbBurst.ResumeLayout(false);
            this.gbBurst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTimeYear;
        private System.Windows.Forms.Label lblTimeYear;
        private System.Windows.Forms.ComboBox cmbTimeMonth;
        private System.Windows.Forms.Label lblTimeMonth;
        private System.Windows.Forms.NumericUpDown nudTimeDay;
        private System.Windows.Forms.Label lblTimeDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBurstBurst;
        private System.Windows.Forms.NumericUpDown nudBurstValue;
        private System.Windows.Forms.Label lblBurstPointDisplay;
        private EO4SaveEdit.Controls.SimpleProgressBar spbBurstGauge;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.GroupBox gbBurst;
    }
}
