using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public class MapIconPropertyGridEditor : UITypeEditor
    {
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            int margin = (e.Bounds.Width - e.Bounds.Height) / 2;
            Rectangle destRect = new Rectangle(e.Bounds.X + margin, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            e.Graphics.DrawImage(ImageHelper.MapIconsLarge, destRect, ImageHelper.GetMapIconRect((MapObjectType)e.Value, true), GraphicsUnit.Pixel);
        }
    }
}
