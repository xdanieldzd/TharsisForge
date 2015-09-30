using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class StatsEditorDialog : Form
    {
        Stats stats;

        public StatsEditorDialog(Stats stats)
        {
            InitializeComponent();

            this.stats = stats;

            txtMaxHP.SetBinding("Text", this.stats, "HP");
            txtMaxTP.SetBinding("Text", this.stats, "TP");
            txtSTR.SetBinding("Text", this.stats, "STR");
            txtTEC.SetBinding("Text", this.stats, "TEC");
            txtVIT.SetBinding("Text", this.stats, "VIT");
            txtAGI.SetBinding("Text", this.stats, "AGI");
            txtLUC.SetBinding("Text", this.stats, "LUC");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
