using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EO4SaveEdit.FileHandlers
{
    public partial class Mori4MapEditor : UserControl
    {
        const int tileSize = 16;

        Mori4Map mapData;
        Point tileHover;
        ToolTip tip;

        Dictionary<MapLayer, string> mapNameDict;
        MapLayer currentMap;

        public Mori4MapEditor()
        {
            InitializeComponent();
        }

        public void Initialize(Mori4Map map)
        {
            this.mapData = map;

            if (this.mapData == null)
            {
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            tileHover = Point.Empty;
            tip = new ToolTip();

            mapNameDict = new Dictionary<MapLayer, string>();
            mapNameDict.Add(this.mapData.MazeMaps[0], "Maze: Lush Woodlands B1F");
            mapNameDict.Add(this.mapData.MazeMaps[1], "Maze: Lush Woodlands B2F");
            mapNameDict.Add(this.mapData.MazeMaps[2], "Maze: Lush Woodlands B3F");
            mapNameDict.Add(this.mapData.MazeMaps[3], "Maze: Misty Ravine B1F");
            mapNameDict.Add(this.mapData.MazeMaps[4], "Maze: Misty Ravine B2F");
            mapNameDict.Add(this.mapData.MazeMaps[5], "Maze: Misty Ravine B3F");
            mapNameDict.Add(this.mapData.MazeMaps[6], "Maze: Golden Lair B1F");
            mapNameDict.Add(this.mapData.MazeMaps[7], "Maze: Golden Lair B2F");
            mapNameDict.Add(this.mapData.MazeMaps[8], "Maze: Golden Lair B3F");
            mapNameDict.Add(this.mapData.MazeMaps[9], "Maze: Echoing Library B1F");
            mapNameDict.Add(this.mapData.MazeMaps[10], "Maze: Echoing Library B2F");
            mapNameDict.Add(this.mapData.MazeMaps[11], "Maze: Echoing Library B3F");
            mapNameDict.Add(this.mapData.MazeMaps[12], "Maze: Forgotten Capital B1F");
            mapNameDict.Add(this.mapData.MazeMaps[13], "Maze: Hall of Darkness B1F");
            mapNameDict.Add(this.mapData.MazeMaps[14], "Maze: Hall of Darkness B2F");
            mapNameDict.Add(this.mapData.MazeMaps[15], "Maze: Hall of Darkness B3F");
            mapNameDict.Add(this.mapData.CaveMaps[0], "Cave: Old Forest Mine");
            mapNameDict.Add(this.mapData.CaveMaps[1], "Cave: Small Orchard");
            mapNameDict.Add(this.mapData.CaveMaps[2], "Cave: Valley Spring");
            mapNameDict.Add(this.mapData.CaveMaps[3], "Cave: Dense Bushland");
            mapNameDict.Add(this.mapData.CaveMaps[5], "Cave: Miasma Forest");   // v-- swapped
            mapNameDict.Add(this.mapData.CaveMaps[4], "Cave: Moth's Garden");   // ^-- in-game
            mapNameDict.Add(this.mapData.CaveMaps[6], "Cave: Noisy Marsh");
            mapNameDict.Add(this.mapData.CaveMaps[7], "Cave: Cramped Nest");
            mapNameDict.Add(this.mapData.CaveMaps[8], "Cave: Toxic Cave");
            mapNameDict.Add(this.mapData.CaveMaps[9], "Cave: Underground Lake");
            mapNameDict.Add(this.mapData.CaveMaps[10], "Cave: South Sanctuary");
            mapNameDict.Add(this.mapData.CaveMaps[11], "Cave: Windy Archive");
            mapNameDict.Add(this.mapData.CaveMaps[12], "Cave: Golden Deer Keep");

            cmbMaps.DataSource = new BindingSource(mapNameDict, null);
            cmbMaps.DisplayMember = "Value";
            cmbMaps.ValueMember = "Key";

            currentMap = this.mapData.MazeMaps[0];
        }

        private void pnlRender_Paint(object sender, PaintEventArgs e)
        {
            if (this.mapData == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            e.Graphics.Clear(Color.Gray);

            for (int y = 0; y < currentMap.TilesYX.GetLength(0); y++)
            {
                for (int x = 0; x < currentMap.TilesYX.GetLength(1); x++)
                {
                    MapTile tileData = (MapTile)currentMap.TilesYX[y, x];
                    Rectangle rect = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

                    if ((tileData & MapTile.FloorTypeMask) != MapTile.None)
                    {
                        Brush brush = Brushes.DarkSlateGray;
                        switch (tileData & MapTile.FloorTypeMask)
                        {
                            case MapTile.GreenFloor: brush = Brushes.DarkSeaGreen; break;
                            case MapTile.BlueFloor: brush = Brushes.DeepSkyBlue; break;
                            case MapTile.YellowFloor: brush = Brushes.Yellow; break;
                            case MapTile.OrangeFloor: brush = Brushes.Orange; break;
                        }

                        e.Graphics.FillRectangle(brush, rect);
                        //e.Graphics.DrawString(((int)tileData).ToString("X2"), SystemFonts.MessageBoxFont, Brushes.White, rect.X, rect.Y);
                    }
                }
            }

            for (int y = 0; y < currentMap.TilesYX.GetLength(0); y++)
            {
                for (int x = 0; x < currentMap.TilesYX.GetLength(1); x++)
                {
                    MapTile tileData = (MapTile)currentMap.TilesYX[y, x];
                    Rectangle rect = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

                    using (Pen p = new Pen(Color.DarkGreen, 4.0f))
                    {
                        if ((tileData & MapTile.SouthWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X, rect.Y + tileSize, rect.X + tileSize, rect.Y + tileSize);
                        }

                        if ((tileData & MapTile.EastWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X + tileSize, rect.Y, rect.X + tileSize, rect.Y + tileSize);
                        }
                    }
                }
            }

            foreach (MapObject mapObj in currentMap.Objects.Where(x => x.Type != 0))
            {
                using (Pen p = new Pen(Color.FromArgb(192, Color.Green), 3.0f))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(mapObj.XPosition * tileSize, mapObj.YPosition * tileSize, tileSize, tileSize));
                    e.Graphics.DrawString(((int)mapObj.Type).ToString("X2"), SystemFonts.MessageBoxFont, Brushes.White, mapObj.XPosition * tileSize, mapObj.YPosition * tileSize);
                }
            }

            foreach (MapNote mapNote in currentMap.Notes.Where(x => x.Description != string.Empty))
            {
                using (Pen p = new Pen(Color.FromArgb(192, Color.Red), 3.0f))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(mapNote.XPosition * tileSize, mapNote.YPosition * tileSize, tileSize, tileSize));
                }
            }
        }

        private void pnlRender_MouseMove(object sender, MouseEventArgs e)
        {
            Point newHover = new Point(e.X / tileSize, e.Y / tileSize);

            if (currentMap != null && tileHover != newHover && newHover.Y < currentMap.TilesYX.GetLength(0) && newHover.X < currentMap.TilesYX.GetLength(1))
            {
                tileHover = newHover;

                tip.ToolTipTitle = string.Format("Location X:{0} Y:{1}", tileHover.X, tileHover.Y);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Map tile: 0x{0:X2}\n", currentMap.TilesYX[tileHover.Y, tileHover.X]);

                foreach (MapObject mapObj in currentMap.Objects.Where(x => x.XPosition == tileHover.X && x.YPosition == tileHover.Y))
                {
                    sb.AppendFormat("Object #{0}: {1}\n", Array.IndexOf(currentMap.Objects, mapObj), mapObj.Type);
                }

                foreach (MapNote mapNote in currentMap.Notes.Where(x => x.XPosition == tileHover.X && x.YPosition == tileHover.Y))
                {
                    sb.AppendFormat("Note #{0}: {1}\n", Array.IndexOf(currentMap.Notes, mapNote), mapNote.Description);
                }

                tip.Show(sb.ToString(), (sender as PanelEx), e.X + 5, e.Y + 5, 2500);
            }
        }

        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMap = ((KeyValuePair<MapLayer, string>)(sender as ComboBox).SelectedItem).Key;
            pnlRender.Invalidate();
        }

        private void btnFileHeader_Click(object sender, EventArgs e)
        {
            if (mapData == null) return;

            FileHeaderDialog fhd = new FileHeaderDialog(mapData.FileHeader);
            if (fhd.ShowDialog() == DialogResult.OK)
            {
                mapData.FileHeader.Signature = fhd.Header.Signature;
            }
        }
    }
}
