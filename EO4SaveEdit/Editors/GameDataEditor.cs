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

            //TEMP
            label1.Text = string.Format("TEMP TEST:\n\nYear {0}, {1}\nBurst level {2}, gauge {3}\n\nFileheader, last saved: {4}",
                gameData.CurrentYear, gameData.DayName, gameData.BurstGaugeLevel, gameData.BurstGaugeValue, gameData.FileHeader.LastSavedTime.DateTime);

            //
        }

        //
    }
}
