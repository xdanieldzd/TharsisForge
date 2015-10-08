using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using EO4SaveEdit.Controls;
using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public static class ImageHelper
    {
        public static Dictionary<Class, ImageList> CharacterIcons { get; private set; }

        public static Bitmap MapIconsLarge { get; private set; }
        public static Bitmap MapIconsSmall { get; private set; }
        public static int MapTileSizeLarge { get; private set; }
        public static int MapTileSizeSmall { get; private set; }

        static ImageHelper()
        {
            CharacterIcons = new Dictionary<Class, ImageList>();
            foreach (Class charaClass in Enum.GetValues(typeof(Class)))
            {
                ImageList imageList = new ImageList();
                imageList.ColorDepth = ColorDepth.Depth32Bit;
                int fileClassId = (int)(charaClass + 1);

                if (charaClass == Class.None) continue;

                List<string> files = Directory.EnumerateFiles("Data\\CharaIcon", string.Format("{0:D2}_*.png", fileClassId))
                    .Concat(Directory.EnumerateFiles("Data\\CharaIcon", "11_*.png")).ToList();

                if (files.Count != 16) throw new Exception("Wrong number of character icons for class");

                for (int i = 0; i < files.Count; i++)
                {
                    Bitmap image = (Bitmap)Bitmap.FromFile(files[i]);
                    imageList.ImageSize = image.Size;
                    imageList.Images.Add(i.ToString(), image);
                }

                CharacterIcons.Add(charaClass, imageList);
            }

            MapIconsLarge = new Bitmap("Data\\MapIconsLarge.png");
            if (MapIconsLarge.Width / 16 != MapIconsLarge.Height / 16) throw new Exception("Unexpected map icon (large) image size");
            MapTileSizeLarge = (MapIconsLarge.Width / 16);

            MapIconsSmall = new Bitmap("Data\\MapIconsSmall.png");
            if (MapIconsSmall.Width / 16 != MapIconsSmall.Height / 16) throw new Exception("Unexpected map icon (small) image size");
            MapTileSizeSmall = (MapIconsSmall.Width / 16);
        }

        public static Rectangle GetMapIconRect(MapObjectType objType, bool zoomedMap)
        {
            int tileSize = (zoomedMap ? MapTileSizeLarge : MapTileSizeSmall);
            return new Rectangle(((byte)objType % 16) * tileSize, ((byte)objType / 16) * tileSize, tileSize, tileSize);
        }

        public static void InitializePortraitComboBox(ImageComboBox portraitComboBox, ComboBox classComboBox, object binding)
        {
            classComboBox.Tag = portraitComboBox;
            classComboBox.SelectedValueChanged += ((s, e) =>
            {
                ComboBox ccb = (s as ComboBox);
                ImageComboBox pcb = (ccb.Tag as ImageComboBox);
                RefreshPortraitComboBox(pcb, (Class)ccb.SelectedItem);
            });

            portraitComboBox.Items.Clear();
            for (int j = 0; j < 16; j++) portraitComboBox.Items.Add(new ImageComboItem(string.Empty, j));
            portraitComboBox.SetBinding("SelectedIndex", binding, "Portrait");

            RefreshPortraitComboBox(portraitComboBox, (Class)classComboBox.SelectedItem);
        }

        public static void RefreshPortraitComboBox(ImageComboBox portraitComboBox, Class charaClass)
        {
            if (ImageHelper.CharacterIcons.ContainsKey(charaClass))
            {
                portraitComboBox.Enabled = true;
                portraitComboBox.ImageList = ImageHelper.CharacterIcons[charaClass];
            }
            else
            {
                portraitComboBox.Enabled = false;
                portraitComboBox.ImageList = null;
            }

            portraitComboBox.Invalidate();
        }
    }
}
