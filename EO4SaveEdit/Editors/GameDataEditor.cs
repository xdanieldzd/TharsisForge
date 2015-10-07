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
#if !DEBUG
            pictureBox1.Visible = false;
#endif
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (gameData != null)
                e.Graphics.DrawString(string.Format("TEMP TEST:\n\nYear {0}, {1}\nBurst points {2}, gauge {3}\n\nFileheader, last saved: {4}",
                    gameData.CurrentYear, gameData.DayName, gameData.BurstPoints, gameData.BurstGauge, gameData.FileHeader.LastSavedTime.DateTime),
                    this.Font, SystemBrushes.WindowText, Point.Empty);
        }

        private void btnMaxBerundMaterials_Click(object sender, EventArgs e)
        {
            foreach (ItemAmount berundMaterialAmount in gameData.BerundMaterialAmounts)
                berundMaterialAmount.Amount = 99;
        }

        private void btnCompleteItemCompendium_Click(object sender, EventArgs e)
        {
            foreach (DictionaryUnlocks itemCompendiumUnlock in gameData.ItemCompendiumUnlocks)
                itemCompendiumUnlock.UnlockStatus = UnlockStatus.Unlocked;
        }

        private void btnCompleteMonstrousCodex_Click(object sender, EventArgs e)
        {
            foreach (DictionaryUnlocks monstrousCodexUnlock in gameData.MonstrousCodexUnlocks)
                monstrousCodexUnlock.UnlockStatus = UnlockStatus.Unlocked | UnlockStatus.UnlockedConditionalDrop;
        }
    }
}
