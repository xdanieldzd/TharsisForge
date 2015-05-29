namespace EO4SaveEdit
{
    partial class FileHeaderDialog
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimeUnknown4 = new System.Windows.Forms.TextBox();
            this.lblTimeUnknown4 = new System.Windows.Forms.Label();
            this.txtTimeUnknown3 = new System.Windows.Forms.TextBox();
            this.lblTimeUnknown3 = new System.Windows.Forms.Label();
            this.txtTimeSecond = new System.Windows.Forms.TextBox();
            this.lblTimeSecond = new System.Windows.Forms.Label();
            this.txtTimeMinute = new System.Windows.Forms.TextBox();
            this.lblTimeMinute = new System.Windows.Forms.Label();
            this.txtTimeHour = new System.Windows.Forms.TextBox();
            this.lblTimeHour = new System.Windows.Forms.Label();
            this.txtTimeUnknown2 = new System.Windows.Forms.TextBox();
            this.lblTimeUnknown2 = new System.Windows.Forms.Label();
            this.txtTimeDay = new System.Windows.Forms.TextBox();
            this.lblTimeDay = new System.Windows.Forms.Label();
            this.txtTimeMonth = new System.Windows.Forms.TextBox();
            this.lblTimeMonth = new System.Windows.Forms.Label();
            this.txtTimeUnknown1 = new System.Windows.Forms.TextBox();
            this.lblTimeUnknown1 = new System.Windows.Forms.Label();
            this.txtTimeYear = new System.Windows.Forms.TextBox();
            this.lblTimeYear = new System.Windows.Forms.Label();
            this.txtUnknown1 = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.lblUnknown1 = new System.Windows.Forms.Label();
            this.lblChunkSize = new System.Windows.Forms.Label();
            this.lblLastTimestamp = new System.Windows.Forms.Label();
            this.lblUnknown2 = new System.Windows.Forms.Label();
            this.txtChunkSize = new System.Windows.Forms.TextBox();
            this.txtUnknown2 = new System.Windows.Forms.TextBox();
            this.txtTimeReadable = new System.Windows.Forms.TextBox();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(383, 443);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.Controls.Add(this.txtTimeUnknown4, 2, 13);
            this.tlpHeader.Controls.Add(this.lblTimeUnknown4, 1, 13);
            this.tlpHeader.Controls.Add(this.txtTimeUnknown3, 2, 12);
            this.tlpHeader.Controls.Add(this.lblTimeUnknown3, 1, 12);
            this.tlpHeader.Controls.Add(this.txtTimeSecond, 2, 11);
            this.tlpHeader.Controls.Add(this.lblTimeSecond, 1, 11);
            this.tlpHeader.Controls.Add(this.txtTimeMinute, 2, 10);
            this.tlpHeader.Controls.Add(this.lblTimeMinute, 1, 10);
            this.tlpHeader.Controls.Add(this.txtTimeHour, 2, 9);
            this.tlpHeader.Controls.Add(this.lblTimeHour, 1, 9);
            this.tlpHeader.Controls.Add(this.txtTimeUnknown2, 2, 8);
            this.tlpHeader.Controls.Add(this.lblTimeUnknown2, 1, 8);
            this.tlpHeader.Controls.Add(this.txtTimeDay, 2, 7);
            this.tlpHeader.Controls.Add(this.lblTimeDay, 1, 7);
            this.tlpHeader.Controls.Add(this.txtTimeMonth, 2, 6);
            this.tlpHeader.Controls.Add(this.lblTimeMonth, 1, 6);
            this.tlpHeader.Controls.Add(this.txtTimeUnknown1, 2, 5);
            this.tlpHeader.Controls.Add(this.lblTimeUnknown1, 1, 5);
            this.tlpHeader.Controls.Add(this.txtTimeYear, 2, 4);
            this.tlpHeader.Controls.Add(this.lblTimeYear, 1, 4);
            this.tlpHeader.Controls.Add(this.txtUnknown1, 1, 1);
            this.tlpHeader.Controls.Add(this.lblSignature, 0, 0);
            this.tlpHeader.Controls.Add(this.txtSignature, 1, 0);
            this.tlpHeader.Controls.Add(this.lblUnknown1, 0, 1);
            this.tlpHeader.Controls.Add(this.lblChunkSize, 0, 2);
            this.tlpHeader.Controls.Add(this.lblLastTimestamp, 0, 3);
            this.tlpHeader.Controls.Add(this.lblUnknown2, 0, 14);
            this.tlpHeader.Controls.Add(this.txtChunkSize, 1, 2);
            this.tlpHeader.Controls.Add(this.txtUnknown2, 1, 14);
            this.tlpHeader.Controls.Add(this.txtTimeReadable, 1, 3);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 16;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(458, 434);
            this.tlpHeader.TabIndex = 5;
            // 
            // txtTimeUnknown4
            // 
            this.txtTimeUnknown4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeUnknown4.Location = new System.Drawing.Point(253, 341);
            this.txtTimeUnknown4.Name = "txtTimeUnknown4";
            this.txtTimeUnknown4.Size = new System.Drawing.Size(202, 20);
            this.txtTimeUnknown4.TabIndex = 27;
            // 
            // lblTimeUnknown4
            // 
            this.lblTimeUnknown4.AutoSize = true;
            this.lblTimeUnknown4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeUnknown4.Location = new System.Drawing.Point(153, 338);
            this.lblTimeUnknown4.Name = "lblTimeUnknown4";
            this.lblTimeUnknown4.Size = new System.Drawing.Size(94, 26);
            this.lblTimeUnknown4.TabIndex = 26;
            this.lblTimeUnknown4.Text = "Unknown 4:";
            this.lblTimeUnknown4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeUnknown3
            // 
            this.txtTimeUnknown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeUnknown3.Location = new System.Drawing.Point(253, 315);
            this.txtTimeUnknown3.Name = "txtTimeUnknown3";
            this.txtTimeUnknown3.Size = new System.Drawing.Size(202, 20);
            this.txtTimeUnknown3.TabIndex = 25;
            // 
            // lblTimeUnknown3
            // 
            this.lblTimeUnknown3.AutoSize = true;
            this.lblTimeUnknown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeUnknown3.Location = new System.Drawing.Point(153, 312);
            this.lblTimeUnknown3.Name = "lblTimeUnknown3";
            this.lblTimeUnknown3.Size = new System.Drawing.Size(94, 26);
            this.lblTimeUnknown3.TabIndex = 24;
            this.lblTimeUnknown3.Text = "Unknown 3:";
            this.lblTimeUnknown3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeSecond
            // 
            this.txtTimeSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeSecond.Location = new System.Drawing.Point(253, 289);
            this.txtTimeSecond.Name = "txtTimeSecond";
            this.txtTimeSecond.Size = new System.Drawing.Size(202, 20);
            this.txtTimeSecond.TabIndex = 23;
            // 
            // lblTimeSecond
            // 
            this.lblTimeSecond.AutoSize = true;
            this.lblTimeSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeSecond.Location = new System.Drawing.Point(153, 286);
            this.lblTimeSecond.Name = "lblTimeSecond";
            this.lblTimeSecond.Size = new System.Drawing.Size(94, 26);
            this.lblTimeSecond.TabIndex = 22;
            this.lblTimeSecond.Text = "Second:";
            this.lblTimeSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeMinute
            // 
            this.txtTimeMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeMinute.Location = new System.Drawing.Point(253, 263);
            this.txtTimeMinute.Name = "txtTimeMinute";
            this.txtTimeMinute.Size = new System.Drawing.Size(202, 20);
            this.txtTimeMinute.TabIndex = 21;
            // 
            // lblTimeMinute
            // 
            this.lblTimeMinute.AutoSize = true;
            this.lblTimeMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeMinute.Location = new System.Drawing.Point(153, 260);
            this.lblTimeMinute.Name = "lblTimeMinute";
            this.lblTimeMinute.Size = new System.Drawing.Size(94, 26);
            this.lblTimeMinute.TabIndex = 20;
            this.lblTimeMinute.Text = "Minute:";
            this.lblTimeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeHour
            // 
            this.txtTimeHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeHour.Location = new System.Drawing.Point(253, 237);
            this.txtTimeHour.Name = "txtTimeHour";
            this.txtTimeHour.Size = new System.Drawing.Size(202, 20);
            this.txtTimeHour.TabIndex = 19;
            // 
            // lblTimeHour
            // 
            this.lblTimeHour.AutoSize = true;
            this.lblTimeHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeHour.Location = new System.Drawing.Point(153, 234);
            this.lblTimeHour.Name = "lblTimeHour";
            this.lblTimeHour.Size = new System.Drawing.Size(94, 26);
            this.lblTimeHour.TabIndex = 18;
            this.lblTimeHour.Text = "Hour:";
            this.lblTimeHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeUnknown2
            // 
            this.txtTimeUnknown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeUnknown2.Location = new System.Drawing.Point(253, 211);
            this.txtTimeUnknown2.Name = "txtTimeUnknown2";
            this.txtTimeUnknown2.Size = new System.Drawing.Size(202, 20);
            this.txtTimeUnknown2.TabIndex = 17;
            // 
            // lblTimeUnknown2
            // 
            this.lblTimeUnknown2.AutoSize = true;
            this.lblTimeUnknown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeUnknown2.Location = new System.Drawing.Point(153, 208);
            this.lblTimeUnknown2.Name = "lblTimeUnknown2";
            this.lblTimeUnknown2.Size = new System.Drawing.Size(94, 26);
            this.lblTimeUnknown2.TabIndex = 16;
            this.lblTimeUnknown2.Text = "Unknown 2:";
            this.lblTimeUnknown2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeDay
            // 
            this.txtTimeDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeDay.Location = new System.Drawing.Point(253, 185);
            this.txtTimeDay.Name = "txtTimeDay";
            this.txtTimeDay.Size = new System.Drawing.Size(202, 20);
            this.txtTimeDay.TabIndex = 15;
            // 
            // lblTimeDay
            // 
            this.lblTimeDay.AutoSize = true;
            this.lblTimeDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeDay.Location = new System.Drawing.Point(153, 182);
            this.lblTimeDay.Name = "lblTimeDay";
            this.lblTimeDay.Size = new System.Drawing.Size(94, 26);
            this.lblTimeDay.TabIndex = 14;
            this.lblTimeDay.Text = "Day:";
            this.lblTimeDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeMonth
            // 
            this.txtTimeMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeMonth.Location = new System.Drawing.Point(253, 159);
            this.txtTimeMonth.Name = "txtTimeMonth";
            this.txtTimeMonth.Size = new System.Drawing.Size(202, 20);
            this.txtTimeMonth.TabIndex = 13;
            // 
            // lblTimeMonth
            // 
            this.lblTimeMonth.AutoSize = true;
            this.lblTimeMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeMonth.Location = new System.Drawing.Point(153, 156);
            this.lblTimeMonth.Name = "lblTimeMonth";
            this.lblTimeMonth.Size = new System.Drawing.Size(94, 26);
            this.lblTimeMonth.TabIndex = 12;
            this.lblTimeMonth.Text = "Month:";
            this.lblTimeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeUnknown1
            // 
            this.txtTimeUnknown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeUnknown1.Location = new System.Drawing.Point(253, 133);
            this.txtTimeUnknown1.Name = "txtTimeUnknown1";
            this.txtTimeUnknown1.Size = new System.Drawing.Size(202, 20);
            this.txtTimeUnknown1.TabIndex = 11;
            // 
            // lblTimeUnknown1
            // 
            this.lblTimeUnknown1.AutoSize = true;
            this.lblTimeUnknown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeUnknown1.Location = new System.Drawing.Point(153, 130);
            this.lblTimeUnknown1.Name = "lblTimeUnknown1";
            this.lblTimeUnknown1.Size = new System.Drawing.Size(94, 26);
            this.lblTimeUnknown1.TabIndex = 10;
            this.lblTimeUnknown1.Text = "Unknown 1:";
            this.lblTimeUnknown1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeYear
            // 
            this.txtTimeYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeYear.Location = new System.Drawing.Point(253, 107);
            this.txtTimeYear.Name = "txtTimeYear";
            this.txtTimeYear.Size = new System.Drawing.Size(202, 20);
            this.txtTimeYear.TabIndex = 9;
            // 
            // lblTimeYear
            // 
            this.lblTimeYear.AutoSize = true;
            this.lblTimeYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeYear.Location = new System.Drawing.Point(153, 104);
            this.lblTimeYear.Name = "lblTimeYear";
            this.lblTimeYear.Size = new System.Drawing.Size(94, 26);
            this.lblTimeYear.TabIndex = 8;
            this.lblTimeYear.Text = "Year:";
            this.lblTimeYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnknown1
            // 
            this.tlpHeader.SetColumnSpan(this.txtUnknown1, 2);
            this.txtUnknown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnknown1.Location = new System.Drawing.Point(153, 29);
            this.txtUnknown1.Name = "txtUnknown1";
            this.txtUnknown1.ReadOnly = true;
            this.txtUnknown1.Size = new System.Drawing.Size(302, 20);
            this.txtUnknown1.TabIndex = 3;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignature.Location = new System.Drawing.Point(3, 0);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(144, 26);
            this.lblSignature.TabIndex = 0;
            this.lblSignature.Text = "Signature:";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSignature
            // 
            this.tlpHeader.SetColumnSpan(this.txtSignature, 2);
            this.txtSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSignature.Location = new System.Drawing.Point(153, 3);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.ReadOnly = true;
            this.txtSignature.Size = new System.Drawing.Size(302, 20);
            this.txtSignature.TabIndex = 1;
            // 
            // lblUnknown1
            // 
            this.lblUnknown1.AutoSize = true;
            this.lblUnknown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnknown1.Location = new System.Drawing.Point(3, 26);
            this.lblUnknown1.Name = "lblUnknown1";
            this.lblUnknown1.Size = new System.Drawing.Size(144, 26);
            this.lblUnknown1.TabIndex = 2;
            this.lblUnknown1.Text = "Unknown 1:";
            this.lblUnknown1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChunkSize
            // 
            this.lblChunkSize.AutoSize = true;
            this.lblChunkSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChunkSize.Location = new System.Drawing.Point(3, 52);
            this.lblChunkSize.Name = "lblChunkSize";
            this.lblChunkSize.Size = new System.Drawing.Size(144, 26);
            this.lblChunkSize.TabIndex = 4;
            this.lblChunkSize.Text = "Chunk Size:";
            this.lblChunkSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastTimestamp
            // 
            this.lblLastTimestamp.AutoSize = true;
            this.lblLastTimestamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastTimestamp.Location = new System.Drawing.Point(3, 78);
            this.lblLastTimestamp.Name = "lblLastTimestamp";
            this.lblLastTimestamp.Size = new System.Drawing.Size(144, 26);
            this.lblLastTimestamp.TabIndex = 6;
            this.lblLastTimestamp.Text = "Last Saved Timestamp:";
            this.lblLastTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnknown2
            // 
            this.lblUnknown2.AutoSize = true;
            this.lblUnknown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnknown2.Location = new System.Drawing.Point(3, 364);
            this.lblUnknown2.Name = "lblUnknown2";
            this.lblUnknown2.Size = new System.Drawing.Size(144, 20);
            this.lblUnknown2.TabIndex = 28;
            this.lblUnknown2.Text = "Unknown 2:";
            this.lblUnknown2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChunkSize
            // 
            this.tlpHeader.SetColumnSpan(this.txtChunkSize, 2);
            this.txtChunkSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChunkSize.Location = new System.Drawing.Point(153, 55);
            this.txtChunkSize.Name = "txtChunkSize";
            this.txtChunkSize.ReadOnly = true;
            this.txtChunkSize.Size = new System.Drawing.Size(302, 20);
            this.txtChunkSize.TabIndex = 5;
            // 
            // txtUnknown2
            // 
            this.tlpHeader.SetColumnSpan(this.txtUnknown2, 2);
            this.txtUnknown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnknown2.Location = new System.Drawing.Point(153, 367);
            this.txtUnknown2.Name = "txtUnknown2";
            this.txtUnknown2.Size = new System.Drawing.Size(302, 20);
            this.txtUnknown2.TabIndex = 29;
            // 
            // txtTimeReadable
            // 
            this.tlpHeader.SetColumnSpan(this.txtTimeReadable, 2);
            this.txtTimeReadable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimeReadable.Location = new System.Drawing.Point(153, 81);
            this.txtTimeReadable.Name = "txtTimeReadable";
            this.txtTimeReadable.ReadOnly = true;
            this.txtTimeReadable.Size = new System.Drawing.Size(302, 20);
            this.txtTimeReadable.TabIndex = 7;
            // 
            // FileHeaderDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(464, 472);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tlpHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileHeaderDialog";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Header";
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TextBox txtTimeUnknown4;
        private System.Windows.Forms.Label lblTimeUnknown4;
        private System.Windows.Forms.TextBox txtTimeUnknown3;
        private System.Windows.Forms.Label lblTimeUnknown3;
        private System.Windows.Forms.TextBox txtTimeSecond;
        private System.Windows.Forms.Label lblTimeSecond;
        private System.Windows.Forms.TextBox txtTimeMinute;
        private System.Windows.Forms.Label lblTimeMinute;
        private System.Windows.Forms.TextBox txtTimeHour;
        private System.Windows.Forms.Label lblTimeHour;
        private System.Windows.Forms.TextBox txtTimeUnknown2;
        private System.Windows.Forms.Label lblTimeUnknown2;
        private System.Windows.Forms.TextBox txtTimeDay;
        private System.Windows.Forms.Label lblTimeDay;
        private System.Windows.Forms.TextBox txtTimeMonth;
        private System.Windows.Forms.Label lblTimeMonth;
        private System.Windows.Forms.TextBox txtTimeUnknown1;
        private System.Windows.Forms.Label lblTimeUnknown1;
        private System.Windows.Forms.TextBox txtTimeYear;
        private System.Windows.Forms.Label lblTimeYear;
        private System.Windows.Forms.TextBox txtUnknown1;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label lblUnknown1;
        private System.Windows.Forms.Label lblChunkSize;
        private System.Windows.Forms.Label lblLastTimestamp;
        private System.Windows.Forms.Label lblUnknown2;
        private System.Windows.Forms.TextBox txtChunkSize;
        private System.Windows.Forms.TextBox txtUnknown2;
        private System.Windows.Forms.TextBox txtTimeReadable;
    }
}