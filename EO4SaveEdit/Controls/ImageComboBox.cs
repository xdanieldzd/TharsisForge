using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EO4SaveEdit.Controls
{
    public class ImageComboBox : ComboBox
    {
        public ImageList ImageList { get; set; }
        public int DropDownItemHeight { get; set; }

        StringFormat stringFormat;

        public ImageComboBox()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.DrawMode = DrawMode.OwnerDrawFixed;

            ImageList = new ImageList();
            DropDownItemHeight = -1;

            stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (DropDownItemHeight != -1)
                e.ItemHeight = DropDownItemHeight;
            else
                base.OnMeasureItem(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, (e.State ^ DrawItemState.Selected), e.ForeColor, e.ForeColor);

            e.DrawBackground();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    int imageWidth = (this.ImageList != null ? this.ImageList.ImageSize.Width : 0);

                    if (this.Items[e.Index] is ImageComboItem && this.ImageList != null)
                    {
                        ImageComboItem currentItem = (ImageComboItem)this.Items[e.Index];

                        if (currentItem.ImageIndex != -1 && currentItem.ImageIndex < this.ImageList.Images.Count)
                            this.ImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, currentItem.ImageIndex);

                        if (currentItem.Text != string.Empty)
                            e.Graphics.DrawString(currentItem.Text, e.Font, brush,
                                new RectangleF(e.Bounds.Left + imageWidth, e.Bounds.Top, e.Bounds.Width - imageWidth, e.Bounds.Height), stringFormat);
                    }
                    else
                        e.Graphics.DrawString(this.GetItemText(this.Items[e.Index]), e.Font, brush,
                            new RectangleF(e.Bounds.Left + imageWidth, e.Bounds.Top, e.Bounds.Width - imageWidth, e.Bounds.Height), stringFormat);
                }
            }

            e.DrawFocusRectangle();
        }
    }

    public class ImageComboItem
    {
        public string Text { get; set; }
        public int ImageIndex { get; set; }

        public ImageComboItem()
        {
            Text = null;
            ImageIndex = -1;
        }

        public ImageComboItem(string text, int imageIndex)
        {
            Text = text;
            ImageIndex = imageIndex;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
