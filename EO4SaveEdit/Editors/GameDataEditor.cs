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

            if (this.Enabled = (this.gameData != null))
            {
                txtGuildName.SetBinding("Text", gameData, "GuildName");
                txtSkyshipName.SetBinding("Text", gameData, "SkyshipName");

                txtCurrentEn.SetBinding("Text", gameData, "CurrentEn");

                nudBurstValue.SetBinding("Value", gameData, "BurstValue");
                lblBurstPointDisplay.SetBinding("Text", gameData, "BurstPoints");
                spbBurstGauge.SetBinding("Value", gameData, "BurstGauge");

                nudTimeYear.SetBinding("Value", gameData, "CurrentYear");
                cmbTimeMonth.DataSource = Mori4Game.MonthNames;
                cmbTimeMonth.SetBinding("SelectedIndex", gameData, "CurrentMonth");
                nudTimeDay.SetBinding("Value", gameData, "CurrentDay");
            }
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
