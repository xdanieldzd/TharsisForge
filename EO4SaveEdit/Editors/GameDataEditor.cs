using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class GameDataEditor : UserControl, IEditorControl
    {
        Mori4Game gameData;

        public GameDataEditor()
        {
            InitializeComponent();
        }

        public void Initialize(SaveDataHandler handler)
        {
            this.gameData = handler.GameDataFile;

            nudTimeYear.SetBinding("Value", gameData, "CurrentYear");
            cmbTimeMonth.DataSource = Mori4Game.MonthNames;
            cmbTimeMonth.SetBinding("SelectedIndex", gameData, "CurrentMonth");
            nudTimeDay.SetBinding("Value", gameData, "CurrentDay");
            nudBurstValue.SetBinding("Value", gameData, "BurstValue");
            lblBurstPointDisplay.SetBinding("Text", gameData, "BurstPoints");
            spbBurstGauge.SetBinding("Value", gameData, "BurstGauge");
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (gameData != null)
                e.Graphics.DrawString(string.Format("TEMP TEST:\n\nYear {0}, {1}\nBurst points {2}, gauge {3}\n\nFileheader, last saved: {4}",
                    gameData.CurrentYear, gameData.DayName, gameData.BurstPoints, gameData.BurstGauge, gameData.FileHeader.LastSavedTime.DateTime),
                    this.Font, SystemBrushes.WindowText, Point.Empty);
        }

        //
    }
}
