using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class HeaderEditorDialog : Form
    {
        FileHeader fileHeader;

        public HeaderEditorDialog(FileHeader fileHeader)
        {
            InitializeComponent();

            this.fileHeader = fileHeader;

            cmbSignature.DataSource = FileHeader.ValidSignatures.ToList();
            cmbSignature.DataBindings.Add("SelectedItem", this.fileHeader, "Signature");
            dtpLastSavedDate.DataBindings.Add("Value", this.fileHeader.LastSavedTime, "DateTime");
            dtpLastSavedTime.DataBindings.Add("Value", this.fileHeader.LastSavedTime, "DateTime");
        }
    }
}
