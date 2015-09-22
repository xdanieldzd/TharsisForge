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
    public partial class GameDataEditor : UserControl
    {
        Mori4Game gameData;

        public GameDataEditor()
        {
            InitializeComponent();
        }

        public void Initialize(Mori4Game game)
        {
            this.gameData = game;

            if (this.gameData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            numericUpDown1.SetBinding("Value", gameData, "CurrentYear");
            comboBox1.DataSource = Mori4Game.MonthNames;
            comboBox1.SetBinding("SelectedIndex", gameData, "CurrentMonth");
            numericUpDown2.SetBinding("Value", gameData, "CurrentDay");
            numericUpDown3.SetBinding("Value", gameData, "BurstValue");
            label5.SetBinding("Text", gameData, "BurstPoints");
            simpleProgressBar1.SetBinding("Value", gameData, "BurstGauge");
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
