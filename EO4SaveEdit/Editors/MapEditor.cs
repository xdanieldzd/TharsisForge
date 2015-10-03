using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit.Editors
{
    public partial class MapEditor : UserControl
    {
        static readonly Color floorColorGreen = Color.FromArgb(16, 205, 115);
        static readonly Color floorColorBlue = Color.FromArgb(0, 139, 205);
        static readonly Color floorColorYellow = Color.FromArgb(246, 213, 0);
        static readonly Color floorColorOrange = Color.FromArgb(246, 123, 32);
        static readonly Color wallColor = Color.FromArgb(0, 74, 65);

        Mori4Map mapData;
        Point tileHover;
        ToolTip tip;

        int tileSize { get { return (Properties.Settings.Default.ZoomedMap ? ImageHelper.MapTileSizeLarge : ImageHelper.MapTileSizeSmall); } }
        Size renderSize { get { return (currentMap != null ? new Size(currentMap.TilesYX.GetLength(1) * tileSize, currentMap.TilesYX.GetLength(0) * tileSize) : Size.Empty); } }

        Dictionary<MapLayer, string> mapNameDict;
        MapLayer currentMap;
        IMapPlaceable currentPlaceable;

        public MapEditor()
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

            tileHover = new Point(-1, -1);
            tip = new ToolTip();

            chkZoomedMap.Checked = Properties.Settings.Default.ZoomedMap;

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

        public void AfterSaveUpdate()
        {
            pgMapPlaceable.Refresh();
        }

        private void pbRender_Paint(object sender, PaintEventArgs e)
        {
            if (this.mapData == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;

            e.Graphics.Clear(Color.Gray);

            for (int y = 0; y < currentMap.TilesYX.GetLength(0); y++)
            {
                for (int x = 0; x < currentMap.TilesYX.GetLength(1); x++)
                {
                    MapTile tileData = (MapTile)currentMap.TilesYX[y, x];
                    Rectangle rect = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

                    if ((tileData & MapTile.FloorTypeMask) != MapTile.None)
                    {
                        Color floorColor = Color.DarkSlateGray;
                        switch (tileData & MapTile.FloorTypeMask)
                        {
                            case MapTile.GreenFloor: floorColor = floorColorGreen; break;
                            case MapTile.BlueFloor: floorColor = floorColorBlue; break;
                            case MapTile.YellowFloor: floorColor = floorColorYellow; break;
                            case MapTile.OrangeFloor: floorColor = floorColorOrange; break;
                        }

                        using (SolidBrush brush = new SolidBrush(floorColor))
                        {
                            e.Graphics.FillRectangle(brush, rect);
                        }
                    }
                }
            }

            for (int y = 0; y < currentMap.TilesYX.GetLength(0); y++)
            {
                for (int x = 0; x < currentMap.TilesYX.GetLength(1); x++)
                {
                    MapTile tileData = (MapTile)currentMap.TilesYX[y, x];
                    Rectangle rect = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

                    using (Pen p = new Pen(wallColor, 4.0f))
                    {
                        if ((tileData & MapTile.SouthWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X - (p.Width / 2.0f), rect.Y + tileSize, rect.X + tileSize + (p.Width / 2.0f), rect.Y + tileSize);
                        }

                        if ((tileData & MapTile.EastWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X + tileSize, rect.Y - (p.Width / 2.0f), rect.X + tileSize, rect.Y + tileSize + (p.Width / 2.0f));
                        }
                    }
                }
            }

            foreach (MapObject mapObj in currentMap.Objects.Where(x => x.Type != MapObjectType.None))
            {
                e.Graphics.DrawImage((Properties.Settings.Default.ZoomedMap ? ImageHelper.MapIconsLarge : ImageHelper.MapIconsSmall),
                    new Rectangle(mapObj.XPosition * tileSize, mapObj.YPosition * tileSize, tileSize, tileSize),
                    ImageHelper.GetMapIconRect(mapObj.Type, Properties.Settings.Default.ZoomedMap),
                    GraphicsUnit.Pixel);
            }

            foreach (MapNote mapNote in currentMap.Notes.Where(x => x.Description != string.Empty))
            {
                e.Graphics.DrawImage((Properties.Settings.Default.ZoomedMap ? ImageHelper.MapIconsLarge : ImageHelper.MapIconsSmall),
                    new Rectangle(mapNote.XPosition * tileSize, mapNote.YPosition * tileSize, tileSize, tileSize),
                    ImageHelper.GetMapIconRect(MapObjectType.Note, Properties.Settings.Default.ZoomedMap),
                    GraphicsUnit.Pixel);
            }

            if (currentPlaceable != null)
            {
                using (Pen p = new Pen(Color.FromArgb(192, Color.Red), 2.0f))
                {
                    Point placeablePosition = currentPlaceable.GetPosition();
                    e.Graphics.DrawRectangle(p, new Rectangle(placeablePosition.X * tileSize, placeablePosition.Y * tileSize, tileSize, tileSize));
                }
            }
        }

        private void pbRender_MouseMove(object sender, MouseEventArgs e)
        {
            Point newHover = new Point(e.X / tileSize, e.Y / tileSize);

            if (currentMap != null && tileHover != newHover && newHover.Y < currentMap.TilesYX.GetLength(0) && newHover.X < currentMap.TilesYX.GetLength(1))
            {
                tileHover = newHover;

                tip.ToolTipTitle = string.Format("Location X:{0} Y:{1}", tileHover.X, tileHover.Y);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Map tile: 0x{0:X2}\n", currentMap.TilesYX[tileHover.Y, tileHover.X]);

                foreach (MapObject mapObj in currentMap.Objects.Where(x => x.Type != MapObjectType.None && x.XPosition == tileHover.X && x.YPosition == tileHover.Y))
                {
                    sb.AppendFormat("Object #{0}: {1}\n", Array.IndexOf(currentMap.Objects, mapObj) + 1, mapObj.Type);
                }

                foreach (MapNote mapNote in currentMap.Notes.Where(x => x.Description != string.Empty && x.XPosition == tileHover.X && x.YPosition == tileHover.Y))
                {
                    sb.AppendFormat("Note #{0}: {1}\n", Array.IndexOf(currentMap.Notes, mapNote) + 1, mapNote.Description);
                }

                tip.Show(sb.ToString(), (sender as Control), e.X + 5, e.Y + 5, 2500);
            }
        }

        private void pbRender_MouseLeave(object sender, EventArgs e)
        {
            if (tip != null) tip.Hide(sender as Control);
        }

        private void cmbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMap = ((KeyValuePair<MapLayer, string>)(sender as ComboBox).SelectedItem).Key;

            lbMapPlaceables.DataSource = currentMap.Objects.Cast<IMapPlaceable>().Concat(currentMap.Notes).ToList();

            pbRender.ClientSize = renderSize;
            pbRender.Invalidate();
        }

        private void btnFileHeader_Click(object sender, EventArgs e)
        {
            if (mapData == null) return;

            HeaderEditorDialog hed = new HeaderEditorDialog(mapData.FileHeader);
            hed.ShowDialog();
        }

        private void lbMapPlaceables_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.DesiredType == typeof(string))
            {
                IMapPlaceable placeable = (e.ListItem as IMapPlaceable);
                if (placeable is MapObject)
                {
                    MapObject mapObject = (placeable as MapObject);
                    e.Value = string.Format("Object #{0} (X:{1} Y:{2})", (Array.IndexOf(currentMap.Objects, mapObject) + 1), mapObject.XPosition, mapObject.YPosition);
                }
                else if (placeable is MapNote)
                {
                    MapNote mapNote = (placeable as MapNote);
                    e.Value = string.Format("Note #{0} (X:{1} Y:{2})", (Array.IndexOf(currentMap.Notes, mapNote) + 1), mapNote.XPosition, mapNote.YPosition);
                }
            }
        }

        private void lbMapPlaceables_SelectedValueChanged(object sender, EventArgs e)
        {
            currentPlaceable = ((sender as ListBox).SelectedItem as IMapPlaceable);
            pgMapPlaceable.SelectedObject = currentPlaceable;
            pbRender.Invalidate();
        }

        private void chkZoomedMap_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ZoomedMap = (sender as CheckBox).Checked;

            pbRender.ClientSize = renderSize;
            pbRender.Invalidate();
        }

        private void pgMapPlaceable_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (e.ChangedItem.PropertyDescriptor.Name == "Type" || e.ChangedItem.PropertyDescriptor.Name == "Description" ||
                e.ChangedItem.PropertyDescriptor.Name == "XPosition" || e.ChangedItem.PropertyDescriptor.Name == "YPosition")
            {
                lbMapPlaceables.Invalidate();
                pbRender.Invalidate();
            }
        }
    }
}
