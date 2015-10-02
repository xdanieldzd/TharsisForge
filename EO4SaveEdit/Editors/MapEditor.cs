﻿using System;
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
                    Rectangle rect = new Rectangle(x * ImageHelper.MapTileSize, y * ImageHelper.MapTileSize, ImageHelper.MapTileSize, ImageHelper.MapTileSize);

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
                    Rectangle rect = new Rectangle(x * ImageHelper.MapTileSize, y * ImageHelper.MapTileSize, ImageHelper.MapTileSize, ImageHelper.MapTileSize);

                    using (Pen p = new Pen(wallColor, 4.0f))
                    {
                        if ((tileData & MapTile.SouthWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X - (p.Width / 2.0f), rect.Y + ImageHelper.MapTileSize, rect.X + ImageHelper.MapTileSize + (p.Width / 2.0f), rect.Y + ImageHelper.MapTileSize);
                        }

                        if ((tileData & MapTile.EastWallMask) != MapTile.None)
                        {
                            e.Graphics.DrawLine(p, rect.X + ImageHelper.MapTileSize, rect.Y - (p.Width / 2.0f), rect.X + ImageHelper.MapTileSize, rect.Y + ImageHelper.MapTileSize + (p.Width / 2.0f));
                        }
                    }
                }
            }

            foreach (MapObject mapObj in currentMap.Objects.Where(x => x.Type != MapObjectType.None))
            {
                e.Graphics.DrawImage(ImageHelper.MapIcons,
                    new Rectangle(mapObj.XPosition * ImageHelper.MapTileSize, mapObj.YPosition * ImageHelper.MapTileSize, ImageHelper.MapTileSize, ImageHelper.MapTileSize),
                    ImageHelper.GetMapIconRect(mapObj.Type),
                    GraphicsUnit.Pixel);
            }

            foreach (MapNote mapNote in currentMap.Notes.Where(x => x.Description != string.Empty))
            {
                e.Graphics.DrawImage(ImageHelper.MapIcons,
                    new Rectangle(mapNote.XPosition * ImageHelper.MapTileSize, mapNote.YPosition * ImageHelper.MapTileSize, ImageHelper.MapTileSize, ImageHelper.MapTileSize),
                    ImageHelper.GetMapIconRect(MapObjectType.Note),
                    GraphicsUnit.Pixel);
            }

            if (currentPlaceable != null)
            {
                using (Pen p = new Pen(Color.FromArgb(192, Color.Red), 2.0f))
                {
                    Point placeablePosition = currentPlaceable.GetPosition();
                    e.Graphics.DrawRectangle(p, new Rectangle(placeablePosition.X * ImageHelper.MapTileSize, placeablePosition.Y * ImageHelper.MapTileSize, ImageHelper.MapTileSize, ImageHelper.MapTileSize));
                }
            }
        }

        private void pbRender_MouseMove(object sender, MouseEventArgs e)
        {
            Point newHover = new Point(e.X / ImageHelper.MapTileSize, e.Y / ImageHelper.MapTileSize);

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

            pbRender.ClientSize = new System.Drawing.Size(currentMap.TilesYX.GetLength(1) * ImageHelper.MapTileSize, currentMap.TilesYX.GetLength(0) * ImageHelper.MapTileSize);
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
                    string description = mapObject.Type.ToString();
                    if (MapObject.ObjectDescriptions.ContainsKey(mapObject.Type))
                        description = MapObject.ObjectDescriptions[mapObject.Type];
                    e.Value = string.Format("O #{0} (X:{1} Y:{2}): {3}", (Array.IndexOf(currentMap.Objects, mapObject) + 1), mapObject.XPosition, mapObject.YPosition, description);
                }
                else if (placeable is MapNote)
                {
                    MapNote mapNote = (placeable as MapNote);
                    string note = (mapNote.Description == string.Empty ? "None" : mapNote.Description);
                    e.Value = string.Format("N #{0} (X:{1} Y:{2}): {3}", (Array.IndexOf(currentMap.Notes, mapNote) + 1), mapNote.XPosition, mapNote.YPosition, note);
                }
            }
        }

        private void lbMapPlaceables_SelectedValueChanged(object sender, EventArgs e)
        {
            currentPlaceable = ((sender as ListBox).SelectedItem as IMapPlaceable);
            pbRender.Invalidate();
        }
    }
}